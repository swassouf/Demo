using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Repository.Contract
{
    public interface IHelloWorldRepository
    {
        /// <summary>
        /// Get Hello World 
        /// </summary>
        /// <returns></returns>
        Task<string> GetHelloWorld();
    }
}
