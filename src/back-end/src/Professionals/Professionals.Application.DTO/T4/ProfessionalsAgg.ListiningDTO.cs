using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Professionals.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	using Requests;
}
namespace Bravo.Professionals.Application.DTO.Aggregates.SchedulingsAgg.Requests 
{
	using Requests;
    public partial class SchedulingsAggSettingsListiningDTO : EntityDTO
	{
        
    }
    public partial class AgendaExameListiningDTO : EntityDTO
	{
        
    }
    public partial class AgendaSalaListiningDTO : EntityDTO
	{
        
    }
    public partial class FeriadoListiningDTO : EntityDTO
	{
        [DisplayOnList(0),DisplayName("Nome do Feriado"),Title] public  string Descricao { get; set; }[DisplayOnList(0)] public  System.DateOnly Data { get; set; }[DisplayOnList(0),DisplayName("Tipo do Feriado"),Subtitle] public  Bravo.Schedulings.Enumerations.HolidayType Tipo { get; set; }
    }
    public partial class AgendaProfissionalListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Title] public  string Codigo { get; set; }[DisplayOnList(2)] public  string Tipo { get; set; }[DisplayOnList(1),Subtitle] public  string Titulos { get; set; }
    }
}
namespace Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests 
{
	using Requests;
    public partial class ProfissionalConfiguracaoListiningDTO : EntityDTO
	{
        
    }
    public partial class FuncionarioListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Title] public  string Codigo { get; set; }[DisplayOnList(2)] public  string Tipo { get; set; }[DisplayOnList(1),Subtitle] public  string Titulos { get; set; }[DisplayOnList(0),Title] public  string Nome { get; set; }[DisplayOnList(1)] public  string CPF { get; set; }[DisplayOnList(2),Subtitle] public  string CNPJ { get; set; }[DisplayOnList(3)] public  string Telefone { get; set; }
    }
    public partial class ProfissionalListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Title] public  string Codigo { get; set; }[DisplayOnList(2)] public  string Tipo { get; set; }[DisplayOnList(1),Subtitle] public  string Titulos { get; set; }[DisplayOnList(0),Title] public  string Nome { get; set; }[DisplayOnList(1)] public  string CPF { get; set; }[DisplayOnList(2),Subtitle] public  string CNPJ { get; set; }[DisplayOnList(3)] public  string Telefone { get; set; }
    }
    public partial class ProfessionalsAggSettingsListiningDTO : EntityDTO
	{
        
    }
    public partial class CboListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Title] public  string Codigo { get; set; }[DisplayOnList(1),Subtitle] public  string Titulos { get; set; }[DisplayOnList(2)] public  string Tipo { get; set; }
    }
}
namespace Bravo.Professionals.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
}
