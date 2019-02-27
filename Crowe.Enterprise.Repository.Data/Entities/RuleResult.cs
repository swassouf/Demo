using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleResult
    {
        [Key]
        [Column("RULE_RESULT_KEY")]
        public int RuleResultKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("RULE_EXPRESSION_KEY")]
        public int RuleExpressionKey { get; set; }
        [Column("MOD_SCORE_TRUE", TypeName = "decimal(18, 9)")]
        public decimal ModScoreTrue { get; set; }
        [Column("MOD_SCORE_FALSE", TypeName = "decimal(18, 9)")]
        public decimal ModScoreFalse { get; set; }
        [Column("MOD_SCORE_NODATA", TypeName = "decimal(18, 9)")]
        public decimal ModScoreNodata { get; set; }
        [Column("MOD_AMOUNT_TRUE", TypeName = "decimal(6, 2)")]
        public decimal ModAmountTrue { get; set; }
        [Column("MOD_AMOUNT_FALSE", TypeName = "decimal(6, 2)")]
        public decimal ModAmountFalse { get; set; }
        [Column("MOD_AMOUNT_NODATA", TypeName = "decimal(6, 2)")]
        public decimal ModAmountNodata { get; set; }
        [Column("CRITICAL_FLAG")]
        public byte CriticalFlag { get; set; }
        [Column("SCORECARD_FLAG")]
        public byte? ScorecardFlag { get; set; }
        [Column("MSG_TRUE")]
        [StringLength(75)]
        public string MsgTrue { get; set; }
        [Column("MSG_FALSE")]
        [StringLength(75)]
        public string MsgFalse { get; set; }
        [Column("MSG_NODATA")]
        [StringLength(75)]
        public string MsgNodata { get; set; }
        [Column("MSG_STOP")]
        [StringLength(75)]
        public string MsgStop { get; set; }
        [Column("AUTO_APPROVE")]
        public byte AutoApprove { get; set; }
        [Required]
        [Column("MSG_AUTO_APPROVE")]
        [StringLength(75)]
        public string MsgAutoApprove { get; set; }
        [Column("WARNING_FLAG")]
        public byte WarningFlag { get; set; }
        [Column("MSG_VENDOR_ERROR")]
        [StringLength(75)]
        public string MsgVendorError { get; set; }
        [Column("VENDOR_ERROR_FLAG")]
        public byte VendorErrorFlag { get; set; }
        [Column("TRUE_PENDING_REASON_KEY")]
        public int? TruePendingReasonKey { get; set; }
        [Column("FALSE_PENDING_REASON_KEY")]
        public int? FalsePendingReasonKey { get; set; }
        [Column("NODATA_PENDING_REASON_KEY")]
        public int? NodataPendingReasonKey { get; set; }
        [Column("STOP_PENDING_REASON_KEY")]
        public int? StopPendingReasonKey { get; set; }
        [Column("AUTO_APPROVE_PENDING_REASON_KEY")]
        public int? AutoApprovePendingReasonKey { get; set; }
        [Column("VENDOR_ERROR_PENDING_REASON_KEY")]
        public int? VendorErrorPendingReasonKey { get; set; }

        [ForeignKey("AutoApprovePendingReasonKey")]
        [InverseProperty("RuleResultAutoApprovePendingReasonKeyNavigation")]
        public virtual PendingReason AutoApprovePendingReasonKeyNavigation { get; set; }
        [ForeignKey("FalsePendingReasonKey")]
        [InverseProperty("RuleResultFalsePendingReasonKeyNavigation")]
        public virtual PendingReason FalsePendingReasonKeyNavigation { get; set; }
        [ForeignKey("NodataPendingReasonKey")]
        [InverseProperty("RuleResultNodataPendingReasonKeyNavigation")]
        public virtual PendingReason NodataPendingReasonKeyNavigation { get; set; }
        [ForeignKey("RuleExpressionKey")]
        [InverseProperty("RuleResult")]
        public virtual RuleExpression RuleExpressionKeyNavigation { get; set; }
        [ForeignKey("RuleHeaderKey")]
        [InverseProperty("RuleResult")]
        public virtual RuleHeader RuleHeaderKeyNavigation { get; set; }
        [ForeignKey("StopPendingReasonKey")]
        [InverseProperty("RuleResultStopPendingReasonKeyNavigation")]
        public virtual PendingReason StopPendingReasonKeyNavigation { get; set; }
        [ForeignKey("TruePendingReasonKey")]
        [InverseProperty("RuleResultTruePendingReasonKeyNavigation")]
        public virtual PendingReason TruePendingReasonKeyNavigation { get; set; }
        [ForeignKey("VendorErrorPendingReasonKey")]
        [InverseProperty("RuleResultVendorErrorPendingReasonKeyNavigation")]
        public virtual PendingReason VendorErrorPendingReasonKeyNavigation { get; set; }
    }
}
