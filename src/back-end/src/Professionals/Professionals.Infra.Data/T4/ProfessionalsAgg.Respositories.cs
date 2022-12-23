using Microsoft.Extensions.Configuration;
using Bravo.Core.Infra.Data.Repositories;
using Bravo.Professionals.Infra.Data.Context;

using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Professionals.Infra.Data.Aggregates.CompaniesAgg.Repositories
{
	using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Repositories;
	public partial class EmpresaRepository : Repository<Empresa>, IEmpresaRepository { public EmpresaRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class EmpresaMongoRepository : MongoRepository<Empresa>, IEmpresaMongoRepository { public EmpresaMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Professionals.Infra.Data.Aggregates.SchedulingsAgg.Repositories
{
	using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Repositories;
	public partial class SchedulingsAggSettingsRepository : Repository<SchedulingsAggSettings>, ISchedulingsAggSettingsRepository { public SchedulingsAggSettingsRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class SchedulingsAggSettingsMongoRepository : MongoRepository<SchedulingsAggSettings>, ISchedulingsAggSettingsMongoRepository { public SchedulingsAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

	public partial class AgendaExameRepository : Repository<AgendaExame>, IAgendaExameRepository { public AgendaExameRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class AgendaExameMongoRepository : MongoRepository<AgendaExame>, IAgendaExameMongoRepository { public AgendaExameMongoRepository(IConfiguration config) : base(config) { } }

	public partial class AgendaSalaRepository : Repository<AgendaSala>, IAgendaSalaRepository { public AgendaSalaRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class AgendaSalaMongoRepository : MongoRepository<AgendaSala>, IAgendaSalaMongoRepository { public AgendaSalaMongoRepository(IConfiguration config) : base(config) { } }

	public partial class FeriadoRepository : Repository<Feriado>, IFeriadoRepository { public FeriadoRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class FeriadoMongoRepository : MongoRepository<Feriado>, IFeriadoMongoRepository { public FeriadoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class AgendaProfissionalRepository : Repository<AgendaProfissional>, IAgendaProfissionalRepository { public AgendaProfissionalRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class AgendaProfissionalMongoRepository : MongoRepository<AgendaProfissional>, IAgendaProfissionalMongoRepository { public AgendaProfissionalMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Professionals.Infra.Data.Aggregates.ProfessionalsAgg.Repositories
{
	using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Repositories;
	public partial class ProfissionalConfiguracaoRepository : Repository<ProfissionalConfiguracao>, IProfissionalConfiguracaoRepository { public ProfissionalConfiguracaoRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class ProfissionalConfiguracaoMongoRepository : MongoRepository<ProfissionalConfiguracao>, IProfissionalConfiguracaoMongoRepository { public ProfissionalConfiguracaoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository { public FuncionarioRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class FuncionarioMongoRepository : MongoRepository<Funcionario>, IFuncionarioMongoRepository { public FuncionarioMongoRepository(IConfiguration config) : base(config) { } }

	public partial class ProfissionalRepository : Repository<Profissional>, IProfissionalRepository { public ProfissionalRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class ProfissionalMongoRepository : MongoRepository<Profissional>, IProfissionalMongoRepository { public ProfissionalMongoRepository(IConfiguration config) : base(config) { } }

	public partial class ProfessionalsAggSettingsRepository : Repository<ProfessionalsAggSettings>, IProfessionalsAggSettingsRepository { public ProfessionalsAggSettingsRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class ProfessionalsAggSettingsMongoRepository : MongoRepository<ProfessionalsAggSettings>, IProfessionalsAggSettingsMongoRepository { public ProfessionalsAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

	public partial class CboRepository : Repository<Cbo>, ICboRepository { public CboRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class CboMongoRepository : MongoRepository<Cbo>, ICboMongoRepository { public CboMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Professionals.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Bravo.Professionals.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(ProfessionalsAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
