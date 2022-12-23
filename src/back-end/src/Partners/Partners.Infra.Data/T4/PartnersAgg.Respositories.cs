using Microsoft.Extensions.Configuration;
using Bravo.Core.Infra.Data.Repositories;
using Bravo.Partners.Infra.Data.Context;

using Bravo.Partners.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities;
using Bravo.Partners.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Partners.Infra.Data.Aggregates.CompaniesAgg.Repositories
{
	using Bravo.Partners.Domain.Aggregates.CompaniesAgg.Repositories;
	public partial class EmpresaRepository : Repository<Empresa>, IEmpresaRepository { public EmpresaRepository(PartnersAggContext ctx) : base(ctx) { } }
	public partial class EmpresaMongoRepository : MongoRepository<Empresa>, IEmpresaMongoRepository { public EmpresaMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Partners.Infra.Data.Aggregates.PartnersAgg.Repositories
{
	using Bravo.Partners.Domain.Aggregates.PartnersAgg.Repositories;
	public partial class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository { public FornecedorRepository(PartnersAggContext ctx) : base(ctx) { } }
	public partial class FornecedorMongoRepository : MongoRepository<Fornecedor>, IFornecedorMongoRepository { public FornecedorMongoRepository(IConfiguration config) : base(config) { } }

	public partial class PublicitarioRepository : Repository<Publicitario>, IPublicitarioRepository { public PublicitarioRepository(PartnersAggContext ctx) : base(ctx) { } }
	public partial class PublicitarioMongoRepository : MongoRepository<Publicitario>, IPublicitarioMongoRepository { public PublicitarioMongoRepository(IConfiguration config) : base(config) { } }

	public partial class PartnersAggSettingsRepository : Repository<PartnersAggSettings>, IPartnersAggSettingsRepository { public PartnersAggSettingsRepository(PartnersAggContext ctx) : base(ctx) { } }
	public partial class PartnersAggSettingsMongoRepository : MongoRepository<PartnersAggSettings>, IPartnersAggSettingsMongoRepository { public PartnersAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Partners.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Bravo.Partners.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(PartnersAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
