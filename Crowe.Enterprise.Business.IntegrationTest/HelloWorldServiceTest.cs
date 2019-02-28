using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;
using Crowe.Ioc;
using Crowe.Enterprise.Business.Contract;
using System.Threading.Tasks;
using FluentAssertions;

namespace Crowe.Enterprise.Business.IntegrationTest
{
    public class HelloWorldServiceTest
    {
        ServiceProvider _ServiceProvider;

        public HelloWorldServiceTest()
        {
            var services = new ServiceCollection();
            services.AddCroweService();

            this._ServiceProvider = services.BuildServiceProvider();
        }

        [Fact]
        public async Task Hello_World_NotNull()
        {
            var helloWorldService = this._ServiceProvider.GetService<IHelloWorldService>();

            var result = await helloWorldService.GetHelloWorld();

            result.Should().NotBeNull();
            result.Should().Be("Hello World");
        }
    }
}
