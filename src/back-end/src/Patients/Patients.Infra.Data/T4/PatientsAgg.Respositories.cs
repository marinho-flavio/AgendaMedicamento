using Microsoft.Extensions.Configuration;
using Bravo.Core.Infra.Data.Repositories;
using Bravo.Patients.Infra.Data.Context;

using Bravo.Patients.Domain.Aggregates.PatientsAgg.Entities;
using Bravo.Patients.Domain.Aggregates.UsersAgg.Entities;

namespace Bravo.Patients.Infra.Data.Aggregates.PatientsAgg.Repositories
{
	using Bravo.Patients.Domain.Aggregates.PatientsAgg.Repositories;
	public partial class PacienteRepository : Repository<Paciente>, IPacienteRepository { public PacienteRepository(PatientsAggContext ctx) : base(ctx) { } }
	public partial class PacienteMongoRepository : MongoRepository<Paciente>, IPacienteMongoRepository { public PacienteMongoRepository(IConfiguration config) : base(config) { } }

	public partial class PatientsAggSettingsRepository : Repository<PatientsAggSettings>, IPatientsAggSettingsRepository { public PatientsAggSettingsRepository(PatientsAggContext ctx) : base(ctx) { } }
	public partial class PatientsAggSettingsMongoRepository : MongoRepository<PatientsAggSettings>, IPatientsAggSettingsMongoRepository { public PatientsAggSettingsMongoRepository(IConfiguration config) : base(config) { } }

}
namespace Bravo.Patients.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Bravo.Patients.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(PatientsAggContext ctx) : base(ctx) { } }
	public partial class UserMongoRepository : MongoRepository<User>, IUserMongoRepository { public UserMongoRepository(IConfiguration config) : base(config) { } }

}
