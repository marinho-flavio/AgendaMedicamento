using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Patients.Application.DTO.Aggregates.PatientsAgg.Requests 
{
	using Requests;
    public partial class PacienteListiningDTO : EntityDTO
	{
        [DisplayOnList(0)] public  string Tipo { get; set; }
    }
    public partial class PatientsAggSettingsListiningDTO : EntityDTO
	{
        
    }
}
namespace Bravo.Patients.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
}
