﻿//// Licensed to the .NET Foundation under one or more agreements.
//// The .NET Foundation licenses this file to you under the MIT license.
//#nullable disable

//using System;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using System.Text.Encodings.Web;
//using System.Threading.Tasks;
//using SES.Core.Domain.Aggregates.CommonAgg.AppServices;
//using SES.CrossCuting.Infra.Utils.Extensions;
//using SES.Users.Application.Aggregates.UsersAgg.AppServices;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI.Services;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.WebUtilities;

//namespace Companies.Adm.Panel.Server.Areas.Identity.Pages.Account
//{
//    public class VerificationCodeModel : PageModel
//    {
//        private readonly UserManager<SES.Users.Identity.ApplicationUser> _userManager;
//        private readonly IEmailSender _emailSender;
//        [Inject] IUserAppService _userAppService { get; set; }

//        public VerificationCodeModel(UserManager<SES.Users.Identity.ApplicationUser> userManager, IEmailSender emailSender)
//        {
//            _userManager = userManager;
//            _emailSender = emailSender;
//        }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        [BindProperty]
//        public InputModel Input { get; set; }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        public class InputModel
//        {
//            /// <summary>
//            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//            ///     directly from your code. This API may change or be removed in future releases.
//            /// </summary>


//            [Required]
//            public string Email { get; set; }

//        }

//        public async Task<IActionResult> OnGetAsync(string email)
//        {
//            Input = new InputModel { Email = email };
//            return Page();
//        }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            if (ModelState.IsValid)
//            {

//                var user = await _userManager.FindByEmailAsync(Input.Email);
//                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
//                {
//                    // Don't reveal that the user does not exist or is not confirmed
//                    return RedirectToPage("./ForgotPasswordConfirmation");
//                }

//                var random = new Random();
//                user.RecoverPasswordCode = random.Next(1000, 9999);
//                user.RecoverPasswordCodeDate = DateTime.UtcNow;
//                await _userManager.UpdateAsync(user);

//                // For more information on how to enable account confirmation and password reset please
//                // visit https://go.microsoft.com/fwlink/?LinkID=532713
//                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
//                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
//                var callbackUrl = Url.Page(
//                    "/Account/ResetPassword",
//                    pageHandler: null,
//                    values: new { area = "Identity", code },
//                    protocol: Request.Scheme);

//                await _emailSender.SendEmailAsync(
//                    user.Email,
//                    "Reset Password",
//                    $"Please reset your password using this code: {user.RecoverPasswordCode}.");

//                return RedirectToPage("./CheckEmailCode", new { user.Email });
//            }

//            return Page();
//        }
//    }
//}
