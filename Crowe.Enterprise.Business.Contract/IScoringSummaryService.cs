using Crowe.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Business.Contract
{
    public interface IScoringSummaryService
    {
        Task<IEnumerable<ScoringModel>> GetScoringModels();

        Task<IEnumerable<string>> GetLocations();
    }
}
