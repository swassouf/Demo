using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class PointValue
    {
        [Key]
        [Column("POINT_VALUE_KEY")]
        public int PointValueKey { get; set; }
        [Column("RULE_HEADER_KEY")]
        public int RuleHeaderKey { get; set; }
        [Required]
        [Column("VALUE")]
        [StringLength(250)]
        public string Value { get; set; }
        [Column("POINTS", TypeName = "decimal(18, 9)")]
        public decimal Points { get; set; }
        [Column("STOP_ACTION")]
        public byte StopAction { get; set; }
    }
}
