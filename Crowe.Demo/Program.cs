using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Crowe.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
             
            ClientManager client = new ClientManager();

            var helloWorld = client.GetHelloWorld();
            Task.WaitAll(helloWorld);
            Console.WriteLine(helloWorld.Result);

            Console.ReadKey();
        }

       
    }
}
