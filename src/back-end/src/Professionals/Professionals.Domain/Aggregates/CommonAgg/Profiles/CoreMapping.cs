
using AutoMapper;
using Bravo.Professionals.Application.DTO.Aggregates.CommonAgg.ValueObjects;
using Bravo.Professionals.Domain.Aggregates.CommonAgg.ValueObjects;

namespace Bravo.Professionals.Domain.Aggregates.CommonAgg.Profiles
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

