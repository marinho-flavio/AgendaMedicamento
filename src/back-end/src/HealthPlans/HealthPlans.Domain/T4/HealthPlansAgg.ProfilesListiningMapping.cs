using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Profiles
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
	public partial class HealthPlansAggSettingsListiningProfile : Profile
	{
		public HealthPlansAggSettingsListiningProfile()
		{
			 CreateMap<HealthPlansAggSettings, HealthPlansAggSettingsListiningDTO>();
		}
	}
	public partial class PlanoConvenioListiningProfile : Profile
	{
		public PlanoConvenioListiningProfile()
		{
			 CreateMap<PlanoConvenio, PlanoConvenioListiningDTO>();
		}
	}
	public partial class TipoPlanoListiningProfile : Profile
	{
		public TipoPlanoListiningProfile()
		{
			 CreateMap<TipoPlano, TipoPlanoListiningDTO>();
		}
	}
	public partial class ConvenioHorasEspeciaisListiningProfile : Profile
	{
		public ConvenioHorasEspeciaisListiningProfile()
		{
			 CreateMap<ConvenioHorasEspeciais, ConvenioHorasEspeciaisListiningDTO>();
		}
	}
}
namespace Bravo.HealthPlans.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
}
