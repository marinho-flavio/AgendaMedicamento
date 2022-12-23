using Bravo.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Bravo.Core.Domain.Seedwork.Specification;
using Bravo.CrossCuting.Infra.Utils.Extensions;

namespace Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Filters{
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
namespace Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Filters{
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
	public static class AgendaExameFilters 
	{
		public static Expression<Func<AgendaExame, bool>> GetFilters(this AgendaExameQueryModel request, bool isOrSpecification = false) 
		{
			Specification<AgendaExame> filter = new DirectSpecification<AgendaExame>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.DataInicioEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DataInicioEqual(request.DataInicioEqual.Value);
					else
						filter &= AgendaExameSpecifications.DataInicioEqual(request.DataInicioEqual.Value);
				}
				if (request.DataInicioSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DataInicioGreatThanOrEqual(request.DataInicioSince.Value);
					else
						filter &= AgendaExameSpecifications.DataInicioGreatThanOrEqual(request.DataInicioSince.Value);
				}
				if (request.DataInicioUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DataInicioLessThan(request.DataInicioUntil.Value);
					else
						filter &= AgendaExameSpecifications.DataInicioLessThan(request.DataInicioUntil.Value);
				}
				if (request.DataFimEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DataFimEqual(request.DataFimEqual.Value);
					else
						filter &= AgendaExameSpecifications.DataFimEqual(request.DataFimEqual.Value);
				}
				if (request.DataFimSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DataFimGreatThanOrEqual(request.DataFimSince.Value);
					else
						filter &= AgendaExameSpecifications.DataFimGreatThanOrEqual(request.DataFimSince.Value);
				}
				if (request.DataFimUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DataFimLessThan(request.DataFimUntil.Value);
					else
						filter &= AgendaExameSpecifications.DataFimLessThan(request.DataFimUntil.Value);
				}
				if (request.TempoAtendimentoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.TempoAtendimentoEqual(request.TempoAtendimentoEqual.Value);
					else
						filter &= AgendaExameSpecifications.TempoAtendimentoEqual(request.TempoAtendimentoEqual.Value);
				}
				if (request.TempoAtendimentoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.TempoAtendimentoGreatThanOrEqual(request.TempoAtendimentoSince.Value);
					else
						filter &= AgendaExameSpecifications.TempoAtendimentoGreatThanOrEqual(request.TempoAtendimentoSince.Value);
				}
				if (request.TempoAtendimentoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.TempoAtendimentoLessThan(request.TempoAtendimentoUntil.Value);
					else
						filter &= AgendaExameSpecifications.TempoAtendimentoLessThan(request.TempoAtendimentoUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.TipoEqual(request.TipoEqual);
					else
						filter &= AgendaExameSpecifications.TipoEqual(request.TipoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.TipoNotEqual(request.TipoNotEqual);
					else
						filter &= AgendaExameSpecifications.TipoNotEqual(request.TipoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.TipoContains(request.TipoContains);
					else
						filter &= AgendaExameSpecifications.TipoContains(request.TipoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.TipoStartsWith(request.TipoStartsWith);
					else
						filter &= AgendaExameSpecifications.TipoStartsWith(request.TipoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.AgendaStatusEqual(request.AgendaStatusEqual);
					else
						filter &= AgendaExameSpecifications.AgendaStatusEqual(request.AgendaStatusEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.AgendaStatusNotEqual(request.AgendaStatusNotEqual);
					else
						filter &= AgendaExameSpecifications.AgendaStatusNotEqual(request.AgendaStatusNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.AgendaStatusContains(request.AgendaStatusContains);
					else
						filter &= AgendaExameSpecifications.AgendaStatusContains(request.AgendaStatusContains);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.AgendaStatusStartsWith(request.AgendaStatusStartsWith);
					else
						filter &= AgendaExameSpecifications.AgendaStatusStartsWith(request.AgendaStatusStartsWith);
				}
				if (request.QuantidadeAgendamentosEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.QuantidadeAgendamentosEqual(request.QuantidadeAgendamentosEqual.Value);
					else
						filter &= AgendaExameSpecifications.QuantidadeAgendamentosEqual(request.QuantidadeAgendamentosEqual.Value);
				}
				if (request.QuantidadeAgendamentosSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.QuantidadeAgendamentosGreatThanOrEqual(request.QuantidadeAgendamentosSince.Value);
					else
						filter &= AgendaExameSpecifications.QuantidadeAgendamentosGreatThanOrEqual(request.QuantidadeAgendamentosSince.Value);
				}
				if (request.QuantidadeAgendamentosUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.QuantidadeAgendamentosLessThan(request.QuantidadeAgendamentosUntil.Value);
					else
						filter &= AgendaExameSpecifications.QuantidadeAgendamentosLessThan(request.QuantidadeAgendamentosUntil.Value);
				}
				if (request.QuantidadeEncaixesEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.QuantidadeEncaixesEqual(request.QuantidadeEncaixesEqual.Value);
					else
						filter &= AgendaExameSpecifications.QuantidadeEncaixesEqual(request.QuantidadeEncaixesEqual.Value);
				}
				if (request.QuantidadeEncaixesSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.QuantidadeEncaixesGreatThanOrEqual(request.QuantidadeEncaixesSince.Value);
					else
						filter &= AgendaExameSpecifications.QuantidadeEncaixesGreatThanOrEqual(request.QuantidadeEncaixesSince.Value);
				}
				if (request.QuantidadeEncaixesUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.QuantidadeEncaixesLessThan(request.QuantidadeEncaixesUntil.Value);
					else
						filter &= AgendaExameSpecifications.QuantidadeEncaixesLessThan(request.QuantidadeEncaixesUntil.Value);
				}
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= AgendaExameSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= AgendaExameSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= AgendaExameSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
				if (request.AtivoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.AtivoEqual(request.AtivoEqual.Value);
					else
						filter &= AgendaExameSpecifications.AtivoEqual(request.AtivoEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AgendaExameSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AgendaExameSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AgendaExameSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AgendaExameSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AgendaExameSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AgendaExameSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AgendaExameSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AgendaExameSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AgendaExameSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AgendaExameSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AgendaExameSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AgendaExameSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AgendaExameSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AgendaExameSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AgendaExameSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class AgendaSalaFilters 
	{
		public static Expression<Func<AgendaSala, bool>> GetFilters(this AgendaSalaQueryModel request, bool isOrSpecification = false) 
		{
			Specification<AgendaSala> filter = new DirectSpecification<AgendaSala>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.DataInicioEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DataInicioEqual(request.DataInicioEqual.Value);
					else
						filter &= AgendaSalaSpecifications.DataInicioEqual(request.DataInicioEqual.Value);
				}
				if (request.DataInicioSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DataInicioGreatThanOrEqual(request.DataInicioSince.Value);
					else
						filter &= AgendaSalaSpecifications.DataInicioGreatThanOrEqual(request.DataInicioSince.Value);
				}
				if (request.DataInicioUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DataInicioLessThan(request.DataInicioUntil.Value);
					else
						filter &= AgendaSalaSpecifications.DataInicioLessThan(request.DataInicioUntil.Value);
				}
				if (request.DataFimEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DataFimEqual(request.DataFimEqual.Value);
					else
						filter &= AgendaSalaSpecifications.DataFimEqual(request.DataFimEqual.Value);
				}
				if (request.DataFimSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DataFimGreatThanOrEqual(request.DataFimSince.Value);
					else
						filter &= AgendaSalaSpecifications.DataFimGreatThanOrEqual(request.DataFimSince.Value);
				}
				if (request.DataFimUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DataFimLessThan(request.DataFimUntil.Value);
					else
						filter &= AgendaSalaSpecifications.DataFimLessThan(request.DataFimUntil.Value);
				}
				if (request.TempoAtendimentoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.TempoAtendimentoEqual(request.TempoAtendimentoEqual.Value);
					else
						filter &= AgendaSalaSpecifications.TempoAtendimentoEqual(request.TempoAtendimentoEqual.Value);
				}
				if (request.TempoAtendimentoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.TempoAtendimentoGreatThanOrEqual(request.TempoAtendimentoSince.Value);
					else
						filter &= AgendaSalaSpecifications.TempoAtendimentoGreatThanOrEqual(request.TempoAtendimentoSince.Value);
				}
				if (request.TempoAtendimentoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.TempoAtendimentoLessThan(request.TempoAtendimentoUntil.Value);
					else
						filter &= AgendaSalaSpecifications.TempoAtendimentoLessThan(request.TempoAtendimentoUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.TipoEqual(request.TipoEqual);
					else
						filter &= AgendaSalaSpecifications.TipoEqual(request.TipoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.TipoNotEqual(request.TipoNotEqual);
					else
						filter &= AgendaSalaSpecifications.TipoNotEqual(request.TipoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.TipoContains(request.TipoContains);
					else
						filter &= AgendaSalaSpecifications.TipoContains(request.TipoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.TipoStartsWith(request.TipoStartsWith);
					else
						filter &= AgendaSalaSpecifications.TipoStartsWith(request.TipoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.AgendaStatusEqual(request.AgendaStatusEqual);
					else
						filter &= AgendaSalaSpecifications.AgendaStatusEqual(request.AgendaStatusEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.AgendaStatusNotEqual(request.AgendaStatusNotEqual);
					else
						filter &= AgendaSalaSpecifications.AgendaStatusNotEqual(request.AgendaStatusNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.AgendaStatusContains(request.AgendaStatusContains);
					else
						filter &= AgendaSalaSpecifications.AgendaStatusContains(request.AgendaStatusContains);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.AgendaStatusStartsWith(request.AgendaStatusStartsWith);
					else
						filter &= AgendaSalaSpecifications.AgendaStatusStartsWith(request.AgendaStatusStartsWith);
				}
				if (request.QuantidadeAgendamentosEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.QuantidadeAgendamentosEqual(request.QuantidadeAgendamentosEqual.Value);
					else
						filter &= AgendaSalaSpecifications.QuantidadeAgendamentosEqual(request.QuantidadeAgendamentosEqual.Value);
				}
				if (request.QuantidadeAgendamentosSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.QuantidadeAgendamentosGreatThanOrEqual(request.QuantidadeAgendamentosSince.Value);
					else
						filter &= AgendaSalaSpecifications.QuantidadeAgendamentosGreatThanOrEqual(request.QuantidadeAgendamentosSince.Value);
				}
				if (request.QuantidadeAgendamentosUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.QuantidadeAgendamentosLessThan(request.QuantidadeAgendamentosUntil.Value);
					else
						filter &= AgendaSalaSpecifications.QuantidadeAgendamentosLessThan(request.QuantidadeAgendamentosUntil.Value);
				}
				if (request.QuantidadeEncaixesEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.QuantidadeEncaixesEqual(request.QuantidadeEncaixesEqual.Value);
					else
						filter &= AgendaSalaSpecifications.QuantidadeEncaixesEqual(request.QuantidadeEncaixesEqual.Value);
				}
				if (request.QuantidadeEncaixesSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.QuantidadeEncaixesGreatThanOrEqual(request.QuantidadeEncaixesSince.Value);
					else
						filter &= AgendaSalaSpecifications.QuantidadeEncaixesGreatThanOrEqual(request.QuantidadeEncaixesSince.Value);
				}
				if (request.QuantidadeEncaixesUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.QuantidadeEncaixesLessThan(request.QuantidadeEncaixesUntil.Value);
					else
						filter &= AgendaSalaSpecifications.QuantidadeEncaixesLessThan(request.QuantidadeEncaixesUntil.Value);
				}
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= AgendaSalaSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= AgendaSalaSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= AgendaSalaSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
				if (request.AtivoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.AtivoEqual(request.AtivoEqual.Value);
					else
						filter &= AgendaSalaSpecifications.AtivoEqual(request.AtivoEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AgendaSalaSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AgendaSalaSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AgendaSalaSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AgendaSalaSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AgendaSalaSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AgendaSalaSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AgendaSalaSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AgendaSalaSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AgendaSalaSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AgendaSalaSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AgendaSalaSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AgendaSalaSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AgendaSalaSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AgendaSalaSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AgendaSalaSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AgendaSalaSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
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
	public static class AgendaProfissionalFilters 
	{
		public static Expression<Func<AgendaProfissional, bool>> GetFilters(this AgendaProfissionalQueryModel request, bool isOrSpecification = false) 
		{
			Specification<AgendaProfissional> filter = new DirectSpecification<AgendaProfissional>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.ProfissionalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ProfissionalIdEqual(request.ProfissionalIdEqual);
					else
						filter &= AgendaProfissionalSpecifications.ProfissionalIdEqual(request.ProfissionalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ProfissionalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ProfissionalIdNotEqual(request.ProfissionalIdNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.ProfissionalIdNotEqual(request.ProfissionalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ProfissionalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ProfissionalIdContains(request.ProfissionalIdContains);
					else
						filter &= AgendaProfissionalSpecifications.ProfissionalIdContains(request.ProfissionalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ProfissionalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ProfissionalIdStartsWith(request.ProfissionalIdStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.ProfissionalIdStartsWith(request.ProfissionalIdStartsWith);
				}
				if (request.DataInicioEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DataInicioEqual(request.DataInicioEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.DataInicioEqual(request.DataInicioEqual.Value);
				}
				if (request.DataInicioSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DataInicioGreatThanOrEqual(request.DataInicioSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.DataInicioGreatThanOrEqual(request.DataInicioSince.Value);
				}
				if (request.DataInicioUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DataInicioLessThan(request.DataInicioUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.DataInicioLessThan(request.DataInicioUntil.Value);
				}
				if (request.DataFimEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DataFimEqual(request.DataFimEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.DataFimEqual(request.DataFimEqual.Value);
				}
				if (request.DataFimSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DataFimGreatThanOrEqual(request.DataFimSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.DataFimGreatThanOrEqual(request.DataFimSince.Value);
				}
				if (request.DataFimUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DataFimLessThan(request.DataFimUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.DataFimLessThan(request.DataFimUntil.Value);
				}
				if (request.TempoAtendimentoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.TempoAtendimentoEqual(request.TempoAtendimentoEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.TempoAtendimentoEqual(request.TempoAtendimentoEqual.Value);
				}
				if (request.TempoAtendimentoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.TempoAtendimentoGreatThanOrEqual(request.TempoAtendimentoSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.TempoAtendimentoGreatThanOrEqual(request.TempoAtendimentoSince.Value);
				}
				if (request.TempoAtendimentoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.TempoAtendimentoLessThan(request.TempoAtendimentoUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.TempoAtendimentoLessThan(request.TempoAtendimentoUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.TipoEqual(request.TipoEqual);
					else
						filter &= AgendaProfissionalSpecifications.TipoEqual(request.TipoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.TipoNotEqual(request.TipoNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.TipoNotEqual(request.TipoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.TipoContains(request.TipoContains);
					else
						filter &= AgendaProfissionalSpecifications.TipoContains(request.TipoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.TipoStartsWith(request.TipoStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.TipoStartsWith(request.TipoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.AgendaStatusEqual(request.AgendaStatusEqual);
					else
						filter &= AgendaProfissionalSpecifications.AgendaStatusEqual(request.AgendaStatusEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.AgendaStatusNotEqual(request.AgendaStatusNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.AgendaStatusNotEqual(request.AgendaStatusNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.AgendaStatusContains(request.AgendaStatusContains);
					else
						filter &= AgendaProfissionalSpecifications.AgendaStatusContains(request.AgendaStatusContains);
				}
				if (!string.IsNullOrWhiteSpace(request.AgendaStatusStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.AgendaStatusStartsWith(request.AgendaStatusStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.AgendaStatusStartsWith(request.AgendaStatusStartsWith);
				}
				if (request.QuantidadeAgendamentosEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.QuantidadeAgendamentosEqual(request.QuantidadeAgendamentosEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.QuantidadeAgendamentosEqual(request.QuantidadeAgendamentosEqual.Value);
				}
				if (request.QuantidadeAgendamentosSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.QuantidadeAgendamentosGreatThanOrEqual(request.QuantidadeAgendamentosSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.QuantidadeAgendamentosGreatThanOrEqual(request.QuantidadeAgendamentosSince.Value);
				}
				if (request.QuantidadeAgendamentosUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.QuantidadeAgendamentosLessThan(request.QuantidadeAgendamentosUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.QuantidadeAgendamentosLessThan(request.QuantidadeAgendamentosUntil.Value);
				}
				if (request.QuantidadeEncaixesEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.QuantidadeEncaixesEqual(request.QuantidadeEncaixesEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.QuantidadeEncaixesEqual(request.QuantidadeEncaixesEqual.Value);
				}
				if (request.QuantidadeEncaixesSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.QuantidadeEncaixesGreatThanOrEqual(request.QuantidadeEncaixesSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.QuantidadeEncaixesGreatThanOrEqual(request.QuantidadeEncaixesSince.Value);
				}
				if (request.QuantidadeEncaixesUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.QuantidadeEncaixesLessThan(request.QuantidadeEncaixesUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.QuantidadeEncaixesLessThan(request.QuantidadeEncaixesUntil.Value);
				}
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
				if (request.AtivoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.AtivoEqual(request.AtivoEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.AtivoEqual(request.AtivoEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AgendaProfissionalSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AgendaProfissionalSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AgendaProfissionalSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AgendaProfissionalSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AgendaProfissionalSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class ProfissionalConfiguracaoFilters 
	{
		public static Expression<Func<ProfissionalConfiguracao, bool>> GetFilters(this ProfissionalConfiguracaoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<ProfissionalConfiguracao> filter = new DirectSpecification<ProfissionalConfiguracao>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.SetorProprioEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.SetorProprioEqual(request.SetorProprioEqual.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.SetorProprioEqual(request.SetorProprioEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ProfissionalConfiguracaoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ProfissionalConfiguracaoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ProfissionalConfiguracaoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ProfissionalConfiguracaoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ProfissionalConfiguracaoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ProfissionalConfiguracaoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class FuncionarioFilters 
	{
		public static Expression<Func<Funcionario, bool>> GetFilters(this FuncionarioQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Funcionario> filter = new DirectSpecification<Funcionario>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= FuncionarioSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= FuncionarioSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeContains(request.NomeContains);
					else
						filter &= FuncionarioSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= FuncionarioSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeSocialEqual(request.NomeSocialEqual);
					else
						filter &= FuncionarioSpecifications.NomeSocialEqual(request.NomeSocialEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeSocialNotEqual(request.NomeSocialNotEqual);
					else
						filter &= FuncionarioSpecifications.NomeSocialNotEqual(request.NomeSocialNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeSocialContains(request.NomeSocialContains);
					else
						filter &= FuncionarioSpecifications.NomeSocialContains(request.NomeSocialContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.NomeSocialStartsWith(request.NomeSocialStartsWith);
					else
						filter &= FuncionarioSpecifications.NomeSocialStartsWith(request.NomeSocialStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CPFEqual(request.CPFEqual);
					else
						filter &= FuncionarioSpecifications.CPFEqual(request.CPFEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CPFNotEqual(request.CPFNotEqual);
					else
						filter &= FuncionarioSpecifications.CPFNotEqual(request.CPFNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CPFContains(request.CPFContains);
					else
						filter &= FuncionarioSpecifications.CPFContains(request.CPFContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CPFStartsWith(request.CPFStartsWith);
					else
						filter &= FuncionarioSpecifications.CPFStartsWith(request.CPFStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CNPJEqual(request.CNPJEqual);
					else
						filter &= FuncionarioSpecifications.CNPJEqual(request.CNPJEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CNPJNotEqual(request.CNPJNotEqual);
					else
						filter &= FuncionarioSpecifications.CNPJNotEqual(request.CNPJNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CNPJContains(request.CNPJContains);
					else
						filter &= FuncionarioSpecifications.CNPJContains(request.CNPJContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CNPJStartsWith(request.CNPJStartsWith);
					else
						filter &= FuncionarioSpecifications.CNPJStartsWith(request.CNPJStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.UsuarioLoginEqual(request.UsuarioLoginEqual);
					else
						filter &= FuncionarioSpecifications.UsuarioLoginEqual(request.UsuarioLoginEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.UsuarioLoginNotEqual(request.UsuarioLoginNotEqual);
					else
						filter &= FuncionarioSpecifications.UsuarioLoginNotEqual(request.UsuarioLoginNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.UsuarioLoginContains(request.UsuarioLoginContains);
					else
						filter &= FuncionarioSpecifications.UsuarioLoginContains(request.UsuarioLoginContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.UsuarioLoginStartsWith(request.UsuarioLoginStartsWith);
					else
						filter &= FuncionarioSpecifications.UsuarioLoginStartsWith(request.UsuarioLoginStartsWith);
				}
				if (request.DataNascimentoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.DataNascimentoEqual(request.DataNascimentoEqual.Value);
					else
						filter &= FuncionarioSpecifications.DataNascimentoEqual(request.DataNascimentoEqual.Value);
				}
				if (request.DataNascimentoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.DataNascimentoGreatThanOrEqual(request.DataNascimentoSince.Value);
					else
						filter &= FuncionarioSpecifications.DataNascimentoGreatThanOrEqual(request.DataNascimentoSince.Value);
				}
				if (request.DataNascimentoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.DataNascimentoLessThan(request.DataNascimentoUntil.Value);
					else
						filter &= FuncionarioSpecifications.DataNascimentoLessThan(request.DataNascimentoUntil.Value);
				}
				if (request.GeneroEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.GeneroEqual(request.GeneroEqual.Value);
					else
						filter &= FuncionarioSpecifications.GeneroEqual(request.GeneroEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EspecialidadeEqual(request.EspecialidadeEqual);
					else
						filter &= FuncionarioSpecifications.EspecialidadeEqual(request.EspecialidadeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EspecialidadeNotEqual(request.EspecialidadeNotEqual);
					else
						filter &= FuncionarioSpecifications.EspecialidadeNotEqual(request.EspecialidadeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EspecialidadeContains(request.EspecialidadeContains);
					else
						filter &= FuncionarioSpecifications.EspecialidadeContains(request.EspecialidadeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EspecialidadeStartsWith(request.EspecialidadeStartsWith);
					else
						filter &= FuncionarioSpecifications.EspecialidadeStartsWith(request.EspecialidadeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.SubEspecialidadeEqual(request.SubEspecialidadeEqual);
					else
						filter &= FuncionarioSpecifications.SubEspecialidadeEqual(request.SubEspecialidadeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.SubEspecialidadeNotEqual(request.SubEspecialidadeNotEqual);
					else
						filter &= FuncionarioSpecifications.SubEspecialidadeNotEqual(request.SubEspecialidadeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.SubEspecialidadeContains(request.SubEspecialidadeContains);
					else
						filter &= FuncionarioSpecifications.SubEspecialidadeContains(request.SubEspecialidadeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.SubEspecialidadeStartsWith(request.SubEspecialidadeStartsWith);
					else
						filter &= FuncionarioSpecifications.SubEspecialidadeStartsWith(request.SubEspecialidadeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CorpoClinicoEqual(request.CorpoClinicoEqual);
					else
						filter &= FuncionarioSpecifications.CorpoClinicoEqual(request.CorpoClinicoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CorpoClinicoNotEqual(request.CorpoClinicoNotEqual);
					else
						filter &= FuncionarioSpecifications.CorpoClinicoNotEqual(request.CorpoClinicoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CorpoClinicoContains(request.CorpoClinicoContains);
					else
						filter &= FuncionarioSpecifications.CorpoClinicoContains(request.CorpoClinicoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CorpoClinicoStartsWith(request.CorpoClinicoStartsWith);
					else
						filter &= FuncionarioSpecifications.CorpoClinicoStartsWith(request.CorpoClinicoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoSusEqual(request.CodigoSusEqual);
					else
						filter &= FuncionarioSpecifications.CodigoSusEqual(request.CodigoSusEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoSusNotEqual(request.CodigoSusNotEqual);
					else
						filter &= FuncionarioSpecifications.CodigoSusNotEqual(request.CodigoSusNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoSusContains(request.CodigoSusContains);
					else
						filter &= FuncionarioSpecifications.CodigoSusContains(request.CodigoSusContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoSusStartsWith(request.CodigoSusStartsWith);
					else
						filter &= FuncionarioSpecifications.CodigoSusStartsWith(request.CodigoSusStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoCnesEqual(request.CodigoCnesEqual);
					else
						filter &= FuncionarioSpecifications.CodigoCnesEqual(request.CodigoCnesEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoCnesNotEqual(request.CodigoCnesNotEqual);
					else
						filter &= FuncionarioSpecifications.CodigoCnesNotEqual(request.CodigoCnesNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoCnesContains(request.CodigoCnesContains);
					else
						filter &= FuncionarioSpecifications.CodigoCnesContains(request.CodigoCnesContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CodigoCnesStartsWith(request.CodigoCnesStartsWith);
					else
						filter &= FuncionarioSpecifications.CodigoCnesStartsWith(request.CodigoCnesStartsWith);
				}
				if (request.CboIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CboIdEqual(request.CboIdEqual.Value);
					else
						filter &= FuncionarioSpecifications.CboIdEqual(request.CboIdEqual.Value);
				}
				if (request.CboIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CboIdGreatThanOrEqual(request.CboIdSince.Value);
					else
						filter &= FuncionarioSpecifications.CboIdGreatThanOrEqual(request.CboIdSince.Value);
				}
				if (request.CboIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CboIdLessThan(request.CboIdUntil.Value);
					else
						filter &= FuncionarioSpecifications.CboIdLessThan(request.CboIdUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ConvenioEqual(request.ConvenioEqual);
					else
						filter &= FuncionarioSpecifications.ConvenioEqual(request.ConvenioEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ConvenioNotEqual(request.ConvenioNotEqual);
					else
						filter &= FuncionarioSpecifications.ConvenioNotEqual(request.ConvenioNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ConvenioContains(request.ConvenioContains);
					else
						filter &= FuncionarioSpecifications.ConvenioContains(request.ConvenioContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ConvenioStartsWith(request.ConvenioStartsWith);
					else
						filter &= FuncionarioSpecifications.ConvenioStartsWith(request.ConvenioStartsWith);
				}
				if (request.EscolaridadeEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EscolaridadeEqual(request.EscolaridadeEqual.Value);
					else
						filter &= FuncionarioSpecifications.EscolaridadeEqual(request.EscolaridadeEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.FuncaoEqual(request.FuncaoEqual);
					else
						filter &= FuncionarioSpecifications.FuncaoEqual(request.FuncaoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.FuncaoNotEqual(request.FuncaoNotEqual);
					else
						filter &= FuncionarioSpecifications.FuncaoNotEqual(request.FuncaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.FuncaoContains(request.FuncaoContains);
					else
						filter &= FuncionarioSpecifications.FuncaoContains(request.FuncaoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.FuncaoStartsWith(request.FuncaoStartsWith);
					else
						filter &= FuncionarioSpecifications.FuncaoStartsWith(request.FuncaoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CargosEqual(request.CargosEqual);
					else
						filter &= FuncionarioSpecifications.CargosEqual(request.CargosEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CargosNotEqual(request.CargosNotEqual);
					else
						filter &= FuncionarioSpecifications.CargosNotEqual(request.CargosNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CargosContains(request.CargosContains);
					else
						filter &= FuncionarioSpecifications.CargosContains(request.CargosContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CargosStartsWith(request.CargosStartsWith);
					else
						filter &= FuncionarioSpecifications.CargosStartsWith(request.CargosStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.TelefoneEqual(request.TelefoneEqual);
					else
						filter &= FuncionarioSpecifications.TelefoneEqual(request.TelefoneEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
					else
						filter &= FuncionarioSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.TelefoneContains(request.TelefoneContains);
					else
						filter &= FuncionarioSpecifications.TelefoneContains(request.TelefoneContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
					else
						filter &= FuncionarioSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
				}
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= FuncionarioSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= FuncionarioSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= FuncionarioSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= FuncionarioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= FuncionarioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= FuncionarioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= FuncionarioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= FuncionarioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= FuncionarioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= FuncionarioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= FuncionarioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= FuncionarioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.IdEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.IdEqual(request.IdEqual);
					else
						filter &= FuncionarioSpecifications.IdEqual(request.IdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.IdNotEqual(request.IdNotEqual);
					else
						filter &= FuncionarioSpecifications.IdNotEqual(request.IdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.IdContains(request.IdContains);
					else
						filter &= FuncionarioSpecifications.IdContains(request.IdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.IdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.IdStartsWith(request.IdStartsWith);
					else
						filter &= FuncionarioSpecifications.IdStartsWith(request.IdStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= FuncionarioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= FuncionarioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= FuncionarioSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= FuncionarioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= FuncionarioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= FuncionarioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class ProfissionalFilters 
	{
		public static Expression<Func<Profissional, bool>> GetFilters(this ProfissionalQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Profissional> filter = new DirectSpecification<Profissional>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= ProfissionalSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= ProfissionalSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeContains(request.NomeContains);
					else
						filter &= ProfissionalSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= ProfissionalSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeSocialEqual(request.NomeSocialEqual);
					else
						filter &= ProfissionalSpecifications.NomeSocialEqual(request.NomeSocialEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeSocialNotEqual(request.NomeSocialNotEqual);
					else
						filter &= ProfissionalSpecifications.NomeSocialNotEqual(request.NomeSocialNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeSocialContains(request.NomeSocialContains);
					else
						filter &= ProfissionalSpecifications.NomeSocialContains(request.NomeSocialContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeSocialStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.NomeSocialStartsWith(request.NomeSocialStartsWith);
					else
						filter &= ProfissionalSpecifications.NomeSocialStartsWith(request.NomeSocialStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CPFEqual(request.CPFEqual);
					else
						filter &= ProfissionalSpecifications.CPFEqual(request.CPFEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CPFNotEqual(request.CPFNotEqual);
					else
						filter &= ProfissionalSpecifications.CPFNotEqual(request.CPFNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CPFContains(request.CPFContains);
					else
						filter &= ProfissionalSpecifications.CPFContains(request.CPFContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CPFStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CPFStartsWith(request.CPFStartsWith);
					else
						filter &= ProfissionalSpecifications.CPFStartsWith(request.CPFStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CNPJEqual(request.CNPJEqual);
					else
						filter &= ProfissionalSpecifications.CNPJEqual(request.CNPJEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CNPJNotEqual(request.CNPJNotEqual);
					else
						filter &= ProfissionalSpecifications.CNPJNotEqual(request.CNPJNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CNPJContains(request.CNPJContains);
					else
						filter &= ProfissionalSpecifications.CNPJContains(request.CNPJContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CNPJStartsWith(request.CNPJStartsWith);
					else
						filter &= ProfissionalSpecifications.CNPJStartsWith(request.CNPJStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.UsuarioLoginEqual(request.UsuarioLoginEqual);
					else
						filter &= ProfissionalSpecifications.UsuarioLoginEqual(request.UsuarioLoginEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.UsuarioLoginNotEqual(request.UsuarioLoginNotEqual);
					else
						filter &= ProfissionalSpecifications.UsuarioLoginNotEqual(request.UsuarioLoginNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.UsuarioLoginContains(request.UsuarioLoginContains);
					else
						filter &= ProfissionalSpecifications.UsuarioLoginContains(request.UsuarioLoginContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UsuarioLoginStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.UsuarioLoginStartsWith(request.UsuarioLoginStartsWith);
					else
						filter &= ProfissionalSpecifications.UsuarioLoginStartsWith(request.UsuarioLoginStartsWith);
				}
				if (request.DataNascimentoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.DataNascimentoEqual(request.DataNascimentoEqual.Value);
					else
						filter &= ProfissionalSpecifications.DataNascimentoEqual(request.DataNascimentoEqual.Value);
				}
				if (request.DataNascimentoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.DataNascimentoGreatThanOrEqual(request.DataNascimentoSince.Value);
					else
						filter &= ProfissionalSpecifications.DataNascimentoGreatThanOrEqual(request.DataNascimentoSince.Value);
				}
				if (request.DataNascimentoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.DataNascimentoLessThan(request.DataNascimentoUntil.Value);
					else
						filter &= ProfissionalSpecifications.DataNascimentoLessThan(request.DataNascimentoUntil.Value);
				}
				if (request.GeneroEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.GeneroEqual(request.GeneroEqual.Value);
					else
						filter &= ProfissionalSpecifications.GeneroEqual(request.GeneroEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EspecialidadeEqual(request.EspecialidadeEqual);
					else
						filter &= ProfissionalSpecifications.EspecialidadeEqual(request.EspecialidadeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EspecialidadeNotEqual(request.EspecialidadeNotEqual);
					else
						filter &= ProfissionalSpecifications.EspecialidadeNotEqual(request.EspecialidadeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EspecialidadeContains(request.EspecialidadeContains);
					else
						filter &= ProfissionalSpecifications.EspecialidadeContains(request.EspecialidadeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.EspecialidadeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EspecialidadeStartsWith(request.EspecialidadeStartsWith);
					else
						filter &= ProfissionalSpecifications.EspecialidadeStartsWith(request.EspecialidadeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.SubEspecialidadeEqual(request.SubEspecialidadeEqual);
					else
						filter &= ProfissionalSpecifications.SubEspecialidadeEqual(request.SubEspecialidadeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.SubEspecialidadeNotEqual(request.SubEspecialidadeNotEqual);
					else
						filter &= ProfissionalSpecifications.SubEspecialidadeNotEqual(request.SubEspecialidadeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.SubEspecialidadeContains(request.SubEspecialidadeContains);
					else
						filter &= ProfissionalSpecifications.SubEspecialidadeContains(request.SubEspecialidadeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.SubEspecialidadeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.SubEspecialidadeStartsWith(request.SubEspecialidadeStartsWith);
					else
						filter &= ProfissionalSpecifications.SubEspecialidadeStartsWith(request.SubEspecialidadeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CorpoClinicoEqual(request.CorpoClinicoEqual);
					else
						filter &= ProfissionalSpecifications.CorpoClinicoEqual(request.CorpoClinicoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CorpoClinicoNotEqual(request.CorpoClinicoNotEqual);
					else
						filter &= ProfissionalSpecifications.CorpoClinicoNotEqual(request.CorpoClinicoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CorpoClinicoContains(request.CorpoClinicoContains);
					else
						filter &= ProfissionalSpecifications.CorpoClinicoContains(request.CorpoClinicoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CorpoClinicoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CorpoClinicoStartsWith(request.CorpoClinicoStartsWith);
					else
						filter &= ProfissionalSpecifications.CorpoClinicoStartsWith(request.CorpoClinicoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoSusEqual(request.CodigoSusEqual);
					else
						filter &= ProfissionalSpecifications.CodigoSusEqual(request.CodigoSusEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoSusNotEqual(request.CodigoSusNotEqual);
					else
						filter &= ProfissionalSpecifications.CodigoSusNotEqual(request.CodigoSusNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoSusContains(request.CodigoSusContains);
					else
						filter &= ProfissionalSpecifications.CodigoSusContains(request.CodigoSusContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSusStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoSusStartsWith(request.CodigoSusStartsWith);
					else
						filter &= ProfissionalSpecifications.CodigoSusStartsWith(request.CodigoSusStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoCnesEqual(request.CodigoCnesEqual);
					else
						filter &= ProfissionalSpecifications.CodigoCnesEqual(request.CodigoCnesEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoCnesNotEqual(request.CodigoCnesNotEqual);
					else
						filter &= ProfissionalSpecifications.CodigoCnesNotEqual(request.CodigoCnesNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoCnesContains(request.CodigoCnesContains);
					else
						filter &= ProfissionalSpecifications.CodigoCnesContains(request.CodigoCnesContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoCnesStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CodigoCnesStartsWith(request.CodigoCnesStartsWith);
					else
						filter &= ProfissionalSpecifications.CodigoCnesStartsWith(request.CodigoCnesStartsWith);
				}
				if (request.CboIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CboIdEqual(request.CboIdEqual.Value);
					else
						filter &= ProfissionalSpecifications.CboIdEqual(request.CboIdEqual.Value);
				}
				if (request.CboIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CboIdGreatThanOrEqual(request.CboIdSince.Value);
					else
						filter &= ProfissionalSpecifications.CboIdGreatThanOrEqual(request.CboIdSince.Value);
				}
				if (request.CboIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CboIdLessThan(request.CboIdUntil.Value);
					else
						filter &= ProfissionalSpecifications.CboIdLessThan(request.CboIdUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ConvenioEqual(request.ConvenioEqual);
					else
						filter &= ProfissionalSpecifications.ConvenioEqual(request.ConvenioEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ConvenioNotEqual(request.ConvenioNotEqual);
					else
						filter &= ProfissionalSpecifications.ConvenioNotEqual(request.ConvenioNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ConvenioContains(request.ConvenioContains);
					else
						filter &= ProfissionalSpecifications.ConvenioContains(request.ConvenioContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ConvenioStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.ConvenioStartsWith(request.ConvenioStartsWith);
					else
						filter &= ProfissionalSpecifications.ConvenioStartsWith(request.ConvenioStartsWith);
				}
				if (request.EscolaridadeEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EscolaridadeEqual(request.EscolaridadeEqual.Value);
					else
						filter &= ProfissionalSpecifications.EscolaridadeEqual(request.EscolaridadeEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.FuncaoEqual(request.FuncaoEqual);
					else
						filter &= ProfissionalSpecifications.FuncaoEqual(request.FuncaoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.FuncaoNotEqual(request.FuncaoNotEqual);
					else
						filter &= ProfissionalSpecifications.FuncaoNotEqual(request.FuncaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.FuncaoContains(request.FuncaoContains);
					else
						filter &= ProfissionalSpecifications.FuncaoContains(request.FuncaoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.FuncaoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.FuncaoStartsWith(request.FuncaoStartsWith);
					else
						filter &= ProfissionalSpecifications.FuncaoStartsWith(request.FuncaoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CargosEqual(request.CargosEqual);
					else
						filter &= ProfissionalSpecifications.CargosEqual(request.CargosEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CargosNotEqual(request.CargosNotEqual);
					else
						filter &= ProfissionalSpecifications.CargosNotEqual(request.CargosNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CargosContains(request.CargosContains);
					else
						filter &= ProfissionalSpecifications.CargosContains(request.CargosContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CargosStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.CargosStartsWith(request.CargosStartsWith);
					else
						filter &= ProfissionalSpecifications.CargosStartsWith(request.CargosStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.TelefoneEqual(request.TelefoneEqual);
					else
						filter &= ProfissionalSpecifications.TelefoneEqual(request.TelefoneEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
					else
						filter &= ProfissionalSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneContains)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.TelefoneContains(request.TelefoneContains);
					else
						filter &= ProfissionalSpecifications.TelefoneContains(request.TelefoneContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
					else
						filter &= ProfissionalSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
				}
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= ProfissionalSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= ProfissionalSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfissionalSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= ProfissionalSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
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
	public static class ProfessionalsAggSettingsFilters 
	{
		public static Expression<Func<ProfessionalsAggSettings, bool>> GetFilters(this ProfessionalsAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<ProfessionalsAggSettings> filter = new DirectSpecification<ProfessionalsAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= ProfessionalsAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= ProfessionalsAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= ProfessionalsAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= ProfessionalsAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ProfessionalsAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ProfessionalsAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ProfessionalsAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ProfessionalsAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ProfessionalsAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ProfessionalsAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class CboFilters 
	{
		public static Expression<Func<Cbo, bool>> GetFilters(this CboQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Cbo> filter = new DirectSpecification<Cbo>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.CodigoEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.CodigoEqual(request.CodigoEqual);
					else
						filter &= CboSpecifications.CodigoEqual(request.CodigoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.CodigoNotEqual(request.CodigoNotEqual);
					else
						filter &= CboSpecifications.CodigoNotEqual(request.CodigoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoContains)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.CodigoContains(request.CodigoContains);
					else
						filter &= CboSpecifications.CodigoContains(request.CodigoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.CodigoStartsWith(request.CodigoStartsWith);
					else
						filter &= CboSpecifications.CodigoStartsWith(request.CodigoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TitulosEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TitulosEqual(request.TitulosEqual);
					else
						filter &= CboSpecifications.TitulosEqual(request.TitulosEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TitulosNotEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TitulosNotEqual(request.TitulosNotEqual);
					else
						filter &= CboSpecifications.TitulosNotEqual(request.TitulosNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TitulosContains)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TitulosContains(request.TitulosContains);
					else
						filter &= CboSpecifications.TitulosContains(request.TitulosContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TitulosStartsWith)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TitulosStartsWith(request.TitulosStartsWith);
					else
						filter &= CboSpecifications.TitulosStartsWith(request.TitulosStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TipoEqual(request.TipoEqual);
					else
						filter &= CboSpecifications.TipoEqual(request.TipoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TipoNotEqual(request.TipoNotEqual);
					else
						filter &= CboSpecifications.TipoNotEqual(request.TipoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoContains)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TipoContains(request.TipoContains);
					else
						filter &= CboSpecifications.TipoContains(request.TipoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.TipoStartsWith(request.TipoStartsWith);
					else
						filter &= CboSpecifications.TipoStartsWith(request.TipoStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= CboSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= CboSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= CboSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= CboSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= CboSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= CboSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= CboSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= CboSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= CboSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CboSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= CboSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= CboSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= CboSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= CboSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= CboSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= CboSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= CboSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Professionals.Domain.Aggregates.UsersAgg.Filters{
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

