

using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bravo.Core.Application.DTO.Attributes;

namespace Bravo.ClinicalProcedures.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	}
}
namespace Bravo.ClinicalProcedures.Application.DTO.Aggregates.ClinicalProceduresAgg.Requests 
{
	public partial class ClinicalProceduresAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
}
