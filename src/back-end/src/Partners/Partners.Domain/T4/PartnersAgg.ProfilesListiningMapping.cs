using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Partners.Domain.Aggregates.CompaniesAgg.Profiles
{
	using Application.DTO.Aggregates.CompaniesAgg.Requests;
	using Entities;
}
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Profiles
{
	using Application.DTO.Aggregates.PartnersAgg.Requests;
	using Entities;
	public partial class FornecedorListiningProfile : Profile
	{
		public FornecedorListiningProfile()
		{
			 CreateMap<Fornecedor, FornecedorListiningDTO>().ForMember(x=>x.Nome, opt => opt.MapFrom(x=>x.Nome)).ForMember(x=>x.Cpf, opt => opt.MapFrom(x=>x.Cpf));
		}
	}
	public partial class PublicitarioListiningProfile : Profile
	{
		public PublicitarioListiningProfile()
		{
			 CreateMap<Publicitario, PublicitarioListiningDTO>().ForMember(x=>x.Cpf, opt => opt.MapFrom(x=>x.Fornecedor.Cpf)).ForMember(x=>x.Nome, opt => opt.MapFrom(x=>x.Fornecedor.Nome));
		}
	}
	public partial class PartnersAggSettingsListiningProfile : Profile
	{
		public PartnersAggSettingsListiningProfile()
		{
			 CreateMap<PartnersAggSettings, PartnersAggSettingsListiningDTO>();
		}
	}
}
namespace Bravo.Partners.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
}
