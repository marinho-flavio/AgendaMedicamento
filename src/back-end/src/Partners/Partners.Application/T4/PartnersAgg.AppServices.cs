
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Application.Aggregates.Common;
namespace Bravo.Partners.Application.Aggregates.PartnersAgg.AppServices {
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Domain.Aggregates.PartnersAgg.Queries.Models;
	using Domain.Aggregates.PartnersAgg.Repositories;
	using Domain.Aggregates.PartnersAgg.Filters;
	using Domain.Aggregates.PartnersAgg.Entities;
	public partial class FornecedorAppService : BaseAppService, IFornecedorAppService {	
		IFornecedorRepository _fornecedorRepository;
		public FornecedorAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IFornecedorRepository fornecedorRepository) : base(ctx, mediator) { _fornecedorRepository = fornecedorRepository; }	
		public async Task<FornecedorDTO> Get(FornecedorQueryModel request) {
            return (await _fornecedorRepository.FindAsync(filter: FornecedorFilters.GetFilters(request), selector: x => x.ProjectedAs<FornecedorDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(FornecedorQueryModel request, int? page = null, int? size = null, Expression<Func<Fornecedor, T>> selector = null) {
			return await _fornecedorRepository.SelectAllAsync(
                filter: FornecedorFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Fornecedor>(),
                selector: selector);
		}
		public async Task<T> Select<T>(FornecedorQueryModel request, Expression<Func<Fornecedor, T>> selector = null)
        {
            return (await _fornecedorRepository.FindAsync(filter: FornecedorFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<FornecedorDTO>> GetAll(FornecedorQueryModel request, int? page = null, int? size = null) {
            return await _fornecedorRepository.FindAllAsync(
                filter: FornecedorFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Fornecedor>(),
                selector: x => x.ProjectedAs<FornecedorDTO>());
        }
		public async Task<IEnumerable<FornecedorListiningDTO>> GetAllSummary(FornecedorQueryModel request, int? page = null, int? size = null)
        {
            return await _fornecedorRepository.FindAllAsync(
                filter: FornecedorFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Fornecedor>(),
                selector: x => x.ProjectedAs<FornecedorListiningDTO>());
        }

		public Task<ValidationResult> Create(FornecedorDTO request, bool updateIfExists = true, FornecedorQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(FornecedorQueryModel request) { return await _fornecedorRepository.CountAsync(filter: FornecedorFilters.GetFilters(request)); }
		public Task Update(FornecedorQueryModel searchQuery, FornecedorDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(FornecedorQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(FornecedorQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class PublicitarioAppService : BaseAppService, IPublicitarioAppService {	
		IPublicitarioRepository _publicitarioRepository;
		public PublicitarioAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IPublicitarioRepository publicitarioRepository) : base(ctx, mediator) { _publicitarioRepository = publicitarioRepository; }	
		public async Task<PublicitarioDTO> Get(PublicitarioQueryModel request) {
            return (await _publicitarioRepository.FindAsync(filter: PublicitarioFilters.GetFilters(request), selector: x => x.ProjectedAs<PublicitarioDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(PublicitarioQueryModel request, int? page = null, int? size = null, Expression<Func<Publicitario, T>> selector = null) {
			return await _publicitarioRepository.SelectAllAsync(
                filter: PublicitarioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Publicitario>(),
                selector: selector);
		}
		public async Task<T> Select<T>(PublicitarioQueryModel request, Expression<Func<Publicitario, T>> selector = null)
        {
            return (await _publicitarioRepository.FindAsync(filter: PublicitarioFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<PublicitarioDTO>> GetAll(PublicitarioQueryModel request, int? page = null, int? size = null) {
            return await _publicitarioRepository.FindAllAsync(
                filter: PublicitarioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Publicitario>(),
                selector: x => x.ProjectedAs<PublicitarioDTO>());
        }
		public async Task<IEnumerable<PublicitarioListiningDTO>> GetAllSummary(PublicitarioQueryModel request, int? page = null, int? size = null)
        {
            return await _publicitarioRepository.FindAllAsync(
                filter: PublicitarioFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Publicitario>(),
                selector: x => x.ProjectedAs<PublicitarioListiningDTO>());
        }

		public Task<ValidationResult> Create(PublicitarioDTO request, bool updateIfExists = true, PublicitarioQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(PublicitarioQueryModel request) { return await _publicitarioRepository.CountAsync(filter: PublicitarioFilters.GetFilters(request)); }
		public Task Update(PublicitarioQueryModel searchQuery, PublicitarioDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(PublicitarioQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(PublicitarioQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class PartnersAggSettingsAppService : BaseAppService, IPartnersAggSettingsAppService {	
		IPartnersAggSettingsRepository _partnersAggSettingsRepository;
		public PartnersAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IPartnersAggSettingsRepository partnersAggSettingsRepository) : base(ctx, mediator) { _partnersAggSettingsRepository = partnersAggSettingsRepository; }	
		public async Task<PartnersAggSettingsDTO> Get(PartnersAggSettingsQueryModel request) {
            return (await _partnersAggSettingsRepository.FindAsync(filter: PartnersAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<PartnersAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(PartnersAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<PartnersAggSettings, T>> selector = null) {
			return await _partnersAggSettingsRepository.SelectAllAsync(
                filter: PartnersAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PartnersAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(PartnersAggSettingsQueryModel request, Expression<Func<PartnersAggSettings, T>> selector = null)
        {
            return (await _partnersAggSettingsRepository.FindAsync(filter: PartnersAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<PartnersAggSettingsDTO>> GetAll(PartnersAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _partnersAggSettingsRepository.FindAllAsync(
                filter: PartnersAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PartnersAggSettings>(),
                selector: x => x.ProjectedAs<PartnersAggSettingsDTO>());
        }
		public async Task<IEnumerable<PartnersAggSettingsListiningDTO>> GetAllSummary(PartnersAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _partnersAggSettingsRepository.FindAllAsync(
                filter: PartnersAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PartnersAggSettings>(),
                selector: x => x.ProjectedAs<PartnersAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(PartnersAggSettingsDTO request, bool updateIfExists = true, PartnersAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(PartnersAggSettingsQueryModel request) { return await _partnersAggSettingsRepository.CountAsync(filter: PartnersAggSettingsFilters.GetFilters(request)); }
		public Task Update(PartnersAggSettingsQueryModel searchQuery, PartnersAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(PartnersAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(PartnersAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace Bravo.Partners.Application.Aggregates.UsersAgg.AppServices {
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Domain.Aggregates.UsersAgg.Repositories;
	using Domain.Aggregates.UsersAgg.Filters;
	using Domain.Aggregates.UsersAgg.Entities;
	public partial class UserAppService : BaseAppService, IUserAppService {	
		IUserRepository _userRepository;
		public UserAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUserRepository userRepository) : base(ctx, mediator) { _userRepository = userRepository; }	
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

		public async Task<int> CountAsync(UserQueryModel request) { return await _userRepository.CountAsync(filter: UserFilters.GetFilters(request)); }
	}
}
