using Crowe.Enterprise.Repository.Contract;
using Crowe.Enterprise.Repository.Data;
using Crowe.Infrastructure.UnitOfWork.Contracts;
using Crowe.Infrastructure.UnitOfWork.EntityFramework.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Repository
{
    public class HelloWorldRepository : BaseRepository, IHelloWorldRepository
    {
        /// <summary>
        /// This is for future database 
        /// </summary>
        IDemoDataContext _DemoDataContext;

        public HelloWorldRepository(IRepositoryContextProvider<DbContext> repositoryContextProvider) : base(repositoryContextProvider)
        {
            _DemoDataContext = repositoryContextProvider.GetRepositoryContext<IDemoDataContext>(ContextTypes.Scoring.ToString()).RepoContext as IDemoDataContext;

        }

        public async Task<string> GetHelloWorld()
        {

            await Task.Delay(5000);

            return "Hello World";
        }
    }
}
