using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleExpression
    {
        public RuleExpression()
        {
            RuleParameterDetail = new HashSet<RuleParameterDetail>();
            RuleResult = new HashSet<RuleResult>();
        }

        [Key]
        [Column("RULE_EXPRESSION_KEY")]
        public int RuleExpressionKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("SCORING_ITEM_MASTER_KEY")]
        public int ScoringItemMasterKey { get; set; }
        [Column("EVAL_OPERATOR")]
        public byte? EvalOperator { get; set; }
        [Column("EVAL_EQUAL", TypeName = "decimal(8, 2)")]
        public decimal? EvalEqual { get; set; }
        [Column("EVAL_FROM", TypeName = "decimal(10, 4)")]
        public decimal? EvalFrom { get; set; }
        [Column("EVAL_TO", TypeName = "decimal(10, 4)")]
        public decimal? EvalTo { get; set; }
        [Column("EVAL_DATE_FROM")]
        [StringLength(12)]
        public string EvalDateFrom { get; set; }
        [Column("EVAL_DATE_TO")]
        [StringLength(12)]
        public string EvalDateTo { get; set; }
        [Column("EVAL_STRING_DATA")]
        [StringLength(2500)]
        public string EvalStringData { get; set; }
        [Column("EVAL_TRUE_FALSE")]
        public bool EvalTrueFalse { get; set; }
        [Column("CHAIN_OPERATOR")]
        [StringLength(3)]
        public string ChainOperator { get; set; }
        [Column("CHAIN_RESULT")]
        public bool ChainResult { get; set; }
        [Column("CHAIN_TO")]
        public int? ChainTo { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("RuleHeaderKey")]
        [InverseProperty("RuleExpression")]
        public virtual RuleHeader RuleHeaderKeyNavigation { get; set; }
        [ForeignKey("ScoringItemMasterKey")]
        [InverseProperty("RuleExpression")]
        public virtual ScoringItemMaster ScoringItemMasterKeyNavigation { get; set; }
        [InverseProperty("RuleExpressionKeyNavigation")]
        public virtual ICollection<RuleParameterDetail> RuleParameterDetail { get; set; }
        [InverseProperty("RuleExpressionKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResult { get; set; }
    }
}
