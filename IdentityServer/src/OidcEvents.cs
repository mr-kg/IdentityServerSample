using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using System.Threading.Tasks;

namespace IdentityServerHost
{
    public class OidcEvents : OpenIdConnectEvents
    {
        public override Task AuthorizationCodeReceived(AuthorizationCodeReceivedContext context)
        {
            return base.AuthorizationCodeReceived(context);
        }
    }
}
