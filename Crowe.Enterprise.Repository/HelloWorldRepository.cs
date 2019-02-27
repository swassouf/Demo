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
        IScoringViewerDataContext _ScoringViewerDataContext;

        public HelloWorldRepository(IRepositoryContextProvider<DbContext> repositoryContextProvider) : base(repositoryContextProvider)
        {
            _ScoringViewerDataContext = repositoryContextProvider.GetRepositoryContext<IScoringViewerDataContext>(ContextTypes.Scoring.ToString()).RepoContext as IScoringViewerDataContext;

        }

        public async Task<string> GetHelloWorld()
        {

            await Task.Delay(5000);

            return "Hello World";
        }
    }
}
