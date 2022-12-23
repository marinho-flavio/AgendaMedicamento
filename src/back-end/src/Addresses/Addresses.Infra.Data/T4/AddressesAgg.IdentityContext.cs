
using Bravo.Addresses.Domain.Aggregates.AddressesAgg.Entities; 
using Bravo.Addresses.Infra.Data.Aggregates.AddressesAgg.Mappings; 
using Bravo.Addresses.Domain.Aggregates.UsersAgg.Entities; 
using Bravo.Addresses.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bravo.Core.Infra.Data.Contexts;

namespace Bravo.Addresses.Infra.Data.Context
{
	public class AddressesAggContext : BaseContext
	{
		public DbSet<Endereco> Endereco { get; set; }
		public DbSet<AddressesAggSettings> AddressesAggSettings { get; set; }
		public DbSet<User> User { get; set; }

		public AddressesAggContext (MediatR.IMediator mediator, DbContextOptions<AddressesAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new EnderecoMapping());
			builder.ApplyConfiguration(new AddressesAggSettingsMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
