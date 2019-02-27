using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ModelGroup
    {
        public ModelGroup()
        {
            ExcludedModelType = new HashSet<ExcludedModelType>();
            ModelGroupApplyToAllModel = new HashSet<ModelGroupApplyToAllModel>();
            ModelGroupDetail = new HashSet<ModelGroupDetail>();
            ModelGroupPrimaryModel = new HashSet<ModelGroupPrimaryModel>();
        }

        [Key]
        [Column("MODEL_GROUP_KEY")]
        public int ModelGroupKey { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(2048)]
        public string Description { get; set; }
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

        [InverseProperty("ModelGroupKeyNavigation")]
        public virtual ICollection<ExcludedModelType> ExcludedModelType { get; set; }
        [InverseProperty("ModelGroupKeyNavigation")]
        public virtual ICollection<ModelGroupApplyToAllModel> ModelGroupApplyToAllModel { get; set; }
        [InverseProperty("ModelGroupKeyNavigation")]
        public virtual ICollection<ModelGroupDetail> ModelGroupDetail { get; set; }
        [InverseProperty("ModelGroupKeyNavigation")]
        public virtual ICollection<ModelGroupPrimaryModel> ModelGroupPrimaryModel { get; set; }
    }
}
