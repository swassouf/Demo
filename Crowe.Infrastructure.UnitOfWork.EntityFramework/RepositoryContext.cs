using Crowe.Infrastructure.UnitOfWork.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Crowe.Infrastructure.UnitOfWork.EntityFramework
{
    public class RepositoryContext : IRepositoryContext<DbContext>
    {
        IServiceProvider _ServiceProvider;

        public RepositoryContext(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                throw new ArgumentNullException("serviceProvider");
            }

            _ServiceProvider = serviceProvider;
        }

        public DbContext RepoContext { get; private set; }

        public DbContext GetRepositoryContext(Type contextType)
        {
            RepoContext = _ServiceProvider.GetService(contextType) as DbContext;

           return RepoContext;
        }
    }
}
