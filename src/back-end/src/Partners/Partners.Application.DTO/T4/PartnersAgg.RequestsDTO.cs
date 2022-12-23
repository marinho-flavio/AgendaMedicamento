

using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bravo.Core.Application.DTO.Attributes;

namespace Bravo.Partners.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	public partial class EmpresaDTO : EntityDTO
	{
	}
}
namespace Bravo.Partners.Application.DTO.Aggregates.PartnersAgg.Requests 
{
	public partial class FornecedorDTO : EntityDTO
	{
	    [DisplayOnList(1)] public  string Nome { get; set; }
	    public  string NomeFantasia { get; set; }
	    [DisplayOnList(2)] public  string Cpf { get; set; }
	    public  string Cnpj { get; set; }
	    public  int? Tipo { get; set; }
	    public  string NomeContato { get; set; }
	    public  string Telefone { get; set; }
	    public  string Classificacao { get; set; }
	    public Bravo.Partners.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new Bravo.Partners.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
	public partial class PublicitarioDTO : EntityDTO
	{
	    public  string Nome { get; set; }
	    public  int? Tipo { get; set; }
	    public  int FornecedorId { get; set; }
	    public Bravo.Partners.Application.DTO.Aggregates.PartnersAgg.Requests.FornecedorDTO Fornecedor { get; set; } = new Bravo.Partners.Application.DTO.Aggregates.PartnersAgg.Requests.FornecedorDTO();
	    public  int? TipoValorRepasse { get; set; }
	    public Bravo.Partners.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO Empresa { get; set; } = new Bravo.Partners.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO();
	}
	public partial class PartnersAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
}
namespace Bravo.Partners.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	}
}
