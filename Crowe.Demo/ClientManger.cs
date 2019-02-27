using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Demo
{
    internal class ClientManager
    {
        Crowe.Demo.Client.Client _CLient; 
        internal ClientManager()
        {
            _CLient = new Client.Client();
        }

        public async Task GetHelloWorld()
        {
            var response = await _CLient.GetRequestAsync<HttpResponseMessage>();

            var result = await response.Content.ReadAsStringAsync();

        }
    }
}
