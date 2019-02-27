using Crowe.Infrastructure.UnitOfWork.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Crowe.Infrastructure.UnitOfWork.EntityFramework
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        IRepositoryFactory _repositoryFactory;
        IRepositoryContextProvider<DbContext> _repositoryContextProvider;


        public UnitOfWorkFactory(IRepositoryFactory repositoryFactory, IRepositoryContextProvider<DbContext> repositoryContextProvider)
        {
            if (repositoryFactory == null)
            {
                throw new ArgumentNullException("repositoryFactory");
            }
            if (repositoryContextProvider == null)
            {
                throw new ArgumentNullException("repositoryContextProvider");
            }

            _repositoryFactory = repositoryFactory;
            _repositoryContextProvider = repositoryContextProvider;
           
        }
        public IUnitOfWork GetUnitOfWork()
        {
            return GetUnitOfWork(IsolationLevel.ReadCommitted);
        }

        public IUnitOfWork GetUnitOfWork(IsolationLevel isolationLevel)
        {
            _repositoryContextProvider.ClearActiveContexts();
            return new UnitOfWork(_repositoryFactory, _repositoryContextProvider, true, null);
        }

        public IUnitOfWork GetUnitOfWorkWithoutTransaction()
        {
            _repositoryContextProvider.ClearActiveContexts();
            return new UnitOfWork(_repositoryFactory, _repositoryContextProvider, false);
        }

    }
}
