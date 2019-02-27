using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportProduct
    {
        [Key]
        [Column("VENDOR_REPORT_PRODUCT_KEY")]
        public int VendorReportProductKey { get; set; }
        [Column("VENDOR_REPORT_CONFIG_KEY")]
        public int VendorReportConfigKey { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int LoanProductKey { get; set; }

        [ForeignKey("VendorReportConfigKey")]
        [InverseProperty("VendorReportProduct")]
        public virtual VendorReportConfig VendorReportConfigKeyNavigation { get; set; }
    }
}
