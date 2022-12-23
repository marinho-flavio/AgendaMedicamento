

using SES.Schedulings.Infra.Data.Aggregates.CompaniesAgg.Repositories;
using SES.Schedulings.Application.Aggregates.CompaniesAgg.AppServices;
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Repositories;
using SES.Schedulings.Infra.Data.Aggregates.SchedulingsAgg.Repositories;
using SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices;
using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Repositories;
using SES.Schedulings.Infra.Data.Aggregates.ProfessionalsAgg.Repositories;
using SES.Schedulings.Application.Aggregates.ProfessionalsAgg.AppServices;
using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Repositories;
using SES.Schedulings.Infra.Data.Aggregates.UsersAgg.Repositories;
using SES.Schedulings.Application.Aggregates.UsersAgg.AppServices;
using SES.Schedulings.Domain.Aggregates.UsersAgg.Repositories;
using SES.Schedulings.Infra.Data.Aggregates.PartnersAgg.Repositories;
using SES.Schedulings.Application.Aggregates.PartnersAgg.AppServices;
using SES.Schedulings.Domain.Aggregates.PartnersAgg.Repositories;
using SES.Schedulings.Application.Aggregates.SchedulingsAgg.AppServices;
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

namespace SES.Schedulings.Infra.IoC {

	using Infra.Data.Context;
	using Domain.Aggregates.SchedulingsAgg.CommandHandlers;
	

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
			services.AddMediatR(typeof(BaseSchedulingsAggCommandHandler).GetTypeInfo().Assembly);
						
		}

		void ConfigureLog(IServiceCollection services)
		{
			services.AddScoped<ILogRequestContext, LogRequestContext>();
			services.AddSingleton<ILogProvider, LoggerProvider>();
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<SchedulingsAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEmpresaMongoRepository, EmpresaMongoRepository>();
            services.AddScoped<ISchedulingsAggSettingsRepository, SchedulingsAggSettingsRepository>();
            services.AddScoped<ISchedulingsAggSettingsMongoRepository, SchedulingsAggSettingsMongoRepository>();
            services.AddScoped<IFeriadoRepository, FeriadoRepository>();
            services.AddScoped<IFeriadoMongoRepository, FeriadoMongoRepository>();
            services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
            services.AddScoped<IProfissionalMongoRepository, ProfissionalMongoRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserMongoRepository, UserMongoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorMongoRepository, FornecedorMongoRepository>();
            services.AddScoped<IPublicitarioRepository, PublicitarioRepository>();
            services.AddScoped<IPublicitarioMongoRepository, PublicitarioMongoRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<IEmpresaAppService, EmpresaAppService>();
            services.AddScoped<ISchedulingsAggSettingsAppService, SchedulingsAggSettingsAppService>();
            services.AddScoped<IFeriadoAppService, FeriadoAppService>();
            services.AddScoped<IProfissionalAppService, ProfissionalAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IFornecedorAppService, FornecedorAppService>();
            services.AddScoped<IPublicitarioAppService, PublicitarioAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}