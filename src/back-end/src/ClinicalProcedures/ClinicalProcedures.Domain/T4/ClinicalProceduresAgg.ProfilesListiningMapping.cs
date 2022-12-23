using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.ClinicalProcedures.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
}
namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.Profiles
{
	using Application.DTO.Aggregates.ClinicalProceduresAgg.Requests;
	using Entities;
	public partial class ClinicalProceduresAggSettingsListiningProfile : Profile
	{
		public ClinicalProceduresAggSettingsListiningProfile()
		{
			 CreateMap<ClinicalProceduresAggSettings, ClinicalProceduresAggSettingsListiningDTO>();
		}
	}
}
