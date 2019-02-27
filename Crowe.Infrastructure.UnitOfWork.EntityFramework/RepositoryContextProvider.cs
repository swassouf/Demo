using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crowe.Infrastructure.UnitOfWork.Contracts;
using Microsoft.EntityFrameworkCore;
using Crowe.Infrastructure.UnitOfWork.EntityFramework.Enums;


namespace Crowe.Infrastructure.UnitOfWork.EntityFramework
{
    public class RepositoryContextProvider : IRepositoryContextProvider<DbContext>
    {

        IRepositoryContext<DbContext> _repoContext = null;

        public RepositoryContextProvider(IRepositoryContext<DbContext> repositoryContext)
        {
            _repoContext = repositoryContext;
            ActiveContexts = new Dictionary<string, IRepositoryContext<DbContext>>();
        }

        public IDictionary<string, IRepositoryContext<DbContext>> ActiveContexts { get; private set; }

        public IRepositoryContext<DbContext> GetRepositoryContext<Context>(string repositoryName) //where Context: new()
        {
            if (!ActiveContexts.ContainsKey(repositoryName))
            {

                CreateRepositoryContext<Context>(repositoryName);
            }

            return ActiveContexts[repositoryName] as IRepositoryContext<DbContext>;
        }

        private void CreateRepositoryContext<Context>(string repositoryName)
        {
            if (Enum.IsDefined(typeof(ContextTypes), repositoryName))
            {
                _repoContext.GetRepositoryContext(typeof(Context));

                ActiveContexts.Add(repositoryName, _repoContext);
            }
        }

        public void ClearActiveContexts()
        {
            if (ActiveContexts != null && ActiveContexts.Count > 0)
            {
                foreach (var context in ActiveContexts)
                {
                    context.Value.RepoContext.Dispose();
                }

                ActiveContexts.Clear();
            }
        }


    }

}
