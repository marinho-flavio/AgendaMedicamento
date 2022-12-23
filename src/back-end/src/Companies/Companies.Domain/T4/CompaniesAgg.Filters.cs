using Bravo.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Bravo.Core.Domain.Seedwork.Specification;
using Bravo.CrossCuting.Infra.Utils.Extensions;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class EmpresaConfiguracaoFilters 
	{
		public static Expression<Func<EmpresaConfiguracao, bool>> GetFilters(this EmpresaConfiguracaoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<EmpresaConfiguracao> filter = new DirectSpecification<EmpresaConfiguracao>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.SetorProprioEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.SetorProprioEqual(request.SetorProprioEqual.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.SetorProprioEqual(request.SetorProprioEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= EmpresaConfiguracaoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= EmpresaConfiguracaoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= EmpresaConfiguracaoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= EmpresaConfiguracaoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaConfiguracaoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= EmpresaConfiguracaoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class EmpresaFilters 
	{
		public static Expression<Func<Empresa, bool>> GetFilters(this EmpresaQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Empresa> filter = new DirectSpecification<Empresa>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= EmpresaSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= EmpresaSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= EmpresaSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
				if (request.GrupoEmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.GrupoEmpresaIdEqual(request.GrupoEmpresaIdEqual.Value);
					else
						filter &= EmpresaSpecifications.GrupoEmpresaIdEqual(request.GrupoEmpresaIdEqual.Value);
				}
				if (request.GrupoEmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.GrupoEmpresaIdGreatThanOrEqual(request.GrupoEmpresaIdSince.Value);
					else
						filter &= EmpresaSpecifications.GrupoEmpresaIdGreatThanOrEqual(request.GrupoEmpresaIdSince.Value);
				}
				if (request.GrupoEmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.GrupoEmpresaIdLessThan(request.GrupoEmpresaIdUntil.Value);
					else
						filter &= EmpresaSpecifications.GrupoEmpresaIdLessThan(request.GrupoEmpresaIdUntil.Value);
				}
				if (request.IsFilialEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.IsFilialEqual(request.IsFilialEqual.Value);
					else
						filter &= EmpresaSpecifications.IsFilialEqual(request.IsFilialEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.CNESEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNESEqual(request.CNESEqual);
					else
						filter &= EmpresaSpecifications.CNESEqual(request.CNESEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNESNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNESNotEqual(request.CNESNotEqual);
					else
						filter &= EmpresaSpecifications.CNESNotEqual(request.CNESNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNESContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNESContains(request.CNESContains);
					else
						filter &= EmpresaSpecifications.CNESContains(request.CNESContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CNESStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNESStartsWith(request.CNESStartsWith);
					else
						filter &= EmpresaSpecifications.CNESStartsWith(request.CNESStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ANSEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ANSEqual(request.ANSEqual);
					else
						filter &= EmpresaSpecifications.ANSEqual(request.ANSEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ANSNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ANSNotEqual(request.ANSNotEqual);
					else
						filter &= EmpresaSpecifications.ANSNotEqual(request.ANSNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ANSContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ANSContains(request.ANSContains);
					else
						filter &= EmpresaSpecifications.ANSContains(request.ANSContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ANSStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.ANSStartsWith(request.ANSStartsWith);
					else
						filter &= EmpresaSpecifications.ANSStartsWith(request.ANSStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSUSEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CodigoSUSEqual(request.CodigoSUSEqual);
					else
						filter &= EmpresaSpecifications.CodigoSUSEqual(request.CodigoSUSEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSUSNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CodigoSUSNotEqual(request.CodigoSUSNotEqual);
					else
						filter &= EmpresaSpecifications.CodigoSUSNotEqual(request.CodigoSUSNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSUSContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CodigoSUSContains(request.CodigoSUSContains);
					else
						filter &= EmpresaSpecifications.CodigoSUSContains(request.CodigoSUSContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CodigoSUSStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CodigoSUSStartsWith(request.CodigoSUSStartsWith);
					else
						filter &= EmpresaSpecifications.CodigoSUSStartsWith(request.CodigoSUSStartsWith);
				}
				if (request.TerceirizadoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.TerceirizadoEqual(request.TerceirizadoEqual.Value);
					else
						filter &= EmpresaSpecifications.TerceirizadoEqual(request.TerceirizadoEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNPJEqual(request.CNPJEqual);
					else
						filter &= EmpresaSpecifications.CNPJEqual(request.CNPJEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNPJNotEqual(request.CNPJNotEqual);
					else
						filter &= EmpresaSpecifications.CNPJNotEqual(request.CNPJNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNPJContains(request.CNPJContains);
					else
						filter &= EmpresaSpecifications.CNPJContains(request.CNPJContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CNPJStartsWith(request.CNPJStartsWith);
					else
						filter &= EmpresaSpecifications.CNPJStartsWith(request.CNPJStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.RazaoSocialEqual(request.RazaoSocialEqual);
					else
						filter &= EmpresaSpecifications.RazaoSocialEqual(request.RazaoSocialEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.RazaoSocialNotEqual(request.RazaoSocialNotEqual);
					else
						filter &= EmpresaSpecifications.RazaoSocialNotEqual(request.RazaoSocialNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.RazaoSocialContains(request.RazaoSocialContains);
					else
						filter &= EmpresaSpecifications.RazaoSocialContains(request.RazaoSocialContains);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.RazaoSocialStartsWith(request.RazaoSocialStartsWith);
					else
						filter &= EmpresaSpecifications.RazaoSocialStartsWith(request.RazaoSocialStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.NomeFantasiaEqual(request.NomeFantasiaEqual);
					else
						filter &= EmpresaSpecifications.NomeFantasiaEqual(request.NomeFantasiaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.NomeFantasiaNotEqual(request.NomeFantasiaNotEqual);
					else
						filter &= EmpresaSpecifications.NomeFantasiaNotEqual(request.NomeFantasiaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.NomeFantasiaContains(request.NomeFantasiaContains);
					else
						filter &= EmpresaSpecifications.NomeFantasiaContains(request.NomeFantasiaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.NomeFantasiaStartsWith(request.NomeFantasiaStartsWith);
					else
						filter &= EmpresaSpecifications.NomeFantasiaStartsWith(request.NomeFantasiaStartsWith);
				}
				if (request.CurrentStepEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CurrentStepEqual(request.CurrentStepEqual.Value);
					else
						filter &= EmpresaSpecifications.CurrentStepEqual(request.CurrentStepEqual.Value);
				}
				if (request.CurrentStepSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CurrentStepGreatThanOrEqual(request.CurrentStepSince.Value);
					else
						filter &= EmpresaSpecifications.CurrentStepGreatThanOrEqual(request.CurrentStepSince.Value);
				}
				if (request.CurrentStepUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.CurrentStepLessThan(request.CurrentStepUntil.Value);
					else
						filter &= EmpresaSpecifications.CurrentStepLessThan(request.CurrentStepUntil.Value);
				}
				if (request.InstituicaoTypeEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.InstituicaoTypeEqual(request.InstituicaoTypeEqual.Value);
					else
						filter &= EmpresaSpecifications.InstituicaoTypeEqual(request.InstituicaoTypeEqual.Value);
				}
				if (request.AtivoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaSpecifications.AtivoEqual(request.AtivoEqual.Value);
					else
						filter &= EmpresaSpecifications.AtivoEqual(request.AtivoEqual.Value);
				}
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
	public static class GrupoEmpresaContactsFilters 
	{
		public static Expression<Func<GrupoEmpresaContacts, bool>> GetFilters(this GrupoEmpresaContactsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<GrupoEmpresaContacts> filter = new DirectSpecification<GrupoEmpresaContacts>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.EmailEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.EmailEqual(request.EmailEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.EmailEqual(request.EmailEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.EmailNotEqual(request.EmailNotEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.EmailNotEqual(request.EmailNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.EmailContains(request.EmailContains);
					else
						filter &= GrupoEmpresaContactsSpecifications.EmailContains(request.EmailContains);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.EmailStartsWith(request.EmailStartsWith);
					else
						filter &= GrupoEmpresaContactsSpecifications.EmailStartsWith(request.EmailStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TelefoneEqual(request.TelefoneEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.TelefoneEqual(request.TelefoneEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TelefoneContains(request.TelefoneContains);
					else
						filter &= GrupoEmpresaContactsSpecifications.TelefoneContains(request.TelefoneContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
					else
						filter &= GrupoEmpresaContactsSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TipoTelefoneEqual(request.TipoTelefoneEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.TipoTelefoneEqual(request.TipoTelefoneEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TipoTelefoneNotEqual(request.TipoTelefoneNotEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.TipoTelefoneNotEqual(request.TipoTelefoneNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TipoTelefoneContains(request.TipoTelefoneContains);
					else
						filter &= GrupoEmpresaContactsSpecifications.TipoTelefoneContains(request.TipoTelefoneContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.TipoTelefoneStartsWith(request.TipoTelefoneStartsWith);
					else
						filter &= GrupoEmpresaContactsSpecifications.TipoTelefoneStartsWith(request.TipoTelefoneStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.WebSiteEqual(request.WebSiteEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.WebSiteEqual(request.WebSiteEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.WebSiteNotEqual(request.WebSiteNotEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.WebSiteNotEqual(request.WebSiteNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.WebSiteContains(request.WebSiteContains);
					else
						filter &= GrupoEmpresaContactsSpecifications.WebSiteContains(request.WebSiteContains);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.WebSiteStartsWith(request.WebSiteStartsWith);
					else
						filter &= GrupoEmpresaContactsSpecifications.WebSiteStartsWith(request.WebSiteStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= GrupoEmpresaContactsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= GrupoEmpresaContactsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= GrupoEmpresaContactsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaContactsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= GrupoEmpresaContactsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class GrupoEmpresaConfiguracaoFilters 
	{
		public static Expression<Func<GrupoEmpresaConfiguracao, bool>> GetFilters(this GrupoEmpresaConfiguracaoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<GrupoEmpresaConfiguracao> filter = new DirectSpecification<GrupoEmpresaConfiguracao>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.SetorProprioEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.SetorProprioEqual(request.SetorProprioEqual.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.SetorProprioEqual(request.SetorProprioEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaConfiguracaoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= GrupoEmpresaConfiguracaoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class CompaniesAggSettingsFilters 
	{
		public static Expression<Func<CompaniesAggSettings, bool>> GetFilters(this CompaniesAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<CompaniesAggSettings> filter = new DirectSpecification<CompaniesAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.UserIdEqual)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
					else
						filter &= CompaniesAggSettingsSpecifications.UserIdEqual(request.UserIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
					else
						filter &= CompaniesAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdContains)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= CompaniesAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
					else
						filter &= CompaniesAggSettingsSpecifications.UserIdStartsWith(request.UserIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= CompaniesAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= CompaniesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= CompaniesAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= CompaniesAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= CompaniesAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= CompaniesAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class GrupoEmpresaEnderecoFilters 
	{
		public static Expression<Func<GrupoEmpresaEndereco, bool>> GetFilters(this GrupoEmpresaEnderecoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<GrupoEmpresaEndereco> filter = new DirectSpecification<GrupoEmpresaEndereco>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.GrupoEmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.GrupoEmpresaIdEqual(request.GrupoEmpresaIdEqual.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.GrupoEmpresaIdEqual(request.GrupoEmpresaIdEqual.Value);
				}
				if (request.GrupoEmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.GrupoEmpresaIdGreatThanOrEqual(request.GrupoEmpresaIdSince.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.GrupoEmpresaIdGreatThanOrEqual(request.GrupoEmpresaIdSince.Value);
				}
				if (request.GrupoEmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.GrupoEmpresaIdLessThan(request.GrupoEmpresaIdUntil.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.GrupoEmpresaIdLessThan(request.GrupoEmpresaIdUntil.Value);
				}
				if (request.EnderecoIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.EnderecoIdEqual(request.EnderecoIdEqual.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.EnderecoIdEqual(request.EnderecoIdEqual.Value);
				}
				if (request.EnderecoIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.EnderecoIdGreatThanOrEqual(request.EnderecoIdSince.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.EnderecoIdGreatThanOrEqual(request.EnderecoIdSince.Value);
				}
				if (request.EnderecoIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.EnderecoIdLessThan(request.EnderecoIdUntil.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.EnderecoIdLessThan(request.EnderecoIdUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.NumeroEqual(request.NumeroEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.NumeroEqual(request.NumeroEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.NumeroNotEqual(request.NumeroNotEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.NumeroNotEqual(request.NumeroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.NumeroContains(request.NumeroContains);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.NumeroContains(request.NumeroContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.NumeroStartsWith(request.NumeroStartsWith);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.NumeroStartsWith(request.NumeroStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ReferenciaEqual(request.ReferenciaEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ReferenciaEqual(request.ReferenciaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ReferenciaNotEqual(request.ReferenciaNotEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ReferenciaNotEqual(request.ReferenciaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ReferenciaContains(request.ReferenciaContains);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ReferenciaContains(request.ReferenciaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ReferenciaStartsWith(request.ReferenciaStartsWith);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ReferenciaStartsWith(request.ReferenciaStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.TipoEnderecoEqual(request.TipoEnderecoEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.TipoEnderecoEqual(request.TipoEnderecoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.TipoEnderecoNotEqual(request.TipoEnderecoNotEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.TipoEnderecoNotEqual(request.TipoEnderecoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.TipoEnderecoContains(request.TipoEnderecoContains);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.TipoEnderecoContains(request.TipoEnderecoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.TipoEnderecoStartsWith(request.TipoEnderecoStartsWith);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.TipoEnderecoStartsWith(request.TipoEnderecoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ComplementoEqual(request.ComplementoEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ComplementoEqual(request.ComplementoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ComplementoNotEqual(request.ComplementoNotEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ComplementoNotEqual(request.ComplementoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ComplementoContains(request.ComplementoContains);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ComplementoContains(request.ComplementoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ComplementoStartsWith(request.ComplementoStartsWith);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ComplementoStartsWith(request.ComplementoStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaEnderecoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= GrupoEmpresaEnderecoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class GrupoEmpresaFilters 
	{
		public static Expression<Func<GrupoEmpresa, bool>> GetFilters(this GrupoEmpresaQueryModel request, bool isOrSpecification = false) 
		{
			Specification<GrupoEmpresa> filter = new DirectSpecification<GrupoEmpresa>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.CNPJEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CNPJEqual(request.CNPJEqual);
					else
						filter &= GrupoEmpresaSpecifications.CNPJEqual(request.CNPJEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CNPJNotEqual(request.CNPJNotEqual);
					else
						filter &= GrupoEmpresaSpecifications.CNPJNotEqual(request.CNPJNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CNPJContains(request.CNPJContains);
					else
						filter &= GrupoEmpresaSpecifications.CNPJContains(request.CNPJContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CNPJStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CNPJStartsWith(request.CNPJStartsWith);
					else
						filter &= GrupoEmpresaSpecifications.CNPJStartsWith(request.CNPJStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.RazaoSocialEqual(request.RazaoSocialEqual);
					else
						filter &= GrupoEmpresaSpecifications.RazaoSocialEqual(request.RazaoSocialEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.RazaoSocialNotEqual(request.RazaoSocialNotEqual);
					else
						filter &= GrupoEmpresaSpecifications.RazaoSocialNotEqual(request.RazaoSocialNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.RazaoSocialContains(request.RazaoSocialContains);
					else
						filter &= GrupoEmpresaSpecifications.RazaoSocialContains(request.RazaoSocialContains);
				}
				if (!string.IsNullOrWhiteSpace(request.RazaoSocialStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.RazaoSocialStartsWith(request.RazaoSocialStartsWith);
					else
						filter &= GrupoEmpresaSpecifications.RazaoSocialStartsWith(request.RazaoSocialStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.NomeFantasiaEqual(request.NomeFantasiaEqual);
					else
						filter &= GrupoEmpresaSpecifications.NomeFantasiaEqual(request.NomeFantasiaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.NomeFantasiaNotEqual(request.NomeFantasiaNotEqual);
					else
						filter &= GrupoEmpresaSpecifications.NomeFantasiaNotEqual(request.NomeFantasiaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.NomeFantasiaContains(request.NomeFantasiaContains);
					else
						filter &= GrupoEmpresaSpecifications.NomeFantasiaContains(request.NomeFantasiaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeFantasiaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.NomeFantasiaStartsWith(request.NomeFantasiaStartsWith);
					else
						filter &= GrupoEmpresaSpecifications.NomeFantasiaStartsWith(request.NomeFantasiaStartsWith);
				}
				if (request.CurrentStepEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CurrentStepEqual(request.CurrentStepEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.CurrentStepEqual(request.CurrentStepEqual.Value);
				}
				if (request.CurrentStepSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CurrentStepGreatThanOrEqual(request.CurrentStepSince.Value);
					else
						filter &= GrupoEmpresaSpecifications.CurrentStepGreatThanOrEqual(request.CurrentStepSince.Value);
				}
				if (request.CurrentStepUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CurrentStepLessThan(request.CurrentStepUntil.Value);
					else
						filter &= GrupoEmpresaSpecifications.CurrentStepLessThan(request.CurrentStepUntil.Value);
				}
				if (request.InstituicaoTypeEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.InstituicaoTypeEqual(request.InstituicaoTypeEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.InstituicaoTypeEqual(request.InstituicaoTypeEqual.Value);
				}
				if (request.AtivoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.AtivoEqual(request.AtivoEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.AtivoEqual(request.AtivoEqual.Value);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= GrupoEmpresaSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= GrupoEmpresaSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= GrupoEmpresaSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= GrupoEmpresaSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= GrupoEmpresaSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= GrupoEmpresaSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= GrupoEmpresaSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= GrupoEmpresaSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= GrupoEmpresaSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= GrupoEmpresaSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= GrupoEmpresaSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= GrupoEmpresaSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class EmpresaEnderecoFilters 
	{
		public static Expression<Func<EmpresaEndereco, bool>> GetFilters(this EmpresaEnderecoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<EmpresaEndereco> filter = new DirectSpecification<EmpresaEndereco>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.EmpresaIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
					else
						filter &= EmpresaEnderecoSpecifications.EmpresaIdEqual(request.EmpresaIdEqual.Value);
				}
				if (request.EmpresaIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
					else
						filter &= EmpresaEnderecoSpecifications.EmpresaIdGreatThanOrEqual(request.EmpresaIdSince.Value);
				}
				if (request.EmpresaIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
					else
						filter &= EmpresaEnderecoSpecifications.EmpresaIdLessThan(request.EmpresaIdUntil.Value);
				}
				if (request.EnderecoIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.EnderecoIdEqual(request.EnderecoIdEqual.Value);
					else
						filter &= EmpresaEnderecoSpecifications.EnderecoIdEqual(request.EnderecoIdEqual.Value);
				}
				if (request.EnderecoIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.EnderecoIdGreatThanOrEqual(request.EnderecoIdSince.Value);
					else
						filter &= EmpresaEnderecoSpecifications.EnderecoIdGreatThanOrEqual(request.EnderecoIdSince.Value);
				}
				if (request.EnderecoIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.EnderecoIdLessThan(request.EnderecoIdUntil.Value);
					else
						filter &= EmpresaEnderecoSpecifications.EnderecoIdLessThan(request.EnderecoIdUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.NumeroEqual(request.NumeroEqual);
					else
						filter &= EmpresaEnderecoSpecifications.NumeroEqual(request.NumeroEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.NumeroNotEqual(request.NumeroNotEqual);
					else
						filter &= EmpresaEnderecoSpecifications.NumeroNotEqual(request.NumeroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.NumeroContains(request.NumeroContains);
					else
						filter &= EmpresaEnderecoSpecifications.NumeroContains(request.NumeroContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NumeroStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.NumeroStartsWith(request.NumeroStartsWith);
					else
						filter &= EmpresaEnderecoSpecifications.NumeroStartsWith(request.NumeroStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ReferenciaEqual(request.ReferenciaEqual);
					else
						filter &= EmpresaEnderecoSpecifications.ReferenciaEqual(request.ReferenciaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ReferenciaNotEqual(request.ReferenciaNotEqual);
					else
						filter &= EmpresaEnderecoSpecifications.ReferenciaNotEqual(request.ReferenciaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ReferenciaContains(request.ReferenciaContains);
					else
						filter &= EmpresaEnderecoSpecifications.ReferenciaContains(request.ReferenciaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ReferenciaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ReferenciaStartsWith(request.ReferenciaStartsWith);
					else
						filter &= EmpresaEnderecoSpecifications.ReferenciaStartsWith(request.ReferenciaStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.TipoEnderecoEqual(request.TipoEnderecoEqual);
					else
						filter &= EmpresaEnderecoSpecifications.TipoEnderecoEqual(request.TipoEnderecoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.TipoEnderecoNotEqual(request.TipoEnderecoNotEqual);
					else
						filter &= EmpresaEnderecoSpecifications.TipoEnderecoNotEqual(request.TipoEnderecoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.TipoEnderecoContains(request.TipoEnderecoContains);
					else
						filter &= EmpresaEnderecoSpecifications.TipoEnderecoContains(request.TipoEnderecoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoEnderecoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.TipoEnderecoStartsWith(request.TipoEnderecoStartsWith);
					else
						filter &= EmpresaEnderecoSpecifications.TipoEnderecoStartsWith(request.TipoEnderecoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ComplementoEqual(request.ComplementoEqual);
					else
						filter &= EmpresaEnderecoSpecifications.ComplementoEqual(request.ComplementoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ComplementoNotEqual(request.ComplementoNotEqual);
					else
						filter &= EmpresaEnderecoSpecifications.ComplementoNotEqual(request.ComplementoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ComplementoContains(request.ComplementoContains);
					else
						filter &= EmpresaEnderecoSpecifications.ComplementoContains(request.ComplementoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ComplementoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ComplementoStartsWith(request.ComplementoStartsWith);
					else
						filter &= EmpresaEnderecoSpecifications.ComplementoStartsWith(request.ComplementoStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= EmpresaEnderecoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= EmpresaEnderecoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= EmpresaEnderecoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= EmpresaEnderecoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= EmpresaEnderecoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= EmpresaEnderecoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= EmpresaEnderecoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= EmpresaEnderecoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= EmpresaEnderecoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= EmpresaEnderecoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= EmpresaEnderecoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= EmpresaEnderecoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= EmpresaEnderecoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= EmpresaEnderecoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaEnderecoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= EmpresaEnderecoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
	public static class EmpresaContactsFilters 
	{
		public static Expression<Func<EmpresaContacts, bool>> GetFilters(this EmpresaContactsQueryModel request, bool isOrSpecification = false) 
		{
			Specification<EmpresaContacts> filter = new DirectSpecification<EmpresaContacts>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.EmailEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.EmailEqual(request.EmailEqual);
					else
						filter &= EmpresaContactsSpecifications.EmailEqual(request.EmailEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.EmailNotEqual(request.EmailNotEqual);
					else
						filter &= EmpresaContactsSpecifications.EmailNotEqual(request.EmailNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.EmailContains(request.EmailContains);
					else
						filter &= EmpresaContactsSpecifications.EmailContains(request.EmailContains);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.EmailStartsWith(request.EmailStartsWith);
					else
						filter &= EmpresaContactsSpecifications.EmailStartsWith(request.EmailStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TelefoneEqual(request.TelefoneEqual);
					else
						filter &= EmpresaContactsSpecifications.TelefoneEqual(request.TelefoneEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
					else
						filter &= EmpresaContactsSpecifications.TelefoneNotEqual(request.TelefoneNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TelefoneContains(request.TelefoneContains);
					else
						filter &= EmpresaContactsSpecifications.TelefoneContains(request.TelefoneContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TelefoneStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
					else
						filter &= EmpresaContactsSpecifications.TelefoneStartsWith(request.TelefoneStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TipoTelefoneEqual(request.TipoTelefoneEqual);
					else
						filter &= EmpresaContactsSpecifications.TipoTelefoneEqual(request.TipoTelefoneEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TipoTelefoneNotEqual(request.TipoTelefoneNotEqual);
					else
						filter &= EmpresaContactsSpecifications.TipoTelefoneNotEqual(request.TipoTelefoneNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TipoTelefoneContains(request.TipoTelefoneContains);
					else
						filter &= EmpresaContactsSpecifications.TipoTelefoneContains(request.TipoTelefoneContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoTelefoneStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.TipoTelefoneStartsWith(request.TipoTelefoneStartsWith);
					else
						filter &= EmpresaContactsSpecifications.TipoTelefoneStartsWith(request.TipoTelefoneStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.WebSiteEqual(request.WebSiteEqual);
					else
						filter &= EmpresaContactsSpecifications.WebSiteEqual(request.WebSiteEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.WebSiteNotEqual(request.WebSiteNotEqual);
					else
						filter &= EmpresaContactsSpecifications.WebSiteNotEqual(request.WebSiteNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.WebSiteContains(request.WebSiteContains);
					else
						filter &= EmpresaContactsSpecifications.WebSiteContains(request.WebSiteContains);
				}
				if (!string.IsNullOrWhiteSpace(request.WebSiteStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.WebSiteStartsWith(request.WebSiteStartsWith);
					else
						filter &= EmpresaContactsSpecifications.WebSiteStartsWith(request.WebSiteStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= EmpresaContactsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= EmpresaContactsSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= EmpresaContactsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= EmpresaContactsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= EmpresaContactsSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= EmpresaContactsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= EmpresaContactsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= EmpresaContactsSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= EmpresaContactsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= EmpresaContactsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= EmpresaContactsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= EmpresaContactsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= EmpresaContactsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= EmpresaContactsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= EmpresaContactsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= EmpresaContactsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Filters{
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
namespace Bravo.Companies.Domain.Aggregates.PatientsAgg.Filters{
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
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= PacienteSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= PacienteSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.NomeContains(request.NomeContains);
					else
						filter &= PacienteSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= PacienteSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.CpfEqual(request.CpfEqual);
					else
						filter &= PacienteSpecifications.CpfEqual(request.CpfEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfNotEqual)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.CpfNotEqual(request.CpfNotEqual);
					else
						filter &= PacienteSpecifications.CpfNotEqual(request.CpfNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfContains)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.CpfContains(request.CpfContains);
					else
						filter &= PacienteSpecifications.CpfContains(request.CpfContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CpfStartsWith)) 
				{
					if (isOrSpecification)
						filter |= PacienteSpecifications.CpfStartsWith(request.CpfStartsWith);
					else
						filter &= PacienteSpecifications.CpfStartsWith(request.CpfStartsWith);
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
}
namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
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
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ScheduleStatusEqual(request.ScheduleStatusEqual);
					else
						filter &= AgendaExameSpecifications.ScheduleStatusEqual(request.ScheduleStatusEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ScheduleStatusNotEqual(request.ScheduleStatusNotEqual);
					else
						filter &= AgendaExameSpecifications.ScheduleStatusNotEqual(request.ScheduleStatusNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ScheduleStatusContains(request.ScheduleStatusContains);
					else
						filter &= AgendaExameSpecifications.ScheduleStatusContains(request.ScheduleStatusContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaExameSpecifications.ScheduleStatusStartsWith(request.ScheduleStatusStartsWith);
					else
						filter &= AgendaExameSpecifications.ScheduleStatusStartsWith(request.ScheduleStatusStartsWith);
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
				if (!string.IsNullOrWhiteSpace(request.NomeProfissionalEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.NomeProfissionalEqual(request.NomeProfissionalEqual);
					else
						filter &= AgendaProfissionalSpecifications.NomeProfissionalEqual(request.NomeProfissionalEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeProfissionalNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.NomeProfissionalNotEqual(request.NomeProfissionalNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.NomeProfissionalNotEqual(request.NomeProfissionalNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeProfissionalContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.NomeProfissionalContains(request.NomeProfissionalContains);
					else
						filter &= AgendaProfissionalSpecifications.NomeProfissionalContains(request.NomeProfissionalContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeProfissionalStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.NomeProfissionalStartsWith(request.NomeProfissionalStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.NomeProfissionalStartsWith(request.NomeProfissionalStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ConselhoEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ConselhoEqual(request.ConselhoEqual);
					else
						filter &= AgendaProfissionalSpecifications.ConselhoEqual(request.ConselhoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ConselhoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ConselhoNotEqual(request.ConselhoNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.ConselhoNotEqual(request.ConselhoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ConselhoContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ConselhoContains(request.ConselhoContains);
					else
						filter &= AgendaProfissionalSpecifications.ConselhoContains(request.ConselhoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ConselhoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ConselhoStartsWith(request.ConselhoStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.ConselhoStartsWith(request.ConselhoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CBOProfissionalEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CBOProfissionalEqual(request.CBOProfissionalEqual);
					else
						filter &= AgendaProfissionalSpecifications.CBOProfissionalEqual(request.CBOProfissionalEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CBOProfissionalNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CBOProfissionalNotEqual(request.CBOProfissionalNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.CBOProfissionalNotEqual(request.CBOProfissionalNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CBOProfissionalContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CBOProfissionalContains(request.CBOProfissionalContains);
					else
						filter &= AgendaProfissionalSpecifications.CBOProfissionalContains(request.CBOProfissionalContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CBOProfissionalStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CBOProfissionalStartsWith(request.CBOProfissionalStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.CBOProfissionalStartsWith(request.CBOProfissionalStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.DuracaoConsultaEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DuracaoConsultaEqual(request.DuracaoConsultaEqual);
					else
						filter &= AgendaProfissionalSpecifications.DuracaoConsultaEqual(request.DuracaoConsultaEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DuracaoConsultaNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DuracaoConsultaNotEqual(request.DuracaoConsultaNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.DuracaoConsultaNotEqual(request.DuracaoConsultaNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DuracaoConsultaContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DuracaoConsultaContains(request.DuracaoConsultaContains);
					else
						filter &= AgendaProfissionalSpecifications.DuracaoConsultaContains(request.DuracaoConsultaContains);
				}
				if (!string.IsNullOrWhiteSpace(request.DuracaoConsultaStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.DuracaoConsultaStartsWith(request.DuracaoConsultaStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.DuracaoConsultaStartsWith(request.DuracaoConsultaStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.CotaAtendimentoEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CotaAtendimentoEqual(request.CotaAtendimentoEqual);
					else
						filter &= AgendaProfissionalSpecifications.CotaAtendimentoEqual(request.CotaAtendimentoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CotaAtendimentoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CotaAtendimentoNotEqual(request.CotaAtendimentoNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.CotaAtendimentoNotEqual(request.CotaAtendimentoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CotaAtendimentoContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CotaAtendimentoContains(request.CotaAtendimentoContains);
					else
						filter &= AgendaProfissionalSpecifications.CotaAtendimentoContains(request.CotaAtendimentoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CotaAtendimentoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.CotaAtendimentoStartsWith(request.CotaAtendimentoStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.CotaAtendimentoStartsWith(request.CotaAtendimentoStartsWith);
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
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ScheduleStatusEqual(request.ScheduleStatusEqual);
					else
						filter &= AgendaProfissionalSpecifications.ScheduleStatusEqual(request.ScheduleStatusEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ScheduleStatusNotEqual(request.ScheduleStatusNotEqual);
					else
						filter &= AgendaProfissionalSpecifications.ScheduleStatusNotEqual(request.ScheduleStatusNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusContains)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ScheduleStatusContains(request.ScheduleStatusContains);
					else
						filter &= AgendaProfissionalSpecifications.ScheduleStatusContains(request.ScheduleStatusContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ScheduleStatusStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AgendaProfissionalSpecifications.ScheduleStatusStartsWith(request.ScheduleStatusStartsWith);
					else
						filter &= AgendaProfissionalSpecifications.ScheduleStatusStartsWith(request.ScheduleStatusStartsWith);
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
namespace Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Filters{
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
}
namespace Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class ProcedimentoFilters 
	{
		public static Expression<Func<Procedimento, bool>> GetFilters(this ProcedimentoQueryModel request, bool isOrSpecification = false) 
		{
			Specification<Procedimento> filter = new DirectSpecification<Procedimento>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.CodigoProcedimentoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.CodigoProcedimentoEqual(request.CodigoProcedimentoEqual.Value);
					else
						filter &= ProcedimentoSpecifications.CodigoProcedimentoEqual(request.CodigoProcedimentoEqual.Value);
				}
				if (request.CodigoProcedimentoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.CodigoProcedimentoGreatThanOrEqual(request.CodigoProcedimentoSince.Value);
					else
						filter &= ProcedimentoSpecifications.CodigoProcedimentoGreatThanOrEqual(request.CodigoProcedimentoSince.Value);
				}
				if (request.CodigoProcedimentoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.CodigoProcedimentoLessThan(request.CodigoProcedimentoUntil.Value);
					else
						filter &= ProcedimentoSpecifications.CodigoProcedimentoLessThan(request.CodigoProcedimentoUntil.Value);
				}
				if (request.DescricaoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.DescricaoEqual(request.DescricaoEqual.Value);
					else
						filter &= ProcedimentoSpecifications.DescricaoEqual(request.DescricaoEqual.Value);
				}
				if (request.DescricaoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.DescricaoGreatThanOrEqual(request.DescricaoSince.Value);
					else
						filter &= ProcedimentoSpecifications.DescricaoGreatThanOrEqual(request.DescricaoSince.Value);
				}
				if (request.DescricaoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.DescricaoLessThan(request.DescricaoUntil.Value);
					else
						filter &= ProcedimentoSpecifications.DescricaoLessThan(request.DescricaoUntil.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.OrientacaoEqual)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.OrientacaoEqual(request.OrientacaoEqual);
					else
						filter &= ProcedimentoSpecifications.OrientacaoEqual(request.OrientacaoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.OrientacaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.OrientacaoNotEqual(request.OrientacaoNotEqual);
					else
						filter &= ProcedimentoSpecifications.OrientacaoNotEqual(request.OrientacaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.OrientacaoContains)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.OrientacaoContains(request.OrientacaoContains);
					else
						filter &= ProcedimentoSpecifications.OrientacaoContains(request.OrientacaoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.OrientacaoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.OrientacaoStartsWith(request.OrientacaoStartsWith);
					else
						filter &= ProcedimentoSpecifications.OrientacaoStartsWith(request.OrientacaoStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ProcedimentoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ProcedimentoSpecifications.CreatedAtGreatThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ProcedimentoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ProcedimentoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ProcedimentoSpecifications.UpdatedAtGreatThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ProcedimentoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ProcedimentoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ProcedimentoSpecifications.DeletedAtGreatThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ProcedimentoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ProcedimentoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ProcedimentoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ProcedimentoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ProcedimentoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ProcedimentoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ProcedimentoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ProcedimentoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter.SatisfiedBy();
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.UsersAgg.Filters{
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
				if (!string.IsNullOrWhiteSpace(request.UserNameEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.UserNameEqual(request.UserNameEqual);
					else
						filter &= UserSpecifications.UserNameEqual(request.UserNameEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserNameNotEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.UserNameNotEqual(request.UserNameNotEqual);
					else
						filter &= UserSpecifications.UserNameNotEqual(request.UserNameNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UserNameContains)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.UserNameContains(request.UserNameContains);
					else
						filter &= UserSpecifications.UserNameContains(request.UserNameContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UserNameStartsWith)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.UserNameStartsWith(request.UserNameStartsWith);
					else
						filter &= UserSpecifications.UserNameStartsWith(request.UserNameStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.NameEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.NameEqual(request.NameEqual);
					else
						filter &= UserSpecifications.NameEqual(request.NameEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NameNotEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.NameNotEqual(request.NameNotEqual);
					else
						filter &= UserSpecifications.NameNotEqual(request.NameNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NameContains)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.NameContains(request.NameContains);
					else
						filter &= UserSpecifications.NameContains(request.NameContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NameStartsWith)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.NameStartsWith(request.NameStartsWith);
					else
						filter &= UserSpecifications.NameStartsWith(request.NameStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.EmailEqual(request.EmailEqual);
					else
						filter &= UserSpecifications.EmailEqual(request.EmailEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailNotEqual)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.EmailNotEqual(request.EmailNotEqual);
					else
						filter &= UserSpecifications.EmailNotEqual(request.EmailNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailContains)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.EmailContains(request.EmailContains);
					else
						filter &= UserSpecifications.EmailContains(request.EmailContains);
				}
				if (!string.IsNullOrWhiteSpace(request.EmailStartsWith)) 
				{
					if (isOrSpecification)
						filter |= UserSpecifications.EmailStartsWith(request.EmailStartsWith);
					else
						filter &= UserSpecifications.EmailStartsWith(request.EmailStartsWith);
				}
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
namespace Bravo.Companies.Domain.Aggregates.PartnersAgg.Filters{
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
namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.Filters{
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
}

