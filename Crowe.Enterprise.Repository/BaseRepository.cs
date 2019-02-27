using Crowe.Infrastructure.UnitOfWork.Contracts;
using Crowe.Infrastructure.UnitOfWork.EntityFramework.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;


namespace Crowe.Enterprise.Repository
{
    public abstract class BaseRepository 
    {
      
        public BaseRepository(IRepositoryContextProvider<DbContext> repositoryContextProvider)
        {
            
        }
         

    }
}
