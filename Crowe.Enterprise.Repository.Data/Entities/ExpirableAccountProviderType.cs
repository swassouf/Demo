using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ExpirableAccountProviderType
    {
        public ExpirableAccountProviderType()
        {
            ExpirableAccount = new HashSet<ExpirableAccount>();
        }

        [Key]
        [Column("EXPIRABLE_ACCOUNT_PROVIDER_TYPE_KEY")]
        public int ExpirableAccountProviderTypeKey { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(64)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }

        [InverseProperty("ExpirableAccountProviderTypeKeyNavigation")]
        public virtual ICollection<ExpirableAccount> ExpirableAccount { get; set; }
    }
}
