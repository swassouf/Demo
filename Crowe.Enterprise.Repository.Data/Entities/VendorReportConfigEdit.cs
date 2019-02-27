using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportConfigEdit
    {
        [Key]
        [Column("VENDOR_REPORT_CONFIG_EDIT_KEY")]
        public int VendorReportConfigEditKey { get; set; }
        [Column("VENDOR_REPORT_CONFIG_KEY")]
        public int VendorReportConfigKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Required]
        [Column("CONFIG_NAME")]
        [StringLength(100)]
        public string ConfigName { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }
        [Column("ENTERED_BY")]
        [StringLength(3)]
        public string EnteredBy { get; set; }
        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }
        [Required]
        [Column("FREQUENCY")]
        [StringLength(1)]
        public string Frequency { get; set; }
        [Column("LOGIN_URL")]
        [StringLength(500)]
        public string LoginUrl { get; set; }
        [Column("LOGIN_ID")]
        [StringLength(30)]
        public string LoginId { get; set; }
        [Column("LOGIN_PWD")]
        [StringLength(30)]
        public string LoginPwd { get; set; }
        [Column("OUTPUT_FOLDER")]
        [StringLength(300)]
        public string OutputFolder { get; set; }
        [Required]
        [Column("METRO2_ID")]
        [StringLength(20)]
        public string Metro2Id { get; set; }
        [Column("APPEND_LOCATION")]
        public bool AppendLocation { get; set; }
    }
}
