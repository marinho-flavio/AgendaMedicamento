
using MediatR;
using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Application.Aggregates.Common;
namespace Bravo.Companies.Application.Aggregates.CompaniesAgg.AppServices {
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Domain.Aggregates.CompaniesAgg.Queries.Models;
	using Domain.Aggregates.CompaniesAgg.Repositories;
	using Domain.Aggregates.CompaniesAgg.Filters;
	using Domain.Aggregates.CompaniesAgg.Entities;
	public partial class EmpresaAppService : BaseAppService, IEmpresaAppService {	
		IEmpresaRepository _empresaRepository;
		public EmpresaAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IEmpresaRepository empresaRepository) : base(ctx, mediator) { _empresaRepository = empresaRepository; }	
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
	public partial class CompaniesAggSettingsAppService : BaseAppService, ICompaniesAggSettingsAppService {	
		ICompaniesAggSettingsRepository _companiesAggSettingsRepository;
		public CompaniesAggSettingsAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ICompaniesAggSettingsRepository companiesAggSettingsRepository) : base(ctx, mediator) { _companiesAggSettingsRepository = companiesAggSettingsRepository; }	
		public async Task<CompaniesAggSettingsDTO> Get(CompaniesAggSettingsQueryModel request) {
            return (await _companiesAggSettingsRepository.FindAsync(filter: CompaniesAggSettingsFilters.GetFilters(request), selector: x => x.ProjectedAs<CompaniesAggSettingsDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(CompaniesAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<CompaniesAggSettings, T>> selector = null) {
			return await _companiesAggSettingsRepository.SelectAllAsync(
                filter: CompaniesAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<CompaniesAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(CompaniesAggSettingsQueryModel request, Expression<Func<CompaniesAggSettings, T>> selector = null)
        {
            return (await _companiesAggSettingsRepository.FindAsync(filter: CompaniesAggSettingsFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<CompaniesAggSettingsDTO>> GetAll(CompaniesAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _companiesAggSettingsRepository.FindAllAsync(
                filter: CompaniesAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<CompaniesAggSettings>(),
                selector: x => x.ProjectedAs<CompaniesAggSettingsDTO>());
        }
		public async Task<IEnumerable<CompaniesAggSettingsListiningDTO>> GetAllSummary(CompaniesAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _companiesAggSettingsRepository.FindAllAsync(
                filter: CompaniesAggSettingsFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<CompaniesAggSettings>(),
                selector: x => x.ProjectedAs<CompaniesAggSettingsListiningDTO>());
        }

		public Task<ValidationResult> Create(CompaniesAggSettingsDTO request, bool updateIfExists = true, CompaniesAggSettingsQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(CompaniesAggSettingsQueryModel request) { return await _companiesAggSettingsRepository.CountAsync(filter: CompaniesAggSettingsFilters.GetFilters(request)); }
		public Task Update(CompaniesAggSettingsQueryModel searchQuery, CompaniesAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(CompaniesAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(CompaniesAggSettingsQueryModel request){ return _mediator.Send(request.Command); }
	}
	public partial class GrupoEmpresaAppService : BaseAppService, IGrupoEmpresaAppService {	
		IGrupoEmpresaRepository _grupoEmpresaRepository;
		public GrupoEmpresaAppService(IMediator mediator, Bravo.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IGrupoEmpresaRepository grupoEmpresaRepository) : base(ctx, mediator) { _grupoEmpresaRepository = grupoEmpresaRepository; }	
		public async Task<GrupoEmpresaDTO> Get(GrupoEmpresaQueryModel request) {
            return (await _grupoEmpresaRepository.FindAsync(filter: GrupoEmpresaFilters.GetFilters(request), selector: x => x.ProjectedAs<GrupoEmpresaDTO>()));
        }
		public async Task<IEnumerable<T>> GetAll<T>(GrupoEmpresaQueryModel request, int? page = null, int? size = null, Expression<Func<GrupoEmpresa, T>> selector = null) {
			return await _grupoEmpresaRepository.SelectAllAsync(
                filter: GrupoEmpresaFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<GrupoEmpresa>(),
                selector: selector);
		}
		public async Task<T> Select<T>(GrupoEmpresaQueryModel request, Expression<Func<GrupoEmpresa, T>> selector = null)
        {
            return (await _grupoEmpresaRepository.FindAsync(filter: GrupoEmpresaFilters.GetFilters(request), selector: selector));
        }
        public async Task<IEnumerable<GrupoEmpresaDTO>> GetAll(GrupoEmpresaQueryModel request, int? page = null, int? size = null) {
            return await _grupoEmpresaRepository.FindAllAsync(
                filter: GrupoEmpresaFilters.GetFilters(request),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<GrupoEmpresa>(),
                selector: x => x.ProjectedAs<GrupoEmpresaDTO>());
        }
		public async Task<IEnumerable<GrupoEmpresaListiningDTO>> GetAllSummary(GrupoEmpresaQueryModel request, int? page = null, int? size = null)
        {
            return await _grupoEmpresaRepository.FindAllAsync(
                filter: GrupoEmpresaFilters.GetFilters(request),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<GrupoEmpresa>(),
                selector: x => x.ProjectedAs<GrupoEmpresaListiningDTO>());
        }

		public Task<ValidationResult> Create(GrupoEmpresaDTO request, bool updateIfExists = true, GrupoEmpresaQueryModel searchQuery = null) { return _mediator.Send(request.Command); }
		public async Task<int> CountAsync(GrupoEmpresaQueryModel request) { return await _grupoEmpresaRepository.CountAsync(filter: GrupoEmpresaFilters.GetFilters(request)); }
		public Task Update(GrupoEmpresaQueryModel searchQuery, GrupoEmpresaDTO request, bool createIfNotExists = true) { return _mediator.Send(request.Command); }
		public Task DeleteRange(GrupoEmpresaQueryModel request){ return _mediator.Send(request.Command); }
		public Task Delete(GrupoEmpresaQueryModel request){ return _mediator.Send(request.Command); }
	}
}
namespace Bravo.Companies.Application.Aggregates.ProfessionalsAgg.AppServices {
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
namespace Bravo.Companies.Application.Aggregates.PatientsAgg.AppServices {
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
}
namespace Bravo.Companies.Application.Aggregates.SchedulingsAgg.AppServices {
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Domain.Aggregates.SchedulingsAgg.Repositories;
	using Domain.Aggregates.SchedulingsAgg.Filters;
	using Domain.Aggregates.SchedulingsAgg.Entities;
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
namespace Bravo.Companies.Application.Aggregates.HealthPlansAgg.AppServices {
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
}
namespace Bravo.Companies.Application.Aggregates.UsersAgg.AppServices {
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
namespace Bravo.Companies.Application.Aggregates.PartnersAgg.AppServices {
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
}
namespace Bravo.Companies.Application.Aggregates.AddressesAgg.AppServices {
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

		public async Task<int> CountAsync(EnderecoQueryModel request) { return await _enderecoRepository.CountAsync(filter: EnderecoFilters.GetFilters(request)); }
	}
}
