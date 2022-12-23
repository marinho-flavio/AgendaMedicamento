using Microsoft.Extensions.Configuration;
using Bravo.Core.Infra.Data.Repositories;
using Bravo.HealthPlans.Infra.Data.Context;

using Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities;
using Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.HealthPlans.Infra.Data.Aggregates.HealthPlansAgg.Repositories
{
	using Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Repositories;
	public partial class ConvenioRepository : Repository<Convenio>, IConvenioRepository { public ConvenioRepository(HealthPlansAggContext ctx) : base(ctx) { } }
	public partial class ConvenioMongoRepository : MongoRepository<Convenio>, IConvenioMongoRepository { public ConvenioMongoRepository(IConfiguration config) : base(config) { } }

	public partial class HealthPlansAggSettingsRepository : Repository<HealthPlansAggSettings>, IHealthPlansAggSettingsRepository { public HealthPlansAggSettingsRepository(HealthPlansAggContext ctx) : base(ctx) { } }
	public partial class HealthPlansAggSettingsMongoRepository : MongoRepository<HealthPlansAggSettings>, IHealthPlansAggSettingsMongoRepository { public HealthPlansAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

	public partial class PlanoConvenioRepository : Repository<PlanoConvenio>, IPlanoConvenioRepository { public PlanoConvenioRepository(HealthPlansAggContext ctx) : base(ctx) { } }
	public partial class PlanoConvenioMongoRepository : MongoRepository<PlanoConvenio>, IPlanoConvenioMongoRepository { public PlanoConvenioMongoRepository(IConfiguration config) : base(config) { } }

	public partial class TipoPlanoRepository : Repository<TipoPlano>, ITipoPlanoRepository { public TipoPlanoRepository(HealthPlansAggContext ctx) : base(ctx) { } }
	public partial class TipoPlanoMongoRepository : MongoRepository<TipoPlano>, ITipoPlanoMongoRepository { public TipoPlanoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class ConvenioHorasEspeciaisRepository : Repository<ConvenioHorasEspeciais>, IConvenioHorasEspeciaisRepository { public ConvenioHorasEspeciaisRepository(HealthPlansAggContext ctx) : base(ctx) { } }
	public partial class ConvenioHorasEspeciaisMongoRepository : MongoRepository<ConvenioHorasEspeciais>, IConvenioHorasEspeciaisMongoRepository { public ConvenioHorasEspeciaisMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.HealthPlans.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(HealthPlansAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
