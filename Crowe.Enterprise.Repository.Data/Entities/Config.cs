using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class Config
    {
        public Config()
        {
            ModelGroupApplyToAllModel = new HashSet<ModelGroupApplyToAllModel>();
            ModelGroupPrimaryModel = new HashSet<ModelGroupPrimaryModel>();
        }

        [Column("CONFIG_KEY")]
        public int ConfigKey { get; set; }
        [Required]
        [Column("CONFIG_NAME")]
        [StringLength(100)]
        public string ConfigName { get; set; }
        [Column("CONFIG_DESCRIPTION")]
        [StringLength(300)]
        public string ConfigDescription { get; set; }
        [Column("MODEL_NUM")]
        public short ModelNum { get; set; }
        [Column("PERCENT_USE_OBSOLETE", TypeName = "decimal(8, 2)")]
        public decimal? PercentUseObsolete { get; set; }
        [Column("BEGIN_RANGE_OBSOLETE", TypeName = "decimal(8, 2)")]
        public decimal? BeginRangeObsolete { get; set; }
        [Column("END_RANGE_OBSOLETE", TypeName = "decimal(8, 2)")]
        public decimal? EndRangeObsolete { get; set; }
        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }
        [Column("IS_DISPLAYED")]
        public bool? IsDisplayed { get; set; }
        [Column("IS_WATERFALL_GROUP_MODEL")]
        public bool IsWaterfallGroupModel { get; set; }
        [Column("POINTS_REQUIRED", TypeName = "decimal(18, 9)")]
        public decimal PointsRequired { get; set; }
        [Column("USE_CONVERT_MATRIX")]
        public bool? UseConvertMatrix { get; set; }
        [Column("MODEL_OVERRIDE_POINTS", TypeName = "decimal(18, 2)")]
        public decimal? ModelOverridePoints { get; set; }
        [Column("USE_MODEL_SLM")]
        public bool? UseModelSlm { get; set; }
        [Column("PRIMARY_MODEL_NUM")]
        public short PrimaryModelNum { get; set; }
        [Column("USE_MULTI_SCORE_MATRIX")]
        public bool UseMultiScoreMatrix { get; set; }
        [Column("PROCESS_AGENCY_DATA_IN_PARALLEL")]
        public bool ProcessAgencyDataInParallel { get; set; }
        [Column("PULL_NEW_DATA_FOR_CUST_INFO_CHANGE")]
        public bool PullNewDataForCustInfoChange { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [InverseProperty("ConfigKeyNavigation")]
        public virtual ICollection<ModelGroupApplyToAllModel> ModelGroupApplyToAllModel { get; set; }
        [InverseProperty("ConfigKeyNavigation")]
        public virtual ICollection<ModelGroupPrimaryModel> ModelGroupPrimaryModel { get; set; }
    }
}
