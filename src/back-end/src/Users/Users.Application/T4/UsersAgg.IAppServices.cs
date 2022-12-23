using System.Linq.Expressions;
using FluentValidation.Results;
using SES.Core.Domain.Seedwork.Specification;
namespace SES.Users.Application.Aggregates.CompaniesAgg.AppServices {
	using Domain.Aggregates.CompaniesAgg.Queries.Models;
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	public partial interface IEmpresaAppService {	
		public Task<EmpresaDTO> Get(EmpresaQueryModel request);
		public Task<int> CountAsync(EmpresaQueryModel request);
		public Task<IEnumerable<EmpresaDTO>> GetAll(EmpresaQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(EmpresaQueryModel request, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.Empresa, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(EmpresaQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.Empresa, T>> selector = null);
		public Task<IEnumerable<EmpresaListiningDTO>> GetAllSummary(EmpresaQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(EmpresaDTO request, bool updateIfExists = true, EmpresaQueryModel searchQuery = null);
		public Task Delete(EmpresaQueryModel request);
		public Task Update(EmpresaQueryModel searchQuery, EmpresaDTO request, bool createIfNotExists = true);
		public Task DeleteRange(EmpresaQueryModel request);
	}
}
namespace SES.Users.Application.Aggregates.UsersAgg.AppServices {
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Application.DTO.Aggregates.UsersAgg.Requests;
	public partial interface IUsersAggSettingsAppService {	
		public Task<UsersAggSettingsDTO> Get(UsersAggSettingsQueryModel request);
		public Task<int> CountAsync(UsersAggSettingsQueryModel request);
		public Task<IEnumerable<UsersAggSettingsDTO>> GetAll(UsersAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UsersAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UsersAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UsersAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UsersAggSettings, T>> selector = null);
		public Task<IEnumerable<UsersAggSettingsListiningDTO>> GetAllSummary(UsersAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(UsersAggSettingsDTO request, bool updateIfExists = true, UsersAggSettingsQueryModel searchQuery = null);
		public Task Delete(UsersAggSettingsQueryModel request);
		public Task Update(UsersAggSettingsQueryModel searchQuery, UsersAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(UsersAggSettingsQueryModel request);
	}
	public partial interface IUserAppService {	
		public Task<UserDTO> Get(UserQueryModel request);
		public Task<int> CountAsync(UserQueryModel request);
		public Task<IEnumerable<UserDTO>> GetAll(UserQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<UserListiningDTO>> GetAllSummary(UserQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(UserDTO request, bool updateIfExists = true, UserQueryModel searchQuery = null);
		public Task Delete(UserQueryModel request);
		public Task Update(UserQueryModel searchQuery, UserDTO request, bool createIfNotExists = true);
		public Task DeleteRange(UserQueryModel request);
	}
}
