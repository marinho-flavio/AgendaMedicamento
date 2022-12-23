using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.Core.Domain.Seedwork.Specification;
namespace Bravo.Partners.Application.Aggregates.PartnersAgg.AppServices {
	using Domain.Aggregates.PartnersAgg.Queries.Models;
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	public partial interface IFornecedorAppService {	
		public Task<FornecedorDTO> Get(FornecedorQueryModel request);
		public Task<int> CountAsync(FornecedorQueryModel request);
		public Task<IEnumerable<FornecedorDTO>> GetAll(FornecedorQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(FornecedorQueryModel request, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Fornecedor, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(FornecedorQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Fornecedor, T>> selector = null);
		public Task<IEnumerable<FornecedorListiningDTO>> GetAllSummary(FornecedorQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(FornecedorDTO request, bool updateIfExists = true, FornecedorQueryModel searchQuery = null);
		public Task Delete(FornecedorQueryModel request);
		public Task Update(FornecedorQueryModel searchQuery, FornecedorDTO request, bool createIfNotExists = true);
		public Task DeleteRange(FornecedorQueryModel request);
	}
	public partial interface IPublicitarioAppService {	
		public Task<PublicitarioDTO> Get(PublicitarioQueryModel request);
		public Task<int> CountAsync(PublicitarioQueryModel request);
		public Task<IEnumerable<PublicitarioDTO>> GetAll(PublicitarioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PublicitarioQueryModel request, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Publicitario, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PublicitarioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Publicitario, T>> selector = null);
		public Task<IEnumerable<PublicitarioListiningDTO>> GetAllSummary(PublicitarioQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(PublicitarioDTO request, bool updateIfExists = true, PublicitarioQueryModel searchQuery = null);
		public Task Delete(PublicitarioQueryModel request);
		public Task Update(PublicitarioQueryModel searchQuery, PublicitarioDTO request, bool createIfNotExists = true);
		public Task DeleteRange(PublicitarioQueryModel request);
	}
	public partial interface IPartnersAggSettingsAppService {	
		public Task<PartnersAggSettingsDTO> Get(PartnersAggSettingsQueryModel request);
		public Task<int> CountAsync(PartnersAggSettingsQueryModel request);
		public Task<IEnumerable<PartnersAggSettingsDTO>> GetAll(PartnersAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PartnersAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.PartnersAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PartnersAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.PartnersAggSettings, T>> selector = null);
		public Task<IEnumerable<PartnersAggSettingsListiningDTO>> GetAllSummary(PartnersAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(PartnersAggSettingsDTO request, bool updateIfExists = true, PartnersAggSettingsQueryModel searchQuery = null);
		public Task Delete(PartnersAggSettingsQueryModel request);
		public Task Update(PartnersAggSettingsQueryModel searchQuery, PartnersAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(PartnersAggSettingsQueryModel request);
	}
}
namespace Bravo.Partners.Application.Aggregates.UsersAgg.AppServices {
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
