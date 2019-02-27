using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowe.Infrastructure.UnitOfWork.Contracts
{
    public interface IRepositoryFactory
    {
        Repository GetRepositoryInstance<Repository>();
        
    }
}
