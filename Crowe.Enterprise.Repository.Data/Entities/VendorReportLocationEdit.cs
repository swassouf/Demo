using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportLocationEdit
    {
        [Key]
        [Column("VENDOR_REPORT_LOCATION_EDIT_KEY")]
        public int VendorReportLocationEditKey { get; set; }
        [Column("VENDOR_REPORT_CONFIG_EDIT_KEY")]
        public int VendorReportConfigEditKey { get; set; }
        [Column("LOCATION_KEY")]
        public int LocationKey { get; set; }
    }
}
