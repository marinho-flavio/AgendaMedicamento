using SES.Core.Application.DTO.Attributes;
using System.Reflection;

namespace SES.Core.Application.DTO.Extensions
{
    public static class AttributesExtensions
    {
        public static object GetValueWithAttribute<T>(this object obj)
        {
            if (obj == null) return new Dictionary<string, object>();

            return obj
                .GetType()
                .GetProperties()
                .FirstOrDefault(x => x.CustomAttributes?.Any(p => p.AttributeType == typeof(T)) == true)
                ?.GetValue(obj);
        }

        public static PropertyInfo GetFieldInfoByWithAttribute<T>(this object obj)
        {
            if (obj == null) return null;

            return obj
                .GetType()
                .GetProperties()
                .FirstOrDefault(x => x.CustomAttributes?.Any(p => p.AttributeType == typeof(T)) == true);
        }
    }
}
