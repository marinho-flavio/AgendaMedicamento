using Bravo.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.Specifications {
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
			public static Specification<Endereco> TipoLogradouroContains(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.TipoLogradouro.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Endereco> TipoLogradouroStartsWith(string value) {
			return new DirectSpecification<Endereco>(p => EF.Functions.Like(p.TipoLogradouro.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Endereco> TipoLogradouroEqual(params string[] values) {
			return new DirectSpecification<Endereco>(p => values.Contains(p.TipoLogradouro));
		}
		public static Specification<Endereco> TipoLogradouroNotEqual(string value) {
			return new DirectSpecification<Endereco>(p => p.TipoLogradouro != value);
		}
		public static Specification<Endereco> TipoLogradouroIsNull() {
            return new DirectSpecification<Endereco>(p => p.TipoLogradouro == null);
        }
		public static Specification<Endereco> TipoLogradouroIsNotNull() {
            return new DirectSpecification<Endereco>(p => p.TipoLogradouro != null);
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
   public partial class AddressesAggSettingsSpecifications {
		public static Specification<AddressesAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<AddressesAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<AddressesAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<AddressesAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<AddressesAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<AddressesAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<AddressesAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<AddressesAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<AddressesAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<AddressesAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<AddressesAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<AddressesAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<AddressesAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<AddressesAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<AddressesAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<AddressesAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id >= value);
        }
        public static Specification<AddressesAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id <= value);
        }
        public static Specification<AddressesAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id != value);
        }
        public static Specification<AddressesAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id > value);
        }
        public static Specification<AddressesAggSettings> IdLessThan(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id < value);
        }
			public static Specification<AddressesAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AddressesAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AddressesAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<AddressesAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<AddressesAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<AddressesAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<AddressesAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<AddressesAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<AddressesAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<AddressesAggSettings>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Addresses.Domain.Aggregates.UsersAgg.Specifications {
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
