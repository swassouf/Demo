using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ModelType
    {
        public ModelType()
        {
            ExcludedModelType = new HashSet<ExcludedModelType>();
            ModelGroupDetail = new HashSet<ModelGroupDetail>();
        }

        [Key]
        [Column("MODEL_TYPE_KEY")]
        public int ModelTypeKey { get; set; }
        [Column("MODEL_TYPE")]
        public int ModelType1 { get; set; }
        [Required]
        [Column("MODEL_TYPE_DESCRIPTION")]
        [StringLength(50)]
        public string ModelTypeDescription { get; set; }

        [InverseProperty("ModelTypeKeyNavigation")]
        public virtual ICollection<ExcludedModelType> ExcludedModelType { get; set; }
        [InverseProperty("ModelTypeKeyNavigation")]
        public virtual ICollection<ModelGroupDetail> ModelGroupDetail { get; set; }
    }
}
