using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorMatrixToSpeedyMatrix
    {
        [Key]
        [Column("VENDOR_MATRIX_TO_SPEEDY_MATRIX_KEY")]
        public int VendorMatrixToSpeedyMatrixKey { get; set; }
        [Column("MODEL_NUM")]
        public short ModelNum { get; set; }
        [Column("VENDOR_SCORE_FROM", TypeName = "decimal(18, 9)")]
        public decimal VendorScoreFrom { get; set; }
        [Column("VENDOR_SCORE_TO", TypeName = "decimal(18, 9)")]
        public decimal VendorScoreTo { get; set; }
        [Column("SPEEDY_SCORE_FOR_RANGE", TypeName = "decimal(18, 9)")]
        public decimal SpeedyScoreForRange { get; set; }
        [Column("MODEL_TYPE")]
        public int ModelType { get; set; }
        [Column("CONVERSION_MATRIX_INDICATOR_KEY")]
        public int? ConversionMatrixIndicatorKey { get; set; }
        [Column("INDICATOR_VALUE")]
        [StringLength(500)]
        public string IndicatorValue { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("ConversionMatrixIndicatorKey")]
        [InverseProperty("VendorMatrixToSpeedyMatrix")]
        public virtual ConversionMatrixIndicator ConversionMatrixIndicatorKeyNavigation { get; set; }
    }
}
