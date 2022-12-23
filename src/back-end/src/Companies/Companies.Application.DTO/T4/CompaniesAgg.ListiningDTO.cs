using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	using Requests;
    public partial class EmpresaListiningDTO : EntityDTO
	{
        [DisplayOnList(3),DisplayName("Cidade / Localidade")] public  string Cidade_Localidade { get; set; }[DisplayOnList(2),Subtitle] public  string CNPJ { get; set; }[DisplayOnList(1),DisplayName("Razão Social"),Title] public  string RazaoSocial { get; set; }[DisplayOnList(0),DisplayName("Nome Fantasia")] public  string NomeFantasia { get; set; }
    }
    public partial class CompaniesAggSettingsListiningDTO : EntityDTO
	{
        [DisplayOnList(3),DisplayName("Cidade / Localidade")] public  string Cidade_Localidade { get; set; }
    }
    public partial class GrupoEmpresaListiningDTO : EntityDTO
	{
        [DisplayOnList(3),DisplayName("Cidade / Localidade")] public  string Cidade_Localidade { get; set; }[DisplayOnList(4),DisplayName("E-Mail")] public  string Email { get; set; }[DisplayOnList(4),DisplayName("Telefone")] public  string Telefone { get; set; }[DisplayOnList(2),Subtitle] public  string CNPJ { get; set; }[DisplayOnList(1),DisplayName("Razão Social"),Title] public  string RazaoSocial { get; set; }[DisplayOnList(0),DisplayName("Nome Fantasia")] public  string NomeFantasia { get; set; }
    }
}
namespace Bravo.Companies.Application.DTO.Aggregates.ProfessionalsAgg.Requests 
{
	using Requests;
    public partial class ProfissionalConfiguracaoListiningDTO : EntityDTO
	{
        
    }
    public partial class FuncionarioListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Title] public  string Nome { get; set; }[DisplayOnList(1)] public  string CPF { get; set; }[DisplayOnList(2),Subtitle] public  string CNPJ { get; set; }[DisplayOnList(3)] public  string Telefone { get; set; }
    }
    public partial class ProfissionalListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Title] public  string Codigo { get; set; }[DisplayOnList(2)] public  string Tipo { get; set; }[DisplayOnList(1),Subtitle] public  string Titulos { get; set; }[DisplayOnList(0),Title] public  string Nome { get; set; }[DisplayOnList(1)] public  string CPF { get; set; }[DisplayOnList(2),Subtitle] public  string CNPJ { get; set; }[DisplayOnList(3)] public  string Telefone { get; set; }
    }
    public partial class CboListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Title] public  string Codigo { get; set; }[DisplayOnList(1),Subtitle] public  string Titulos { get; set; }[DisplayOnList(2)] public  string Tipo { get; set; }
    }
}
namespace Bravo.Companies.Application.DTO.Aggregates.PatientsAgg.Requests 
{
	using Requests;
    public partial class PacienteListiningDTO : EntityDTO
	{
        
    }
}
namespace Bravo.Companies.Application.DTO.Aggregates.SchedulingsAgg.Requests 
{
	using Requests;
    public partial class AgendaExameListiningDTO : EntityDTO
	{
        
    }
    public partial class FeriadoListiningDTO : EntityDTO
	{
        [DisplayOnList(0),DisplayName("Nome do Feriado"),Title] public  string Descricao { get; set; }[DisplayOnList(1),Subtitle] public  System.DateOnly Data { get; set; }[DisplayOnList(2),DisplayName("Tipo do Feriado")] public  Bravo.Schedulings.Enumerations.HolidayType Tipo { get; set; }
    }
    public partial class AgendaProfissionalListiningDTO : EntityDTO
	{
        
    }
}
namespace Bravo.Companies.Application.DTO.Aggregates.HealthPlansAgg.Requests 
{
	using Requests;
    public partial class ConvenioListiningDTO : EntityDTO
	{
        
    }
}
namespace Bravo.Companies.Application.DTO.Aggregates.ClinicalProceduresAgg.Requests 
{
	using Requests;
}
namespace Bravo.Companies.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
}
namespace Bravo.Companies.Application.DTO.Aggregates.PartnersAgg.Requests 
{
	using Requests;
    public partial class FornecedorListiningDTO : EntityDTO
	{
        [DisplayOnList(3),DisplayName("Cidade / Localidade")] public  string Cidade_Localidade { get; set; }
    }
    public partial class PublicitarioListiningDTO : EntityDTO
	{
        [DisplayOnList(3),DisplayName("Cidade / Localidade")] public  string Cidade_Localidade { get; set; }
    }
}
namespace Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests 
{
	using Requests;
}
