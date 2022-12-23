using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using SES.Core.Application.DTO.Attributes;
namespace SES.Users.Domain.Aggregates.CompaniesAgg.Profiles
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
namespace SES.Users.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
	public partial class UsersAggSettingsListiningProfile : Profile
	{
		public UsersAggSettingsListiningProfile()
		{
			 CreateMap<UsersAggSettings, UsersAggSettingsListiningDTO>();
		}
	}
	public partial class UserListiningProfile : Profile
	{
		public UserListiningProfile()
		{
			 CreateMap<User, UserListiningDTO>();
		}
	}
}
