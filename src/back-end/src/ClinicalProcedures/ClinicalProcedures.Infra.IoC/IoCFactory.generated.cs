

using Bravo.ClinicalProcedures.Infra.Data.Aggregates.UsersAgg.Repositories;
using Bravo.ClinicalProcedures.Application.Aggregates.UsersAgg.AppServices;
using Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Repositories;
using Bravo.ClinicalProcedures.Infra.Data.Aggregates.ClinicalProceduresAgg.Repositories;
using Bravo.ClinicalProcedures.Application.Aggregates.ClinicalProceduresAgg.AppServices;
using Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Repositories;
using Bravo.ClinicalProcedures.Application.Aggregates.ClinicalProceduresAgg.AppServices;
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

namespace Bravo.ClinicalProcedures.Infra.IoC {

	using Infra.Data.Context;
	using Domain.Aggregates.ClinicalProceduresAgg.CommandHandlers;
	

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
			services.AddMediatR(typeof(BaseClinicalProceduresAggCommandHandler).GetTypeInfo().Assembly);
						
		}

		void ConfigureLog(IServiceCollection services)
		{
			services.AddScoped<ILogRequestContext, LogRequestContext>();
			services.AddSingleton<ILogProvider, LoggerProvider>();
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<ClinicalProceduresAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserMongoRepository, UserMongoRepository>();
            services.AddScoped<IClinicalProceduresAggSettingsRepository, ClinicalProceduresAggSettingsRepository>();
            services.AddScoped<IClinicalProceduresAggSettingsMongoRepository, ClinicalProceduresAggSettingsMongoRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IClinicalProceduresAggSettingsAppService, ClinicalProceduresAggSettingsAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}