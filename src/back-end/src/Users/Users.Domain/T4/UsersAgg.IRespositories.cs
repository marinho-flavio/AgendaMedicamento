using SES.Core.Domain.Aggregates.CommonAgg.Repositories;
using SES.Users.Domain.Aggregates.CompaniesAgg.Entities;
using SES.Users.Domain.Aggregates.UsersAgg.Entities;

namespace SES.Users.Domain.Aggregates.CompaniesAgg.Repositories 
{
	public interface IEmpresaRepository : IRepository<Empresa> { }
	public interface IEmpresaMongoRepository : IMongoRepository<Empresa> { }

}
namespace SES.Users.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUsersAggSettingsRepository : IRepository<UsersAggSettings> { }
	public interface IUsersAggSettingsMongoRepository : IMongoRepository<UsersAggSettings> { }

	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
