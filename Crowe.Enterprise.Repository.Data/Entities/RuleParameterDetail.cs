using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleParameterDetail
    {
        [Key]
        [Column("RULE_PARAMETER_DETAIL_KEY")]
        public int RuleParameterDetailKey { get; set; }
        [Column("RULE_PARAMETER_PARENT_KEY")]
        public int RuleParameterParentKey { get; set; }
        [Column("RULE_EXPRESSION_KEY")]
        public int RuleExpressionKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("SCORING_ITEM_MASTER_KEY")]
        public int ScoringItemMasterKey { get; set; }
        [Required]
        [Column("DATA_ELEMENT")]
        [StringLength(500)]
        public string DataElement { get; set; }
        [Required]
        [Column("ELEMENT_SQL")]
        public string ElementSql { get; set; }
        [Required]
        [Column("VARIABLE_NAMES")]
        public string VariableNames { get; set; }
        [Column("LINK_OPERATOR")]
        public byte LinkOperator { get; set; }
        [Required]
        [Column("TIME_CODE")]
        [StringLength(2)]
        public string TimeCode { get; set; }
        [Column("TIME_LIMIT_THRESHOLD", TypeName = "decimal(8, 2)")]
        public decimal TimeLimitThreshold { get; set; }
        [Column("COUNT_THRESHOLD", TypeName = "decimal(8, 2)")]
        public decimal CountThreshold { get; set; }
        [Required]
        [Column("REGEX_VALIDATOR")]
        public string RegexValidator { get; set; }
        [Column("EVAL_OPERATOR")]
        public byte EvalOperator { get; set; }
        [Required]
        [Column("KEYS_TO_USE")]
        public string KeysToUse { get; set; }
        [Required]
        [Column("EVAL_STRING_DATA")]
        public string EvalStringData { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("RuleExpressionKey")]
        [InverseProperty("RuleParameterDetail")]
        public virtual RuleExpression RuleExpressionKeyNavigation { get; set; }
        [ForeignKey("RuleHeaderKey")]
        [InverseProperty("RuleParameterDetail")]
        public virtual RuleHeader RuleHeaderKeyNavigation { get; set; }
        [ForeignKey("RuleParameterParentKey")]
        [InverseProperty("RuleParameterDetail")]
        public virtual RuleParameter RuleParameterParentKeyNavigation { get; set; }
        [ForeignKey("ScoringItemMasterKey")]
        [InverseProperty("RuleParameterDetail")]
        public virtual ScoringItemMaster ScoringItemMasterKeyNavigation { get; set; }
    }
}
