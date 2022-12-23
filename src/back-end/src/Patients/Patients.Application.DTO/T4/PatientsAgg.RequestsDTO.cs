

using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bravo.Core.Application.DTO.Attributes;

namespace Bravo.Patients.Application.DTO.Aggregates.PatientsAgg.Requests 
{
	public partial class PacienteDTO : EntityDTO
	{
	    [DisplayOnList(0)] public  string Tipo { get; set; }
	}
	public partial class PatientsAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
}
namespace Bravo.Patients.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	}
}
