using Crowe.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Repository.Contract
{
    public interface IScoringSummaryRepository
    {
        Task<IEnumerable<ScoringModel>> GetScoringModels();

        Task<IEnumerable<string>> GetLocations();
    }
}
