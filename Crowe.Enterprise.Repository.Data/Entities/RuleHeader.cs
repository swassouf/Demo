using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleHeader
    {
        public RuleHeader()
        {
            RuleConfig = new HashSet<RuleConfig>();
            RuleExpression = new HashSet<RuleExpression>();
            RuleHeaderDetail = new HashSet<RuleHeaderDetail>();
            RuleParameter = new HashSet<RuleParameter>();
            RuleParameterDetail = new HashSet<RuleParameterDetail>();
            RuleResult = new HashSet<RuleResult>();
            ScoreDetail = new HashSet<ScoreDetail>();
        }

        [Key]
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
        public bool Isactive { get; set; }
        [Column("EVAL_MANDATORY")]
        public bool EvalMandatory { get; set; }
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
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("RuleGroupKey")]
        [InverseProperty("RuleHeader")]
        public virtual RuleGroup RuleGroupKeyNavigation { get; set; }
        [InverseProperty("RuleHeaderKeyNavigation")]
        public virtual ICollection<RuleConfig> RuleConfig { get; set; }
        [InverseProperty("RuleHeaderKeyNavigation")]
        public virtual ICollection<RuleExpression> RuleExpression { get; set; }
        [InverseProperty("RuleHeaderKeyNavigation")]
        public virtual ICollection<RuleHeaderDetail> RuleHeaderDetail { get; set; }
        [InverseProperty("RuleHeaderKeyNavigation")]
        public virtual ICollection<RuleParameter> RuleParameter { get; set; }
        [InverseProperty("RuleHeaderKeyNavigation")]
        public virtual ICollection<RuleParameterDetail> RuleParameterDetail { get; set; }
        [InverseProperty("RuleHeaderKeyNavigation")]
        public virtual ICollection<RuleResult> RuleResult { get; set; }
        [InverseProperty("RuleHeaderKeyNavigation")]
        public virtual ICollection<ScoreDetail> ScoreDetail { get; set; }
    }
}
