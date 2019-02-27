using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace Crowe.Demo.Client
{
    public class Client
    {

        public async Task<AccessToken> GetAccessTokenAsync()
        {
            var client = new HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync("http://localhost:6622");
 
            // request token
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,
                ClientId = "client",
                ClientSecret = "secret",
                Scope = "api1"
            });

            return new AccessToken(tokenResponse, GrantTypes.AuthorizationCode);
        }

        public async Task<HttpResponseMessage> GetRequestAsync<T>()
        {
            var accessToken = await this.GetAccessTokenAsync();
            // call api
            var apiClient = new HttpClient();
            apiClient.SetBearerToken(accessToken.Token);

            var response = await apiClient.GetAsync("http://localhost:16738/api/HelloWorld");
          
            return response;
        }
    }
}
