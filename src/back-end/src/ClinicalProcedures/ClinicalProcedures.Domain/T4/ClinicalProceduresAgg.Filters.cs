using Bravo.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Bravo.Core.Domain.Seedwork.Specification;
using Bravo.CrossCuting.Infra.Utils.Extensions;

namespace Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Filters{
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
namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class ClinicalProceduresAggSettingsFilters 
	{
		public static Expression<Func<ClinicalProceduresAggSettings, bool>> GetFilters(this ClinicalProceduresAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<ClinicalProceduresAggSettings> filter = new DirectSpecification<ClinicalProceduresAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ClinicalProceduresAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ClinicalProceduresAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}

