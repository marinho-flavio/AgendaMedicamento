
using SES.Users.Domain.Aggregates.CompaniesAgg.Entities; 
using SES.Users.Infra.Data.Aggregates.CompaniesAgg.Mappings; 
using SES.Users.Domain.Aggregates.UsersAgg.Entities; 
using SES.Users.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SES.Core.Infra.Data.Contexts;

namespace SES.Users.Infra.Data.Context
{
	public class UsersAggContext : BaseContext
	{
		public DbSet<Empresa> Empresa { get; set; }
		public DbSet<UsersAggSettings> UsersAggSettings { get; set; }
		public DbSet<User> User { get; set; }

		public UsersAggContext (MediatR.IMediator mediator, DbContextOptions<UsersAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new EmpresaMapping());
			builder.ApplyConfiguration(new UsersAggSettingsMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
