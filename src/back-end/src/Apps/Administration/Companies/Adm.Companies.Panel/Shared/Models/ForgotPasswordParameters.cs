using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Companies.Adm.Panel.Shared.Models
{
    public class ForgotPasswordParameters
    {
        [Required]
        [DisplayName("CPF")]
        public string Username { get; set; }
    }
}
