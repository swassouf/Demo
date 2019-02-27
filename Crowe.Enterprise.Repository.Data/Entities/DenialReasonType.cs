using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class DenialReasonType
    {
        [Key]
        [Column("DENIAL_REASON_TYPE_KEY")]
        public int DenialReasonTypeKey { get; set; }
        [Required]
        [Column("REASON_TYPE_NAME")]
        [StringLength(100)]
        public string ReasonTypeName { get; set; }
        [Column("REASON_TYPE")]
        public byte ReasonType { get; set; }
    }
}
