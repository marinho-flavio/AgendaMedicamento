using Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities;
using Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bravo.HealthPlans.Infra.Data.Aggregates.HealthPlansAgg.Mappings 
{
    public partial class ConvenioMapping : IEntityTypeConfiguration<Convenio>
    {
        public void Configure(EntityTypeBuilder<Convenio> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Convenio> builder);
    }
    public partial class HealthPlansAggSettingsMapping : IEntityTypeConfiguration<HealthPlansAggSettings>
    {
        public void Configure(EntityTypeBuilder<HealthPlansAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<HealthPlansAggSettings> builder);
    }
    public partial class PlanoConvenioMapping : IEntityTypeConfiguration<PlanoConvenio>
    {
        public void Configure(EntityTypeBuilder<PlanoConvenio> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<PlanoConvenio> builder);
    }
    public partial class TipoPlanoMapping : IEntityTypeConfiguration<TipoPlano>
    {
        public void Configure(EntityTypeBuilder<TipoPlano> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<TipoPlano> builder);
    }
    public partial class ConvenioHorasEspeciaisMapping : IEntityTypeConfiguration<ConvenioHorasEspeciais>
    {
        public void Configure(EntityTypeBuilder<ConvenioHorasEspeciais> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<ConvenioHorasEspeciais> builder);
    }
}
namespace Bravo.HealthPlans.Infra.Data.Aggregates.UsersAgg.Mappings 
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
