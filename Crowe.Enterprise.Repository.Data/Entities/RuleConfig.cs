using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleConfig
    {
        [Key]
        [Column("RULE_CONFIG_KEY")]
        public int RuleConfigKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("CONFIG_KEY")]
        public int ConfigKey { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("RuleHeaderKey")]
        [InverseProperty("RuleConfig")]
        public virtual RuleHeader RuleHeaderKeyNavigation { get; set; }
    }
}
