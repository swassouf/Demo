using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowe.Infrastructure.UnitOfWork.Contracts
{
    public interface IRepositoryContextProvider<Context> where Context : class
    {
        IRepositoryContext<Context> GetRepositoryContext<C>(string repositoryName); //where C : new();
        IDictionary<string, IRepositoryContext<Context>> ActiveContexts { get; }
        void ClearActiveContexts();

        //IRepositoryContext<Context> GetRepositoryContext(Context context);
    }
}
