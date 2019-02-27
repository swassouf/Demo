using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ExcludedModelType
    {
        [Key]
        [Column("EXCLUDED_MODEL_TYPE_KEY")]
        public int ExcludedModelTypeKey { get; set; }
        [Column("MODEL_GROUP_KEY")]
        public int ModelGroupKey { get; set; }
        [Column("MODEL_TYPE_KEY")]
        public int ModelTypeKey { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Column("ENTERED_BY")]
        [StringLength(3)]
        public string EnteredBy { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("ModelGroupKey")]
        [InverseProperty("ExcludedModelType")]
        public virtual ModelGroup ModelGroupKeyNavigation { get; set; }
        [ForeignKey("ModelTypeKey")]
        [InverseProperty("ExcludedModelType")]
        public virtual ModelType ModelTypeKeyNavigation { get; set; }
    }
}
