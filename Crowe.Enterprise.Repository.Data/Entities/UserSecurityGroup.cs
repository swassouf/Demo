using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class UserSecurityGroup
    {
        [Key]
        [Column("USER_SECURITY_GROUP_KEY")]
        public int UserSecurityGroupKey { get; set; }
        [Required]
        [Column("TELLER")]
        [StringLength(3)]
        public string Teller { get; set; }
        [Column("SECURITY_GROUP_KEY")]
        public int SecurityGroupKey { get; set; }

        [ForeignKey("SecurityGroupKey")]
        [InverseProperty("UserSecurityGroup")]
        public virtual SecurityGroup SecurityGroupKeyNavigation { get; set; }
    }
}
