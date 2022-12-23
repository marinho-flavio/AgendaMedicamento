namespace SES.Core.Application.DTO.Aggregates.CommonAgg.Commands.Responses
{
    public class GetDTO : GetDTO<object>
    {

    }
    public class GetDTO<T>
        where T : class
    {
        public GetDTO() { }

        public GetDTO(T response)
        {
            Data = response;
        }

        public virtual bool Success
        {
            get { return Errors?.Any() != true; }
        }

        public static GetDTO Error(params string[] errors)
        {
            return new GetDTO { Errors = errors };
        }

        public void AddError(params string[] newErrors)
        {
            var list = Errors?.ToList() ?? new List<string>();
            list.AddRange(newErrors);
            Errors = list.ToArray();
        }

        public string[] Errors { get; set; }
        public T Data { get; set; }
    }
}
