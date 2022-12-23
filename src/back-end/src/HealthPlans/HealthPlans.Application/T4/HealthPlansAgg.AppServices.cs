
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Application.Aggregates.Common;
namespace Bravo.HealthPlans.Application.Aggregates.HealthPlansAgg.AppServices {
	using Application.DTO.Aggregates.HealthPlansAgg.Requests;
	using Domain.Aggregates.HealthPlansAgg.Queries.Models;
	using Domain.Aggregates.HealthPlansAgg.Repositories;
	using Domain.Aggregates.HealthPlansAgg.Filters;
	using Domain.Aggregates.HealthPlansAgg.Entities;
	public partial class ConvenioAppService : BaseAppService, IConvenioAppService {	
		IConvenioRepository _convenioRepository;
		public ConvenioAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IConvenioRepository convenioRepository) : base(ctx, mediator) { _convenioRepository = convenioRepository; }	
		public async Task<ConvenioDTO> Get(ConvenioQueryModel request) {
            return (await _convenioRepository.FindAsync(filter: ConvenioFilters.GetFilters(request), selector: x => x.ProjectedAs<ConvenioDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(ConvenioQueryModel request, int? page = null, int? size = null, Expression<Func<Convenio, T>> selector = null) {
			return await _convenioRepository.SelectAllAsync(
                filter: ConvenioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Convenio>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ConvenioQueryModel request, Expression<Func<Convenio, T>> selector = null)
        {
            return (await _convenioRepository.FindAsync(filter: ConvenioFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<ConvenioDTO>> GetAll(ConvenioQueryModel request, int? page = null, int? size = null) {
            return await _convenioRepository.FindAllAsync(
                filter: ConvenioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Convenio>(),
                selector: x => x.ProjectedAs<ConvenioDTO>());
        }
		public async Task<IEnumerable<ConvenioListiningDTO>> GetAllSummary(ConvenioQueryModel request, int? page = null, int? size = null)
        {
            return await _convenioRepository.FindAllAsync(
                filter: ConvenioFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Convenio>(),
                selector: x => x.ProjectedAs<ConvenioListiningDTO>());
        }

		public Task<ValidationResult> Create(ConvenioDTO request, bool updateIfExists = true, ConvenioQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(ConvenioQueryModel request) { return await _convenioRepository.CountAsync(filter: ConvenioFilters.GetFilters(request)); }
		public Task Update(ConvenioQueryModel searchQuery, ConvenioDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(ConvenioQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(ConvenioQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class HealthPlansAggSettingsAppService : BaseAppService, IHealthPlansAggSettingsAppService {	
		IHealthPlansAggSettingsRepository _healthPlansAggSettingsRepository;
		public HealthPlansAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IHealthPlansAggSettingsRepository healthPlansAggSettingsRepository) : base(ctx, mediator) { _healthPlansAggSettingsRepository = healthPlansAggSettingsRepository; }	
		public async Task<HealthPlansAggSettingsDTO> Get(HealthPlansAggSettingsQueryModel request) {
            return (await _healthPlansAggSettingsRepository.FindAsync(filter: HealthPlansAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<HealthPlansAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(HealthPlansAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<HealthPlansAggSettings, T>> selector = null) {
			return await _healthPlansAggSettingsRepository.SelectAllAsync(
                filter: HealthPlansAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<HealthPlansAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(HealthPlansAggSettingsQueryModel request, Expression<Func<HealthPlansAggSettings, T>> selector = null)
        {
            return (await _healthPlansAggSettingsRepository.FindAsync(filter: HealthPlansAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<HealthPlansAggSettingsDTO>> GetAll(HealthPlansAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _healthPlansAggSettingsRepository.FindAllAsync(
                filter: HealthPlansAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<HealthPlansAggSettings>(),
                selector: x => x.ProjectedAs<HealthPlansAggSettingsDTO>());
        }
		public async Task<IEnumerable<HealthPlansAggSettingsListiningDTO>> GetAllSummary(HealthPlansAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _healthPlansAggSettingsRepository.FindAllAsync(
                filter: HealthPlansAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<HealthPlansAggSettings>(),
                selector: x => x.ProjectedAs<HealthPlansAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(HealthPlansAggSettingsDTO request, bool updateIfExists = true, HealthPlansAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(HealthPlansAggSettingsQueryModel request) { return await _healthPlansAggSettingsRepository.CountAsync(filter: HealthPlansAggSettingsFilters.GetFilters(request)); }
		public Task Update(HealthPlansAggSettingsQueryModel searchQuery, HealthPlansAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(HealthPlansAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(HealthPlansAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class PlanoConvenioAppService : BaseAppService, IPlanoConvenioAppService {	
		IPlanoConvenioRepository _planoConvenioRepository;
		public PlanoConvenioAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IPlanoConvenioRepository planoConvenioRepository) : base(ctx, mediator) { _planoConvenioRepository = planoConvenioRepository; }	
		public async Task<PlanoConvenioDTO> Get(PlanoConvenioQueryModel request) {
            return (await _planoConvenioRepository.FindAsync(filter: PlanoConvenioFilters.GetFilters(request), selector: x => x.ProjectedAs<PlanoConvenioDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(PlanoConvenioQueryModel request, int? page = null, int? size = null, Expression<Func<PlanoConvenio, T>> selector = null) {
			return await _planoConvenioRepository.SelectAllAsync(
                filter: PlanoConvenioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PlanoConvenio>(),
                selector: selector);
		}
		public async Task<T> Select<T>(PlanoConvenioQueryModel request, Expression<Func<PlanoConvenio, T>> selector = null)
        {
            return (await _planoConvenioRepository.FindAsync(filter: PlanoConvenioFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<PlanoConvenioDTO>> GetAll(PlanoConvenioQueryModel request, int? page = null, int? size = null) {
            return await _planoConvenioRepository.FindAllAsync(
                filter: PlanoConvenioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PlanoConvenio>(),
                selector: x => x.ProjectedAs<PlanoConvenioDTO>());
        }
		public async Task<IEnumerable<PlanoConvenioListiningDTO>> GetAllSummary(PlanoConvenioQueryModel request, int? page = null, int? size = null)
        {
            return await _planoConvenioRepository.FindAllAsync(
                filter: PlanoConvenioFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<PlanoConvenio>(),
                selector: x => x.ProjectedAs<PlanoConvenioListiningDTO>());
        }

		public Task<ValidationResult> Create(PlanoConvenioDTO request, bool updateIfExists = true, PlanoConvenioQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(PlanoConvenioQueryModel request) { return await _planoConvenioRepository.CountAsync(filter: PlanoConvenioFilters.GetFilters(request)); }
		public Task Update(PlanoConvenioQueryModel searchQuery, PlanoConvenioDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(PlanoConvenioQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(PlanoConvenioQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class TipoPlanoAppService : BaseAppService, ITipoPlanoAppService {	
		ITipoPlanoRepository _tipoPlanoRepository;
		public TipoPlanoAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ITipoPlanoRepository tipoPlanoRepository) : base(ctx, mediator) { _tipoPlanoRepository = tipoPlanoRepository; }	
		public async Task<TipoPlanoDTO> Get(TipoPlanoQueryModel request) {
            return (await _tipoPlanoRepository.FindAsync(filter: TipoPlanoFilters.GetFilters(request), selector: x => x.ProjectedAs<TipoPlanoDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(TipoPlanoQueryModel request, int? page = null, int? size = null, Expression<Func<TipoPlano, T>> selector = null) {
			return await _tipoPlanoRepository.SelectAllAsync(
                filter: TipoPlanoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<TipoPlano>(),
                selector: selector);
		}
		public async Task<T> Select<T>(TipoPlanoQueryModel request, Expression<Func<TipoPlano, T>> selector = null)
        {
            return (await _tipoPlanoRepository.FindAsync(filter: TipoPlanoFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<TipoPlanoDTO>> GetAll(TipoPlanoQueryModel request, int? page = null, int? size = null) {
            return await _tipoPlanoRepository.FindAllAsync(
                filter: TipoPlanoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<TipoPlano>(),
                selector: x => x.ProjectedAs<TipoPlanoDTO>());
        }
		public async Task<IEnumerable<TipoPlanoListiningDTO>> GetAllSummary(TipoPlanoQueryModel request, int? page = null, int? size = null)
        {
            return await _tipoPlanoRepository.FindAllAsync(
                filter: TipoPlanoFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<TipoPlano>(),
                selector: x => x.ProjectedAs<TipoPlanoListiningDTO>());
        }

		public Task<ValidationResult> Create(TipoPlanoDTO request, bool updateIfExists = true, TipoPlanoQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(TipoPlanoQueryModel request) { return await _tipoPlanoRepository.CountAsync(filter: TipoPlanoFilters.GetFilters(request)); }
		public Task Update(TipoPlanoQueryModel searchQuery, TipoPlanoDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(TipoPlanoQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(TipoPlanoQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class ConvenioHorasEspeciaisAppService : BaseAppService, IConvenioHorasEspeciaisAppService {	
		IConvenioHorasEspeciaisRepository _convenioHorasEspeciaisRepository;
		public ConvenioHorasEspeciaisAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IConvenioHorasEspeciaisRepository convenioHorasEspeciaisRepository) : base(ctx, mediator) { _convenioHorasEspeciaisRepository = convenioHorasEspeciaisRepository; }	
		public async Task<ConvenioHorasEspeciaisDTO> Get(ConvenioHorasEspeciaisQueryModel request) {
            return (await _convenioHorasEspeciaisRepository.FindAsync(filter: ConvenioHorasEspeciaisFilters.GetFilters(request), selector: x => x.ProjectedAs<ConvenioHorasEspeciaisDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(ConvenioHorasEspeciaisQueryModel request, int? page = null, int? size = null, Expression<Func<ConvenioHorasEspeciais, T>> selector = null) {
			return await _convenioHorasEspeciaisRepository.SelectAllAsync(
                filter: ConvenioHorasEspeciaisFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ConvenioHorasEspeciais>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ConvenioHorasEspeciaisQueryModel request, Expression<Func<ConvenioHorasEspeciais, T>> selector = null)
        {
            return (await _convenioHorasEspeciaisRepository.FindAsync(filter: ConvenioHorasEspeciaisFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<ConvenioHorasEspeciaisDTO>> GetAll(ConvenioHorasEspeciaisQueryModel request, int? page = null, int? size = null) {
            return await _convenioHorasEspeciaisRepository.FindAllAsync(
                filter: ConvenioHorasEspeciaisFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ConvenioHorasEspeciais>(),
                selector: x => x.ProjectedAs<ConvenioHorasEspeciaisDTO>());
        }
		public async Task<IEnumerable<ConvenioHorasEspeciaisListiningDTO>> GetAllSummary(ConvenioHorasEspeciaisQueryModel request, int? page = null, int? size = null)
        {
            return await _convenioHorasEspeciaisRepository.FindAllAsync(
                filter: ConvenioHorasEspeciaisFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ConvenioHorasEspeciais>(),
                selector: x => x.ProjectedAs<ConvenioHorasEspeciaisListiningDTO>());
        }

		public Task<ValidationResult> Create(ConvenioHorasEspeciaisDTO request, bool updateIfExists = true, ConvenioHorasEspeciaisQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(ConvenioHorasEspeciaisQueryModel request) { return await _convenioHorasEspeciaisRepository.CountAsync(filter: ConvenioHorasEspeciaisFilters.GetFilters(request)); }
		public Task Update(ConvenioHorasEspeciaisQueryModel searchQuery, ConvenioHorasEspeciaisDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(ConvenioHorasEspeciaisQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(ConvenioHorasEspeciaisQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace Bravo.HealthPlans.Application.Aggregates.UsersAgg.AppServices {
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
