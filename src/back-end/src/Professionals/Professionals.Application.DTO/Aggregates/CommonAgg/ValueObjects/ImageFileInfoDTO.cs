using Bravo.Core.Application.DTO.Aggregates.CommonAgg.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Professionals.Application.DTO.Aggregates.CommonAgg.ValueObjects
{
    public class ImageFileInfoDTO : IImageFileInfoDTO
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public byte[] Image { get; set; }

        public string Src
        {
            get
            {
                if (Image == null) return null;
                try
                {
                    return string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(Image));
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
