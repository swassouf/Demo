using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ModelGroupDetail
    {
        [Key]
        [Column("MODEL_GROUP_DETAIL_KEY")]
        public int ModelGroupDetailKey { get; set; }
        [Column("MODEL_GROUP_KEY")]
        public int ModelGroupKey { get; set; }
        [Column("MODEL_TYPE_KEY")]
        public int ModelTypeKey { get; set; }
        [Column("LOCATION_KEY")]
        public int LocationKey { get; set; }
        [Column("PRODUCT_TYPE")]
        [StringLength(1)]
        public string ProductType { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Column("ENTERED_BY")]
        [StringLength(3)]
        public string EnteredBy { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int? LoanProductKey { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("ModelGroupKey")]
        [InverseProperty("ModelGroupDetail")]
        public virtual ModelGroup ModelGroupKeyNavigation { get; set; }
        [ForeignKey("ModelTypeKey")]
        [InverseProperty("ModelGroupDetail")]
        public virtual ModelType ModelTypeKeyNavigation { get; set; }
    }
}
