using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class RuleParameterType
    {
        [Key]
        [Column("RULE_PARAMETER_TYPE_KEY")]
        public int RuleParameterTypeKey { get; set; }
        [Column("RULE_PARAMETER_TYPE_CODE")]
        public byte RuleParameterTypeCode { get; set; }
        [Required]
        [Column("RULE_PARAMETER_TYPE_DESCRIPTION")]
        [StringLength(500)]
        public string RuleParameterTypeDescription { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }
    }
}
