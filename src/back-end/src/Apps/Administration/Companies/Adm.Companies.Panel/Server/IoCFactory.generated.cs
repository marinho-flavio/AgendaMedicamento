

using SES.Core.Infra.Data.Contexts;
using SES.Core.Infra.IoC;
using SES.Users.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
    
namespace SES.Companies.Adm.Panel.Server {
    public static partial class IoCFactory {
       
		public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration) {

            SES.Addresses.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            SES.Companies.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            SES.Users.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            SES.Professionals.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            SES.HealthPlans.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            SES.Patients.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            SES.Schedulings.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            SES.Partners.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
			
            SES.Users.Identity.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
		}

        public static void Migrate(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var contexts = (from asm in AppDomain.CurrentDomain.GetAssemblies()
                                from type in asm.GetTypes()
                                where type.IsClass && type.BaseType == typeof(BaseContext) || type.BaseType == typeof(IdentityDbContext<ApplicationUser>)
                                select type).ToArray();

                foreach (var item in contexts)
                {
                    (scope.ServiceProvider.GetRequiredService(item) as DbContext)
                        .Database.Migrate();
                }
            }
        }
    }
}