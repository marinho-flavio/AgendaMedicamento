
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Application.Aggregates.Common;
namespace Bravo.Professionals.Application.Aggregates.SchedulingsAgg.AppServices {
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Domain.Aggregates.SchedulingsAgg.Repositories;
	using Domain.Aggregates.SchedulingsAgg.Filters;
	using Domain.Aggregates.SchedulingsAgg.Entities;
	public partial class SchedulingsAggSettingsAppService : BaseAppService, ISchedulingsAggSettingsAppService {	
		ISchedulingsAggSettingsRepository _schedulingsAggSettingsRepository;
		public SchedulingsAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ISchedulingsAggSettingsRepository schedulingsAggSettingsRepository) : base(ctx, mediator) { _schedulingsAggSettingsRepository = schedulingsAggSettingsRepository; }	
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
	public partial class AgendaExameAppService : BaseAppService, IAgendaExameAppService {	
		IAgendaExameRepository _agendaExameRepository;
		public AgendaExameAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAgendaExameRepository agendaExameRepository) : base(ctx, mediator) { _agendaExameRepository = agendaExameRepository; }	
		public async Task<AgendaExameDTO> Get(AgendaExameQueryModel request) {
            return (await _agendaExameRepository.FindAsync(filter: AgendaExameFilters.GetFilters(request), selector: x => x.ProjectedAs<AgendaExameDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(AgendaExameQueryModel request, int? page = null, int? size = null, Expression<Func<AgendaExame, T>> selector = null) {
			return await _agendaExameRepository.SelectAllAsync(
                filter: AgendaExameFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaExame>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AgendaExameQueryModel request, Expression<Func<AgendaExame, T>> selector = null)
        {
            return (await _agendaExameRepository.FindAsync(filter: AgendaExameFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<AgendaExameDTO>> GetAll(AgendaExameQueryModel request, int? page = null, int? size = null) {
            return await _agendaExameRepository.FindAllAsync(
                filter: AgendaExameFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaExame>(),
                selector: x => x.ProjectedAs<AgendaExameDTO>());
        }
		public async Task<IEnumerable<AgendaExameListiningDTO>> GetAllSummary(AgendaExameQueryModel request, int? page = null, int? size = null)
        {
            return await _agendaExameRepository.FindAllAsync(
                filter: AgendaExameFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaExame>(),
                selector: x => x.ProjectedAs<AgendaExameListiningDTO>());
        }

		public Task<ValidationResult> Create(AgendaExameDTO request, bool updateIfExists = true, AgendaExameQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(AgendaExameQueryModel request) { return await _agendaExameRepository.CountAsync(filter: AgendaExameFilters.GetFilters(request)); }
		public Task Update(AgendaExameQueryModel searchQuery, AgendaExameDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(AgendaExameQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(AgendaExameQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class AgendaSalaAppService : BaseAppService, IAgendaSalaAppService {	
		IAgendaSalaRepository _agendaSalaRepository;
		public AgendaSalaAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAgendaSalaRepository agendaSalaRepository) : base(ctx, mediator) { _agendaSalaRepository = agendaSalaRepository; }	
		public async Task<AgendaSalaDTO> Get(AgendaSalaQueryModel request) {
            return (await _agendaSalaRepository.FindAsync(filter: AgendaSalaFilters.GetFilters(request), selector: x => x.ProjectedAs<AgendaSalaDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(AgendaSalaQueryModel request, int? page = null, int? size = null, Expression<Func<AgendaSala, T>> selector = null) {
			return await _agendaSalaRepository.SelectAllAsync(
                filter: AgendaSalaFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaSala>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AgendaSalaQueryModel request, Expression<Func<AgendaSala, T>> selector = null)
        {
            return (await _agendaSalaRepository.FindAsync(filter: AgendaSalaFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<AgendaSalaDTO>> GetAll(AgendaSalaQueryModel request, int? page = null, int? size = null) {
            return await _agendaSalaRepository.FindAllAsync(
                filter: AgendaSalaFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaSala>(),
                selector: x => x.ProjectedAs<AgendaSalaDTO>());
        }
		public async Task<IEnumerable<AgendaSalaListiningDTO>> GetAllSummary(AgendaSalaQueryModel request, int? page = null, int? size = null)
        {
            return await _agendaSalaRepository.FindAllAsync(
                filter: AgendaSalaFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaSala>(),
                selector: x => x.ProjectedAs<AgendaSalaListiningDTO>());
        }

		public Task<ValidationResult> Create(AgendaSalaDTO request, bool updateIfExists = true, AgendaSalaQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(AgendaSalaQueryModel request) { return await _agendaSalaRepository.CountAsync(filter: AgendaSalaFilters.GetFilters(request)); }
		public Task Update(AgendaSalaQueryModel searchQuery, AgendaSalaDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(AgendaSalaQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(AgendaSalaQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class FeriadoAppService : BaseAppService, IFeriadoAppService {	
		IFeriadoRepository _feriadoRepository;
		public FeriadoAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IFeriadoRepository feriadoRepository) : base(ctx, mediator) { _feriadoRepository = feriadoRepository; }	
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
	public partial class AgendaProfissionalAppService : BaseAppService, IAgendaProfissionalAppService {	
		IAgendaProfissionalRepository _agendaProfissionalRepository;
		public AgendaProfissionalAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAgendaProfissionalRepository agendaProfissionalRepository) : base(ctx, mediator) { _agendaProfissionalRepository = agendaProfissionalRepository; }	
		public async Task<AgendaProfissionalDTO> Get(AgendaProfissionalQueryModel request) {
            return (await _agendaProfissionalRepository.FindAsync(filter: AgendaProfissionalFilters.GetFilters(request), selector: x => x.ProjectedAs<AgendaProfissionalDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(AgendaProfissionalQueryModel request, int? page = null, int? size = null, Expression<Func<AgendaProfissional, T>> selector = null) {
			return await _agendaProfissionalRepository.SelectAllAsync(
                filter: AgendaProfissionalFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaProfissional>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AgendaProfissionalQueryModel request, Expression<Func<AgendaProfissional, T>> selector = null)
        {
            return (await _agendaProfissionalRepository.FindAsync(filter: AgendaProfissionalFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<AgendaProfissionalDTO>> GetAll(AgendaProfissionalQueryModel request, int? page = null, int? size = null) {
            return await _agendaProfissionalRepository.FindAllAsync(
                filter: AgendaProfissionalFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaProfissional>(),
                selector: x => x.ProjectedAs<AgendaProfissionalDTO>());
        }
		public async Task<IEnumerable<AgendaProfissionalListiningDTO>> GetAllSummary(AgendaProfissionalQueryModel request, int? page = null, int? size = null)
        {
            return await _agendaProfissionalRepository.FindAllAsync(
                filter: AgendaProfissionalFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AgendaProfissional>(),
                selector: x => x.ProjectedAs<AgendaProfissionalListiningDTO>());
        }

		public Task<ValidationResult> Create(AgendaProfissionalDTO request, bool updateIfExists = true, AgendaProfissionalQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(AgendaProfissionalQueryModel request) { return await _agendaProfissionalRepository.CountAsync(filter: AgendaProfissionalFilters.GetFilters(request)); }
		public Task Update(AgendaProfissionalQueryModel searchQuery, AgendaProfissionalDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(AgendaProfissionalQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(AgendaProfissionalQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace Bravo.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices {
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Domain.Aggregates.ProfessionalsAgg.Queries.Models;
	using Domain.Aggregates.ProfessionalsAgg.Repositories;
	using Domain.Aggregates.ProfessionalsAgg.Filters;
	using Domain.Aggregates.ProfessionalsAgg.Entities;
	public partial class ProfissionalConfiguracaoAppService : BaseAppService, IProfissionalConfiguracaoAppService {	
		IProfissionalConfiguracaoRepository _profissionalConfiguracaoRepository;
		public ProfissionalConfiguracaoAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IProfissionalConfiguracaoRepository profissionalConfiguracaoRepository) : base(ctx, mediator) { _profissionalConfiguracaoRepository = profissionalConfiguracaoRepository; }	
		public async Task<ProfissionalConfiguracaoDTO> Get(ProfissionalConfiguracaoQueryModel request) {
            return (await _profissionalConfiguracaoRepository.FindAsync(filter: ProfissionalConfiguracaoFilters.GetFilters(request), selector: x => x.ProjectedAs<ProfissionalConfiguracaoDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null, Expression<Func<ProfissionalConfiguracao, T>> selector = null) {
			return await _profissionalConfiguracaoRepository.SelectAllAsync(
                filter: ProfissionalConfiguracaoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ProfissionalConfiguracao>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ProfissionalConfiguracaoQueryModel request, Expression<Func<ProfissionalConfiguracao, T>> selector = null)
        {
            return (await _profissionalConfiguracaoRepository.FindAsync(filter: ProfissionalConfiguracaoFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<ProfissionalConfiguracaoDTO>> GetAll(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null) {
            return await _profissionalConfiguracaoRepository.FindAllAsync(
                filter: ProfissionalConfiguracaoFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ProfissionalConfiguracao>(),
                selector: x => x.ProjectedAs<ProfissionalConfiguracaoDTO>());
        }
		public async Task<IEnumerable<ProfissionalConfiguracaoListiningDTO>> GetAllSummary(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null)
        {
            return await _profissionalConfiguracaoRepository.FindAllAsync(
                filter: ProfissionalConfiguracaoFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ProfissionalConfiguracao>(),
                selector: x => x.ProjectedAs<ProfissionalConfiguracaoListiningDTO>());
        }

		public Task<ValidationResult> Create(ProfissionalConfiguracaoDTO request, bool updateIfExists = true, ProfissionalConfiguracaoQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(ProfissionalConfiguracaoQueryModel request) { return await _profissionalConfiguracaoRepository.CountAsync(filter: ProfissionalConfiguracaoFilters.GetFilters(request)); }
		public Task Update(ProfissionalConfiguracaoQueryModel searchQuery, ProfissionalConfiguracaoDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(ProfissionalConfiguracaoQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(ProfissionalConfiguracaoQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class FuncionarioAppService : BaseAppService, IFuncionarioAppService {	
		IFuncionarioRepository _funcionarioRepository;
		public FuncionarioAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IFuncionarioRepository funcionarioRepository) : base(ctx, mediator) { _funcionarioRepository = funcionarioRepository; }	
		public async Task<FuncionarioDTO> Get(FuncionarioQueryModel request) {
            return (await _funcionarioRepository.FindAsync(filter: FuncionarioFilters.GetFilters(request), selector: x => x.ProjectedAs<FuncionarioDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(FuncionarioQueryModel request, int? page = null, int? size = null, Expression<Func<Funcionario, T>> selector = null) {
			return await _funcionarioRepository.SelectAllAsync(
                filter: FuncionarioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Funcionario>(),
                selector: selector);
		}
		public async Task<T> Select<T>(FuncionarioQueryModel request, Expression<Func<Funcionario, T>> selector = null)
        {
            return (await _funcionarioRepository.FindAsync(filter: FuncionarioFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<FuncionarioDTO>> GetAll(FuncionarioQueryModel request, int? page = null, int? size = null) {
            return await _funcionarioRepository.FindAllAsync(
                filter: FuncionarioFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Funcionario>(),
                selector: x => x.ProjectedAs<FuncionarioDTO>());
        }
		public async Task<IEnumerable<FuncionarioListiningDTO>> GetAllSummary(FuncionarioQueryModel request, int? page = null, int? size = null)
        {
            return await _funcionarioRepository.FindAllAsync(
                filter: FuncionarioFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Funcionario>(),
                selector: x => x.ProjectedAs<FuncionarioListiningDTO>());
        }

		public Task<ValidationResult> Create(FuncionarioDTO request, bool updateIfExists = true, FuncionarioQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(FuncionarioQueryModel request) { return await _funcionarioRepository.CountAsync(filter: FuncionarioFilters.GetFilters(request)); }
		public Task Update(FuncionarioQueryModel searchQuery, FuncionarioDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(FuncionarioQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(FuncionarioQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class ProfissionalAppService : BaseAppService, IProfissionalAppService {	
		IProfissionalRepository _profissionalRepository;
		public ProfissionalAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IProfissionalRepository profissionalRepository) : base(ctx, mediator) { _profissionalRepository = profissionalRepository; }	
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
	public partial class ProfessionalsAggSettingsAppService : BaseAppService, IProfessionalsAggSettingsAppService {	
		IProfessionalsAggSettingsRepository _professionalsAggSettingsRepository;
		public ProfessionalsAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IProfessionalsAggSettingsRepository professionalsAggSettingsRepository) : base(ctx, mediator) { _professionalsAggSettingsRepository = professionalsAggSettingsRepository; }	
		public async Task<ProfessionalsAggSettingsDTO> Get(ProfessionalsAggSettingsQueryModel request) {
            return (await _professionalsAggSettingsRepository.FindAsync(filter: ProfessionalsAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<ProfessionalsAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(ProfessionalsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<ProfessionalsAggSettings, T>> selector = null) {
			return await _professionalsAggSettingsRepository.SelectAllAsync(
                filter: ProfessionalsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ProfessionalsAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ProfessionalsAggSettingsQueryModel request, Expression<Func<ProfessionalsAggSettings, T>> selector = null)
        {
            return (await _professionalsAggSettingsRepository.FindAsync(filter: ProfessionalsAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<ProfessionalsAggSettingsDTO>> GetAll(ProfessionalsAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _professionalsAggSettingsRepository.FindAllAsync(
                filter: ProfessionalsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ProfessionalsAggSettings>(),
                selector: x => x.ProjectedAs<ProfessionalsAggSettingsDTO>());
        }
		public async Task<IEnumerable<ProfessionalsAggSettingsListiningDTO>> GetAllSummary(ProfessionalsAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _professionalsAggSettingsRepository.FindAllAsync(
                filter: ProfessionalsAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ProfessionalsAggSettings>(),
                selector: x => x.ProjectedAs<ProfessionalsAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(ProfessionalsAggSettingsDTO request, bool updateIfExists = true, ProfessionalsAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(ProfessionalsAggSettingsQueryModel request) { return await _professionalsAggSettingsRepository.CountAsync(filter: ProfessionalsAggSettingsFilters.GetFilters(request)); }
		public Task Update(ProfessionalsAggSettingsQueryModel searchQuery, ProfessionalsAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(ProfessionalsAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(ProfessionalsAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class CboAppService : BaseAppService, ICboAppService {	
		ICboRepository _cboRepository;
		public CboAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ICboRepository cboRepository) : base(ctx, mediator) { _cboRepository = cboRepository; }	
		public async Task<CboDTO> Get(CboQueryModel request) {
            return (await _cboRepository.FindAsync(filter: CboFilters.GetFilters(request), selector: x => x.ProjectedAs<CboDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(CboQueryModel request, int? page = null, int? size = null, Expression<Func<Cbo, T>> selector = null) {
			return await _cboRepository.SelectAllAsync(
                filter: CboFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Cbo>(),
                selector: selector);
		}
		public async Task<T> Select<T>(CboQueryModel request, Expression<Func<Cbo, T>> selector = null)
        {
            return (await _cboRepository.FindAsync(filter: CboFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<CboDTO>> GetAll(CboQueryModel request, int? page = null, int? size = null) {
            return await _cboRepository.FindAllAsync(
                filter: CboFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Cbo>(),
                selector: x => x.ProjectedAs<CboDTO>());
        }
		public async Task<IEnumerable<CboListiningDTO>> GetAllSummary(CboQueryModel request, int? page = null, int? size = null)
        {
            return await _cboRepository.FindAllAsync(
                filter: CboFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Cbo>(),
                selector: x => x.ProjectedAs<CboListiningDTO>());
        }

		public Task<ValidationResult> Create(CboDTO request, bool updateIfExists = true, CboQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(CboQueryModel request) { return await _cboRepository.CountAsync(filter: CboFilters.GetFilters(request)); }
		public Task Update(CboQueryModel searchQuery, CboDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(CboQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(CboQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace Bravo.Professionals.Application.Aggregates.UsersAgg.AppServices {
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
