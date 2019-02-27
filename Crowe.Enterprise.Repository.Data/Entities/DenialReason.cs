using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class DenialReason
    {
        public DenialReason()
        {
            ScoreDenialReason = new HashSet<ScoreDenialReason>();
        }

        [Key]
        [Column("DENIAL_REASON_KEY")]
        public int DenialReasonKey { get; set; }
        [Required]
        [Column("REASON_CODE")]
        [StringLength(15)]
        public string ReasonCode { get; set; }
        [Required]
        [Column("REASON_DESCRIPTION")]
        [StringLength(500)]
        public string ReasonDescription { get; set; }
        [Required]
        [Column("REASON_TALKOFF_TEXT")]
        public string ReasonTalkoffText { get; set; }
        [Column("IS_REASON_ACTIVE")]
        public bool IsReasonActive { get; set; }
        [Column("IS_TALKOFF_ACTIVE")]
        public bool IsTalkoffActive { get; set; }
        [Column("REASON_TYPE")]
        public byte ReasonType { get; set; }

        public virtual ICollection<ScoreDenialReason> ScoreDenialReason { get; set; }
    }
}
