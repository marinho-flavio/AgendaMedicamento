using SES.Core.Domain.Aggregates.CommonAgg.Repositories;
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities;
using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Entities;
using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Entities;
using SES.Schedulings.Domain.Aggregates.UsersAgg.Entities;
using SES.Schedulings.Domain.Aggregates.PartnersAgg.Entities;

namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.Repositories 
{
	public interface IEmpresaRepository : IRepository<Empresa> { }
	public interface IEmpresaMongoRepository : IMongoRepository<Empresa> { }

}
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Repositories 
{
	public interface ISchedulingsAggSettingsRepository : IRepository<SchedulingsAggSettings> { }
	public interface ISchedulingsAggSettingsMongoRepository : IMongoRepository<SchedulingsAggSettings> { }

	public interface IFeriadoRepository : IRepository<Feriado> { }
	public interface IFeriadoMongoRepository : IMongoRepository<Feriado> { }

}
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Repositories 
{
	public interface IProfissionalRepository : IRepository<Profissional> { }
	public interface IProfissionalMongoRepository : IMongoRepository<Profissional> { }

}
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.Repositories 
{
	public interface IUserRepository : IRepository<User> { }
	public interface IUserMongoRepository : IMongoRepository<User> { }

}
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.Repositories 
{
	public interface IFornecedorRepository : IRepository<Fornecedor> { }
	public interface IFornecedorMongoRepository : IMongoRepository<Fornecedor> { }

	public interface IPublicitarioRepository : IRepository<Publicitario> { }
	public interface IPublicitarioMongoRepository : IMongoRepository<Publicitario> { }

}
