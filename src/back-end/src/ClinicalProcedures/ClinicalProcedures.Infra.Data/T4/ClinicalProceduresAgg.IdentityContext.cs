
using Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Entities; 
using Bravo.ClinicalProcedures.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Entities; 
using Bravo.ClinicalProcedures.Infra.Data.Aggregates.ClinicalProceduresAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bravo.Core.Infra.Data.Contexts;

namespace Bravo.ClinicalProcedures.Infra.Data.Context
{
	public class ClinicalProceduresAggContext : BaseContext
	{
		public DbSet<User> User { get; set; }
		public DbSet<ClinicalProceduresAggSettings> ClinicalProceduresAggSettings { get; set; }

		public ClinicalProceduresAggContext (MediatR.IMediator mediator, DbContextOptions<ClinicalProceduresAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new UserMapping());
			builder.ApplyConfiguration(new ClinicalProceduresAggSettingsMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
