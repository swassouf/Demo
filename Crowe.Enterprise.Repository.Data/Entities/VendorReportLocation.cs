using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportLocation
    {
        [Key]
        [Column("VENDOR_REPORT_LOCATION_KEY")]
        public int VendorReportLocationKey { get; set; }
        [Column("VENDOR_REPORT_CONFIG_KEY")]
        public int VendorReportConfigKey { get; set; }
        [Column("LOCATION_KEY")]
        public int LocationKey { get; set; }

        [ForeignKey("VendorReportConfigKey")]
        [InverseProperty("VendorReportLocation")]
        public virtual VendorReportConfig VendorReportConfigKeyNavigation { get; set; }
    }
}
