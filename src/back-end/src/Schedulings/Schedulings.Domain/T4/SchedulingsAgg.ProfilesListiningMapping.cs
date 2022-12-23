using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using SES.Core.Application.DTO.Attributes;
namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.Profiles
{
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Entities;
	public partial class EmpresaListiningProfile : Profile
	{
		public EmpresaListiningProfile()
		{
			 CreateMap<Empresa, EmpresaListiningDTO>();
		}
	}
}
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Profiles
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
	public partial class FeriadoListiningProfile : Profile
	{
		public FeriadoListiningProfile()
		{
			 CreateMap<Feriado, FeriadoListiningDTO>().ForMember(x=>x.Data, opt => opt.MapFrom(x=>x.Data)).ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Tipo));
		}
	}
}
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Profiles
{
	using Application.DTO.Aggregates.ProfessionalsAgg.Requests;
	using Entities;
	public partial class ProfissionalListiningProfile : Profile
	{
		public ProfissionalListiningProfile()
		{
			 CreateMap<Profissional, ProfissionalListiningDTO>();
		}
	}
}
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
	public partial class UserListiningProfile : Profile
	{
		public UserListiningProfile()
		{
			 CreateMap<User, UserListiningDTO>();
		}
	}
}
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.Profiles
{
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Entities;
	public partial class FornecedorListiningProfile : Profile
	{
		public FornecedorListiningProfile()
		{
			 CreateMap<Fornecedor, FornecedorListiningDTO>().ForMember(x=>x.Nome, opt => opt.MapFrom(x=>x.Nome));
		}
	}
	public partial class PublicitarioListiningProfile : Profile
	{
		public PublicitarioListiningProfile()
		{
			 CreateMap<Publicitario, PublicitarioListiningDTO>().ForMember(x=>x.Nome, opt => opt.MapFrom(x=>x.Fornecedor.Nome));
		}
	}
}
