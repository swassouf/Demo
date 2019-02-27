using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoreSummary
    {
        public ScoreSummary()
        {
            ScoreDenialReason = new HashSet<ScoreDenialReason>();
            ScoreDetail = new HashSet<ScoreDetail>();
            ScorePendingReason = new HashSet<ScorePendingReason>();
            ScoreProductSummary = new HashSet<ScoreProductSummary>();
            ScoreSummaryAgencyDataXref = new HashSet<ScoreSummaryAgencyDataXref>();
        }

        [Key]
        [Column("SCORE_SUMMARY_KEY")]
        public int ScoreSummaryKey { get; set; }
        [Column("CUSTOMER_KEY")]
        public int CustomerKey { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }
        [Column("SSN")]
        [StringLength(12)]
        public string Ssn { get; set; }
        [Column("LOCATION_KEY")]
        public short LocationKey { get; set; }
        [Required]
        [Column("PRODUCT_TYPE")]
        [StringLength(1)]
        public string ProductType { get; set; }
        [Required]
        [Column("TELLER")]
        [StringLength(3)]
        public string Teller { get; set; }
        [Column("APPROVED")]
        public bool Approved { get; set; }
        [Column("SCORE", TypeName = "decimal(18, 9)")]
        public decimal Score { get; set; }
        [Column("LOAN_AMT", TypeName = "smallmoney")]
        public decimal? LoanAmt { get; set; }
        [Column("MODEL_USED")]
        public short ModelUsed { get; set; }
        [Column("STATE_DECLINED")]
        public bool StateDeclined { get; set; }
        [Column("VENDOR_SCORE", TypeName = "decimal(18, 9)")]
        public decimal VendorScore { get; set; }
        [Column("VENDOR_SCORE_USED")]
        public bool VendorScoreUsed { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int? LoanApplicationKey { get; set; }
        [Column("MODEL_TYPE")]
        public short? ModelType { get; set; }
        [Column("OVERRIDE_APPROVAL")]
        public bool OverrideApproval { get; set; }
        [Column("OVERRIDE_SCORE", TypeName = "decimal(18, 9)")]
        public decimal OverrideScore { get; set; }
        [Column("OVERRIDE_AMT", TypeName = "smallmoney")]
        public decimal OverrideAmt { get; set; }
        [Column("CRIT_STOP")]
        public bool? CritStop { get; set; }
        [Column("WARN_STOP")]
        public bool? WarnStop { get; set; }
        [Column("GUARANTEE_LOAN_AMT", TypeName = "decimal(8, 2)")]
        public decimal? GuaranteeLoanAmt { get; set; }
        [Column("BUMP_MAX_PCT_OF_INCOME", TypeName = "decimal(5, 2)")]
        public decimal BumpMaxPctOfIncome { get; set; }
        [Column("SCORE_TIME")]
        public int? ScoreTime { get; set; }
        [Column("CREDIT_SCORE")]
        public int CreditScore { get; set; }
        [Column("CREDIT_SCORE_BEGIN_RANGE")]
        public int CreditScoreBeginRange { get; set; }
        [Column("CREDIT_SCORE_END_RANGE")]
        public int CreditScoreEndRange { get; set; }
        [Required]
        [Column("CREDIT_SCORE_VENDOR_NAME")]
        [StringLength(50)]
        public string CreditScoreVendorName { get; set; }
        [Column("PRIOR_SCORE_SUMMARY_KEY")]
        public int PriorScoreSummaryKey { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int LoanProductKey { get; set; }
        [Column("VISITOR_KEY")]
        public int VisitorKey { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int? LoanAppPrimKey { get; set; }
        [Column("PENDED")]
        public bool Pended { get; set; }
        [Column("ERRORED")]
        public bool Errored { get; set; }
        [Column("ERROR_MESSAGE")]
        [StringLength(1000)]
        public string ErrorMessage { get; set; }
        [Column("HAD_CREDIT_LOCK")]
        public bool HadCreditLock { get; set; }
        [Column("HAD_SOFT_HIT")]
        public bool HadSoftHit { get; set; }
        [Column("OVERRIDE_APR", TypeName = "decimal(5, 2)")]
        public decimal? OverrideApr { get; set; }

        [ForeignKey("LoanAppPrimKey")]
        [InverseProperty("ScoreSummary")]
        public virtual LoanApplication LoanAppPrimKeyNavigation { get; set; }
        [ForeignKey("LocationKey")]
        [InverseProperty("ScoreSummary")]
        public virtual Location LocationKeyNavigation { get; set; }
        [InverseProperty("ScoreSummaryKeyNavigation")]
        public virtual ICollection<ScoreDenialReason> ScoreDenialReason { get; set; }
        [InverseProperty("ScoreSummaryKeyNavigation")]
        public virtual ICollection<ScoreDetail> ScoreDetail { get; set; }
        [InverseProperty("ScoreSummaryKeyNavigation")]
        public virtual ICollection<ScorePendingReason> ScorePendingReason { get; set; }
        [InverseProperty("ScoreSummaryKeyNavigation")]
        public virtual ICollection<ScoreProductSummary> ScoreProductSummary { get; set; }
        [InverseProperty("ScoreSummaryKeyNavigation")]
        public virtual ICollection<ScoreSummaryAgencyDataXref> ScoreSummaryAgencyDataXref { get; set; }
    }
}
