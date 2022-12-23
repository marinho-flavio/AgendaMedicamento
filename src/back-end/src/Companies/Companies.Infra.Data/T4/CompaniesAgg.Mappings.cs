using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.PatientsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Entities;
using Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Entities;
using Bravo.Companies.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Companies.Domain.Aggregates.PartnersAgg.Entities;
using Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bravo.Companies.Infra.Data.Aggregates.CompaniesAgg.Mappings 
{
    public partial class EmpresaConfiguracaoMapping : IEntityTypeConfiguration<EmpresaConfiguracao>
    {
        public void Configure(EntityTypeBuilder<EmpresaConfiguracao> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<EmpresaConfiguracao> builder);
    }
    public partial class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasOne(x => x.Endereco).WithOne().HasForeignKey<EmpresaEndereco>("Id");
            builder.HasOne(x => x.Contacts).WithOne().HasForeignKey<EmpresaContacts>("Id");
            builder.HasOne(x => x.Configuracao).WithOne().HasForeignKey<EmpresaConfiguracao>("Id");
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Empresa> builder);
    }
    public partial class GrupoEmpresaContactsMapping : IEntityTypeConfiguration<GrupoEmpresaContacts>
    {
        public void Configure(EntityTypeBuilder<GrupoEmpresaContacts> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<GrupoEmpresaContacts> builder);
    }
    public partial class GrupoEmpresaConfiguracaoMapping : IEntityTypeConfiguration<GrupoEmpresaConfiguracao>
    {
        public void Configure(EntityTypeBuilder<GrupoEmpresaConfiguracao> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<GrupoEmpresaConfiguracao> builder);
    }
    public partial class CompaniesAggSettingsMapping : IEntityTypeConfiguration<CompaniesAggSettings>
    {
        public void Configure(EntityTypeBuilder<CompaniesAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<CompaniesAggSettings> builder);
    }
    public partial class GrupoEmpresaEnderecoMapping : IEntityTypeConfiguration<GrupoEmpresaEndereco>
    {
        public void Configure(EntityTypeBuilder<GrupoEmpresaEndereco> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<GrupoEmpresaEndereco> builder);
    }
    public partial class GrupoEmpresaMapping : IEntityTypeConfiguration<GrupoEmpresa>
    {
        public void Configure(EntityTypeBuilder<GrupoEmpresa> builder)
        {
            builder.HasOne(x => x.GrupoEmpresaEndereco).WithOne().HasForeignKey<GrupoEmpresaEndereco>("Id");
            builder.HasOne(x => x.Contacts).WithOne().HasForeignKey<GrupoEmpresaContacts>("Id");
            builder.HasOne(x => x.GrupoEmpresaConfiguracao).WithOne().HasForeignKey<GrupoEmpresaConfiguracao>("Id");
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<GrupoEmpresa> builder);
    }
    public partial class EmpresaEnderecoMapping : IEntityTypeConfiguration<EmpresaEndereco>
    {
        public void Configure(EntityTypeBuilder<EmpresaEndereco> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<EmpresaEndereco> builder);
    }
    public partial class EmpresaContactsMapping : IEntityTypeConfiguration<EmpresaContacts>
    {
        public void Configure(EntityTypeBuilder<EmpresaContacts> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<EmpresaContacts> builder);
    }
}
namespace Bravo.Companies.Infra.Data.Aggregates.ProfessionalsAgg.Mappings 
{
    public partial class ProfissionalConfiguracaoMapping : IEntityTypeConfiguration<ProfissionalConfiguracao>
    {
        public void Configure(EntityTypeBuilder<ProfissionalConfiguracao> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<ProfissionalConfiguracao> builder);
    }
    public partial class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Funcionario> builder);
    }
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
    public partial class CboMapping : IEntityTypeConfiguration<Cbo>
    {
        public void Configure(EntityTypeBuilder<Cbo> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Cbo> builder);
    }
}
namespace Bravo.Companies.Infra.Data.Aggregates.PatientsAgg.Mappings 
{
    public partial class PacienteMapping : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Paciente> builder);
    }
}
namespace Bravo.Companies.Infra.Data.Aggregates.SchedulingsAgg.Mappings 
{
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
namespace Bravo.Companies.Infra.Data.Aggregates.HealthPlansAgg.Mappings 
{
    public partial class ConvenioMapping : IEntityTypeConfiguration<Convenio>
    {
        public void Configure(EntityTypeBuilder<Convenio> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Convenio> builder);
    }
}
namespace Bravo.Companies.Infra.Data.Aggregates.ClinicalProceduresAgg.Mappings 
{
    public partial class ProcedimentoMapping : IEntityTypeConfiguration<Procedimento>
    {
        public void Configure(EntityTypeBuilder<Procedimento> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Procedimento> builder);
    }
}
namespace Bravo.Companies.Infra.Data.Aggregates.UsersAgg.Mappings 
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
namespace Bravo.Companies.Infra.Data.Aggregates.PartnersAgg.Mappings 
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
namespace Bravo.Companies.Infra.Data.Aggregates.AddressesAgg.Mappings 
{
    public partial class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Endereco> builder);
    }
}
