using Bravo.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Specifications {
	using Entities;
   public partial class EmpresaSpecifications {
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
}
namespace Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Specifications {
	using Entities;
   public partial class SchedulingsAggSettingsSpecifications {
		public static Specification<SchedulingsAggSettings> UserIdContains(string value) {
			return new DirectSpecification<SchedulingsAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<SchedulingsAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<SchedulingsAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<SchedulingsAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<SchedulingsAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<SchedulingsAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<SchedulingsAggSettings>(p => p.UserId != value);
		}
		public static Specification<SchedulingsAggSettings> UserIdIsNull() {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.UserId == null);
        }
		public static Specification<SchedulingsAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.UserId != null);
        }
				public static Specification<SchedulingsAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<SchedulingsAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<SchedulingsAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<SchedulingsAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<SchedulingsAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<SchedulingsAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<SchedulingsAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<SchedulingsAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<SchedulingsAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<SchedulingsAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<SchedulingsAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<SchedulingsAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<SchedulingsAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<SchedulingsAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<SchedulingsAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<SchedulingsAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<SchedulingsAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<SchedulingsAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<SchedulingsAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<SchedulingsAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<SchedulingsAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<SchedulingsAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<SchedulingsAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<SchedulingsAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.Id >= value);
        }
        public static Specification<SchedulingsAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.Id <= value);
        }
        public static Specification<SchedulingsAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.Id != value);
        }
        public static Specification<SchedulingsAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.Id > value);
        }
        public static Specification<SchedulingsAggSettings> IdLessThan(int value) {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.Id < value);
        }
			public static Specification<SchedulingsAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<SchedulingsAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<SchedulingsAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<SchedulingsAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<SchedulingsAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<SchedulingsAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<SchedulingsAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<SchedulingsAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<SchedulingsAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<SchedulingsAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<SchedulingsAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<SchedulingsAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<SchedulingsAggSettings>(p => p.IsDeleted == value);
		}
	   }
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
			public static Specification<AgendaExame> AgendaStatusContains(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.AgendaStatus.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaExame> AgendaStatusStartsWith(string value) {
			return new DirectSpecification<AgendaExame>(p => EF.Functions.Like(p.AgendaStatus.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaExame> AgendaStatusEqual(params string[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.AgendaStatus));
		}
		public static Specification<AgendaExame> AgendaStatusNotEqual(string value) {
			return new DirectSpecification<AgendaExame>(p => p.AgendaStatus != value);
		}
		public static Specification<AgendaExame> AgendaStatusIsNull() {
            return new DirectSpecification<AgendaExame>(p => p.AgendaStatus == null);
        }
		public static Specification<AgendaExame> AgendaStatusIsNotNull() {
            return new DirectSpecification<AgendaExame>(p => p.AgendaStatus != null);
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
			public static Specification<AgendaExame> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<AgendaExame>(p => values.Contains(p.EmpresaId));
        }
        public static Specification<AgendaExame> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.EmpresaId >= value);
        }
        public static Specification<AgendaExame> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.EmpresaId <= value);
        }
        public static Specification<AgendaExame> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<AgendaExame>(p => p.EmpresaId != value);
        }
        public static Specification<AgendaExame> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.EmpresaId > value);
        }
        public static Specification<AgendaExame> EmpresaIdLessThan(int value) {
            return new DirectSpecification<AgendaExame>(p => p.EmpresaId < value);
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
   public partial class AgendaSalaSpecifications {
		public static Specification<AgendaSala> DataInicioEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.DataInicio));
        }
        public static Specification<AgendaSala> DataInicioGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataInicio >= value);
        }
        public static Specification<AgendaSala> DataInicioLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataInicio <= value);
        }
        public static Specification<AgendaSala> DataInicioNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataInicio != value);
        }
        public static Specification<AgendaSala> DataInicioGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataInicio > value);
        }
        public static Specification<AgendaSala> DataInicioLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataInicio < value);
        }
			public static Specification<AgendaSala> DataFimEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.DataFim));
        }
        public static Specification<AgendaSala> DataFimGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataFim >= value);
        }
        public static Specification<AgendaSala> DataFimLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataFim <= value);
        }
        public static Specification<AgendaSala> DataFimNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataFim != value);
        }
        public static Specification<AgendaSala> DataFimGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataFim > value);
        }
        public static Specification<AgendaSala> DataFimLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DataFim < value);
        }
			public static Specification<AgendaSala> TempoAtendimentoEqual(params int[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.TempoAtendimento));
        }
        public static Specification<AgendaSala> TempoAtendimentoGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.TempoAtendimento >= value);
        }
        public static Specification<AgendaSala> TempoAtendimentoLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.TempoAtendimento <= value);
        }
        public static Specification<AgendaSala> TempoAtendimentoNotEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.TempoAtendimento != value);
        }
        public static Specification<AgendaSala> TempoAtendimentoGreatThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.TempoAtendimento > value);
        }
        public static Specification<AgendaSala> TempoAtendimentoLessThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.TempoAtendimento < value);
        }
			public static Specification<AgendaSala> TipoContains(string value) {
			return new DirectSpecification<AgendaSala>(p => EF.Functions.Like(p.Tipo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaSala> TipoStartsWith(string value) {
			return new DirectSpecification<AgendaSala>(p => EF.Functions.Like(p.Tipo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaSala> TipoEqual(params string[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.Tipo));
		}
		public static Specification<AgendaSala> TipoNotEqual(string value) {
			return new DirectSpecification<AgendaSala>(p => p.Tipo != value);
		}
		public static Specification<AgendaSala> TipoIsNull() {
            return new DirectSpecification<AgendaSala>(p => p.Tipo == null);
        }
		public static Specification<AgendaSala> TipoIsNotNull() {
            return new DirectSpecification<AgendaSala>(p => p.Tipo != null);
        }
			public static Specification<AgendaSala> AgendaStatusContains(string value) {
			return new DirectSpecification<AgendaSala>(p => EF.Functions.Like(p.AgendaStatus.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaSala> AgendaStatusStartsWith(string value) {
			return new DirectSpecification<AgendaSala>(p => EF.Functions.Like(p.AgendaStatus.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaSala> AgendaStatusEqual(params string[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.AgendaStatus));
		}
		public static Specification<AgendaSala> AgendaStatusNotEqual(string value) {
			return new DirectSpecification<AgendaSala>(p => p.AgendaStatus != value);
		}
		public static Specification<AgendaSala> AgendaStatusIsNull() {
            return new DirectSpecification<AgendaSala>(p => p.AgendaStatus == null);
        }
		public static Specification<AgendaSala> AgendaStatusIsNotNull() {
            return new DirectSpecification<AgendaSala>(p => p.AgendaStatus != null);
        }
			public static Specification<AgendaSala> QuantidadeAgendamentosEqual(params int[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.QuantidadeAgendamentos));
        }
        public static Specification<AgendaSala> QuantidadeAgendamentosGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeAgendamentos >= value);
        }
        public static Specification<AgendaSala> QuantidadeAgendamentosLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeAgendamentos <= value);
        }
        public static Specification<AgendaSala> QuantidadeAgendamentosNotEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeAgendamentos != value);
        }
        public static Specification<AgendaSala> QuantidadeAgendamentosGreatThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeAgendamentos > value);
        }
        public static Specification<AgendaSala> QuantidadeAgendamentosLessThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeAgendamentos < value);
        }
			public static Specification<AgendaSala> QuantidadeEncaixesEqual(params int[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.QuantidadeEncaixes));
        }
        public static Specification<AgendaSala> QuantidadeEncaixesGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeEncaixes >= value);
        }
        public static Specification<AgendaSala> QuantidadeEncaixesLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeEncaixes <= value);
        }
        public static Specification<AgendaSala> QuantidadeEncaixesNotEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeEncaixes != value);
        }
        public static Specification<AgendaSala> QuantidadeEncaixesGreatThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeEncaixes > value);
        }
        public static Specification<AgendaSala> QuantidadeEncaixesLessThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.QuantidadeEncaixes < value);
        }
			public static Specification<AgendaSala> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.EmpresaId));
        }
        public static Specification<AgendaSala> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.EmpresaId >= value);
        }
        public static Specification<AgendaSala> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.EmpresaId <= value);
        }
        public static Specification<AgendaSala> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.EmpresaId != value);
        }
        public static Specification<AgendaSala> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.EmpresaId > value);
        }
        public static Specification<AgendaSala> EmpresaIdLessThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.EmpresaId < value);
        }
				public static Specification<AgendaSala> AtivoEqual(bool value) {
			return new DirectSpecification<AgendaSala>(p => p.Ativo == value);
		}
		public static Specification<AgendaSala> AtivoIsNull() {
            return new DirectSpecification<AgendaSala>(p => p.Ativo == null);
        }
		public static Specification<AgendaSala> AtivoIsNotNull() {
            return new DirectSpecification<AgendaSala>(p => p.Ativo != null);
        }
			public static Specification<AgendaSala> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<AgendaSala> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.CreatedAt >= value);
        }
        public static Specification<AgendaSala> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.CreatedAt <= value);
        }
        public static Specification<AgendaSala> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.CreatedAt != value);
        }
        public static Specification<AgendaSala> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.CreatedAt > value);
        }
        public static Specification<AgendaSala> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.CreatedAt < value);
        }
			public static Specification<AgendaSala> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<AgendaSala> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.UpdatedAt >= value);
        }
        public static Specification<AgendaSala> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.UpdatedAt <= value);
        }
        public static Specification<AgendaSala> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.UpdatedAt != value);
        }
        public static Specification<AgendaSala> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.UpdatedAt > value);
        }
        public static Specification<AgendaSala> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.UpdatedAt < value);
        }
			public static Specification<AgendaSala> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<AgendaSala> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DeletedAt >= value);
        }
        public static Specification<AgendaSala> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DeletedAt <= value);
        }
        public static Specification<AgendaSala> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DeletedAt != value);
        }
        public static Specification<AgendaSala> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DeletedAt > value);
        }
        public static Specification<AgendaSala> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AgendaSala>(p => p.DeletedAt < value);
        }
			public static Specification<AgendaSala> IdEqual(params int[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.Id));
        }
        public static Specification<AgendaSala> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.Id >= value);
        }
        public static Specification<AgendaSala> IdLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.Id <= value);
        }
        public static Specification<AgendaSala> IdNotEqual(int value) {
            return new DirectSpecification<AgendaSala>(p => p.Id != value);
        }
        public static Specification<AgendaSala> IdGreatThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.Id > value);
        }
        public static Specification<AgendaSala> IdLessThan(int value) {
            return new DirectSpecification<AgendaSala>(p => p.Id < value);
        }
			public static Specification<AgendaSala> ExternalIdContains(string value) {
			return new DirectSpecification<AgendaSala>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaSala> ExternalIdStartsWith(string value) {
			return new DirectSpecification<AgendaSala>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaSala> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<AgendaSala>(p => values.Contains(p.ExternalId));
		}
		public static Specification<AgendaSala> ExternalIdNotEqual(string value) {
			return new DirectSpecification<AgendaSala>(p => p.ExternalId != value);
		}
		public static Specification<AgendaSala> ExternalIdIsNull() {
            return new DirectSpecification<AgendaSala>(p => p.ExternalId == null);
        }
		public static Specification<AgendaSala> ExternalIdIsNotNull() {
            return new DirectSpecification<AgendaSala>(p => p.ExternalId != null);
        }
			public static Specification<AgendaSala> IsDeletedEqual(bool value) {
			return new DirectSpecification<AgendaSala>(p => p.IsDeleted == value);
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
		public static Specification<AgendaProfissional> ProfissionalIdContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.ProfissionalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> ProfissionalIdStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.ProfissionalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> ProfissionalIdEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.ProfissionalId));
		}
		public static Specification<AgendaProfissional> ProfissionalIdNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.ProfissionalId != value);
		}
		public static Specification<AgendaProfissional> ProfissionalIdIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.ProfissionalId == null);
        }
		public static Specification<AgendaProfissional> ProfissionalIdIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.ProfissionalId != null);
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
			public static Specification<AgendaProfissional> AgendaStatusContains(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.AgendaStatus.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AgendaProfissional> AgendaStatusStartsWith(string value) {
			return new DirectSpecification<AgendaProfissional>(p => EF.Functions.Like(p.AgendaStatus.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AgendaProfissional> AgendaStatusEqual(params string[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.AgendaStatus));
		}
		public static Specification<AgendaProfissional> AgendaStatusNotEqual(string value) {
			return new DirectSpecification<AgendaProfissional>(p => p.AgendaStatus != value);
		}
		public static Specification<AgendaProfissional> AgendaStatusIsNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.AgendaStatus == null);
        }
		public static Specification<AgendaProfissional> AgendaStatusIsNotNull() {
            return new DirectSpecification<AgendaProfissional>(p => p.AgendaStatus != null);
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
			public static Specification<AgendaProfissional> EmpresaIdEqual(params int[] values) {
			return new DirectSpecification<AgendaProfissional>(p => values.Contains(p.EmpresaId));
        }
        public static Specification<AgendaProfissional> EmpresaIdGreatThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.EmpresaId >= value);
        }
        public static Specification<AgendaProfissional> EmpresaIdLessThanOrEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.EmpresaId <= value);
        }
        public static Specification<AgendaProfissional> EmpresaIdNotEqual(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.EmpresaId != value);
        }
        public static Specification<AgendaProfissional> EmpresaIdGreatThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.EmpresaId > value);
        }
        public static Specification<AgendaProfissional> EmpresaIdLessThan(int value) {
            return new DirectSpecification<AgendaProfissional>(p => p.EmpresaId < value);
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
namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Specifications {
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
   public partial class ProfessionalsAggSettingsSpecifications {
		public static Specification<ProfessionalsAggSettings> UserIdContains(string value) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ProfessionalsAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ProfessionalsAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<ProfessionalsAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => p.UserId != value);
		}
		public static Specification<ProfessionalsAggSettings> UserIdIsNull() {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.UserId == null);
        }
		public static Specification<ProfessionalsAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.UserId != null);
        }
				public static Specification<ProfessionalsAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<ProfessionalsAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<ProfessionalsAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<ProfessionalsAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<ProfessionalsAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<ProfessionalsAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<ProfessionalsAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<ProfessionalsAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<ProfessionalsAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<ProfessionalsAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<ProfessionalsAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<ProfessionalsAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<ProfessionalsAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<ProfessionalsAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<ProfessionalsAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<ProfessionalsAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<ProfessionalsAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<ProfessionalsAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<ProfessionalsAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<ProfessionalsAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.Id >= value);
        }
        public static Specification<ProfessionalsAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.Id <= value);
        }
        public static Specification<ProfessionalsAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.Id != value);
        }
        public static Specification<ProfessionalsAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.Id > value);
        }
        public static Specification<ProfessionalsAggSettings> IdLessThan(int value) {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.Id < value);
        }
			public static Specification<ProfessionalsAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ProfessionalsAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ProfessionalsAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<ProfessionalsAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<ProfessionalsAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<ProfessionalsAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<ProfessionalsAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<ProfessionalsAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<ProfessionalsAggSettings>(p => p.IsDeleted == value);
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
namespace Bravo.Professionals.Domain.Aggregates.UsersAgg.Specifications {
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
