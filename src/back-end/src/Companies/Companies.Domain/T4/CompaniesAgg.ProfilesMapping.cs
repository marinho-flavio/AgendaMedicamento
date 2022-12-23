using AutoMapper;
namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Profiles
{
    public class CompaniesAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Profiles
{
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Entities;
	public partial class CompaniesAggProfile : Profile
	{
		public CompaniesAggProfile()
		{
			CreateMap<EmpresaConfiguracaoDTO, EmpresaConfiguracao>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<EmpresaConfiguracao, EmpresaConfiguracaoDTO>();
			CreateMap<EmpresaDTO, Empresa>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Empresa, EmpresaDTO>();
			CreateMap<GrupoEmpresaContactsDTO, GrupoEmpresaContacts>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<GrupoEmpresaContacts, GrupoEmpresaContactsDTO>();
			CreateMap<GrupoEmpresaConfiguracaoDTO, GrupoEmpresaConfiguracao>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<GrupoEmpresaConfiguracao, GrupoEmpresaConfiguracaoDTO>();
			CreateMap<CompaniesAggSettingsDTO, CompaniesAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<CompaniesAggSettings, CompaniesAggSettingsDTO>();
			CreateMap<GrupoEmpresaEnderecoDTO, GrupoEmpresaEndereco>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<GrupoEmpresaEndereco, GrupoEmpresaEnderecoDTO>();
			CreateMap<GrupoEmpresaDTO, GrupoEmpresa>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<GrupoEmpresa, GrupoEmpresaDTO>();
			CreateMap<EmpresaEnderecoDTO, EmpresaEndereco>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<EmpresaEndereco, EmpresaEnderecoDTO>();
			CreateMap<EmpresaContactsDTO, EmpresaContacts>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<EmpresaContacts, EmpresaContactsDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Profiles
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
			CreateMap<CboDTO, Cbo>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Cbo, CboDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Companies.Domain.Aggregates.PatientsAgg.Profiles
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
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Profiles
{
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Entities;
	public partial class SchedulingsAggProfile : Profile
	{
		public SchedulingsAggProfile()
		{
			CreateMap<AgendaExameDTO, AgendaExame>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<AgendaExame, AgendaExameDTO>();
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

namespace Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Profiles
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
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Profiles
{
	using Application.DTO.Aggregates.ClinicalProceduresAgg.Requests;
	using Entities;
	public partial class ClinicalProceduresAggProfile : Profile
	{
		public ClinicalProceduresAggProfile()
		{
			CreateMap<ProcedimentoDTO, Procedimento>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Procedimento, ProcedimentoDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Bravo.Companies.Domain.Aggregates.UsersAgg.Profiles
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

namespace Bravo.Companies.Domain.Aggregates.PartnersAgg.Profiles
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

namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.Profiles
{
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Entities;
	public partial class AddressesAggProfile : Profile
	{
		public AddressesAggProfile()
		{
			CreateMap<EnderecoDTO, Endereco>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Endereco, EnderecoDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

