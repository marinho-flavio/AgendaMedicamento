using Bravo.Core.Domain.Aggregates.CommonAgg.Repositories;
using Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities;
using Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Repositories 
{
	public interface IConvenioRepository : IRepository<Convenio> { }
	public interface IConvenioMongoRepository : IMongoRepository<Convenio> { }

	public interface IHealthPlansAggSettingsRepository : IRepository<HealthPlansAggSettings> { }
	public interface IHealthPlansAggSettingsMongoRepository : IMongoRepository<HealthPlansAggSettings> { }

	public interface IPlanoConvenioRepository : IRepository<PlanoConvenio> { }
	public interface IPlanoConvenioMongoRepository : IMongoRepository<PlanoConvenio> { }

	public interface ITipoPlanoRepository : IRepository<TipoPlano> { }
	public interface ITipoPlanoMongoRepository : IMongoRepository<TipoPlano> { }

	public interface IConvenioHorasEspeciaisRepository : IRepository<ConvenioHorasEspeciais> { }
	public interface IConvenioHorasEspeciaisMongoRepository : IMongoRepository<ConvenioHorasEspeciais> { }

}
namespace Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
