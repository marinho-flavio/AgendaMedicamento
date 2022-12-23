using System.Linq.Expressions;
using FluentValidation.Results;
using SES.Core.Domain.Seedwork.Specification;
namespace SES.Schedulings.Application.Aggregates.CompaniesAgg.AppServices {
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
}
namespace SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices {
	using Domain.Aggregates.SchedulingsAgg.Queries.Models;
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	public partial interface ISchedulingsAggSettingsAppService {	
		public Task<SchedulingsAggSettingsDTO> Get(SchedulingsAggSettingsQueryModel request);
		public Task<int> CountAsync(SchedulingsAggSettingsQueryModel request);
		public Task<IEnumerable<SchedulingsAggSettingsDTO>> GetAll(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(SchedulingsAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.SchedulingsAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.SchedulingsAggSettings, T>> selector = null);
		public Task<IEnumerable<SchedulingsAggSettingsListiningDTO>> GetAllSummary(SchedulingsAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(SchedulingsAggSettingsDTO request, bool updateIfExists = true, SchedulingsAggSettingsQueryModel searchQuery = null);
		public Task Delete(SchedulingsAggSettingsQueryModel request);
		public Task Update(SchedulingsAggSettingsQueryModel searchQuery, SchedulingsAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(SchedulingsAggSettingsQueryModel request);
	}
	public partial interface IFeriadoAppService {	
		public Task<FeriadoDTO> Get(FeriadoQueryModel request);
		public Task<int> CountAsync(FeriadoQueryModel request);
		public Task<IEnumerable<FeriadoDTO>> GetAll(FeriadoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(FeriadoQueryModel request, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.Feriado, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(FeriadoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SchedulingsAgg.Entities.Feriado, T>> selector = null);
		public Task<IEnumerable<FeriadoListiningDTO>> GetAllSummary(FeriadoQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(FeriadoDTO request, bool updateIfExists = true, FeriadoQueryModel searchQuery = null);
		public Task Delete(FeriadoQueryModel request);
		public Task Update(FeriadoQueryModel searchQuery, FeriadoDTO request, bool createIfNotExists = true);
		public Task DeleteRange(FeriadoQueryModel request);
	}
}
namespace SES.Schedulings.Application.Aggregates.ProfessionalsAgg.AppServices {
	using Domain.Aggregates.ProfessionalsAgg.Queries.Models;
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
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
}
namespace SES.Schedulings.Application.Aggregates.UsersAgg.AppServices {
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Application.DTO.Aggregates.UsersAgg.Requests;
	public partial interface IUserAppService {	
		public Task<UserDTO> Get(UserQueryModel request);
		public Task<int> CountAsync(UserQueryModel request);
		public Task<IEnumerable<UserDTO>> GetAll(UserQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<UserListiningDTO>> GetAllSummary(UserQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(UserDTO request, bool updateIfExists = true, UserQueryModel searchQuery = null);
		public Task Delete(UserQueryModel request);
		public Task Update(UserQueryModel searchQuery, UserDTO request, bool createIfNotExists = true);
		public Task DeleteRange(UserQueryModel request);
	}
}
namespace SES.Schedulings.Application.Aggregates.PartnersAgg.AppServices {
	using Domain.Aggregates.PartnersAgg.Queries.Models;
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	public partial interface IFornecedorAppService {	
		public Task<FornecedorDTO> Get(FornecedorQueryModel request);
		public Task<int> CountAsync(FornecedorQueryModel request);
		public Task<IEnumerable<FornecedorDTO>> GetAll(FornecedorQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(FornecedorQueryModel request, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Fornecedor, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(FornecedorQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Fornecedor, T>> selector = null);
		public Task<IEnumerable<FornecedorListiningDTO>> GetAllSummary(FornecedorQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(FornecedorDTO request, bool updateIfExists = true, FornecedorQueryModel searchQuery = null);
		public Task Delete(FornecedorQueryModel request);
		public Task Update(FornecedorQueryModel searchQuery, FornecedorDTO request, bool createIfNotExists = true);
		public Task DeleteRange(FornecedorQueryModel request);
	}
	public partial interface IPublicitarioAppService {	
		public Task<PublicitarioDTO> Get(PublicitarioQueryModel request);
		public Task<int> CountAsync(PublicitarioQueryModel request);
		public Task<IEnumerable<PublicitarioDTO>> GetAll(PublicitarioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PublicitarioQueryModel request, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Publicitario, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PublicitarioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PartnersAgg.Entities.Publicitario, T>> selector = null);
		public Task<IEnumerable<PublicitarioListiningDTO>> GetAllSummary(PublicitarioQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(PublicitarioDTO request, bool updateIfExists = true, PublicitarioQueryModel searchQuery = null);
		public Task Delete(PublicitarioQueryModel request);
		public Task Update(PublicitarioQueryModel searchQuery, PublicitarioDTO request, bool createIfNotExists = true);
		public Task DeleteRange(PublicitarioQueryModel request);
	}
}
