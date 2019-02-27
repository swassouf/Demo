using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Crowe.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClientManager client = new ClientManager();
             
            Task.Run(async () =>  await client.GetHelloWorld());

            Console.ReadKey();
        }

        private async Task<string> GetHelloWorld()
        {
            Crowe.Demo.Client.Client client = new Client.Client();
            var result = await client.GetRequestAsync<HttpResponseMessage>();

            return result.Content.ToString();
        }
    }
}
