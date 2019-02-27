using Crowe.Infrastructure.UnitOfWork.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowe.Infrastructure.UnitOfWork.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        // private TransactionScope _transactionScope = null;
        private IRepositoryFactory _repositoryFactory = null;
        private IRepositoryContextProvider<DbContext> _repositoryContextProvider = null;
        // private ILogger _logger;

        public bool IsTransactional { get; private set; }

        public UnitOfWork(IRepositoryFactory repositoryFactory, IRepositoryContextProvider<DbContext> repositoryContextProvider, bool useTransaction)
            : this(repositoryFactory, repositoryContextProvider, useTransaction, null ) //IsolationLevel.ReadCommitted)
        {

        }

        public UnitOfWork(IRepositoryFactory repositoryFactory, IRepositoryContextProvider<DbContext> repositoryContextProvider, bool useTransaction, int? level) //IsolationLevel isolationLevel)
        {
            if (repositoryFactory == null)
            {
                throw new ArgumentNullException("repositoryFactory");
            }
            if (repositoryContextProvider == null)
            {
                throw new ArgumentNullException("repositoryContextProvider");
            }
            //if (logger == null)
            //{
            //    throw new ArgumentNullException("logger");
            //}

            _repositoryFactory = repositoryFactory;
            _repositoryContextProvider = repositoryContextProvider;
           // _logger = logger;
            IsTransactional = useTransaction;

            if (IsTransactional)
            {
                //BeginTransaction(isolationLevel);
            }
        }

        public void CommitChanges()
        {
            //if (_transactionScope != null)
            //{
            //    _transactionScope.Complete();
            //}
        }

        //private void BeginTransaction(IsolationLevel isolationLevel)
        //{
          
        //}

        public T GetRepository<T>()
        {
            return _repositoryFactory.GetRepositoryInstance<T>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

                if (_repositoryContextProvider != null && _repositoryContextProvider.ActiveContexts != null && _repositoryContextProvider.ActiveContexts.Count > 0)
                {
                    foreach (var activeContext in _repositoryContextProvider.ActiveContexts)
                    {
                        activeContext.Value.RepoContext.Dispose();
                    }
                }
            }

            // free native resources if there are any.
        }


    }

}
