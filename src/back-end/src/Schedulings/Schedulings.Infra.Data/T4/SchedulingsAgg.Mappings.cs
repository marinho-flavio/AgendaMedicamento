using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities;
using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Entities;
using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Entities;
using SES.Schedulings.Domain.Aggregates.UsersAgg.Entities;
using SES.Schedulings.Domain.Aggregates.PartnersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SES.Schedulings.Infra.Data.Aggregates.CompaniesAgg.Mappings 
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
namespace SES.Schedulings.Infra.Data.Aggregates.SchedulingsAgg.Mappings 
{
    public partial class SchedulingsAggSettingsMapping : IEntityTypeConfiguration<SchedulingsAggSettings>
    {
        public void Configure(EntityTypeBuilder<SchedulingsAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<SchedulingsAggSettings> builder);
    }
    public partial class FeriadoMapping : IEntityTypeConfiguration<Feriado>
    {
        public void Configure(EntityTypeBuilder<Feriado> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Feriado> builder);
    }
}
namespace SES.Schedulings.Infra.Data.Aggregates.ProfessionalsAgg.Mappings 
{
    public partial class ProfissionalMapping : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Profissional> builder);
    }
}
namespace SES.Schedulings.Infra.Data.Aggregates.UsersAgg.Mappings 
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
namespace SES.Schedulings.Infra.Data.Aggregates.PartnersAgg.Mappings 
{
    public partial class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Fornecedor> builder);
    }
    public partial class PublicitarioMapping : IEntityTypeConfiguration<Publicitario>
    {
        public void Configure(EntityTypeBuilder<Publicitario> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Publicitario> builder);
    }
}
