using SES.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using SES.Core.Domain.Seedwork.Specification;
using SES.CrossCuting.Infra.Utils.Extensions;

namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.Filters{
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
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class SchedulingsAggSettingsFilters 
	{
		public static Expression<Func<SchedulingsAggSettings, bool>> GetFilters(this SchedulingsAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<SchedulingsAggSettings> filter = new DirectSpecification<SchedulingsAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= SchedulingsAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= SchedulingsAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= SchedulingsAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= SchedulingsAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= SchedulingsAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= SchedulingsAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= SchedulingsAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= SchedulingsAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= SchedulingsAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= SchedulingsAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class FeriadoFilters 
	{
		public static Expression<Func<Feriado, bool>> GetFilters(this FeriadoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Feriado> filter = new DirectSpecification<Feriado>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.DescricaoEqual)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DescricaoEqual(request.DescricaoEqual);
					else
						filter &= FeriadoSpecifications.DescricaoEqual(request.DescricaoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DescricaoNotEqual(request.DescricaoNotEqual);
					else
						filter &= FeriadoSpecifications.DescricaoNotEqual(request.DescricaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoContains)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DescricaoContains(request.DescricaoContains);
					else
						filter &= FeriadoSpecifications.DescricaoContains(request.DescricaoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DescricaoStartsWith(request.DescricaoStartsWith);
					else
						filter &= FeriadoSpecifications.DescricaoStartsWith(request.DescricaoStartsWith);
				}
				if (request.DataEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DataEqual(request.DataEqual.Value);
					else
						filter &= FeriadoSpecifications.DataEqual(request.DataEqual.Value);
				}
				if (request.DataSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DataGreatThanOrEqual(request.DataSince.Value);
					else
						filter &= FeriadoSpecifications.DataGreatThanOrEqual(request.DataSince.Value);
				}
				if (request.DataUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DataLessThan(request.DataUntil.Value);
					else
						filter &= FeriadoSpecifications.DataLessThan(request.DataUntil.Value);
				}
				if (request.TipoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.TipoEqual(request.TipoEqual.Value);
					else
						filter &= FeriadoSpecifications.TipoEqual(request.TipoEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= FeriadoSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= FeriadoSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= FeriadoSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= FeriadoSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= FeriadoSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= FeriadoSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= FeriadoSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
				if (request.AtivoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.AtivoEqual(request.AtivoEqual.Value);
					else
						filter &= FeriadoSpecifications.AtivoEqual(request.AtivoEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= FeriadoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= FeriadoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= FeriadoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= FeriadoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= FeriadoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= FeriadoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= FeriadoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= FeriadoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= FeriadoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= FeriadoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= FeriadoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= FeriadoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= FeriadoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= FeriadoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= FeriadoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= FeriadoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class ProfissionalFilters 
	{
		public static Expression<Func<Profissional, bool>> GetFilters(this ProfissionalQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Profissional> filter = new DirectSpecification<Profissional>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ProfissionalSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ProfissionalSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ProfissionalSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ProfissionalSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ProfissionalSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ProfissionalSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ProfissionalSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ProfissionalSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ProfissionalSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.IdEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.IdEqual(request.IdEqual);
					else
						filter &= ProfissionalSpecifications.IdEqual(request.IdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.IdNotEqual(request.IdNotEqual);
					else
						filter &= ProfissionalSpecifications.IdNotEqual(request.IdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.IdContains(request.IdContains);
					else
						filter &= ProfissionalSpecifications.IdContains(request.IdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.IdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.IdStartsWith(request.IdStartsWith);
					else
						filter &= ProfissionalSpecifications.IdStartsWith(request.IdStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ProfissionalSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ProfissionalSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ProfissionalSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ProfissionalSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ProfissionalSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.Filters{
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
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.Filters{
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
}

