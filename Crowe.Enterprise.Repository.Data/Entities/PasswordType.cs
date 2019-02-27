using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class PasswordType
    {
        public PasswordType()
        {
            ExpirableAccount = new HashSet<ExpirableAccount>();
        }

        [Key]
        [Column("PASSWORD_TYPE_KEY")]
        public int PasswordTypeKey { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(64)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }

        [InverseProperty("PasswordTypeKeyNavigation")]
        public virtual ICollection<ExpirableAccount> ExpirableAccount { get; set; }
    }
}
