using SES.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace SES.Users.Domain.Aggregates.CompaniesAgg.Specifications {
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
namespace SES.Users.Domain.Aggregates.UsersAgg.Specifications {
	using Entities;
   public partial class UsersAggSettingsSpecifications {
		public static Specification<UsersAggSettings> UserIdContains(string value) {
			return new DirectSpecification<UsersAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<UsersAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<UsersAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<UsersAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<UsersAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<UsersAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<UsersAggSettings>(p => p.UserId != value);
		}
		public static Specification<UsersAggSettings> UserIdIsNull() {
            return new DirectSpecification<UsersAggSettings>(p => p.UserId == null);
        }
		public static Specification<UsersAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<UsersAggSettings>(p => p.UserId != null);
        }
				public static Specification<UsersAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<UsersAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<UsersAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<UsersAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<UsersAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<UsersAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<UsersAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<UsersAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<UsersAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<UsersAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<UsersAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<UsersAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<UsersAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<UsersAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<UsersAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<UsersAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<UsersAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<UsersAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<UsersAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<UsersAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<UsersAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<UsersAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<UsersAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<UsersAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<UsersAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<UsersAggSettings>(p => p.Id >= value);
        }
        public static Specification<UsersAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<UsersAggSettings>(p => p.Id <= value);
        }
        public static Specification<UsersAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<UsersAggSettings>(p => p.Id != value);
        }
        public static Specification<UsersAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<UsersAggSettings>(p => p.Id > value);
        }
        public static Specification<UsersAggSettings> IdLessThan(int value) {
            return new DirectSpecification<UsersAggSettings>(p => p.Id < value);
        }
			public static Specification<UsersAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<UsersAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<UsersAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<UsersAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<UsersAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<UsersAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<UsersAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<UsersAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<UsersAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<UsersAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<UsersAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<UsersAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<UsersAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<UsersAggSettings>(p => p.IsDeleted == value);
		}
	   }
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
