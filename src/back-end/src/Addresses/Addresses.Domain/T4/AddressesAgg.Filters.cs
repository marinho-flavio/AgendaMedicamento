using Bravo.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Bravo.Core.Domain.Seedwork.Specification;
using Bravo.CrossCuting.Infra.Utils.Extensions;

namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class EnderecoFilters 
	{
		public static Expression<Func<Endereco, bool>> GetFilters(this EnderecoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Endereco> filter = new DirectSpecification<Endereco>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.CEPEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.CEPEqual(request.CEPEqual);
					else
						filter &= EnderecoSpecifications.CEPEqual(request.CEPEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CEPNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.CEPNotEqual(request.CEPNotEqual);
					else
						filter &= EnderecoSpecifications.CEPNotEqual(request.CEPNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CEPContains)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.CEPContains(request.CEPContains);
					else
						filter &= EnderecoSpecifications.CEPContains(request.CEPContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CEPStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.CEPStartsWith(request.CEPStartsWith);
					else
						filter &= EnderecoSpecifications.CEPStartsWith(request.CEPStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.LogradouroEqual(request.LogradouroEqual);
					else
						filter &= EnderecoSpecifications.LogradouroEqual(request.LogradouroEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.LogradouroNotEqual(request.LogradouroNotEqual);
					else
						filter &= EnderecoSpecifications.LogradouroNotEqual(request.LogradouroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroContains)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.LogradouroContains(request.LogradouroContains);
					else
						filter &= EnderecoSpecifications.LogradouroContains(request.LogradouroContains);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.LogradouroStartsWith(request.LogradouroStartsWith);
					else
						filter &= EnderecoSpecifications.LogradouroStartsWith(request.LogradouroStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.TipoLogradouroEqual(request.TipoLogradouroEqual);
					else
						filter &= EnderecoSpecifications.TipoLogradouroEqual(request.TipoLogradouroEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.TipoLogradouroNotEqual(request.TipoLogradouroNotEqual);
					else
						filter &= EnderecoSpecifications.TipoLogradouroNotEqual(request.TipoLogradouroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroContains)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.TipoLogradouroContains(request.TipoLogradouroContains);
					else
						filter &= EnderecoSpecifications.TipoLogradouroContains(request.TipoLogradouroContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.TipoLogradouroStartsWith(request.TipoLogradouroStartsWith);
					else
						filter &= EnderecoSpecifications.TipoLogradouroStartsWith(request.TipoLogradouroStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Bairro_DistritoEqual(request.Bairro_DistritoEqual);
					else
						filter &= EnderecoSpecifications.Bairro_DistritoEqual(request.Bairro_DistritoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Bairro_DistritoNotEqual(request.Bairro_DistritoNotEqual);
					else
						filter &= EnderecoSpecifications.Bairro_DistritoNotEqual(request.Bairro_DistritoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoContains)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Bairro_DistritoContains(request.Bairro_DistritoContains);
					else
						filter &= EnderecoSpecifications.Bairro_DistritoContains(request.Bairro_DistritoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Bairro_DistritoStartsWith(request.Bairro_DistritoStartsWith);
					else
						filter &= EnderecoSpecifications.Bairro_DistritoStartsWith(request.Bairro_DistritoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Cidade_LocalidadeEqual(request.Cidade_LocalidadeEqual);
					else
						filter &= EnderecoSpecifications.Cidade_LocalidadeEqual(request.Cidade_LocalidadeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Cidade_LocalidadeNotEqual(request.Cidade_LocalidadeNotEqual);
					else
						filter &= EnderecoSpecifications.Cidade_LocalidadeNotEqual(request.Cidade_LocalidadeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeContains)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Cidade_LocalidadeContains(request.Cidade_LocalidadeContains);
					else
						filter &= EnderecoSpecifications.Cidade_LocalidadeContains(request.Cidade_LocalidadeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.Cidade_LocalidadeStartsWith(request.Cidade_LocalidadeStartsWith);
					else
						filter &= EnderecoSpecifications.Cidade_LocalidadeStartsWith(request.Cidade_LocalidadeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.UFEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.UFEqual(request.UFEqual);
					else
						filter &= EnderecoSpecifications.UFEqual(request.UFEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UFNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.UFNotEqual(request.UFNotEqual);
					else
						filter &= EnderecoSpecifications.UFNotEqual(request.UFNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UFContains)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.UFContains(request.UFContains);
					else
						filter &= EnderecoSpecifications.UFContains(request.UFContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UFStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.UFStartsWith(request.UFStartsWith);
					else
						filter &= EnderecoSpecifications.UFStartsWith(request.UFStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= EnderecoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= EnderecoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= EnderecoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= EnderecoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= EnderecoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= EnderecoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= EnderecoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= EnderecoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= EnderecoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= EnderecoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= EnderecoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= EnderecoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= EnderecoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= EnderecoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EnderecoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= EnderecoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class AddressesAggSettingsFilters 
	{
		public static Expression<Func<AddressesAggSettings, bool>> GetFilters(this AddressesAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<AddressesAggSettings> filter = new DirectSpecification<AddressesAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Addresses.Domain.Aggregates.UsersAgg.Filters{
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

