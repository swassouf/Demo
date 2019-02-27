using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class Country
    {
        [Column("COUNTRY_KEY")]
        public int CountryKey { get; set; }
        [Required]
        [Column("COUNTRY")]
        [StringLength(50)]
        public string Country1 { get; set; }
        [Required]
        [Column("COUNTRY_ABBREV")]
        [StringLength(3)]
        public string CountryAbbrev { get; set; }
        [Column("COUNTRY_CODE")]
        public byte CountryCode { get; set; }
    }
}
