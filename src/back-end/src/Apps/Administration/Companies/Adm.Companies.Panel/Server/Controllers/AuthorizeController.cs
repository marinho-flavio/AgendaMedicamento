using Companies.Adm.Panel.Shared.Models;
using SES.Users.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Humanizer;
using Syncfusion.Blazor.PivotView;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using System.Text;
using Companies.Adm.Panel.Server.Services;
using SES.Companies.Application.Aggregates.CompaniesAgg.AppServices;
using System.Runtime.Intrinsics.Arm;
using SES.Companies.Domain.Aggregates.CompaniesAgg.CommandModels;
using MediatR;
using SES.CrossCutting.Infra.Log.Contexts;

namespace BlazorWithIdentity.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthorizeController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly IEmpresaAppService _empresaAppService;
        protected readonly ILogRequestContext _logRequestContext;

        public AuthorizeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender, IEmpresaAppService empresaAppService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _empresaAppService = empresaAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginParameters parameters)
        {
            var user = await _userManager.FindByNameAsync(parameters.UserName);
            if (user == null) return BadRequest("User does not exist");
            var singInResult = await _signInManager.CheckPasswordSignInAsync(user, parameters.Password, false);
            if (!singInResult.Succeeded) return BadRequest("Invalid password");

            await _signInManager.SignInAsync(user, parameters.RememberMe);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordParameters forgotPasswordParameters)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(forgotPasswordParameters.Username);
                var userId = await _userManager.GetUserIdAsync(user);
                var email = await _userManager.GetEmailAsync(user);
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);

                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId = userId, code = code },
                    protocol: Request.Scheme);
                callbackUrl = callbackUrl.Replace("Identity/Account/ConfirmEmail", "login/criar-senha");
                await _emailSender.SendEmailAsync(
                    email,
                    "Confirm your email",
                    $"Cria uma nova senha através deste link: <a href='#'>Clique aqui</a>.");

                var StatusMessage = "Verification email sent. Please check your email.";

            }
            catch (Exception ex)
            {
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePassword(CreatePasswordParameters forgotPasswordParameters)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(forgotPasswordParameters.UserId);

                if (user == null) return BadRequest("Usuário não encontrado.");
                var result = await _userManager.ResetPasswordAsync(user, forgotPasswordParameters.Code, forgotPasswordParameters.Password);
                if (result.Succeeded)
                    return Ok();
                else
                    return BadRequest(result.Errors.Select(x => x.Description));
            }
            catch (Exception ex)
            {
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterParameters parameters)
        {
            var empresa = await _empresaAppService.Get(new SES.Companies.Domain.Aggregates.CompaniesAgg.Queries.Models.EmpresaQueryModel { });
            var id = Guid.NewGuid().ToString();
            if (empresa == null)
            {
                var request = new SES.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests.EmpresaDTO
                {
                    ExternalId = id,
                    NomeFantasia = "SES Saúde",
                    CNPJ = "0000000000",
                    CNES = "0000000000",
                    RazaoSocial = "SES Saúde"
                };
                request.Command = new CreateEmpresaCommand(_logRequestContext, request);
                await _empresaAppService.Create(request);
            }
            var user = new ApplicationUser();
            user.EmpresaId = await _empresaAppService.Select(
                    new SES.Companies.Domain.Aggregates.CompaniesAgg.Queries.Models.EmpresaQueryModel
                    {
                        ExternalIdEqual = id
                    },
                    x => x.Id);
            user.UserName = parameters.UserName;
            user.Email = parameters.UserName;
            user.EmailConfirmed = true;
            user.Name = "Nome teste";
            var result = await _userManager.CreateAsync(user, parameters.Password);
            if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);

            return await Login(new LoginParameters
            {
                UserName = parameters.UserName,
                Password = parameters.Password
            });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

        [HttpGet]
        public UserInfo UserInfo()
        {
            //var user = await _userManager.GetUserAsync(HttpContext.User);
            return BuildUserInfo();
        }


        private UserInfo BuildUserInfo()
        {
            return new UserInfo
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                ExposedClaims = User.Claims
                    //Optionally: filter the claims you want to expose to the client
                    //.Where(c => c.Type == "test-claim")
                    .ToDictionary(c => c.Type, c => c.Value)
            };
        }




    }
}
