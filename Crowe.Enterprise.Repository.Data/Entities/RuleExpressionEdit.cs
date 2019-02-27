using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleExpressionEdit
    {
        [Key]
        [Column("RULE_EXPRESSION_EDIT_KEY")]
        public int RuleExpressionEditKey { get; set; }
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
        [Column("EVAL_FROM", TypeName = "decimal(8, 2)")]
        public decimal? EvalFrom { get; set; }
        [Column("EVAL_TO", TypeName = "decimal(8, 2)")]
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
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Column("ENTERED_BY")]
        [StringLength(25)]
        public string EnteredBy { get; set; }
    }
}
