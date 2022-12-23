using FluentValidation.Results;
using System.Net;

namespace SES.Core.Application.DTO.Aggregates.CommonAgg.Commands.Responses
{
    public partial class GetHttpResponseDTO : GetHttpResponseDTO<object>
    {
        public GetHttpResponseDTO() : base() { }
        public GetHttpResponseDTO(object response)
            : base(response)
        {
        }

        public GetHttpResponseDTO(HttpStatusCode response, string[] errors)
            :base(response, errors)
        {
        }
    }

    public partial class GetHttpResponseDTO<T> : GetDTO<T>
        where T : class
    {
        public GetHttpResponseDTO() : base() { }

        public override bool Success
        {
            get { return base.Success && StatusCode >= HttpStatusCode.OK && StatusCode < HttpStatusCode.Ambiguous; }
        }

        public HttpStatusCode StatusCode { get; private set; }

        public GetHttpResponseDTO(T response)
            : base(response)
        {
        }

        public GetHttpResponseDTO(HttpStatusCode response, string[] errors)
        {
            this.StatusCode = response;
            this.Errors = errors;
        }

        public static GetHttpResponseDTO<T> Ok(T response)
        {
            return new GetHttpResponseDTO<T>(response) { StatusCode = HttpStatusCode.OK };
        }

        public static GetHttpResponseDTO Ok()
        {
            return new GetHttpResponseDTO() { StatusCode = HttpStatusCode.OK };
        }

        public static GetHttpResponseDTO BadRequest(params string[] errors)
        {
            return Error(HttpStatusCode.BadRequest, errors);
        }

        public static GetHttpResponseDTO BadRequest(ValidationResult result)
        {
            return Error(HttpStatusCode.BadRequest, result.Errors?.Select(x=>x.ErrorMessage)?.ToArray() ?? new string[0]) ;
        }

        public static GetHttpResponseDTO NotFound(params string[] errors)
        {
            return Error(HttpStatusCode.NotFound, errors);
        }

        public static GetHttpResponseDTO Error(HttpStatusCode statusCode, params string[] errors)
        {
            return new GetHttpResponseDTO(statusCode, errors);
        }

        public static GetHttpResponseDTO<T> Error(HttpStatusCode statusCode, IEnumerable<string> errors)
        {
            return new GetHttpResponseDTO<T>(statusCode, errors: errors.ToArray());
        }
    }
}
