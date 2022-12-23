using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.Profiles
{
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Entities;
	public partial class EnderecoListiningProfile : Profile
	{
		public EnderecoListiningProfile()
		{
			 CreateMap<Endereco, EnderecoListiningDTO>();
		}
	}
	public partial class AddressesAggSettingsListiningProfile : Profile
	{
		public AddressesAggSettingsListiningProfile()
		{
			 CreateMap<AddressesAggSettings, AddressesAggSettingsListiningDTO>();
		}
	}
}
namespace Bravo.Addresses.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
}
