using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoringTestName
    {
        [Key]
        [Column("SCORING_TEST_NAME_KEY")]
        public int ScoringTestNameKey { get; set; }
        [Required]
        [Column("TEST_NAME")]
        [StringLength(50)]
        public string TestName { get; set; }
        [Column("POINTS", TypeName = "decimal(9, 2)")]
        public decimal Points { get; set; }
        [Column("AMOUNT", TypeName = "decimal(9, 2)")]
        public decimal Amount { get; set; }
        [Column("USE_AMOUNT")]
        public bool UseAmount { get; set; }
        [Column("USE_POINTS")]
        public bool UsePoints { get; set; }
        [Column("ACTIVE")]
        public bool Active { get; set; }
        [Column("STATE_DB_LIMIT")]
        public bool StateDbLimit { get; set; }
        [Column("AUTO_APPROVE")]
        public bool AutoApprove { get; set; }
        [Column("CRIT_STOP")]
        public bool CritStop { get; set; }
        [Column("WARN_STOP")]
        public bool WarnStop { get; set; }
        [Column("MODEL_TYPE")]
        public int ModelType { get; set; }
        [Column("IS_NEW_DATA_REQUIRED")]
        public bool IsNewDataRequired { get; set; }
        [Column("IS_LIMITED_TIER")]
        public bool IsLimitedTier { get; set; }
        [Column("IS_MILITARY_MEMBER")]
        public bool IsMilitaryMember { get; set; }
        [Column("IS_STATE_DECLINE")]
        public bool IsStateDecline { get; set; }
        [Column("IS_DATA_VENDOR_ERROR")]
        public bool IsDataVendorError { get; set; }
        [Column("IS_CREDIT_LOCK")]
        public bool IsCreditLock { get; set; }
        [Column("CREDIT_SCORE")]
        public int CreditScore { get; set; }
        [Column("USE_CREDIT_SCORE")]
        public bool UseCreditScore { get; set; }
        [Column("IS_SOFT_HIT")]
        public bool IsSoftHit { get; set; }
    }
}
