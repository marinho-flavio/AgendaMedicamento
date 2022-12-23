
using AutoMapper;
using Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects;
using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;

namespace Bravo.Companies.Domain.Aggregates.CommonAgg.Profiles
{
    public partial class CoreAggProfile : Profile
	{
		public CoreAggProfile()
		{
			CreateMap<ImageFileInfo, ImageFileInfoDTO>()
				.ReverseMap();
		}
	}
}

