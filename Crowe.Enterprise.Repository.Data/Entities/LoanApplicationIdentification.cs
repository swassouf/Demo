using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LoanApplicationIdentification
    {
        [Column("LOAN_APPLICATION_IDENTIFICATION_KEY")]
        public int? LoanApplicationIdentificationKey { get; set; }
        [Key]
        [Column("PK_LOAN_APPLICATION_IDENTIFICATION_KEY")]
        public int PkLoanApplicationIdentificationKey { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int? LoanApplicationKey { get; set; }
        [Column("IDENTIFICATION_TYPE_KEY")]
        public int? IdentificationTypeKey { get; set; }
        [Column("ID_NUMBER")]
        [StringLength(40)]
        public string IdNumber { get; set; }
        [Column("OTHER_SOURCE")]
        [StringLength(30)]
        public string OtherSource { get; set; }
        [Column("VERIFIED_OTHER")]
        [StringLength(30)]
        public string VerifiedOther { get; set; }
        [Column("EXPIRATION_DATE", TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }
        [Column("ID_COUNTRY")]
        [StringLength(3)]
        public string IdCountry { get; set; }
        [Column("ID_STATE")]
        [StringLength(2)]
        public string IdState { get; set; }
        [Column("IDENTIFICATION_TYPE_VERIFY_KEY")]
        public int? IdentificationTypeVerifyKey { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int LoanAppPrimKey { get; set; }

        [ForeignKey("LoanAppPrimKey")]
        [InverseProperty("LoanApplicationIdentification")]
        public virtual LoanApplication LoanAppPrimKeyNavigation { get; set; }
    }
}
