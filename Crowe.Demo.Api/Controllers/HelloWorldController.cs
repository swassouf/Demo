using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crowe.Enterprise.Business.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Crowe.Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        IHelloWorldService _HelloWorldService;
        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            this._HelloWorldService = helloWorldService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<string>> Get()
        {
            var result = await this._HelloWorldService.GetHelloWorld();

            return result;
        }
    }
}