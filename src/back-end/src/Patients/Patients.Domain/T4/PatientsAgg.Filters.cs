using Bravo.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Bravo.Core.Domain.Seedwork.Specification;
using Bravo.CrossCuting.Infra.Utils.Extensions;

namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class PacienteFilters 
	{
		public static Expression<Func<Paciente, bool>> GetFilters(this PacienteQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Paciente> filter = new DirectSpecification<Paciente>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.TipoEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.TipoEqual(request.TipoEqual);
					else
						filter &= PacienteSpecifications.TipoEqual(request.TipoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.TipoNotEqual(request.TipoNotEqual);
					else
						filter &= PacienteSpecifications.TipoNotEqual(request.TipoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoContains)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.TipoContains(request.TipoContains);
					else
						filter &= PacienteSpecifications.TipoContains(request.TipoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.TipoStartsWith(request.TipoStartsWith);
					else
						filter &= PacienteSpecifications.TipoStartsWith(request.TipoStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= PacienteSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= PacienteSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= PacienteSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= PacienteSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= PacienteSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= PacienteSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= PacienteSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= PacienteSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= PacienteSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= PacienteSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= PacienteSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= PacienteSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= PacienteSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= PacienteSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= PacienteSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class PatientsAggSettingsFilters 
	{
		public static Expression<Func<PatientsAggSettings, bool>> GetFilters(this PatientsAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<PatientsAggSettings> filter = new DirectSpecification<PatientsAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= PatientsAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= PatientsAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= PatientsAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= PatientsAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= PatientsAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= PatientsAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= PatientsAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= PatientsAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= PatientsAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= PatientsAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= PatientsAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= PatientsAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= PatientsAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= PatientsAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= PatientsAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= PatientsAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= PatientsAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= PatientsAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= PatientsAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= PatientsAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Patients.Domain.Aggregates.UsersAgg.Filters{
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

