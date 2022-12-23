using Bravo.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Specifications {
	using Entities;
   public partial class PacienteSpecifications {
		public static Specification<Paciente> TipoContains(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.Tipo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Paciente> TipoStartsWith(string value) {
			return new DirectSpecification<Paciente>(p => EF.Functions.Like(p.Tipo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Paciente> TipoEqual(params string[] values) {
			return new DirectSpecification<Paciente>(p => values.Contains(p.Tipo));
		}
		public static Specification<Paciente> TipoNotEqual(string value) {
			return new DirectSpecification<Paciente>(p => p.Tipo != value);
		}
		public static Specification<Paciente> TipoIsNull() {
            return new DirectSpecification<Paciente>(p => p.Tipo == null);
        }
		public static Specification<Paciente> TipoIsNotNull() {
            return new DirectSpecification<Paciente>(p => p.Tipo != null);
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
   public partial class PatientsAggSettingsSpecifications {
		public static Specification<PatientsAggSettings> UserIdContains(string value) {
			return new DirectSpecification<PatientsAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<PatientsAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<PatientsAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<PatientsAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<PatientsAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<PatientsAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<PatientsAggSettings>(p => p.UserId != value);
		}
		public static Specification<PatientsAggSettings> UserIdIsNull() {
            return new DirectSpecification<PatientsAggSettings>(p => p.UserId == null);
        }
		public static Specification<PatientsAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<PatientsAggSettings>(p => p.UserId != null);
        }
				public static Specification<PatientsAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PatientsAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<PatientsAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<PatientsAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<PatientsAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<PatientsAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<PatientsAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<PatientsAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PatientsAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<PatientsAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<PatientsAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<PatientsAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<PatientsAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<PatientsAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<PatientsAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PatientsAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<PatientsAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<PatientsAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<PatientsAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<PatientsAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<PatientsAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<PatientsAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<PatientsAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<PatientsAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.Id >= value);
        }
        public static Specification<PatientsAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.Id <= value);
        }
        public static Specification<PatientsAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.Id != value);
        }
        public static Specification<PatientsAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.Id > value);
        }
        public static Specification<PatientsAggSettings> IdLessThan(int value) {
            return new DirectSpecification<PatientsAggSettings>(p => p.Id < value);
        }
			public static Specification<PatientsAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<PatientsAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<PatientsAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<PatientsAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<PatientsAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<PatientsAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<PatientsAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<PatientsAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<PatientsAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<PatientsAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<PatientsAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<PatientsAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<PatientsAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<PatientsAggSettings>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Patients.Domain.Aggregates.UsersAgg.Specifications {
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
