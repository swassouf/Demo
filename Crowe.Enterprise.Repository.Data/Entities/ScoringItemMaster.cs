using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoringItemMaster
    {
        public ScoringItemMaster()
        {
            RuleExpression = new HashSet<RuleExpression>();
            RuleParameterDetail = new HashSet<RuleParameterDetail>();
        }

        [Key]
        [Column("SCORING_ITEM_MASTER_KEY")]
        public int ScoringItemMasterKey { get; set; }
        [Required]
        [Column("ITEM_NAME")]
        [StringLength(100)]
        public string ItemName { get; set; }
        [Column("ITEM_DESCRIPTION")]
        [StringLength(1000)]
        public string ItemDescription { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }
        [Column("DATATYPE")]
        public byte Datatype { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [InverseProperty("ScoringItemMasterKeyNavigation")]
        public virtual ICollection<RuleExpression> RuleExpression { get; set; }
        [InverseProperty("ScoringItemMasterKeyNavigation")]
        public virtual ICollection<RuleParameterDetail> RuleParameterDetail { get; set; }
    }
}
