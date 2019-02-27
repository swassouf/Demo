using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScorePendingReason
    {
        [Column("SCORE_SUMMARY_KEY")]
        public int ScoreSummaryKey { get; set; }
        [Column("PENDING_REASON_KEY")]
        public int PendingReasonKey { get; set; }

        [ForeignKey("PendingReasonKey")]
        [InverseProperty("ScorePendingReason")]
        public virtual PendingReason PendingReasonKeyNavigation { get; set; }
        [ForeignKey("ScoreSummaryKey")]
        [InverseProperty("ScorePendingReason")]
        public virtual ScoreSummary ScoreSummaryKeyNavigation { get; set; }
    }
}
