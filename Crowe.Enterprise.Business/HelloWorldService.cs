using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Crowe.Enterprise.Business.Contract;
using Crowe.Enterprise.Repository.Contract;
using Crowe.Infrastructure.UnitOfWork.Contracts;

namespace Crowe.Enterprise.Business
{
    public class HelloWorldService : BusinessServiceBase, IHelloWorldService
    {
       

        public HelloWorldService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {

        }

        public async Task<string> GetHelloWorld()
        {
            using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
            {
                var repo = uow.GetRepository<IHelloWorldRepository>();
                var helloWorld = await repo.GetHelloWorld();

                return helloWorld;
            }
        }
    }
}
