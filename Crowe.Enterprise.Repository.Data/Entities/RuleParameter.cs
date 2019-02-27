using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleParameter
    {
        public RuleParameter()
        {
            RuleParameterDetail = new HashSet<RuleParameterDetail>();
        }

        [Key]
        [Column("RULE_PARAMETER_KEY")]
        public int RuleParameterKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Column("PARAMETER_TYPE_CODE")]
        public byte ParameterTypeCode { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("RuleHeaderKey")]
        [InverseProperty("RuleParameter")]
        public virtual RuleHeader RuleHeaderKeyNavigation { get; set; }
        [InverseProperty("RuleParameterParentKeyNavigation")]
        public virtual ICollection<RuleParameterDetail> RuleParameterDetail { get; set; }
    }
}
