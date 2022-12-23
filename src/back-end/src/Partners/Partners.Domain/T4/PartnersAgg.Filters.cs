using Bravo.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Bravo.Core.Domain.Seedwork.Specification;
using Bravo.CrossCuting.Infra.Utils.Extensions;

namespace Bravo.Partners.Domain.Aggregates.CompaniesAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class EmpresaFilters 
	{
		public static Expression<Func<Empresa, bool>> GetFilters(this EmpresaQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Empresa> filter = new DirectSpecification<Empresa>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= EmpresaSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= EmpresaSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= EmpresaSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= EmpresaSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= EmpresaSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= EmpresaSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= EmpresaSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= EmpresaSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= EmpresaSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= EmpresaSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= EmpresaSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= EmpresaSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= EmpresaSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= EmpresaSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= EmpresaSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class FornecedorFilters 
	{
		public static Expression<Func<Fornecedor, bool>> GetFilters(this FornecedorQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Fornecedor> filter = new DirectSpecification<Fornecedor>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= FornecedorSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= FornecedorSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeContains(request.NomeContains);
					else
						filter &= FornecedorSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= FornecedorSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeFantasiaEqual(request.NomeFantasiaEqual);
					else
						filter &= FornecedorSpecifications.NomeFantasiaEqual(request.NomeFantasiaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeFantasiaNotEqual(request.NomeFantasiaNotEqual);
					else
						filter &= FornecedorSpecifications.NomeFantasiaNotEqual(request.NomeFantasiaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeFantasiaContains(request.NomeFantasiaContains);
					else
						filter &= FornecedorSpecifications.NomeFantasiaContains(request.NomeFantasiaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeFantasiaStartsWith(request.NomeFantasiaStartsWith);
					else
						filter &= FornecedorSpecifications.NomeFantasiaStartsWith(request.NomeFantasiaStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CpfEqual(request.CpfEqual);
					else
						filter &= FornecedorSpecifications.CpfEqual(request.CpfEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CpfNotEqual(request.CpfNotEqual);
					else
						filter &= FornecedorSpecifications.CpfNotEqual(request.CpfNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CpfContains(request.CpfContains);
					else
						filter &= FornecedorSpecifications.CpfContains(request.CpfContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CpfStartsWith(request.CpfStartsWith);
					else
						filter &= FornecedorSpecifications.CpfStartsWith(request.CpfStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CnpjEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CnpjEqual(request.CnpjEqual);
					else
						filter &= FornecedorSpecifications.CnpjEqual(request.CnpjEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CnpjNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CnpjNotEqual(request.CnpjNotEqual);
					else
						filter &= FornecedorSpecifications.CnpjNotEqual(request.CnpjNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CnpjContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CnpjContains(request.CnpjContains);
					else
						filter &= FornecedorSpecifications.CnpjContains(request.CnpjContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CnpjStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CnpjStartsWith(request.CnpjStartsWith);
					else
						filter &= FornecedorSpecifications.CnpjStartsWith(request.CnpjStartsWith);
				}
				if (request.TipoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.TipoEqual(request.TipoEqual.Value);
					else
						filter &= FornecedorSpecifications.TipoEqual(request.TipoEqual.Value);
				}
				if (request.TipoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.TipoGreatThanOrEqual(request.TipoSince.Value);
					else
						filter &= FornecedorSpecifications.TipoGreatThanOrEqual(request.TipoSince.Value);
				}
				if (request.TipoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.TipoLessThan(request.TipoUntil.Value);
					else
						filter &= FornecedorSpecifications.TipoLessThan(request.TipoUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContatoEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeContatoEqual(request.NomeContatoEqual);
					else
						filter &= FornecedorSpecifications.NomeContatoEqual(request.NomeContatoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContatoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeContatoNotEqual(request.NomeContatoNotEqual);
					else
						filter &= FornecedorSpecifications.NomeContatoNotEqual(request.NomeContatoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContatoContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeContatoContains(request.NomeContatoContains);
					else
						filter &= FornecedorSpecifications.NomeContatoContains(request.NomeContatoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContatoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.NomeContatoStartsWith(request.NomeContatoStartsWith);
					else
						filter &= FornecedorSpecifications.NomeContatoStartsWith(request.NomeContatoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.TelefoneEqual(request.TelefoneEqual);
					else
						filter &= FornecedorSpecifications.TelefoneEqual(request.TelefoneEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
					else
						filter &= FornecedorSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.TelefoneContains(request.TelefoneContains);
					else
						filter &= FornecedorSpecifications.TelefoneContains(request.TelefoneContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
					else
						filter &= FornecedorSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ClassificacaoEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ClassificacaoEqual(request.ClassificacaoEqual);
					else
						filter &= FornecedorSpecifications.ClassificacaoEqual(request.ClassificacaoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ClassificacaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ClassificacaoNotEqual(request.ClassificacaoNotEqual);
					else
						filter &= FornecedorSpecifications.ClassificacaoNotEqual(request.ClassificacaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ClassificacaoContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ClassificacaoContains(request.ClassificacaoContains);
					else
						filter &= FornecedorSpecifications.ClassificacaoContains(request.ClassificacaoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ClassificacaoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ClassificacaoStartsWith(request.ClassificacaoStartsWith);
					else
						filter &= FornecedorSpecifications.ClassificacaoStartsWith(request.ClassificacaoStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= FornecedorSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= FornecedorSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= FornecedorSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= FornecedorSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= FornecedorSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= FornecedorSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= FornecedorSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= FornecedorSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= FornecedorSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= FornecedorSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= FornecedorSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= FornecedorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= FornecedorSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= FornecedorSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= FornecedorSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= FornecedorSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class PublicitarioFilters 
	{
		public static Expression<Func<Publicitario, bool>> GetFilters(this PublicitarioQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Publicitario> filter = new DirectSpecification<Publicitario>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= PublicitarioSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= PublicitarioSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.NomeContains(request.NomeContains);
					else
						filter &= PublicitarioSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= PublicitarioSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (request.TipoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.TipoEqual(request.TipoEqual.Value);
					else
						filter &= PublicitarioSpecifications.TipoEqual(request.TipoEqual.Value);
				}
				if (request.TipoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.TipoGreatThanOrEqual(request.TipoSince.Value);
					else
						filter &= PublicitarioSpecifications.TipoGreatThanOrEqual(request.TipoSince.Value);
				}
				if (request.TipoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.TipoLessThan(request.TipoUntil.Value);
					else
						filter &= PublicitarioSpecifications.TipoLessThan(request.TipoUntil.Value);
				}
				if (request.FornecedorIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.FornecedorIdEqual(request.FornecedorIdEqual.Value);
					else
						filter &= PublicitarioSpecifications.FornecedorIdEqual(request.FornecedorIdEqual.Value);
				}
				if (request.FornecedorIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.FornecedorIdGreatThanOrEqual(request.FornecedorIdSince.Value);
					else
						filter &= PublicitarioSpecifications.FornecedorIdGreatThanOrEqual(request.FornecedorIdSince.Value);
				}
				if (request.FornecedorIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.FornecedorIdLessThan(request.FornecedorIdUntil.Value);
					else
						filter &= PublicitarioSpecifications.FornecedorIdLessThan(request.FornecedorIdUntil.Value);
				}
				if (request.TipoValorRepasseEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.TipoValorRepasseEqual(request.TipoValorRepasseEqual.Value);
					else
						filter &= PublicitarioSpecifications.TipoValorRepasseEqual(request.TipoValorRepasseEqual.Value);
				}
				if (request.TipoValorRepasseSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.TipoValorRepasseGreatThanOrEqual(request.TipoValorRepasseSince.Value);
					else
						filter &= PublicitarioSpecifications.TipoValorRepasseGreatThanOrEqual(request.TipoValorRepasseSince.Value);
				}
				if (request.TipoValorRepasseUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.TipoValorRepasseLessThan(request.TipoValorRepasseUntil.Value);
					else
						filter &= PublicitarioSpecifications.TipoValorRepasseLessThan(request.TipoValorRepasseUntil.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= PublicitarioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= PublicitarioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= PublicitarioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= PublicitarioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= PublicitarioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= PublicitarioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= PublicitarioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= PublicitarioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= PublicitarioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= PublicitarioSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= PublicitarioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= PublicitarioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= PublicitarioSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= PublicitarioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= PublicitarioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= PublicitarioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class PartnersAggSettingsFilters 
	{
		public static Expression<Func<PartnersAggSettings, bool>> GetFilters(this PartnersAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<PartnersAggSettings> filter = new DirectSpecification<PartnersAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= PartnersAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= PartnersAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= PartnersAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= PartnersAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= PartnersAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= PartnersAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= PartnersAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= PartnersAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= PartnersAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= PartnersAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= PartnersAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= PartnersAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= PartnersAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= PartnersAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= PartnersAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= PartnersAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= PartnersAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= PartnersAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= PartnersAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= PartnersAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Partners.Domain.Aggregates.UsersAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class UserFilters 
	{
		public static Expression<Func<User, bool>> GetFilters(this UserQueryModel request, bool isOrSpecification = false) 
		{
			Specification<User> filter = new DirectSpecification<User>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= UserSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= UserSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= UserSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= UserSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= UserSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= UserSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= UserSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= UserSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= UserSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.IdEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.IdEqual(request.IdEqual);
					else
						filter &= UserSpecifications.IdEqual(request.IdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.IdNotEqual(request.IdNotEqual);
					else
						filter &= UserSpecifications.IdNotEqual(request.IdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdContains)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.IdContains(request.IdContains);
					else
						filter &= UserSpecifications.IdContains(request.IdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.IdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.IdStartsWith(request.IdStartsWith);
					else
						filter &= UserSpecifications.IdStartsWith(request.IdStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= UserSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= UserSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= UserSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= UserSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= UserSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}

