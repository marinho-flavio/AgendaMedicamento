

using SES.Users.Infra.Data.Aggregates.CompaniesAgg.Repositories;
using SES.Users.Application.Aggregates.CompaniesAgg.AppServices;
using SES.Users.Domain.Aggregates.CompaniesAgg.Repositories;
using SES.Users.Infra.Data.Aggregates.UsersAgg.Repositories;
using SES.Users.Application.Aggregates.UsersAgg.AppServices;
using SES.Users.Domain.Aggregates.UsersAgg.Repositories;
using SES.Users.Application.Aggregates.UsersAgg.AppServices;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using SES.CrossCutting.Infra.Log.Contexts;
using SES.CrossCutting.Infra.Log.Providers;
using SES.Core.Domain.Aggregates.CommonAgg.Commands;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SES.Core.Application.DTO.Seedwork;
using SES.Core.Infra.IoC;

namespace SES.Users.Infra.IoC {

	using Infra.Data.Context;
	using Domain.Aggregates.UsersAgg.CommandHandlers;
	

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
			services.AddMediatR(typeof(BaseUsersAggCommandHandler).GetTypeInfo().Assembly);
						
		}

		void ConfigureLog(IServiceCollection services)
		{
			services.AddScoped<ILogRequestContext, LogRequestContext>();
			services.AddSingleton<ILogProvider, LoggerProvider>();
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<UsersAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEmpresaMongoRepository, EmpresaMongoRepository>();
            services.AddScoped<IUsersAggSettingsRepository, UsersAggSettingsRepository>();
            services.AddScoped<IUsersAggSettingsMongoRepository, UsersAggSettingsMongoRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserMongoRepository, UserMongoRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<IEmpresaAppService, EmpresaAppService>();
            services.AddScoped<IUsersAggSettingsAppService, UsersAggSettingsAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}