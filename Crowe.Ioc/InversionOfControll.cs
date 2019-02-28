using System;
using Crowe.Enterprise.Business;
using Crowe.Enterprise.Business.Contract;
using Crowe.Enterprise.Repository;
using Crowe.Enterprise.Repository.Contract;
using Crowe.Infrastructure.UnitOfWork.Contracts;
using Crowe.Infrastructure.UnitOfWork.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Crowe.Ioc
{
    public static class InversionOfControll
    {
        public static IServiceCollection AddCroweService(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();
            services.AddTransient<IRepositoryFactory, RepositoryFactory>();
            services.AddTransient<IRepositoryContext<DbContext>, RepositoryContext>();
            services.AddTransient<IRepositoryContextProvider<DbContext>, RepositoryContextProvider>();
            services.AddTransient<IHelloWorldRepository, HelloWorldRepository>();
            services.AddTransient<IHelloWorldService, HelloWorldService>();
            return services;
        }
    }
}
