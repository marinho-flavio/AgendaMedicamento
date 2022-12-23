using Bravo.Core.Domain.Aggregates.CommonAgg.Repositories;
using Bravo.Addresses.Domain.Aggregates.AddressesAgg.Entities;
using Bravo.Addresses.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.Repositories 
{
	public interface IEnderecoRepository : IRepository<Endereco> { }
	public interface IEnderecoMongoRepository : IMongoRepository<Endereco> { }

	public interface IAddressesAggSettingsRepository : IRepository<AddressesAggSettings> { }
	public interface IAddressesAggSettingsMongoRepository : IMongoRepository<AddressesAggSettings> { }

}
namespace Bravo.Addresses.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
