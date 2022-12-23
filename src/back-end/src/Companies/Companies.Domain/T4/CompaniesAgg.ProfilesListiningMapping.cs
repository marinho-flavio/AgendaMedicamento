using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Profiles
{
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Entities;
	public partial class EmpresaListiningProfile : Profile
	{
		public EmpresaListiningProfile()
		{
			 CreateMap<Empresa, EmpresaListiningDTO>().ForMember(x=>x.Cidade_Localidade, opt => opt.MapFrom(x=>x.Endereco.Endereco.Cidade_Localidade));
		}
	}
	public partial class CompaniesAggSettingsListiningProfile : Profile
	{
		public CompaniesAggSettingsListiningProfile()
		{
			 CreateMap<CompaniesAggSettings, CompaniesAggSettingsListiningDTO>().ForMember(x=>x.Cidade_Localidade, opt => opt.MapFrom(x=>x.User.Empresa.Endereco.Endereco.Cidade_Localidade));
		}
	}
	public partial class GrupoEmpresaListiningProfile : Profile
	{
		public GrupoEmpresaListiningProfile()
		{
			 CreateMap<GrupoEmpresa, GrupoEmpresaListiningDTO>().ForMember(x=>x.Cidade_Localidade, opt => opt.MapFrom(x=>x.GrupoEmpresaEndereco.Endereco.Cidade_Localidade)).ForMember(x=>x.Email, opt => opt.MapFrom(x=>x.Contacts.Email)).ForMember(x=>x.Telefone, opt => opt.MapFrom(x=>x.Contacts.Telefone));
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Profiles
{
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Entities;
	public partial class ProfissionalConfiguracaoListiningProfile : Profile
	{
		public ProfissionalConfiguracaoListiningProfile()
		{
			 CreateMap<ProfissionalConfiguracao, ProfissionalConfiguracaoListiningDTO>();
		}
	}
	public partial class FuncionarioListiningProfile : Profile
	{
		public FuncionarioListiningProfile()
		{
			 CreateMap<Funcionario, FuncionarioListiningDTO>();
		}
	}
	public partial class ProfissionalListiningProfile : Profile
	{
		public ProfissionalListiningProfile()
		{
			 CreateMap<Profissional, ProfissionalListiningDTO>().ForMember(x=>x.Codigo, opt => opt.MapFrom(x=>x.Cbo.Codigo)).ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Cbo.Tipo)).ForMember(x=>x.Titulos, opt => opt.MapFrom(x=>x.Cbo.Titulos));
		}
	}
	public partial class CboListiningProfile : Profile
	{
		public CboListiningProfile()
		{
			 CreateMap<Cbo, CboListiningDTO>().ForMember(x=>x.Codigo, opt => opt.MapFrom(x=>x.Codigo)).ForMember(x=>x.Titulos, opt => opt.MapFrom(x=>x.Titulos)).ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Tipo));
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.PatientsAgg.Profiles
{
	using Application.DTO.Aggregates.PatientsAgg.Requests;
	using Entities;
	public partial class PacienteListiningProfile : Profile
	{
		public PacienteListiningProfile()
		{
			 CreateMap<Paciente, PacienteListiningDTO>();
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Profiles
{
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Entities;
	public partial class AgendaExameListiningProfile : Profile
	{
		public AgendaExameListiningProfile()
		{
			 CreateMap<AgendaExame, AgendaExameListiningDTO>();
		}
	}
	public partial class FeriadoListiningProfile : Profile
	{
		public FeriadoListiningProfile()
		{
			 CreateMap<Feriado, FeriadoListiningDTO>().ForMember(x=>x.Descricao, opt => opt.MapFrom(x=>x.Descricao)).ForMember(x=>x.Data, opt => opt.MapFrom(x=>x.Data)).ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Tipo));
		}
	}
	public partial class AgendaProfissionalListiningProfile : Profile
	{
		public AgendaProfissionalListiningProfile()
		{
			 CreateMap<AgendaProfissional, AgendaProfissionalListiningDTO>();
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Profiles
{
	using Application.DTO.Aggregates.HealthPlansAgg.Requests;
	using Entities;
	public partial class ConvenioListiningProfile : Profile
	{
		public ConvenioListiningProfile()
		{
			 CreateMap<Convenio, ConvenioListiningDTO>();
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Profiles
{
	using Application.DTO.Aggregates.ClinicalProceduresAgg.Requests;
	using Entities;
}
namespace Bravo.Companies.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
}
namespace Bravo.Companies.Domain.Aggregates.PartnersAgg.Profiles
{
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Entities;
	public partial class FornecedorListiningProfile : Profile
	{
		public FornecedorListiningProfile()
		{
			 CreateMap<Fornecedor, FornecedorListiningDTO>().ForMember(x=>x.Cidade_Localidade, opt => opt.MapFrom(x=>x.Empresa.Endereco.Endereco.Cidade_Localidade));
		}
	}
	public partial class PublicitarioListiningProfile : Profile
	{
		public PublicitarioListiningProfile()
		{
			 CreateMap<Publicitario, PublicitarioListiningDTO>().ForMember(x=>x.Cidade_Localidade, opt => opt.MapFrom(x=>x.Empresa.Endereco.Endereco.Cidade_Localidade));
		}
	}
}
namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.Profiles
{
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Entities;
}
