using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyDataDeviceId
    {
        [Key]
        [Column("AGENCY_DATA_DEVICE_ID_KEY")]
        public int AgencyDataDeviceIdKey { get; set; }
        [Column("AGENCY_DATA_KEY")]
        public int AgencyDataKey { get; set; }
        [Column("IOVATION_DEVICE_ALIAS")]
        public long? IovationDeviceAlias { get; set; }
        [Column("THREATMETRIX_EXACT_ID")]
        public Guid? ThreatmetrixExactId { get; set; }
        [Column("THREATMETRIX_SMART_ID")]
        public Guid? ThreatmetrixSmartId { get; set; }

        [ForeignKey("AgencyDataKey")]
        [InverseProperty("AgencyDataDeviceId")]
        public virtual AgencyData AgencyDataKeyNavigation { get; set; }
    }
}
