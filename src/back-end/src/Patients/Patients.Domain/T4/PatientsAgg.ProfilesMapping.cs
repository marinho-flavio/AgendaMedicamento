using AutoMapper;
namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Profiles
{
    public class PatientsAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Profiles
{
	using Application.DTO.Aggregates.PatientsAgg.Requests;
	using Entities;
	public partial class PatientsAggProfile : Profile
	{
		public PatientsAggProfile()
		{
			CreateMap<PacienteDTO, Paciente>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Paciente, PacienteDTO>();
			CreateMap<PatientsAggSettingsDTO, PatientsAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<PatientsAggSettings, PatientsAggSettingsDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Patients.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
	public partial class UsersAggProfile : Profile
	{
		public UsersAggProfile()
		{
			CreateMap<UserDTO, User>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<User, UserDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

