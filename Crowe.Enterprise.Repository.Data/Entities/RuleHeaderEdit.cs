using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleHeaderEdit
    {
        [Key]
        [Column("RULE_HEADER_EDIT_KEY")]
        public int RuleHeaderEditKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("RULE_GROUP_KEY")]
        public int RuleGroupKey { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(300)]
        public string Description { get; set; }
        [Column("ISACTIVE")]
        public bool? Isactive { get; set; }
        [Column("EVAL_MANDATORY")]
        public bool? EvalMandatory { get; set; }
        [Column("RUN_ORDER")]
        public int RunOrder { get; set; }
        [Column("TRUE_RULE_HEADER_KEY")]
        public int TrueRuleHeaderKey { get; set; }
        [Column("FALSE_RULE_HEADER_KEY")]
        public int FalseRuleHeaderKey { get; set; }
        [Column("NO_DATA_RULE_HEADER_KEY")]
        public int NoDataRuleHeaderKey { get; set; }
        [Column("IS_CONDITIONAL_RULE")]
        public bool IsConditionalRule { get; set; }
        [Column("MODEL_TO_CALL")]
        public int? ModelToCall { get; set; }
        [Column("POINTS_REQUIRED")]
        public short? PointsRequired { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Column("ENTERED_BY")]
        [StringLength(25)]
        public string EnteredBy { get; set; }
    }
}
