
using Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities; 
using Bravo.HealthPlans.Infra.Data.Aggregates.HealthPlansAgg.Mappings; 
using Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Entities; 
using Bravo.HealthPlans.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bravo.Core.Infra.Data.Contexts;

namespace Bravo.HealthPlans.Infra.Data.Context
{
	public class HealthPlansAggContext : BaseContext
	{
		public DbSet<Convenio> Convenio { get; set; }
		public DbSet<HealthPlansAggSettings> HealthPlansAggSettings { get; set; }
		public DbSet<PlanoConvenio> PlanoConvenio { get; set; }
		public DbSet<TipoPlano> TipoPlano { get; set; }
		public DbSet<ConvenioHorasEspeciais> ConvenioHorasEspeciais { get; set; }
		public DbSet<User> User { get; set; }

		public HealthPlansAggContext (MediatR.IMediator mediator, DbContextOptions<HealthPlansAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new ConvenioMapping());
			builder.ApplyConfiguration(new HealthPlansAggSettingsMapping());
			builder.ApplyConfiguration(new PlanoConvenioMapping());
			builder.ApplyConfiguration(new TipoPlanoMapping());
			builder.ApplyConfiguration(new ConvenioHorasEspeciaisMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
