
using AutoMapper;
using SES.Core.Application.DTO.Aggregates.CommonAgg.ValueObjects;
using SES.Core.Domain.Aggregates.CommonAgg.ValueObjects;

namespace SES.Core.Domain.Aggregates.CommonAgg.Profiles
{
    public partial class CoreAggProfile : Profile
	{
		public CoreAggProfile()
		{
			CreateMap<AutoSaveSettings, AutoSaveSettingsDTO>()
				.ReverseMap();
		}
	}
}

