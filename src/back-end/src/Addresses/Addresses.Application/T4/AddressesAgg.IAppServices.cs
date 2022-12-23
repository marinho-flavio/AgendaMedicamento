using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.Core.Domain.Seedwork.Specification;
namespace Bravo.Addresses.Application.Aggregates.AddressesAgg.AppServices {
	using Domain.Aggregates.AddressesAgg.Queries.Models;
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	public partial interface IEnderecoAppService {	
		public Task<EnderecoDTO> Get(EnderecoQueryModel request);
		public Task<int> CountAsync(EnderecoQueryModel request);
		public Task<IEnumerable<EnderecoDTO>> GetAll(EnderecoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(EnderecoQueryModel request, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Endereco, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(EnderecoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Endereco, T>> selector = null);
		public Task<IEnumerable<EnderecoListiningDTO>> GetAllSummary(EnderecoQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(EnderecoDTO request, bool updateIfExists = true, EnderecoQueryModel searchQuery = null);
		public Task Delete(EnderecoQueryModel request);
		public Task Update(EnderecoQueryModel searchQuery, EnderecoDTO request, bool createIfNotExists = true);
		public Task DeleteRange(EnderecoQueryModel request);
	}
	public partial interface IAddressesAggSettingsAppService {	
		public Task<AddressesAggSettingsDTO> Get(AddressesAggSettingsQueryModel request);
		public Task<int> CountAsync(AddressesAggSettingsQueryModel request);
		public Task<IEnumerable<AddressesAggSettingsDTO>> GetAll(AddressesAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AddressesAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.AddressesAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AddressesAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.AddressesAggSettings, T>> selector = null);
		public Task<IEnumerable<AddressesAggSettingsListiningDTO>> GetAllSummary(AddressesAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(AddressesAggSettingsDTO request, bool updateIfExists = true, AddressesAggSettingsQueryModel searchQuery = null);
		public Task Delete(AddressesAggSettingsQueryModel request);
		public Task Update(AddressesAggSettingsQueryModel searchQuery, AddressesAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(AddressesAggSettingsQueryModel request);
	}
}
namespace Bravo.Addresses.Application.Aggregates.UsersAgg.AppServices {
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Application.DTO.Aggregates.UsersAgg.Requests;
	public partial interface IUserAppService {	
		public Task<UserDTO> Get(UserQueryModel request);
		public Task<int> CountAsync(UserQueryModel request);
		public Task<IEnumerable<UserDTO>> GetAll(UserQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);

	}
}
