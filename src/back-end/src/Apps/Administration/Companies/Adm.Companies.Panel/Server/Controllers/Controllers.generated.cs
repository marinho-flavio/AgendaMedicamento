
using Microsoft.AspNetCore.Mvc;
using SES.CrossCutting.Infra.Log.Contexts;
using SES.Core.Application.DTO.Extensions;
using SES.Core.Application.Aggregates.Common;
using SES.CrossCuting.Infra.Utils.Extensions;
using global::Companies.Adm.Panel.Server.Extensions;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Commands.Responses;
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Domain.Aggregates.CompaniesAgg.Queries.Models;
	using Application.Aggregates.CompaniesAgg.AppServices;
	using Domain.Aggregates.CompaniesAgg.Entities;
	using SES.Companies.Domain.Aggregates.CompaniesAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class EmpresaController : BaseController {
 SES.Companies.Application.Aggregates.CompaniesAgg.AppServices.IEmpresaAppService _writeService; Application.Aggregates.UsersAgg.AppServices.IUserAppService _userService; 		IEmpresaAppService _empresaAppService;
		public EmpresaController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			IEmpresaAppService empresaAppService ,
			SES.Companies.Application.Aggregates.CompaniesAgg.AppServices.IEmpresaAppService writeService )
				: base(logRequestContext)
			{ 
				_empresaAppService = empresaAppService; 
				_userService = userService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] EmpresaQueryModel request) {
		    var obj = await _empresaAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] EmpresaQueryModel request) {
            return GetHttpResponseDTO.Ok(await _empresaAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] EmpresaQueryModel request, int page = 0, int size = 5) {
		    var obj = await _empresaAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] EmpresaQueryModel request, int page = 0, int size = 5) {
		    var obj = await _empresaAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] EmpresaQueryModel request, int? page = null, int? size = null) {
		    var obj = await _empresaAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Empresa>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<EmpresaDTO>> Post(SES.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.EmpresaId = (int)await _userService.Select(new Domain.Aggregates.UsersAgg.Queries.Models.UserQueryModel { IdEqual = loggedUserId }, x => x.EmpresaId);
			request.Command = new CreateEmpresaCommand(_logRequestContext, request);
			var result = await _empresaAppService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
		//public Task Delete(EmpresaQueryModel request){ return _mediator.Send(new DeleteEmpresaCommand(_logRequestContext, request)); }
		//public Task DeleteRange(EmpresaQueryModel request){ return _mediator.Send(new DeleteRangeEmpresaCommand(_logRequestContext, request)); }
		//public Task<ValidationResult> Create(EmpresaDTO request, bool updateIfExists = true, EmpresaQueryModel searchQuery = null){ return _mediator.Send(request.Command); }
		//public Task Update(EmpresaQueryModel searchQuery, EmpresaDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateEmpresaCommand(_logRequestContext, searchQuery, request, createIfNotExists)); }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class CompaniesAggSettingsController : BaseController {
 SES.Companies.Application.Aggregates.CompaniesAgg.AppServices.ICompaniesAggSettingsAppService _writeService;		ICompaniesAggSettingsAppService _companiesAggSettingsAppService;
		public CompaniesAggSettingsController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			ICompaniesAggSettingsAppService companiesAggSettingsAppService ,
			SES.Companies.Application.Aggregates.CompaniesAgg.AppServices.ICompaniesAggSettingsAppService writeService )
				: base(logRequestContext)
			{ 
				_companiesAggSettingsAppService = companiesAggSettingsAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] CompaniesAggSettingsQueryModel request) {
			request = request ?? new CompaniesAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _companiesAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] CompaniesAggSettingsQueryModel request) {
			request = request ?? new CompaniesAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
            return GetHttpResponseDTO.Ok(await _companiesAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] CompaniesAggSettingsQueryModel request, int page = 0, int size = 5) {
			request = request ?? new CompaniesAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _companiesAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] CompaniesAggSettingsQueryModel request, int page = 0, int size = 5) {
			request = request ?? new CompaniesAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _companiesAggSettingsAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] CompaniesAggSettingsQueryModel request, int? page = null, int? size = null) {
			request = request ?? new CompaniesAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _companiesAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<CompaniesAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<CompaniesAggSettingsDTO>> Post(SES.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.CompaniesAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request = request ?? new SES.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.CompaniesAggSettingsDTO();
			request.UserId = loggedUserId;
			request.Command = new CreateCompaniesAggSettingsCommand(_logRequestContext, request);
			var result = await _companiesAggSettingsAppService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
		//public Task Delete(CompaniesAggSettingsQueryModel request){ return _mediator.Send(new DeleteCompaniesAggSettingsCommand(_logRequestContext, request)); }
		//public Task DeleteRange(CompaniesAggSettingsQueryModel request){ return _mediator.Send(new DeleteRangeCompaniesAggSettingsCommand(_logRequestContext, request)); }
		//public Task<ValidationResult> Create(CompaniesAggSettingsDTO request, bool updateIfExists = true, CompaniesAggSettingsQueryModel searchQuery = null){ return _mediator.Send(request.Command); }
		//public Task Update(CompaniesAggSettingsQueryModel searchQuery, CompaniesAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateCompaniesAggSettingsCommand(_logRequestContext, searchQuery, request, createIfNotExists)); }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class GrupoEmpresaController : BaseController {
 SES.Companies.Application.Aggregates.CompaniesAgg.AppServices.IGrupoEmpresaAppService _writeService;		IGrupoEmpresaAppService _grupoEmpresaAppService;
		public GrupoEmpresaController(
			            ILogRequestContext logRequestContext,
			IGrupoEmpresaAppService grupoEmpresaAppService ,
			SES.Companies.Application.Aggregates.CompaniesAgg.AppServices.IGrupoEmpresaAppService writeService )
				: base(logRequestContext)
			{ 
				_grupoEmpresaAppService = grupoEmpresaAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] GrupoEmpresaQueryModel request) {
		    var obj = await _grupoEmpresaAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] GrupoEmpresaQueryModel request) {
            return GetHttpResponseDTO.Ok(await _grupoEmpresaAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] GrupoEmpresaQueryModel request, int page = 0, int size = 5) {
		    var obj = await _grupoEmpresaAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] GrupoEmpresaQueryModel request, int page = 0, int size = 5) {
		    var obj = await _grupoEmpresaAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] GrupoEmpresaQueryModel request, int? page = null, int? size = null) {
		    var obj = await _grupoEmpresaAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<GrupoEmpresa>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<GrupoEmpresaDTO>> Post(SES.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.GrupoEmpresaDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateGrupoEmpresaCommand(_logRequestContext, request);
			var result = await _grupoEmpresaAppService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
		//public Task Delete(GrupoEmpresaQueryModel request){ return _mediator.Send(new DeleteGrupoEmpresaCommand(_logRequestContext, request)); }
		//public Task DeleteRange(GrupoEmpresaQueryModel request){ return _mediator.Send(new DeleteRangeGrupoEmpresaCommand(_logRequestContext, request)); }
		//public Task<ValidationResult> Create(GrupoEmpresaDTO request, bool updateIfExists = true, GrupoEmpresaQueryModel searchQuery = null){ return _mediator.Send(request.Command); }
		//public Task Update(GrupoEmpresaQueryModel searchQuery, GrupoEmpresaDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateGrupoEmpresaCommand(_logRequestContext, searchQuery, request, createIfNotExists)); }
	}
}
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Domain.Aggregates.ProfessionalsAgg.Queries.Models;
	using Application.Aggregates.ProfessionalsAgg.AppServices;
	using Domain.Aggregates.ProfessionalsAgg.Entities;
	using SES.Professionals.Domain.Aggregates.ProfessionalsAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class ProfissionalConfiguracaoController : BaseController {
 SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.IProfissionalConfiguracaoAppService _writeService;		IProfissionalConfiguracaoAppService _profissionalConfiguracaoAppService;
		public ProfissionalConfiguracaoController(
			            ILogRequestContext logRequestContext,
			IProfissionalConfiguracaoAppService profissionalConfiguracaoAppService ,
			SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.IProfissionalConfiguracaoAppService writeService )
				: base(logRequestContext)
			{ 
				_profissionalConfiguracaoAppService = profissionalConfiguracaoAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] ProfissionalConfiguracaoQueryModel request) {
		    var obj = await _profissionalConfiguracaoAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] ProfissionalConfiguracaoQueryModel request) {
            return GetHttpResponseDTO.Ok(await _profissionalConfiguracaoAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] ProfissionalConfiguracaoQueryModel request, int page = 0, int size = 5) {
		    var obj = await _profissionalConfiguracaoAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] ProfissionalConfiguracaoQueryModel request, int page = 0, int size = 5) {
		    var obj = await _profissionalConfiguracaoAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null) {
		    var obj = await _profissionalConfiguracaoAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<ProfissionalConfiguracao>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<ProfissionalConfiguracaoDTO>> Post(SES.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalConfiguracaoDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateProfissionalConfiguracaoCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class FuncionarioController : BaseController {
 SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.IFuncionarioAppService _writeService; Application.Aggregates.UsersAgg.AppServices.IUserAppService _userService; 		IFuncionarioAppService _funcionarioAppService;
		public FuncionarioController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			IFuncionarioAppService funcionarioAppService ,
			SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.IFuncionarioAppService writeService )
				: base(logRequestContext)
			{ 
				_funcionarioAppService = funcionarioAppService; 
				_userService = userService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] FuncionarioQueryModel request) {
		    var obj = await _funcionarioAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] FuncionarioQueryModel request) {
            return GetHttpResponseDTO.Ok(await _funcionarioAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] FuncionarioQueryModel request, int page = 0, int size = 5) {
		    var obj = await _funcionarioAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] FuncionarioQueryModel request, int page = 0, int size = 5) {
		    var obj = await _funcionarioAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] FuncionarioQueryModel request, int? page = null, int? size = null) {
		    var obj = await _funcionarioAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Funcionario>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<FuncionarioDTO>> Post(SES.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.FuncionarioDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.EmpresaId = (int)await _userService.Select(new Domain.Aggregates.UsersAgg.Queries.Models.UserQueryModel { IdEqual = loggedUserId }, x => x.EmpresaId);
			request.Command = new CreateFuncionarioCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class ProfissionalController : BaseController {
 SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.IProfissionalAppService _writeService; Application.Aggregates.UsersAgg.AppServices.IUserAppService _userService; 		IProfissionalAppService _profissionalAppService;
		public ProfissionalController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			IProfissionalAppService profissionalAppService ,
			SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.IProfissionalAppService writeService )
				: base(logRequestContext)
			{ 
				_profissionalAppService = profissionalAppService; 
				_userService = userService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] ProfissionalQueryModel request) {
		    var obj = await _profissionalAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] ProfissionalQueryModel request) {
            return GetHttpResponseDTO.Ok(await _profissionalAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] ProfissionalQueryModel request, int page = 0, int size = 5) {
		    var obj = await _profissionalAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] ProfissionalQueryModel request, int page = 0, int size = 5) {
		    var obj = await _profissionalAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] ProfissionalQueryModel request, int? page = null, int? size = null) {
		    var obj = await _profissionalAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Profissional>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<ProfissionalDTO>> Post(SES.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.EmpresaId = (int)await _userService.Select(new Domain.Aggregates.UsersAgg.Queries.Models.UserQueryModel { IdEqual = loggedUserId }, x => x.EmpresaId);
			request.Command = new CreateProfissionalCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class CboController : BaseController {
 SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.ICboAppService _writeService;		ICboAppService _cboAppService;
		public CboController(
			            ILogRequestContext logRequestContext,
			ICboAppService cboAppService ,
			SES.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices.ICboAppService writeService )
				: base(logRequestContext)
			{ 
				_cboAppService = cboAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] CboQueryModel request) {
		    var obj = await _cboAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] CboQueryModel request) {
            return GetHttpResponseDTO.Ok(await _cboAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] CboQueryModel request, int page = 0, int size = 5) {
		    var obj = await _cboAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] CboQueryModel request, int page = 0, int size = 5) {
		    var obj = await _cboAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] CboQueryModel request, int? page = null, int? size = null) {
		    var obj = await _cboAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Cbo>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<CboDTO>> Post(SES.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests.CboDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateCboCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.PatientsAgg.Requests;
	using Domain.Aggregates.PatientsAgg.Queries.Models;
	using Application.Aggregates.PatientsAgg.AppServices;
	using Domain.Aggregates.PatientsAgg.Entities;
	using SES.Patients.Domain.Aggregates.PatientsAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class PacienteController : BaseController {
 SES.Patients.Application.Aggregates.PatientsAgg.AppServices.IPacienteAppService _writeService;		IPacienteAppService _pacienteAppService;
		public PacienteController(
			            ILogRequestContext logRequestContext,
			IPacienteAppService pacienteAppService ,
			SES.Patients.Application.Aggregates.PatientsAgg.AppServices.IPacienteAppService writeService )
				: base(logRequestContext)
			{ 
				_pacienteAppService = pacienteAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] PacienteQueryModel request) {
		    var obj = await _pacienteAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] PacienteQueryModel request) {
            return GetHttpResponseDTO.Ok(await _pacienteAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] PacienteQueryModel request, int page = 0, int size = 5) {
		    var obj = await _pacienteAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] PacienteQueryModel request, int page = 0, int size = 5) {
		    var obj = await _pacienteAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] PacienteQueryModel request, int? page = null, int? size = null) {
		    var obj = await _pacienteAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Paciente>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<PacienteDTO>> Post(SES.Patients.Application.DTO.Aggregates.PatientsAgg.Requests.PacienteDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreatePacienteCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Application.Aggregates.SchedulingsAgg.AppServices;
	using Domain.Aggregates.SchedulingsAgg.Entities;
	using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class AgendaExameController : BaseController {
 SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.IAgendaExameAppService _writeService;		IAgendaExameAppService _agendaExameAppService;
		public AgendaExameController(
			            ILogRequestContext logRequestContext,
			IAgendaExameAppService agendaExameAppService ,
			SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.IAgendaExameAppService writeService )
				: base(logRequestContext)
			{ 
				_agendaExameAppService = agendaExameAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] AgendaExameQueryModel request) {
		    var obj = await _agendaExameAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] AgendaExameQueryModel request) {
            return GetHttpResponseDTO.Ok(await _agendaExameAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] AgendaExameQueryModel request, int page = 0, int size = 5) {
		    var obj = await _agendaExameAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] AgendaExameQueryModel request, int page = 0, int size = 5) {
		    var obj = await _agendaExameAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] AgendaExameQueryModel request, int? page = null, int? size = null) {
		    var obj = await _agendaExameAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<AgendaExame>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<AgendaExameDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests.AgendaExameDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateAgendaExameCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class FeriadoController : BaseController {
 SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.IFeriadoAppService _writeService; Application.Aggregates.UsersAgg.AppServices.IUserAppService _userService; 		IFeriadoAppService _feriadoAppService;
		public FeriadoController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			IFeriadoAppService feriadoAppService ,
			SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.IFeriadoAppService writeService )
				: base(logRequestContext)
			{ 
				_feriadoAppService = feriadoAppService; 
				_userService = userService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] FeriadoQueryModel request) {
			request = request ?? new FeriadoQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _feriadoAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] FeriadoQueryModel request) {
			request = request ?? new FeriadoQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
            return GetHttpResponseDTO.Ok(await _feriadoAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] FeriadoQueryModel request, int page = 0, int size = 5) {
			request = request ?? new FeriadoQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _feriadoAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] FeriadoQueryModel request, int page = 0, int size = 5) {
			request = request ?? new FeriadoQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _feriadoAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] FeriadoQueryModel request, int? page = null, int? size = null) {
			request = request ?? new FeriadoQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _feriadoAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Feriado>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<FeriadoDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests.FeriadoDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request = request ?? new SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests.FeriadoDTO();
			request.UserId = loggedUserId;
			request.EmpresaId = (int)await _userService.Select(new Domain.Aggregates.UsersAgg.Queries.Models.UserQueryModel { IdEqual = loggedUserId }, x => x.EmpresaId);
			request.Command = new CreateFeriadoCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class AgendaProfissionalController : BaseController {
 SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.IAgendaProfissionalAppService _writeService;		IAgendaProfissionalAppService _agendaProfissionalAppService;
		public AgendaProfissionalController(
			            ILogRequestContext logRequestContext,
			IAgendaProfissionalAppService agendaProfissionalAppService ,
			SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.IAgendaProfissionalAppService writeService )
				: base(logRequestContext)
			{ 
				_agendaProfissionalAppService = agendaProfissionalAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] AgendaProfissionalQueryModel request) {
		    var obj = await _agendaProfissionalAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] AgendaProfissionalQueryModel request) {
            return GetHttpResponseDTO.Ok(await _agendaProfissionalAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] AgendaProfissionalQueryModel request, int page = 0, int size = 5) {
		    var obj = await _agendaProfissionalAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] AgendaProfissionalQueryModel request, int page = 0, int size = 5) {
		    var obj = await _agendaProfissionalAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] AgendaProfissionalQueryModel request, int? page = null, int? size = null) {
		    var obj = await _agendaProfissionalAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<AgendaProfissional>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<AgendaProfissionalDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests.AgendaProfissionalDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateAgendaProfissionalCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.HealthPlansAgg.Requests;
	using Domain.Aggregates.HealthPlansAgg.Queries.Models;
	using Application.Aggregates.HealthPlansAgg.AppServices;
	using Domain.Aggregates.HealthPlansAgg.Entities;
	using SES.HealthPlans.Domain.Aggregates.HealthPlansAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class ConvenioController : BaseController {
 SES.HealthPlans.Application.Aggregates.HealthPlansAgg.AppServices.IConvenioAppService _writeService;		IConvenioAppService _convenioAppService;
		public ConvenioController(
			            ILogRequestContext logRequestContext,
			IConvenioAppService convenioAppService ,
			SES.HealthPlans.Application.Aggregates.HealthPlansAgg.AppServices.IConvenioAppService writeService )
				: base(logRequestContext)
			{ 
				_convenioAppService = convenioAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] ConvenioQueryModel request) {
		    var obj = await _convenioAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] ConvenioQueryModel request) {
            return GetHttpResponseDTO.Ok(await _convenioAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] ConvenioQueryModel request, int page = 0, int size = 5) {
		    var obj = await _convenioAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] ConvenioQueryModel request, int page = 0, int size = 5) {
		    var obj = await _convenioAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] ConvenioQueryModel request, int? page = null, int? size = null) {
		    var obj = await _convenioAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Convenio>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<ConvenioDTO>> Post(SES.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.ConvenioDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateConvenioCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Application.Aggregates.UsersAgg.AppServices;
	using Domain.Aggregates.UsersAgg.Entities;
	using SES.Users.Domain.Aggregates.UsersAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserController : BaseController {
 Application.Aggregates.UsersAgg.AppServices.IUserAppService _userService; 		IUserAppService _userAppService;
		public UserController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			IUserAppService userAppService  )
				: base(logRequestContext)
			{ 
				_userAppService = userAppService; 
				_userService = userService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UserQueryModel request) {
		    var obj = await _userAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UserQueryModel request, int? page = null, int? size = null) {
		    var obj = await _userAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<User>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
	}
}
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Domain.Aggregates.PartnersAgg.Queries.Models;
	using Application.Aggregates.PartnersAgg.AppServices;
	using Domain.Aggregates.PartnersAgg.Entities;
	using SES.Partners.Domain.Aggregates.PartnersAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class FornecedorController : BaseController {
 SES.Partners.Application.Aggregates.PartnersAgg.AppServices.IFornecedorAppService _writeService;		IFornecedorAppService _fornecedorAppService;
		public FornecedorController(
			            ILogRequestContext logRequestContext,
			IFornecedorAppService fornecedorAppService ,
			SES.Partners.Application.Aggregates.PartnersAgg.AppServices.IFornecedorAppService writeService )
				: base(logRequestContext)
			{ 
				_fornecedorAppService = fornecedorAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] FornecedorQueryModel request) {
		    var obj = await _fornecedorAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] FornecedorQueryModel request) {
            return GetHttpResponseDTO.Ok(await _fornecedorAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] FornecedorQueryModel request, int page = 0, int size = 5) {
		    var obj = await _fornecedorAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] FornecedorQueryModel request, int page = 0, int size = 5) {
		    var obj = await _fornecedorAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] FornecedorQueryModel request, int? page = null, int? size = null) {
		    var obj = await _fornecedorAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Fornecedor>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<FornecedorDTO>> Post(SES.Partners.Application.DTO.Aggregates.PartnersAgg.Requests.FornecedorDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateFornecedorCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class PublicitarioController : BaseController {
 SES.Partners.Application.Aggregates.PartnersAgg.AppServices.IPublicitarioAppService _writeService;		IPublicitarioAppService _publicitarioAppService;
		public PublicitarioController(
			            ILogRequestContext logRequestContext,
			IPublicitarioAppService publicitarioAppService ,
			SES.Partners.Application.Aggregates.PartnersAgg.AppServices.IPublicitarioAppService writeService )
				: base(logRequestContext)
			{ 
				_publicitarioAppService = publicitarioAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] PublicitarioQueryModel request) {
		    var obj = await _publicitarioAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] PublicitarioQueryModel request) {
            return GetHttpResponseDTO.Ok(await _publicitarioAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] PublicitarioQueryModel request, int page = 0, int size = 5) {
		    var obj = await _publicitarioAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] PublicitarioQueryModel request, int page = 0, int size = 5) {
		    var obj = await _publicitarioAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] PublicitarioQueryModel request, int? page = null, int? size = null) {
		    var obj = await _publicitarioAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Publicitario>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<PublicitarioDTO>> Post(SES.Partners.Application.DTO.Aggregates.PartnersAgg.Requests.PublicitarioDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreatePublicitarioCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Companies.Adm.Panel.Server.Controllers {
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Domain.Aggregates.AddressesAgg.Queries.Models;
	using Application.Aggregates.AddressesAgg.AppServices;
	using Domain.Aggregates.AddressesAgg.Entities;
	using SES.Addresses.Domain.Aggregates.AddressesAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class EnderecoController : BaseController {
		IEnderecoAppService _enderecoAppService;
		public EnderecoController(
			            ILogRequestContext logRequestContext,
			IEnderecoAppService enderecoAppService  )
				: base(logRequestContext)
			{ 
				_enderecoAppService = enderecoAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] EnderecoQueryModel request) {
		    var obj = await _enderecoAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] EnderecoQueryModel request, int page = 0, int size = 5) {
		    var obj = await _enderecoAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] EnderecoQueryModel request, int? page = null, int? size = null) {
		    var obj = await _enderecoAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Endereco>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
	}
}
