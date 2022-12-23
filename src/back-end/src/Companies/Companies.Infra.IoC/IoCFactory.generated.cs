

using Bravo.Companies.Infra.Data.Aggregates.CompaniesAgg.Repositories;
using Bravo.Companies.Application.Aggregates.CompaniesAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Repositories;
using Bravo.Companies.Infra.Data.Aggregates.ProfessionalsAgg.Repositories;
using Bravo.Companies.Application.Aggregates.ProfessionalsAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Repositories;
using Bravo.Companies.Infra.Data.Aggregates.PatientsAgg.Repositories;
using Bravo.Companies.Application.Aggregates.PatientsAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.PatientsAgg.Repositories;
using Bravo.Companies.Infra.Data.Aggregates.SchedulingsAgg.Repositories;
using Bravo.Companies.Application.Aggregates.SchedulingsAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Repositories;
using Bravo.Companies.Infra.Data.Aggregates.HealthPlansAgg.Repositories;
using Bravo.Companies.Application.Aggregates.HealthPlansAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Repositories;
using Bravo.Companies.Infra.Data.Aggregates.UsersAgg.Repositories;
using Bravo.Companies.Application.Aggregates.UsersAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.UsersAgg.Repositories;
using Bravo.Companies.Infra.Data.Aggregates.PartnersAgg.Repositories;
using Bravo.Companies.Application.Aggregates.PartnersAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.PartnersAgg.Repositories;
using Bravo.Companies.Infra.Data.Aggregates.AddressesAgg.Repositories;
using Bravo.Companies.Application.Aggregates.AddressesAgg.AppServices;
using Bravo.Companies.Domain.Aggregates.AddressesAgg.Repositories;
using Bravo.Companies.Application.Aggregates.CompaniesAgg.AppServices;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Bravo.Core.Application.DTO.Seedwork;
using Bravo.Core.Infra.IoC;

namespace Bravo.Companies.Infra.IoC {

	using Infra.Data.Context;
	using Domain.Aggregates.CompaniesAgg.CommandHandlers;
	

    public partial class IoCFactory : IBaseIoC {
		
		partial void ConfigureFactories();
		partial void ConfigureValidators();
		partial void ConfigureAdditionalAppServices(IServiceCollection services);
		partial void ConfigureAdditionalRepositories();

        #region Constructor

        private static IoCFactory _current;
		public static IoCFactory Current { get { return _current ?? (_current = new IoCFactory()); } }

        #endregion

        #region Methods

        public void Configure(IConfiguration configuration, IServiceCollection services) {
			ConfigureFactories();
			ConfigureLog(services);
			ConfigureMediatR(services);
			ConfigureAppServices(services);
			ConfigureRepositories(services);
			ConfigureDatabase(services, configuration);
			ConfigureMappings();
        }

		void ConfigureMappings()
		{
			MapperFactory.Setup(this.GetType().Namespace.Replace("Infra.IoC","Domain"));
		}

		void ConfigureMediatR(IServiceCollection services)
		{
			services.AddMediatR(typeof(BaseCommand).GetTypeInfo().Assembly);
			services.AddMediatR(typeof(BaseCompaniesAggCommandHandler).GetTypeInfo().Assembly);
						
		}

		void ConfigureLog(IServiceCollection services)
		{
			services.AddScoped<ILogRequestContext, LogRequestContext>();
			services.AddSingleton<ILogProvider, LoggerProvider>();
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<CompaniesAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEmpresaMongoRepository, EmpresaMongoRepository>();
            services.AddScoped<ICompaniesAggSettingsRepository, CompaniesAggSettingsRepository>();
            services.AddScoped<ICompaniesAggSettingsMongoRepository, CompaniesAggSettingsMongoRepository>();
            services.AddScoped<IGrupoEmpresaRepository, GrupoEmpresaRepository>();
            services.AddScoped<IGrupoEmpresaMongoRepository, GrupoEmpresaMongoRepository>();
            services.AddScoped<IProfissionalConfiguracaoRepository, ProfissionalConfiguracaoRepository>();
            services.AddScoped<IProfissionalConfiguracaoMongoRepository, ProfissionalConfiguracaoMongoRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IFuncionarioMongoRepository, FuncionarioMongoRepository>();
            services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
            services.AddScoped<IProfissionalMongoRepository, ProfissionalMongoRepository>();
            services.AddScoped<ICboRepository, CboRepository>();
            services.AddScoped<ICboMongoRepository, CboMongoRepository>();
            services.AddScoped<IPacienteRepository, PacienteRepository>();
            services.AddScoped<IPacienteMongoRepository, PacienteMongoRepository>();
            services.AddScoped<IAgendaExameRepository, AgendaExameRepository>();
            services.AddScoped<IAgendaExameMongoRepository, AgendaExameMongoRepository>();
            services.AddScoped<IFeriadoRepository, FeriadoRepository>();
            services.AddScoped<IFeriadoMongoRepository, FeriadoMongoRepository>();
            services.AddScoped<IAgendaProfissionalRepository, AgendaProfissionalRepository>();
            services.AddScoped<IAgendaProfissionalMongoRepository, AgendaProfissionalMongoRepository>();
            services.AddScoped<IConvenioRepository, ConvenioRepository>();
            services.AddScoped<IConvenioMongoRepository, ConvenioMongoRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserMongoRepository, UserMongoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorMongoRepository, FornecedorMongoRepository>();
            services.AddScoped<IPublicitarioRepository, PublicitarioRepository>();
            services.AddScoped<IPublicitarioMongoRepository, PublicitarioMongoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEnderecoMongoRepository, EnderecoMongoRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<IEmpresaAppService, EmpresaAppService>();
            services.AddScoped<ICompaniesAggSettingsAppService, CompaniesAggSettingsAppService>();
            services.AddScoped<IGrupoEmpresaAppService, GrupoEmpresaAppService>();
            services.AddScoped<IProfissionalConfiguracaoAppService, ProfissionalConfiguracaoAppService>();
            services.AddScoped<IFuncionarioAppService, FuncionarioAppService>();
            services.AddScoped<IProfissionalAppService, ProfissionalAppService>();
            services.AddScoped<ICboAppService, CboAppService>();
            services.AddScoped<IPacienteAppService, PacienteAppService>();
            services.AddScoped<IAgendaExameAppService, AgendaExameAppService>();
            services.AddScoped<IFeriadoAppService, FeriadoAppService>();
            services.AddScoped<IAgendaProfissionalAppService, AgendaProfissionalAppService>();
            services.AddScoped<IConvenioAppService, ConvenioAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IFornecedorAppService, FornecedorAppService>();
            services.AddScoped<IPublicitarioAppService, PublicitarioAppService>();
            services.AddScoped<IEnderecoAppService, EnderecoAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}