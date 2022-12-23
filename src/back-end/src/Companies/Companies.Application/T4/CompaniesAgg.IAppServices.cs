using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.Core.Domain.Seedwork.Specification;
namespace Bravo.Companies.Application.Aggregates.CompaniesAgg.AppServices {
	using Domain.Aggregates.CompaniesAgg.Queries.Models;
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	public partial interface IEmpresaAppService {	
		public Task<EmpresaDTO> Get(EmpresaQueryModel request);
		public Task<int> CountAsync(EmpresaQueryModel request);
		public Task<IEnumerable<EmpresaDTO>> GetAll(EmpresaQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(EmpresaQueryModel request, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.Empresa, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(EmpresaQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.Empresa, T>> selector = null);
		public Task<IEnumerable<EmpresaListiningDTO>> GetAllSummary(EmpresaQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(EmpresaDTO request, bool updateIfExists = true, EmpresaQueryModel searchQuery = null);
		public Task Delete(EmpresaQueryModel request);
		public Task Update(EmpresaQueryModel searchQuery, EmpresaDTO request, bool createIfNotExists = true);
		public Task DeleteRange(EmpresaQueryModel request);
	}
	public partial interface ICompaniesAggSettingsAppService {	
		public Task<CompaniesAggSettingsDTO> Get(CompaniesAggSettingsQueryModel request);
		public Task<int> CountAsync(CompaniesAggSettingsQueryModel request);
		public Task<IEnumerable<CompaniesAggSettingsDTO>> GetAll(CompaniesAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(CompaniesAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.CompaniesAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(CompaniesAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.CompaniesAggSettings, T>> selector = null);
		public Task<IEnumerable<CompaniesAggSettingsListiningDTO>> GetAllSummary(CompaniesAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(CompaniesAggSettingsDTO request, bool updateIfExists = true, CompaniesAggSettingsQueryModel searchQuery = null);
		public Task Delete(CompaniesAggSettingsQueryModel request);
		public Task Update(CompaniesAggSettingsQueryModel searchQuery, CompaniesAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(CompaniesAggSettingsQueryModel request);
	}
	public partial interface IGrupoEmpresaAppService {	
		public Task<GrupoEmpresaDTO> Get(GrupoEmpresaQueryModel request);
		public Task<int> CountAsync(GrupoEmpresaQueryModel request);
		public Task<IEnumerable<GrupoEmpresaDTO>> GetAll(GrupoEmpresaQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(GrupoEmpresaQueryModel request, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(GrupoEmpresaQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa, T>> selector = null);
		public Task<IEnumerable<GrupoEmpresaListiningDTO>> GetAllSummary(GrupoEmpresaQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(GrupoEmpresaDTO request, bool updateIfExists = true, GrupoEmpresaQueryModel searchQuery = null);
		public Task Delete(GrupoEmpresaQueryModel request);
		public Task Update(GrupoEmpresaQueryModel searchQuery, GrupoEmpresaDTO request, bool createIfNotExists = true);
		public Task DeleteRange(GrupoEmpresaQueryModel request);
	}
}
namespace Bravo.Companies.Application.Aggregates.ProfessionalsAgg.AppServices {
	using Domain.Aggregates.ProfessionalsAgg.Queries.Models;
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	public partial interface IProfissionalConfiguracaoAppService {	
		public Task<ProfissionalConfiguracaoDTO> Get(ProfissionalConfiguracaoQueryModel request);
		public Task<int> CountAsync(ProfissionalConfiguracaoQueryModel request);
		public Task<IEnumerable<ProfissionalConfiguracaoDTO>> GetAll(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ProfissionalConfiguracaoQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.ProfissionalConfiguracao, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.ProfissionalConfiguracao, T>> selector = null);
		public Task<IEnumerable<ProfissionalConfiguracaoListiningDTO>> GetAllSummary(ProfissionalConfiguracaoQueryModel request, int? page = null, int? size = null);

	}
	public partial interface IFuncionarioAppService {	
		public Task<FuncionarioDTO> Get(FuncionarioQueryModel request);
		public Task<int> CountAsync(FuncionarioQueryModel request);
		public Task<IEnumerable<FuncionarioDTO>> GetAll(FuncionarioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(FuncionarioQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Funcionario, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(FuncionarioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Funcionario, T>> selector = null);
		public Task<IEnumerable<FuncionarioListiningDTO>> GetAllSummary(FuncionarioQueryModel request, int? page = null, int? size = null);

	}
	public partial interface IProfissionalAppService {	
		public Task<ProfissionalDTO> Get(ProfissionalQueryModel request);
		public Task<int> CountAsync(ProfissionalQueryModel request);
		public Task<IEnumerable<ProfissionalDTO>> GetAll(ProfissionalQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ProfissionalQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Profissional, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ProfissionalQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Profissional, T>> selector = null);
		public Task<IEnumerable<ProfissionalListiningDTO>> GetAllSummary(ProfissionalQueryModel request, int? page = null, int? size = null);

	}
	public partial interface ICboAppService {	
		public Task<CboDTO> Get(CboQueryModel request);
		public Task<int> CountAsync(CboQueryModel request);
		public Task<IEnumerable<CboDTO>> GetAll(CboQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(CboQueryModel request, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Cbo, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(CboQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ProfessionalsAgg.Entities.Cbo, T>> selector = null);
		public Task<IEnumerable<CboListiningDTO>> GetAllSummary(CboQueryModel request, int? page = null, int? size = null);

	}
}
namespace Bravo.Companies.Application.Aggregates.PatientsAgg.AppServices {
	using Domain.Aggregates.PatientsAgg.Queries.Models;
	using Application.DTO.Aggregates.PatientsAgg.Requests;
	public partial interface IPacienteAppService {	
		public Task<PacienteDTO> Get(PacienteQueryModel request);
		public Task<int> CountAsync(PacienteQueryModel request);
		public Task<IEnumerable<PacienteDTO>> GetAll(PacienteQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PacienteQueryModel request, Expression<Func<Domain.Aggregates.PatientsAgg.Entities.Paciente, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PacienteQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PatientsAgg.Entities.Paciente, T>> selector = null);
		public Task<IEnumerable<PacienteListiningDTO>> GetAllSummary(PacienteQueryModel request, int? page = null, int? size = null);

	}
}
namespace Bravo.Companies.Application.Aggregates.SchedulingsAgg.AppServices {
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	public partial interface IAgendaExameAppService {	
		public Task<AgendaExameDTO> Get(AgendaExameQueryModel request);
		public Task<int> CountAsync(AgendaExameQueryModel request);
		public Task<IEnumerable<AgendaExameDTO>> GetAll(AgendaExameQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AgendaExameQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaExame, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AgendaExameQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.AgendaExame, T>> selector = null);
		public Task<IEnumerable<AgendaExameListiningDTO>> GetAllSummary(AgendaExameQueryModel request, int? page = null, int? size = null);

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
namespace Bravo.Companies.Application.Aggregates.HealthPlansAgg.AppServices {
	using Domain.Aggregates.HealthPlansAgg.Queries.Models;
	using Application.DTO.Aggregates.HealthPlansAgg.Requests;
	public partial interface IConvenioAppService {	
		public Task<ConvenioDTO> Get(ConvenioQueryModel request);
		public Task<int> CountAsync(ConvenioQueryModel request);
		public Task<IEnumerable<ConvenioDTO>> GetAll(ConvenioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ConvenioQueryModel request, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.Convenio, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ConvenioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.Convenio, T>> selector = null);
		public Task<IEnumerable<ConvenioListiningDTO>> GetAllSummary(ConvenioQueryModel request, int? page = null, int? size = null);

	}
}
namespace Bravo.Companies.Application.Aggregates.UsersAgg.AppServices {
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
namespace Bravo.Companies.Application.Aggregates.PartnersAgg.AppServices {
	using Domain.Aggregates.PartnersAgg.Queries.Models;
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	public partial interface IFornecedorAppService {	
		public Task<FornecedorDTO> Get(FornecedorQueryModel request);
		public Task<int> CountAsync(FornecedorQueryModel request);
		public Task<IEnumerable<FornecedorDTO>> GetAll(FornecedorQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(FornecedorQueryModel request, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Fornecedor, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(FornecedorQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Fornecedor, T>> selector = null);
		public Task<IEnumerable<FornecedorListiningDTO>> GetAllSummary(FornecedorQueryModel request, int? page = null, int? size = null);

	}
	public partial interface IPublicitarioAppService {	
		public Task<PublicitarioDTO> Get(PublicitarioQueryModel request);
		public Task<int> CountAsync(PublicitarioQueryModel request);
		public Task<IEnumerable<PublicitarioDTO>> GetAll(PublicitarioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PublicitarioQueryModel request, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Publicitario, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PublicitarioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Publicitario, T>> selector = null);
		public Task<IEnumerable<PublicitarioListiningDTO>> GetAllSummary(PublicitarioQueryModel request, int? page = null, int? size = null);

	}
}
namespace Bravo.Companies.Application.Aggregates.AddressesAgg.AppServices {
	using Domain.Aggregates.AddressesAgg.Queries.Models;
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	public partial interface IEnderecoAppService {	
		public Task<EnderecoDTO> Get(EnderecoQueryModel request);
		public Task<int> CountAsync(EnderecoQueryModel request);
		public Task<IEnumerable<EnderecoDTO>> GetAll(EnderecoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(EnderecoQueryModel request, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Endereco, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(EnderecoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Endereco, T>> selector = null);

	}
}
