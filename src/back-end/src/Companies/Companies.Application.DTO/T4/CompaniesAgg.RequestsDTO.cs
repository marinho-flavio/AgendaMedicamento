

using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bravo.Core.Application.DTO.Attributes;

namespace Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	public partial class EmpresaConfiguracaoDTO : EntityDTO
	{
	    public Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO Logo { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO();
	    [DisplayName("Setor Próprio")] public  bool? SetorProprio { get; set; }
	}
	public partial class EmpresaDTO : BaseInstituicaoDTO
	{
	    public  int? EmpresaId { get; set; }
	    public  int? GrupoEmpresaId { get; set; }
	    public  bool IsFilial { get; set; }
	    [DisplayName("Cadastro Nacional de Estabelecimento de Saúde")] public  string CNES { get; set; }
	    [DisplayName("Registro ANS")] public  string ANS { get; set; }
	    [DisplayName("Código SUS")] public  string CodigoSUS { get; set; }
	    [DisplayName("A empresa é terceirizada?")] public  bool Terceirizado { get; set; }
	    public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaEnderecoDTO Endereco { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaEnderecoDTO();
	    public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaContactsDTO Contacts { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaContactsDTO();
	    public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaConfiguracaoDTO Configuracao { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaConfiguracaoDTO();
	}
	public partial class GrupoEmpresaContactsDTO : EntityDTO
	{
	    [DisplayOnList(4),DisplayName("E-Mail")] public  string Email { get; set; }
	    [DisplayOnList(4),DisplayName("Telefone")] public  string Telefone { get; set; }
	    [DisplayName("Tipo de Telefone")] public  string TipoTelefone { get; set; }
	    public  string WebSite { get; set; }
	}
	public partial class GrupoEmpresaConfiguracaoDTO : EntityDTO
	{
	    [DisplayName("Logomarca")] public Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO Logo { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO();
	    [DisplayName("Setor Próprio")] public  bool? SetorProprio { get; set; }
	}
	public partial class CompaniesAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
	public partial class GrupoEmpresaEnderecoDTO : BaseEnderecoComplementoDTO<Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests.EnderecoDTO>
	{
		public  override Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests.EnderecoDTO Endereco { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests.EnderecoDTO();
	    public  int GrupoEmpresaId { get; set; }
	    public  override  int? EnderecoId { get; set; }
	    [DisplayName("Número")] public  override  string Numero { get; set; }
	    [DisplayName("Referência")] public  override  string Referencia { get; set; }
	    [DisplayName("Tipo Endereço")] public  override  string TipoEndereco { get; set; }
	    public  override  string Complemento { get; set; }
	}
	public partial class GrupoEmpresaDTO : BaseInstituicaoDTO
	{
	    [DisplayOnList] public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.GrupoEmpresaEnderecoDTO GrupoEmpresaEndereco { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.GrupoEmpresaEnderecoDTO();
	    [DisplayOnList] public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.GrupoEmpresaContactsDTO Contacts { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.GrupoEmpresaContactsDTO();
	    [DisplayOnList] public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.GrupoEmpresaConfiguracaoDTO GrupoEmpresaConfiguracao { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.GrupoEmpresaConfiguracaoDTO();
	}
	public partial class EmpresaEnderecoDTO : BaseEnderecoComplementoDTO<Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests.EnderecoDTO>
	{
		public  override Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests.EnderecoDTO Endereco { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests.EnderecoDTO();
	    public  int EmpresaId { get; set; }
	    public  override  int? EnderecoId { get; set; }
	    [DisplayName("Número")] public  override  string Numero { get; set; }
	    [DisplayName("Referência")] public  override  string Referencia { get; set; }
	    [DisplayName("Tipo Endereço")] public  override  string TipoEndereco { get; set; }
	    public  override  string Complemento { get; set; }
	}
	public partial class EmpresaContactsDTO : EntityDTO
	{
	    public  string Email { get; set; }
	    public  string Telefone { get; set; }
	    [DisplayName("Tipo de Telefone")] public  string TipoTelefone { get; set; }
	    public  string WebSite { get; set; }
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.ProfessionalsAgg.Requests 
{
	public partial class ProfissionalConfiguracaoDTO : EntityDTO
	{
	    public Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO Logo { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO();
	    [DisplayName("Setor Próprio")] public  bool? SetorProprio { get; set; }
	}
	public partial class FuncionarioDTO : BaseFuncionarioDTO
	{
	}
	public partial class ProfissionalDTO : BaseFuncionarioDTO
	{
	    public Bravo.Companies.Application.DTO.Aggregates.ProfessionalsAgg.Requests.CboDTO Cbo { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.ProfessionalsAgg.Requests.CboDTO();
	    public Bravo.Companies.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalConfiguracaoDTO ProfissionalConfiguracao { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalConfiguracaoDTO();
	}
	public partial class CboDTO : EntityDTO
	{
	    [DisplayOnList(0),Title] public  string Codigo { get; set; }
	    [DisplayOnList(1),Subtitle] public  string Titulos { get; set; }
	    [DisplayOnList(2)] public  string Tipo { get; set; }
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.PatientsAgg.Requests 
{
	public partial class PacienteDTO : EntityDTO
	{
	    public  string Nome { get; set; }
	    public  string Cpf { get; set; }
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.SchedulingsAgg.Requests 
{
	public partial class AgendaExameDTO : BaseConfiguracaoAgendaDTO
	{
	}
	public partial class FeriadoDTO : ActivableEntityDTO
	{
	    [DisplayOnList(0),DisplayName("Nome do Feriado"),Title] public  string Descricao { get; set; }
	    [DisplayOnList(1),Subtitle] public  System.DateOnly Data { get; set; }
	    [DisplayOnList(2),DisplayName("Tipo do Feriado")] public  Bravo.Schedulings.Enumerations.HolidayType Tipo { get; set; }
	    public  string UserId { get; set; }
	    public  int EmpresaId { get; set; }
	}
	public partial class AgendaProfissionalDTO : BaseConfiguracaoAgendaDTO
	{
	    [Title] public  string NomeProfissional { get; set; }
	    public  string Conselho { get; set; }
	    public  string CBOProfissional { get; set; }
	    public  string DuracaoConsulta { get; set; }
	    public  string CotaAtendimento { get; set; }
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.HealthPlansAgg.Requests 
{
	public partial class ConvenioDTO : EntityDTO
	{
	    public  string Nome { get; set; }
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.ClinicalProceduresAgg.Requests 
{
	public partial class ProcedimentoDTO : EntityDTO
	{
	    public  int CodigoProcedimento { get; set; }
	    public  int Descricao { get; set; }
	    public  string Orientacao { get; set; }
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	    public  string UserName { get; set; }
	    public  string Name { get; set; }
	    public  string Email { get; set; }
	    public  int? EmpresaId { get; set; }
	    public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.PartnersAgg.Requests 
{
	public partial class FornecedorDTO : EntityDTO
	{
	    public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
	public partial class PublicitarioDTO : EntityDTO
	{
	    public Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
}
namespace Bravo.Companies.Application.DTO.Aggregates.AddressesAgg.Requests 
{
	public partial class EnderecoDTO : BaseEnderecoDTO
	{
	}
}
