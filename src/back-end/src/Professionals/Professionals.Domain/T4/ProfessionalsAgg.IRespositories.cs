using Bravo.Core.Domain.Aggregates.CommonAgg.Repositories;
using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Repositories 
{
	public interface IEmpresaRepository : IRepository<Empresa> { }
	public interface IEmpresaMongoRepository : IMongoRepository<Empresa> { }

}
namespace Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Repositories 
{
	public interface ISchedulingsAggSettingsRepository : IRepository<SchedulingsAggSettings> { }
	public interface ISchedulingsAggSettingsMongoRepository : IMongoRepository<SchedulingsAggSettings> { }

	public interface IAgendaExameRepository : IRepository<AgendaExame> { }
	public interface IAgendaExameMongoRepository : IMongoRepository<AgendaExame> { }

	public interface IAgendaSalaRepository : IRepository<AgendaSala> { }
	public interface IAgendaSalaMongoRepository : IMongoRepository<AgendaSala> { }

	public interface IFeriadoRepository : IRepository<Feriado> { }
	public interface IFeriadoMongoRepository : IMongoRepository<Feriado> { }

	public interface IAgendaProfissionalRepository : IRepository<AgendaProfissional> { }
	public interface IAgendaProfissionalMongoRepository : IMongoRepository<AgendaProfissional> { }

}
namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Repositories 
{
	public interface IProfissionalConfiguracaoRepository : IRepository<ProfissionalConfiguracao> { }
	public interface IProfissionalConfiguracaoMongoRepository : IMongoRepository<ProfissionalConfiguracao> { }

	public interface IFuncionarioRepository : IRepository<Funcionario> { }
	public interface IFuncionarioMongoRepository : IMongoRepository<Funcionario> { }

	public interface IProfissionalRepository : IRepository<Profissional> { }
	public interface IProfissionalMongoRepository : IMongoRepository<Profissional> { }

	public interface IProfessionalsAggSettingsRepository : IRepository<ProfessionalsAggSettings> { }
	public interface IProfessionalsAggSettingsMongoRepository : IMongoRepository<ProfessionalsAggSettings> { }

	public interface ICboRepository : IRepository<Cbo> { }
	public interface ICboMongoRepository : IMongoRepository<Cbo> { }

}
namespace Bravo.Professionals.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
