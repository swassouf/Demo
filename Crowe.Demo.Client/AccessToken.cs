using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Crowe.Demo.Client
{
 public  class AccessToken
    {

        public DateTimeOffset? ExpiresAt { get; set; }

        public bool IsExpired => ExpiresAt <= DateTimeOffset.Now;

        public string RefreshToken { get; set; }

        public string Token { get; set; }

        public string Type { get; set; }

        public string GrantType { get; set; }

        public AccessToken()
        {
            // An empty constructor for JSON serialization.
        }

        public AccessToken(string token, string type, string grantType)
        {
            Token = token;
            Type = type;
            GrantType = grantType;
        }

        public AccessToken(TokenResponse tokenResponse, string grantType)
            : this(tokenResponse.AccessToken, tokenResponse.TokenType, grantType)
        {
            ExpiresAt = DateTimeOffset.Now.AddSeconds(tokenResponse.ExpiresIn);
            RefreshToken = tokenResponse.RefreshToken;
        }

      
    }
}
