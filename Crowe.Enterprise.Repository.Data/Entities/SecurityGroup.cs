using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class SecurityGroup
    {
        public SecurityGroup()
        {
            SecurityGroupClaim = new HashSet<SecurityGroupClaim>();
            UserSecurityGroup = new HashSet<UserSecurityGroup>();
        }

        [Key]
        [Column("SECURITY_GROUP_KEY")]
        public int SecurityGroupKey { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }
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

        [InverseProperty("SecurityGroupKeyNavigation")]
        public virtual ICollection<SecurityGroupClaim> SecurityGroupClaim { get; set; }
        [InverseProperty("SecurityGroupKeyNavigation")]
        public virtual ICollection<UserSecurityGroup> UserSecurityGroup { get; set; }
    }
}
