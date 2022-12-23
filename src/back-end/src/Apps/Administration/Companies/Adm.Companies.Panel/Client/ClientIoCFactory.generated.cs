
using FluentValidation;
namespace SES.Companies.Adm.Panel.Client {
    public static partial class IoCFactory {
       
		public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration) {
            ConfigureValidators(services);
		}

        static void ConfigureValidators(IServiceCollection services) {
			services.AddValidatorsFromAssemblyContaining
				<Companies.Application.DTO.Aggregates.CompaniesAgg.Validators.BaseCompaniesAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Validators.BaseProfessionalsAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<Patients.Application.DTO.Aggregates.PatientsAgg.Validators.BasePatientsAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Validators.BaseSchedulingsAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Validators.BaseHealthPlansAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<Partners.Application.DTO.Aggregates.PartnersAgg.Validators.BasePartnersAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			
		}
    }
}