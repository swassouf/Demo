
using Crowe.Infrastructure.UnitOfWork.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Crowe.Infrastructure.UnitOfWork.EntityFramework
{
    public class RepositoryFactory : IRepositoryFactory
    {
        IServiceProvider _IServiceProvider;

        public RepositoryFactory(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                throw new ArgumentNullException("IServiceProvider");
            }

            _IServiceProvider = serviceProvider;

        }

        public Repository GetRepositoryInstance<Repository>() 
        {
            return _IServiceProvider.GetService<Repository>();
        }
    }
}
