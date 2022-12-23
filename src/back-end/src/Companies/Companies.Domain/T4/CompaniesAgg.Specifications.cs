using Bravo.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Specifications {
	using Entities;
   public partial class EmpresaConfiguracaoSpecifications {
			public static Specification<EmpresaConfiguracao> SetorProprioEqual(bool value) {
			return new DirectSpecification<EmpresaConfiguracao>(p => p.SetorProprio == value);
		}
		public static Specification<EmpresaConfiguracao> SetorProprioIsNull() {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.SetorProprio == null);
        }
		public static Specification<EmpresaConfiguracao> SetorProprioIsNotNull() {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.SetorProprio != null);
        }
			public static Specification<EmpresaConfiguracao> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaConfiguracao>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<EmpresaConfiguracao> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.CreatedAt >= value);
        }
        public static Specification<EmpresaConfiguracao> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.CreatedAt <= value);
        }
        public static Specification<EmpresaConfiguracao> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.CreatedAt != value);
        }
        public static Specification<EmpresaConfiguracao> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.CreatedAt > value);
        }
        public static Specification<EmpresaConfiguracao> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.CreatedAt < value);
        }
			public static Specification<EmpresaConfiguracao> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaConfiguracao>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<EmpresaConfiguracao> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.UpdatedAt >= value);
        }
        public static Specification<EmpresaConfiguracao> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.UpdatedAt <= value);
        }
        public static Specification<EmpresaConfiguracao> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.UpdatedAt != value);
        }
        public static Specification<EmpresaConfiguracao> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.UpdatedAt > value);
        }
        public static Specification<EmpresaConfiguracao> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.UpdatedAt < value);
        }
			public static Specification<EmpresaConfiguracao> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaConfiguracao>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<EmpresaConfiguracao> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.DeletedAt >= value);
        }
        public static Specification<EmpresaConfiguracao> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.DeletedAt <= value);
        }
        public static Specification<EmpresaConfiguracao> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.DeletedAt != value);
        }
        public static Specification<EmpresaConfiguracao> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.DeletedAt > value);
        }
        public static Specification<EmpresaConfiguracao> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.DeletedAt < value);
        }
			public static Specification<EmpresaConfiguracao> IdEqual(params int[] values) {
			return new DirectSpecification<EmpresaConfiguracao>(p => values.Contains(p.Id));
        }
        public static Specification<EmpresaConfiguracao> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.Id >= value);
        }
        public static Specification<EmpresaConfiguracao> IdLessThanOrEqual(int value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.Id <= value);
        }
        public static Specification<EmpresaConfiguracao> IdNotEqual(int value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.Id != value);
        }
        public static Specification<EmpresaConfiguracao> IdGreatThan(int value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.Id > value);
        }
        public static Specification<EmpresaConfiguracao> IdLessThan(int value) {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.Id < value);
        }
			public static Specification<EmpresaConfiguracao> ExternalIdContains(string value) {
			return new DirectSpecification<EmpresaConfiguracao>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaConfiguracao> ExternalIdStartsWith(string value) {
			return new DirectSpecification<EmpresaConfiguracao>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaConfiguracao> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<EmpresaConfiguracao>(p => values.Contains(p.ExternalId));
		}
		public static Specification<EmpresaConfiguracao> ExternalIdNotEqual(string value) {
			return new DirectSpecification<EmpresaConfiguracao>(p => p.ExternalId != value);
		}
		public static Specification<EmpresaConfiguracao> ExternalIdIsNull() {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.ExternalId == null);
        }
		public static Specification<EmpresaConfiguracao> ExternalIdIsNotNull() {
            return new DirectSpecification<EmpresaConfiguracao>(p => p.ExternalId != null);
        }
			public static Specification<EmpresaConfiguracao> IsDeletedEqual(bool value) {
			return new DirectSpecification<EmpresaConfiguracao>(p => p.IsDeleted == value);
		}
	   }
   public partial class EmpresaSpecifications {
		public static Specification<Empresa> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.EmpresaId.Value));
        }
        public static Specification<Empresa> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.EmpresaId >= value);
        }
        public static Specification<Empresa> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.EmpresaId <= value);
        }
        public static Specification<Empresa> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.EmpresaId != value);
        }
        public static Specification<Empresa> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<Empresa>(p => p.EmpresaId > value);
        }
        public static Specification<Empresa> EmpresaIdLessThan(int value) {
            return new DirectSpecification<Empresa>(p => p.EmpresaId < value);
        }
			public static Specification<Empresa> GrupoEmpresaIdEqual(params int[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.GrupoEmpresaId.Value));
        }
        public static Specification<Empresa> GrupoEmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.GrupoEmpresaId >= value);
        }
        public static Specification<Empresa> GrupoEmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.GrupoEmpresaId <= value);
        }
        public static Specification<Empresa> GrupoEmpresaIdNotEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.GrupoEmpresaId != value);
        }
        public static Specification<Empresa> GrupoEmpresaIdGreatThan(int value) {
            return new DirectSpecification<Empresa>(p => p.GrupoEmpresaId > value);
        }
        public static Specification<Empresa> GrupoEmpresaIdLessThan(int value) {
            return new DirectSpecification<Empresa>(p => p.GrupoEmpresaId < value);
        }
			public static Specification<Empresa> IsFilialEqual(bool value) {
			return new DirectSpecification<Empresa>(p => p.IsFilial == value);
		}
			public static Specification<Empresa> CNESContains(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.CNES.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Empresa> CNESStartsWith(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.CNES.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Empresa> CNESEqual(params string[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.CNES));
		}
		public static Specification<Empresa> CNESNotEqual(string value) {
			return new DirectSpecification<Empresa>(p => p.CNES != value);
		}
		public static Specification<Empresa> CNESIsNull() {
            return new DirectSpecification<Empresa>(p => p.CNES == null);
        }
		public static Specification<Empresa> CNESIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.CNES != null);
        }
			public static Specification<Empresa> ANSContains(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.ANS.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Empresa> ANSStartsWith(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.ANS.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Empresa> ANSEqual(params string[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.ANS));
		}
		public static Specification<Empresa> ANSNotEqual(string value) {
			return new DirectSpecification<Empresa>(p => p.ANS != value);
		}
		public static Specification<Empresa> ANSIsNull() {
            return new DirectSpecification<Empresa>(p => p.ANS == null);
        }
		public static Specification<Empresa> ANSIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.ANS != null);
        }
			public static Specification<Empresa> CodigoSUSContains(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.CodigoSUS.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Empresa> CodigoSUSStartsWith(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.CodigoSUS.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Empresa> CodigoSUSEqual(params string[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.CodigoSUS));
		}
		public static Specification<Empresa> CodigoSUSNotEqual(string value) {
			return new DirectSpecification<Empresa>(p => p.CodigoSUS != value);
		}
		public static Specification<Empresa> CodigoSUSIsNull() {
            return new DirectSpecification<Empresa>(p => p.CodigoSUS == null);
        }
		public static Specification<Empresa> CodigoSUSIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.CodigoSUS != null);
        }
			public static Specification<Empresa> TerceirizadoEqual(bool value) {
			return new DirectSpecification<Empresa>(p => p.Terceirizado == value);
		}
						public static Specification<Empresa> CNPJContains(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Empresa> CNPJStartsWith(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Empresa> CNPJEqual(params string[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.CNPJ));
		}
		public static Specification<Empresa> CNPJNotEqual(string value) {
			return new DirectSpecification<Empresa>(p => p.CNPJ != value);
		}
		public static Specification<Empresa> CNPJIsNull() {
            return new DirectSpecification<Empresa>(p => p.CNPJ == null);
        }
		public static Specification<Empresa> CNPJIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.CNPJ != null);
        }
			public static Specification<Empresa> RazaoSocialContains(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.RazaoSocial.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Empresa> RazaoSocialStartsWith(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.RazaoSocial.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Empresa> RazaoSocialEqual(params string[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.RazaoSocial));
		}
		public static Specification<Empresa> RazaoSocialNotEqual(string value) {
			return new DirectSpecification<Empresa>(p => p.RazaoSocial != value);
		}
		public static Specification<Empresa> RazaoSocialIsNull() {
            return new DirectSpecification<Empresa>(p => p.RazaoSocial == null);
        }
		public static Specification<Empresa> RazaoSocialIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.RazaoSocial != null);
        }
			public static Specification<Empresa> NomeFantasiaContains(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.NomeFantasia.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Empresa> NomeFantasiaStartsWith(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.NomeFantasia.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Empresa> NomeFantasiaEqual(params string[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.NomeFantasia));
		}
		public static Specification<Empresa> NomeFantasiaNotEqual(string value) {
			return new DirectSpecification<Empresa>(p => p.NomeFantasia != value);
		}
		public static Specification<Empresa> NomeFantasiaIsNull() {
            return new DirectSpecification<Empresa>(p => p.NomeFantasia == null);
        }
		public static Specification<Empresa> NomeFantasiaIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.NomeFantasia != null);
        }
			public static Specification<Empresa> CurrentStepEqual(params int[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.CurrentStep));
        }
        public static Specification<Empresa> CurrentStepGreatThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.CurrentStep >= value);
        }
        public static Specification<Empresa> CurrentStepLessThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.CurrentStep <= value);
        }
        public static Specification<Empresa> CurrentStepNotEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.CurrentStep != value);
        }
        public static Specification<Empresa> CurrentStepGreatThan(int value) {
            return new DirectSpecification<Empresa>(p => p.CurrentStep > value);
        }
        public static Specification<Empresa> CurrentStepLessThan(int value) {
            return new DirectSpecification<Empresa>(p => p.CurrentStep < value);
        }
			public static Specification<Empresa> InstituicaoTypeEqual(params Bravo.Companies.Enumerations.InstituicaoType[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.InstituicaoType));
		}
		public static Specification<Empresa> InstituicaoTypeNotEqual(Bravo.Companies.Enumerations.InstituicaoType value) {
			return new DirectSpecification<Empresa>(p => p.InstituicaoType != value);
		}
			public static Specification<Empresa> AtivoEqual(bool value) {
			return new DirectSpecification<Empresa>(p => p.Ativo == value);
		}
		public static Specification<Empresa> AtivoIsNull() {
            return new DirectSpecification<Empresa>(p => p.Ativo == null);
        }
		public static Specification<Empresa> AtivoIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.Ativo != null);
        }
			public static Specification<Empresa> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Empresa> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.CreatedAt >= value);
        }
        public static Specification<Empresa> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.CreatedAt <= value);
        }
        public static Specification<Empresa> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.CreatedAt != value);
        }
        public static Specification<Empresa> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.CreatedAt > value);
        }
        public static Specification<Empresa> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.CreatedAt < value);
        }
			public static Specification<Empresa> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Empresa> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.UpdatedAt >= value);
        }
        public static Specification<Empresa> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.UpdatedAt <= value);
        }
        public static Specification<Empresa> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.UpdatedAt != value);
        }
        public static Specification<Empresa> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.UpdatedAt > value);
        }
        public static Specification<Empresa> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.UpdatedAt < value);
        }
			public static Specification<Empresa> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Empresa> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.DeletedAt >= value);
        }
        public static Specification<Empresa> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.DeletedAt <= value);
        }
        public static Specification<Empresa> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.DeletedAt != value);
        }
        public static Specification<Empresa> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.DeletedAt > value);
        }
        public static Specification<Empresa> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Empresa>(p => p.DeletedAt < value);
        }
			public static Specification<Empresa> IdEqual(params int[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.Id));
        }
        public static Specification<Empresa> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.Id >= value);
        }
        public static Specification<Empresa> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.Id <= value);
        }
        public static Specification<Empresa> IdNotEqual(int value) {
            return new DirectSpecification<Empresa>(p => p.Id != value);
        }
        public static Specification<Empresa> IdGreatThan(int value) {
            return new DirectSpecification<Empresa>(p => p.Id > value);
        }
        public static Specification<Empresa> IdLessThan(int value) {
            return new DirectSpecification<Empresa>(p => p.Id < value);
        }
			public static Specification<Empresa> ExternalIdContains(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Empresa> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Empresa>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Empresa> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Empresa>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Empresa> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Empresa>(p => p.ExternalId != value);
		}
		public static Specification<Empresa> ExternalIdIsNull() {
            return new DirectSpecification<Empresa>(p => p.ExternalId == null);
        }
		public static Specification<Empresa> ExternalIdIsNotNull() {
            return new DirectSpecification<Empresa>(p => p.ExternalId != null);
        }
			public static Specification<Empresa> IsDeletedEqual(bool value) {
			return new DirectSpecification<Empresa>(p => p.IsDeleted == value);
		}
	   }
   public partial class GrupoEmpresaContactsSpecifications {
		public static Specification<GrupoEmpresaContacts> EmailContains(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.Email.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaContacts> EmailStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.Email.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaContacts> EmailEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.Email));
		}
		public static Specification<GrupoEmpresaContacts> EmailNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => p.Email != value);
		}
		public static Specification<GrupoEmpresaContacts> EmailIsNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Email == null);
        }
		public static Specification<GrupoEmpresaContacts> EmailIsNotNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Email != null);
        }
			public static Specification<GrupoEmpresaContacts> TelefoneContains(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.Telefone.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaContacts> TelefoneStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.Telefone.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaContacts> TelefoneEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.Telefone));
		}
		public static Specification<GrupoEmpresaContacts> TelefoneNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => p.Telefone != value);
		}
		public static Specification<GrupoEmpresaContacts> TelefoneIsNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Telefone == null);
        }
		public static Specification<GrupoEmpresaContacts> TelefoneIsNotNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Telefone != null);
        }
			public static Specification<GrupoEmpresaContacts> TipoTelefoneContains(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.TipoTelefone.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaContacts> TipoTelefoneStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.TipoTelefone.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaContacts> TipoTelefoneEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.TipoTelefone));
		}
		public static Specification<GrupoEmpresaContacts> TipoTelefoneNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => p.TipoTelefone != value);
		}
		public static Specification<GrupoEmpresaContacts> TipoTelefoneIsNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.TipoTelefone == null);
        }
		public static Specification<GrupoEmpresaContacts> TipoTelefoneIsNotNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.TipoTelefone != null);
        }
			public static Specification<GrupoEmpresaContacts> WebSiteContains(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.WebSite.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaContacts> WebSiteStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.WebSite.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaContacts> WebSiteEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.WebSite));
		}
		public static Specification<GrupoEmpresaContacts> WebSiteNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => p.WebSite != value);
		}
		public static Specification<GrupoEmpresaContacts> WebSiteIsNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.WebSite == null);
        }
		public static Specification<GrupoEmpresaContacts> WebSiteIsNotNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.WebSite != null);
        }
			public static Specification<GrupoEmpresaContacts> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<GrupoEmpresaContacts> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.CreatedAt >= value);
        }
        public static Specification<GrupoEmpresaContacts> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.CreatedAt <= value);
        }
        public static Specification<GrupoEmpresaContacts> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.CreatedAt != value);
        }
        public static Specification<GrupoEmpresaContacts> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.CreatedAt > value);
        }
        public static Specification<GrupoEmpresaContacts> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.CreatedAt < value);
        }
			public static Specification<GrupoEmpresaContacts> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<GrupoEmpresaContacts> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.UpdatedAt >= value);
        }
        public static Specification<GrupoEmpresaContacts> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.UpdatedAt <= value);
        }
        public static Specification<GrupoEmpresaContacts> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.UpdatedAt != value);
        }
        public static Specification<GrupoEmpresaContacts> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.UpdatedAt > value);
        }
        public static Specification<GrupoEmpresaContacts> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.UpdatedAt < value);
        }
			public static Specification<GrupoEmpresaContacts> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<GrupoEmpresaContacts> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.DeletedAt >= value);
        }
        public static Specification<GrupoEmpresaContacts> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.DeletedAt <= value);
        }
        public static Specification<GrupoEmpresaContacts> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.DeletedAt != value);
        }
        public static Specification<GrupoEmpresaContacts> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.DeletedAt > value);
        }
        public static Specification<GrupoEmpresaContacts> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.DeletedAt < value);
        }
			public static Specification<GrupoEmpresaContacts> IdEqual(params int[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.Id));
        }
        public static Specification<GrupoEmpresaContacts> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Id >= value);
        }
        public static Specification<GrupoEmpresaContacts> IdLessThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Id <= value);
        }
        public static Specification<GrupoEmpresaContacts> IdNotEqual(int value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Id != value);
        }
        public static Specification<GrupoEmpresaContacts> IdGreatThan(int value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Id > value);
        }
        public static Specification<GrupoEmpresaContacts> IdLessThan(int value) {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.Id < value);
        }
			public static Specification<GrupoEmpresaContacts> ExternalIdContains(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaContacts> ExternalIdStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaContacts> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => values.Contains(p.ExternalId));
		}
		public static Specification<GrupoEmpresaContacts> ExternalIdNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => p.ExternalId != value);
		}
		public static Specification<GrupoEmpresaContacts> ExternalIdIsNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.ExternalId == null);
        }
		public static Specification<GrupoEmpresaContacts> ExternalIdIsNotNull() {
            return new DirectSpecification<GrupoEmpresaContacts>(p => p.ExternalId != null);
        }
			public static Specification<GrupoEmpresaContacts> IsDeletedEqual(bool value) {
			return new DirectSpecification<GrupoEmpresaContacts>(p => p.IsDeleted == value);
		}
	   }
   public partial class GrupoEmpresaConfiguracaoSpecifications {
			public static Specification<GrupoEmpresaConfiguracao> SetorProprioEqual(bool value) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.SetorProprio == value);
		}
		public static Specification<GrupoEmpresaConfiguracao> SetorProprioIsNull() {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.SetorProprio == null);
        }
		public static Specification<GrupoEmpresaConfiguracao> SetorProprioIsNotNull() {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.SetorProprio != null);
        }
			public static Specification<GrupoEmpresaConfiguracao> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<GrupoEmpresaConfiguracao> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.CreatedAt >= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.CreatedAt <= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.CreatedAt != value);
        }
        public static Specification<GrupoEmpresaConfiguracao> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.CreatedAt > value);
        }
        public static Specification<GrupoEmpresaConfiguracao> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.CreatedAt < value);
        }
			public static Specification<GrupoEmpresaConfiguracao> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<GrupoEmpresaConfiguracao> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.UpdatedAt >= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.UpdatedAt <= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.UpdatedAt != value);
        }
        public static Specification<GrupoEmpresaConfiguracao> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.UpdatedAt > value);
        }
        public static Specification<GrupoEmpresaConfiguracao> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.UpdatedAt < value);
        }
			public static Specification<GrupoEmpresaConfiguracao> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<GrupoEmpresaConfiguracao> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.DeletedAt >= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.DeletedAt <= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.DeletedAt != value);
        }
        public static Specification<GrupoEmpresaConfiguracao> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.DeletedAt > value);
        }
        public static Specification<GrupoEmpresaConfiguracao> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.DeletedAt < value);
        }
			public static Specification<GrupoEmpresaConfiguracao> IdEqual(params int[] values) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => values.Contains(p.Id));
        }
        public static Specification<GrupoEmpresaConfiguracao> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.Id >= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> IdLessThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.Id <= value);
        }
        public static Specification<GrupoEmpresaConfiguracao> IdNotEqual(int value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.Id != value);
        }
        public static Specification<GrupoEmpresaConfiguracao> IdGreatThan(int value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.Id > value);
        }
        public static Specification<GrupoEmpresaConfiguracao> IdLessThan(int value) {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.Id < value);
        }
			public static Specification<GrupoEmpresaConfiguracao> ExternalIdContains(string value) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaConfiguracao> ExternalIdStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaConfiguracao> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => values.Contains(p.ExternalId));
		}
		public static Specification<GrupoEmpresaConfiguracao> ExternalIdNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.ExternalId != value);
		}
		public static Specification<GrupoEmpresaConfiguracao> ExternalIdIsNull() {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.ExternalId == null);
        }
		public static Specification<GrupoEmpresaConfiguracao> ExternalIdIsNotNull() {
            return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.ExternalId != null);
        }
			public static Specification<GrupoEmpresaConfiguracao> IsDeletedEqual(bool value) {
			return new DirectSpecification<GrupoEmpresaConfiguracao>(p => p.IsDeleted == value);
		}
	   }
   public partial class CompaniesAggSettingsSpecifications {
		public static Specification<CompaniesAggSettings> UserIdContains(string value) {
			return new DirectSpecification<CompaniesAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<CompaniesAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<CompaniesAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<CompaniesAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<CompaniesAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<CompaniesAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<CompaniesAggSettings>(p => p.UserId != value);
		}
		public static Specification<CompaniesAggSettings> UserIdIsNull() {
            return new DirectSpecification<CompaniesAggSettings>(p => p.UserId == null);
        }
		public static Specification<CompaniesAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<CompaniesAggSettings>(p => p.UserId != null);
        }
				public static Specification<CompaniesAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<CompaniesAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<CompaniesAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<CompaniesAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<CompaniesAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<CompaniesAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<CompaniesAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<CompaniesAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<CompaniesAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<CompaniesAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<CompaniesAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<CompaniesAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<CompaniesAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<CompaniesAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<CompaniesAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<CompaniesAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<CompaniesAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<CompaniesAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<CompaniesAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<CompaniesAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<CompaniesAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<CompaniesAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<CompaniesAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<CompaniesAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.Id >= value);
        }
        public static Specification<CompaniesAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.Id <= value);
        }
        public static Specification<CompaniesAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.Id != value);
        }
        public static Specification<CompaniesAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.Id > value);
        }
        public static Specification<CompaniesAggSettings> IdLessThan(int value) {
            return new DirectSpecification<CompaniesAggSettings>(p => p.Id < value);
        }
			public static Specification<CompaniesAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<CompaniesAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<CompaniesAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<CompaniesAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<CompaniesAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<CompaniesAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<CompaniesAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<CompaniesAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<CompaniesAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<CompaniesAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<CompaniesAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<CompaniesAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<CompaniesAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<CompaniesAggSettings>(p => p.IsDeleted == value);
		}
	   }
   public partial class GrupoEmpresaEnderecoSpecifications {
		public static Specification<GrupoEmpresaEndereco> GrupoEmpresaIdEqual(params int[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.GrupoEmpresaId));
        }
        public static Specification<GrupoEmpresaEndereco> GrupoEmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.GrupoEmpresaId >= value);
        }
        public static Specification<GrupoEmpresaEndereco> GrupoEmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.GrupoEmpresaId <= value);
        }
        public static Specification<GrupoEmpresaEndereco> GrupoEmpresaIdNotEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.GrupoEmpresaId != value);
        }
        public static Specification<GrupoEmpresaEndereco> GrupoEmpresaIdGreatThan(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.GrupoEmpresaId > value);
        }
        public static Specification<GrupoEmpresaEndereco> GrupoEmpresaIdLessThan(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.GrupoEmpresaId < value);
        }
			public static Specification<GrupoEmpresaEndereco> EnderecoIdEqual(params int[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.EnderecoId.Value));
        }
        public static Specification<GrupoEmpresaEndereco> EnderecoIdGreatThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.EnderecoId >= value);
        }
        public static Specification<GrupoEmpresaEndereco> EnderecoIdLessThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.EnderecoId <= value);
        }
        public static Specification<GrupoEmpresaEndereco> EnderecoIdNotEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.EnderecoId != value);
        }
        public static Specification<GrupoEmpresaEndereco> EnderecoIdGreatThan(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.EnderecoId > value);
        }
        public static Specification<GrupoEmpresaEndereco> EnderecoIdLessThan(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.EnderecoId < value);
        }
			public static Specification<GrupoEmpresaEndereco> NumeroContains(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.Numero.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaEndereco> NumeroStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.Numero.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaEndereco> NumeroEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.Numero));
		}
		public static Specification<GrupoEmpresaEndereco> NumeroNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Numero != value);
		}
		public static Specification<GrupoEmpresaEndereco> NumeroIsNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Numero == null);
        }
		public static Specification<GrupoEmpresaEndereco> NumeroIsNotNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Numero != null);
        }
			public static Specification<GrupoEmpresaEndereco> ReferenciaContains(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.Referencia.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaEndereco> ReferenciaStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.Referencia.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaEndereco> ReferenciaEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.Referencia));
		}
		public static Specification<GrupoEmpresaEndereco> ReferenciaNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Referencia != value);
		}
		public static Specification<GrupoEmpresaEndereco> ReferenciaIsNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Referencia == null);
        }
		public static Specification<GrupoEmpresaEndereco> ReferenciaIsNotNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Referencia != null);
        }
			public static Specification<GrupoEmpresaEndereco> TipoEnderecoContains(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.TipoEndereco.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaEndereco> TipoEnderecoStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.TipoEndereco.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaEndereco> TipoEnderecoEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.TipoEndereco));
		}
		public static Specification<GrupoEmpresaEndereco> TipoEnderecoNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => p.TipoEndereco != value);
		}
		public static Specification<GrupoEmpresaEndereco> TipoEnderecoIsNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.TipoEndereco == null);
        }
		public static Specification<GrupoEmpresaEndereco> TipoEnderecoIsNotNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.TipoEndereco != null);
        }
			public static Specification<GrupoEmpresaEndereco> ComplementoContains(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.Complemento.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaEndereco> ComplementoStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.Complemento.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaEndereco> ComplementoEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.Complemento));
		}
		public static Specification<GrupoEmpresaEndereco> ComplementoNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Complemento != value);
		}
		public static Specification<GrupoEmpresaEndereco> ComplementoIsNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Complemento == null);
        }
		public static Specification<GrupoEmpresaEndereco> ComplementoIsNotNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Complemento != null);
        }
				public static Specification<GrupoEmpresaEndereco> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<GrupoEmpresaEndereco> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.CreatedAt >= value);
        }
        public static Specification<GrupoEmpresaEndereco> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.CreatedAt <= value);
        }
        public static Specification<GrupoEmpresaEndereco> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.CreatedAt != value);
        }
        public static Specification<GrupoEmpresaEndereco> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.CreatedAt > value);
        }
        public static Specification<GrupoEmpresaEndereco> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.CreatedAt < value);
        }
			public static Specification<GrupoEmpresaEndereco> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<GrupoEmpresaEndereco> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.UpdatedAt >= value);
        }
        public static Specification<GrupoEmpresaEndereco> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.UpdatedAt <= value);
        }
        public static Specification<GrupoEmpresaEndereco> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.UpdatedAt != value);
        }
        public static Specification<GrupoEmpresaEndereco> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.UpdatedAt > value);
        }
        public static Specification<GrupoEmpresaEndereco> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.UpdatedAt < value);
        }
			public static Specification<GrupoEmpresaEndereco> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<GrupoEmpresaEndereco> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.DeletedAt >= value);
        }
        public static Specification<GrupoEmpresaEndereco> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.DeletedAt <= value);
        }
        public static Specification<GrupoEmpresaEndereco> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.DeletedAt != value);
        }
        public static Specification<GrupoEmpresaEndereco> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.DeletedAt > value);
        }
        public static Specification<GrupoEmpresaEndereco> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.DeletedAt < value);
        }
			public static Specification<GrupoEmpresaEndereco> IdEqual(params int[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.Id));
        }
        public static Specification<GrupoEmpresaEndereco> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Id >= value);
        }
        public static Specification<GrupoEmpresaEndereco> IdLessThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Id <= value);
        }
        public static Specification<GrupoEmpresaEndereco> IdNotEqual(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Id != value);
        }
        public static Specification<GrupoEmpresaEndereco> IdGreatThan(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Id > value);
        }
        public static Specification<GrupoEmpresaEndereco> IdLessThan(int value) {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.Id < value);
        }
			public static Specification<GrupoEmpresaEndereco> ExternalIdContains(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresaEndereco> ExternalIdStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresaEndereco> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => values.Contains(p.ExternalId));
		}
		public static Specification<GrupoEmpresaEndereco> ExternalIdNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => p.ExternalId != value);
		}
		public static Specification<GrupoEmpresaEndereco> ExternalIdIsNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.ExternalId == null);
        }
		public static Specification<GrupoEmpresaEndereco> ExternalIdIsNotNull() {
            return new DirectSpecification<GrupoEmpresaEndereco>(p => p.ExternalId != null);
        }
			public static Specification<GrupoEmpresaEndereco> IsDeletedEqual(bool value) {
			return new DirectSpecification<GrupoEmpresaEndereco>(p => p.IsDeleted == value);
		}
	   }
   public partial class GrupoEmpresaSpecifications {
					public static Specification<GrupoEmpresa> CNPJContains(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresa> CNPJStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresa> CNPJEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.CNPJ));
		}
		public static Specification<GrupoEmpresa> CNPJNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => p.CNPJ != value);
		}
		public static Specification<GrupoEmpresa> CNPJIsNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.CNPJ == null);
        }
		public static Specification<GrupoEmpresa> CNPJIsNotNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.CNPJ != null);
        }
			public static Specification<GrupoEmpresa> RazaoSocialContains(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.RazaoSocial.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresa> RazaoSocialStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.RazaoSocial.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresa> RazaoSocialEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.RazaoSocial));
		}
		public static Specification<GrupoEmpresa> RazaoSocialNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => p.RazaoSocial != value);
		}
		public static Specification<GrupoEmpresa> RazaoSocialIsNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.RazaoSocial == null);
        }
		public static Specification<GrupoEmpresa> RazaoSocialIsNotNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.RazaoSocial != null);
        }
			public static Specification<GrupoEmpresa> NomeFantasiaContains(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.NomeFantasia.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresa> NomeFantasiaStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.NomeFantasia.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresa> NomeFantasiaEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.NomeFantasia));
		}
		public static Specification<GrupoEmpresa> NomeFantasiaNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => p.NomeFantasia != value);
		}
		public static Specification<GrupoEmpresa> NomeFantasiaIsNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.NomeFantasia == null);
        }
		public static Specification<GrupoEmpresa> NomeFantasiaIsNotNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.NomeFantasia != null);
        }
			public static Specification<GrupoEmpresa> CurrentStepEqual(params int[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.CurrentStep));
        }
        public static Specification<GrupoEmpresa> CurrentStepGreatThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CurrentStep >= value);
        }
        public static Specification<GrupoEmpresa> CurrentStepLessThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CurrentStep <= value);
        }
        public static Specification<GrupoEmpresa> CurrentStepNotEqual(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CurrentStep != value);
        }
        public static Specification<GrupoEmpresa> CurrentStepGreatThan(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CurrentStep > value);
        }
        public static Specification<GrupoEmpresa> CurrentStepLessThan(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CurrentStep < value);
        }
			public static Specification<GrupoEmpresa> InstituicaoTypeEqual(params Bravo.Companies.Enumerations.InstituicaoType[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.InstituicaoType));
		}
		public static Specification<GrupoEmpresa> InstituicaoTypeNotEqual(Bravo.Companies.Enumerations.InstituicaoType value) {
			return new DirectSpecification<GrupoEmpresa>(p => p.InstituicaoType != value);
		}
			public static Specification<GrupoEmpresa> AtivoEqual(bool value) {
			return new DirectSpecification<GrupoEmpresa>(p => p.Ativo == value);
		}
		public static Specification<GrupoEmpresa> AtivoIsNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.Ativo == null);
        }
		public static Specification<GrupoEmpresa> AtivoIsNotNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.Ativo != null);
        }
			public static Specification<GrupoEmpresa> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<GrupoEmpresa> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CreatedAt >= value);
        }
        public static Specification<GrupoEmpresa> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CreatedAt <= value);
        }
        public static Specification<GrupoEmpresa> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CreatedAt != value);
        }
        public static Specification<GrupoEmpresa> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CreatedAt > value);
        }
        public static Specification<GrupoEmpresa> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.CreatedAt < value);
        }
			public static Specification<GrupoEmpresa> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<GrupoEmpresa> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.UpdatedAt >= value);
        }
        public static Specification<GrupoEmpresa> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.UpdatedAt <= value);
        }
        public static Specification<GrupoEmpresa> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.UpdatedAt != value);
        }
        public static Specification<GrupoEmpresa> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.UpdatedAt > value);
        }
        public static Specification<GrupoEmpresa> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.UpdatedAt < value);
        }
			public static Specification<GrupoEmpresa> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<GrupoEmpresa> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.DeletedAt >= value);
        }
        public static Specification<GrupoEmpresa> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.DeletedAt <= value);
        }
        public static Specification<GrupoEmpresa> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.DeletedAt != value);
        }
        public static Specification<GrupoEmpresa> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.DeletedAt > value);
        }
        public static Specification<GrupoEmpresa> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.DeletedAt < value);
        }
			public static Specification<GrupoEmpresa> IdEqual(params int[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.Id));
        }
        public static Specification<GrupoEmpresa> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.Id >= value);
        }
        public static Specification<GrupoEmpresa> IdLessThanOrEqual(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.Id <= value);
        }
        public static Specification<GrupoEmpresa> IdNotEqual(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.Id != value);
        }
        public static Specification<GrupoEmpresa> IdGreatThan(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.Id > value);
        }
        public static Specification<GrupoEmpresa> IdLessThan(int value) {
            return new DirectSpecification<GrupoEmpresa>(p => p.Id < value);
        }
			public static Specification<GrupoEmpresa> ExternalIdContains(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<GrupoEmpresa> ExternalIdStartsWith(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<GrupoEmpresa> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<GrupoEmpresa>(p => values.Contains(p.ExternalId));
		}
		public static Specification<GrupoEmpresa> ExternalIdNotEqual(string value) {
			return new DirectSpecification<GrupoEmpresa>(p => p.ExternalId != value);
		}
		public static Specification<GrupoEmpresa> ExternalIdIsNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.ExternalId == null);
        }
		public static Specification<GrupoEmpresa> ExternalIdIsNotNull() {
            return new DirectSpecification<GrupoEmpresa>(p => p.ExternalId != null);
        }
			public static Specification<GrupoEmpresa> IsDeletedEqual(bool value) {
			return new DirectSpecification<GrupoEmpresa>(p => p.IsDeleted == value);
		}
	   }
   public partial class EmpresaEnderecoSpecifications {
		public static Specification<EmpresaEndereco> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.EmpresaId));
        }
        public static Specification<EmpresaEndereco> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EmpresaId >= value);
        }
        public static Specification<EmpresaEndereco> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EmpresaId <= value);
        }
        public static Specification<EmpresaEndereco> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EmpresaId != value);
        }
        public static Specification<EmpresaEndereco> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EmpresaId > value);
        }
        public static Specification<EmpresaEndereco> EmpresaIdLessThan(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EmpresaId < value);
        }
			public static Specification<EmpresaEndereco> EnderecoIdEqual(params int[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.EnderecoId.Value));
        }
        public static Specification<EmpresaEndereco> EnderecoIdGreatThanOrEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EnderecoId >= value);
        }
        public static Specification<EmpresaEndereco> EnderecoIdLessThanOrEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EnderecoId <= value);
        }
        public static Specification<EmpresaEndereco> EnderecoIdNotEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EnderecoId != value);
        }
        public static Specification<EmpresaEndereco> EnderecoIdGreatThan(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EnderecoId > value);
        }
        public static Specification<EmpresaEndereco> EnderecoIdLessThan(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.EnderecoId < value);
        }
			public static Specification<EmpresaEndereco> NumeroContains(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.Numero.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaEndereco> NumeroStartsWith(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.Numero.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaEndereco> NumeroEqual(params string[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.Numero));
		}
		public static Specification<EmpresaEndereco> NumeroNotEqual(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => p.Numero != value);
		}
		public static Specification<EmpresaEndereco> NumeroIsNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.Numero == null);
        }
		public static Specification<EmpresaEndereco> NumeroIsNotNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.Numero != null);
        }
			public static Specification<EmpresaEndereco> ReferenciaContains(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.Referencia.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaEndereco> ReferenciaStartsWith(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.Referencia.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaEndereco> ReferenciaEqual(params string[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.Referencia));
		}
		public static Specification<EmpresaEndereco> ReferenciaNotEqual(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => p.Referencia != value);
		}
		public static Specification<EmpresaEndereco> ReferenciaIsNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.Referencia == null);
        }
		public static Specification<EmpresaEndereco> ReferenciaIsNotNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.Referencia != null);
        }
			public static Specification<EmpresaEndereco> TipoEnderecoContains(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.TipoEndereco.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaEndereco> TipoEnderecoStartsWith(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.TipoEndereco.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaEndereco> TipoEnderecoEqual(params string[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.TipoEndereco));
		}
		public static Specification<EmpresaEndereco> TipoEnderecoNotEqual(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => p.TipoEndereco != value);
		}
		public static Specification<EmpresaEndereco> TipoEnderecoIsNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.TipoEndereco == null);
        }
		public static Specification<EmpresaEndereco> TipoEnderecoIsNotNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.TipoEndereco != null);
        }
			public static Specification<EmpresaEndereco> ComplementoContains(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.Complemento.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaEndereco> ComplementoStartsWith(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.Complemento.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaEndereco> ComplementoEqual(params string[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.Complemento));
		}
		public static Specification<EmpresaEndereco> ComplementoNotEqual(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => p.Complemento != value);
		}
		public static Specification<EmpresaEndereco> ComplementoIsNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.Complemento == null);
        }
		public static Specification<EmpresaEndereco> ComplementoIsNotNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.Complemento != null);
        }
				public static Specification<EmpresaEndereco> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<EmpresaEndereco> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.CreatedAt >= value);
        }
        public static Specification<EmpresaEndereco> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.CreatedAt <= value);
        }
        public static Specification<EmpresaEndereco> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.CreatedAt != value);
        }
        public static Specification<EmpresaEndereco> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.CreatedAt > value);
        }
        public static Specification<EmpresaEndereco> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.CreatedAt < value);
        }
			public static Specification<EmpresaEndereco> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<EmpresaEndereco> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.UpdatedAt >= value);
        }
        public static Specification<EmpresaEndereco> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.UpdatedAt <= value);
        }
        public static Specification<EmpresaEndereco> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.UpdatedAt != value);
        }
        public static Specification<EmpresaEndereco> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.UpdatedAt > value);
        }
        public static Specification<EmpresaEndereco> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.UpdatedAt < value);
        }
			public static Specification<EmpresaEndereco> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<EmpresaEndereco> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.DeletedAt >= value);
        }
        public static Specification<EmpresaEndereco> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.DeletedAt <= value);
        }
        public static Specification<EmpresaEndereco> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.DeletedAt != value);
        }
        public static Specification<EmpresaEndereco> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.DeletedAt > value);
        }
        public static Specification<EmpresaEndereco> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.DeletedAt < value);
        }
			public static Specification<EmpresaEndereco> IdEqual(params int[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.Id));
        }
        public static Specification<EmpresaEndereco> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.Id >= value);
        }
        public static Specification<EmpresaEndereco> IdLessThanOrEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.Id <= value);
        }
        public static Specification<EmpresaEndereco> IdNotEqual(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.Id != value);
        }
        public static Specification<EmpresaEndereco> IdGreatThan(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.Id > value);
        }
        public static Specification<EmpresaEndereco> IdLessThan(int value) {
            return new DirectSpecification<EmpresaEndereco>(p => p.Id < value);
        }
			public static Specification<EmpresaEndereco> ExternalIdContains(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaEndereco> ExternalIdStartsWith(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaEndereco> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<EmpresaEndereco>(p => values.Contains(p.ExternalId));
		}
		public static Specification<EmpresaEndereco> ExternalIdNotEqual(string value) {
			return new DirectSpecification<EmpresaEndereco>(p => p.ExternalId != value);
		}
		public static Specification<EmpresaEndereco> ExternalIdIsNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.ExternalId == null);
        }
		public static Specification<EmpresaEndereco> ExternalIdIsNotNull() {
            return new DirectSpecification<EmpresaEndereco>(p => p.ExternalId != null);
        }
			public static Specification<EmpresaEndereco> IsDeletedEqual(bool value) {
			return new DirectSpecification<EmpresaEndereco>(p => p.IsDeleted == value);
		}
	   }
   public partial class EmpresaContactsSpecifications {
		public static Specification<EmpresaContacts> EmailContains(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.Email.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaContacts> EmailStartsWith(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.Email.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaContacts> EmailEqual(params string[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.Email));
		}
		public static Specification<EmpresaContacts> EmailNotEqual(string value) {
			return new DirectSpecification<EmpresaContacts>(p => p.Email != value);
		}
		public static Specification<EmpresaContacts> EmailIsNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.Email == null);
        }
		public static Specification<EmpresaContacts> EmailIsNotNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.Email != null);
        }
			public static Specification<EmpresaContacts> TelefoneContains(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.Telefone.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaContacts> TelefoneStartsWith(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.Telefone.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaContacts> TelefoneEqual(params string[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.Telefone));
		}
		public static Specification<EmpresaContacts> TelefoneNotEqual(string value) {
			return new DirectSpecification<EmpresaContacts>(p => p.Telefone != value);
		}
		public static Specification<EmpresaContacts> TelefoneIsNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.Telefone == null);
        }
		public static Specification<EmpresaContacts> TelefoneIsNotNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.Telefone != null);
        }
			public static Specification<EmpresaContacts> TipoTelefoneContains(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.TipoTelefone.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaContacts> TipoTelefoneStartsWith(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.TipoTelefone.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaContacts> TipoTelefoneEqual(params string[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.TipoTelefone));
		}
		public static Specification<EmpresaContacts> TipoTelefoneNotEqual(string value) {
			return new DirectSpecification<EmpresaContacts>(p => p.TipoTelefone != value);
		}
		public static Specification<EmpresaContacts> TipoTelefoneIsNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.TipoTelefone == null);
        }
		public static Specification<EmpresaContacts> TipoTelefoneIsNotNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.TipoTelefone != null);
        }
			public static Specification<EmpresaContacts> WebSiteContains(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.WebSite.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaContacts> WebSiteStartsWith(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.WebSite.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaContacts> WebSiteEqual(params string[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.WebSite));
		}
		public static Specification<EmpresaContacts> WebSiteNotEqual(string value) {
			return new DirectSpecification<EmpresaContacts>(p => p.WebSite != value);
		}
		public static Specification<EmpresaContacts> WebSiteIsNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.WebSite == null);
        }
		public static Specification<EmpresaContacts> WebSiteIsNotNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.WebSite != null);
        }
			public static Specification<EmpresaContacts> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<EmpresaContacts> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.CreatedAt >= value);
        }
        public static Specification<EmpresaContacts> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.CreatedAt <= value);
        }
        public static Specification<EmpresaContacts> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.CreatedAt != value);
        }
        public static Specification<EmpresaContacts> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.CreatedAt > value);
        }
        public static Specification<EmpresaContacts> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.CreatedAt < value);
        }
			public static Specification<EmpresaContacts> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<EmpresaContacts> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.UpdatedAt >= value);
        }
        public static Specification<EmpresaContacts> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.UpdatedAt <= value);
        }
        public static Specification<EmpresaContacts> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.UpdatedAt != value);
        }
        public static Specification<EmpresaContacts> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.UpdatedAt > value);
        }
        public static Specification<EmpresaContacts> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.UpdatedAt < value);
        }
			public static Specification<EmpresaContacts> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<EmpresaContacts> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.DeletedAt >= value);
        }
        public static Specification<EmpresaContacts> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.DeletedAt <= value);
        }
        public static Specification<EmpresaContacts> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.DeletedAt != value);
        }
        public static Specification<EmpresaContacts> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.DeletedAt > value);
        }
        public static Specification<EmpresaContacts> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<EmpresaContacts>(p => p.DeletedAt < value);
        }
			public static Specification<EmpresaContacts> IdEqual(params int[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.Id));
        }
        public static Specification<EmpresaContacts> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<EmpresaContacts>(p => p.Id >= value);
        }
        public static Specification<EmpresaContacts> IdLessThanOrEqual(int value) {
            return new DirectSpecification<EmpresaContacts>(p => p.Id <= value);
        }
        public static Specification<EmpresaContacts> IdNotEqual(int value) {
            return new DirectSpecification<EmpresaContacts>(p => p.Id != value);
        }
        public static Specification<EmpresaContacts> IdGreatThan(int value) {
            return new DirectSpecification<EmpresaContacts>(p => p.Id > value);
        }
        public static Specification<EmpresaContacts> IdLessThan(int value) {
            return new DirectSpecification<EmpresaContacts>(p => p.Id < value);
        }
			public static Specification<EmpresaContacts> ExternalIdContains(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<EmpresaContacts> ExternalIdStartsWith(string value) {
			return new DirectSpecification<EmpresaContacts>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<EmpresaContacts> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<EmpresaContacts>(p => values.Contains(p.ExternalId));
		}
		public static Specification<EmpresaContacts> ExternalIdNotEqual(string value) {
			return new DirectSpecification<EmpresaContacts>(p => p.ExternalId != value);
		}
		public static Specification<EmpresaContacts> ExternalIdIsNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.ExternalId == null);
        }
		public static Specification<EmpresaContacts> ExternalIdIsNotNull() {
            return new DirectSpecification<EmpresaContacts>(p => p.ExternalId != null);
        }
			public static Specification<EmpresaContacts> IsDeletedEqual(bool value) {
			return new DirectSpecification<EmpresaContacts>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Specifications {
	using Entities;
   public partial class ProfissionalConfiguracaoSpecifications {
			public static Specification<ProfissionalConfiguracao> SetorProprioEqual(bool value) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => p.SetorProprio == value);
		}
		public static Specification<ProfissionalConfiguracao> SetorProprioIsNull() {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.SetorProprio == null);
        }
		public static Specification<ProfissionalConfiguracao> SetorProprioIsNotNull() {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.SetorProprio != null);
        }
			public static Specification<ProfissionalConfiguracao> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<ProfissionalConfiguracao> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.CreatedAt >= value);
        }
        public static Specification<ProfissionalConfiguracao> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.CreatedAt <= value);
        }
        public static Specification<ProfissionalConfiguracao> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.CreatedAt != value);
        }
        public static Specification<ProfissionalConfiguracao> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.CreatedAt > value);
        }
        public static Specification<ProfissionalConfiguracao> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.CreatedAt < value);
        }
			public static Specification<ProfissionalConfiguracao> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<ProfissionalConfiguracao> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.UpdatedAt >= value);
        }
        public static Specification<ProfissionalConfiguracao> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.UpdatedAt <= value);
        }
        public static Specification<ProfissionalConfiguracao> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.UpdatedAt != value);
        }
        public static Specification<ProfissionalConfiguracao> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.UpdatedAt > value);
        }
        public static Specification<ProfissionalConfiguracao> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.UpdatedAt < value);
        }
			public static Specification<ProfissionalConfiguracao> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<ProfissionalConfiguracao> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.DeletedAt >= value);
        }
        public static Specification<ProfissionalConfiguracao> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.DeletedAt <= value);
        }
        public static Specification<ProfissionalConfiguracao> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.DeletedAt != value);
        }
        public static Specification<ProfissionalConfiguracao> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.DeletedAt > value);
        }
        public static Specification<ProfissionalConfiguracao> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.DeletedAt < value);
        }
			public static Specification<ProfissionalConfiguracao> IdEqual(params int[] values) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => values.Contains(p.Id));
        }
        public static Specification<ProfissionalConfiguracao> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.Id >= value);
        }
        public static Specification<ProfissionalConfiguracao> IdLessThanOrEqual(int value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.Id <= value);
        }
        public static Specification<ProfissionalConfiguracao> IdNotEqual(int value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.Id != value);
        }
        public static Specification<ProfissionalConfiguracao> IdGreatThan(int value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.Id > value);
        }
        public static Specification<ProfissionalConfiguracao> IdLessThan(int value) {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.Id < value);
        }
			public static Specification<ProfissionalConfiguracao> ExternalIdContains(string value) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ProfissionalConfiguracao> ExternalIdStartsWith(string value) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ProfissionalConfiguracao> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => values.Contains(p.ExternalId));
		}
		public static Specification<ProfissionalConfiguracao> ExternalIdNotEqual(string value) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => p.ExternalId != value);
		}
		public static Specification<ProfissionalConfiguracao> ExternalIdIsNull() {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.ExternalId == null);
        }
		public static Specification<ProfissionalConfiguracao> ExternalIdIsNotNull() {
            return new DirectSpecification<ProfissionalConfiguracao>(p => p.ExternalId != null);
        }
			public static Specification<ProfissionalConfiguracao> IsDeletedEqual(bool value) {
			return new DirectSpecification<ProfissionalConfiguracao>(p => p.IsDeleted == value);
		}
	   }
   public partial class FuncionarioSpecifications {
		public static Specification<Funcionario> NomeContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> NomeStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> NomeEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Nome));
		}
		public static Specification<Funcionario> NomeNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.Nome != value);
		}
		public static Specification<Funcionario> NomeIsNull() {
            return new DirectSpecification<Funcionario>(p => p.Nome == null);
        }
		public static Specification<Funcionario> NomeIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.Nome != null);
        }
			public static Specification<Funcionario> NomeSocialContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.NomeSocial.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> NomeSocialStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.NomeSocial.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> NomeSocialEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.NomeSocial));
		}
		public static Specification<Funcionario> NomeSocialNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.NomeSocial != value);
		}
		public static Specification<Funcionario> NomeSocialIsNull() {
            return new DirectSpecification<Funcionario>(p => p.NomeSocial == null);
        }
		public static Specification<Funcionario> NomeSocialIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.NomeSocial != null);
        }
			public static Specification<Funcionario> CPFContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CPF.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> CPFStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CPF.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> CPFEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.CPF));
		}
		public static Specification<Funcionario> CPFNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.CPF != value);
		}
		public static Specification<Funcionario> CPFIsNull() {
            return new DirectSpecification<Funcionario>(p => p.CPF == null);
        }
		public static Specification<Funcionario> CPFIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.CPF != null);
        }
			public static Specification<Funcionario> CNPJContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> CNPJStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> CNPJEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.CNPJ));
		}
		public static Specification<Funcionario> CNPJNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.CNPJ != value);
		}
		public static Specification<Funcionario> CNPJIsNull() {
            return new DirectSpecification<Funcionario>(p => p.CNPJ == null);
        }
		public static Specification<Funcionario> CNPJIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.CNPJ != null);
        }
			public static Specification<Funcionario> UsuarioLoginContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.UsuarioLogin.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> UsuarioLoginStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.UsuarioLogin.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> UsuarioLoginEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.UsuarioLogin));
		}
		public static Specification<Funcionario> UsuarioLoginNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.UsuarioLogin != value);
		}
		public static Specification<Funcionario> UsuarioLoginIsNull() {
            return new DirectSpecification<Funcionario>(p => p.UsuarioLogin == null);
        }
		public static Specification<Funcionario> UsuarioLoginIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.UsuarioLogin != null);
        }
			public static Specification<Funcionario> DataNascimentoEqual(params System.DateOnly[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.DataNascimento));
        }
        public static Specification<Funcionario> DataNascimentoGreatThanOrEqual(System.DateOnly value) {
            return new DirectSpecification<Funcionario>(p => p.DataNascimento >= value);
        }
        public static Specification<Funcionario> DataNascimentoLessThanOrEqual(System.DateOnly value) {
            return new DirectSpecification<Funcionario>(p => p.DataNascimento <= value);
        }
        public static Specification<Funcionario> DataNascimentoNotEqual(System.DateOnly value) {
            return new DirectSpecification<Funcionario>(p => p.DataNascimento != value);
        }
        public static Specification<Funcionario> DataNascimentoGreatThan(System.DateOnly value) {
            return new DirectSpecification<Funcionario>(p => p.DataNascimento > value);
        }
        public static Specification<Funcionario> DataNascimentoLessThan(System.DateOnly value) {
            return new DirectSpecification<Funcionario>(p => p.DataNascimento < value);
        }
			public static Specification<Funcionario> GeneroEqual(params Bravo.Professionals.Enumerations.Enum.GeneroEnum[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Genero));
		}
		public static Specification<Funcionario> GeneroNotEqual(Bravo.Professionals.Enumerations.Enum.GeneroEnum value) {
			return new DirectSpecification<Funcionario>(p => p.Genero != value);
		}
			public static Specification<Funcionario> EspecialidadeContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Especialidade.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> EspecialidadeStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Especialidade.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> EspecialidadeEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Especialidade));
		}
		public static Specification<Funcionario> EspecialidadeNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.Especialidade != value);
		}
		public static Specification<Funcionario> EspecialidadeIsNull() {
            return new DirectSpecification<Funcionario>(p => p.Especialidade == null);
        }
		public static Specification<Funcionario> EspecialidadeIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.Especialidade != null);
        }
			public static Specification<Funcionario> SubEspecialidadeContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.SubEspecialidade.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> SubEspecialidadeStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.SubEspecialidade.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> SubEspecialidadeEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.SubEspecialidade));
		}
		public static Specification<Funcionario> SubEspecialidadeNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.SubEspecialidade != value);
		}
		public static Specification<Funcionario> SubEspecialidadeIsNull() {
            return new DirectSpecification<Funcionario>(p => p.SubEspecialidade == null);
        }
		public static Specification<Funcionario> SubEspecialidadeIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.SubEspecialidade != null);
        }
			public static Specification<Funcionario> CorpoClinicoContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CorpoClinico.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> CorpoClinicoStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CorpoClinico.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> CorpoClinicoEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.CorpoClinico));
		}
		public static Specification<Funcionario> CorpoClinicoNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.CorpoClinico != value);
		}
		public static Specification<Funcionario> CorpoClinicoIsNull() {
            return new DirectSpecification<Funcionario>(p => p.CorpoClinico == null);
        }
		public static Specification<Funcionario> CorpoClinicoIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.CorpoClinico != null);
        }
			public static Specification<Funcionario> CodigoSusContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CodigoSus.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> CodigoSusStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CodigoSus.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> CodigoSusEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.CodigoSus));
		}
		public static Specification<Funcionario> CodigoSusNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.CodigoSus != value);
		}
		public static Specification<Funcionario> CodigoSusIsNull() {
            return new DirectSpecification<Funcionario>(p => p.CodigoSus == null);
        }
		public static Specification<Funcionario> CodigoSusIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.CodigoSus != null);
        }
			public static Specification<Funcionario> CodigoCnesContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CodigoCnes.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> CodigoCnesStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.CodigoCnes.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> CodigoCnesEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.CodigoCnes));
		}
		public static Specification<Funcionario> CodigoCnesNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.CodigoCnes != value);
		}
		public static Specification<Funcionario> CodigoCnesIsNull() {
            return new DirectSpecification<Funcionario>(p => p.CodigoCnes == null);
        }
		public static Specification<Funcionario> CodigoCnesIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.CodigoCnes != null);
        }
			public static Specification<Funcionario> CboIdEqual(params int[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.CboId.Value));
        }
        public static Specification<Funcionario> CboIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Funcionario>(p => p.CboId >= value);
        }
        public static Specification<Funcionario> CboIdLessThanOrEqual(int value) {
            return new DirectSpecification<Funcionario>(p => p.CboId <= value);
        }
        public static Specification<Funcionario> CboIdNotEqual(int value) {
            return new DirectSpecification<Funcionario>(p => p.CboId != value);
        }
        public static Specification<Funcionario> CboIdGreatThan(int value) {
            return new DirectSpecification<Funcionario>(p => p.CboId > value);
        }
        public static Specification<Funcionario> CboIdLessThan(int value) {
            return new DirectSpecification<Funcionario>(p => p.CboId < value);
        }
			public static Specification<Funcionario> ConvenioContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Convenio.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> ConvenioStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Convenio.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> ConvenioEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Convenio));
		}
		public static Specification<Funcionario> ConvenioNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.Convenio != value);
		}
		public static Specification<Funcionario> ConvenioIsNull() {
            return new DirectSpecification<Funcionario>(p => p.Convenio == null);
        }
		public static Specification<Funcionario> ConvenioIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.Convenio != null);
        }
			public static Specification<Funcionario> EscolaridadeEqual(params Bravo.Professionals.Enumerations.Enum.Escolaridade[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Escolaridade.Value));
		}
		public static Specification<Funcionario> EscolaridadeNotEqual(Bravo.Professionals.Enumerations.Enum.Escolaridade value) {
			return new DirectSpecification<Funcionario>(p => p.Escolaridade != value);
		}
			public static Specification<Funcionario> FuncaoContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Funcao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> FuncaoStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Funcao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> FuncaoEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Funcao));
		}
		public static Specification<Funcionario> FuncaoNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.Funcao != value);
		}
		public static Specification<Funcionario> FuncaoIsNull() {
            return new DirectSpecification<Funcionario>(p => p.Funcao == null);
        }
		public static Specification<Funcionario> FuncaoIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.Funcao != null);
        }
			public static Specification<Funcionario> CargosContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Cargos.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> CargosStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Cargos.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> CargosEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Cargos));
		}
		public static Specification<Funcionario> CargosNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.Cargos != value);
		}
		public static Specification<Funcionario> CargosIsNull() {
            return new DirectSpecification<Funcionario>(p => p.Cargos == null);
        }
		public static Specification<Funcionario> CargosIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.Cargos != null);
        }
			public static Specification<Funcionario> TelefoneContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Telefone.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> TelefoneStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Telefone.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> TelefoneEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Telefone));
		}
		public static Specification<Funcionario> TelefoneNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.Telefone != value);
		}
		public static Specification<Funcionario> TelefoneIsNull() {
            return new DirectSpecification<Funcionario>(p => p.Telefone == null);
        }
		public static Specification<Funcionario> TelefoneIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.Telefone != null);
        }
			public static Specification<Funcionario> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.EmpresaId.Value));
        }
        public static Specification<Funcionario> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Funcionario>(p => p.EmpresaId >= value);
        }
        public static Specification<Funcionario> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<Funcionario>(p => p.EmpresaId <= value);
        }
        public static Specification<Funcionario> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<Funcionario>(p => p.EmpresaId != value);
        }
        public static Specification<Funcionario> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<Funcionario>(p => p.EmpresaId > value);
        }
        public static Specification<Funcionario> EmpresaIdLessThan(int value) {
            return new DirectSpecification<Funcionario>(p => p.EmpresaId < value);
        }
			public static Specification<Funcionario> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Funcionario> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.CreatedAt >= value);
        }
        public static Specification<Funcionario> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.CreatedAt <= value);
        }
        public static Specification<Funcionario> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.CreatedAt != value);
        }
        public static Specification<Funcionario> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.CreatedAt > value);
        }
        public static Specification<Funcionario> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.CreatedAt < value);
        }
			public static Specification<Funcionario> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Funcionario> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.UpdatedAt >= value);
        }
        public static Specification<Funcionario> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.UpdatedAt <= value);
        }
        public static Specification<Funcionario> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.UpdatedAt != value);
        }
        public static Specification<Funcionario> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.UpdatedAt > value);
        }
        public static Specification<Funcionario> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.UpdatedAt < value);
        }
			public static Specification<Funcionario> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Funcionario> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.DeletedAt >= value);
        }
        public static Specification<Funcionario> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.DeletedAt <= value);
        }
        public static Specification<Funcionario> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.DeletedAt != value);
        }
        public static Specification<Funcionario> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.DeletedAt > value);
        }
        public static Specification<Funcionario> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Funcionario>(p => p.DeletedAt < value);
        }
			public static Specification<Funcionario> IdContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Id.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> IdStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.Id.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> IdEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.Id));
		}
		public static Specification<Funcionario> IdNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.Id != value);
		}
		public static Specification<Funcionario> IdIsNull() {
            return new DirectSpecification<Funcionario>(p => p.Id == null);
        }
		public static Specification<Funcionario> IdIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.Id != null);
        }
			public static Specification<Funcionario> ExternalIdContains(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Funcionario> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Funcionario>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Funcionario> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Funcionario>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Funcionario> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Funcionario>(p => p.ExternalId != value);
		}
		public static Specification<Funcionario> ExternalIdIsNull() {
            return new DirectSpecification<Funcionario>(p => p.ExternalId == null);
        }
		public static Specification<Funcionario> ExternalIdIsNotNull() {
            return new DirectSpecification<Funcionario>(p => p.ExternalId != null);
        }
			public static Specification<Funcionario> IsDeletedEqual(bool value) {
			return new DirectSpecification<Funcionario>(p => p.IsDeleted == value);
		}
	   }
   public partial class ProfissionalSpecifications {
				public static Specification<Profissional> NomeContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> NomeStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> NomeEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Nome));
		}
		public static Specification<Profissional> NomeNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.Nome != value);
		}
		public static Specification<Profissional> NomeIsNull() {
            return new DirectSpecification<Profissional>(p => p.Nome == null);
        }
		public static Specification<Profissional> NomeIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.Nome != null);
        }
			public static Specification<Profissional> NomeSocialContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.NomeSocial.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> NomeSocialStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.NomeSocial.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> NomeSocialEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.NomeSocial));
		}
		public static Specification<Profissional> NomeSocialNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.NomeSocial != value);
		}
		public static Specification<Profissional> NomeSocialIsNull() {
            return new DirectSpecification<Profissional>(p => p.NomeSocial == null);
        }
		public static Specification<Profissional> NomeSocialIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.NomeSocial != null);
        }
			public static Specification<Profissional> CPFContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CPF.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> CPFStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CPF.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> CPFEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.CPF));
		}
		public static Specification<Profissional> CPFNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.CPF != value);
		}
		public static Specification<Profissional> CPFIsNull() {
            return new DirectSpecification<Profissional>(p => p.CPF == null);
        }
		public static Specification<Profissional> CPFIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.CPF != null);
        }
			public static Specification<Profissional> CNPJContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> CNPJStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CNPJ.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> CNPJEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.CNPJ));
		}
		public static Specification<Profissional> CNPJNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.CNPJ != value);
		}
		public static Specification<Profissional> CNPJIsNull() {
            return new DirectSpecification<Profissional>(p => p.CNPJ == null);
        }
		public static Specification<Profissional> CNPJIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.CNPJ != null);
        }
			public static Specification<Profissional> UsuarioLoginContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.UsuarioLogin.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> UsuarioLoginStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.UsuarioLogin.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> UsuarioLoginEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.UsuarioLogin));
		}
		public static Specification<Profissional> UsuarioLoginNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.UsuarioLogin != value);
		}
		public static Specification<Profissional> UsuarioLoginIsNull() {
            return new DirectSpecification<Profissional>(p => p.UsuarioLogin == null);
        }
		public static Specification<Profissional> UsuarioLoginIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.UsuarioLogin != null);
        }
			public static Specification<Profissional> DataNascimentoEqual(params System.DateOnly[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.DataNascimento));
        }
        public static Specification<Profissional> DataNascimentoGreatThanOrEqual(System.DateOnly value) {
            return new DirectSpecification<Profissional>(p => p.DataNascimento >= value);
        }
        public static Specification<Profissional> DataNascimentoLessThanOrEqual(System.DateOnly value) {
            return new DirectSpecification<Profissional>(p => p.DataNascimento <= value);
        }
        public static Specification<Profissional> DataNascimentoNotEqual(System.DateOnly value) {
            return new DirectSpecification<Profissional>(p => p.DataNascimento != value);
        }
        public static Specification<Profissional> DataNascimentoGreatThan(System.DateOnly value) {
            return new DirectSpecification<Profissional>(p => p.DataNascimento > value);
        }
        public static Specification<Profissional> DataNascimentoLessThan(System.DateOnly value) {
            return new DirectSpecification<Profissional>(p => p.DataNascimento < value);
        }
			public static Specification<Profissional> GeneroEqual(params Bravo.Professionals.Enumerations.Enum.GeneroEnum[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Genero));
		}
		public static Specification<Profissional> GeneroNotEqual(Bravo.Professionals.Enumerations.Enum.GeneroEnum value) {
			return new DirectSpecification<Profissional>(p => p.Genero != value);
		}
			public static Specification<Profissional> EspecialidadeContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Especialidade.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> EspecialidadeStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Especialidade.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> EspecialidadeEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Especialidade));
		}
		public static Specification<Profissional> EspecialidadeNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.Especialidade != value);
		}
		public static Specification<Profissional> EspecialidadeIsNull() {
            return new DirectSpecification<Profissional>(p => p.Especialidade == null);
        }
		public static Specification<Profissional> EspecialidadeIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.Especialidade != null);
        }
			public static Specification<Profissional> SubEspecialidadeContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.SubEspecialidade.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> SubEspecialidadeStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.SubEspecialidade.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> SubEspecialidadeEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.SubEspecialidade));
		}
		public static Specification<Profissional> SubEspecialidadeNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.SubEspecialidade != value);
		}
		public static Specification<Profissional> SubEspecialidadeIsNull() {
            return new DirectSpecification<Profissional>(p => p.SubEspecialidade == null);
        }
		public static Specification<Profissional> SubEspecialidadeIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.SubEspecialidade != null);
        }
			public static Specification<Profissional> CorpoClinicoContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CorpoClinico.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> CorpoClinicoStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CorpoClinico.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> CorpoClinicoEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.CorpoClinico));
		}
		public static Specification<Profissional> CorpoClinicoNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.CorpoClinico != value);
		}
		public static Specification<Profissional> CorpoClinicoIsNull() {
            return new DirectSpecification<Profissional>(p => p.CorpoClinico == null);
        }
		public static Specification<Profissional> CorpoClinicoIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.CorpoClinico != null);
        }
			public static Specification<Profissional> CodigoSusContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CodigoSus.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> CodigoSusStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CodigoSus.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> CodigoSusEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.CodigoSus));
		}
		public static Specification<Profissional> CodigoSusNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.CodigoSus != value);
		}
		public static Specification<Profissional> CodigoSusIsNull() {
            return new DirectSpecification<Profissional>(p => p.CodigoSus == null);
        }
		public static Specification<Profissional> CodigoSusIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.CodigoSus != null);
        }
			public static Specification<Profissional> CodigoCnesContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CodigoCnes.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> CodigoCnesStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.CodigoCnes.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> CodigoCnesEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.CodigoCnes));
		}
		public static Specification<Profissional> CodigoCnesNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.CodigoCnes != value);
		}
		public static Specification<Profissional> CodigoCnesIsNull() {
            return new DirectSpecification<Profissional>(p => p.CodigoCnes == null);
        }
		public static Specification<Profissional> CodigoCnesIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.CodigoCnes != null);
        }
			public static Specification<Profissional> CboIdEqual(params int[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.CboId.Value));
        }
        public static Specification<Profissional> CboIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Profissional>(p => p.CboId >= value);
        }
        public static Specification<Profissional> CboIdLessThanOrEqual(int value) {
            return new DirectSpecification<Profissional>(p => p.CboId <= value);
        }
        public static Specification<Profissional> CboIdNotEqual(int value) {
            return new DirectSpecification<Profissional>(p => p.CboId != value);
        }
        public static Specification<Profissional> CboIdGreatThan(int value) {
            return new DirectSpecification<Profissional>(p => p.CboId > value);
        }
        public static Specification<Profissional> CboIdLessThan(int value) {
            return new DirectSpecification<Profissional>(p => p.CboId < value);
        }
			public static Specification<Profissional> ConvenioContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Convenio.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> ConvenioStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Convenio.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> ConvenioEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Convenio));
		}
		public static Specification<Profissional> ConvenioNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.Convenio != value);
		}
		public static Specification<Profissional> ConvenioIsNull() {
            return new DirectSpecification<Profissional>(p => p.Convenio == null);
        }
		public static Specification<Profissional> ConvenioIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.Convenio != null);
        }
			public static Specification<Profissional> EscolaridadeEqual(params Bravo.Professionals.Enumerations.Enum.Escolaridade[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Escolaridade.Value));
		}
		public static Specification<Profissional> EscolaridadeNotEqual(Bravo.Professionals.Enumerations.Enum.Escolaridade value) {
			return new DirectSpecification<Profissional>(p => p.Escolaridade != value);
		}
			public static Specification<Profissional> FuncaoContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Funcao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> FuncaoStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Funcao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> FuncaoEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Funcao));
		}
		public static Specification<Profissional> FuncaoNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.Funcao != value);
		}
		public static Specification<Profissional> FuncaoIsNull() {
            return new DirectSpecification<Profissional>(p => p.Funcao == null);
        }
		public static Specification<Profissional> FuncaoIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.Funcao != null);
        }
			public static Specification<Profissional> CargosContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Cargos.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> CargosStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Cargos.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> CargosEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Cargos));
		}
		public static Specification<Profissional> CargosNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.Cargos != value);
		}
		public static Specification<Profissional> CargosIsNull() {
            return new DirectSpecification<Profissional>(p => p.Cargos == null);
        }
		public static Specification<Profissional> CargosIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.Cargos != null);
        }
			public static Specification<Profissional> TelefoneContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Telefone.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> TelefoneStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Telefone.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> TelefoneEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Telefone));
		}
		public static Specification<Profissional> TelefoneNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.Telefone != value);
		}
		public static Specification<Profissional> TelefoneIsNull() {
            return new DirectSpecification<Profissional>(p => p.Telefone == null);
        }
		public static Specification<Profissional> TelefoneIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.Telefone != null);
        }
			public static Specification<Profissional> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.EmpresaId.Value));
        }
        public static Specification<Profissional> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Profissional>(p => p.EmpresaId >= value);
        }
        public static Specification<Profissional> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<Profissional>(p => p.EmpresaId <= value);
        }
        public static Specification<Profissional> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<Profissional>(p => p.EmpresaId != value);
        }
        public static Specification<Profissional> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<Profissional>(p => p.EmpresaId > value);
        }
        public static Specification<Profissional> EmpresaIdLessThan(int value) {
            return new DirectSpecification<Profissional>(p => p.EmpresaId < value);
        }
			public static Specification<Profissional> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Profissional> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.CreatedAt >= value);
        }
        public static Specification<Profissional> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.CreatedAt <= value);
        }
        public static Specification<Profissional> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.CreatedAt != value);
        }
        public static Specification<Profissional> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.CreatedAt > value);
        }
        public static Specification<Profissional> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.CreatedAt < value);
        }
			public static Specification<Profissional> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Profissional> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.UpdatedAt >= value);
        }
        public static Specification<Profissional> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.UpdatedAt <= value);
        }
        public static Specification<Profissional> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.UpdatedAt != value);
        }
        public static Specification<Profissional> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.UpdatedAt > value);
        }
        public static Specification<Profissional> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.UpdatedAt < value);
        }
			public static Specification<Profissional> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Profissional> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.DeletedAt >= value);
        }
        public static Specification<Profissional> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.DeletedAt <= value);
        }
        public static Specification<Profissional> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.DeletedAt != value);
        }
        public static Specification<Profissional> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.DeletedAt > value);
        }
        public static Specification<Profissional> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Profissional>(p => p.DeletedAt < value);
        }
			public static Specification<Profissional> IdContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Id.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> IdStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.Id.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> IdEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.Id));
		}
		public static Specification<Profissional> IdNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.Id != value);
		}
		public static Specification<Profissional> IdIsNull() {
            return new DirectSpecification<Profissional>(p => p.Id == null);
        }
		public static Specification<Profissional> IdIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.Id != null);
        }
			public static Specification<Profissional> ExternalIdContains(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Profissional> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Profissional>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Profissional> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Profissional>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Profissional> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Profissional>(p => p.ExternalId != value);
		}
		public static Specification<Profissional> ExternalIdIsNull() {
            return new DirectSpecification<Profissional>(p => p.ExternalId == null);
        }
		public static Specification<Profissional> ExternalIdIsNotNull() {
            return new DirectSpecification<Profissional>(p => p.ExternalId != null);
        }
			public static Specification<Profissional> IsDeletedEqual(bool value) {
			return new DirectSpecification<Profissional>(p => p.IsDeleted == value);
		}
	   }
   public partial class CboSpecifications {
		public static Specification<Cbo> CodigoContains(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.Codigo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Cbo> CodigoStartsWith(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.Codigo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Cbo> CodigoEqual(params string[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.Codigo));
		}
		public static Specification<Cbo> CodigoNotEqual(string value) {
			return new DirectSpecification<Cbo>(p => p.Codigo != value);
		}
		public static Specification<Cbo> CodigoIsNull() {
            return new DirectSpecification<Cbo>(p => p.Codigo == null);
        }
		public static Specification<Cbo> CodigoIsNotNull() {
            return new DirectSpecification<Cbo>(p => p.Codigo != null);
        }
			public static Specification<Cbo> TitulosContains(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.Titulos.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Cbo> TitulosStartsWith(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.Titulos.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Cbo> TitulosEqual(params string[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.Titulos));
		}
		public static Specification<Cbo> TitulosNotEqual(string value) {
			return new DirectSpecification<Cbo>(p => p.Titulos != value);
		}
		public static Specification<Cbo> TitulosIsNull() {
            return new DirectSpecification<Cbo>(p => p.Titulos == null);
        }
		public static Specification<Cbo> TitulosIsNotNull() {
            return new DirectSpecification<Cbo>(p => p.Titulos != null);
        }
			public static Specification<Cbo> TipoContains(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.Tipo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Cbo> TipoStartsWith(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.Tipo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Cbo> TipoEqual(params string[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.Tipo));
		}
		public static Specification<Cbo> TipoNotEqual(string value) {
			return new DirectSpecification<Cbo>(p => p.Tipo != value);
		}
		public static Specification<Cbo> TipoIsNull() {
            return new DirectSpecification<Cbo>(p => p.Tipo == null);
        }
		public static Specification<Cbo> TipoIsNotNull() {
            return new DirectSpecification<Cbo>(p => p.Tipo != null);
        }
			public static Specification<Cbo> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Cbo> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.CreatedAt >= value);
        }
        public static Specification<Cbo> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.CreatedAt <= value);
        }
        public static Specification<Cbo> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.CreatedAt != value);
        }
        public static Specification<Cbo> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.CreatedAt > value);
        }
        public static Specification<Cbo> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.CreatedAt < value);
        }
			public static Specification<Cbo> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Cbo> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.UpdatedAt >= value);
        }
        public static Specification<Cbo> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.UpdatedAt <= value);
        }
        public static Specification<Cbo> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.UpdatedAt != value);
        }
        public static Specification<Cbo> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.UpdatedAt > value);
        }
        public static Specification<Cbo> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.UpdatedAt < value);
        }
			public static Specification<Cbo> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Cbo> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.DeletedAt >= value);
        }
        public static Specification<Cbo> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.DeletedAt <= value);
        }
        public static Specification<Cbo> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.DeletedAt != value);
        }
        public static Specification<Cbo> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.DeletedAt > value);
        }
        public static Specification<Cbo> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Cbo>(p => p.DeletedAt < value);
        }
			public static Specification<Cbo> IdEqual(params int[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.Id));
        }
        public static Specification<Cbo> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Cbo>(p => p.Id >= value);
        }
        public static Specification<Cbo> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Cbo>(p => p.Id <= value);
        }
        public static Specification<Cbo> IdNotEqual(int value) {
            return new DirectSpecification<Cbo>(p => p.Id != value);
        }
        public static Specification<Cbo> IdGreatThan(int value) {
            return new DirectSpecification<Cbo>(p => p.Id > value);
        }
        public static Specification<Cbo> IdLessThan(int value) {
            return new DirectSpecification<Cbo>(p => p.Id < value);
        }
			public static Specification<Cbo> ExternalIdContains(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Cbo> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Cbo>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Cbo> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Cbo>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Cbo> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Cbo>(p => p.ExternalId != value);
		}
		public static Specification<Cbo> ExternalIdIsNull() {
            return new DirectSpecification<Cbo>(p => p.ExternalId == null);
        }
		public static Specification<Cbo> ExternalIdIsNotNull() {
            return new DirectSpecification<Cbo>(p => p.ExternalId != null);
        }
			public static Specification<Cbo> IsDeletedEqual(bool value) {
			return new DirectSpecification<Cbo>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.PatientsAgg.Specifications {
	using Entities;
   public partial class PacienteSpecifications {
		public static Specification<Paciente> NomeContains(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Paciente> NomeStartsWith(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Paciente> NomeEqual(params string[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.Nome));
		}
		public static Specification<Paciente> NomeNotEqual(string value) {
			return new DirectSpecification<Paciente>(p => p.Nome != value);
		}
		public static Specification<Paciente> NomeIsNull() {
            return new DirectSpecification<Paciente>(p => p.Nome == null);
        }
		public static Specification<Paciente> NomeIsNotNull() {
            return new DirectSpecification<Paciente>(p => p.Nome != null);
        }
			public static Specification<Paciente> CpfContains(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.Cpf.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Paciente> CpfStartsWith(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.Cpf.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Paciente> CpfEqual(params string[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.Cpf));
		}
		public static Specification<Paciente> CpfNotEqual(string value) {
			return new DirectSpecification<Paciente>(p => p.Cpf != value);
		}
		public static Specification<Paciente> CpfIsNull() {
            return new DirectSpecification<Paciente>(p => p.Cpf == null);
        }
		public static Specification<Paciente> CpfIsNotNull() {
            return new DirectSpecification<Paciente>(p => p.Cpf != null);
        }
			public static Specification<Paciente> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Paciente> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.CreatedAt >= value);
        }
        public static Specification<Paciente> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.CreatedAt <= value);
        }
        public static Specification<Paciente> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.CreatedAt != value);
        }
        public static Specification<Paciente> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.CreatedAt > value);
        }
        public static Specification<Paciente> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.CreatedAt < value);
        }
			public static Specification<Paciente> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Paciente> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.UpdatedAt >= value);
        }
        public static Specification<Paciente> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.UpdatedAt <= value);
        }
        public static Specification<Paciente> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.UpdatedAt != value);
        }
        public static Specification<Paciente> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.UpdatedAt > value);
        }
        public static Specification<Paciente> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.UpdatedAt < value);
        }
			public static Specification<Paciente> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Paciente> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.DeletedAt >= value);
        }
        public static Specification<Paciente> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.DeletedAt <= value);
        }
        public static Specification<Paciente> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.DeletedAt != value);
        }
        public static Specification<Paciente> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.DeletedAt > value);
        }
        public static Specification<Paciente> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Paciente>(p => p.DeletedAt < value);
        }
			public static Specification<Paciente> IdEqual(params int[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.Id));
        }
        public static Specification<Paciente> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Paciente>(p => p.Id >= value);
        }
        public static Specification<Paciente> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Paciente>(p => p.Id <= value);
        }
        public static Specification<Paciente> IdNotEqual(int value) {
            return new DirectSpecification<Paciente>(p => p.Id != value);
        }
        public static Specification<Paciente> IdGreatThan(int value) {
            return new DirectSpecification<Paciente>(p => p.Id > value);
        }
        public static Specification<Paciente> IdLessThan(int value) {
            return new DirectSpecification<Paciente>(p => p.Id < value);
        }
			public static Specification<Paciente> ExternalIdContains(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Paciente> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Paciente> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Paciente> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Paciente>(p => p.ExternalId != value);
		}
		public static Specification<Paciente> ExternalIdIsNull() {
            return new DirectSpecification<Paciente>(p => p.ExternalId == null);
        }
		public static Specification<Paciente> ExternalIdIsNotNull() {
            return new DirectSpecification<Paciente>(p => p.ExternalId != null);
        }
			public static Specification<Paciente> IsDeletedEqual(bool value) {
			return new DirectSpecification<Paciente>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Specifications {
	using Entities;
   public partial class AgendaExameSpecifications {
		public static Specification<AgendaExame> DataInicioEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.DataInicio));
        }
        public static Specification<AgendaExame> DataInicioGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataInicio >= value);
        }
        public static Specification<AgendaExame> DataInicioLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataInicio <= value);
        }
        public static Specification<AgendaExame> DataInicioNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataInicio != value);
        }
        public static Specification<AgendaExame> DataInicioGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataInicio > value);
        }
        public static Specification<AgendaExame> DataInicioLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataInicio < value);
        }
			public static Specification<AgendaExame> DataFimEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.DataFim));
        }
        public static Specification<AgendaExame> DataFimGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataFim >= value);
        }
        public static Specification<AgendaExame> DataFimLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataFim <= value);
        }
        public static Specification<AgendaExame> DataFimNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataFim != value);
        }
        public static Specification<AgendaExame> DataFimGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataFim > value);
        }
        public static Specification<AgendaExame> DataFimLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DataFim < value);
        }
			public static Specification<AgendaExame> TempoAtendimentoEqual(params int[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.TempoAtendimento));
        }
        public static Specification<AgendaExame> TempoAtendimentoGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.TempoAtendimento >= value);
        }
        public static Specification<AgendaExame> TempoAtendimentoLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.TempoAtendimento <= value);
        }
        public static Specification<AgendaExame> TempoAtendimentoNotEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.TempoAtendimento != value);
        }
        public static Specification<AgendaExame> TempoAtendimentoGreatThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.TempoAtendimento > value);
        }
        public static Specification<AgendaExame> TempoAtendimentoLessThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.TempoAtendimento < value);
        }
			public static Specification<AgendaExame> TipoContains(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.Tipo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaExame> TipoStartsWith(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.Tipo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaExame> TipoEqual(params string[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.Tipo));
		}
		public static Specification<AgendaExame> TipoNotEqual(string value) {
			return new DirectSpecification<AgendaExame>(p => p.Tipo != value);
		}
		public static Specification<AgendaExame> TipoIsNull() {
            return new DirectSpecification<AgendaExame>(p => p.Tipo == null);
        }
		public static Specification<AgendaExame> TipoIsNotNull() {
            return new DirectSpecification<AgendaExame>(p => p.Tipo != null);
        }
			public static Specification<AgendaExame> ScheduleStatusContains(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.ScheduleStatus.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaExame> ScheduleStatusStartsWith(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.ScheduleStatus.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaExame> ScheduleStatusEqual(params string[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.ScheduleStatus));
		}
		public static Specification<AgendaExame> ScheduleStatusNotEqual(string value) {
			return new DirectSpecification<AgendaExame>(p => p.ScheduleStatus != value);
		}
		public static Specification<AgendaExame> ScheduleStatusIsNull() {
            return new DirectSpecification<AgendaExame>(p => p.ScheduleStatus == null);
        }
		public static Specification<AgendaExame> ScheduleStatusIsNotNull() {
            return new DirectSpecification<AgendaExame>(p => p.ScheduleStatus != null);
        }
			public static Specification<AgendaExame> QuantidadeAgendamentosEqual(params int[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.QuantidadeAgendamentos));
        }
        public static Specification<AgendaExame> QuantidadeAgendamentosGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeAgendamentos >= value);
        }
        public static Specification<AgendaExame> QuantidadeAgendamentosLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeAgendamentos <= value);
        }
        public static Specification<AgendaExame> QuantidadeAgendamentosNotEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeAgendamentos != value);
        }
        public static Specification<AgendaExame> QuantidadeAgendamentosGreatThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeAgendamentos > value);
        }
        public static Specification<AgendaExame> QuantidadeAgendamentosLessThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeAgendamentos < value);
        }
			public static Specification<AgendaExame> QuantidadeEncaixesEqual(params int[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.QuantidadeEncaixes));
        }
        public static Specification<AgendaExame> QuantidadeEncaixesGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeEncaixes >= value);
        }
        public static Specification<AgendaExame> QuantidadeEncaixesLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeEncaixes <= value);
        }
        public static Specification<AgendaExame> QuantidadeEncaixesNotEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeEncaixes != value);
        }
        public static Specification<AgendaExame> QuantidadeEncaixesGreatThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeEncaixes > value);
        }
        public static Specification<AgendaExame> QuantidadeEncaixesLessThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.QuantidadeEncaixes < value);
        }
			public static Specification<AgendaExame> AtivoEqual(bool value) {
			return new DirectSpecification<AgendaExame>(p => p.Ativo == value);
		}
		public static Specification<AgendaExame> AtivoIsNull() {
            return new DirectSpecification<AgendaExame>(p => p.Ativo == null);
        }
		public static Specification<AgendaExame> AtivoIsNotNull() {
            return new DirectSpecification<AgendaExame>(p => p.Ativo != null);
        }
			public static Specification<AgendaExame> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<AgendaExame> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.CreatedAt >= value);
        }
        public static Specification<AgendaExame> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.CreatedAt <= value);
        }
        public static Specification<AgendaExame> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.CreatedAt != value);
        }
        public static Specification<AgendaExame> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.CreatedAt > value);
        }
        public static Specification<AgendaExame> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.CreatedAt < value);
        }
			public static Specification<AgendaExame> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<AgendaExame> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.UpdatedAt >= value);
        }
        public static Specification<AgendaExame> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.UpdatedAt <= value);
        }
        public static Specification<AgendaExame> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.UpdatedAt != value);
        }
        public static Specification<AgendaExame> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.UpdatedAt > value);
        }
        public static Specification<AgendaExame> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.UpdatedAt < value);
        }
			public static Specification<AgendaExame> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<AgendaExame> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DeletedAt >= value);
        }
        public static Specification<AgendaExame> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DeletedAt <= value);
        }
        public static Specification<AgendaExame> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DeletedAt != value);
        }
        public static Specification<AgendaExame> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DeletedAt > value);
        }
        public static Specification<AgendaExame> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaExame>(p => p.DeletedAt < value);
        }
			public static Specification<AgendaExame> IdEqual(params int[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.Id));
        }
        public static Specification<AgendaExame> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.Id >= value);
        }
        public static Specification<AgendaExame> IdLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.Id <= value);
        }
        public static Specification<AgendaExame> IdNotEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.Id != value);
        }
        public static Specification<AgendaExame> IdGreatThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.Id > value);
        }
        public static Specification<AgendaExame> IdLessThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.Id < value);
        }
			public static Specification<AgendaExame> ExternalIdContains(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaExame> ExternalIdStartsWith(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaExame> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.ExternalId));
		}
		public static Specification<AgendaExame> ExternalIdNotEqual(string value) {
			return new DirectSpecification<AgendaExame>(p => p.ExternalId != value);
		}
		public static Specification<AgendaExame> ExternalIdIsNull() {
            return new DirectSpecification<AgendaExame>(p => p.ExternalId == null);
        }
		public static Specification<AgendaExame> ExternalIdIsNotNull() {
            return new DirectSpecification<AgendaExame>(p => p.ExternalId != null);
        }
			public static Specification<AgendaExame> IsDeletedEqual(bool value) {
			return new DirectSpecification<AgendaExame>(p => p.IsDeleted == value);
		}
	   }
   public partial class FeriadoSpecifications {
		public static Specification<Feriado> DescricaoContains(string value) {
			return new DirectSpecification<Feriado>(p => EF.Functions.Like(p.Descricao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Feriado> DescricaoStartsWith(string value) {
			return new DirectSpecification<Feriado>(p => EF.Functions.Like(p.Descricao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Feriado> DescricaoEqual(params string[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.Descricao));
		}
		public static Specification<Feriado> DescricaoNotEqual(string value) {
			return new DirectSpecification<Feriado>(p => p.Descricao != value);
		}
		public static Specification<Feriado> DescricaoIsNull() {
            return new DirectSpecification<Feriado>(p => p.Descricao == null);
        }
		public static Specification<Feriado> DescricaoIsNotNull() {
            return new DirectSpecification<Feriado>(p => p.Descricao != null);
        }
			public static Specification<Feriado> DataEqual(params System.DateOnly[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.Data));
        }
        public static Specification<Feriado> DataGreatThanOrEqual(System.DateOnly value) {
            return new DirectSpecification<Feriado>(p => p.Data >= value);
        }
        public static Specification<Feriado> DataLessThanOrEqual(System.DateOnly value) {
            return new DirectSpecification<Feriado>(p => p.Data <= value);
        }
        public static Specification<Feriado> DataNotEqual(System.DateOnly value) {
            return new DirectSpecification<Feriado>(p => p.Data != value);
        }
        public static Specification<Feriado> DataGreatThan(System.DateOnly value) {
            return new DirectSpecification<Feriado>(p => p.Data > value);
        }
        public static Specification<Feriado> DataLessThan(System.DateOnly value) {
            return new DirectSpecification<Feriado>(p => p.Data < value);
        }
			public static Specification<Feriado> TipoEqual(params Bravo.Schedulings.Enumerations.HolidayType[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.Tipo));
		}
		public static Specification<Feriado> TipoNotEqual(Bravo.Schedulings.Enumerations.HolidayType value) {
			return new DirectSpecification<Feriado>(p => p.Tipo != value);
		}
			public static Specification<Feriado> UserIdContains(string value) {
			return new DirectSpecification<Feriado>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Feriado> UserIdStartsWith(string value) {
			return new DirectSpecification<Feriado>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Feriado> UserIdEqual(params string[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.UserId));
		}
		public static Specification<Feriado> UserIdNotEqual(string value) {
			return new DirectSpecification<Feriado>(p => p.UserId != value);
		}
		public static Specification<Feriado> UserIdIsNull() {
            return new DirectSpecification<Feriado>(p => p.UserId == null);
        }
		public static Specification<Feriado> UserIdIsNotNull() {
            return new DirectSpecification<Feriado>(p => p.UserId != null);
        }
			public static Specification<Feriado> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.EmpresaId));
        }
        public static Specification<Feriado> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Feriado>(p => p.EmpresaId >= value);
        }
        public static Specification<Feriado> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<Feriado>(p => p.EmpresaId <= value);
        }
        public static Specification<Feriado> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<Feriado>(p => p.EmpresaId != value);
        }
        public static Specification<Feriado> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<Feriado>(p => p.EmpresaId > value);
        }
        public static Specification<Feriado> EmpresaIdLessThan(int value) {
            return new DirectSpecification<Feriado>(p => p.EmpresaId < value);
        }
			public static Specification<Feriado> AtivoEqual(bool value) {
			return new DirectSpecification<Feriado>(p => p.Ativo == value);
		}
		public static Specification<Feriado> AtivoIsNull() {
            return new DirectSpecification<Feriado>(p => p.Ativo == null);
        }
		public static Specification<Feriado> AtivoIsNotNull() {
            return new DirectSpecification<Feriado>(p => p.Ativo != null);
        }
			public static Specification<Feriado> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Feriado> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.CreatedAt >= value);
        }
        public static Specification<Feriado> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.CreatedAt <= value);
        }
        public static Specification<Feriado> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.CreatedAt != value);
        }
        public static Specification<Feriado> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.CreatedAt > value);
        }
        public static Specification<Feriado> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.CreatedAt < value);
        }
			public static Specification<Feriado> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Feriado> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.UpdatedAt >= value);
        }
        public static Specification<Feriado> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.UpdatedAt <= value);
        }
        public static Specification<Feriado> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.UpdatedAt != value);
        }
        public static Specification<Feriado> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.UpdatedAt > value);
        }
        public static Specification<Feriado> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.UpdatedAt < value);
        }
			public static Specification<Feriado> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Feriado> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.DeletedAt >= value);
        }
        public static Specification<Feriado> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.DeletedAt <= value);
        }
        public static Specification<Feriado> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.DeletedAt != value);
        }
        public static Specification<Feriado> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.DeletedAt > value);
        }
        public static Specification<Feriado> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Feriado>(p => p.DeletedAt < value);
        }
			public static Specification<Feriado> IdEqual(params int[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.Id));
        }
        public static Specification<Feriado> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Feriado>(p => p.Id >= value);
        }
        public static Specification<Feriado> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Feriado>(p => p.Id <= value);
        }
        public static Specification<Feriado> IdNotEqual(int value) {
            return new DirectSpecification<Feriado>(p => p.Id != value);
        }
        public static Specification<Feriado> IdGreatThan(int value) {
            return new DirectSpecification<Feriado>(p => p.Id > value);
        }
        public static Specification<Feriado> IdLessThan(int value) {
            return new DirectSpecification<Feriado>(p => p.Id < value);
        }
			public static Specification<Feriado> ExternalIdContains(string value) {
			return new DirectSpecification<Feriado>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Feriado> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Feriado>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Feriado> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Feriado> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Feriado>(p => p.ExternalId != value);
		}
		public static Specification<Feriado> ExternalIdIsNull() {
            return new DirectSpecification<Feriado>(p => p.ExternalId == null);
        }
		public static Specification<Feriado> ExternalIdIsNotNull() {
            return new DirectSpecification<Feriado>(p => p.ExternalId != null);
        }
			public static Specification<Feriado> IsDeletedEqual(bool value) {
			return new DirectSpecification<Feriado>(p => p.IsDeleted == value);
		}
	   }
   public partial class AgendaProfissionalSpecifications {
		public static Specification<AgendaProfissional> NomeProfissionalContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.NomeProfissional.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> NomeProfissionalStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.NomeProfissional.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> NomeProfissionalEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.NomeProfissional));
		}
		public static Specification<AgendaProfissional> NomeProfissionalNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.NomeProfissional != value);
		}
		public static Specification<AgendaProfissional> NomeProfissionalIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.NomeProfissional == null);
        }
		public static Specification<AgendaProfissional> NomeProfissionalIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.NomeProfissional != null);
        }
			public static Specification<AgendaProfissional> ConselhoContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.Conselho.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> ConselhoStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.Conselho.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> ConselhoEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.Conselho));
		}
		public static Specification<AgendaProfissional> ConselhoNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.Conselho != value);
		}
		public static Specification<AgendaProfissional> ConselhoIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.Conselho == null);
        }
		public static Specification<AgendaProfissional> ConselhoIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.Conselho != null);
        }
			public static Specification<AgendaProfissional> CBOProfissionalContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.CBOProfissional.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> CBOProfissionalStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.CBOProfissional.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> CBOProfissionalEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.CBOProfissional));
		}
		public static Specification<AgendaProfissional> CBOProfissionalNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.CBOProfissional != value);
		}
		public static Specification<AgendaProfissional> CBOProfissionalIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.CBOProfissional == null);
        }
		public static Specification<AgendaProfissional> CBOProfissionalIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.CBOProfissional != null);
        }
			public static Specification<AgendaProfissional> DuracaoConsultaContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.DuracaoConsulta.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> DuracaoConsultaStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.DuracaoConsulta.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> DuracaoConsultaEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.DuracaoConsulta));
		}
		public static Specification<AgendaProfissional> DuracaoConsultaNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.DuracaoConsulta != value);
		}
		public static Specification<AgendaProfissional> DuracaoConsultaIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.DuracaoConsulta == null);
        }
		public static Specification<AgendaProfissional> DuracaoConsultaIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.DuracaoConsulta != null);
        }
			public static Specification<AgendaProfissional> CotaAtendimentoContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.CotaAtendimento.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> CotaAtendimentoStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.CotaAtendimento.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> CotaAtendimentoEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.CotaAtendimento));
		}
		public static Specification<AgendaProfissional> CotaAtendimentoNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.CotaAtendimento != value);
		}
		public static Specification<AgendaProfissional> CotaAtendimentoIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.CotaAtendimento == null);
        }
		public static Specification<AgendaProfissional> CotaAtendimentoIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.CotaAtendimento != null);
        }
			public static Specification<AgendaProfissional> DataInicioEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.DataInicio));
        }
        public static Specification<AgendaProfissional> DataInicioGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataInicio >= value);
        }
        public static Specification<AgendaProfissional> DataInicioLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataInicio <= value);
        }
        public static Specification<AgendaProfissional> DataInicioNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataInicio != value);
        }
        public static Specification<AgendaProfissional> DataInicioGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataInicio > value);
        }
        public static Specification<AgendaProfissional> DataInicioLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataInicio < value);
        }
			public static Specification<AgendaProfissional> DataFimEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.DataFim));
        }
        public static Specification<AgendaProfissional> DataFimGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataFim >= value);
        }
        public static Specification<AgendaProfissional> DataFimLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataFim <= value);
        }
        public static Specification<AgendaProfissional> DataFimNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataFim != value);
        }
        public static Specification<AgendaProfissional> DataFimGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataFim > value);
        }
        public static Specification<AgendaProfissional> DataFimLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DataFim < value);
        }
			public static Specification<AgendaProfissional> TempoAtendimentoEqual(params int[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.TempoAtendimento));
        }
        public static Specification<AgendaProfissional> TempoAtendimentoGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.TempoAtendimento >= value);
        }
        public static Specification<AgendaProfissional> TempoAtendimentoLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.TempoAtendimento <= value);
        }
        public static Specification<AgendaProfissional> TempoAtendimentoNotEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.TempoAtendimento != value);
        }
        public static Specification<AgendaProfissional> TempoAtendimentoGreatThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.TempoAtendimento > value);
        }
        public static Specification<AgendaProfissional> TempoAtendimentoLessThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.TempoAtendimento < value);
        }
			public static Specification<AgendaProfissional> TipoContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.Tipo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> TipoStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.Tipo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> TipoEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.Tipo));
		}
		public static Specification<AgendaProfissional> TipoNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.Tipo != value);
		}
		public static Specification<AgendaProfissional> TipoIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.Tipo == null);
        }
		public static Specification<AgendaProfissional> TipoIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.Tipo != null);
        }
			public static Specification<AgendaProfissional> ScheduleStatusContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.ScheduleStatus.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> ScheduleStatusStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.ScheduleStatus.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> ScheduleStatusEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.ScheduleStatus));
		}
		public static Specification<AgendaProfissional> ScheduleStatusNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.ScheduleStatus != value);
		}
		public static Specification<AgendaProfissional> ScheduleStatusIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.ScheduleStatus == null);
        }
		public static Specification<AgendaProfissional> ScheduleStatusIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.ScheduleStatus != null);
        }
			public static Specification<AgendaProfissional> QuantidadeAgendamentosEqual(params int[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.QuantidadeAgendamentos));
        }
        public static Specification<AgendaProfissional> QuantidadeAgendamentosGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeAgendamentos >= value);
        }
        public static Specification<AgendaProfissional> QuantidadeAgendamentosLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeAgendamentos <= value);
        }
        public static Specification<AgendaProfissional> QuantidadeAgendamentosNotEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeAgendamentos != value);
        }
        public static Specification<AgendaProfissional> QuantidadeAgendamentosGreatThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeAgendamentos > value);
        }
        public static Specification<AgendaProfissional> QuantidadeAgendamentosLessThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeAgendamentos < value);
        }
			public static Specification<AgendaProfissional> QuantidadeEncaixesEqual(params int[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.QuantidadeEncaixes));
        }
        public static Specification<AgendaProfissional> QuantidadeEncaixesGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeEncaixes >= value);
        }
        public static Specification<AgendaProfissional> QuantidadeEncaixesLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeEncaixes <= value);
        }
        public static Specification<AgendaProfissional> QuantidadeEncaixesNotEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeEncaixes != value);
        }
        public static Specification<AgendaProfissional> QuantidadeEncaixesGreatThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeEncaixes > value);
        }
        public static Specification<AgendaProfissional> QuantidadeEncaixesLessThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.QuantidadeEncaixes < value);
        }
			public static Specification<AgendaProfissional> AtivoEqual(bool value) {
			return new DirectSpecification<AgendaProfissional>(p => p.Ativo == value);
		}
		public static Specification<AgendaProfissional> AtivoIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.Ativo == null);
        }
		public static Specification<AgendaProfissional> AtivoIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.Ativo != null);
        }
			public static Specification<AgendaProfissional> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<AgendaProfissional> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.CreatedAt >= value);
        }
        public static Specification<AgendaProfissional> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.CreatedAt <= value);
        }
        public static Specification<AgendaProfissional> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.CreatedAt != value);
        }
        public static Specification<AgendaProfissional> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.CreatedAt > value);
        }
        public static Specification<AgendaProfissional> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.CreatedAt < value);
        }
			public static Specification<AgendaProfissional> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<AgendaProfissional> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.UpdatedAt >= value);
        }
        public static Specification<AgendaProfissional> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.UpdatedAt <= value);
        }
        public static Specification<AgendaProfissional> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.UpdatedAt != value);
        }
        public static Specification<AgendaProfissional> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.UpdatedAt > value);
        }
        public static Specification<AgendaProfissional> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.UpdatedAt < value);
        }
			public static Specification<AgendaProfissional> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<AgendaProfissional> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DeletedAt >= value);
        }
        public static Specification<AgendaProfissional> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DeletedAt <= value);
        }
        public static Specification<AgendaProfissional> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DeletedAt != value);
        }
        public static Specification<AgendaProfissional> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DeletedAt > value);
        }
        public static Specification<AgendaProfissional> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaProfissional>(p => p.DeletedAt < value);
        }
			public static Specification<AgendaProfissional> IdEqual(params int[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.Id));
        }
        public static Specification<AgendaProfissional> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.Id >= value);
        }
        public static Specification<AgendaProfissional> IdLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.Id <= value);
        }
        public static Specification<AgendaProfissional> IdNotEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.Id != value);
        }
        public static Specification<AgendaProfissional> IdGreatThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.Id > value);
        }
        public static Specification<AgendaProfissional> IdLessThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.Id < value);
        }
			public static Specification<AgendaProfissional> ExternalIdContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> ExternalIdStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.ExternalId));
		}
		public static Specification<AgendaProfissional> ExternalIdNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.ExternalId != value);
		}
		public static Specification<AgendaProfissional> ExternalIdIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.ExternalId == null);
        }
		public static Specification<AgendaProfissional> ExternalIdIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.ExternalId != null);
        }
			public static Specification<AgendaProfissional> IsDeletedEqual(bool value) {
			return new DirectSpecification<AgendaProfissional>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Specifications {
	using Entities;
   public partial class ConvenioSpecifications {
		public static Specification<Convenio> NomeContains(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Convenio> NomeStartsWith(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Convenio> NomeEqual(params string[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.Nome));
		}
		public static Specification<Convenio> NomeNotEqual(string value) {
			return new DirectSpecification<Convenio>(p => p.Nome != value);
		}
		public static Specification<Convenio> NomeIsNull() {
            return new DirectSpecification<Convenio>(p => p.Nome == null);
        }
		public static Specification<Convenio> NomeIsNotNull() {
            return new DirectSpecification<Convenio>(p => p.Nome != null);
        }
			public static Specification<Convenio> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Convenio> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.CreatedAt >= value);
        }
        public static Specification<Convenio> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.CreatedAt <= value);
        }
        public static Specification<Convenio> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.CreatedAt != value);
        }
        public static Specification<Convenio> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.CreatedAt > value);
        }
        public static Specification<Convenio> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.CreatedAt < value);
        }
			public static Specification<Convenio> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Convenio> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.UpdatedAt >= value);
        }
        public static Specification<Convenio> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.UpdatedAt <= value);
        }
        public static Specification<Convenio> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.UpdatedAt != value);
        }
        public static Specification<Convenio> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.UpdatedAt > value);
        }
        public static Specification<Convenio> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.UpdatedAt < value);
        }
			public static Specification<Convenio> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Convenio> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.DeletedAt >= value);
        }
        public static Specification<Convenio> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.DeletedAt <= value);
        }
        public static Specification<Convenio> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.DeletedAt != value);
        }
        public static Specification<Convenio> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.DeletedAt > value);
        }
        public static Specification<Convenio> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Convenio>(p => p.DeletedAt < value);
        }
			public static Specification<Convenio> IdEqual(params int[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.Id));
        }
        public static Specification<Convenio> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Convenio>(p => p.Id >= value);
        }
        public static Specification<Convenio> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Convenio>(p => p.Id <= value);
        }
        public static Specification<Convenio> IdNotEqual(int value) {
            return new DirectSpecification<Convenio>(p => p.Id != value);
        }
        public static Specification<Convenio> IdGreatThan(int value) {
            return new DirectSpecification<Convenio>(p => p.Id > value);
        }
        public static Specification<Convenio> IdLessThan(int value) {
            return new DirectSpecification<Convenio>(p => p.Id < value);
        }
			public static Specification<Convenio> ExternalIdContains(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Convenio> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Convenio> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Convenio> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Convenio>(p => p.ExternalId != value);
		}
		public static Specification<Convenio> ExternalIdIsNull() {
            return new DirectSpecification<Convenio>(p => p.ExternalId == null);
        }
		public static Specification<Convenio> ExternalIdIsNotNull() {
            return new DirectSpecification<Convenio>(p => p.ExternalId != null);
        }
			public static Specification<Convenio> IsDeletedEqual(bool value) {
			return new DirectSpecification<Convenio>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Specifications {
	using Entities;
   public partial class ProcedimentoSpecifications {
		public static Specification<Procedimento> CodigoProcedimentoEqual(params int[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.CodigoProcedimento));
        }
        public static Specification<Procedimento> CodigoProcedimentoGreatThanOrEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.CodigoProcedimento >= value);
        }
        public static Specification<Procedimento> CodigoProcedimentoLessThanOrEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.CodigoProcedimento <= value);
        }
        public static Specification<Procedimento> CodigoProcedimentoNotEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.CodigoProcedimento != value);
        }
        public static Specification<Procedimento> CodigoProcedimentoGreatThan(int value) {
            return new DirectSpecification<Procedimento>(p => p.CodigoProcedimento > value);
        }
        public static Specification<Procedimento> CodigoProcedimentoLessThan(int value) {
            return new DirectSpecification<Procedimento>(p => p.CodigoProcedimento < value);
        }
			public static Specification<Procedimento> DescricaoEqual(params int[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.Descricao));
        }
        public static Specification<Procedimento> DescricaoGreatThanOrEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.Descricao >= value);
        }
        public static Specification<Procedimento> DescricaoLessThanOrEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.Descricao <= value);
        }
        public static Specification<Procedimento> DescricaoNotEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.Descricao != value);
        }
        public static Specification<Procedimento> DescricaoGreatThan(int value) {
            return new DirectSpecification<Procedimento>(p => p.Descricao > value);
        }
        public static Specification<Procedimento> DescricaoLessThan(int value) {
            return new DirectSpecification<Procedimento>(p => p.Descricao < value);
        }
			public static Specification<Procedimento> OrientacaoContains(string value) {
			return new DirectSpecification<Procedimento>(p => EF.Functions.Like(p.Orientacao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Procedimento> OrientacaoStartsWith(string value) {
			return new DirectSpecification<Procedimento>(p => EF.Functions.Like(p.Orientacao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Procedimento> OrientacaoEqual(params string[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.Orientacao));
		}
		public static Specification<Procedimento> OrientacaoNotEqual(string value) {
			return new DirectSpecification<Procedimento>(p => p.Orientacao != value);
		}
		public static Specification<Procedimento> OrientacaoIsNull() {
            return new DirectSpecification<Procedimento>(p => p.Orientacao == null);
        }
		public static Specification<Procedimento> OrientacaoIsNotNull() {
            return new DirectSpecification<Procedimento>(p => p.Orientacao != null);
        }
			public static Specification<Procedimento> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Procedimento> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.CreatedAt >= value);
        }
        public static Specification<Procedimento> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.CreatedAt <= value);
        }
        public static Specification<Procedimento> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.CreatedAt != value);
        }
        public static Specification<Procedimento> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.CreatedAt > value);
        }
        public static Specification<Procedimento> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.CreatedAt < value);
        }
			public static Specification<Procedimento> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Procedimento> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.UpdatedAt >= value);
        }
        public static Specification<Procedimento> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.UpdatedAt <= value);
        }
        public static Specification<Procedimento> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.UpdatedAt != value);
        }
        public static Specification<Procedimento> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.UpdatedAt > value);
        }
        public static Specification<Procedimento> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.UpdatedAt < value);
        }
			public static Specification<Procedimento> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Procedimento> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.DeletedAt >= value);
        }
        public static Specification<Procedimento> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.DeletedAt <= value);
        }
        public static Specification<Procedimento> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.DeletedAt != value);
        }
        public static Specification<Procedimento> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.DeletedAt > value);
        }
        public static Specification<Procedimento> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Procedimento>(p => p.DeletedAt < value);
        }
			public static Specification<Procedimento> IdEqual(params int[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.Id));
        }
        public static Specification<Procedimento> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.Id >= value);
        }
        public static Specification<Procedimento> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.Id <= value);
        }
        public static Specification<Procedimento> IdNotEqual(int value) {
            return new DirectSpecification<Procedimento>(p => p.Id != value);
        }
        public static Specification<Procedimento> IdGreatThan(int value) {
            return new DirectSpecification<Procedimento>(p => p.Id > value);
        }
        public static Specification<Procedimento> IdLessThan(int value) {
            return new DirectSpecification<Procedimento>(p => p.Id < value);
        }
			public static Specification<Procedimento> ExternalIdContains(string value) {
			return new DirectSpecification<Procedimento>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Procedimento> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Procedimento>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Procedimento> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Procedimento>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Procedimento> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Procedimento>(p => p.ExternalId != value);
		}
		public static Specification<Procedimento> ExternalIdIsNull() {
            return new DirectSpecification<Procedimento>(p => p.ExternalId == null);
        }
		public static Specification<Procedimento> ExternalIdIsNotNull() {
            return new DirectSpecification<Procedimento>(p => p.ExternalId != null);
        }
			public static Specification<Procedimento> IsDeletedEqual(bool value) {
			return new DirectSpecification<Procedimento>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.UsersAgg.Specifications {
	using Entities;
   public partial class UserSpecifications {
		public static Specification<User> UserNameContains(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.UserName.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<User> UserNameStartsWith(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.UserName.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<User> UserNameEqual(params string[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.UserName));
		}
		public static Specification<User> UserNameNotEqual(string value) {
			return new DirectSpecification<User>(p => p.UserName != value);
		}
		public static Specification<User> UserNameIsNull() {
            return new DirectSpecification<User>(p => p.UserName == null);
        }
		public static Specification<User> UserNameIsNotNull() {
            return new DirectSpecification<User>(p => p.UserName != null);
        }
			public static Specification<User> NameContains(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.Name.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<User> NameStartsWith(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.Name.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<User> NameEqual(params string[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.Name));
		}
		public static Specification<User> NameNotEqual(string value) {
			return new DirectSpecification<User>(p => p.Name != value);
		}
		public static Specification<User> NameIsNull() {
            return new DirectSpecification<User>(p => p.Name == null);
        }
		public static Specification<User> NameIsNotNull() {
            return new DirectSpecification<User>(p => p.Name != null);
        }
			public static Specification<User> EmailContains(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.Email.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<User> EmailStartsWith(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.Email.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<User> EmailEqual(params string[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.Email));
		}
		public static Specification<User> EmailNotEqual(string value) {
			return new DirectSpecification<User>(p => p.Email != value);
		}
		public static Specification<User> EmailIsNull() {
            return new DirectSpecification<User>(p => p.Email == null);
        }
		public static Specification<User> EmailIsNotNull() {
            return new DirectSpecification<User>(p => p.Email != null);
        }
			public static Specification<User> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.EmpresaId.Value));
        }
        public static Specification<User> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<User>(p => p.EmpresaId >= value);
        }
        public static Specification<User> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<User>(p => p.EmpresaId <= value);
        }
        public static Specification<User> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<User>(p => p.EmpresaId != value);
        }
        public static Specification<User> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<User>(p => p.EmpresaId > value);
        }
        public static Specification<User> EmpresaIdLessThan(int value) {
            return new DirectSpecification<User>(p => p.EmpresaId < value);
        }
				public static Specification<User> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<User> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.CreatedAt >= value);
        }
        public static Specification<User> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.CreatedAt <= value);
        }
        public static Specification<User> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.CreatedAt != value);
        }
        public static Specification<User> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<User>(p => p.CreatedAt > value);
        }
        public static Specification<User> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<User>(p => p.CreatedAt < value);
        }
			public static Specification<User> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<User> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.UpdatedAt >= value);
        }
        public static Specification<User> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.UpdatedAt <= value);
        }
        public static Specification<User> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.UpdatedAt != value);
        }
        public static Specification<User> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<User>(p => p.UpdatedAt > value);
        }
        public static Specification<User> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<User>(p => p.UpdatedAt < value);
        }
			public static Specification<User> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<User> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.DeletedAt >= value);
        }
        public static Specification<User> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.DeletedAt <= value);
        }
        public static Specification<User> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<User>(p => p.DeletedAt != value);
        }
        public static Specification<User> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<User>(p => p.DeletedAt > value);
        }
        public static Specification<User> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<User>(p => p.DeletedAt < value);
        }
			public static Specification<User> IdContains(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.Id.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<User> IdStartsWith(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.Id.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<User> IdEqual(params string[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.Id));
		}
		public static Specification<User> IdNotEqual(string value) {
			return new DirectSpecification<User>(p => p.Id != value);
		}
		public static Specification<User> IdIsNull() {
            return new DirectSpecification<User>(p => p.Id == null);
        }
		public static Specification<User> IdIsNotNull() {
            return new DirectSpecification<User>(p => p.Id != null);
        }
			public static Specification<User> ExternalIdContains(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<User> ExternalIdStartsWith(string value) {
			return new DirectSpecification<User>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<User> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<User>(p => values.Contains(p.ExternalId));
		}
		public static Specification<User> ExternalIdNotEqual(string value) {
			return new DirectSpecification<User>(p => p.ExternalId != value);
		}
		public static Specification<User> ExternalIdIsNull() {
            return new DirectSpecification<User>(p => p.ExternalId == null);
        }
		public static Specification<User> ExternalIdIsNotNull() {
            return new DirectSpecification<User>(p => p.ExternalId != null);
        }
			public static Specification<User> IsDeletedEqual(bool value) {
			return new DirectSpecification<User>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.PartnersAgg.Specifications {
	using Entities;
   public partial class FornecedorSpecifications {
			public static Specification<Fornecedor> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Fornecedor> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.CreatedAt >= value);
        }
        public static Specification<Fornecedor> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.CreatedAt <= value);
        }
        public static Specification<Fornecedor> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.CreatedAt != value);
        }
        public static Specification<Fornecedor> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.CreatedAt > value);
        }
        public static Specification<Fornecedor> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.CreatedAt < value);
        }
			public static Specification<Fornecedor> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Fornecedor> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.UpdatedAt >= value);
        }
        public static Specification<Fornecedor> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.UpdatedAt <= value);
        }
        public static Specification<Fornecedor> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.UpdatedAt != value);
        }
        public static Specification<Fornecedor> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.UpdatedAt > value);
        }
        public static Specification<Fornecedor> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.UpdatedAt < value);
        }
			public static Specification<Fornecedor> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Fornecedor> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.DeletedAt >= value);
        }
        public static Specification<Fornecedor> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.DeletedAt <= value);
        }
        public static Specification<Fornecedor> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.DeletedAt != value);
        }
        public static Specification<Fornecedor> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.DeletedAt > value);
        }
        public static Specification<Fornecedor> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Fornecedor>(p => p.DeletedAt < value);
        }
			public static Specification<Fornecedor> IdEqual(params int[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.Id));
        }
        public static Specification<Fornecedor> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Id >= value);
        }
        public static Specification<Fornecedor> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Id <= value);
        }
        public static Specification<Fornecedor> IdNotEqual(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Id != value);
        }
        public static Specification<Fornecedor> IdGreatThan(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Id > value);
        }
        public static Specification<Fornecedor> IdLessThan(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Id < value);
        }
			public static Specification<Fornecedor> ExternalIdContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Fornecedor> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.ExternalId != value);
		}
		public static Specification<Fornecedor> ExternalIdIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.ExternalId == null);
        }
		public static Specification<Fornecedor> ExternalIdIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.ExternalId != null);
        }
			public static Specification<Fornecedor> IsDeletedEqual(bool value) {
			return new DirectSpecification<Fornecedor>(p => p.IsDeleted == value);
		}
	   }
   public partial class PublicitarioSpecifications {
			public static Specification<Publicitario> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Publicitario> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.CreatedAt >= value);
        }
        public static Specification<Publicitario> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.CreatedAt <= value);
        }
        public static Specification<Publicitario> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.CreatedAt != value);
        }
        public static Specification<Publicitario> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.CreatedAt > value);
        }
        public static Specification<Publicitario> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.CreatedAt < value);
        }
			public static Specification<Publicitario> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Publicitario> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.UpdatedAt >= value);
        }
        public static Specification<Publicitario> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.UpdatedAt <= value);
        }
        public static Specification<Publicitario> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.UpdatedAt != value);
        }
        public static Specification<Publicitario> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.UpdatedAt > value);
        }
        public static Specification<Publicitario> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.UpdatedAt < value);
        }
			public static Specification<Publicitario> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Publicitario> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.DeletedAt >= value);
        }
        public static Specification<Publicitario> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.DeletedAt <= value);
        }
        public static Specification<Publicitario> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.DeletedAt != value);
        }
        public static Specification<Publicitario> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.DeletedAt > value);
        }
        public static Specification<Publicitario> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Publicitario>(p => p.DeletedAt < value);
        }
			public static Specification<Publicitario> IdEqual(params int[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.Id));
        }
        public static Specification<Publicitario> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.Id >= value);
        }
        public static Specification<Publicitario> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.Id <= value);
        }
        public static Specification<Publicitario> IdNotEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.Id != value);
        }
        public static Specification<Publicitario> IdGreatThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.Id > value);
        }
        public static Specification<Publicitario> IdLessThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.Id < value);
        }
			public static Specification<Publicitario> ExternalIdContains(string value) {
			return new DirectSpecification<Publicitario>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Publicitario> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Publicitario>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Publicitario> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Publicitario> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Publicitario>(p => p.ExternalId != value);
		}
		public static Specification<Publicitario> ExternalIdIsNull() {
            return new DirectSpecification<Publicitario>(p => p.ExternalId == null);
        }
		public static Specification<Publicitario> ExternalIdIsNotNull() {
            return new DirectSpecification<Publicitario>(p => p.ExternalId != null);
        }
			public static Specification<Publicitario> IsDeletedEqual(bool value) {
			return new DirectSpecification<Publicitario>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.Specifications {
	using Entities;
   public partial class EnderecoSpecifications {
		public static Specification<Endereco> CEPContains(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.CEP.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Endereco> CEPStartsWith(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.CEP.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Endereco> CEPEqual(params string[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.CEP));
		}
		public static Specification<Endereco> CEPNotEqual(string value) {
			return new DirectSpecification<Endereco>(p => p.CEP != value);
		}
		public static Specification<Endereco> CEPIsNull() {
            return new DirectSpecification<Endereco>(p => p.CEP == null);
        }
		public static Specification<Endereco> CEPIsNotNull() {
            return new DirectSpecification<Endereco>(p => p.CEP != null);
        }
			public static Specification<Endereco> LogradouroContains(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.Logradouro.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Endereco> LogradouroStartsWith(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.Logradouro.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Endereco> LogradouroEqual(params string[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.Logradouro));
		}
		public static Specification<Endereco> LogradouroNotEqual(string value) {
			return new DirectSpecification<Endereco>(p => p.Logradouro != value);
		}
		public static Specification<Endereco> LogradouroIsNull() {
            return new DirectSpecification<Endereco>(p => p.Logradouro == null);
        }
		public static Specification<Endereco> LogradouroIsNotNull() {
            return new DirectSpecification<Endereco>(p => p.Logradouro != null);
        }
			public static Specification<Endereco> Bairro_DistritoContains(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.Bairro_Distrito.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Endereco> Bairro_DistritoStartsWith(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.Bairro_Distrito.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Endereco> Bairro_DistritoEqual(params string[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.Bairro_Distrito));
		}
		public static Specification<Endereco> Bairro_DistritoNotEqual(string value) {
			return new DirectSpecification<Endereco>(p => p.Bairro_Distrito != value);
		}
		public static Specification<Endereco> Bairro_DistritoIsNull() {
            return new DirectSpecification<Endereco>(p => p.Bairro_Distrito == null);
        }
		public static Specification<Endereco> Bairro_DistritoIsNotNull() {
            return new DirectSpecification<Endereco>(p => p.Bairro_Distrito != null);
        }
			public static Specification<Endereco> Cidade_LocalidadeContains(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.Cidade_Localidade.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Endereco> Cidade_LocalidadeStartsWith(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.Cidade_Localidade.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Endereco> Cidade_LocalidadeEqual(params string[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.Cidade_Localidade));
		}
		public static Specification<Endereco> Cidade_LocalidadeNotEqual(string value) {
			return new DirectSpecification<Endereco>(p => p.Cidade_Localidade != value);
		}
		public static Specification<Endereco> Cidade_LocalidadeIsNull() {
            return new DirectSpecification<Endereco>(p => p.Cidade_Localidade == null);
        }
		public static Specification<Endereco> Cidade_LocalidadeIsNotNull() {
            return new DirectSpecification<Endereco>(p => p.Cidade_Localidade != null);
        }
			public static Specification<Endereco> UFContains(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.UF.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Endereco> UFStartsWith(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.UF.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Endereco> UFEqual(params string[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.UF));
		}
		public static Specification<Endereco> UFNotEqual(string value) {
			return new DirectSpecification<Endereco>(p => p.UF != value);
		}
		public static Specification<Endereco> UFIsNull() {
            return new DirectSpecification<Endereco>(p => p.UF == null);
        }
		public static Specification<Endereco> UFIsNotNull() {
            return new DirectSpecification<Endereco>(p => p.UF != null);
        }
			public static Specification<Endereco> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Endereco> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.CreatedAt >= value);
        }
        public static Specification<Endereco> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.CreatedAt <= value);
        }
        public static Specification<Endereco> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.CreatedAt != value);
        }
        public static Specification<Endereco> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.CreatedAt > value);
        }
        public static Specification<Endereco> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.CreatedAt < value);
        }
			public static Specification<Endereco> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Endereco> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.UpdatedAt >= value);
        }
        public static Specification<Endereco> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.UpdatedAt <= value);
        }
        public static Specification<Endereco> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.UpdatedAt != value);
        }
        public static Specification<Endereco> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.UpdatedAt > value);
        }
        public static Specification<Endereco> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.UpdatedAt < value);
        }
			public static Specification<Endereco> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Endereco> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.DeletedAt >= value);
        }
        public static Specification<Endereco> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.DeletedAt <= value);
        }
        public static Specification<Endereco> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.DeletedAt != value);
        }
        public static Specification<Endereco> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.DeletedAt > value);
        }
        public static Specification<Endereco> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Endereco>(p => p.DeletedAt < value);
        }
			public static Specification<Endereco> IdEqual(params int[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.Id));
        }
        public static Specification<Endereco> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<Endereco>(p => p.Id >= value);
        }
        public static Specification<Endereco> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Endereco>(p => p.Id <= value);
        }
        public static Specification<Endereco> IdNotEqual(int value) {
            return new DirectSpecification<Endereco>(p => p.Id != value);
        }
        public static Specification<Endereco> IdGreatThan(int value) {
            return new DirectSpecification<Endereco>(p => p.Id > value);
        }
        public static Specification<Endereco> IdLessThan(int value) {
            return new DirectSpecification<Endereco>(p => p.Id < value);
        }
			public static Specification<Endereco> ExternalIdContains(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Endereco> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Endereco> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.ExternalId));
		}
		public static Specification<Endereco> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Endereco>(p => p.ExternalId != value);
		}
		public static Specification<Endereco> ExternalIdIsNull() {
            return new DirectSpecification<Endereco>(p => p.ExternalId == null);
        }
		public static Specification<Endereco> ExternalIdIsNotNull() {
            return new DirectSpecification<Endereco>(p => p.ExternalId != null);
        }
			public static Specification<Endereco> IsDeletedEqual(bool value) {
			return new DirectSpecification<Endereco>(p => p.IsDeleted == value);
		}
	   }
}
