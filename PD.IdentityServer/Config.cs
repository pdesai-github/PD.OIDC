using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace PD.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
                { };

        public static IEnumerable<Client> Clients =>
            new Client[]
                {
                    new Client()
                    {
                        ClientName = "PD Client App",
                        ClientId = "pdclientapp",
                        AllowedGrantTypes = GrantTypes.Code,
                        RedirectUris=
                        {
                            "https://localhost:7294/signin-oidc"
                        },
                        PostLogoutRedirectUris=
                        {
                             "https://localhost:7294/signout-callback-oidc"
                        },
                        AllowedScopes=
                        {
                            IdentityServerConstants.StandardScopes.OpenId,
                            IdentityServerConstants.StandardScopes.Profile
                        },
                        ClientSecrets=
                        {
                            new Secret("Secret".Sha256())
                        },
                        RequireConsent = true
                    }
                };
    }
}