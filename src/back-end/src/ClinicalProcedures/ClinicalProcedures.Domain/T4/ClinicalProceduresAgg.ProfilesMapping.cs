using AutoMapper;
namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Profiles
{
    public class ClinicalProceduresAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Profiles
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

namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Profiles
{
	using Application.DTO.Aggregates.ClinicalProceduresAgg.Requests;
	using Entities;
	public partial class ClinicalProceduresAggProfile : Profile
	{
		public ClinicalProceduresAggProfile()
		{
			CreateMap<ClinicalProceduresAggSettingsDTO, ClinicalProceduresAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<ClinicalProceduresAggSettings, ClinicalProceduresAggSettingsDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

