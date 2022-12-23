using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.Core.Domain.Seedwork.Specification;
namespace Bravo.Patients.Application.Aggregates.PatientsAgg.AppServices {
	using Domain.Aggregates.PatientsAgg.Queries.Models;
	using Application.DTO.Aggregates.PatientsAgg.Requests;
	public partial interface IPacienteAppService {	
		public Task<PacienteDTO> Get(PacienteQueryModel request);
		public Task<int> CountAsync(PacienteQueryModel request);
		public Task<IEnumerable<PacienteDTO>> GetAll(PacienteQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PacienteQueryModel request, Expression<Func<Domain.Aggregates.PatientsAgg.Entities.Paciente, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PacienteQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PatientsAgg.Entities.Paciente, T>> selector = null);
		public Task<IEnumerable<PacienteListiningDTO>> GetAllSummary(PacienteQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(PacienteDTO request, bool updateIfExists = true, PacienteQueryModel searchQuery = null);
		public Task Delete(PacienteQueryModel request);
		public Task Update(PacienteQueryModel searchQuery, PacienteDTO request, bool createIfNotExists = true);
		public Task DeleteRange(PacienteQueryModel request);
	}
	public partial interface IPatientsAggSettingsAppService {	
		public Task<PatientsAggSettingsDTO> Get(PatientsAggSettingsQueryModel request);
		public Task<int> CountAsync(PatientsAggSettingsQueryModel request);
		public Task<IEnumerable<PatientsAggSettingsDTO>> GetAll(PatientsAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PatientsAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.PatientsAgg.Entities.PatientsAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PatientsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.PatientsAgg.Entities.PatientsAggSettings, T>> selector = null);
		public Task<IEnumerable<PatientsAggSettingsListiningDTO>> GetAllSummary(PatientsAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(PatientsAggSettingsDTO request, bool updateIfExists = true, PatientsAggSettingsQueryModel searchQuery = null);
		public Task Delete(PatientsAggSettingsQueryModel request);
		public Task Update(PatientsAggSettingsQueryModel searchQuery, PatientsAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(PatientsAggSettingsQueryModel request);
	}
}
namespace Bravo.Patients.Application.Aggregates.UsersAgg.AppServices {
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
