using SES.Core.Application.DTO.Attributes;
using SES.Core.Application.DTO.Extensions;
using FluentValidation.Results;
using MediatR;
using System.ComponentModel;
using System.Reflection;

namespace SES.Core.Application.DTO.Aggregates.CommonAgg.Models
{
    public interface IEntityDTO
    {
        public IRequest<ValidationResult> Command { get; set; }
        public string Title { get; }
        public string SubTitle { get; }
        public string DisplayNameTitle { get; }
        public string DisplayNameSubTitle { get; }
        public string Id { get; set; }
        public string ExternalId { get; set; }
        public string[] FieldsToValidate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CurrentStep { get; set; }

        public string GetRoute();
        public string GetSearchRoute();
        public string GetSelectRoute();
        public string GetSummaryRoute();
    }

    public class EntityDTO : IEntityDTO
    {
        public IRequest<ValidationResult> Command { get; set; }
        public string Id { get; set; }
        public string ExternalId { get; set; }
        public string[] FieldsToValidate { get; set; } = new string[0];
        public DateTime? CreatedAt { get; set; }
        public int CurrentStep { get; set; }

        public virtual string GetRoute()
        {
            return $"api/{GetMyTypeName()}";
        }

        public virtual string GetSearchRoute()
        {
            return $"{GetRoute()}/search";
        }
        public virtual string GetSelectRoute()
        {
            return $"{GetRoute()}/select";
        }
        public virtual string GetSummaryRoute()
        {
            return $"{GetRoute()}/summary";
        }

        public virtual string GetMyTypeName()
        {
            var type = GetType().Name;
            var route = type.Replace("[]", "").Replace("DTO", "").Replace("Listining", "");
            if (route.StartsWith("Base"))
                route = route.Substring("Base".Length - 1);
            return $"{route}";
            //return $"{route}?id={ExternalId}";
        }

        public string GetFieldPlaceholder(string col)
        {
            MemberInfo property = this.GetType().GetProperty(col);
            if (property == null) return null;

            var dd = property.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;

            return dd?.DisplayName ?? property.Name;
        }

        public string GetFieldPlaceholder(PropertyInfo property)
        {
            if (property == null) return null;

            var dd = property.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;

            return dd?.DisplayName ?? property.Name;
        }

        public string Title
        {
            get
            {
                var val = this.GetValueWithAttribute<Title>()?.ToString();
                if (string.IsNullOrWhiteSpace(val))
                {
                    var property = this.GetFieldInfoByWithAttribute<DisplayNameAttribute>();
                    val = property?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "Título";
                }
                return val;
            }
        }

        public string SubTitle
        {
            get
            {
                var val = this.GetValueWithAttribute<Subtitle>()?.ToString();
                if (string.IsNullOrWhiteSpace(val))
                {
                    var property = this.GetFieldInfoByWithAttribute<DisplayNameAttribute>();
                    val = property?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "SubTítulo";
                }
                return val;
            }
        }

        public string DisplayNameTitle
        {
            get
            {
                var property = this.GetFieldInfoByWithAttribute<Title>();
                var test = property?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "Título";
                return property?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "Título";
            }
        }

        public string DisplayNameSubTitle
        {
            get
            {
                var property = this.GetFieldInfoByWithAttribute<Subtitle>();
                return property?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "SubTítulo";
            }
        }
    }
}
