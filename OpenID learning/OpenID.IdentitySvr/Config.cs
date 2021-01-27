using IdentityServer4.Models;
using System.Collections.Generic;

namespace OpenID.IdentitySvr
{
    public class Config
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope
                {
                    Name = "OpenIDApi",
                    Emphasize=true
                }
            };
        }

        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("OpenIDApi", "Customer Api for OpenID")
                {
                    Scopes = new []{ "OpenIDApi" }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "OpenIDApi" }
                }
            };
        }
    }
}
