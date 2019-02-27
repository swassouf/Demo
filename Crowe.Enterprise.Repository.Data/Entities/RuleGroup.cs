using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleGroup
    {
        public RuleGroup()
        {
            RuleHeader = new HashSet<RuleHeader>();
        }

        [Key]
        [Column("RULE_GROUP_KEY")]
        public int RuleGroupKey { get; set; }
        [Required]
        [Column("GROUP_NAME")]
        [StringLength(100)]
        public string GroupName { get; set; }
        [Column("RUN_ORDER")]
        public short RunOrder { get; set; }
        [Column("IS_WATERFALL_GROUP")]
        public bool IsWaterfallGroup { get; set; }
        [Column("PRE_GROUP_POINTS", TypeName = "decimal(18, 9)")]
        public decimal PreGroupPoints { get; set; }
        [Column("PRIOR_GROUP_POINT_PCT", TypeName = "decimal(18, 9)")]
        public decimal PriorGroupPointPct { get; set; }
        [Column("POINT_TOT_MINIMUM", TypeName = "decimal(18, 9)")]
        public decimal PointTotMinimum { get; set; }
        [Required]
        [Column("POINT_CONVERT_FORMULA")]
        [StringLength(2500)]
        public string PointConvertFormula { get; set; }
        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }
        [Column("POINT_TOT_MAXIMUM", TypeName = "decimal(18, 9)")]
        public decimal? PointTotMaximum { get; set; }
        [Column("IS_THIRD_PARTY")]
        public bool IsThirdParty { get; set; }

        [InverseProperty("RuleGroupKeyNavigation")]
        public virtual ICollection<RuleHeader> RuleHeader { get; set; }
    }
}
