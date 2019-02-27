using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportRun
    {
        [Key]
        [Column("VENDOR_REPORT_RUN_KEY")]
        public int VendorReportRunKey { get; set; }
        [Column("VENDOR_REPORT_CONFIG_KEY")]
        public int? VendorReportConfigKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public int AgencyMasterKey { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }
        [Column("COMPLETED")]
        public bool Completed { get; set; }
        [Column("COUNT_BASE")]
        public int CountBase { get; set; }
        [Column("COUNT_J1")]
        public int CountJ1 { get; set; }
        [Column("COUNT_PAYMENT_PLAN")]
        public int CountPaymentPlan { get; set; }
        [Column("COUNT_SPAY")]
        public int CountSpay { get; set; }
        [Column("COUNT_MPAY")]
        public int CountMpay { get; set; }
        [Column("COUNT_OEND")]
        public int CountOend { get; set; }
        [Column("OUTPUT_FILE")]
        [StringLength(300)]
        public string OutputFile { get; set; }

        [ForeignKey("VendorReportConfigKey")]
        [InverseProperty("VendorReportRun")]
        public virtual VendorReportConfig VendorReportConfigKeyNavigation { get; set; }
    }
}
