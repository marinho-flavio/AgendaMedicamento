using Bravo.Core.Domain.Aggregates.CommonAgg.Repositories;
using Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Entities;
using Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Entities;

namespace Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Repositories 
{
	public interface IClinicalProceduresAggSettingsRepository : IRepository<ClinicalProceduresAggSettings> { }
	public interface IClinicalProceduresAggSettingsMongoRepository : IMongoRepository<ClinicalProceduresAggSettings> { }

}
