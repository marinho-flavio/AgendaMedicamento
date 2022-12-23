using Companies.Adm.Panel.Shared.Models;

namespace Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task Login(LoginParameters loginParameters);
        Task Register(RegisterParameters registerParameters);
        Task<HttpResponseMessage> ForgotPassword(ForgotPasswordParameters forgotPasswordParameters);
        Task<HttpResponseMessage> CreatePassword(CreatePasswordParameters forgotPasswordParameters);
        Task Logout();
        Task<UserInfo> GetUserInfo();
    }
}
