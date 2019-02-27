using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyCertificate
    {
        [Key]
        [Column("AGENCY_CERTIFICATE_KEY")]
        public int AgencyCertificateKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Required]
        [Column("DATA")]
        public byte[] Data { get; set; }
        [Column("PASSWORD")]
        [StringLength(100)]
        public string Password { get; set; }
        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetimeoffset(0)")]
        public DateTimeOffset DateEntered { get; set; }
        [Column("DATE_EXPIRES", TypeName = "datetimeoffset(0)")]
        public DateTimeOffset DateExpires { get; set; }

        [ForeignKey("AgencyMasterKey")]
        [InverseProperty("AgencyCertificate")]
        public virtual AgencyMaster AgencyMasterKeyNavigation { get; set; }
    }
}
