using Bravo.Core.Domain.Aggregates.CommonAgg.Repositories;
using Bravo.Patients.Domain.Aggregates.PatientsAgg.Entities;
using Bravo.Patients.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Repositories 
{
	public interface IPacienteRepository : IRepository<Paciente> { }
	public interface IPacienteMongoRepository : IMongoRepository<Paciente> { }

	public interface IPatientsAggSettingsRepository : IRepository<PatientsAggSettings> { }
	public interface IPatientsAggSettingsMongoRepository : IMongoRepository<PatientsAggSettings> { }

}
namespace Bravo.Patients.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
