using SES.Core.Application.DTO.Aggregates.CommonAgg.ValueObjects;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SES.CrossCuting.Infra.Utils.Extensions
{
    public static class ObjectExtensions
    {
        public static IEnumerable<PropertyDescriptor> ExtractProperties(this object item)
        {
            var result = new List<PropertyDescriptor>();
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(item))
            {
                result.Add(descriptor);
            }
            return result;
        }

        public static T Update<T, K>(this T item, K other, params string[] namesToIgnore)
            where T : class
            where K : class
        {
            var fis = FillFields(item?.GetType());
            var fis2 = FillFields(other?.GetType());

            // object tempMyClass = item == null ? null : Activator.CreateInstance(item?.GetType()); -> IF CLONE
            foreach (FieldInfo fi in fis)
            {
                var name = fi.Name.Contains("<") ? fi.Name.Substring(fi.Name.IndexOf('<') + 1, fi.Name.IndexOf('>') - 1) : fi.Name;
                if (namesToIgnore.Any(x => name.EndsWith(x) == true)) continue;

                if (fi.FieldType.Namespace != item.GetType().Namespace)
                {
                    var otherVal = fis2.FirstOrDefault(x => x.Name == fi.Name)?.GetValue(other);
                    if (otherVal is null) continue;

                    var myVal = fi.GetValue(item);
                    if (myVal != otherVal)
                    {
                        otherVal = otherVal is Guid && (Guid)otherVal == Guid.Empty || otherVal == null ? null : otherVal;

                        fi.SetValue(item, otherVal ?? myVal);
                    }
                }
                else
                {
                    object obj = fi.GetValue(item);
                    object otherObj = fis2.FirstOrDefault(x => x.Name == fi.Name)?.GetValue(other);

                    if (otherObj != null)
                        obj.Update(otherObj, namesToIgnore);
                }
            }
            return item;
        }


        public static T SetValue<T>(this T item, KeyValuePair<string, object> val)
        {
            List<FieldInfo> fis = new List<FieldInfo>();
            FillFields(item?.GetType(), fis);

            if (val.Key.Contains("."))
            {
                var spplited = val.Key.Split(".");
                var myKey = string.Join(".", spplited.Skip(1));
                var myField = fis.FirstOrDefault(x => x.FieldType.Name.Equals(spplited[0], StringComparison.InvariantCultureIgnoreCase));
                if (myField == null) throw new Exception("Field not found");
                object otherObj = fis.FirstOrDefault(x => x.FieldType.Name == myField.FieldType.Name).GetValue(item);
                otherObj.SetValue(new KeyValuePair<string, object>(myKey, val.Value));
                return item;
            }

            // object tempMyClass = item == null ? null : Activator.CreateInstance(item?.GetType()); -> IF CLONE
            foreach (FieldInfo fi in fis)
            {
                var name = fi.Name.Substring(fi.Name.IndexOf('<') + 1, fi.Name.IndexOf('>') - 1);
                if (!name.Equals(val.Key, StringComparison.InvariantCultureIgnoreCase)) continue;

                if (fi.FieldType.Namespace != item.GetType().Namespace)
                {
                    var myVal = fi.GetValue(item);
                    if (myVal != val.Value)
                    {
                        var otherVal = val.Value is Guid && (Guid)val.Value == Guid.Empty || val.Value == null ? null : val.Value;
                        if (string.IsNullOrWhiteSpace(otherVal.ToString())) continue;

                        if (fi.FieldType == typeof(DateTime) || fi.FieldType == typeof(DateTime?))
                            otherVal = DateTime.Parse(otherVal.ToString());
                        else if (fi.FieldType == typeof(string))
                            otherVal = otherVal.ToString();
                        else if (fi.FieldType == typeof(bool))
                            otherVal = bool.Parse(otherVal.ToString());
                        else if (fi.FieldType == typeof(int) || fi.FieldType == typeof(int?))
                            otherVal = int.Parse(otherVal.ToString());

                        fi.SetValue(item, otherVal ?? myVal);
                        return item;
                    }
                }
                //else
                //{
                //    object obj = fi.GetValue(item);
                //    object otherObj = fis2.FirstOrDefault(x => x.Name == fi.Name).GetValue(other);
                //    fi.SetValue(item, obj.Update(otherObj));
                //}
            }
            return item;
        }
        
        public static List<FieldInfo> FillFields(this Type t)
        {
            List<FieldInfo> fis = new List<FieldInfo>();
            FillFields(t, fis);
            return fis;
        }

        private static void FillFields(Type t, List<FieldInfo> fis)
        {
            if (t != null)
            {
                if (t.BaseType != null)
                    FillFields(t.BaseType, fis);

                fis.AddRange(t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty) ?? new FieldInfo[0]);
            }
        }

        public static bool IsEmpty(this object obj)
        {
            return obj is null || JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }) == "{}";
        }


        private static void ExtractProperties(this object obj, List<FieldInfo> fis)
        {
            var t = obj.GetType();
            if (t != null)
            {
                fis.AddRange(t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty) ?? new FieldInfo[0]);
            }
        }

        public class CollapseTitle : Attribute
        {
        }
        public static SortedDictionary<string, object> ExtractValues(this object item, SortedDictionary<string, object> result = null)
        {
            result = result ?? new SortedDictionary<string, object>();
            if (item is Array)
            {
                var i = 0;
                foreach (var subObject in item as Array)
                {
                    var prop = subObject.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(CollapseTitle)))?
                        .FirstOrDefault();

                    var propName = prop?.GetValue(subObject)?.ToString() ?? $"{item.GetType().Name.Replace("[]", $"[{i++}]")}";

                    result.Add(propName, subObject.ExtractValues());
                }
            }
            else
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(item))
                {
                    if (descriptor.Attributes.OfType<CollapseTitle>().Any())
                        continue;

                    string name = descriptor.DisplayName ?? descriptor.Name;
                    object value = descriptor.GetValue(item);
                    {
                        if (value is Array)
                        {
                            foreach (var val in value as Array)
                            {
                                if (val is string)
                                {
                                    result[name] = val.ToString();
                                }
                                else
                                {
                                    if (result.ContainsKey(name))
                                        result.Add(name, val.ExtractValues());
                                    else
                                        result[name] = val.ExtractValues();
                                }
                            }
                        }
                        else
                        {
                            result[name] = value == null ? null : (descriptor.DisplayName ?? value.ToString());
                        }
                    }
                }
            }
            return result;
        }

        static void PrintProperties(object obj, List<PropertyDetails> props)
        {
            if (obj == null) return;
            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object propValue = property.GetValue(obj, null);
                var elems = propValue as Array;
                if (elems != null)
                {
                    foreach (var item in elems)
                    {
                        PrintProperties(item, props);
                    }
                }
                else
                {
                    // This will not cut-off System.Collections because of the first check
                    if (property.PropertyType.Assembly == objType.Assembly)
                    {
                        //Console.WriteLine("{0}{1}:", indentString, property.Name);

                        PrintProperties(propValue, props);
                    }
                    else
                    {
                        props.Add(new PropertyDetails(property, propValue));
                        //Console.WriteLine("{0}{1}: {2}", property.Name, propValue);
                    }
                }
            }
        }

        public static List<PropertyDetails> ExtractPropertyInfos(this object obj, params string[] attrs)
        {
            List<PropertyDetails> props = new List<PropertyDetails>();

            PrintProperties(obj, props);
            if (attrs?.Any() == true)
                props = (props.Where(x => x.info.CustomAttributes.Any(x => attrs.Contains(x.AttributeType.Name)))).ToList();
            return props;
        }

        public static bool ContainsBase<T>(this Type t)
        {
            if (t.BaseType == null)
                return false;
            else if (t.BaseType.BaseType != null && t.BaseType.BaseType.FullName != "System.Object")
                return t.BaseType.ContainsBase<T>();
            else
                return t.BaseType.Name.Contains(nameof(T));
        }

        public static bool HasChanged<T>(this T obj1, T obj2)
            where T : class
        {
            obj1 = obj1 ?? throw new NullReferenceException(nameof(obj1));
            obj2 = obj2 ?? throw new NullReferenceException(nameof(obj2));

            var fis = FillFields(obj1?.GetType());
            var fis2 = FillFields(obj2?.GetType());

            return fis.Any(x => fis2.FirstOrDefault(k => k.Name.Equals(x.Name)).GetValue(obj2) != x.GetValue(obj1));
        }

        public static List<PropertyDescriptor> FetchProperties(this object obj)
        {
            var list = new List<PropertyDescriptor>();

            var props = obj?.GetType().GetProperties();
            foreach (var item in props)
            {
                if (item.PropertyType.IsClass
                    && item.PropertyType.Assembly.FullName == obj.GetType().Assembly.FullName)
                {
                    list.AddRange(DisplayObjectRecursive(obj, list));
                    if (item.Name.Contains("Entity")) break;
                }
            }
            return list;
        }

        public static List<PropertyDescriptor> DisplayObjectRecursive(object obj, List<PropertyDescriptor> list)
        {
            var type = obj.GetType();
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(type))
            {
                if (descriptor.PropertyType.IsClass
                    && descriptor.PropertyType.Assembly.FullName == type.Assembly.FullName)
                {
                    //var value = descriptor.GetValue(obj);
                    //DisplayObjectRecursive(value, list);
                }
                else
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(obj);
                    list.Add(descriptor);
                }
                if (type.Name == "Entity") break;
            }
            return list;
        }

    }
}
