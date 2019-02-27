using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorLocationCredential
    {
        [Key]
        [Column("VENDOR_LOCATION_CREDENTIAL_KEY")]
        public int VendorLocationCredentialKey { get; set; }
        [Column("LOCATION_KEY")]
        public short LocationKey { get; set; }
        [Required]
        [Column("LOAN_TYPE")]
        [StringLength(1)]
        public string LoanType { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Column("TEST_USER_ID")]
        [StringLength(50)]
        public string TestUserId { get; set; }
        [Column("TEST_PASSWORD")]
        [StringLength(50)]
        public string TestPassword { get; set; }
        [Column("TEST_LICENSE_KEY")]
        [StringLength(50)]
        public string TestLicenseKey { get; set; }
        [Column("PROD_USER_ID")]
        [StringLength(50)]
        public string ProdUserId { get; set; }
        [Column("PROD_PASSWORD")]
        [StringLength(50)]
        public string ProdPassword { get; set; }
        [Column("PROD_LICENSE_KEY")]
        [StringLength(50)]
        public string ProdLicenseKey { get; set; }

        [ForeignKey("AgencyMasterKey")]
        [InverseProperty("VendorLocationCredential")]
        public virtual AgencyMaster AgencyMasterKeyNavigation { get; set; }
    }
}
