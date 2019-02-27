using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyDetail
    {
        public AgencyDetail()
        {
            AgencyDetailAttribute = new HashSet<AgencyDetailAttribute>();
        }

        [Key]
        [Column("AGENCY_DETAIL_KEY")]
        public int AgencyDetailKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Required]
        [Column("AGENCY_DETAIL_NAME")]
        [StringLength(75)]
        public string AgencyDetailName { get; set; }
        [Required]
        [Column("STORE_TEST_USERNAME")]
        [StringLength(75)]
        public string StoreTestUsername { get; set; }
        [Required]
        [Column("STORE_TEST_PASSWORD")]
        [StringLength(75)]
        public string StoreTestPassword { get; set; }
        [Required]
        [Column("INET_TEST_USERNAME")]
        [StringLength(75)]
        public string InetTestUsername { get; set; }
        [Required]
        [Column("INET_TEST_PASSWORD")]
        [StringLength(75)]
        public string InetTestPassword { get; set; }
        [Required]
        [Column("STORE_PROD_USERNAME")]
        [StringLength(75)]
        public string StoreProdUsername { get; set; }
        [Required]
        [Column("STORE_PROD_PASSWORD")]
        [StringLength(75)]
        public string StoreProdPassword { get; set; }
        [Required]
        [Column("INET_PROD_USERNAME")]
        [StringLength(75)]
        public string InetProdUsername { get; set; }
        [Required]
        [Column("INET_PROD_PASSWORD")]
        [StringLength(75)]
        public string InetProdPassword { get; set; }
        [Required]
        [Column("INET_TEST_LICENSE_KEY")]
        [StringLength(75)]
        public string InetTestLicenseKey { get; set; }
        [Required]
        [Column("STORE_TEST_LICENSE_KEY")]
        [StringLength(75)]
        public string StoreTestLicenseKey { get; set; }
        [Required]
        [Column("INET_PROD_LICENSE_KEY")]
        [StringLength(75)]
        public string InetProdLicenseKey { get; set; }
        [Required]
        [Column("STORE_PROD_LICENSE_KEY")]
        [StringLength(75)]
        public string StoreProdLicenseKey { get; set; }
        [Required]
        [Column("ATTRIBUTE1")]
        [StringLength(150)]
        public string Attribute1 { get; set; }
        [Required]
        [Column("ATTRIBUTE2")]
        [StringLength(150)]
        public string Attribute2 { get; set; }
        [Required]
        [Column("ATTRIBUTE3")]
        [StringLength(150)]
        public string Attribute3 { get; set; }
        [Column("CREDIT_LOCK_XPATH")]
        [StringLength(500)]
        public string CreditLockXpath { get; set; }
        [Column("ERROR_XPATH")]
        [StringLength(500)]
        public string ErrorXpath { get; set; }
        [Column("TRANSFORM_ENCODED_XML_TO_XML")]
        public bool TransformEncodedXmlToXml { get; set; }
        [Column("INQUIRY_TEMPLATE")]
        public string InquiryTemplate { get; set; }
        [Column("CAN_IGNORE_DATA_ERROR")]
        public bool CanIgnoreDataError { get; set; }
        [Column("INET_TEST_EXPIRABLE_ACCOUNT_KEY")]
        public int? InetTestExpirableAccountKey { get; set; }
        [Column("INET_PROD_EXPIRABLE_ACCOUNT_KEY")]
        public int? InetProdExpirableAccountKey { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }
        [Column("CREDIT_SCORE_XPATH")]
        [StringLength(500)]
        public string CreditScoreXpath { get; set; }
        [Column("CREDIT_SCORE_REASONS_XPATH")]
        [StringLength(500)]
        public string CreditScoreReasonsXpath { get; set; }
        [Column("CREDIT_SCORE_REASON_DESCRIPTION_XPATH")]
        [StringLength(500)]
        public string CreditScoreReasonDescriptionXpath { get; set; }
        [Column("IS_SOFT_HIT")]
        public bool IsSoftHit { get; set; }

        [ForeignKey("AgencyMasterKey")]
        [InverseProperty("AgencyDetail")]
        public virtual AgencyMaster AgencyMasterKeyNavigation { get; set; }
        [InverseProperty("AgencyDetailKeyNavigation")]
        public virtual ICollection<AgencyDetailAttribute> AgencyDetailAttribute { get; set; }
    }
}
