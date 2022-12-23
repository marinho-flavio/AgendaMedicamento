using FluentValidation.Results;
using MediatR;
namespace SES.Users.Domain.Aggregates.CompaniesAgg.Queries.Models
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
namespace SES.Users.Domain.Aggregates.UsersAgg.Queries.Models
{
	public partial class UsersAggSettingsQueryModel {
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
