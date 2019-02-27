using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LoanApplicationProduct
    {
        [Column("LOAN_APPLICATION_PRODUCT_KEY")]
        public int? LoanApplicationProductKey { get; set; }
        [Key]
        [Column("PK_LOAN_APPLICATION_PRODUCT_KEY")]
        public int PkLoanApplicationProductKey { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int LoanApplicationKey { get; set; }
        [Column("LOAN_TYPE")]
        [StringLength(1)]
        public string LoanType { get; set; }
        [Column("PRODUCT_TYPE")]
        [StringLength(1)]
        public string ProductType { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int? LoanProductKey { get; set; }
        [Column("LOAN_PRODUCT_CONFIG_KEY")]
        public int? LoanProductConfigKey { get; set; }
        [Column("LOAN_PRODUCT_TILA_KEY")]
        public int? LoanProductTilaKey { get; set; }
        [Column("APPROVED_AMT", TypeName = "smallmoney")]
        public decimal? ApprovedAmt { get; set; }
        [Column("SELECTED_AMT", TypeName = "smallmoney")]
        public decimal? SelectedAmt { get; set; }
        [Column("SELECTED")]
        public bool? Selected { get; set; }
        [Column("SELECTED_TERM")]
        public byte? SelectedTerm { get; set; }
        [Column("APPROVED")]
        public bool? Approved { get; set; }
        [Column("DETAIL")]
        public string Detail { get; set; }
        [Column("PRIMARY_SCORE_DATE", TypeName = "datetime")]
        public DateTime? PrimaryScoreDate { get; set; }
        [Column("MODEL_USED")]
        public short? ModelUsed { get; set; }
        [Column("FINAL_SCORE", TypeName = "decimal(8, 2)")]
        public decimal? FinalScore { get; set; }
        [Column("SCORE_SUMMARY_KEY")]
        public int? ScoreSummaryKey { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int? LoanAppPrimKey { get; set; }
        [Column("ENROLL_IN_INSURANCE")]
        public bool? EnrollInInsurance { get; set; }
        [Column("ENROLL_IN_INSURANCE_CHANGED_TELLER")]
        [StringLength(3)]
        public string EnrollInInsuranceChangedTeller { get; set; }

        [ForeignKey("LoanAppPrimKey")]
        [InverseProperty("LoanApplicationProduct")]
        public virtual LoanApplication LoanAppPrimKeyNavigation { get; set; }
    }
}
