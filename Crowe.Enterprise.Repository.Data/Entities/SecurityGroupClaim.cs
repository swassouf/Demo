using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class SecurityGroupClaim
    {
        [Key]
        [Column("SECURITY_GROUP_CLAIM_KEY")]
        public int SecurityGroupClaimKey { get; set; }
        [Column("SECURITY_GROUP_KEY")]
        public int SecurityGroupKey { get; set; }
        [Column("CLAIM_KEY")]
        public int ClaimKey { get; set; }
        [Required]
        [Column("CLAIM_ACTION")]
        [StringLength(25)]
        public string ClaimAction { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Column("ENTERED_BY")]
        [StringLength(3)]
        public string EnteredBy { get; set; }
        [Column("DATE_UPDATED", TypeName = "smalldatetime")]
        public DateTime? DateUpdated { get; set; }
        [Column("UPDATED_BY")]
        [StringLength(3)]
        public string UpdatedBy { get; set; }

        [ForeignKey("ClaimKey")]
        [InverseProperty("SecurityGroupClaim")]
        public virtual Claim ClaimKeyNavigation { get; set; }
        [ForeignKey("SecurityGroupKey")]
        [InverseProperty("SecurityGroupClaim")]
        public virtual SecurityGroup SecurityGroupKeyNavigation { get; set; }
    }
}
