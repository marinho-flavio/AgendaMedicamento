﻿using Companies.Adm.Panel.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Services.Contracts;
using System.Security.Claims;

namespace Services.Implementations
{
    public class IdentityAuthenticationStateProvider : AuthenticationStateProvider
    {
        private UserInfo _userInfoCache;
        private readonly IAuthorizeApi _authorizeApi;

        public IdentityAuthenticationStateProvider(IAuthorizeApi authorizeApi)
        {
            this._authorizeApi = authorizeApi;
        }

        public async Task Login(LoginParameters loginParameters)
        {
            await _authorizeApi.Login(loginParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task Register(RegisterParameters registerParameters)
        {
            await _authorizeApi.Register(registerParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task<HttpResponseMessage> ForgotPassword(ForgotPasswordParameters forgotPasswordParameters)
        {
            var result = await _authorizeApi.ForgotPassword(forgotPasswordParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            return result;
        }

        public async Task<HttpResponseMessage> CreatePassword(CreatePasswordParameters forgotPasswordParameters)
        {
            var result = await _authorizeApi.CreatePassword(forgotPasswordParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            return result;
        }

        public async Task Logout()
        {
            await _authorizeApi.Logout();
            _userInfoCache = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        private async Task<UserInfo> GetUserInfo()
        {
            if (_userInfoCache != null && _userInfoCache.IsAuthenticated) return _userInfoCache;
            _userInfoCache = await _authorizeApi.GetUserInfo();
            return _userInfoCache;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = await GetUserInfo();
                if (userInfo?.IsAuthenticated == true)
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, userInfo.UserName) }.Concat(userInfo.ExposedClaims.Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
    }
}