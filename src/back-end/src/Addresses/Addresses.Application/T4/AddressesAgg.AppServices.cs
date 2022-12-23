
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Application.Aggregates.Common;
namespace Bravo.Addresses.Application.Aggregates.AddressesAgg.AppServices {
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Domain.Aggregates.AddressesAgg.Queries.Models;
	using Domain.Aggregates.AddressesAgg.Repositories;
	using Domain.Aggregates.AddressesAgg.Filters;
	using Domain.Aggregates.AddressesAgg.Entities;
	public partial class EnderecoAppService : BaseAppService, IEnderecoAppService {	
		IEnderecoRepository _enderecoRepository;
		public EnderecoAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IEnderecoRepository enderecoRepository) : base(ctx, mediator) { _enderecoRepository = enderecoRepository; }	
		public async Task<EnderecoDTO> Get(EnderecoQueryModel request) {
            return (await _enderecoRepository.FindAsync(filter: EnderecoFilters.GetFilters(request), selector: x => x.ProjectedAs<EnderecoDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(EnderecoQueryModel request, int? page = null, int? size = null, Expression<Func<Endereco, T>> selector = null) {
			return await _enderecoRepository.SelectAllAsync(
                filter: EnderecoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Endereco>(),
                selector: selector);
		}
		public async Task<T> Select<T>(EnderecoQueryModel request, Expression<Func<Endereco, T>> selector = null)
        {
            return (await _enderecoRepository.FindAsync(filter: EnderecoFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<EnderecoDTO>> GetAll(EnderecoQueryModel request, int? page = null, int? size = null) {
            return await _enderecoRepository.FindAllAsync(
                filter: EnderecoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Endereco>(),
                selector: x => x.ProjectedAs<EnderecoDTO>());
        }
		public async Task<IEnumerable<EnderecoListiningDTO>> GetAllSummary(EnderecoQueryModel request, int? page = null, int? size = null)
        {
            return await _enderecoRepository.FindAllAsync(
                filter: EnderecoFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Endereco>(),
                selector: x => x.ProjectedAs<EnderecoListiningDTO>());
        }

		public Task<ValidationResult> Create(EnderecoDTO request, bool updateIfExists = true, EnderecoQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(EnderecoQueryModel request) { return await _enderecoRepository.CountAsync(filter: EnderecoFilters.GetFilters(request)); }
		public Task Update(EnderecoQueryModel searchQuery, EnderecoDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(EnderecoQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(EnderecoQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class AddressesAggSettingsAppService : BaseAppService, IAddressesAggSettingsAppService {	
		IAddressesAggSettingsRepository _addressesAggSettingsRepository;
		public AddressesAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAddressesAggSettingsRepository addressesAggSettingsRepository) : base(ctx, mediator) { _addressesAggSettingsRepository = addressesAggSettingsRepository; }	
		public async Task<AddressesAggSettingsDTO> Get(AddressesAggSettingsQueryModel request) {
            return (await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<AddressesAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(AddressesAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<AddressesAggSettings, T>> selector = null) {
			return await _addressesAggSettingsRepository.SelectAllAsync(
                filter: AddressesAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AddressesAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AddressesAggSettingsQueryModel request, Expression<Func<AddressesAggSettings, T>> selector = null)
        {
            return (await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<AddressesAggSettingsDTO>> GetAll(AddressesAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _addressesAggSettingsRepository.FindAllAsync(
                filter: AddressesAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AddressesAggSettings>(),
                selector: x => x.ProjectedAs<AddressesAggSettingsDTO>());
        }
		public async Task<IEnumerable<AddressesAggSettingsListiningDTO>> GetAllSummary(AddressesAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _addressesAggSettingsRepository.FindAllAsync(
                filter: AddressesAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AddressesAggSettings>(),
                selector: x => x.ProjectedAs<AddressesAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(AddressesAggSettingsDTO request, bool updateIfExists = true, AddressesAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(AddressesAggSettingsQueryModel request) { return await _addressesAggSettingsRepository.CountAsync(filter: AddressesAggSettingsFilters.GetFilters(request)); }
		public Task Update(AddressesAggSettingsQueryModel searchQuery, AddressesAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(AddressesAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(AddressesAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace Bravo.Addresses.Application.Aggregates.UsersAgg.AppServices {
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
