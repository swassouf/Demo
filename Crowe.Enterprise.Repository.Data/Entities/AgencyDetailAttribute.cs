using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyDetailAttribute
    {
        [Key]
        [Column("AGENCY_DETAIL_ATTRIBUTE_KEY")]
        public int AgencyDetailAttributeKey { get; set; }
        [Column("AGENCY_DETAIL_KEY")]
        public int AgencyDetailKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Required]
        [Column("ATTRIBUTE_NAME")]
        [StringLength(250)]
        public string AttributeName { get; set; }
        [Required]
        [Column("ATTRIBUTE_VALUE")]
        [StringLength(500)]
        public string AttributeValue { get; set; }
        [Column("IS_TEST")]
        public bool IsTest { get; set; }
        [Required]
        [Column("ATTRIBUTE_ELEMENT_NAME")]
        [StringLength(250)]
        public string AttributeElementName { get; set; }
        [Required]
        [Column("ATTRIBUTE_ELEMENT_VALUE")]
        [StringLength(500)]
        public string AttributeElementValue { get; set; }
        [Column("ATTRIBUTE_ELEMENT_PARENT_KEY")]
        public int? AttributeElementParentKey { get; set; }

        [ForeignKey("AgencyDetailKey")]
        [InverseProperty("AgencyDetailAttribute")]
        public virtual AgencyDetail AgencyDetailKeyNavigation { get; set; }
        [ForeignKey("AgencyMasterKey")]
        [InverseProperty("AgencyDetailAttribute")]
        public virtual AgencyMaster AgencyMasterKeyNavigation { get; set; }
    }
}
