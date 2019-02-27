using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Demo
{
    /// <summary>
    /// Manage http request using Crowe Demo Client 
    /// </summary>
    public class ClientManager
    {
        Crowe.Demo.Client.Client _CLient;
        public ClientManager()
        {
            _CLient = new Client.Client();
        }

        /// <summary>
        /// Get Hello World
        /// </summary>
        /// <returns>String Hello World</returns>
        public async Task<string> GetHelloWorld()
        {
            var response = await _CLient.GetRequestAsync<HttpResponseMessage>();

            var result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}
