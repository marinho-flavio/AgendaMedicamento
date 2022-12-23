using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Profiles
{
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Entities;
}
namespace Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Profiles
{
	using Application.DTO.Aggregates.SchedulingsAgg.Requests;
	using Entities;
	public partial class SchedulingsAggSettingsListiningProfile : Profile
	{
		public SchedulingsAggSettingsListiningProfile()
		{
			 CreateMap<SchedulingsAggSettings, SchedulingsAggSettingsListiningDTO>();
		}
	}
	public partial class AgendaExameListiningProfile : Profile
	{
		public AgendaExameListiningProfile()
		{
			 CreateMap<AgendaExame, AgendaExameListiningDTO>();
		}
	}
	public partial class AgendaSalaListiningProfile : Profile
	{
		public AgendaSalaListiningProfile()
		{
			 CreateMap<AgendaSala, AgendaSalaListiningDTO>();
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
			 CreateMap<AgendaProfissional, AgendaProfissionalListiningDTO>().ForMember(x=>x.Codigo, opt => opt.MapFrom(x=>x.Profissional.Cbo.Codigo)).ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Profissional.Cbo.Tipo)).ForMember(x=>x.Titulos, opt => opt.MapFrom(x=>x.Profissional.Cbo.Titulos));
		}
	}
}
namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Profiles
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
			 CreateMap<Funcionario, FuncionarioListiningDTO>().ForMember(x=>x.Codigo, opt => opt.MapFrom(x=>x.Cbo.Codigo)).ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Cbo.Tipo)).ForMember(x=>x.Titulos, opt => opt.MapFrom(x=>x.Cbo.Titulos));
		}
	}
	public partial class ProfissionalListiningProfile : Profile
	{
		public ProfissionalListiningProfile()
		{
			 CreateMap<Profissional, ProfissionalListiningDTO>().ForMember(x=>x.Codigo, opt => opt.MapFrom(x=>x.Cbo.Codigo)).ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Cbo.Tipo)).ForMember(x=>x.Titulos, opt => opt.MapFrom(x=>x.Cbo.Titulos));
		}
	}
	public partial class ProfessionalsAggSettingsListiningProfile : Profile
	{
		public ProfessionalsAggSettingsListiningProfile()
		{
			 CreateMap<ProfessionalsAggSettings, ProfessionalsAggSettingsListiningDTO>();
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
namespace Bravo.Professionals.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
}
