
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using SES.CrossCuting.Infra.Utils.Extensions;
using SES.Core.Application.DTO.Extensions;
using SES.Core.Application.Aggregates.Common;
namespace SES.Users.Application.Aggregates.CompaniesAgg.AppServices {
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Domain.Aggregates.CompaniesAgg.Queries.Models;
	using Domain.Aggregates.CompaniesAgg.Repositories;
	using Domain.Aggregates.CompaniesAgg.Filters;
	using Domain.Aggregates.CompaniesAgg.Entities;
	public partial class EmpresaAppService : BaseAppService, IEmpresaAppService {	
		IEmpresaRepository _empresaRepository;
		public EmpresaAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IEmpresaRepository empresaRepository) : base(ctx, mediator) { _empresaRepository = empresaRepository; }	
		public async Task<EmpresaDTO> Get(EmpresaQueryModel request) {
            return (await _empresaRepository.FindAsync(filter: EmpresaFilters.GetFilters(request), selector: x => x.ProjectedAs<EmpresaDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(EmpresaQueryModel request, int? page = null, int? size = null, Expression<Func<Empresa, T>> selector = null) {
			return await _empresaRepository.SelectAllAsync(
                filter: EmpresaFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Empresa>(),
                selector: selector);
		}
		public async Task<T> Select<T>(EmpresaQueryModel request, Expression<Func<Empresa, T>> selector = null)
        {
            return (await _empresaRepository.FindAsync(filter: EmpresaFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<EmpresaDTO>> GetAll(EmpresaQueryModel request, int? page = null, int? size = null) {
            return await _empresaRepository.FindAllAsync(
                filter: EmpresaFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Empresa>(),
                selector: x => x.ProjectedAs<EmpresaDTO>());
        }
		public async Task<IEnumerable<EmpresaListiningDTO>> GetAllSummary(EmpresaQueryModel request, int? page = null, int? size = null)
        {
            return await _empresaRepository.FindAllAsync(
                filter: EmpresaFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Empresa>(),
                selector: x => x.ProjectedAs<EmpresaListiningDTO>());
        }

		public Task<ValidationResult> Create(EmpresaDTO request, bool updateIfExists = true, EmpresaQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(EmpresaQueryModel request) { return await _empresaRepository.CountAsync(filter: EmpresaFilters.GetFilters(request)); }
		public Task Update(EmpresaQueryModel searchQuery, EmpresaDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(EmpresaQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(EmpresaQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace SES.Users.Application.Aggregates.UsersAgg.AppServices {
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Domain.Aggregates.UsersAgg.Repositories;
	using Domain.Aggregates.UsersAgg.Filters;
	using Domain.Aggregates.UsersAgg.Entities;
	public partial class UsersAggSettingsAppService : BaseAppService, IUsersAggSettingsAppService {	
		IUsersAggSettingsRepository _usersAggSettingsRepository;
		public UsersAggSettingsAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUsersAggSettingsRepository usersAggSettingsRepository) : base(ctx, mediator) { _usersAggSettingsRepository = usersAggSettingsRepository; }	
		public async Task<UsersAggSettingsDTO> Get(UsersAggSettingsQueryModel request) {
            return (await _usersAggSettingsRepository.FindAsync(filter: UsersAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<UsersAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(UsersAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<UsersAggSettings, T>> selector = null) {
			return await _usersAggSettingsRepository.SelectAllAsync(
                filter: UsersAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UsersAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UsersAggSettingsQueryModel request, Expression<Func<UsersAggSettings, T>> selector = null)
        {
            return (await _usersAggSettingsRepository.FindAsync(filter: UsersAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<UsersAggSettingsDTO>> GetAll(UsersAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _usersAggSettingsRepository.FindAllAsync(
                filter: UsersAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UsersAggSettings>(),
                selector: x => x.ProjectedAs<UsersAggSettingsDTO>());
        }
		public async Task<IEnumerable<UsersAggSettingsListiningDTO>> GetAllSummary(UsersAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _usersAggSettingsRepository.FindAllAsync(
                filter: UsersAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UsersAggSettings>(),
                selector: x => x.ProjectedAs<UsersAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(UsersAggSettingsDTO request, bool updateIfExists = true, UsersAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(UsersAggSettingsQueryModel request) { return await _usersAggSettingsRepository.CountAsync(filter: UsersAggSettingsFilters.GetFilters(request)); }
		public Task Update(UsersAggSettingsQueryModel searchQuery, UsersAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(UsersAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(UsersAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class UserAppService : BaseAppService, IUserAppService {	
		IUserRepository _userRepository;
		public UserAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUserRepository userRepository) : base(ctx, mediator) { _userRepository = userRepository; }	
		public async Task<UserDTO> Get(UserQueryModel request) {
            return (await _userRepository.FindAsync(filter: UserFilters.GetFilters(request), selector: x => x.ProjectedAs<UserDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(UserQueryModel request, int? page = null, int? size = null, Expression<Func<User, T>> selector = null) {
			return await _userRepository.SelectAllAsync(
                filter: UserFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<User>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UserQueryModel request, Expression<Func<User, T>> selector = null)
        {
            return (await _userRepository.FindAsync(filter: UserFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<UserDTO>> GetAll(UserQueryModel request, int? page = null, int? size = null) {
            return await _userRepository.FindAllAsync(
                filter: UserFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<User>(),
                selector: x => x.ProjectedAs<UserDTO>());
        }
		public async Task<IEnumerable<UserListiningDTO>> GetAllSummary(UserQueryModel request, int? page = null, int? size = null)
        {
            return await _userRepository.FindAllAsync(
                filter: UserFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<User>(),
                selector: x => x.ProjectedAs<UserListiningDTO>());
        }

		public Task<ValidationResult> Create(UserDTO request, bool updateIfExists = true, UserQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(UserQueryModel request) { return await _userRepository.CountAsync(filter: UserFilters.GetFilters(request)); }
		public Task Update(UserQueryModel searchQuery, UserDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(UserQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(UserQueryModel request){ return _mediator.Send(request.Command); }
	}
}
