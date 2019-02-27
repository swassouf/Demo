using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportLoan
    {
        [Key]
        [Column("VENDOR_REPORT_LOAN_KEY")]
        public int VendorReportLoanKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public int AgencyMasterKey { get; set; }
        [Column("LOAN_KEY")]
        public int LoanKey { get; set; }
        [Column("LAST_DATE_REPORTED", TypeName = "date")]
        public DateTime LastDateReported { get; set; }
    }
}
