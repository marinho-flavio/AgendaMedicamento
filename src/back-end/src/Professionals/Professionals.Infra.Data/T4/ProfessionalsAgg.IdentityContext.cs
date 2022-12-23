
using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities; 
using Bravo.Professionals.Infra.Data.Aggregates.CompaniesAgg.Mappings; 
using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Entities; 
using Bravo.Professionals.Infra.Data.Aggregates.SchedulingsAgg.Mappings; 
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities; 
using Bravo.Professionals.Infra.Data.Aggregates.ProfessionalsAgg.Mappings; 
using Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities; 
using Bravo.Professionals.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bravo.Core.Infra.Data.Contexts;

namespace Bravo.Professionals.Infra.Data.Context
{
	public class ProfessionalsAggContext : BaseContext
	{
		public DbSet<Empresa> Empresa { get; set; }
		public DbSet<SchedulingsAggSettings> SchedulingsAggSettings { get; set; }
		public DbSet<AgendaExame> AgendaExame { get; set; }
		public DbSet<AgendaSala> AgendaSala { get; set; }
		public DbSet<Feriado> Feriado { get; set; }
		public DbSet<AgendaProfissional> AgendaProfissional { get; set; }
		public DbSet<ProfissionalConfiguracao> ProfissionalConfiguracao { get; set; }
		public DbSet<Funcionario> Funcionario { get; set; }
		public DbSet<Profissional> Profissional { get; set; }
		public DbSet<ProfessionalsAggSettings> ProfessionalsAggSettings { get; set; }
		public DbSet<Cbo> Cbo { get; set; }
		public DbSet<User> User { get; set; }

		public ProfessionalsAggContext (MediatR.IMediator mediator, DbContextOptions<ProfessionalsAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new EmpresaMapping());
			builder.ApplyConfiguration(new SchedulingsAggSettingsMapping());
			builder.ApplyConfiguration(new AgendaExameMapping());
			builder.ApplyConfiguration(new AgendaSalaMapping());
			builder.ApplyConfiguration(new FeriadoMapping());
			builder.ApplyConfiguration(new AgendaProfissionalMapping());
			builder.ApplyConfiguration(new ProfissionalConfiguracaoMapping());
			builder.ApplyConfiguration(new FuncionarioMapping());
			builder.ApplyConfiguration(new ProfissionalMapping());
			builder.ApplyConfiguration(new ProfessionalsAggSettingsMapping());
			builder.ApplyConfiguration(new CboMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
