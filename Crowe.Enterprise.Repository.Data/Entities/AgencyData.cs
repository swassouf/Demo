using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyData
    {
        public AgencyData()
        {
            AgencyDataDeviceId = new HashSet<AgencyDataDeviceId>();
            ScoreSummaryAgencyDataXref = new HashSet<ScoreSummaryAgencyDataXref>();
        }

        [Column("AGENCY_DATA_KEY")]
        public int AgencyDataKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Column("CUSTOMER_KEY")]
        public int CustomerKey { get; set; }
        [Required]
        [Column("DB_SOURCE")]
        [StringLength(1)]
        public string DbSource { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime DateEntered { get; set; }
        [Column("RAW_DATA")]
        public string RawData { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int? LoanApplicationKey { get; set; }
        [Column("DATA_ERROR")]
        public bool DataError { get; set; }
        [Column("DATA_OVERRIDE")]
        public bool? DataOverride { get; set; }
        [Column("REPORT_TOKEN")]
        [StringLength(75)]
        public string ReportToken { get; set; }
        [Column("AGENCY_DETAIL_KEY")]
        public int? AgencyDetailKey { get; set; }
        [Column("REPORT_TIME")]
        public int? ReportTime { get; set; }
        [Column("OVERRIDE_PCT", TypeName = "decimal(5, 2)")]
        public decimal OverridePct { get; set; }
        [Column("OVERRIDE_AMT", TypeName = "decimal(8, 2)")]
        public decimal OverrideAmt { get; set; }
        [Column("REQUEST_DATA")]
        public string RequestData { get; set; }
        [Column("VISITOR_KEY")]
        public int? VisitorKey { get; set; }

        [ForeignKey("AgencyMasterKey")]
        [InverseProperty("AgencyData")]
        public virtual AgencyMaster AgencyMasterKeyNavigation { get; set; }
        [InverseProperty("AgencyDataKeyNavigation")]
        public virtual ICollection<AgencyDataDeviceId> AgencyDataDeviceId { get; set; }
        [InverseProperty("AgencyDataKeyNavigation")]
        public virtual ICollection<ScoreSummaryAgencyDataXref> ScoreSummaryAgencyDataXref { get; set; }
    }
}
