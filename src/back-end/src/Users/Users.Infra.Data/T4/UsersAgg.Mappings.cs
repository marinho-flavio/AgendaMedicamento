using SES.Users.Domain.Aggregates.CompaniesAgg.Entities;
using SES.Users.Domain.Aggregates.UsersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SES.Users.Infra.Data.Aggregates.CompaniesAgg.Mappings 
{
    public partial class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Empresa> builder);
    }
}
namespace SES.Users.Infra.Data.Aggregates.UsersAgg.Mappings 
{
    public partial class UsersAggSettingsMapping : IEntityTypeConfiguration<UsersAggSettings>
    {
        public void Configure(EntityTypeBuilder<UsersAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<UsersAggSettings> builder);
    }
    public partial class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<User> builder);
    }
}
