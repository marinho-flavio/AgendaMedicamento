using Bravo.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Bravo.Partners.Domain.Aggregates.CompaniesAgg.Specifications {
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
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Specifications {
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
			public static Specification<Fornecedor> NomeFantasiaContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.NomeFantasia.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> NomeFantasiaStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.NomeFantasia.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> NomeFantasiaEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.NomeFantasia));
		}
		public static Specification<Fornecedor> NomeFantasiaNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.NomeFantasia != value);
		}
		public static Specification<Fornecedor> NomeFantasiaIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.NomeFantasia == null);
        }
		public static Specification<Fornecedor> NomeFantasiaIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.NomeFantasia != null);
        }
			public static Specification<Fornecedor> CpfContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Cpf.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> CpfStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Cpf.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> CpfEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.Cpf));
		}
		public static Specification<Fornecedor> CpfNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.Cpf != value);
		}
		public static Specification<Fornecedor> CpfIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.Cpf == null);
        }
		public static Specification<Fornecedor> CpfIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.Cpf != null);
        }
			public static Specification<Fornecedor> CnpjContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Cnpj.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> CnpjStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Cnpj.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> CnpjEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.Cnpj));
		}
		public static Specification<Fornecedor> CnpjNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.Cnpj != value);
		}
		public static Specification<Fornecedor> CnpjIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.Cnpj == null);
        }
		public static Specification<Fornecedor> CnpjIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.Cnpj != null);
        }
			public static Specification<Fornecedor> TipoEqual(params int[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.Tipo.Value));
        }
        public static Specification<Fornecedor> TipoGreatThanOrEqual(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Tipo >= value);
        }
        public static Specification<Fornecedor> TipoLessThanOrEqual(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Tipo <= value);
        }
        public static Specification<Fornecedor> TipoNotEqual(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Tipo != value);
        }
        public static Specification<Fornecedor> TipoGreatThan(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Tipo > value);
        }
        public static Specification<Fornecedor> TipoLessThan(int value) {
            return new DirectSpecification<Fornecedor>(p => p.Tipo < value);
        }
			public static Specification<Fornecedor> NomeContatoContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.NomeContato.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> NomeContatoStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.NomeContato.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> NomeContatoEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.NomeContato));
		}
		public static Specification<Fornecedor> NomeContatoNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.NomeContato != value);
		}
		public static Specification<Fornecedor> NomeContatoIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.NomeContato == null);
        }
		public static Specification<Fornecedor> NomeContatoIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.NomeContato != null);
        }
			public static Specification<Fornecedor> TelefoneContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Telefone.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> TelefoneStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Telefone.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> TelefoneEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.Telefone));
		}
		public static Specification<Fornecedor> TelefoneNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.Telefone != value);
		}
		public static Specification<Fornecedor> TelefoneIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.Telefone == null);
        }
		public static Specification<Fornecedor> TelefoneIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.Telefone != null);
        }
			public static Specification<Fornecedor> ClassificacaoContains(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Classificacao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Fornecedor> ClassificacaoStartsWith(string value) {
			return new DirectSpecification<Fornecedor>(p => EF.Functions.Like(p.Classificacao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Fornecedor> ClassificacaoEqual(params string[] values) {
			return new DirectSpecification<Fornecedor>(p => values.Contains(p.Classificacao));
		}
		public static Specification<Fornecedor> ClassificacaoNotEqual(string value) {
			return new DirectSpecification<Fornecedor>(p => p.Classificacao != value);
		}
		public static Specification<Fornecedor> ClassificacaoIsNull() {
            return new DirectSpecification<Fornecedor>(p => p.Classificacao == null);
        }
		public static Specification<Fornecedor> ClassificacaoIsNotNull() {
            return new DirectSpecification<Fornecedor>(p => p.Classificacao != null);
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
   public partial class PartnersAggSettingsSpecifications {
		public static Specification<PartnersAggSettings> UserIdContains(string value) {
			return new DirectSpecification<PartnersAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<PartnersAggSettings> UserIdStartsWith(string value) {
			return new DirectSpecification<PartnersAggSettings>(p => EF.Functions.Like(p.UserId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<PartnersAggSettings> UserIdEqual(params string[] values) {
			return new DirectSpecification<PartnersAggSettings>(p => values.Contains(p.UserId));
		}
		public static Specification<PartnersAggSettings> UserIdNotEqual(string value) {
			return new DirectSpecification<PartnersAggSettings>(p => p.UserId != value);
		}
		public static Specification<PartnersAggSettings> UserIdIsNull() {
            return new DirectSpecification<PartnersAggSettings>(p => p.UserId == null);
        }
		public static Specification<PartnersAggSettings> UserIdIsNotNull() {
            return new DirectSpecification<PartnersAggSettings>(p => p.UserId != null);
        }
				public static Specification<PartnersAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PartnersAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<PartnersAggSettings> CreatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<PartnersAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<PartnersAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<PartnersAggSettings> CreatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<PartnersAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.CreatedAt < value);
        }
			public static Specification<PartnersAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PartnersAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<PartnersAggSettings> UpdatedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<PartnersAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<PartnersAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<PartnersAggSettings> UpdatedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<PartnersAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.UpdatedAt < value);
        }
			public static Specification<PartnersAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<PartnersAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<PartnersAggSettings> DeletedAtGreatThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<PartnersAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<PartnersAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<PartnersAggSettings> DeletedAtGreatThan(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<PartnersAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.DeletedAt < value);
        }
			public static Specification<PartnersAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<PartnersAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<PartnersAggSettings> IdGreatThanOrEqual(int value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.Id >= value);
        }
        public static Specification<PartnersAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.Id <= value);
        }
        public static Specification<PartnersAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.Id != value);
        }
        public static Specification<PartnersAggSettings> IdGreatThan(int value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.Id > value);
        }
        public static Specification<PartnersAggSettings> IdLessThan(int value) {
            return new DirectSpecification<PartnersAggSettings>(p => p.Id < value);
        }
			public static Specification<PartnersAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<PartnersAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<PartnersAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<PartnersAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<PartnersAggSettings> ExternalIdEqual(params string[] values) {
			return new DirectSpecification<PartnersAggSettings>(p => values.Contains(p.ExternalId));
		}
		public static Specification<PartnersAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<PartnersAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<PartnersAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<PartnersAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<PartnersAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<PartnersAggSettings>(p => p.ExternalId != null);
        }
			public static Specification<PartnersAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<PartnersAggSettings>(p => p.IsDeleted == value);
		}
	   }
}
namespace Bravo.Partners.Domain.Aggregates.UsersAgg.Specifications {
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
