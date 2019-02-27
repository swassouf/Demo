using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.Infrastructure.UnitOfWork.Contracts
{
    public interface IRepositoryContext<Context> where Context : class
    {
        Context GetRepositoryContext(Type contextType);
        Context RepoContext { get; }
    }
}
