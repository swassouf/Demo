using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Business.Contract
{
    public interface IHelloWorldService
    {
        /// <summary>
        /// Get Hello world 
        /// </summary>
        /// <returns></returns>
       Task<string> GetHelloWorld();
    }
}
