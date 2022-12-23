using FluentValidation.Results;
using MediatR;
namespace Bravo.Partners.Domain.Aggregates.CompaniesAgg.Queries.Models
{
	public partial class EmpresaQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public int? IdEqual { get; set; }
		public string ExternalIdEqual { get; set; }
		public string ExternalIdNotEqual { get; set; }
		public string ExternalIdContains { get; set; }
		public string ExternalIdStartsWith { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
}
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Queries.Models
{
	public partial class FornecedorQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public string NomeEqual { get; set; }
		public string NomeNotEqual { get; set; }
		public string NomeContains { get; set; }
		public string NomeStartsWith { get; set; }
		public string NomeFantasiaEqual { get; set; }
		public string NomeFantasiaNotEqual { get; set; }
		public string NomeFantasiaContains { get; set; }
		public string NomeFantasiaStartsWith { get; set; }
		public string CpfEqual { get; set; }
		public string CpfNotEqual { get; set; }
		public string CpfContains { get; set; }
		public string CpfStartsWith { get; set; }
		public string CnpjEqual { get; set; }
		public string CnpjNotEqual { get; set; }
		public string CnpjContains { get; set; }
		public string CnpjStartsWith { get; set; }
		public int? TipoEqual { get; set; }
		public int? TipoSince { get; set; }
		public int? TipoUntil { get; set; }
		public string NomeContatoEqual { get; set; }
		public string NomeContatoNotEqual { get; set; }
		public string NomeContatoContains { get; set; }
		public string NomeContatoStartsWith { get; set; }
		public string TelefoneEqual { get; set; }
		public string TelefoneNotEqual { get; set; }
		public string TelefoneContains { get; set; }
		public string TelefoneStartsWith { get; set; }
		public string ClassificacaoEqual { get; set; }
		public string ClassificacaoNotEqual { get; set; }
		public string ClassificacaoContains { get; set; }
		public string ClassificacaoStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public int? IdEqual { get; set; }
		public string ExternalIdEqual { get; set; }
		public string ExternalIdNotEqual { get; set; }
		public string ExternalIdContains { get; set; }
		public string ExternalIdStartsWith { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
	public partial class PublicitarioQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public string NomeEqual { get; set; }
		public string NomeNotEqual { get; set; }
		public string NomeContains { get; set; }
		public string NomeStartsWith { get; set; }
		public int? TipoEqual { get; set; }
		public int? TipoSince { get; set; }
		public int? TipoUntil { get; set; }
		public int? FornecedorIdEqual { get; set; }
		public int? FornecedorIdSince { get; set; }
		public int? FornecedorIdUntil { get; set; }
		public int? TipoValorRepasseEqual { get; set; }
		public int? TipoValorRepasseSince { get; set; }
		public int? TipoValorRepasseUntil { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public int? IdEqual { get; set; }
		public string ExternalIdEqual { get; set; }
		public string ExternalIdNotEqual { get; set; }
		public string ExternalIdContains { get; set; }
		public string ExternalIdStartsWith { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
	public partial class PartnersAggSettingsQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public string UserIdEqual { get; set; }
		public string UserIdNotEqual { get; set; }
		public string UserIdContains { get; set; }
		public string UserIdStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public int? IdEqual { get; set; }
		public string ExternalIdEqual { get; set; }
		public string ExternalIdNotEqual { get; set; }
		public string ExternalIdContains { get; set; }
		public string ExternalIdStartsWith { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
}
namespace Bravo.Partners.Domain.Aggregates.UsersAgg.Queries.Models
{
	public partial class UserQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public string IdEqual { get; set; }
		public string IdNotEqual { get; set; }
		public string IdContains { get; set; }
		public string IdStartsWith { get; set; }
		public string ExternalIdEqual { get; set; }
		public string ExternalIdNotEqual { get; set; }
		public string ExternalIdContains { get; set; }
		public string ExternalIdStartsWith { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
}
