
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Application.Aggregates.Common;
namespace Bravo.Patients.Application.Aggregates.PatientsAgg.AppServices {
	using Application.DTO.Aggregates.PatientsAgg.Requests;
	using Domain.Aggregates.PatientsAgg.Queries.Models;
	using Domain.Aggregates.PatientsAgg.Repositories;
	using Domain.Aggregates.PatientsAgg.Filters;
	using Domain.Aggregates.PatientsAgg.Entities;
	public partial class PacienteAppService : BaseAppService, IPacienteAppService {	
		IPacienteRepository _pacienteRepository;
		public PacienteAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IPacienteRepository pacienteRepository) : base(ctx, mediator) { _pacienteRepository = pacienteRepository; }	
		public async Task<PacienteDTO> Get(PacienteQueryModel request) {
            return (await _pacienteRepository.FindAsync(filter: PacienteFilters.GetFilters(request), selector: x => x.ProjectedAs<PacienteDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(PacienteQueryModel request, int? page = null, int? size = null, Expression<Func<Paciente, T>> selector = null) {
			return await _pacienteRepository.SelectAllAsync(
                filter: PacienteFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Paciente>(),
                selector: selector);
		}
		public async Task<T> Select<T>(PacienteQueryModel request, Expression<Func<Paciente, T>> selector = null)
        {
            return (await _pacienteRepository.FindAsync(filter: PacienteFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<PacienteDTO>> GetAll(PacienteQueryModel request, int? page = null, int? size = null) {
            return await _pacienteRepository.FindAllAsync(
                filter: PacienteFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Paciente>(),
                selector: x => x.ProjectedAs<PacienteDTO>());
        }
		public async Task<IEnumerable<PacienteListiningDTO>> GetAllSummary(PacienteQueryModel request, int? page = null, int? size = null)
        {
            return await _pacienteRepository.FindAllAsync(
                filter: PacienteFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Paciente>(),
                selector: x => x.ProjectedAs<PacienteListiningDTO>());
        }

		public Task<ValidationResult> Create(PacienteDTO request, bool updateIfExists = true, PacienteQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(PacienteQueryModel request) { return await _pacienteRepository.CountAsync(filter: PacienteFilters.GetFilters(request)); }
		public Task Update(PacienteQueryModel searchQuery, PacienteDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(PacienteQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(PacienteQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class PatientsAggSettingsAppService : BaseAppService, IPatientsAggSettingsAppService {	
		IPatientsAggSettingsRepository _patientsAggSettingsRepository;
		public PatientsAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IPatientsAggSettingsRepository patientsAggSettingsRepository) : base(ctx, mediator) { _patientsAggSettingsRepository = patientsAggSettingsRepository; }	
		public async Task<PatientsAggSettingsDTO> Get(PatientsAggSettingsQueryModel request) {
            return (await _patientsAggSettingsRepository.FindAsync(filter: PatientsAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<PatientsAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(PatientsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<PatientsAggSettings, T>> selector = null) {
			return await _patientsAggSettingsRepository.SelectAllAsync(
                filter: PatientsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PatientsAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(PatientsAggSettingsQueryModel request, Expression<Func<PatientsAggSettings, T>> selector = null)
        {
            return (await _patientsAggSettingsRepository.FindAsync(filter: PatientsAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<PatientsAggSettingsDTO>> GetAll(PatientsAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _patientsAggSettingsRepository.FindAllAsync(
                filter: PatientsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PatientsAggSettings>(),
                selector: x => x.ProjectedAs<PatientsAggSettingsDTO>());
        }
		public async Task<IEnumerable<PatientsAggSettingsListiningDTO>> GetAllSummary(PatientsAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _patientsAggSettingsRepository.FindAllAsync(
                filter: PatientsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PatientsAggSettings>(),
                selector: x => x.ProjectedAs<PatientsAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(PatientsAggSettingsDTO request, bool updateIfExists = true, PatientsAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(PatientsAggSettingsQueryModel request) { return await _patientsAggSettingsRepository.CountAsync(filter: PatientsAggSettingsFilters.GetFilters(request)); }
		public Task Update(PatientsAggSettingsQueryModel searchQuery, PatientsAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(PatientsAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(PatientsAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace Bravo.Patients.Application.Aggregates.UsersAgg.AppServices {
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
