

using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using SES.Core.Application.DTO.Attributes;

namespace SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	public partial class EmpresaDTO : EntityDTO
	{
	}
}
namespace SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests 
{
	public partial class SchedulingsAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
	public partial class FeriadoDTO : ActivableEntityDTO
	{
	    [DisplayName("Nome do Feriado"),Title] public  string Descricao { get; set; }
	    [DisplayOnList(0),Subtitle] public  System.DateOnly Data { get; set; }
	    [DisplayOnList(0),DisplayName("Tipo do Feriado")] public  SES.Schedulings.Enumerations.HolidayType Tipo { get; set; }
	    public  string UserId { get; set; }
	    public  int EmpresaId { get; set; }
	}
}
namespace SES.Schedulings.Application.DTO.Aggregates.ProfessionalsAgg.Requests 
{
	public partial class ProfissionalDTO : EntityDTO
	{
	}
}
namespace SES.Schedulings.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	    public  int? EmpresaId { get; set; }
	    public SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
}
namespace SES.Schedulings.Application.DTO.Aggregates.PartnersAgg.Requests 
{
	public partial class FornecedorDTO : EntityDTO
	{
	    [DisplayOnList(1)] public  string Nome { get; set; }
	    public SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
	public partial class PublicitarioDTO : EntityDTO
	{
	    public  string Nome { get; set; }
	    public  int? Tipo { get; set; }
	    public  int FornecedorId { get; set; }
	    public SES.Schedulings.Application.DTO.Aggregates.PartnersAgg.Requests.FornecedorDTO Fornecedor { get; set; } = new SES.Schedulings.Application.DTO.Aggregates.PartnersAgg.Requests.FornecedorDTO();
	    public  int? TipoValorRepasse { get; set; }
	    public SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
}
