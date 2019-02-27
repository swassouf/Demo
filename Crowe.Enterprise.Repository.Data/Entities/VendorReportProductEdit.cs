using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportProductEdit
    {
        [Key]
        [Column("VENDOR_REPORT_PRODUCT_EDIT_KEY")]
        public int VendorReportProductEditKey { get; set; }
        [Column("VENDOR_REPORT_CONFIG_EDIT_KEY")]
        public int VendorReportConfigEditKey { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int LoanProductKey { get; set; }
    }
}
