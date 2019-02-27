using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class AgencyReport
    {
        [Key]
        [Column("AGENCY_REPORT_KEY")]
        public int AgencyReportKey { get; set; }
        [Column("AGENCY_MASTER_KEY")]
        public short AgencyMasterKey { get; set; }
        [Column("DATABASE_ID")]
        public byte DatabaseId { get; set; }
        [Required]
        [Column("FIELD_NAME")]
        [StringLength(500)]
        public string FieldName { get; set; }
        [Column("FIELD_DESCRIPTION")]
        [StringLength(100)]
        public string FieldDescription { get; set; }
        [Column("FIELD_POSITION")]
        public short? FieldPosition { get; set; }
        [Column("TABLE_NAME")]
        [StringLength(500)]
        public string TableName { get; set; }
        [Column("SQL")]
        [StringLength(5000)]
        public string Sql { get; set; }
        [Column("DATATYPE")]
        public byte Datatype { get; set; }
        [Column("SCORING_ITEM_MASTER_KEY")]
        public int? ScoringItemMasterKey { get; set; }
        [Required]
        [Column("ITEM_NAME")]
        [StringLength(100)]
        public string ItemName { get; set; }
        [Column("ITEM_DESCRIPTION")]
        [StringLength(100)]
        public string ItemDescription { get; set; }
        [Required]
        [Column("ACTIVE")]
        public bool? Active { get; set; }
        [Column("ITEM_SUM")]
        public bool ItemSum { get; set; }
        [Column("ITEM_COUNT")]
        public bool ItemCount { get; set; }
        [Column("IS_LIST")]
        public bool? IsList { get; set; }
        [Column("LINKED_FIELD_KEY")]
        public int? LinkedFieldKey { get; set; }
        [Column("LINKED_FIELD_OPERATOR")]
        public byte? LinkedFieldOperator { get; set; }
        [Column("SQL_TO_USE_ON_FIELD")]
        [StringLength(1500)]
        public string SqlToUseOnField { get; set; }
        [Column("ORDER_IN_LIST")]
        public byte? OrderInList { get; set; }
        [Column("ATTRIBUTE_NAME_VALUE")]
        [StringLength(50)]
        public string AttributeNameValue { get; set; }
        [Column("IS_SEARCHABLE_LIST")]
        public bool IsSearchableList { get; set; }
        [Column("IS_CREDIT_SCORE")]
        public bool IsCreditScore { get; set; }
        [Column("AGENCY_DETAIL_KEY")]
        public int? AgencyDetailKey { get; set; }
        [Required]
        [Column("LINK_DATE_PART")]
        [StringLength(5)]
        public string LinkDatePart { get; set; }
        [Required]
        [Column("UPDATED_BY")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ForeignKey("AgencyMasterKey")]
        [InverseProperty("AgencyReport")]
        public virtual AgencyMaster AgencyMasterKeyNavigation { get; set; }
    }
}
