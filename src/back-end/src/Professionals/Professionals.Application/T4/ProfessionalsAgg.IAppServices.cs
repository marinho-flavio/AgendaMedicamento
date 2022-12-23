using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.Core.Domain.Seedwork.Specification;
namespace Bravo.Professionals.Application.Aggregates.SchedulingsAgg.AppServices {
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	public partial interface ISchedulingsAggSettingsAppService {	
		public Task<SchedulingsAggSettingsDTO> Get(SchedulingsAggSettingsQueryModel request);
		public Task<int> CountAsync(SchedulingsAggSettingsQueryModel request);
		public Task<IEnumerable<SchedulingsAggSettingsDTO>> GetAll(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(SchedulingsAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.SchedulingsAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.SchedulingsAggSettings, T>> selector = null);
		public Task<IEnumerable<SchedulingsAggSettingsListiningDTO>> GetAllSummary(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null);

	}
	public partial interface IAgendaExameAppService {	
		public Task<AgendaExameDTO> Get(AgendaExameQueryModel request);
		public Task<int> CountAsync(AgendaExameQueryModel request);
		public Task<IEnumerable<AgendaExameDTO>> GetAll(AgendaExameQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AgendaExameQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaExame, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AgendaExameQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaExame, T>> selector = null);
		public Task<IEnumerable<AgendaExameListiningDTO>> GetAllSummary(AgendaExameQueryModel request, int? page = null, int? size = null);

	}
	public partial interface IAgendaSalaAppService {	
		public Task<AgendaSalaDTO> Get(AgendaSalaQueryModel request);
		public Task<int> CountAsync(AgendaSalaQueryModel request);
		public Task<IEnumerable<AgendaSalaDTO>> GetAll(AgendaSalaQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AgendaSalaQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaSala, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AgendaSalaQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaSala, T>> selector = null);
		public Task<IEnumerable<AgendaSalaListiningDTO>> GetAllSummary(AgendaSalaQueryModel request, int? page = null, int? size = null);

	}
	public partial interface IFeriadoAppService {	
		public Task<FeriadoDTO> Get(FeriadoQueryModel request);
		public Task<int> CountAsync(FeriadoQueryModel request);
		public Task<IEnumerable<FeriadoDTO>> GetAll(FeriadoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(FeriadoQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.Feriado, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(FeriadoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.Feriado, T>> selector = null);
		public Task<IEnumerable<FeriadoListiningDTO>> GetAllSummary(FeriadoQueryModel request, int? page = null, int? size = null);

	}
	public partial interface IAgendaProfissionalAppService {	
		public Task<AgendaProfissionalDTO> Get(AgendaProfissionalQueryModel request);
		public Task<int> CountAsync(AgendaProfissionalQueryModel request);
		public Task<IEnumerable<AgendaProfissionalDTO>> GetAll(AgendaProfissionalQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AgendaProfissionalQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaProfissional, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AgendaProfissionalQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaProfissional, T>> selector = null);
		public Task<IEnumerable<AgendaProfissionalListiningDTO>> GetAllSummary(AgendaProfissionalQueryModel request, int? page = null, int? size = null);

	}
}
namespace Bravo.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices {
	using Domain.Aggregates.ProfessionalsAgg.Queries.Models;
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	public partial interface IProfissionalConfiguracaoAppService {	
		public Task<ProfissionalConfiguracaoDTO> Get(ProfissionalConfiguracaoQueryModel request);
		public Task<int> CountAsync(ProfissionalConfiguracaoQueryModel request);
		public Task<IEnumerable<ProfissionalConfiguracaoDTO>> GetAll(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ProfissionalConfiguracaoQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.ProfissionalConfiguracao, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.ProfissionalConfiguracao, T>> selector = null);
		public Task<IEnumerable<ProfissionalConfiguracaoListiningDTO>> GetAllSummary(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(ProfissionalConfiguracaoDTO request, bool updateIfExists = true, ProfissionalConfiguracaoQueryModel searchQuery = null);
		public Task Delete(ProfissionalConfiguracaoQueryModel request);
		public Task Update(ProfissionalConfiguracaoQueryModel searchQuery, ProfissionalConfiguracaoDTO request, bool createIfNotExists = true);
		public Task DeleteRange(ProfissionalConfiguracaoQueryModel request);
	}
	public partial interface IFuncionarioAppService {	
		public Task<FuncionarioDTO> Get(FuncionarioQueryModel request);
		public Task<int> CountAsync(FuncionarioQueryModel request);
		public Task<IEnumerable<FuncionarioDTO>> GetAll(FuncionarioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(FuncionarioQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Funcionario, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(FuncionarioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Funcionario, T>> selector = null);
		public Task<IEnumerable<FuncionarioListiningDTO>> GetAllSummary(FuncionarioQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(FuncionarioDTO request, bool updateIfExists = true, FuncionarioQueryModel searchQuery = null);
		public Task Delete(FuncionarioQueryModel request);
		public Task Update(FuncionarioQueryModel searchQuery, FuncionarioDTO request, bool createIfNotExists = true);
		public Task DeleteRange(FuncionarioQueryModel request);
	}
	public partial interface IProfissionalAppService {	
		public Task<ProfissionalDTO> Get(ProfissionalQueryModel request);
		public Task<int> CountAsync(ProfissionalQueryModel request);
		public Task<IEnumerable<ProfissionalDTO>> GetAll(ProfissionalQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ProfissionalQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Profissional, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ProfissionalQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Profissional, T>> selector = null);
		public Task<IEnumerable<ProfissionalListiningDTO>> GetAllSummary(ProfissionalQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(ProfissionalDTO request, bool updateIfExists = true, ProfissionalQueryModel searchQuery = null);
		public Task Delete(ProfissionalQueryModel request);
		public Task Update(ProfissionalQueryModel searchQuery, ProfissionalDTO request, bool createIfNotExists = true);
		public Task DeleteRange(ProfissionalQueryModel request);
	}
	public partial interface IProfessionalsAggSettingsAppService {	
		public Task<ProfessionalsAggSettingsDTO> Get(ProfessionalsAggSettingsQueryModel request);
		public Task<int> CountAsync(ProfessionalsAggSettingsQueryModel request);
		public Task<IEnumerable<ProfessionalsAggSettingsDTO>> GetAll(ProfessionalsAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ProfessionalsAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.ProfessionalsAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ProfessionalsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.ProfessionalsAggSettings, T>> selector = null);
		public Task<IEnumerable<ProfessionalsAggSettingsListiningDTO>> GetAllSummary(ProfessionalsAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(ProfessionalsAggSettingsDTO request, bool updateIfExists = true, ProfessionalsAggSettingsQueryModel searchQuery = null);
		public Task Delete(ProfessionalsAggSettingsQueryModel request);
		public Task Update(ProfessionalsAggSettingsQueryModel searchQuery, ProfessionalsAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(ProfessionalsAggSettingsQueryModel request);
	}
	public partial interface ICboAppService {	
		public Task<CboDTO> Get(CboQueryModel request);
		public Task<int> CountAsync(CboQueryModel request);
		public Task<IEnumerable<CboDTO>> GetAll(CboQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(CboQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Cbo, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(CboQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Cbo, T>> selector = null);
		public Task<IEnumerable<CboListiningDTO>> GetAllSummary(CboQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(CboDTO request, bool updateIfExists = true, CboQueryModel searchQuery = null);
		public Task Delete(CboQueryModel request);
		public Task Update(CboQueryModel searchQuery, CboDTO request, bool createIfNotExists = true);
		public Task DeleteRange(CboQueryModel request);
	}
}
namespace Bravo.Professionals.Application.Aggregates.UsersAgg.AppServices {
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Application.DTO.Aggregates.UsersAgg.Requests;
	public partial interface IUserAppService {	
		public Task<UserDTO> Get(UserQueryModel request);
		public Task<int> CountAsync(UserQueryModel request);
		public Task<IEnumerable<UserDTO>> GetAll(UserQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);

	}
}
