using AutoMapper;
namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Profiles
{
    public class ProfessionalsAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Profiles
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

namespace Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Profiles
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
			CreateMap<AgendaExameDTO, AgendaExame>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<AgendaExame, AgendaExameDTO>();
			CreateMap<AgendaSalaDTO, AgendaSala>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<AgendaSala, AgendaSalaDTO>();
			CreateMap<FeriadoDTO, Feriado>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Feriado, FeriadoDTO>();
			CreateMap<AgendaProfissionalDTO, AgendaProfissional>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<AgendaProfissional, AgendaProfissionalDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Profiles
{
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Entities;
	public partial class ProfessionalsAggProfile : Profile
	{
		public ProfessionalsAggProfile()
		{
			CreateMap<ProfissionalConfiguracaoDTO, ProfissionalConfiguracao>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<ProfissionalConfiguracao, ProfissionalConfiguracaoDTO>();
			CreateMap<FuncionarioDTO, Funcionario>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Funcionario, FuncionarioDTO>();
			CreateMap<ProfissionalDTO, Profissional>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Profissional, ProfissionalDTO>();
			CreateMap<ProfessionalsAggSettingsDTO, ProfessionalsAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<ProfessionalsAggSettings, ProfessionalsAggSettingsDTO>();
			CreateMap<CboDTO, Cbo>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Cbo, CboDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Professionals.Domain.Aggregates.UsersAgg.Profiles
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

