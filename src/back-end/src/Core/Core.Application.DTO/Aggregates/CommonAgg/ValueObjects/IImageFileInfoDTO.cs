namespace SES.Core.Application.DTO.Aggregates.CommonAgg.ValueObjects
{
    public interface IImageFileInfoDTO
    {
        byte[] Image { get; set; }
        string Name { get; set; }
        string Src { get; }
        string Type { get; set; }
    }
}