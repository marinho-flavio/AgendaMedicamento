
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using SES.CrossCuting.Infra.Utils.Extensions;
using SES.Core.Application.DTO.Extensions;
using SES.Core.Application.Aggregates.Common;
namespace SES.Schedulings.Application.Aggregates.CompaniesAgg.AppServices {
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
namespace SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices {
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Domain.Aggregates.SchedulingsAgg.Repositories;
	using Domain.Aggregates.SchedulingsAgg.Filters;
	using Domain.Aggregates.SchedulingsAgg.Entities;
	public partial class SchedulingsAggSettingsAppService : BaseAppService, ISchedulingsAggSettingsAppService {	
		ISchedulingsAggSettingsRepository _schedulingsAggSettingsRepository;
		public SchedulingsAggSettingsAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ISchedulingsAggSettingsRepository schedulingsAggSettingsRepository) : base(ctx, mediator) { _schedulingsAggSettingsRepository = schedulingsAggSettingsRepository; }	
		public async Task<SchedulingsAggSettingsDTO> Get(SchedulingsAggSettingsQueryModel request) {
            return (await _schedulingsAggSettingsRepository.FindAsync(filter: SchedulingsAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<SchedulingsAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<SchedulingsAggSettings, T>> selector = null) {
			return await _schedulingsAggSettingsRepository.SelectAllAsync(
                filter: SchedulingsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SchedulingsAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(SchedulingsAggSettingsQueryModel request, Expression<Func<SchedulingsAggSettings, T>> selector = null)
        {
            return (await _schedulingsAggSettingsRepository.FindAsync(filter: SchedulingsAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<SchedulingsAggSettingsDTO>> GetAll(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _schedulingsAggSettingsRepository.FindAllAsync(
                filter: SchedulingsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SchedulingsAggSettings>(),
                selector: x => x.ProjectedAs<SchedulingsAggSettingsDTO>());
        }
		public async Task<IEnumerable<SchedulingsAggSettingsListiningDTO>> GetAllSummary(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _schedulingsAggSettingsRepository.FindAllAsync(
                filter: SchedulingsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SchedulingsAggSettings>(),
                selector: x => x.ProjectedAs<SchedulingsAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(SchedulingsAggSettingsDTO request, bool updateIfExists = true, SchedulingsAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(SchedulingsAggSettingsQueryModel request) { return await _schedulingsAggSettingsRepository.CountAsync(filter: SchedulingsAggSettingsFilters.GetFilters(request)); }
		public Task Update(SchedulingsAggSettingsQueryModel searchQuery, SchedulingsAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(SchedulingsAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(SchedulingsAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class FeriadoAppService : BaseAppService, IFeriadoAppService {	
		IFeriadoRepository _feriadoRepository;
		public FeriadoAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IFeriadoRepository feriadoRepository) : base(ctx, mediator) { _feriadoRepository = feriadoRepository; }	
		public async Task<FeriadoDTO> Get(FeriadoQueryModel request) {
            return (await _feriadoRepository.FindAsync(filter: FeriadoFilters.GetFilters(request), selector: x => x.ProjectedAs<FeriadoDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(FeriadoQueryModel request, int? page = null, int? size = null, Expression<Func<Feriado, T>> selector = null) {
			return await _feriadoRepository.SelectAllAsync(
                filter: FeriadoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Feriado>(),
                selector: selector);
		}
		public async Task<T> Select<T>(FeriadoQueryModel request, Expression<Func<Feriado, T>> selector = null)
        {
            return (await _feriadoRepository.FindAsync(filter: FeriadoFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<FeriadoDTO>> GetAll(FeriadoQueryModel request, int? page = null, int? size = null) {
            return await _feriadoRepository.FindAllAsync(
                filter: FeriadoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Feriado>(),
                selector: x => x.ProjectedAs<FeriadoDTO>());
        }
		public async Task<IEnumerable<FeriadoListiningDTO>> GetAllSummary(FeriadoQueryModel request, int? page = null, int? size = null)
        {
            return await _feriadoRepository.FindAllAsync(
                filter: FeriadoFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Feriado>(),
                selector: x => x.ProjectedAs<FeriadoListiningDTO>());
        }

		public Task<ValidationResult> Create(FeriadoDTO request, bool updateIfExists = true, FeriadoQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(FeriadoQueryModel request) { return await _feriadoRepository.CountAsync(filter: FeriadoFilters.GetFilters(request)); }
		public Task Update(FeriadoQueryModel searchQuery, FeriadoDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(FeriadoQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(FeriadoQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace SES.Schedulings.Application.Aggregates.ProfessionalsAgg.AppServices {
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Domain.Aggregates.ProfessionalsAgg.Queries.Models;
	using Domain.Aggregates.ProfessionalsAgg.Repositories;
	using Domain.Aggregates.ProfessionalsAgg.Filters;
	using Domain.Aggregates.ProfessionalsAgg.Entities;
	public partial class ProfissionalAppService : BaseAppService, IProfissionalAppService {	
		IProfissionalRepository _profissionalRepository;
		public ProfissionalAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IProfissionalRepository profissionalRepository) : base(ctx, mediator) { _profissionalRepository = profissionalRepository; }	
		public async Task<ProfissionalDTO> Get(ProfissionalQueryModel request) {
            return (await _profissionalRepository.FindAsync(filter: ProfissionalFilters.GetFilters(request), selector: x => x.ProjectedAs<ProfissionalDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(ProfissionalQueryModel request, int? page = null, int? size = null, Expression<Func<Profissional, T>> selector = null) {
			return await _profissionalRepository.SelectAllAsync(
                filter: ProfissionalFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Profissional>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ProfissionalQueryModel request, Expression<Func<Profissional, T>> selector = null)
        {
            return (await _profissionalRepository.FindAsync(filter: ProfissionalFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<ProfissionalDTO>> GetAll(ProfissionalQueryModel request, int? page = null, int? size = null) {
            return await _profissionalRepository.FindAllAsync(
                filter: ProfissionalFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Profissional>(),
                selector: x => x.ProjectedAs<ProfissionalDTO>());
        }
		public async Task<IEnumerable<ProfissionalListiningDTO>> GetAllSummary(ProfissionalQueryModel request, int? page = null, int? size = null)
        {
            return await _profissionalRepository.FindAllAsync(
                filter: ProfissionalFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Profissional>(),
                selector: x => x.ProjectedAs<ProfissionalListiningDTO>());
        }

		public Task<ValidationResult> Create(ProfissionalDTO request, bool updateIfExists = true, ProfissionalQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(ProfissionalQueryModel request) { return await _profissionalRepository.CountAsync(filter: ProfissionalFilters.GetFilters(request)); }
		public Task Update(ProfissionalQueryModel searchQuery, ProfissionalDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(ProfissionalQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(ProfissionalQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace SES.Schedulings.Application.Aggregates.UsersAgg.AppServices {
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Domain.Aggregates.UsersAgg.Repositories;
	using Domain.Aggregates.UsersAgg.Filters;
	using Domain.Aggregates.UsersAgg.Entities;
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
namespace SES.Schedulings.Application.Aggregates.PartnersAgg.AppServices {
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Domain.Aggregates.PartnersAgg.Queries.Models;
	using Domain.Aggregates.PartnersAgg.Repositories;
	using Domain.Aggregates.PartnersAgg.Filters;
	using Domain.Aggregates.PartnersAgg.Entities;
	public partial class FornecedorAppService : BaseAppService, IFornecedorAppService {	
		IFornecedorRepository _fornecedorRepository;
		public FornecedorAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IFornecedorRepository fornecedorRepository) : base(ctx, mediator) { _fornecedorRepository = fornecedorRepository; }	
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
		public PublicitarioAppService(IMediator mediator, SES.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IPublicitarioRepository publicitarioRepository) : base(ctx, mediator) { _publicitarioRepository = publicitarioRepository; }	
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
}
