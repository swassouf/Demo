using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class MultiScoreMatrix
    {
        [Key]
        [Column("MULTI_SCORE_MATRIX_KEY")]
        public int MultiScoreMatrixKey { get; set; }
        [Column("PRIMARY_MODEL_NUM")]
        public short PrimaryModelNum { get; set; }
        [Column("SECONDARY_MODEL_NUM")]
        public short SecondaryModelNum { get; set; }
        [Column("TERTIARY_MODEL_NUM")]
        public short TertiaryModelNum { get; set; }
        [Column("PRIMARY_SCORE_BEGIN_RANGE", TypeName = "decimal(8, 2)")]
        public decimal PrimaryScoreBeginRange { get; set; }
        [Column("PRIMARY_SCORE_END_RANGE", TypeName = "decimal(8, 2)")]
        public decimal PrimaryScoreEndRange { get; set; }
        [Column("SECONDARY_SCORE_BEGIN_RANGE", TypeName = "decimal(8, 2)")]
        public decimal SecondaryScoreBeginRange { get; set; }
        [Column("SECONDARY_SCORE_END_RANGE", TypeName = "decimal(8, 2)")]
        public decimal SecondaryScoreEndRange { get; set; }
        [Column("TERTIARY_SCORE_BEGIN_RANGE", TypeName = "decimal(8, 2)")]
        public decimal TertiaryScoreBeginRange { get; set; }
        [Column("TERTIARY_SCORE_END_RANGE", TypeName = "decimal(8, 2)")]
        public decimal TertiaryScoreEndRange { get; set; }
        [Column("FINAL_SCORE", TypeName = "decimal(8, 2)")]
        public decimal FinalScore { get; set; }
    }
}
