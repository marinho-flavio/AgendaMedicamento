using AutoMapper;
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Profiles
{
    public class PartnersAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Bravo.Partners.Domain.Aggregates.CompaniesAgg.Profiles
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

namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Profiles
{
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Entities;
	public partial class PartnersAggProfile : Profile
	{
		public PartnersAggProfile()
		{
			CreateMap<FornecedorDTO, Fornecedor>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Fornecedor, FornecedorDTO>();
			CreateMap<PublicitarioDTO, Publicitario>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Publicitario, PublicitarioDTO>();
			CreateMap<PartnersAggSettingsDTO, PartnersAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<PartnersAggSettings, PartnersAggSettingsDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Partners.Domain.Aggregates.UsersAgg.Profiles
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

