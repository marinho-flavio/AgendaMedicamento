using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Professionals.Domain.Aggregates.CommonAgg.ValueObjects
{
    public class ImageFileInfo
    {
        [Required, IgnorePropertyT4]
        public string? Name { get; set; }
        [Required, RegisterOrder(0), IgnorePropertyT4]
        public byte[]? Image { get; set; }
    }
}
