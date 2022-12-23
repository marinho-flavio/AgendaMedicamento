using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bravo.Professionals.Infra.Data.Aggregates.CompaniesAgg.Mappings 
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
namespace Bravo.Professionals.Infra.Data.Aggregates.SchedulingsAgg.Mappings 
{
    public partial class SchedulingsAggSettingsMapping : IEntityTypeConfiguration<SchedulingsAggSettings>
    {
        public void Configure(EntityTypeBuilder<SchedulingsAggSettings> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<SchedulingsAggSettings> builder);
    }
    public partial class AgendaExameMapping : IEntityTypeConfiguration<AgendaExame>
    {
        public void Configure(EntityTypeBuilder<AgendaExame> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<AgendaExame> builder);
    }
    public partial class AgendaSalaMapping : IEntityTypeConfiguration<AgendaSala>
    {
        public void Configure(EntityTypeBuilder<AgendaSala> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<AgendaSala> builder);
    }
    public partial class FeriadoMapping : IEntityTypeConfiguration<Feriado>
    {
        public void Configure(EntityTypeBuilder<Feriado> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Feriado> builder);
    }
    public partial class AgendaProfissionalMapping : IEntityTypeConfiguration<AgendaProfissional>
    {
        public void Configure(EntityTypeBuilder<AgendaProfissional> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<AgendaProfissional> builder);
    }
}
namespace Bravo.Professionals.Infra.Data.Aggregates.ProfessionalsAgg.Mappings 
{
    public partial class ProfissionalConfiguracaoMapping : IEntityTypeConfiguration<ProfissionalConfiguracao>
    {
        public void Configure(EntityTypeBuilder<ProfissionalConfiguracao> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<ProfissionalConfiguracao> builder);
    }
    public partial class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Funcionario> builder);
    }
    public partial class ProfissionalMapping : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Profissional> builder);
    }
    public partial class ProfessionalsAggSettingsMapping : IEntityTypeConfiguration<ProfessionalsAggSettings>
    {
        public void Configure(EntityTypeBuilder<ProfessionalsAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<ProfessionalsAggSettings> builder);
    }
    public partial class CboMapping : IEntityTypeConfiguration<Cbo>
    {
        public void Configure(EntityTypeBuilder<Cbo> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Cbo> builder);
    }
}
namespace Bravo.Professionals.Infra.Data.Aggregates.UsersAgg.Mappings 
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
