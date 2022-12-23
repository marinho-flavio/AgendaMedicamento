
using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.CompaniesAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.ProfessionalsAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.PatientsAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.PatientsAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.SchedulingsAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.HealthPlansAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.ClinicalProceduresAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.UsersAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.PartnersAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.PartnersAgg.Mappings; 
using Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities; 
using Bravo.Companies.Infra.Data.Aggregates.AddressesAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bravo.Core.Infra.Data.Contexts;

namespace Bravo.Companies.Infra.Data.Context
{
	public class CompaniesAggContext : BaseContext
	{
		public DbSet<EmpresaConfiguracao> EmpresaConfiguracao { get; set; }
		public DbSet<Empresa> Empresa { get; set; }
		public DbSet<GrupoEmpresaContacts> GrupoEmpresaContacts { get; set; }
		public DbSet<GrupoEmpresaConfiguracao> GrupoEmpresaConfiguracao { get; set; }
		public DbSet<CompaniesAggSettings> CompaniesAggSettings { get; set; }
		public DbSet<GrupoEmpresaEndereco> GrupoEmpresaEndereco { get; set; }
		public DbSet<GrupoEmpresa> GrupoEmpresa { get; set; }
		public DbSet<EmpresaEndereco> EmpresaEndereco { get; set; }
		public DbSet<EmpresaContacts> EmpresaContacts { get; set; }
		public DbSet<ProfissionalConfiguracao> ProfissionalConfiguracao { get; set; }
		public DbSet<Funcionario> Funcionario { get; set; }
		public DbSet<Profissional> Profissional { get; set; }
		public DbSet<Cbo> Cbo { get; set; }
		public DbSet<Paciente> Paciente { get; set; }
		public DbSet<AgendaExame> AgendaExame { get; set; }
		public DbSet<Feriado> Feriado { get; set; }
		public DbSet<AgendaProfissional> AgendaProfissional { get; set; }
		public DbSet<Convenio> Convenio { get; set; }
		public DbSet<Procedimento> Procedimento { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Fornecedor> Fornecedor { get; set; }
		public DbSet<Publicitario> Publicitario { get; set; }
		public DbSet<Endereco> Endereco { get; set; }

		public CompaniesAggContext (MediatR.IMediator mediator, DbContextOptions<CompaniesAggContext> options)
            : base(mediator, options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new EmpresaConfiguracaoMapping());
			builder.ApplyConfiguration(new EmpresaMapping());
			builder.ApplyConfiguration(new GrupoEmpresaContactsMapping());
			builder.ApplyConfiguration(new GrupoEmpresaConfiguracaoMapping());
			builder.ApplyConfiguration(new CompaniesAggSettingsMapping());
			builder.ApplyConfiguration(new GrupoEmpresaEnderecoMapping());
			builder.ApplyConfiguration(new GrupoEmpresaMapping());
			builder.ApplyConfiguration(new EmpresaEnderecoMapping());
			builder.ApplyConfiguration(new EmpresaContactsMapping());
			builder.ApplyConfiguration(new ProfissionalConfiguracaoMapping());
			builder.ApplyConfiguration(new FuncionarioMapping());
			builder.ApplyConfiguration(new ProfissionalMapping());
			builder.ApplyConfiguration(new CboMapping());
			builder.ApplyConfiguration(new PacienteMapping());
			builder.ApplyConfiguration(new AgendaExameMapping());
			builder.ApplyConfiguration(new FeriadoMapping());
			builder.ApplyConfiguration(new AgendaProfissionalMapping());
			builder.ApplyConfiguration(new ConvenioMapping());
			builder.ApplyConfiguration(new ProcedimentoMapping());
			builder.ApplyConfiguration(new UserMapping());
			builder.ApplyConfiguration(new FornecedorMapping());
			builder.ApplyConfiguration(new PublicitarioMapping());
			builder.ApplyConfiguration(new EnderecoMapping());
		
			base.OnModelCreating(builder);
		}
	}
}
