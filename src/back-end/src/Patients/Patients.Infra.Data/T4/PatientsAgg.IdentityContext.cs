
using Bravo.Patients.Domain.Aggregates.PatientsAgg.Entities; 
using Bravo.Patients.Infra.Data.Aggregates.PatientsAgg.Mappings; 
using Bravo.Patients.Domain.Aggregates.UsersAgg.Entities; 
using Bravo.Patients.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bravo.Core.Infra.Data.Contexts;

namespace Bravo.Patients.Infra.Data.Context
{
	public class PatientsAggContext : BaseContext
	{
		public DbSet<Paciente> Paciente { get; set; }
		public DbSet<PatientsAggSettings> PatientsAggSettings { get; set; }
		public DbSet<User> User { get; set; }

		public PatientsAggContext (MediatR.IMediator mediator, DbContextOptions<PatientsAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new PacienteMapping());
			builder.ApplyConfiguration(new PatientsAggSettingsMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
