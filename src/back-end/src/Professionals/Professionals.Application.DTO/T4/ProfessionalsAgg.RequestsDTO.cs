

using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bravo.Core.Application.DTO.Attributes;

namespace Bravo.Professionals.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	public partial class EmpresaDTO : EntityDTO
	{
	}
}
namespace Bravo.Professionals.Application.DTO.Aggregates.SchedulingsAgg.Requests 
{
	public partial class SchedulingsAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
	public partial class AgendaExameDTO : BaseConfiguracaoAgendaDTO
	{
	}
	public partial class AgendaSalaDTO : BaseConfiguracaoAgendaDTO
	{
	}
	public partial class FeriadoDTO : ActivableEntityDTO
	{
	    [DisplayOnList(0),DisplayName("Nome do Feriado"),Title] public  string Descricao { get; set; }
	    [DisplayOnList(0)] public  System.DateOnly Data { get; set; }
	    [DisplayOnList(0),DisplayName("Tipo do Feriado"),Subtitle] public  Bravo.Schedulings.Enumerations.HolidayType Tipo { get; set; }
	    public  string UserId { get; set; }
	    public  int EmpresaId { get; set; }
	}
	public partial class AgendaProfissionalDTO : BaseConfiguracaoAgendaDTO
	{
	    public  string ProfissionalId { get; set; }
	    public Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalDTO Profissional { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalDTO();
	}
}
namespace Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests 
{
	public partial class ProfissionalConfiguracaoDTO : EntityDTO
	{
	    public Bravo.Professionals.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO Logo { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO();
	    [DisplayName("Setor Próprio")] public  bool? SetorProprio { get; set; }
	}
	public partial class FuncionarioDTO : BaseFuncionarioDTO
	{
	    public Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.CboDTO Cbo { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.CboDTO();
	    public Bravo.Professionals.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
	public partial class ProfissionalDTO : BaseFuncionarioDTO
	{
	    public Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.CboDTO Cbo { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.CboDTO();
	    public Bravo.Professionals.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	    public Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalConfiguracaoDTO ProfissionalConfiguracao { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalConfiguracaoDTO();
	    public Bravo.Professionals.Application.DTO.Aggregates.SchedulingsAgg.Requests.AgendaProfissionalDTO[] AgendaProfissionalAgenda { get; set; } = new Bravo.Professionals.Application.DTO.Aggregates.SchedulingsAgg.Requests.AgendaProfissionalDTO[0];
	}
	public partial class ProfessionalsAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
	public partial class CboDTO : EntityDTO
	{
	    [DisplayOnList(0),Title] public  string Codigo { get; set; }
	    [DisplayOnList(1),Subtitle] public  string Titulos { get; set; }
	    [DisplayOnList(2)] public  string Tipo { get; set; }
	}
}
namespace Bravo.Professionals.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	}
}
