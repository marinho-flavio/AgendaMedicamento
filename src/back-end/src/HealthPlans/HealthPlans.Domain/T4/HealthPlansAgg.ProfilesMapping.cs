using AutoMapper;
namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Profiles
{
    public class HealthPlansAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Profiles
{
	using Application.DTO.Aggregates.HealthPlansAgg.Requests;
	using Entities;
	public partial class HealthPlansAggProfile : Profile
	{
		public HealthPlansAggProfile()
		{
			CreateMap<ConvenioDTO, Convenio>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Convenio, ConvenioDTO>();
			CreateMap<HealthPlansAggSettingsDTO, HealthPlansAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<HealthPlansAggSettings, HealthPlansAggSettingsDTO>();
			CreateMap<PlanoConvenioDTO, PlanoConvenio>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<PlanoConvenio, PlanoConvenioDTO>();
			CreateMap<TipoPlanoDTO, TipoPlano>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<TipoPlano, TipoPlanoDTO>();
			CreateMap<ConvenioHorasEspeciaisDTO, ConvenioHorasEspeciais>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<ConvenioHorasEspeciais, ConvenioHorasEspeciaisDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Profiles
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

