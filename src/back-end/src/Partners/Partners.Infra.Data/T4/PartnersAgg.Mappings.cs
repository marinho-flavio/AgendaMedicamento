using Bravo.Partners.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities;
using Bravo.Partners.Domain.Aggregates.UsersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bravo.Partners.Infra.Data.Aggregates.CompaniesAgg.Mappings 
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
namespace Bravo.Partners.Infra.Data.Aggregates.PartnersAgg.Mappings 
{
    public partial class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Fornecedor> builder);
    }
    public partial class PublicitarioMapping : IEntityTypeConfiguration<Publicitario>
    {
        public void Configure(EntityTypeBuilder<Publicitario> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Publicitario> builder);
    }
    public partial class PartnersAggSettingsMapping : IEntityTypeConfiguration<PartnersAggSettings>
    {
        public void Configure(EntityTypeBuilder<PartnersAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<PartnersAggSettings> builder);
    }
}
namespace Bravo.Partners.Infra.Data.Aggregates.UsersAgg.Mappings 
{
    public partial class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<User> builder);
    }
}
