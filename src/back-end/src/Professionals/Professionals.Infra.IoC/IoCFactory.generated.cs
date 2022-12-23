

using Bravo.Professionals.Infra.Data.Aggregates.SchedulingsAgg.Repositories;
using Bravo.Professionals.Application.Aggregates.SchedulingsAgg.AppServices;
using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Repositories;
using Bravo.Professionals.Infra.Data.Aggregates.ProfessionalsAgg.Repositories;
using Bravo.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Repositories;
using Bravo.Professionals.Infra.Data.Aggregates.UsersAgg.Repositories;
using Bravo.Professionals.Application.Aggregates.UsersAgg.AppServices;
using Bravo.Professionals.Domain.Aggregates.UsersAgg.Repositories;
using Bravo.Professionals.Application.Aggregates.ProfessionalsAgg.AppServices;
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

namespace Bravo.Professionals.Infra.IoC {

	using Infra.Data.Context;
	using Domain.Aggregates.ProfessionalsAgg.CommandHandlers;
	

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
			services.AddMediatR(typeof(BaseProfessionalsAggCommandHandler).GetTypeInfo().Assembly);
						
		}

		void ConfigureLog(IServiceCollection services)
		{
			services.AddScoped<ILogRequestContext, LogRequestContext>();
			services.AddSingleton<ILogProvider, LoggerProvider>();
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<ProfessionalsAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<ISchedulingsAggSettingsRepository, SchedulingsAggSettingsRepository>();
            services.AddScoped<ISchedulingsAggSettingsMongoRepository, SchedulingsAggSettingsMongoRepository>();
            services.AddScoped<IAgendaExameRepository, AgendaExameRepository>();
            services.AddScoped<IAgendaExameMongoRepository, AgendaExameMongoRepository>();
            services.AddScoped<IAgendaSalaRepository, AgendaSalaRepository>();
            services.AddScoped<IAgendaSalaMongoRepository, AgendaSalaMongoRepository>();
            services.AddScoped<IFeriadoRepository, FeriadoRepository>();
            services.AddScoped<IFeriadoMongoRepository, FeriadoMongoRepository>();
            services.AddScoped<IAgendaProfissionalRepository, AgendaProfissionalRepository>();
            services.AddScoped<IAgendaProfissionalMongoRepository, AgendaProfissionalMongoRepository>();
            services.AddScoped<IProfissionalConfiguracaoRepository, ProfissionalConfiguracaoRepository>();
            services.AddScoped<IProfissionalConfiguracaoMongoRepository, ProfissionalConfiguracaoMongoRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IFuncionarioMongoRepository, FuncionarioMongoRepository>();
            services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
            services.AddScoped<IProfissionalMongoRepository, ProfissionalMongoRepository>();
            services.AddScoped<IProfessionalsAggSettingsRepository, ProfessionalsAggSettingsRepository>();
            services.AddScoped<IProfessionalsAggSettingsMongoRepository, ProfessionalsAggSettingsMongoRepository>();
            services.AddScoped<ICboRepository, CboRepository>();
            services.AddScoped<ICboMongoRepository, CboMongoRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserMongoRepository, UserMongoRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<ISchedulingsAggSettingsAppService, SchedulingsAggSettingsAppService>();
            services.AddScoped<IAgendaExameAppService, AgendaExameAppService>();
            services.AddScoped<IAgendaSalaAppService, AgendaSalaAppService>();
            services.AddScoped<IFeriadoAppService, FeriadoAppService>();
            services.AddScoped<IAgendaProfissionalAppService, AgendaProfissionalAppService>();
            services.AddScoped<IProfissionalConfiguracaoAppService, ProfissionalConfiguracaoAppService>();
            services.AddScoped<IFuncionarioAppService, FuncionarioAppService>();
            services.AddScoped<IProfissionalAppService, ProfissionalAppService>();
            services.AddScoped<IProfessionalsAggSettingsAppService, ProfessionalsAggSettingsAppService>();
            services.AddScoped<ICboAppService, CboAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}