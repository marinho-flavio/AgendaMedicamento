

using Bravo.HealthPlans.Infra.Data.Aggregates.HealthPlansAgg.Repositories;
using Bravo.HealthPlans.Application.Aggregates.HealthPlansAgg.AppServices;
using Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Repositories;
using Bravo.HealthPlans.Infra.Data.Aggregates.UsersAgg.Repositories;
using Bravo.HealthPlans.Application.Aggregates.UsersAgg.AppServices;
using Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Repositories;
using Bravo.HealthPlans.Application.Aggregates.HealthPlansAgg.AppServices;
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

namespace Bravo.HealthPlans.Infra.IoC {

	using Infra.Data.Context;
	using Domain.Aggregates.HealthPlansAgg.CommandHandlers;
	

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
			services.AddMediatR(typeof(BaseHealthPlansAggCommandHandler).GetTypeInfo().Assembly);
						
		}

		void ConfigureLog(IServiceCollection services)
		{
			services.AddScoped<ILogRequestContext, LogRequestContext>();
			services.AddSingleton<ILogProvider, LoggerProvider>();
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<HealthPlansAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<IConvenioRepository, ConvenioRepository>();
            services.AddScoped<IConvenioMongoRepository, ConvenioMongoRepository>();
            services.AddScoped<IHealthPlansAggSettingsRepository, HealthPlansAggSettingsRepository>();
            services.AddScoped<IHealthPlansAggSettingsMongoRepository, HealthPlansAggSettingsMongoRepository>();
            services.AddScoped<IPlanoConvenioRepository, PlanoConvenioRepository>();
            services.AddScoped<IPlanoConvenioMongoRepository, PlanoConvenioMongoRepository>();
            services.AddScoped<ITipoPlanoRepository, TipoPlanoRepository>();
            services.AddScoped<ITipoPlanoMongoRepository, TipoPlanoMongoRepository>();
            services.AddScoped<IConvenioHorasEspeciaisRepository, ConvenioHorasEspeciaisRepository>();
            services.AddScoped<IConvenioHorasEspeciaisMongoRepository, ConvenioHorasEspeciaisMongoRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserMongoRepository, UserMongoRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<IConvenioAppService, ConvenioAppService>();
            services.AddScoped<IHealthPlansAggSettingsAppService, HealthPlansAggSettingsAppService>();
            services.AddScoped<IPlanoConvenioAppService, PlanoConvenioAppService>();
            services.AddScoped<ITipoPlanoAppService, TipoPlanoAppService>();
            services.AddScoped<IConvenioHorasEspeciaisAppService, ConvenioHorasEspeciaisAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}