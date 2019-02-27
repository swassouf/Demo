using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoringHealthCheckLog
    {
        [Key]
        [Column("SCORING_HEALTH_CHECK_LOG_KEY")]
        public int ScoringHealthCheckLogKey { get; set; }
        [Column("SCORING_HEALTH_CHECK_KEY")]
        public int ScoringHealthCheckKey { get; set; }
        [Required]
        [Column("ERROR_MSG")]
        public string ErrorMsg { get; set; }
        [Column("LAST_LOG_TIMESTAMP", TypeName = "datetime")]
        public DateTime LastLogTimestamp { get; set; }
        [Column("WELL_FORMED_XML")]
        public bool WellFormedXml { get; set; }
        [Column("LOGGED_TO_APPLOG")]
        public bool LoggedToApplog { get; set; }
    }
}
