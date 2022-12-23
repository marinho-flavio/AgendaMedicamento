using System.Linq.Expressions;
using FluentValidation.Results;
using Bravo.Core.Domain.Seedwork.Specification;
namespace Bravo.HealthPlans.Application.Aggregates.HealthPlansAgg.AppServices {
	using Domain.Aggregates.HealthPlansAgg.Queries.Models;
	using Application.DTO.Aggregates.HealthPlansAgg.Requests;
	public partial interface IConvenioAppService {	
		public Task<ConvenioDTO> Get(ConvenioQueryModel request);
		public Task<int> CountAsync(ConvenioQueryModel request);
		public Task<IEnumerable<ConvenioDTO>> GetAll(ConvenioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ConvenioQueryModel request, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.Convenio, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ConvenioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.Convenio, T>> selector = null);
		public Task<IEnumerable<ConvenioListiningDTO>> GetAllSummary(ConvenioQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(ConvenioDTO request, bool updateIfExists = true, ConvenioQueryModel searchQuery = null);
		public Task Delete(ConvenioQueryModel request);
		public Task Update(ConvenioQueryModel searchQuery, ConvenioDTO request, bool createIfNotExists = true);
		public Task DeleteRange(ConvenioQueryModel request);
	}
	public partial interface IHealthPlansAggSettingsAppService {	
		public Task<HealthPlansAggSettingsDTO> Get(HealthPlansAggSettingsQueryModel request);
		public Task<int> CountAsync(HealthPlansAggSettingsQueryModel request);
		public Task<IEnumerable<HealthPlansAggSettingsDTO>> GetAll(HealthPlansAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(HealthPlansAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.HealthPlansAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(HealthPlansAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.HealthPlansAggSettings, T>> selector = null);
		public Task<IEnumerable<HealthPlansAggSettingsListiningDTO>> GetAllSummary(HealthPlansAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(HealthPlansAggSettingsDTO request, bool updateIfExists = true, HealthPlansAggSettingsQueryModel searchQuery = null);
		public Task Delete(HealthPlansAggSettingsQueryModel request);
		public Task Update(HealthPlansAggSettingsQueryModel searchQuery, HealthPlansAggSettingsDTO request, bool createIfNotExists = true);
		public Task DeleteRange(HealthPlansAggSettingsQueryModel request);
	}
	public partial interface IPlanoConvenioAppService {	
		public Task<PlanoConvenioDTO> Get(PlanoConvenioQueryModel request);
		public Task<int> CountAsync(PlanoConvenioQueryModel request);
		public Task<IEnumerable<PlanoConvenioDTO>> GetAll(PlanoConvenioQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(PlanoConvenioQueryModel request, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.PlanoConvenio, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(PlanoConvenioQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.PlanoConvenio, T>> selector = null);
		public Task<IEnumerable<PlanoConvenioListiningDTO>> GetAllSummary(PlanoConvenioQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(PlanoConvenioDTO request, bool updateIfExists = true, PlanoConvenioQueryModel searchQuery = null);
		public Task Delete(PlanoConvenioQueryModel request);
		public Task Update(PlanoConvenioQueryModel searchQuery, PlanoConvenioDTO request, bool createIfNotExists = true);
		public Task DeleteRange(PlanoConvenioQueryModel request);
	}
	public partial interface ITipoPlanoAppService {	
		public Task<TipoPlanoDTO> Get(TipoPlanoQueryModel request);
		public Task<int> CountAsync(TipoPlanoQueryModel request);
		public Task<IEnumerable<TipoPlanoDTO>> GetAll(TipoPlanoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(TipoPlanoQueryModel request, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.TipoPlano, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(TipoPlanoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.TipoPlano, T>> selector = null);
		public Task<IEnumerable<TipoPlanoListiningDTO>> GetAllSummary(TipoPlanoQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(TipoPlanoDTO request, bool updateIfExists = true, TipoPlanoQueryModel searchQuery = null);
		public Task Delete(TipoPlanoQueryModel request);
		public Task Update(TipoPlanoQueryModel searchQuery, TipoPlanoDTO request, bool createIfNotExists = true);
		public Task DeleteRange(TipoPlanoQueryModel request);
	}
	public partial interface IConvenioHorasEspeciaisAppService {	
		public Task<ConvenioHorasEspeciaisDTO> Get(ConvenioHorasEspeciaisQueryModel request);
		public Task<int> CountAsync(ConvenioHorasEspeciaisQueryModel request);
		public Task<IEnumerable<ConvenioHorasEspeciaisDTO>> GetAll(ConvenioHorasEspeciaisQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ConvenioHorasEspeciaisQueryModel request, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.ConvenioHorasEspeciais, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ConvenioHorasEspeciaisQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.HealthPlansAgg.Entities.ConvenioHorasEspeciais, T>> selector = null);
		public Task<IEnumerable<ConvenioHorasEspeciaisListiningDTO>> GetAllSummary(ConvenioHorasEspeciaisQueryModel request, int? page = null, int? size = null);

		public Task<ValidationResult> Create(ConvenioHorasEspeciaisDTO request, bool updateIfExists = true, ConvenioHorasEspeciaisQueryModel searchQuery = null);
		public Task Delete(ConvenioHorasEspeciaisQueryModel request);
		public Task Update(ConvenioHorasEspeciaisQueryModel searchQuery, ConvenioHorasEspeciaisDTO request, bool createIfNotExists = true);
		public Task DeleteRange(ConvenioHorasEspeciaisQueryModel request);
	}
}
namespace Bravo.HealthPlans.Application.Aggregates.UsersAgg.AppServices {
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
