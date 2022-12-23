using FluentValidation.Results;
using MediatR;
namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.Queries.Models
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
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Queries.Models
{
	public partial class SchedulingsAggSettingsQueryModel {
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
	public partial class FeriadoQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public string DescricaoEqual { get; set; }
		public string DescricaoNotEqual { get; set; }
		public string DescricaoContains { get; set; }
		public string DescricaoStartsWith { get; set; }
		public System.DateOnly? DataEqual { get; set; }
		public System.DateOnly? DataSince { get; set; }
		public System.DateOnly? DataUntil { get; set; }
		public SES.Schedulings.Enumerations.HolidayType? TipoEqual { get; set; }
		public string UserIdEqual { get; set; }
		public string UserIdNotEqual { get; set; }
		public string UserIdContains { get; set; }
		public string UserIdStartsWith { get; set; }
		public int? EmpresaIdEqual { get; set; }
		public int? EmpresaIdSince { get; set; }
		public int? EmpresaIdUntil { get; set; }
		public bool? AtivoEqual { get; set; }
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
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Queries.Models
{
	public partial class ProfissionalQueryModel {
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
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.Queries.Models
{
	public partial class UserQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public int? EmpresaIdEqual { get; set; }
		public int? EmpresaIdSince { get; set; }
		public int? EmpresaIdUntil { get; set; }
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
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.Queries.Models
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
}
