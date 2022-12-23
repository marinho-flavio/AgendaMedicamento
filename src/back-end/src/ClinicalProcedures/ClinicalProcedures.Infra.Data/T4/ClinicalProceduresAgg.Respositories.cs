using Microsoft.Extensions.Configuration;
using Bravo.Core.Infra.Data.Repositories;
using Bravo.ClinicalProcedures.Infra.Data.Context;

using Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Entities;
using Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Entities;

namespace Bravo.ClinicalProcedures.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(ClinicalProceduresAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.ClinicalProcedures.Infra.Data.Aggregates.ClinicalProceduresAgg.Repositories
{
	using Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Repositories;
	public partial class ClinicalProceduresAggSettingsRepository : Repository<ClinicalProceduresAggSettings>, IClinicalProceduresAggSettingsRepository { public ClinicalProceduresAggSettingsRepository(ClinicalProceduresAggContext ctx) : base(ctx) { } }
	public partial class ClinicalProceduresAggSettingsMongoRepository : MongoRepository<ClinicalProceduresAggSettings>, IClinicalProceduresAggSettingsMongoRepository { public ClinicalProceduresAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

}
