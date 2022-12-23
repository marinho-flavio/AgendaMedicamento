using Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Entities;
using Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bravo.ClinicalProcedures.Infra.Data.Aggregates.UsersAgg.Mappings 
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
namespace Bravo.ClinicalProcedures.Infra.Data.Aggregates.ClinicalProceduresAgg.Mappings 
{
    public partial class ClinicalProceduresAggSettingsMapping : IEntityTypeConfiguration<ClinicalProceduresAggSettings>
    {
        public void Configure(EntityTypeBuilder<ClinicalProceduresAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<ClinicalProceduresAggSettings> builder);
    }
}
