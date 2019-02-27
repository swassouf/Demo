using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class Metro2Format
    {
        [Key]
        [Column("METRO2_FORMAT_KEY")]
        public int Metro2FormatKey { get; set; }
        [Required]
        [Column("SEGMENT_NAME")]
        [StringLength(4)]
        public string SegmentName { get; set; }
        [Column("FIELD_NUM")]
        public short FieldNum { get; set; }
        [Required]
        [Column("FIELD_NAME")]
        [StringLength(40)]
        public string FieldName { get; set; }
        [Column("FIELD_LENGTH")]
        public short FieldLength { get; set; }
        [Column("FIELD_TYPE")]
        [StringLength(2)]
        public string FieldType { get; set; }
        [Column("IS_REQUIRED")]
        public bool IsRequired { get; set; }
        [Column("START_POSITION")]
        public short StartPosition { get; set; }
    }
}
