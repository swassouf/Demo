using Crowe.DataModel;
using Crowe.Enterprise.Business.Contract;
using Crowe.Enterprise.Repository.Contract;
using Crowe.Infrastructure.UnitOfWork.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Business
{
    public class ScoringSummaryService : BusinessServiceBase, IScoringSummaryService
    {
        public ScoringSummaryService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {

        }

        public Task<IEnumerable<ScoringModel>> GetScoringModels()
        {
            using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
            {
                var repo = uow.GetRepository<IScoringSummaryRepository>();
                var summaries = repo.GetScoringModels();

                return summaries;
            }
        }

        public Task<IEnumerable<string>> GetLocations()
        {
            using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
            {
                var repo = uow.GetRepository<IScoringSummaryRepository>();
                var locations = repo.GetLocations();
                return locations;
            }
        }
    }
}
