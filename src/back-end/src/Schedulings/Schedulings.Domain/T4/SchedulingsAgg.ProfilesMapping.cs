using AutoMapper;
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Profiles
{
    public class SchedulingsAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.Profiles
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

namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Profiles
{
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Entities;
	public partial class SchedulingsAggProfile : Profile
	{
		public SchedulingsAggProfile()
		{
			CreateMap<SchedulingsAggSettingsDTO, SchedulingsAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<SchedulingsAggSettings, SchedulingsAggSettingsDTO>();
			CreateMap<FeriadoDTO, Feriado>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Feriado, FeriadoDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Profiles
{
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Entities;
	public partial class ProfessionalsAggProfile : Profile
	{
		public ProfessionalsAggProfile()
		{
			CreateMap<ProfissionalDTO, Profissional>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Profissional, ProfissionalDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace SES.Schedulings.Domain.Aggregates.UsersAgg.Profiles
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

namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.Profiles
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
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

