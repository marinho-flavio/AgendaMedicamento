using SES.Users.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;

namespace Companies.Adm.Panel.Server.Auth
{
    public class IdentityValidationProvider : RevalidatingServerAuthenticationStateProvider
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly IServiceScopeFactory _scopeFactory;
        public ApplicationUser User { get; set; }

        public IdentityValidationProvider(ILoggerFactory loggerFactory, IServiceScopeFactory scopeFactory) : base(loggerFactory)
        {
            this._loggerFactory = loggerFactory;
            this._scopeFactory = scopeFactory;
        }

        protected override TimeSpan RevalidationInterval => throw new NotImplementedException();

        protected override async Task<bool> ValidateAuthenticationStateAsync(AuthenticationState authenticationState, CancellationToken cancellationToken)
        {
            var userManager = _scopeFactory.CreateScope().ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            this.User = await userManager.GetUserAsync(authenticationState.User);
            throw new NotImplementedException();
        }
    }
}
