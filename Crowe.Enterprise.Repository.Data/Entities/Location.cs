using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class Location
    {
        public Location()
        {
            LocationLoanProduct = new HashSet<LocationLoanProduct>();
            ScoreLoanMatrix = new HashSet<ScoreLoanMatrix>();
            ScoreSummary = new HashSet<ScoreSummary>();
        }

        [Key]
        [Column("LOCATION_KEY")]
        public short LocationKey { get; set; }
        [Required]
        [Column("LOCATION_NAME")]
        [StringLength(100)]
        public string LocationName { get; set; }
        [Column("IS_INTERNET")]
        public bool? IsInternet { get; set; }
        [Column("DB_SOURCE")]
        [StringLength(1)]
        public string DbSource { get; set; }
        [Column("USE_MULTIPLE_MODELS")]
        public bool UseMultipleModels { get; set; }
        [Column("DEF_STATE")]
        [StringLength(2)]
        public string DefState { get; set; }
        [Column("COUNTRY_CODE")]
        public byte CountryCode { get; set; }

        [InverseProperty("LocationKeyNavigation")]
        public virtual ICollection<LocationLoanProduct> LocationLoanProduct { get; set; }
        [InverseProperty("LocationKeyNavigation")]
        public virtual ICollection<ScoreLoanMatrix> ScoreLoanMatrix { get; set; }
        [InverseProperty("LocationKeyNavigation")]
        public virtual ICollection<ScoreSummary> ScoreSummary { get; set; }
    }
}
