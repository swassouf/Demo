using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoreDetail
    {
        [Key]
        [Column("SCORE_DETAIL_KEY")]
        public int ScoreDetailKey { get; set; }
        [Column("SCORE_SUMMARY_KEY")]
        public int ScoreSummaryKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("EVAL_RESULT")]
        public byte EvalResult { get; set; }
        [Column("SCORE_ADJUST", TypeName = "decimal(18, 9)")]
        public decimal ScoreAdjust { get; set; }
        [Column("AMOUNT_ADJUST", TypeName = "decimal(8, 2)")]
        public decimal AmountAdjust { get; set; }
        [Column("DATA_VALUE")]
        [StringLength(100)]
        public string DataValue { get; set; }
        [Column("EVAL_CRITICAL_STOP")]
        public bool EvalCriticalStop { get; set; }

        [ForeignKey("RuleHeaderKey")]
        [InverseProperty("ScoreDetail")]
        public virtual RuleHeader RuleHeaderKeyNavigation { get; set; }
        [ForeignKey("ScoreSummaryKey")]
        [InverseProperty("ScoreDetail")]
        public virtual ScoreSummary ScoreSummaryKeyNavigation { get; set; }
    }
}
