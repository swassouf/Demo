using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crowe.Infrastructure.UnitOfWork.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        bool IsTransactional { get; }

        /// <summary>
        /// Commit transaction.
        /// </summary>
        void CommitChanges();

        /// <summary>
        /// Gets an instance of a specific repository type
        /// </summary>
        /// <typeparam name="T">Type of repository to get</typeparam>
        /// <returns></returns>
        T GetRepository<T>();
    }
}
