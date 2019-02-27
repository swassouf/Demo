using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoreLoanMatrix
    {
        [Key]
        [Column("SCORE_LOAN_MATRIX_KEY")]
        public int ScoreLoanMatrixKey { get; set; }
        [Column("LOCATION_KEY")]
        public short LocationKey { get; set; }
        [Required]
        [Column("PRODUCT_TYPE")]
        [StringLength(1)]
        public string ProductType { get; set; }
        [Column("SCORE_FROM", TypeName = "decimal(18, 9)")]
        public decimal ScoreFrom { get; set; }
        [Column("SCORE_TO", TypeName = "decimal(18, 9)")]
        public decimal ScoreTo { get; set; }
        [Column("NET_FROM", TypeName = "smallmoney")]
        public decimal NetFrom { get; set; }
        [Column("NET_TO", TypeName = "money")]
        public decimal NetTo { get; set; }
        [Column("MAX_AMOUNT", TypeName = "smallmoney")]
        public decimal MaxAmount { get; set; }
        [Column("MAX_PCT_OF_NET", TypeName = "decimal(8, 2)")]
        public decimal MaxPctOfNet { get; set; }
        [Required]
        [Column("ENGINE_OR_CREDIT")]
        [StringLength(1)]
        public string EngineOrCredit { get; set; }
        [Column("MIN_LOAN_AMT", TypeName = "decimal(8, 2)")]
        public decimal MinLoanAmt { get; set; }
        [Column("PCT_VEHICLE_VALUE", TypeName = "decimal(8, 2)")]
        public decimal PctVehicleValue { get; set; }
        [Column("GUARANTEE_AMT", TypeName = "smallmoney")]
        public decimal? GuaranteeAmt { get; set; }
        [Column("MODEL_NUM")]
        public int? ModelNum { get; set; }
        [Column("BUMP_MAX_PCT_OF_INCOME", TypeName = "decimal(5, 2)")]
        public decimal BumpMaxPctOfIncome { get; set; }
        [Column("INCENTIVE_AMT", TypeName = "decimal(8, 2)")]
        public decimal IncentiveAmt { get; set; }
        [Column("INET_ONLY_MAX_AMT", TypeName = "decimal(9, 2)")]
        public decimal InetOnlyMaxAmt { get; set; }
        [Column("FIRST_TIME_CUST_MAX_AMT", TypeName = "decimal(9, 2)")]
        public decimal FirstTimeCustMaxAmt { get; set; }
        [Column("ALLOW_USE_PRIOR_SCORE")]
        public bool AllowUsePriorScore { get; set; }
        [Column("IS_LIMITED_TIER")]
        public bool IsLimitedTier { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int LoanProductKey { get; set; }
        [Column("IS_DENIED")]
        public bool IsDenied { get; set; }
        [Column("IS_PENDED")]
        public bool IsPended { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("LocationKey")]
        [InverseProperty("ScoreLoanMatrix")]
        public virtual Location LocationKeyNavigation { get; set; }
    }
}
