using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class Claim
    {
        public Claim()
        {
            SecurityGroupClaim = new HashSet<SecurityGroupClaim>();
            UserClaim = new HashSet<UserClaim>();
        }

        [Key]
        [Column("CLAIM_KEY")]
        public int ClaimKey { get; set; }
        [Required]
        [Column("URI")]
        [StringLength(75)]
        public string Uri { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }

        [InverseProperty("ClaimKeyNavigation")]
        public virtual ICollection<SecurityGroupClaim> SecurityGroupClaim { get; set; }
        [InverseProperty("ClaimKeyNavigation")]
        public virtual ICollection<UserClaim> UserClaim { get; set; }
    }
}
