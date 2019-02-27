using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoreDenialReason
    {
        [Key]
        [Column("SCORE_DENIAL_REASON_KEY")]
        public int ScoreDenialReasonKey { get; set; }
        [Required]
        [Column("REASON")]
        [StringLength(1000)]
        public string Reason { get; set; }
        [Column("REASON_TYPE")]
        public byte ReasonType { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Column("SCORE_SUMMARY_KEY")]
        public int ScoreSummaryKey { get; set; }
        [Required]
        [Column("REASON_CODE")]
        [StringLength(15)]
        public string ReasonCode { get; set; }

        [ForeignKey("AgencyMasterKey")]
        [InverseProperty("ScoreDenialReason")]
        public virtual AgencyMaster AgencyMasterKeyNavigation { get; set; }
        public virtual DenialReason ReasonCodeNavigation { get; set; }
        [ForeignKey("ScoreSummaryKey")]
        [InverseProperty("ScoreDenialReason")]
        public virtual ScoreSummary ScoreSummaryKeyNavigation { get; set; }
    }
}
