using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class UserClaim
    {
        [Key]
        [Column("USER_CLAIM_KEY")]
        public int UserClaimKey { get; set; }
        [Required]
        [Column("TELLER")]
        [StringLength(3)]
        public string Teller { get; set; }
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
        [InverseProperty("UserClaim")]
        public virtual Claim ClaimKeyNavigation { get; set; }
    }
}
