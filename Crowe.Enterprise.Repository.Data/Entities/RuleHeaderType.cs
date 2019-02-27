using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleHeaderType
    {
        public RuleHeaderType()
        {
            RuleHeaderDetail = new HashSet<RuleHeaderDetail>();
        }

        [Key]
        [Column("RULE_HEADER_TYPE_KEY")]
        public int RuleHeaderTypeKey { get; set; }
        [Column("RULE_HEADER_TYPE")]
        public byte RuleHeaderType1 { get; set; }
        [Required]
        [Column("TYPE_DESCRIPTION")]
        [StringLength(100)]
        public string TypeDescription { get; set; }

        public virtual ICollection<RuleHeaderDetail> RuleHeaderDetail { get; set; }
    }
}
