

using Bravo.Addresses.Infra.Data.Aggregates.AddressesAgg.Repositories;
using Bravo.Addresses.Application.Aggregates.AddressesAgg.AppServices;
using Bravo.Addresses.Domain.Aggregates.AddressesAgg.Repositories;
using Bravo.Addresses.Infra.Data.Aggregates.UsersAgg.Repositories;
using Bravo.Addresses.Application.Aggregates.UsersAgg.AppServices;
using Bravo.Addresses.Domain.Aggregates.UsersAgg.Repositories;
using Bravo.Addresses.Application.Aggregates.AddressesAgg.AppServices;
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

namespace Bravo.Addresses.Infra.IoC {

	using Infra.Data.Context;
	using Domain.Aggregates.AddressesAgg.CommandHandlers;
	

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
			services.AddMediatR(typeof(BaseAddressesAggCommandHandler).GetTypeInfo().Assembly);
						
		}

		void ConfigureLog(IServiceCollection services)
		{
			services.AddScoped<ILogRequestContext, LogRequestContext>();
			services.AddSingleton<ILogProvider, LoggerProvider>();
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<AddressesAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEnderecoMongoRepository, EnderecoMongoRepository>();
            services.AddScoped<IAddressesAggSettingsRepository, AddressesAggSettingsRepository>();
            services.AddScoped<IAddressesAggSettingsMongoRepository, AddressesAggSettingsMongoRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserMongoRepository, UserMongoRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<IEnderecoAppService, EnderecoAppService>();
            services.AddScoped<IAddressesAggSettingsAppService, AddressesAggSettingsAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}