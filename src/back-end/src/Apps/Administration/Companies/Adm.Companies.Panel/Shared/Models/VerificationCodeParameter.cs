using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Companies.Adm.Panel.Shared.Models
{
    public class VerificationCodeParameter
    {
        [Required]
        [DisplayName("CPF")]
        public string Username { get; set; }

        [Required]
        [DisplayName("CPF")]
        public string VerificationCode { get; set; }

        [Required]
        [DisplayName("E-Mail")]
        public string Email { get; set; }
    }
}
