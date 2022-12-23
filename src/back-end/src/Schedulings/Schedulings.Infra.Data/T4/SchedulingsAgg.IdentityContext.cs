
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities; 
using SES.Schedulings.Infra.Data.Aggregates.CompaniesAgg.Mappings; 
using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Entities; 
using SES.Schedulings.Infra.Data.Aggregates.SchedulingsAgg.Mappings; 
using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Entities; 
using SES.Schedulings.Infra.Data.Aggregates.ProfessionalsAgg.Mappings; 
using SES.Schedulings.Domain.Aggregates.UsersAgg.Entities; 
using SES.Schedulings.Infra.Data.Aggregates.UsersAgg.Mappings; 
using SES.Schedulings.Domain.Aggregates.PartnersAgg.Entities; 
using SES.Schedulings.Infra.Data.Aggregates.PartnersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SES.Core.Infra.Data.Contexts;

namespace SES.Schedulings.Infra.Data.Context
{
	public class SchedulingsAggContext : BaseContext
	{
		public DbSet<Empresa> Empresa { get; set; }
		public DbSet<SchedulingsAggSettings> SchedulingsAggSettings { get; set; }
		public DbSet<Feriado> Feriado { get; set; }
		public DbSet<Profissional> Profissional { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Fornecedor> Fornecedor { get; set; }
		public DbSet<Publicitario> Publicitario { get; set; }

		public SchedulingsAggContext (MediatR.IMediator mediator, DbContextOptions<SchedulingsAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new EmpresaMapping());
			builder.ApplyConfiguration(new SchedulingsAggSettingsMapping());
			builder.ApplyConfiguration(new FeriadoMapping());
			builder.ApplyConfiguration(new ProfissionalMapping());
			builder.ApplyConfiguration(new UserMapping());
			builder.ApplyConfiguration(new FornecedorMapping());
			builder.ApplyConfiguration(new PublicitarioMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
