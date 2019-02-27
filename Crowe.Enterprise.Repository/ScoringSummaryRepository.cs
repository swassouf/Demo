using Crowe.DataModel;
using Crowe.Enterprise.Repository.Contract;
using Crowe.Enterprise.Repository.Data;
using Crowe.Infrastructure.UnitOfWork.Contracts;
using Crowe.Infrastructure.UnitOfWork.EntityFramework.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Repository
{
    public class ScoringSummaryRepository: BaseRepository, IScoringSummaryRepository
    {
        IScoringViewerDataContext _ScoringViewerDataContext;

        public ScoringSummaryRepository(IRepositoryContextProvider<DbContext> repositoryContextProvider) :base(repositoryContextProvider)
        {
            _ScoringViewerDataContext = repositoryContextProvider.GetRepositoryContext<IScoringViewerDataContext>(ContextTypes.Scoring.ToString()).RepoContext as IScoringViewerDataContext;

        }


        public async Task<IEnumerable<ScoringModel>> GetScoringModels()
        {
            var models = await _ScoringViewerDataContext.Config.Where(c => c.IsActive).Select(s => new ScoringModel
            {
                Id = s.ConfigKey,
                Name = s.ConfigName

            }).OrderBy(o => o.Name).ToListAsync();

            return models;
        }

        public async Task<IEnumerable<string>> GetLocations()
        {
            var locations = await _ScoringViewerDataContext.Location.Where(l => l.LocationKey != 0)
                .Select(l => l.LocationKey.ToString()).OrderBy(x => x).ToListAsync();

            locations.Insert(0, "All");

            return locations;
        }
    }
}
