using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoreProductSummary
    {
        [Key]
        [Column("SCORE_PRODUCT_SUMMARY_KEY")]
        public int ScoreProductSummaryKey { get; set; }
        [Column("SCORE_SUMMARY_KEY")]
        public int ScoreSummaryKey { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int LoanApplicationKey { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int LoanProductKey { get; set; }
        [Column("LOAN_PRODUCT_CONFIG_KEY")]
        public int LoanProductConfigKey { get; set; }
        [Required]
        [Column("LOAN_TYPE")]
        [StringLength(1)]
        public string LoanType { get; set; }
        [Required]
        [Column("PRODUCT_TYPE")]
        [StringLength(1)]
        public string ProductType { get; set; }
        [Column("MODEL_USED")]
        public short ModelUsed { get; set; }
        [Column("APPROVED")]
        public bool Approved { get; set; }
        [Column("APPROVED_AMT", TypeName = "smallmoney")]
        public decimal ApprovedAmt { get; set; }
        [Column("FINAL_SCORE", TypeName = "decimal(8, 2)")]
        public decimal FinalScore { get; set; }
        [Column("VENDOR_SCORE", TypeName = "decimal(8, 2)")]
        public decimal VendorScore { get; set; }
        [Column("WAS_ELIGIBLE")]
        public bool WasEligible { get; set; }
        [Column("CONVERSION_MATRIX_MODEL_USED")]
        public short ConversionMatrixModelUsed { get; set; }
        [Column("CONVERSION_MATRIX_INDICATOR_VALUE")]
        [StringLength(500)]
        public string ConversionMatrixIndicatorValue { get; set; }

        [ForeignKey("ScoreSummaryKey")]
        [InverseProperty("ScoreProductSummary")]
        public virtual ScoreSummary ScoreSummaryKeyNavigation { get; set; }
    }
}
