using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class ScoringHealthCheck
    {
        [Key]
        [Column("SCORING_HEALTH_CHECK_KEY")]
        public int ScoringHealthCheckKey { get; set; }
        [Required]
        [Column("CHECK_NAME")]
        [StringLength(100)]
        public string CheckName { get; set; }
        [Required]
        [Column("CHECK_SQL")]
        public string CheckSql { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public int AgencyMasterKey { get; set; }
        [Column("ACTIVE")]
        public bool Active { get; set; }
        [Column("ERROR_REPORT_TIME_LIMIT")]
        public int ErrorReportTimeLimit { get; set; }
        [Column("ERROR_COUNT_THRESHOLD")]
        public int ErrorCountThreshold { get; set; }
        [Column("PAUSE_BEGIN_TIME", TypeName = "datetime")]
        public DateTime? PauseBeginTime { get; set; }
        [Column("PAUSE_END_TIME", TypeName = "datetime")]
        public DateTime? PauseEndTime { get; set; }
        [Required]
        [Column("XPATH")]
        [StringLength(500)]
        public string Xpath { get; set; }
    }
}
