using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ModelGroupPrimaryModel
    {
        [Key]
        [Column("MODEL_GROUP_PRIMARY_MODEL_KEY")]
        public int ModelGroupPrimaryModelKey { get; set; }
        [Column("CONFIG_KEY")]
        public int ConfigKey { get; set; }
        [Column("MODEL_GROUP_KEY")]
        public int ModelGroupKey { get; set; }
        [Column("PERCENT_USE", TypeName = "decimal(5, 2)")]
        public decimal PercentUse { get; set; }
        [Column("BEGIN_RANGE", TypeName = "decimal(5, 2)")]
        public decimal BeginRange { get; set; }
        [Column("END_RANGE", TypeName = "decimal(5, 2)")]
        public decimal EndRange { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Column("ENTERED_BY")]
        [StringLength(3)]
        public string EnteredBy { get; set; }
        [Column("DATE_UPDATED", TypeName = "smalldatetime")]
        public DateTime? DateUpdated { get; set; }
        [Column("UPDATED_BY")]
        [StringLength(3)]
        public string UpdatedBy { get; set; }

        [ForeignKey("ConfigKey")]
        [InverseProperty("ModelGroupPrimaryModel")]
        public virtual Config ConfigKeyNavigation { get; set; }
        [ForeignKey("ModelGroupKey")]
        [InverseProperty("ModelGroupPrimaryModel")]
        public virtual ModelGroup ModelGroupKeyNavigation { get; set; }
    }
}
