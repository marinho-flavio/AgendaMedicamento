using Bravo.Core.Domain.Aggregates.CommonAgg.Repositories;
using Bravo.Partners.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities;
using Bravo.Partners.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Partners.Domain.Aggregates.CompaniesAgg.Repositories 
{
	public interface IEmpresaRepository : IRepository<Empresa> { }
	public interface IEmpresaMongoRepository : IMongoRepository<Empresa> { }

}
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Repositories 
{
	public interface IFornecedorRepository : IRepository<Fornecedor> { }
	public interface IFornecedorMongoRepository : IMongoRepository<Fornecedor> { }

	public interface IPublicitarioRepository : IRepository<Publicitario> { }
	public interface IPublicitarioMongoRepository : IMongoRepository<Publicitario> { }

	public interface IPartnersAggSettingsRepository : IRepository<PartnersAggSettings> { }
	public interface IPartnersAggSettingsMongoRepository : IMongoRepository<PartnersAggSettings> { }

}
namespace Bravo.Partners.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
