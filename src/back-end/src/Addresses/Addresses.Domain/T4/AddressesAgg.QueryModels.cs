using FluentValidation.Results;
using MediatR;
namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.Queries.Models
{
	public partial class EnderecoQueryModel {
		public string Selector { get; set; }
		public string OrderBy { get; set; }
		public bool? OrderByDesc { get; set; }
		public bool? GetOnlySummary { get; set; }
		public IRequest<ValidationResult> Command { get; set; }
		public string CEPEqual { get; set; }
		public string CEPNotEqual { get; set; }
		public string CEPContains { get; set; }
		public string CEPStartsWith { get; set; }
		public string LogradouroEqual { get; set; }
		public string LogradouroNotEqual { get; set; }
		public string LogradouroContains { get; set; }
		public string LogradouroStartsWith { get; set; }
		public string TipoLogradouroEqual { get; set; }
		public string TipoLogradouroNotEqual { get; set; }
		public string TipoLogradouroContains { get; set; }
		public string TipoLogradouroStartsWith { get; set; }
		public string Bairro_DistritoEqual { get; set; }
		public string Bairro_DistritoNotEqual { get; set; }
		public string Bairro_DistritoContains { get; set; }
		public string Bairro_DistritoStartsWith { get; set; }
		public string Cidade_LocalidadeEqual { get; set; }
		public string Cidade_LocalidadeNotEqual { get; set; }
		public string Cidade_LocalidadeContains { get; set; }
		public string Cidade_LocalidadeStartsWith { get; set; }
		public string UFEqual { get; set; }
		public string UFNotEqual { get; set; }
		public string UFContains { get; set; }
		public string UFStartsWith { get; set; }
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
	public partial class AddressesAggSettingsQueryModel {
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
namespace Bravo.Addresses.Domain.Aggregates.UsersAgg.Queries.Models
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
