using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ExpirableAccount
    {
        [Key]
        [Column("EXPIRABLE_ACCOUNT_KEY")]
        public int ExpirableAccountKey { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }
        [Column("EXPIRABLE_ACCOUNT_PROVIDER_TYPE_KEY")]
        public int ExpirableAccountProviderTypeKey { get; set; }
        [Column("PASSWORD_TYPE_KEY")]
        public int PasswordTypeKey { get; set; }
        [Column("URI")]
        [StringLength(255)]
        public string Uri { get; set; }
        [Column("USERNAME")]
        [StringLength(75)]
        public string Username { get; set; }
        [Column("PASSWORD")]
        [StringLength(75)]
        public string Password { get; set; }
        [Column("CERTIFICATE_DATA")]
        public byte[] CertificateData { get; set; }
        [Column("CERTIFICATE_PASSWORD")]
        [StringLength(75)]
        public string CertificatePassword { get; set; }
        [Column("INET_PASSWORD_UPDATED_DATE", TypeName = "datetime")]
        public DateTime? InetPasswordUpdatedDate { get; set; }
        [Column("INET_PASSWORD_UPDATED_BY")]
        [StringLength(10)]
        public string InetPasswordUpdatedBy { get; set; }
        [Column("PASSWORD_UPDATE_DURATION")]
        public int? PasswordUpdateDuration { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("ExpirableAccountProviderTypeKey")]
        [InverseProperty("ExpirableAccount")]
        public virtual ExpirableAccountProviderType ExpirableAccountProviderTypeKeyNavigation { get; set; }
        [ForeignKey("PasswordTypeKey")]
        [InverseProperty("ExpirableAccount")]
        public virtual PasswordType PasswordTypeKeyNavigation { get; set; }
    }
}
