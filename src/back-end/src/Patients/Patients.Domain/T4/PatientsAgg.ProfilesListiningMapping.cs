using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Profiles
{
	using Application.DTO.Aggregates.PatientsAgg.Requests;
	using Entities;
	public partial class PacienteListiningProfile : Profile
	{
		public PacienteListiningProfile()
		{
			 CreateMap<Paciente, PacienteListiningDTO>().ForMember(x=>x.Tipo, opt => opt.MapFrom(x=>x.Tipo));
		}
	}
	public partial class PatientsAggSettingsListiningProfile : Profile
	{
		public PatientsAggSettingsListiningProfile()
		{
			 CreateMap<PatientsAggSettings, PatientsAggSettingsListiningDTO>();
		}
	}
}
namespace Bravo.Patients.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
}
