using AutoMapper;
namespace SES.Users.Domain.Aggregates.UsersAgg.Profiles
{
    public class UsersAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace SES.Users.Domain.Aggregates.CompaniesAgg.Profiles
{
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Entities;
	public partial class CompaniesAggProfile : Profile
	{
		public CompaniesAggProfile()
		{
			CreateMap<EmpresaDTO, Empresa>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Empresa, EmpresaDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace SES.Users.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
	public partial class UsersAggProfile : Profile
	{
		public UsersAggProfile()
		{
			CreateMap<UsersAggSettingsDTO, UsersAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<UsersAggSettings, UsersAggSettingsDTO>();
			CreateMap<UserDTO, User>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<User, UserDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

