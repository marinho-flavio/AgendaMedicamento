using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.Core.Domain.Seedwork.Specification;
namespace Bravo.ClinicalProcedures.Application.Aggregates.UsersAgg.AppServices {
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
namespace Bravo.ClinicalProcedures.Application.Aggregates.ClinicalProceduresAgg.AppServices {
	using Domain.Aggregates.ClinicalProceduresAgg.Queries.Models;
	using Application.DTO.Aggregates.ClinicalProceduresAgg.Requests;
	public partial interface IClinicalProceduresAggSettingsAppService {	
		public Task<ClinicalProceduresAggSettingsDTO> Get(ClinicalProceduresAggSettingsQueryModel request);
		public Task<int> CountAsync(ClinicalProceduresAggSettingsQueryModel request);
		public Task<IEnumerable<ClinicalProceduresAggSettingsDTO>> GetAll(ClinicalProceduresAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ClinicalProceduresAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.ClinicalProceduresAgg.Entities.ClinicalProceduresAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ClinicalProceduresAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ClinicalProceduresAgg.Entities.ClinicalProceduresAggSettings, T>> selector = null);
		public Task<IEnumerable<ClinicalProceduresAggSettingsListiningDTO>> GetAllSummary(ClinicalProceduresAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(ClinicalProceduresAggSettingsDTO request, bool updateIfExists = true, ClinicalProceduresAggSettingsQueryModel searchQuery = null);
		public Task Delete(ClinicalProceduresAggSettingsQueryModel request);
		public Task Update(ClinicalProceduresAggSettingsQueryModel searchQuery, ClinicalProceduresAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(ClinicalProceduresAggSettingsQueryModel request);
	}
}
