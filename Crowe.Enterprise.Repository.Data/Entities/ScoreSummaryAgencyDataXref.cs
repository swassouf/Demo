using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoreSummaryAgencyDataXref
    {
        [Column("SCORE_SUMMARY_KEY")]
        public int ScoreSummaryKey { get; set; }
        [Column("AGENCY_DATA_KEY")]
        public int AgencyDataKey { get; set; }

        [ForeignKey("AgencyDataKey")]
        [InverseProperty("ScoreSummaryAgencyDataXref")]
        public virtual AgencyData AgencyDataKeyNavigation { get; set; }
        [ForeignKey("ScoreSummaryKey")]
        [InverseProperty("ScoreSummaryAgencyDataXref")]
        public virtual ScoreSummary ScoreSummaryKeyNavigation { get; set; }
    }
}
