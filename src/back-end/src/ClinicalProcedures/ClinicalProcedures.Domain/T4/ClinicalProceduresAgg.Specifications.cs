using Bravo.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Specifications {
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
namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Specifications {
	using Entities;
   public partial class ClinicalProceduresAggSettingsSpecifications {
		public static Specification<ClinicalProceduresAggSettings> UserIdContains(string value) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ClinicalProceduresAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ClinicalProceduresAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<ClinicalProceduresAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UserId != value);
		}
		public static Specification<ClinicalProceduresAggSettings> UserIdIsNull() {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UserId == null);
        }
		public static Specification<ClinicalProceduresAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UserId != null);
        }
				public static Specification<ClinicalProceduresAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<ClinicalProceduresAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<ClinicalProceduresAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<ClinicalProceduresAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<ClinicalProceduresAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<ClinicalProceduresAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<ClinicalProceduresAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<ClinicalProceduresAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<ClinicalProceduresAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<ClinicalProceduresAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<ClinicalProceduresAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<ClinicalProceduresAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<ClinicalProceduresAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<ClinicalProceduresAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<ClinicalProceduresAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<ClinicalProceduresAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<ClinicalProceduresAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<ClinicalProceduresAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<ClinicalProceduresAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<ClinicalProceduresAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.Id >= value);
        }
        public static Specification<ClinicalProceduresAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.Id <= value);
        }
        public static Specification<ClinicalProceduresAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.Id != value);
        }
        public static Specification<ClinicalProceduresAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.Id > value);
        }
        public static Specification<ClinicalProceduresAggSettings> IdLessThan(int value) {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.Id < value);
        }
			public static Specification<ClinicalProceduresAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ClinicalProceduresAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ClinicalProceduresAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<ClinicalProceduresAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<ClinicalProceduresAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<ClinicalProceduresAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<ClinicalProceduresAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<ClinicalProceduresAggSettings>(p => p.IsDeleted == value);
		}
	   }
}
