using SES.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.Specifications {
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
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Specifications {
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
			public static Specification<Feriado> TipoEqual(params SES.Schedulings.Enumerations.HolidayType[] values) {
			return new DirectSpecification<Feriado>(p => values.Contains(p.Tipo));
		}
		public static Specification<Feriado> TipoNotEqual(SES.Schedulings.Enumerations.HolidayType value) {
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
}
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Specifications {
	using Entities;
   public partial class ProfissionalSpecifications {
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
}
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.Specifications {
	using Entities;
   public partial class UserSpecifications {
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
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.Specifications {
	using Entities;
   public partial class FornecedorSpecifications {
		public static Specification<Fornecedor> NomeContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> NomeStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> NomeEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.Nome));
		}
		public static Specification<Fornecedor> NomeNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.Nome != value);
		}
		public static Specification<Fornecedor> NomeIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.Nome == null);
        }
		public static Specification<Fornecedor> NomeIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.Nome != null);
        }
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
		public static Specification<Publicitario> NomeContains(string value) {
			return new DirectSpecification<Publicitario>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Publicitario> NomeStartsWith(string value) {
			return new DirectSpecification<Publicitario>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Publicitario> NomeEqual(params string[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.Nome));
		}
		public static Specification<Publicitario> NomeNotEqual(string value) {
			return new DirectSpecification<Publicitario>(p => p.Nome != value);
		}
		public static Specification<Publicitario> NomeIsNull() {
            return new DirectSpecification<Publicitario>(p => p.Nome == null);
        }
		public static Specification<Publicitario> NomeIsNotNull() {
            return new DirectSpecification<Publicitario>(p => p.Nome != null);
        }
			public static Specification<Publicitario> TipoEqual(params int[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.Tipo.Value));
        }
        public static Specification<Publicitario> TipoGreatThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.Tipo >= value);
        }
        public static Specification<Publicitario> TipoLessThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.Tipo <= value);
        }
        public static Specification<Publicitario> TipoNotEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.Tipo != value);
        }
        public static Specification<Publicitario> TipoGreatThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.Tipo > value);
        }
        public static Specification<Publicitario> TipoLessThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.Tipo < value);
        }
			public static Specification<Publicitario> FornecedorIdEqual(params int[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.FornecedorId));
        }
        public static Specification<Publicitario> FornecedorIdGreatThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.FornecedorId >= value);
        }
        public static Specification<Publicitario> FornecedorIdLessThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.FornecedorId <= value);
        }
        public static Specification<Publicitario> FornecedorIdNotEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.FornecedorId != value);
        }
        public static Specification<Publicitario> FornecedorIdGreatThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.FornecedorId > value);
        }
        public static Specification<Publicitario> FornecedorIdLessThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.FornecedorId < value);
        }
				public static Specification<Publicitario> TipoValorRepasseEqual(params int[] values) {
			return new DirectSpecification<Publicitario>(p => values.Contains(p.TipoValorRepasse.Value));
        }
        public static Specification<Publicitario> TipoValorRepasseGreatThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.TipoValorRepasse >= value);
        }
        public static Specification<Publicitario> TipoValorRepasseLessThanOrEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.TipoValorRepasse <= value);
        }
        public static Specification<Publicitario> TipoValorRepasseNotEqual(int value) {
            return new DirectSpecification<Publicitario>(p => p.TipoValorRepasse != value);
        }
        public static Specification<Publicitario> TipoValorRepasseGreatThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.TipoValorRepasse > value);
        }
        public static Specification<Publicitario> TipoValorRepasseLessThan(int value) {
            return new DirectSpecification<Publicitario>(p => p.TipoValorRepasse < value);
        }
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
