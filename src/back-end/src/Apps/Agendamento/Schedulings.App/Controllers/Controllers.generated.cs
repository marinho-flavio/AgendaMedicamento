
using Microsoft.AspNetCore.Mvc;
using SES.CrossCutting.Infra.Log.Contexts;
using SES.Core.Application.DTO.Extensions;
using SES.Core.Application.Aggregates.Common;
using SES.CrossCuting.Infra.Utils.Extensions;
using global::Schedulings.App.Extensions;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Commands.Responses;
namespace SES.Schedulings.App.Controllers {
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Domain.Aggregates.CompaniesAgg.Queries.Models;
	using Application.Aggregates.CompaniesAgg.AppServices;
	using Domain.Aggregates.CompaniesAgg.Entities;
	using SES.Schedulings.Domain.Aggregates.CompaniesAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class EmpresaController : BaseController {
 SES.Schedulings.Application.Aggregates.CompaniesAgg.AppServices.IEmpresaAppService _writeService;		IEmpresaAppService _empresaAppService;
		public EmpresaController(
			            ILogRequestContext logRequestContext,
			IEmpresaAppService empresaAppService ,
			SES.Schedulings.Application.Aggregates.CompaniesAgg.AppServices.IEmpresaAppService writeService )
				: base(logRequestContext)
			{ 
				_empresaAppService = empresaAppService; 
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
		public async Task<ActionResult<EmpresaDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateEmpresaCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Schedulings.App.Controllers {
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Application.Aggregates.SchedulingsAgg.AppServices;
	using Domain.Aggregates.SchedulingsAgg.Entities;
	using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class SchedulingsAggSettingsController : BaseController {
 SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.ISchedulingsAggSettingsAppService _writeService;		ISchedulingsAggSettingsAppService _schedulingsAggSettingsAppService;
		public SchedulingsAggSettingsController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			ISchedulingsAggSettingsAppService schedulingsAggSettingsAppService ,
			SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices.ISchedulingsAggSettingsAppService writeService )
				: base(logRequestContext)
			{ 
				_schedulingsAggSettingsAppService = schedulingsAggSettingsAppService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] SchedulingsAggSettingsQueryModel request) {
			request = request ?? new SchedulingsAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _schedulingsAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] SchedulingsAggSettingsQueryModel request) {
			request = request ?? new SchedulingsAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
            return GetHttpResponseDTO.Ok(await _schedulingsAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] SchedulingsAggSettingsQueryModel request, int page = 0, int size = 5) {
			request = request ?? new SchedulingsAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _schedulingsAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] SchedulingsAggSettingsQueryModel request, int page = 0, int size = 5) {
			request = request ?? new SchedulingsAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _schedulingsAggSettingsAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null) {
			request = request ?? new SchedulingsAggSettingsQueryModel();
			request.UserIdEqual = User.GetLoggedInUserId<string>();
		    var obj = await _schedulingsAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<SchedulingsAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<SchedulingsAggSettingsDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests.SchedulingsAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request = request ?? new SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests.SchedulingsAggSettingsDTO();
			request.UserId = loggedUserId;
			request.Command = new CreateSchedulingsAggSettingsCommand(_logRequestContext, request);
			var result = await _schedulingsAggSettingsAppService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
		//public Task Delete(SchedulingsAggSettingsQueryModel request){ return _mediator.Send(new DeleteSchedulingsAggSettingsCommand(_logRequestContext, request)); }
		//public Task DeleteRange(SchedulingsAggSettingsQueryModel request){ return _mediator.Send(new DeleteRangeSchedulingsAggSettingsCommand(_logRequestContext, request)); }
		//public Task<ValidationResult> Create(SchedulingsAggSettingsDTO request, bool updateIfExists = true, SchedulingsAggSettingsQueryModel searchQuery = null){ return _mediator.Send(request.Command); }
		//public Task Update(SchedulingsAggSettingsQueryModel searchQuery, SchedulingsAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateSchedulingsAggSettingsCommand(_logRequestContext, searchQuery, request, createIfNotExists)); }
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
			var result = await _feriadoAppService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
		//public Task Delete(FeriadoQueryModel request){ return _mediator.Send(new DeleteFeriadoCommand(_logRequestContext, request)); }
		//public Task DeleteRange(FeriadoQueryModel request){ return _mediator.Send(new DeleteRangeFeriadoCommand(_logRequestContext, request)); }
		//public Task<ValidationResult> Create(FeriadoDTO request, bool updateIfExists = true, FeriadoQueryModel searchQuery = null){ return _mediator.Send(request.Command); }
		//public Task Update(FeriadoQueryModel searchQuery, FeriadoDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateFeriadoCommand(_logRequestContext, searchQuery, request, createIfNotExists)); }
	}
}
namespace SES.Schedulings.App.Controllers {
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Domain.Aggregates.ProfessionalsAgg.Queries.Models;
	using Application.Aggregates.ProfessionalsAgg.AppServices;
	using Domain.Aggregates.ProfessionalsAgg.Entities;
	using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class ProfissionalController : BaseController {
 SES.Schedulings.Application.Aggregates.ProfessionalsAgg.AppServices.IProfissionalAppService _writeService;		IProfissionalAppService _profissionalAppService;
		public ProfissionalController(
			            ILogRequestContext logRequestContext,
			IProfissionalAppService profissionalAppService ,
			SES.Schedulings.Application.Aggregates.ProfessionalsAgg.AppServices.IProfissionalAppService writeService )
				: base(logRequestContext)
			{ 
				_profissionalAppService = profissionalAppService; 
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
		public async Task<ActionResult<ProfissionalDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.ProfessionalsAgg.Requests.ProfissionalDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateProfissionalCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Schedulings.App.Controllers {
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Application.Aggregates.UsersAgg.AppServices;
	using Domain.Aggregates.UsersAgg.Entities;
	using SES.Schedulings.Domain.Aggregates.UsersAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserController : BaseController {
 SES.Schedulings.Application.Aggregates.UsersAgg.AppServices.IUserAppService _writeService; Application.Aggregates.UsersAgg.AppServices.IUserAppService _userService; 		IUserAppService _userAppService;
		public UserController(
			 Application.Aggregates.UsersAgg.AppServices.IUserAppService userService,             ILogRequestContext logRequestContext,
			IUserAppService userAppService ,
			SES.Schedulings.Application.Aggregates.UsersAgg.AppServices.IUserAppService writeService )
				: base(logRequestContext)
			{ 
				_userAppService = userAppService; 
				_userService = userService; 
				_writeService = writeService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UserQueryModel request) {
		    var obj = await _userAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] UserQueryModel request) {
            return GetHttpResponseDTO.Ok(await _userAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UserQueryModel request, int? page = null, int? size = null) {
		    var obj = await _userAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<User>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<ActionResult<UserDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.UsersAgg.Requests.UserDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.EmpresaId = (int)await _userService.Select(new Domain.Aggregates.UsersAgg.Queries.Models.UserQueryModel { IdEqual = loggedUserId }, x => x.EmpresaId);
			request.Command = new CreateUserCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
namespace SES.Schedulings.App.Controllers {
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Domain.Aggregates.PartnersAgg.Queries.Models;
	using Application.Aggregates.PartnersAgg.AppServices;
	using Domain.Aggregates.PartnersAgg.Entities;
	using SES.Schedulings.Domain.Aggregates.PartnersAgg.CommandModels;
 
	[ApiController]
    [Route("api/[controller]")]
	public partial class FornecedorController : BaseController {
 SES.Schedulings.Application.Aggregates.PartnersAgg.AppServices.IFornecedorAppService _writeService;		IFornecedorAppService _fornecedorAppService;
		public FornecedorController(
			            ILogRequestContext logRequestContext,
			IFornecedorAppService fornecedorAppService ,
			SES.Schedulings.Application.Aggregates.PartnersAgg.AppServices.IFornecedorAppService writeService )
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
		public async Task<ActionResult<FornecedorDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.PartnersAgg.Requests.FornecedorDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreateFornecedorCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class PublicitarioController : BaseController {
 SES.Schedulings.Application.Aggregates.PartnersAgg.AppServices.IPublicitarioAppService _writeService;		IPublicitarioAppService _publicitarioAppService;
		public PublicitarioController(
			            ILogRequestContext logRequestContext,
			IPublicitarioAppService publicitarioAppService ,
			SES.Schedulings.Application.Aggregates.PartnersAgg.AppServices.IPublicitarioAppService writeService )
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
		public async Task<ActionResult<PublicitarioDTO>> Post(SES.Schedulings.Application.DTO.Aggregates.PartnersAgg.Requests.PublicitarioDTO request) {
			var loggedUserId = User.GetLoggedInUserId<string>();
			request.Command = new CreatePublicitarioCommand(_logRequestContext, request);
			var result = await _writeService.Create(request);
            return result.IsValid ? Ok(GetHttpResponseDTO.Ok()) : BadRequest(ModelState);
		}
	}
}
