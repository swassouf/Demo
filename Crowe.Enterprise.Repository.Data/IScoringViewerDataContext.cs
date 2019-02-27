using Crowe.Enterprise.Repository.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Repository.Data
{
    public interface IScoringViewerDataContext
    {
        DbSet<ScoreSummary> ScoreSummary { get; set; }
        DbSet<Config> Config { get; set; }
        DbSet<Location> Location { get; set; }
    }
}
