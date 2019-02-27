using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class PendingReason
    {
        public PendingReason()
        {
            RuleResultAutoApprovePendingReasonKeyNavigation = new HashSet<RuleResult>();
            RuleResultFalsePendingReasonKeyNavigation = new HashSet<RuleResult>();
            RuleResultNodataPendingReasonKeyNavigation = new HashSet<RuleResult>();
            RuleResultStopPendingReasonKeyNavigation = new HashSet<RuleResult>();
            RuleResultTruePendingReasonKeyNavigation = new HashSet<RuleResult>();
            RuleResultVendorErrorPendingReasonKeyNavigation = new HashSet<RuleResult>();
            ScorePendingReason = new HashSet<ScorePendingReason>();
        }

        [Key]
        [Column("PENDING_REASON_KEY")]
        public int PendingReasonKey { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(15)]
        public string Code { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }
        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }

        [InverseProperty("AutoApprovePendingReasonKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResultAutoApprovePendingReasonKeyNavigation { get; set; }
        [InverseProperty("FalsePendingReasonKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResultFalsePendingReasonKeyNavigation { get; set; }
        [InverseProperty("NodataPendingReasonKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResultNodataPendingReasonKeyNavigation { get; set; }
        [InverseProperty("StopPendingReasonKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResultStopPendingReasonKeyNavigation { get; set; }
        [InverseProperty("TruePendingReasonKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResultTruePendingReasonKeyNavigation { get; set; }
        [InverseProperty("VendorErrorPendingReasonKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResultVendorErrorPendingReasonKeyNavigation { get; set; }
        [InverseProperty("PendingReasonKeyNavigation")]
        public virtual ICollection<ScorePendingReason> ScorePendingReason { get; set; }
    }
}
