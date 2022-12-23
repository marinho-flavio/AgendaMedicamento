using Bravo.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Bravo.Core.Domain.Seedwork.Specification;
using Bravo.CrossCuting.Infra.Utils.Extensions;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class ConvenioFilters 
	{
		public static Expression<Func<Convenio, bool>> GetFilters(this ConvenioQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Convenio> filter = new DirectSpecification<Convenio>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= ConvenioSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= ConvenioSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.NomeContains(request.NomeContains);
					else
						filter &= ConvenioSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= ConvenioSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.MatriculaEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.MatriculaEqual(request.MatriculaEqual);
					else
						filter &= ConvenioSpecifications.MatriculaEqual(request.MatriculaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.MatriculaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.MatriculaNotEqual(request.MatriculaNotEqual);
					else
						filter &= ConvenioSpecifications.MatriculaNotEqual(request.MatriculaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.MatriculaContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.MatriculaContains(request.MatriculaContains);
					else
						filter &= ConvenioSpecifications.MatriculaContains(request.MatriculaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.MatriculaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.MatriculaStartsWith(request.MatriculaStartsWith);
					else
						filter &= ConvenioSpecifications.MatriculaStartsWith(request.MatriculaStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoEqual(request.CodigoEqual);
					else
						filter &= ConvenioSpecifications.CodigoEqual(request.CodigoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoNotEqual(request.CodigoNotEqual);
					else
						filter &= ConvenioSpecifications.CodigoNotEqual(request.CodigoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoContains(request.CodigoContains);
					else
						filter &= ConvenioSpecifications.CodigoContains(request.CodigoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoStartsWith(request.CodigoStartsWith);
					else
						filter &= ConvenioSpecifications.CodigoStartsWith(request.CodigoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.RegistroANSEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.RegistroANSEqual(request.RegistroANSEqual);
					else
						filter &= ConvenioSpecifications.RegistroANSEqual(request.RegistroANSEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.RegistroANSNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.RegistroANSNotEqual(request.RegistroANSNotEqual);
					else
						filter &= ConvenioSpecifications.RegistroANSNotEqual(request.RegistroANSNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.RegistroANSContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.RegistroANSContains(request.RegistroANSContains);
					else
						filter &= ConvenioSpecifications.RegistroANSContains(request.RegistroANSContains);
				}
				if (!string.IsNullOrWhiteSpace(request.RegistroANSStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.RegistroANSStartsWith(request.RegistroANSStartsWith);
					else
						filter &= ConvenioSpecifications.RegistroANSStartsWith(request.RegistroANSStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoReferenciaEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoReferenciaEqual(request.CodigoReferenciaEqual);
					else
						filter &= ConvenioSpecifications.CodigoReferenciaEqual(request.CodigoReferenciaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoReferenciaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoReferenciaNotEqual(request.CodigoReferenciaNotEqual);
					else
						filter &= ConvenioSpecifications.CodigoReferenciaNotEqual(request.CodigoReferenciaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoReferenciaContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoReferenciaContains(request.CodigoReferenciaContains);
					else
						filter &= ConvenioSpecifications.CodigoReferenciaContains(request.CodigoReferenciaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoReferenciaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CodigoReferenciaStartsWith(request.CodigoReferenciaStartsWith);
					else
						filter &= ConvenioSpecifications.CodigoReferenciaStartsWith(request.CodigoReferenciaStartsWith);
				}
				if (request.PadronizarQuantidadeDigitosEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.PadronizarQuantidadeDigitosEqual(request.PadronizarQuantidadeDigitosEqual.Value);
					else
						filter &= ConvenioSpecifications.PadronizarQuantidadeDigitosEqual(request.PadronizarQuantidadeDigitosEqual.Value);
				}
				if (request.QuantidadeDigitosEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.QuantidadeDigitosEqual(request.QuantidadeDigitosEqual.Value);
					else
						filter &= ConvenioSpecifications.QuantidadeDigitosEqual(request.QuantidadeDigitosEqual.Value);
				}
				if (request.QuantidadeDigitosSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.QuantidadeDigitosGreatThanOrEqual(request.QuantidadeDigitosSince.Value);
					else
						filter &= ConvenioSpecifications.QuantidadeDigitosGreatThanOrEqual(request.QuantidadeDigitosSince.Value);
				}
				if (request.QuantidadeDigitosUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.QuantidadeDigitosLessThan(request.QuantidadeDigitosUntil.Value);
					else
						filter &= ConvenioSpecifications.QuantidadeDigitosLessThan(request.QuantidadeDigitosUntil.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ConvenioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ConvenioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ConvenioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ConvenioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ConvenioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ConvenioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ConvenioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ConvenioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ConvenioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ConvenioSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ConvenioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ConvenioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ConvenioSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ConvenioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConvenioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ConvenioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class HealthPlansAggSettingsFilters 
	{
		public static Expression<Func<HealthPlansAggSettings, bool>> GetFilters(this HealthPlansAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<HealthPlansAggSettings> filter = new DirectSpecification<HealthPlansAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= HealthPlansAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= HealthPlansAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= HealthPlansAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= HealthPlansAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= HealthPlansAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= HealthPlansAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= HealthPlansAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= HealthPlansAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= HealthPlansAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= HealthPlansAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class PlanoConvenioFilters 
	{
		public static Expression<Func<PlanoConvenio, bool>> GetFilters(this PlanoConvenioQueryModel request, bool isOrSpecification = false) 
		{
			Specification<PlanoConvenio> filter = new DirectSpecification<PlanoConvenio>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.ConvenioIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ConvenioIdEqual(request.ConvenioIdEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ConvenioIdEqual(request.ConvenioIdEqual.Value);
				}
				if (request.ConvenioIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ConvenioIdGreatThanOrEqual(request.ConvenioIdSince.Value);
					else
						filter &= PlanoConvenioSpecifications.ConvenioIdGreatThanOrEqual(request.ConvenioIdSince.Value);
				}
				if (request.ConvenioIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ConvenioIdLessThan(request.ConvenioIdUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.ConvenioIdLessThan(request.ConvenioIdUntil.Value);
				}
				if (request.ClassificacaoServicoHospitalarEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ClassificacaoServicoHospitalarEqual(request.ClassificacaoServicoHospitalarEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ClassificacaoServicoHospitalarEqual(request.ClassificacaoServicoHospitalarEqual.Value);
				}
				if (request.TipoPlanoIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.TipoPlanoIdEqual(request.TipoPlanoIdEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.TipoPlanoIdEqual(request.TipoPlanoIdEqual.Value);
				}
				if (request.TipoPlanoIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.TipoPlanoIdGreatThanOrEqual(request.TipoPlanoIdSince.Value);
					else
						filter &= PlanoConvenioSpecifications.TipoPlanoIdGreatThanOrEqual(request.TipoPlanoIdSince.Value);
				}
				if (request.TipoPlanoIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.TipoPlanoIdLessThan(request.TipoPlanoIdUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.TipoPlanoIdLessThan(request.TipoPlanoIdUntil.Value);
				}
				if (request.MultiplicadorHospitalarEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorHospitalarEqual(request.MultiplicadorHospitalarEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorHospitalarEqual(request.MultiplicadorHospitalarEqual.Value);
				}
				if (request.MultiplicadorHospitalarSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorHospitalarGreatThanOrEqual(request.MultiplicadorHospitalarSince.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorHospitalarGreatThanOrEqual(request.MultiplicadorHospitalarSince.Value);
				}
				if (request.MultiplicadorHospitalarUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorHospitalarLessThan(request.MultiplicadorHospitalarUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorHospitalarLessThan(request.MultiplicadorHospitalarUntil.Value);
				}
				if (request.MultiplicadorProfissionalEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorProfissionalEqual(request.MultiplicadorProfissionalEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorProfissionalEqual(request.MultiplicadorProfissionalEqual.Value);
				}
				if (request.MultiplicadorProfissionalSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorProfissionalGreatThanOrEqual(request.MultiplicadorProfissionalSince.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorProfissionalGreatThanOrEqual(request.MultiplicadorProfissionalSince.Value);
				}
				if (request.MultiplicadorProfissionalUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorProfissionalLessThan(request.MultiplicadorProfissionalUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorProfissionalLessThan(request.MultiplicadorProfissionalUntil.Value);
				}
				if (request.MultiplicadorExameEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorExameEqual(request.MultiplicadorExameEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorExameEqual(request.MultiplicadorExameEqual.Value);
				}
				if (request.MultiplicadorExameSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorExameGreatThanOrEqual(request.MultiplicadorExameSince.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorExameGreatThanOrEqual(request.MultiplicadorExameSince.Value);
				}
				if (request.MultiplicadorExameUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MultiplicadorExameLessThan(request.MultiplicadorExameUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.MultiplicadorExameLessThan(request.MultiplicadorExameUntil.Value);
				}
				if (request.ProcedimentoPercentualPrincipalEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPercentualPrincipalEqual(request.ProcedimentoPercentualPrincipalEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPercentualPrincipalEqual(request.ProcedimentoPercentualPrincipalEqual.Value);
				}
				if (request.ProcedimentoPercentualPrincipalSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPercentualPrincipalGreatThanOrEqual(request.ProcedimentoPercentualPrincipalSince.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPercentualPrincipalGreatThanOrEqual(request.ProcedimentoPercentualPrincipalSince.Value);
				}
				if (request.ProcedimentoPercentualPrincipalUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPercentualPrincipalLessThan(request.ProcedimentoPercentualPrincipalUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPercentualPrincipalLessThan(request.ProcedimentoPercentualPrincipalUntil.Value);
				}
				if (request.ProcedimentoPrincipalDiferenteEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPrincipalDiferenteEqual(request.ProcedimentoPrincipalDiferenteEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPrincipalDiferenteEqual(request.ProcedimentoPrincipalDiferenteEqual.Value);
				}
				if (request.ProcedimentoPrincipalDiferenteSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPrincipalDiferenteGreatThanOrEqual(request.ProcedimentoPrincipalDiferenteSince.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPrincipalDiferenteGreatThanOrEqual(request.ProcedimentoPrincipalDiferenteSince.Value);
				}
				if (request.ProcedimentoPrincipalDiferenteUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPrincipalDiferenteLessThan(request.ProcedimentoPrincipalDiferenteUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPrincipalDiferenteLessThan(request.ProcedimentoPrincipalDiferenteUntil.Value);
				}
				if (request.ProcedimentoPrincipalMesmaEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPrincipalMesmaEqual(request.ProcedimentoPrincipalMesmaEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPrincipalMesmaEqual(request.ProcedimentoPrincipalMesmaEqual.Value);
				}
				if (request.ProcedimentoPrincipalMesmaSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPrincipalMesmaGreatThanOrEqual(request.ProcedimentoPrincipalMesmaSince.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPrincipalMesmaGreatThanOrEqual(request.ProcedimentoPrincipalMesmaSince.Value);
				}
				if (request.ProcedimentoPrincipalMesmaUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoPrincipalMesmaLessThan(request.ProcedimentoPrincipalMesmaUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoPrincipalMesmaLessThan(request.ProcedimentoPrincipalMesmaUntil.Value);
				}
				if (request.ProcedimentoHospitalarPrincipalEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarPrincipalEqual(request.ProcedimentoHospitalarPrincipalEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarPrincipalEqual(request.ProcedimentoHospitalarPrincipalEqual.Value);
				}
				if (request.ProcedimentoHospitalarPrincipalSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarPrincipalGreatThanOrEqual(request.ProcedimentoHospitalarPrincipalSince.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarPrincipalGreatThanOrEqual(request.ProcedimentoHospitalarPrincipalSince.Value);
				}
				if (request.ProcedimentoHospitalarPrincipalUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarPrincipalLessThan(request.ProcedimentoHospitalarPrincipalUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarPrincipalLessThan(request.ProcedimentoHospitalarPrincipalUntil.Value);
				}
				if (request.ProcedimentoHospitalarDiferenteEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarDiferenteEqual(request.ProcedimentoHospitalarDiferenteEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarDiferenteEqual(request.ProcedimentoHospitalarDiferenteEqual.Value);
				}
				if (request.ProcedimentoHospitalarDiferenteSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarDiferenteGreatThanOrEqual(request.ProcedimentoHospitalarDiferenteSince.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarDiferenteGreatThanOrEqual(request.ProcedimentoHospitalarDiferenteSince.Value);
				}
				if (request.ProcedimentoHospitalarDiferenteUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarDiferenteLessThan(request.ProcedimentoHospitalarDiferenteUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarDiferenteLessThan(request.ProcedimentoHospitalarDiferenteUntil.Value);
				}
				if (request.ProcedimentoHospitalarMesmaEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarMesmaEqual(request.ProcedimentoHospitalarMesmaEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarMesmaEqual(request.ProcedimentoHospitalarMesmaEqual.Value);
				}
				if (request.ProcedimentoHospitalarMesmaSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarMesmaGreatThanOrEqual(request.ProcedimentoHospitalarMesmaSince.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarMesmaGreatThanOrEqual(request.ProcedimentoHospitalarMesmaSince.Value);
				}
				if (request.ProcedimentoHospitalarMesmaUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ProcedimentoHospitalarMesmaLessThan(request.ProcedimentoHospitalarMesmaUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.ProcedimentoHospitalarMesmaLessThan(request.ProcedimentoHospitalarMesmaUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoMedicamentoEqual)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.DescricaoMedicamentoEqual(request.DescricaoMedicamentoEqual);
					else
						filter &= PlanoConvenioSpecifications.DescricaoMedicamentoEqual(request.DescricaoMedicamentoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoMedicamentoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.DescricaoMedicamentoNotEqual(request.DescricaoMedicamentoNotEqual);
					else
						filter &= PlanoConvenioSpecifications.DescricaoMedicamentoNotEqual(request.DescricaoMedicamentoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoMedicamentoContains)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.DescricaoMedicamentoContains(request.DescricaoMedicamentoContains);
					else
						filter &= PlanoConvenioSpecifications.DescricaoMedicamentoContains(request.DescricaoMedicamentoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoMedicamentoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.DescricaoMedicamentoStartsWith(request.DescricaoMedicamentoStartsWith);
					else
						filter &= PlanoConvenioSpecifications.DescricaoMedicamentoStartsWith(request.DescricaoMedicamentoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.MoedaMedicamentoEqual)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MoedaMedicamentoEqual(request.MoedaMedicamentoEqual);
					else
						filter &= PlanoConvenioSpecifications.MoedaMedicamentoEqual(request.MoedaMedicamentoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.MoedaMedicamentoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MoedaMedicamentoNotEqual(request.MoedaMedicamentoNotEqual);
					else
						filter &= PlanoConvenioSpecifications.MoedaMedicamentoNotEqual(request.MoedaMedicamentoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.MoedaMedicamentoContains)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MoedaMedicamentoContains(request.MoedaMedicamentoContains);
					else
						filter &= PlanoConvenioSpecifications.MoedaMedicamentoContains(request.MoedaMedicamentoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.MoedaMedicamentoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.MoedaMedicamentoStartsWith(request.MoedaMedicamentoStartsWith);
					else
						filter &= PlanoConvenioSpecifications.MoedaMedicamentoStartsWith(request.MoedaMedicamentoStartsWith);
				}
				if (request.TipoTabelaMedicamentoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.TipoTabelaMedicamentoEqual(request.TipoTabelaMedicamentoEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.TipoTabelaMedicamentoEqual(request.TipoTabelaMedicamentoEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= PlanoConvenioSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= PlanoConvenioSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= PlanoConvenioSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= PlanoConvenioSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= PlanoConvenioSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= PlanoConvenioSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= PlanoConvenioSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= PlanoConvenioSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= PlanoConvenioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= PlanoConvenioSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class TipoPlanoFilters 
	{
		public static Expression<Func<TipoPlano, bool>> GetFilters(this TipoPlanoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<TipoPlano> filter = new DirectSpecification<TipoPlano>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= TipoPlanoSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= TipoPlanoSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.NomeContains(request.NomeContains);
					else
						filter &= TipoPlanoSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= TipoPlanoSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= TipoPlanoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= TipoPlanoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= TipoPlanoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= TipoPlanoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= TipoPlanoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= TipoPlanoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= TipoPlanoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= TipoPlanoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= TipoPlanoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= TipoPlanoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= TipoPlanoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= TipoPlanoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= TipoPlanoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= TipoPlanoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= TipoPlanoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= TipoPlanoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class ConvenioHorasEspeciaisFilters 
	{
		public static Expression<Func<ConvenioHorasEspeciais, bool>> GetFilters(this ConvenioHorasEspeciaisQueryModel request, bool isOrSpecification = false) 
		{
			Specification<ConvenioHorasEspeciais> filter = new DirectSpecification<ConvenioHorasEspeciais>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.DiaEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.DiaEqual(request.DiaEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.DiaEqual(request.DiaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DiaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.DiaNotEqual(request.DiaNotEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.DiaNotEqual(request.DiaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DiaContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.DiaContains(request.DiaContains);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.DiaContains(request.DiaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.DiaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.DiaStartsWith(request.DiaStartsWith);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.DiaStartsWith(request.DiaStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraInicialEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraInicialEqual(request.HoraInicialEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraInicialEqual(request.HoraInicialEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraInicialNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraInicialNotEqual(request.HoraInicialNotEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraInicialNotEqual(request.HoraInicialNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraInicialContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraInicialContains(request.HoraInicialContains);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraInicialContains(request.HoraInicialContains);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraInicialStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraInicialStartsWith(request.HoraInicialStartsWith);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraInicialStartsWith(request.HoraInicialStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraFinalEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraFinalEqual(request.HoraFinalEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraFinalEqual(request.HoraFinalEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraFinalNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraFinalNotEqual(request.HoraFinalNotEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraFinalNotEqual(request.HoraFinalNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraFinalContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraFinalContains(request.HoraFinalContains);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraFinalContains(request.HoraFinalContains);
				}
				if (!string.IsNullOrWhiteSpace(request.HoraFinalStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.HoraFinalStartsWith(request.HoraFinalStartsWith);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.HoraFinalStartsWith(request.HoraFinalStartsWith);
				}
				if (request.ConvenioIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.ConvenioIdEqual(request.ConvenioIdEqual.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.ConvenioIdEqual(request.ConvenioIdEqual.Value);
				}
				if (request.ConvenioIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.ConvenioIdGreatThanOrEqual(request.ConvenioIdSince.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.ConvenioIdGreatThanOrEqual(request.ConvenioIdSince.Value);
				}
				if (request.ConvenioIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.ConvenioIdLessThan(request.ConvenioIdUntil.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.ConvenioIdLessThan(request.ConvenioIdUntil.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConvenioHorasEspeciaisSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ConvenioHorasEspeciaisSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Filters{
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

