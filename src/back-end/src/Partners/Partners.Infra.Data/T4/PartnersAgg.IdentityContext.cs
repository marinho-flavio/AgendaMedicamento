
using Bravo.Partners.Domain.Aggregates.CompaniesAgg.Entities; 
using Bravo.Partners.Infra.Data.Aggregates.CompaniesAgg.Mappings; 
using Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities; 
using Bravo.Partners.Infra.Data.Aggregates.PartnersAgg.Mappings; 
using Bravo.Partners.Domain.Aggregates.UsersAgg.Entities; 
using Bravo.Partners.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bravo.Core.Infra.Data.Contexts;

namespace Bravo.Partners.Infra.Data.Context
{
	public class PartnersAggContext : BaseContext
	{
		public DbSet<Empresa> Empresa { get; set; }
		public DbSet<Fornecedor> Fornecedor { get; set; }
		public DbSet<Publicitario> Publicitario { get; set; }
		public DbSet<PartnersAggSettings> PartnersAggSettings { get; set; }
		public DbSet<User> User { get; set; }

		public PartnersAggContext (MediatR.IMediator mediator, DbContextOptions<PartnersAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new EmpresaMapping());
			builder.ApplyConfiguration(new FornecedorMapping());
			builder.ApplyConfiguration(new PublicitarioMapping());
			builder.ApplyConfiguration(new PartnersAggSettingsMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
