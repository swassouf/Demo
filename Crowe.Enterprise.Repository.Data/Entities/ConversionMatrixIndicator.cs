using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ConversionMatrixIndicator
    {
        public ConversionMatrixIndicator()
        {
            VendorMatrixToSpeedyMatrix = new HashSet<VendorMatrixToSpeedyMatrix>();
        }

        [Key]
        [Column("CONVERSION_MATRIX_INDICATOR_KEY")]
        public int ConversionMatrixIndicatorKey { get; set; }
        [Required]
        [Column("INDICATOR_NAME")]
        [StringLength(500)]
        public string IndicatorName { get; set; }
        [Required]
        [Column("INDICATOR_SQL")]
        public string IndicatorSql { get; set; }
        [Required]
        [Column("INDICATOR_FIELD_NAME")]
        [StringLength(500)]
        public string IndicatorFieldName { get; set; }

        [InverseProperty("ConversionMatrixIndicatorKeyNavigation")]
        public virtual ICollection<VendorMatrixToSpeedyMatrix> VendorMatrixToSpeedyMatrix { get; set; }
    }
}
