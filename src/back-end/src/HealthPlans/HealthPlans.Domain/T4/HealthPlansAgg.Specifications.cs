using Bravo.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Specifications {
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
				public static Specification<Convenio> MatriculaContains(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.Matricula.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Convenio> MatriculaStartsWith(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.Matricula.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Convenio> MatriculaEqual(params string[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.Matricula));
		}
		public static Specification<Convenio> MatriculaNotEqual(string value) {
			return new DirectSpecification<Convenio>(p => p.Matricula != value);
		}
		public static Specification<Convenio> MatriculaIsNull() {
            return new DirectSpecification<Convenio>(p => p.Matricula == null);
        }
		public static Specification<Convenio> MatriculaIsNotNull() {
            return new DirectSpecification<Convenio>(p => p.Matricula != null);
        }
			public static Specification<Convenio> CodigoContains(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.Codigo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Convenio> CodigoStartsWith(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.Codigo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Convenio> CodigoEqual(params string[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.Codigo));
		}
		public static Specification<Convenio> CodigoNotEqual(string value) {
			return new DirectSpecification<Convenio>(p => p.Codigo != value);
		}
		public static Specification<Convenio> CodigoIsNull() {
            return new DirectSpecification<Convenio>(p => p.Codigo == null);
        }
		public static Specification<Convenio> CodigoIsNotNull() {
            return new DirectSpecification<Convenio>(p => p.Codigo != null);
        }
			public static Specification<Convenio> RegistroANSContains(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.RegistroANS.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Convenio> RegistroANSStartsWith(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.RegistroANS.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Convenio> RegistroANSEqual(params string[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.RegistroANS));
		}
		public static Specification<Convenio> RegistroANSNotEqual(string value) {
			return new DirectSpecification<Convenio>(p => p.RegistroANS != value);
		}
		public static Specification<Convenio> RegistroANSIsNull() {
            return new DirectSpecification<Convenio>(p => p.RegistroANS == null);
        }
		public static Specification<Convenio> RegistroANSIsNotNull() {
            return new DirectSpecification<Convenio>(p => p.RegistroANS != null);
        }
			public static Specification<Convenio> CodigoReferenciaContains(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.CodigoReferencia.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Convenio> CodigoReferenciaStartsWith(string value) {
			return new DirectSpecification<Convenio>(p => EF.Functions.Like(p.CodigoReferencia.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Convenio> CodigoReferenciaEqual(params string[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.CodigoReferencia));
		}
		public static Specification<Convenio> CodigoReferenciaNotEqual(string value) {
			return new DirectSpecification<Convenio>(p => p.CodigoReferencia != value);
		}
		public static Specification<Convenio> CodigoReferenciaIsNull() {
            return new DirectSpecification<Convenio>(p => p.CodigoReferencia == null);
        }
		public static Specification<Convenio> CodigoReferenciaIsNotNull() {
            return new DirectSpecification<Convenio>(p => p.CodigoReferencia != null);
        }
			public static Specification<Convenio> PadronizarQuantidadeDigitosEqual(bool value) {
			return new DirectSpecification<Convenio>(p => p.PadronizarQuantidadeDigitos == value);
		}
			public static Specification<Convenio> QuantidadeDigitosEqual(params int[] values) {
			return new DirectSpecification<Convenio>(p => values.Contains(p.QuantidadeDigitos.Value));
        }
        public static Specification<Convenio> QuantidadeDigitosGreatThanOrEqual(int value) {
            return new DirectSpecification<Convenio>(p => p.QuantidadeDigitos >= value);
        }
        public static Specification<Convenio> QuantidadeDigitosLessThanOrEqual(int value) {
            return new DirectSpecification<Convenio>(p => p.QuantidadeDigitos <= value);
        }
        public static Specification<Convenio> QuantidadeDigitosNotEqual(int value) {
            return new DirectSpecification<Convenio>(p => p.QuantidadeDigitos != value);
        }
        public static Specification<Convenio> QuantidadeDigitosGreatThan(int value) {
            return new DirectSpecification<Convenio>(p => p.QuantidadeDigitos > value);
        }
        public static Specification<Convenio> QuantidadeDigitosLessThan(int value) {
            return new DirectSpecification<Convenio>(p => p.QuantidadeDigitos < value);
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
   public partial class HealthPlansAggSettingsSpecifications {
		public static Specification<HealthPlansAggSettings> UserIdContains(string value) {
			return new DirectSpecification<HealthPlansAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<HealthPlansAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<HealthPlansAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<HealthPlansAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<HealthPlansAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<HealthPlansAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<HealthPlansAggSettings>(p => p.UserId != value);
		}
		public static Specification<HealthPlansAggSettings> UserIdIsNull() {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.UserId == null);
        }
		public static Specification<HealthPlansAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.UserId != null);
        }
				public static Specification<HealthPlansAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<HealthPlansAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<HealthPlansAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<HealthPlansAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<HealthPlansAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<HealthPlansAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<HealthPlansAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<HealthPlansAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<HealthPlansAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<HealthPlansAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<HealthPlansAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<HealthPlansAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<HealthPlansAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<HealthPlansAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<HealthPlansAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<HealthPlansAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<HealthPlansAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<HealthPlansAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<HealthPlansAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<HealthPlansAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<HealthPlansAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<HealthPlansAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<HealthPlansAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<HealthPlansAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.Id >= value);
        }
        public static Specification<HealthPlansAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.Id <= value);
        }
        public static Specification<HealthPlansAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.Id != value);
        }
        public static Specification<HealthPlansAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.Id > value);
        }
        public static Specification<HealthPlansAggSettings> IdLessThan(int value) {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.Id < value);
        }
			public static Specification<HealthPlansAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<HealthPlansAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<HealthPlansAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<HealthPlansAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<HealthPlansAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<HealthPlansAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<HealthPlansAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<HealthPlansAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<HealthPlansAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<HealthPlansAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<HealthPlansAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<HealthPlansAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<HealthPlansAggSettings>(p => p.IsDeleted == value);
		}
	   }
   public partial class PlanoConvenioSpecifications {
		public static Specification<PlanoConvenio> ConvenioIdEqual(params int[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ConvenioId));
        }
        public static Specification<PlanoConvenio> ConvenioIdGreatThanOrEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ConvenioId >= value);
        }
        public static Specification<PlanoConvenio> ConvenioIdLessThanOrEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ConvenioId <= value);
        }
        public static Specification<PlanoConvenio> ConvenioIdNotEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ConvenioId != value);
        }
        public static Specification<PlanoConvenio> ConvenioIdGreatThan(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ConvenioId > value);
        }
        public static Specification<PlanoConvenio> ConvenioIdLessThan(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ConvenioId < value);
        }
				public static Specification<PlanoConvenio> ClassificacaoServicoHospitalarEqual(params Bravo.HealthPlans.Enumerations.ClassificacaoServicoHospitalarEnum[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ClassificacaoServicoHospitalar));
		}
		public static Specification<PlanoConvenio> ClassificacaoServicoHospitalarNotEqual(Bravo.HealthPlans.Enumerations.ClassificacaoServicoHospitalarEnum value) {
			return new DirectSpecification<PlanoConvenio>(p => p.ClassificacaoServicoHospitalar != value);
		}
			public static Specification<PlanoConvenio> TipoPlanoIdEqual(params int[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.TipoPlanoId));
        }
        public static Specification<PlanoConvenio> TipoPlanoIdGreatThanOrEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.TipoPlanoId >= value);
        }
        public static Specification<PlanoConvenio> TipoPlanoIdLessThanOrEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.TipoPlanoId <= value);
        }
        public static Specification<PlanoConvenio> TipoPlanoIdNotEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.TipoPlanoId != value);
        }
        public static Specification<PlanoConvenio> TipoPlanoIdGreatThan(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.TipoPlanoId > value);
        }
        public static Specification<PlanoConvenio> TipoPlanoIdLessThan(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.TipoPlanoId < value);
        }
				public static Specification<PlanoConvenio> MultiplicadorHospitalarEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.MultiplicadorHospitalar));
        }
        public static Specification<PlanoConvenio> MultiplicadorHospitalarGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorHospitalar >= value);
        }
        public static Specification<PlanoConvenio> MultiplicadorHospitalarLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorHospitalar <= value);
        }
        public static Specification<PlanoConvenio> MultiplicadorHospitalarNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorHospitalar != value);
        }
        public static Specification<PlanoConvenio> MultiplicadorHospitalarGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorHospitalar > value);
        }
        public static Specification<PlanoConvenio> MultiplicadorHospitalarLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorHospitalar < value);
        }
			public static Specification<PlanoConvenio> MultiplicadorProfissionalEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.MultiplicadorProfissional));
        }
        public static Specification<PlanoConvenio> MultiplicadorProfissionalGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorProfissional >= value);
        }
        public static Specification<PlanoConvenio> MultiplicadorProfissionalLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorProfissional <= value);
        }
        public static Specification<PlanoConvenio> MultiplicadorProfissionalNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorProfissional != value);
        }
        public static Specification<PlanoConvenio> MultiplicadorProfissionalGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorProfissional > value);
        }
        public static Specification<PlanoConvenio> MultiplicadorProfissionalLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorProfissional < value);
        }
			public static Specification<PlanoConvenio> MultiplicadorExameEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.MultiplicadorExame));
        }
        public static Specification<PlanoConvenio> MultiplicadorExameGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorExame >= value);
        }
        public static Specification<PlanoConvenio> MultiplicadorExameLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorExame <= value);
        }
        public static Specification<PlanoConvenio> MultiplicadorExameNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorExame != value);
        }
        public static Specification<PlanoConvenio> MultiplicadorExameGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorExame > value);
        }
        public static Specification<PlanoConvenio> MultiplicadorExameLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.MultiplicadorExame < value);
        }
			public static Specification<PlanoConvenio> ProcedimentoPercentualPrincipalEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ProcedimentoPercentualPrincipal));
        }
        public static Specification<PlanoConvenio> ProcedimentoPercentualPrincipalGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPercentualPrincipal >= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPercentualPrincipalLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPercentualPrincipal <= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPercentualPrincipalNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPercentualPrincipal != value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPercentualPrincipalGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPercentualPrincipal > value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPercentualPrincipalLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPercentualPrincipal < value);
        }
			public static Specification<PlanoConvenio> ProcedimentoPrincipalDiferenteEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ProcedimentoPrincipalDiferente));
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalDiferenteGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalDiferente >= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalDiferenteLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalDiferente <= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalDiferenteNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalDiferente != value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalDiferenteGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalDiferente > value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalDiferenteLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalDiferente < value);
        }
			public static Specification<PlanoConvenio> ProcedimentoPrincipalMesmaEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ProcedimentoPrincipalMesma));
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalMesmaGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalMesma >= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalMesmaLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalMesma <= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalMesmaNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalMesma != value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalMesmaGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalMesma > value);
        }
        public static Specification<PlanoConvenio> ProcedimentoPrincipalMesmaLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoPrincipalMesma < value);
        }
			public static Specification<PlanoConvenio> ProcedimentoHospitalarPrincipalEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ProcedimentoHospitalarPrincipal));
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarPrincipalGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarPrincipal >= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarPrincipalLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarPrincipal <= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarPrincipalNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarPrincipal != value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarPrincipalGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarPrincipal > value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarPrincipalLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarPrincipal < value);
        }
			public static Specification<PlanoConvenio> ProcedimentoHospitalarDiferenteEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ProcedimentoHospitalarDiferente));
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarDiferenteGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarDiferente >= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarDiferenteLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarDiferente <= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarDiferenteNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarDiferente != value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarDiferenteGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarDiferente > value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarDiferenteLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarDiferente < value);
        }
			public static Specification<PlanoConvenio> ProcedimentoHospitalarMesmaEqual(params decimal[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ProcedimentoHospitalarMesma));
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarMesmaGreatThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarMesma >= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarMesmaLessThanOrEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarMesma <= value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarMesmaNotEqual(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarMesma != value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarMesmaGreatThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarMesma > value);
        }
        public static Specification<PlanoConvenio> ProcedimentoHospitalarMesmaLessThan(decimal value) {
            return new DirectSpecification<PlanoConvenio>(p => p.ProcedimentoHospitalarMesma < value);
        }
			public static Specification<PlanoConvenio> DescricaoMedicamentoContains(string value) {
			return new DirectSpecification<PlanoConvenio>(p => EF.Functions.Like(p.DescricaoMedicamento.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<PlanoConvenio> DescricaoMedicamentoStartsWith(string value) {
			return new DirectSpecification<PlanoConvenio>(p => EF.Functions.Like(p.DescricaoMedicamento.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<PlanoConvenio> DescricaoMedicamentoEqual(params string[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.DescricaoMedicamento));
		}
		public static Specification<PlanoConvenio> DescricaoMedicamentoNotEqual(string value) {
			return new DirectSpecification<PlanoConvenio>(p => p.DescricaoMedicamento != value);
		}
		public static Specification<PlanoConvenio> DescricaoMedicamentoIsNull() {
            return new DirectSpecification<PlanoConvenio>(p => p.DescricaoMedicamento == null);
        }
		public static Specification<PlanoConvenio> DescricaoMedicamentoIsNotNull() {
            return new DirectSpecification<PlanoConvenio>(p => p.DescricaoMedicamento != null);
        }
			public static Specification<PlanoConvenio> MoedaMedicamentoContains(string value) {
			return new DirectSpecification<PlanoConvenio>(p => EF.Functions.Like(p.MoedaMedicamento.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<PlanoConvenio> MoedaMedicamentoStartsWith(string value) {
			return new DirectSpecification<PlanoConvenio>(p => EF.Functions.Like(p.MoedaMedicamento.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<PlanoConvenio> MoedaMedicamentoEqual(params string[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.MoedaMedicamento));
		}
		public static Specification<PlanoConvenio> MoedaMedicamentoNotEqual(string value) {
			return new DirectSpecification<PlanoConvenio>(p => p.MoedaMedicamento != value);
		}
		public static Specification<PlanoConvenio> MoedaMedicamentoIsNull() {
            return new DirectSpecification<PlanoConvenio>(p => p.MoedaMedicamento == null);
        }
		public static Specification<PlanoConvenio> MoedaMedicamentoIsNotNull() {
            return new DirectSpecification<PlanoConvenio>(p => p.MoedaMedicamento != null);
        }
			public static Specification<PlanoConvenio> TipoTabelaMedicamentoEqual(params Bravo.HealthPlans.Enumerations.TipoTabelaEnum[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.TipoTabelaMedicamento));
		}
		public static Specification<PlanoConvenio> TipoTabelaMedicamentoNotEqual(Bravo.HealthPlans.Enumerations.TipoTabelaEnum value) {
			return new DirectSpecification<PlanoConvenio>(p => p.TipoTabelaMedicamento != value);
		}
			public static Specification<PlanoConvenio> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<PlanoConvenio> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.CreatedAt >= value);
        }
        public static Specification<PlanoConvenio> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.CreatedAt <= value);
        }
        public static Specification<PlanoConvenio> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.CreatedAt != value);
        }
        public static Specification<PlanoConvenio> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.CreatedAt > value);
        }
        public static Specification<PlanoConvenio> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.CreatedAt < value);
        }
			public static Specification<PlanoConvenio> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<PlanoConvenio> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.UpdatedAt >= value);
        }
        public static Specification<PlanoConvenio> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.UpdatedAt <= value);
        }
        public static Specification<PlanoConvenio> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.UpdatedAt != value);
        }
        public static Specification<PlanoConvenio> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.UpdatedAt > value);
        }
        public static Specification<PlanoConvenio> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.UpdatedAt < value);
        }
			public static Specification<PlanoConvenio> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<PlanoConvenio> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.DeletedAt >= value);
        }
        public static Specification<PlanoConvenio> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.DeletedAt <= value);
        }
        public static Specification<PlanoConvenio> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.DeletedAt != value);
        }
        public static Specification<PlanoConvenio> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.DeletedAt > value);
        }
        public static Specification<PlanoConvenio> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PlanoConvenio>(p => p.DeletedAt < value);
        }
			public static Specification<PlanoConvenio> IdEqual(params int[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.Id));
        }
        public static Specification<PlanoConvenio> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.Id >= value);
        }
        public static Specification<PlanoConvenio> IdLessThanOrEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.Id <= value);
        }
        public static Specification<PlanoConvenio> IdNotEqual(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.Id != value);
        }
        public static Specification<PlanoConvenio> IdGreatThan(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.Id > value);
        }
        public static Specification<PlanoConvenio> IdLessThan(int value) {
            return new DirectSpecification<PlanoConvenio>(p => p.Id < value);
        }
			public static Specification<PlanoConvenio> ExternalIdContains(string value) {
			return new DirectSpecification<PlanoConvenio>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<PlanoConvenio> ExternalIdStartsWith(string value) {
			return new DirectSpecification<PlanoConvenio>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<PlanoConvenio> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<PlanoConvenio>(p => values.Contains(p.ExternalId));
		}
		public static Specification<PlanoConvenio> ExternalIdNotEqual(string value) {
			return new DirectSpecification<PlanoConvenio>(p => p.ExternalId != value);
		}
		public static Specification<PlanoConvenio> ExternalIdIsNull() {
            return new DirectSpecification<PlanoConvenio>(p => p.ExternalId == null);
        }
		public static Specification<PlanoConvenio> ExternalIdIsNotNull() {
            return new DirectSpecification<PlanoConvenio>(p => p.ExternalId != null);
        }
			public static Specification<PlanoConvenio> IsDeletedEqual(bool value) {
			return new DirectSpecification<PlanoConvenio>(p => p.IsDeleted == value);
		}
	   }
   public partial class TipoPlanoSpecifications {
		public static Specification<TipoPlano> NomeContains(string value) {
			return new DirectSpecification<TipoPlano>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<TipoPlano> NomeStartsWith(string value) {
			return new DirectSpecification<TipoPlano>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<TipoPlano> NomeEqual(params string[] values) {
			return new DirectSpecification<TipoPlano>(p => values.Contains(p.Nome));
		}
		public static Specification<TipoPlano> NomeNotEqual(string value) {
			return new DirectSpecification<TipoPlano>(p => p.Nome != value);
		}
		public static Specification<TipoPlano> NomeIsNull() {
            return new DirectSpecification<TipoPlano>(p => p.Nome == null);
        }
		public static Specification<TipoPlano> NomeIsNotNull() {
            return new DirectSpecification<TipoPlano>(p => p.Nome != null);
        }
			public static Specification<TipoPlano> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<TipoPlano>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<TipoPlano> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.CreatedAt >= value);
        }
        public static Specification<TipoPlano> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.CreatedAt <= value);
        }
        public static Specification<TipoPlano> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.CreatedAt != value);
        }
        public static Specification<TipoPlano> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.CreatedAt > value);
        }
        public static Specification<TipoPlano> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.CreatedAt < value);
        }
			public static Specification<TipoPlano> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<TipoPlano>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<TipoPlano> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.UpdatedAt >= value);
        }
        public static Specification<TipoPlano> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.UpdatedAt <= value);
        }
        public static Specification<TipoPlano> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.UpdatedAt != value);
        }
        public static Specification<TipoPlano> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.UpdatedAt > value);
        }
        public static Specification<TipoPlano> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.UpdatedAt < value);
        }
			public static Specification<TipoPlano> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<TipoPlano>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<TipoPlano> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.DeletedAt >= value);
        }
        public static Specification<TipoPlano> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.DeletedAt <= value);
        }
        public static Specification<TipoPlano> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.DeletedAt != value);
        }
        public static Specification<TipoPlano> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.DeletedAt > value);
        }
        public static Specification<TipoPlano> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<TipoPlano>(p => p.DeletedAt < value);
        }
			public static Specification<TipoPlano> IdEqual(params int[] values) {
			return new DirectSpecification<TipoPlano>(p => values.Contains(p.Id));
        }
        public static Specification<TipoPlano> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<TipoPlano>(p => p.Id >= value);
        }
        public static Specification<TipoPlano> IdLessThanOrEqual(int value) {
            return new DirectSpecification<TipoPlano>(p => p.Id <= value);
        }
        public static Specification<TipoPlano> IdNotEqual(int value) {
            return new DirectSpecification<TipoPlano>(p => p.Id != value);
        }
        public static Specification<TipoPlano> IdGreatThan(int value) {
            return new DirectSpecification<TipoPlano>(p => p.Id > value);
        }
        public static Specification<TipoPlano> IdLessThan(int value) {
            return new DirectSpecification<TipoPlano>(p => p.Id < value);
        }
			public static Specification<TipoPlano> ExternalIdContains(string value) {
			return new DirectSpecification<TipoPlano>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<TipoPlano> ExternalIdStartsWith(string value) {
			return new DirectSpecification<TipoPlano>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<TipoPlano> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<TipoPlano>(p => values.Contains(p.ExternalId));
		}
		public static Specification<TipoPlano> ExternalIdNotEqual(string value) {
			return new DirectSpecification<TipoPlano>(p => p.ExternalId != value);
		}
		public static Specification<TipoPlano> ExternalIdIsNull() {
            return new DirectSpecification<TipoPlano>(p => p.ExternalId == null);
        }
		public static Specification<TipoPlano> ExternalIdIsNotNull() {
            return new DirectSpecification<TipoPlano>(p => p.ExternalId != null);
        }
			public static Specification<TipoPlano> IsDeletedEqual(bool value) {
			return new DirectSpecification<TipoPlano>(p => p.IsDeleted == value);
		}
	   }
   public partial class ConvenioHorasEspeciaisSpecifications {
		public static Specification<ConvenioHorasEspeciais> DiaContains(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.Dia.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConvenioHorasEspeciais> DiaStartsWith(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.Dia.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ConvenioHorasEspeciais> DiaEqual(params string[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.Dia));
		}
		public static Specification<ConvenioHorasEspeciais> DiaNotEqual(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Dia != value);
		}
		public static Specification<ConvenioHorasEspeciais> DiaIsNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Dia == null);
        }
		public static Specification<ConvenioHorasEspeciais> DiaIsNotNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Dia != null);
        }
			public static Specification<ConvenioHorasEspeciais> HoraInicialContains(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.HoraInicial.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConvenioHorasEspeciais> HoraInicialStartsWith(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.HoraInicial.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ConvenioHorasEspeciais> HoraInicialEqual(params string[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.HoraInicial));
		}
		public static Specification<ConvenioHorasEspeciais> HoraInicialNotEqual(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => p.HoraInicial != value);
		}
		public static Specification<ConvenioHorasEspeciais> HoraInicialIsNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.HoraInicial == null);
        }
		public static Specification<ConvenioHorasEspeciais> HoraInicialIsNotNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.HoraInicial != null);
        }
			public static Specification<ConvenioHorasEspeciais> HoraFinalContains(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.HoraFinal.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConvenioHorasEspeciais> HoraFinalStartsWith(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.HoraFinal.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ConvenioHorasEspeciais> HoraFinalEqual(params string[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.HoraFinal));
		}
		public static Specification<ConvenioHorasEspeciais> HoraFinalNotEqual(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => p.HoraFinal != value);
		}
		public static Specification<ConvenioHorasEspeciais> HoraFinalIsNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.HoraFinal == null);
        }
		public static Specification<ConvenioHorasEspeciais> HoraFinalIsNotNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.HoraFinal != null);
        }
			public static Specification<ConvenioHorasEspeciais> ConvenioIdEqual(params int[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.ConvenioId));
        }
        public static Specification<ConvenioHorasEspeciais> ConvenioIdGreatThanOrEqual(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ConvenioId >= value);
        }
        public static Specification<ConvenioHorasEspeciais> ConvenioIdLessThanOrEqual(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ConvenioId <= value);
        }
        public static Specification<ConvenioHorasEspeciais> ConvenioIdNotEqual(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ConvenioId != value);
        }
        public static Specification<ConvenioHorasEspeciais> ConvenioIdGreatThan(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ConvenioId > value);
        }
        public static Specification<ConvenioHorasEspeciais> ConvenioIdLessThan(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ConvenioId < value);
        }
				public static Specification<ConvenioHorasEspeciais> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<ConvenioHorasEspeciais> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.CreatedAt >= value);
        }
        public static Specification<ConvenioHorasEspeciais> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.CreatedAt <= value);
        }
        public static Specification<ConvenioHorasEspeciais> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.CreatedAt != value);
        }
        public static Specification<ConvenioHorasEspeciais> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.CreatedAt > value);
        }
        public static Specification<ConvenioHorasEspeciais> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.CreatedAt < value);
        }
			public static Specification<ConvenioHorasEspeciais> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<ConvenioHorasEspeciais> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.UpdatedAt >= value);
        }
        public static Specification<ConvenioHorasEspeciais> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.UpdatedAt <= value);
        }
        public static Specification<ConvenioHorasEspeciais> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.UpdatedAt != value);
        }
        public static Specification<ConvenioHorasEspeciais> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.UpdatedAt > value);
        }
        public static Specification<ConvenioHorasEspeciais> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.UpdatedAt < value);
        }
			public static Specification<ConvenioHorasEspeciais> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<ConvenioHorasEspeciais> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.DeletedAt >= value);
        }
        public static Specification<ConvenioHorasEspeciais> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.DeletedAt <= value);
        }
        public static Specification<ConvenioHorasEspeciais> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.DeletedAt != value);
        }
        public static Specification<ConvenioHorasEspeciais> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.DeletedAt > value);
        }
        public static Specification<ConvenioHorasEspeciais> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.DeletedAt < value);
        }
			public static Specification<ConvenioHorasEspeciais> IdEqual(params int[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.Id));
        }
        public static Specification<ConvenioHorasEspeciais> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Id >= value);
        }
        public static Specification<ConvenioHorasEspeciais> IdLessThanOrEqual(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Id <= value);
        }
        public static Specification<ConvenioHorasEspeciais> IdNotEqual(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Id != value);
        }
        public static Specification<ConvenioHorasEspeciais> IdGreatThan(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Id > value);
        }
        public static Specification<ConvenioHorasEspeciais> IdLessThan(int value) {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.Id < value);
        }
			public static Specification<ConvenioHorasEspeciais> ExternalIdContains(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConvenioHorasEspeciais> ExternalIdStartsWith(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ConvenioHorasEspeciais> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => values.Contains(p.ExternalId));
		}
		public static Specification<ConvenioHorasEspeciais> ExternalIdNotEqual(string value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ExternalId != value);
		}
		public static Specification<ConvenioHorasEspeciais> ExternalIdIsNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ExternalId == null);
        }
		public static Specification<ConvenioHorasEspeciais> ExternalIdIsNotNull() {
            return new DirectSpecification<ConvenioHorasEspeciais>(p => p.ExternalId != null);
        }
			public static Specification<ConvenioHorasEspeciais> IsDeletedEqual(bool value) {
			return new DirectSpecification<ConvenioHorasEspeciais>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Specifications {
	using Entities;
   public partial class UserSpecifications {
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
