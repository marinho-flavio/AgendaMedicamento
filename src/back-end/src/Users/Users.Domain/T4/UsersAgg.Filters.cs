using SES.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using SES.Core.Domain.Seedwork.Specification;
using SES.CrossCuting.Infra.Utils.Extensions;

namespace SES.Users.Domain.Aggregates.CompaniesAgg.Filters{
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
namespace SES.Users.Domain.Aggregates.UsersAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class UsersAggSettingsFilters 
	{
		public static Expression<Func<UsersAggSettings, bool>> GetFilters(this UsersAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<UsersAggSettings> filter = new DirectSpecification<UsersAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= UsersAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= UsersAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= UsersAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= UsersAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= UsersAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= UsersAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= UsersAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= UsersAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= UsersAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= UsersAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= UsersAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= UsersAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= UsersAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= UsersAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= UsersAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= UsersAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= UsersAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= UsersAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= UsersAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= UsersAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class UserFilters 
	{
		public static Expression<Func<User, bool>> GetFilters(this UserQueryModel request, bool isOrSpecification = false) 
		{
			Specification<User> filter = new DirectSpecification<User>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= UserSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= UserSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= UserSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= UserSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
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

