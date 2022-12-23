

using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using SES.Core.Application.DTO.Attributes;

namespace SES.Users.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	public partial class EmpresaDTO : EntityDTO
	{
	}
}
namespace SES.Users.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UsersAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
	public partial class UserDTO : EntityDTO
	{
	    public  int? EmpresaId { get; set; }
	    public SES.Users.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new SES.Users.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
}
