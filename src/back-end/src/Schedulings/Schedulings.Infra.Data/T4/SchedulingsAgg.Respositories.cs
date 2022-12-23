using Microsoft.Extensions.Configuration;
using SES.Core.Infra.Data.Repositories;
using SES.Schedulings.Infra.Data.Context;

using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities;
using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Entities;
using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Entities;
using SES.Schedulings.Domain.Aggregates.UsersAgg.Entities;
using SES.Schedulings.Domain.Aggregates.PartnersAgg.Entities;

namespace SES.Schedulings.Infra.Data.Aggregates.CompaniesAgg.Repositories
{
	using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Repositories;
	public partial class EmpresaRepository : Repository<Empresa>, IEmpresaRepository { public EmpresaRepository(SchedulingsAggContext ctx) : base(ctx) { } }
	public partial class EmpresaMongoRepository : MongoRepository<Empresa>, IEmpresaMongoRepository { public EmpresaMongoRepository(IConfiguration config) : base(config) { } }

}
namespace SES.Schedulings.Infra.Data.Aggregates.SchedulingsAgg.Repositories
{
	using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Repositories;
	public partial class SchedulingsAggSettingsRepository : Repository<SchedulingsAggSettings>, ISchedulingsAggSettingsRepository { public SchedulingsAggSettingsRepository(SchedulingsAggContext ctx) : base(ctx) { } }
	public partial class SchedulingsAggSettingsMongoRepository : MongoRepository<SchedulingsAggSettings>, ISchedulingsAggSettingsMongoRepository { public SchedulingsAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

	public partial class FeriadoRepository : Repository<Feriado>, IFeriadoRepository { public FeriadoRepository(SchedulingsAggContext ctx) : base(ctx) { } }
	public partial class FeriadoMongoRepository : MongoRepository<Feriado>, IFeriadoMongoRepository { public FeriadoMongoRepository(IConfiguration config) : base(config) { } }

}
namespace SES.Schedulings.Infra.Data.Aggregates.ProfessionalsAgg.Repositories
{
	using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Repositories;
	public partial class ProfissionalRepository : Repository<Profissional>, IProfissionalRepository { public ProfissionalRepository(SchedulingsAggContext ctx) : base(ctx) { } }
	public partial class ProfissionalMongoRepository : MongoRepository<Profissional>, IProfissionalMongoRepository { public ProfissionalMongoRepository(IConfiguration config) : base(config) { } }

}
namespace SES.Schedulings.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using SES.Schedulings.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(SchedulingsAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
namespace SES.Schedulings.Infra.Data.Aggregates.PartnersAgg.Repositories
{
	using SES.Schedulings.Domain.Aggregates.PartnersAgg.Repositories;
	public partial class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository { public FornecedorRepository(SchedulingsAggContext ctx) : base(ctx) { } }
	public partial class FornecedorMongoRepository : MongoRepository<Fornecedor>, IFornecedorMongoRepository { public FornecedorMongoRepository(IConfiguration config) : base(config) { } }

	public partial class PublicitarioRepository : Repository<Publicitario>, IPublicitarioRepository { public PublicitarioRepository(SchedulingsAggContext ctx) : base(ctx) { } }
	public partial class PublicitarioMongoRepository : MongoRepository<Publicitario>, IPublicitarioMongoRepository { public PublicitarioMongoRepository(IConfiguration config) : base(config) { } }

}
