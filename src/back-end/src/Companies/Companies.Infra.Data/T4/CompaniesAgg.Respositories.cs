using Microsoft.Extensions.Configuration;
using Bravo.Core.Infra.Data.Repositories;
using Bravo.Companies.Infra.Data.Context;

using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.PatientsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Entities;
using Bravo.Companies.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Companies.Domain.Aggregates.PartnersAgg.Entities;
using Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities;

namespace Bravo.Companies.Infra.Data.Aggregates.CompaniesAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Repositories;
	public partial class EmpresaConfiguracaoRepository : Repository<EmpresaConfiguracao>, IEmpresaConfiguracaoRepository { public EmpresaConfiguracaoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class EmpresaConfiguracaoMongoRepository : MongoRepository<EmpresaConfiguracao>, IEmpresaConfiguracaoMongoRepository { public EmpresaConfiguracaoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class EmpresaRepository : Repository<Empresa>, IEmpresaRepository { public EmpresaRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class EmpresaMongoRepository : MongoRepository<Empresa>, IEmpresaMongoRepository { public EmpresaMongoRepository(IConfiguration config) : base(config) { } }

	public partial class GrupoEmpresaContactsRepository : Repository<GrupoEmpresaContacts>, IGrupoEmpresaContactsRepository { public GrupoEmpresaContactsRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class GrupoEmpresaContactsMongoRepository : MongoRepository<GrupoEmpresaContacts>, IGrupoEmpresaContactsMongoRepository { public GrupoEmpresaContactsMongoRepository(IConfiguration config) : base(config) { } }

	public partial class GrupoEmpresaConfiguracaoRepository : Repository<GrupoEmpresaConfiguracao>, IGrupoEmpresaConfiguracaoRepository { public GrupoEmpresaConfiguracaoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class GrupoEmpresaConfiguracaoMongoRepository : MongoRepository<GrupoEmpresaConfiguracao>, IGrupoEmpresaConfiguracaoMongoRepository { public GrupoEmpresaConfiguracaoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class CompaniesAggSettingsRepository : Repository<CompaniesAggSettings>, ICompaniesAggSettingsRepository { public CompaniesAggSettingsRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class CompaniesAggSettingsMongoRepository : MongoRepository<CompaniesAggSettings>, ICompaniesAggSettingsMongoRepository { public CompaniesAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

	public partial class GrupoEmpresaEnderecoRepository : Repository<GrupoEmpresaEndereco>, IGrupoEmpresaEnderecoRepository { public GrupoEmpresaEnderecoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class GrupoEmpresaEnderecoMongoRepository : MongoRepository<GrupoEmpresaEndereco>, IGrupoEmpresaEnderecoMongoRepository { public GrupoEmpresaEnderecoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class GrupoEmpresaRepository : Repository<GrupoEmpresa>, IGrupoEmpresaRepository { public GrupoEmpresaRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class GrupoEmpresaMongoRepository : MongoRepository<GrupoEmpresa>, IGrupoEmpresaMongoRepository { public GrupoEmpresaMongoRepository(IConfiguration config) : base(config) { } }

	public partial class EmpresaEnderecoRepository : Repository<EmpresaEndereco>, IEmpresaEnderecoRepository { public EmpresaEnderecoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class EmpresaEnderecoMongoRepository : MongoRepository<EmpresaEndereco>, IEmpresaEnderecoMongoRepository { public EmpresaEnderecoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class EmpresaContactsRepository : Repository<EmpresaContacts>, IEmpresaContactsRepository { public EmpresaContactsRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class EmpresaContactsMongoRepository : MongoRepository<EmpresaContacts>, IEmpresaContactsMongoRepository { public EmpresaContactsMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.ProfessionalsAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Repositories;
	public partial class ProfissionalConfiguracaoRepository : Repository<ProfissionalConfiguracao>, IProfissionalConfiguracaoRepository { public ProfissionalConfiguracaoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class ProfissionalConfiguracaoMongoRepository : MongoRepository<ProfissionalConfiguracao>, IProfissionalConfiguracaoMongoRepository { public ProfissionalConfiguracaoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository { public FuncionarioRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class FuncionarioMongoRepository : MongoRepository<Funcionario>, IFuncionarioMongoRepository { public FuncionarioMongoRepository(IConfiguration config) : base(config) { } }

	public partial class ProfissionalRepository : Repository<Profissional>, IProfissionalRepository { public ProfissionalRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class ProfissionalMongoRepository : MongoRepository<Profissional>, IProfissionalMongoRepository { public ProfissionalMongoRepository(IConfiguration config) : base(config) { } }

	public partial class CboRepository : Repository<Cbo>, ICboRepository { public CboRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class CboMongoRepository : MongoRepository<Cbo>, ICboMongoRepository { public CboMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.PatientsAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.PatientsAgg.Repositories;
	public partial class PacienteRepository : Repository<Paciente>, IPacienteRepository { public PacienteRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class PacienteMongoRepository : MongoRepository<Paciente>, IPacienteMongoRepository { public PacienteMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.SchedulingsAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Repositories;
	public partial class AgendaExameRepository : Repository<AgendaExame>, IAgendaExameRepository { public AgendaExameRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class AgendaExameMongoRepository : MongoRepository<AgendaExame>, IAgendaExameMongoRepository { public AgendaExameMongoRepository(IConfiguration config) : base(config) { } }

	public partial class FeriadoRepository : Repository<Feriado>, IFeriadoRepository { public FeriadoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class FeriadoMongoRepository : MongoRepository<Feriado>, IFeriadoMongoRepository { public FeriadoMongoRepository(IConfiguration config) : base(config) { } }

	public partial class AgendaProfissionalRepository : Repository<AgendaProfissional>, IAgendaProfissionalRepository { public AgendaProfissionalRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class AgendaProfissionalMongoRepository : MongoRepository<AgendaProfissional>, IAgendaProfissionalMongoRepository { public AgendaProfissionalMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.HealthPlansAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Repositories;
	public partial class ConvenioRepository : Repository<Convenio>, IConvenioRepository { public ConvenioRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class ConvenioMongoRepository : MongoRepository<Convenio>, IConvenioMongoRepository { public ConvenioMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.ClinicalProceduresAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Repositories;
	public partial class ProcedimentoRepository : Repository<Procedimento>, IProcedimentoRepository { public ProcedimentoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class ProcedimentoMongoRepository : MongoRepository<Procedimento>, IProcedimentoMongoRepository { public ProcedimentoMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.PartnersAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.PartnersAgg.Repositories;
	public partial class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository { public FornecedorRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class FornecedorMongoRepository : MongoRepository<Fornecedor>, IFornecedorMongoRepository { public FornecedorMongoRepository(IConfiguration config) : base(config) { } }

	public partial class PublicitarioRepository : Repository<Publicitario>, IPublicitarioRepository { public PublicitarioRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class PublicitarioMongoRepository : MongoRepository<Publicitario>, IPublicitarioMongoRepository { public PublicitarioMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Companies.Infra.Data.Aggregates.AddressesAgg.Repositories
{
	using Bravo.Companies.Domain.Aggregates.AddressesAgg.Repositories;
	public partial class EnderecoRepository : Repository<Endereco>, IEnderecoRepository { public EnderecoRepository(CompaniesAggContext ctx) : base(ctx) { } }
	public partial class EnderecoMongoRepository : MongoRepository<Endereco>, IEnderecoMongoRepository { public EnderecoMongoRepository(IConfiguration config) : base(config) { } }

}
