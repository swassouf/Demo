using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleHeaderDetail
    {
        [Key]
        [Column("RULE_HEADER_DETAIL_KEY")]
        public int RuleHeaderDetailKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("RULE_HEADER_TYPE")]
        public byte RuleHeaderType { get; set; }

        [ForeignKey("RuleHeaderKey")]
        [InverseProperty("RuleHeaderDetail")]
        public virtual RuleHeader RuleHeaderKeyNavigation { get; set; }
        public virtual RuleHeaderType RuleHeaderTypeNavigation { get; set; }
    }
}
