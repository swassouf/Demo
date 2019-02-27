using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyMaster
    {
        public AgencyMaster()
        {
            AgencyCertificate = new HashSet<AgencyCertificate>();
            AgencyData = new HashSet<AgencyData>();
            AgencyDetail = new HashSet<AgencyDetail>();
            AgencyDetailAttribute = new HashSet<AgencyDetailAttribute>();
            AgencyReport = new HashSet<AgencyReport>();
            ScoreDenialReason = new HashSet<ScoreDenialReason>();
            VendorLocationCredential = new HashSet<VendorLocationCredential>();
            VendorReportConfig = new HashSet<VendorReportConfig>();
        }

        [Key]
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Required]
        [Column("AGENCY_NAME")]
        [StringLength(100)]
        public string AgencyName { get; set; }
        [Column("CONTACT_NAME")]
        [StringLength(100)]
        public string ContactName { get; set; }
        [Column("CONTACT_NUMBER")]
        [StringLength(20)]
        public string ContactNumber { get; set; }
        [Column("CONTACT_EXT")]
        [StringLength(5)]
        public string ContactExt { get; set; }
        [Column("AGENCY_ADDRESS")]
        [StringLength(100)]
        public string AgencyAddress { get; set; }
        [Column("AGENCY_CITY")]
        [StringLength(40)]
        public string AgencyCity { get; set; }
        [Column("AGENCY_STATE")]
        [StringLength(2)]
        public string AgencyState { get; set; }
        [Column("AGENCY_ZIP")]
        [StringLength(10)]
        public string AgencyZip { get; set; }
        [Column("RUN_ORDER")]
        public short? RunOrder { get; set; }
        [Column("REFRESH_INTERVAL")]
        public short? RefreshInterval { get; set; }
        [Column("COST_PER_REPORT", TypeName = "smallmoney")]
        public decimal CostPerReport { get; set; }
        [Required]
        [Column("TEST_INQUIRY_URL")]
        [StringLength(300)]
        public string TestInquiryUrl { get; set; }
        [Required]
        [Column("PROD_INQUIRY_URL")]
        [StringLength(300)]
        public string ProdInquiryUrl { get; set; }
        [Required]
        [Column("TEST_UPDATE_URL")]
        [StringLength(300)]
        public string TestUpdateUrl { get; set; }
        [Required]
        [Column("PROD_UPDATE_URL")]
        [StringLength(300)]
        public string ProdUpdateUrl { get; set; }
        [Required]
        [Column("STORE_TEST_USERNAME")]
        [StringLength(150)]
        public string StoreTestUsername { get; set; }
        [Required]
        [Column("STORE_PROD_USERNAME")]
        [StringLength(150)]
        public string StoreProdUsername { get; set; }
        [Required]
        [Column("STORE_TEST_PASSWORD")]
        [StringLength(150)]
        public string StoreTestPassword { get; set; }
        [Required]
        [Column("STORE_PROD_PASSWORD")]
        [StringLength(150)]
        public string StoreProdPassword { get; set; }
        [Required]
        [Column("INET_TEST_USERNAME")]
        [StringLength(150)]
        public string InetTestUsername { get; set; }
        [Required]
        [Column("INET_TEST_PASSWORD")]
        [StringLength(150)]
        public string InetTestPassword { get; set; }
        [Required]
        [Column("INET_PROD_USERNAME")]
        [StringLength(150)]
        public string InetProdUsername { get; set; }
        [Required]
        [Column("INET_PROD_PASSWORD")]
        [StringLength(150)]
        public string InetProdPassword { get; set; }
        [Required]
        [Column("STORE_TEST_USER_KEY")]
        [StringLength(150)]
        public string StoreTestUserKey { get; set; }
        [Required]
        [Column("STORE_PROD_USER_KEY")]
        [StringLength(150)]
        public string StoreProdUserKey { get; set; }
        [Required]
        [Column("INET_TEST_USER_KEY")]
        [StringLength(150)]
        public string InetTestUserKey { get; set; }
        [Required]
        [Column("INET_PROD_USER_KEY")]
        [StringLength(150)]
        public string InetProdUserKey { get; set; }
        [Required]
        [Column("INET_INQUIRY_PASSWORD")]
        [StringLength(150)]
        public string InetInquiryPassword { get; set; }
        [Required]
        [Column("ADDRESS_CONSUMER_CONTACT_NAME")]
        [StringLength(50)]
        public string AddressConsumerContactName { get; set; }
        [Required]
        [Column("CONSUMER_CONTACT_URL")]
        [StringLength(50)]
        public string ConsumerContactUrl { get; set; }
        [Required]
        [Column("AGENCY_ADDRESS2")]
        [StringLength(50)]
        public string AgencyAddress2 { get; set; }
        [Column("IS_CRA")]
        public bool IsCra { get; set; }
        [Required]
        [Column("PROXY_SERVER_ADDRESS")]
        [StringLength(50)]
        public string ProxyServerAddress { get; set; }
        [Required]
        [Column("HTTP_CONTENT_TYPE")]
        [StringLength(50)]
        public string HttpContentType { get; set; }
        [Column("HTTP_TIMEOUT")]
        public int HttpTimeout { get; set; }
        [Column("CREDIT_SCORE_PRIORITY")]
        public short CreditScorePriority { get; set; }
        [Column("CREDIT_SCORE_BEGIN_RANGE")]
        public int CreditScoreBeginRange { get; set; }
        [Column("CREDIT_SCORE_END_RANGE")]
        public int CreditScoreEndRange { get; set; }
        [Required]
        [Column("HTTP_SOAP_ACTION_HEADER")]
        [StringLength(125)]
        public string HttpSoapActionHeader { get; set; }
        [Column("IS_MILITARY")]
        public bool IsMilitary { get; set; }
        [Column("PRE_AUTHENTICATE")]
        public bool PreAuthenticate { get; set; }
        [Column("IS_STATE_DATABASE")]
        public bool IsStateDatabase { get; set; }
        [Column("USE_RAZOR")]
        public bool UseRazor { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }
        [Column("IS_DISCOVERY_URL")]
        public bool IsDiscoveryUrl { get; set; }
        [Column("AUTHENTICATION_SCHEME")]
        public int AuthenticationScheme { get; set; }

        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<AgencyCertificate> AgencyCertificate { get; set; }
        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<AgencyData> AgencyData { get; set; }
        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<AgencyDetail> AgencyDetail { get; set; }
        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<AgencyDetailAttribute> AgencyDetailAttribute { get; set; }
        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<AgencyReport> AgencyReport { get; set; }
        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<ScoreDenialReason> ScoreDenialReason { get; set; }
        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<VendorLocationCredential> VendorLocationCredential { get; set; }
        [InverseProperty("AgencyMasterKeyNavigation")]
        public virtual ICollection<VendorReportConfig> VendorReportConfig { get; set; }
    }
}
