
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Application.Aggregates.Common;
namespace Bravo.ClinicalProcedures.Application.Aggregates.UsersAgg.AppServices {
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
namespace Bravo.ClinicalProcedures.Application.Aggregates.ClinicalProceduresAgg.AppServices {
	using Application.DTO.Aggregates.ClinicalProceduresAgg.Requests;
	using Domain.Aggregates.ClinicalProceduresAgg.Queries.Models;
	using Domain.Aggregates.ClinicalProceduresAgg.Repositories;
	using Domain.Aggregates.ClinicalProceduresAgg.Filters;
	using Domain.Aggregates.ClinicalProceduresAgg.Entities;
	public partial class ClinicalProceduresAggSettingsAppService : BaseAppService, IClinicalProceduresAggSettingsAppService {	
		IClinicalProceduresAggSettingsRepository _clinicalProceduresAggSettingsRepository;
		public ClinicalProceduresAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IClinicalProceduresAggSettingsRepository clinicalProceduresAggSettingsRepository) : base(ctx, mediator) { _clinicalProceduresAggSettingsRepository = clinicalProceduresAggSettingsRepository; }	
		public async Task<ClinicalProceduresAggSettingsDTO> Get(ClinicalProceduresAggSettingsQueryModel request) {
            return (await _clinicalProceduresAggSettingsRepository.FindAsync(filter: ClinicalProceduresAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<ClinicalProceduresAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(ClinicalProceduresAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<ClinicalProceduresAggSettings, T>> selector = null) {
			return await _clinicalProceduresAggSettingsRepository.SelectAllAsync(
                filter: ClinicalProceduresAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ClinicalProceduresAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ClinicalProceduresAggSettingsQueryModel request, Expression<Func<ClinicalProceduresAggSettings, T>> selector = null)
        {
            return (await _clinicalProceduresAggSettingsRepository.FindAsync(filter: ClinicalProceduresAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<ClinicalProceduresAggSettingsDTO>> GetAll(ClinicalProceduresAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _clinicalProceduresAggSettingsRepository.FindAllAsync(
                filter: ClinicalProceduresAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ClinicalProceduresAggSettings>(),
                selector: x => x.ProjectedAs<ClinicalProceduresAggSettingsDTO>());
        }
		public async Task<IEnumerable<ClinicalProceduresAggSettingsListiningDTO>> GetAllSummary(ClinicalProceduresAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _clinicalProceduresAggSettingsRepository.FindAllAsync(
                filter: ClinicalProceduresAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ClinicalProceduresAggSettings>(),
                selector: x => x.ProjectedAs<ClinicalProceduresAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(ClinicalProceduresAggSettingsDTO request, bool updateIfExists = true, ClinicalProceduresAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(ClinicalProceduresAggSettingsQueryModel request) { return await _clinicalProceduresAggSettingsRepository.CountAsync(filter: ClinicalProceduresAggSettingsFilters.GetFilters(request)); }
		public Task Update(ClinicalProceduresAggSettingsQueryModel searchQuery, ClinicalProceduresAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(ClinicalProceduresAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(ClinicalProceduresAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
}
