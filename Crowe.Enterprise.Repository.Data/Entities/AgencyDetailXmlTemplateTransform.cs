using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyDetailXmlTemplateTransform
    {
        [Key]
        [Column("AGENCY_DETAIL_XML_TEMPLATE_TRANSFORM_KEY")]
        public int AgencyDetailXmlTemplateTransformKey { get; set; }
        [Column("AGENCY_DETAIL_KEY")]
        public int AgencyDetailKey { get; set; }
        [Required]
        [Column("XPATH_STATEMENT")]
        [StringLength(500)]
        public string XpathStatement { get; set; }
        [Required]
        [Column("REPLACEMENT_VALUE")]
        [StringLength(500)]
        public string ReplacementValue { get; set; }
        [Column("USE_IN_NON_PRODUCTION")]
        public bool UseInNonProduction { get; set; }
    }
}
