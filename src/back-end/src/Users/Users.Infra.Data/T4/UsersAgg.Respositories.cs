using Microsoft.Extensions.Configuration;
using SES.Core.Infra.Data.Repositories;
using SES.Users.Infra.Data.Context;

using SES.Users.Domain.Aggregates.CompaniesAgg.Entities;
using SES.Users.Domain.Aggregates.UsersAgg.Entities;

namespace SES.Users.Infra.Data.Aggregates.CompaniesAgg.Repositories
{
	using SES.Users.Domain.Aggregates.CompaniesAgg.Repositories;
	public partial class EmpresaRepository : Repository<Empresa>, IEmpresaRepository { public EmpresaRepository(UsersAggContext ctx) : base(ctx) { } }
	public partial class EmpresaMongoRepository : MongoRepository<Empresa>, IEmpresaMongoRepository { public EmpresaMongoRepository(IConfiguration config) : base(config) { } }

}
namespace SES.Users.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using SES.Users.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UsersAggSettingsRepository : Repository<UsersAggSettings>, IUsersAggSettingsRepository { public UsersAggSettingsRepository(UsersAggContext ctx) : base(ctx) { } }
	public partial class UsersAggSettingsMongoRepository : MongoRepository<UsersAggSettings>, IUsersAggSettingsMongoRepository { public UsersAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(UsersAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
