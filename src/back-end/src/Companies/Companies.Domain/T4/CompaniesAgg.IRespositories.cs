using Bravo.Core.Domain.Aggregates.CommonAgg.Repositories;
using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.PatientsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Entities;
using Bravo.Companies.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Companies.Domain.Aggregates.PartnersAgg.Entities;
using Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Repositories 
{
	public interface IEmpresaConfiguracaoRepository : IRepository<EmpresaConfiguracao> { }
	public interface IEmpresaConfiguracaoMongoRepository : IMongoRepository<EmpresaConfiguracao> { }

	public interface IEmpresaRepository : IRepository<Empresa> { }
	public interface IEmpresaMongoRepository : IMongoRepository<Empresa> { }

	public interface IGrupoEmpresaContactsRepository : IRepository<GrupoEmpresaContacts> { }
	public interface IGrupoEmpresaContactsMongoRepository : IMongoRepository<GrupoEmpresaContacts> { }

	public interface IGrupoEmpresaConfiguracaoRepository : IRepository<GrupoEmpresaConfiguracao> { }
	public interface IGrupoEmpresaConfiguracaoMongoRepository : IMongoRepository<GrupoEmpresaConfiguracao> { }

	public interface ICompaniesAggSettingsRepository : IRepository<CompaniesAggSettings> { }
	public interface ICompaniesAggSettingsMongoRepository : IMongoRepository<CompaniesAggSettings> { }

	public interface IGrupoEmpresaEnderecoRepository : IRepository<GrupoEmpresaEndereco> { }
	public interface IGrupoEmpresaEnderecoMongoRepository : IMongoRepository<GrupoEmpresaEndereco> { }

	public interface IGrupoEmpresaRepository : IRepository<GrupoEmpresa> { }
	public interface IGrupoEmpresaMongoRepository : IMongoRepository<GrupoEmpresa> { }

	public interface IEmpresaEnderecoRepository : IRepository<EmpresaEndereco> { }
	public interface IEmpresaEnderecoMongoRepository : IMongoRepository<EmpresaEndereco> { }

	public interface IEmpresaContactsRepository : IRepository<EmpresaContacts> { }
	public interface IEmpresaContactsMongoRepository : IMongoRepository<EmpresaContacts> { }

}
namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Repositories 
{
	public interface IProfissionalConfiguracaoRepository : IRepository<ProfissionalConfiguracao> { }
	public interface IProfissionalConfiguracaoMongoRepository : IMongoRepository<ProfissionalConfiguracao> { }

	public interface IFuncionarioRepository : IRepository<Funcionario> { }
	public interface IFuncionarioMongoRepository : IMongoRepository<Funcionario> { }

	public interface IProfissionalRepository : IRepository<Profissional> { }
	public interface IProfissionalMongoRepository : IMongoRepository<Profissional> { }

	public interface ICboRepository : IRepository<Cbo> { }
	public interface ICboMongoRepository : IMongoRepository<Cbo> { }

}
namespace Bravo.Companies.Domain.Aggregates.PatientsAgg.Repositories 
{
	public interface IPacienteRepository : IRepository<Paciente> { }
	public interface IPacienteMongoRepository : IMongoRepository<Paciente> { }

}
namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Repositories 
{
	public interface IAgendaExameRepository : IRepository<AgendaExame> { }
	public interface IAgendaExameMongoRepository : IMongoRepository<AgendaExame> { }

	public interface IFeriadoRepository : IRepository<Feriado> { }
	public interface IFeriadoMongoRepository : IMongoRepository<Feriado> { }

	public interface IAgendaProfissionalRepository : IRepository<AgendaProfissional> { }
	public interface IAgendaProfissionalMongoRepository : IMongoRepository<AgendaProfissional> { }

}
namespace Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Repositories 
{
	public interface IConvenioRepository : IRepository<Convenio> { }
	public interface IConvenioMongoRepository : IMongoRepository<Convenio> { }

}
namespace Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Repositories 
{
	public interface IProcedimentoRepository : IRepository<Procedimento> { }
	public interface IProcedimentoMongoRepository : IMongoRepository<Procedimento> { }

}
namespace Bravo.Companies.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
namespace Bravo.Companies.Domain.Aggregates.PartnersAgg.Repositories 
{
	public interface IFornecedorRepository : IRepository<Fornecedor> { }
	public interface IFornecedorMongoRepository : IMongoRepository<Fornecedor> { }

	public interface IPublicitarioRepository : IRepository<Publicitario> { }
	public interface IPublicitarioMongoRepository : IMongoRepository<Publicitario> { }

}
namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.Repositories 
{
	public interface IEnderecoRepository : IRepository<Endereco> { }
	public interface IEnderecoMongoRepository : IMongoRepository<Endereco> { }

}
