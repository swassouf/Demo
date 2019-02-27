using Crowe.Infrastructure.UnitOfWork.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Business
{
    public abstract class BusinessServiceBase
    {
        protected IUnitOfWorkFactory UnitOfWorkFactory { get; private set; }

        protected BusinessServiceBase(IUnitOfWorkFactory unitOfWorkFactory)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
        }
    }
}
