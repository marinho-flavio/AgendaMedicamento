using Microsoft.Extensions.Configuration;
using Bravo.Core.Infra.Data.Repositories;
using Bravo.Addresses.Infra.Data.Context;

using Bravo.Addresses.Domain.Aggregates.AddressesAgg.Entities;
using Bravo.Addresses.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Addresses.Infra.Data.Aggregates.AddressesAgg.Repositories
{
	using Bravo.Addresses.Domain.Aggregates.AddressesAgg.Repositories;
	public partial class EnderecoRepository : Repository<Endereco>, IEnderecoRepository { public EnderecoRepository(AddressesAggContext ctx) : base(ctx) { } }
	public partial class EnderecoMongoRepository : MongoRepository<Endereco>, IEnderecoMongoRepository { public EnderecoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class AddressesAggSettingsRepository : Repository<AddressesAggSettings>, IAddressesAggSettingsRepository { public AddressesAggSettingsRepository(AddressesAggContext ctx) : base(ctx) { } }
	public partial class AddressesAggSettingsMongoRepository : MongoRepository<AddressesAggSettings>, IAddressesAggSettingsMongoRepository { public AddressesAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Addresses.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Bravo.Addresses.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(AddressesAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
