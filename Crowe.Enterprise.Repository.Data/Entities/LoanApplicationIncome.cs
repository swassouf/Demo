using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LoanApplicationIncome
    {
        [Column("LOAN_APPLICATION_INCOME_KEY")]
        public int LoanApplicationIncomeKey { get; set; }
        [Key]
        [Column("PK_LOAN_APPLICATION_INCOME_KEY")]
        public int PkLoanApplicationIncomeKey { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int? LoanApplicationKey { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime? DateEntered { get; set; }
        [Column("TELLER")]
        [StringLength(3)]
        public string Teller { get; set; }
        [Column("AMOUNT_TYPE")]
        [StringLength(1)]
        public string AmountType { get; set; }
        [Column("AMOUNT_CYCLE")]
        [StringLength(1)]
        public string AmountCycle { get; set; }
        [Column("INCOME_AMOUNT", TypeName = "smallmoney")]
        public decimal? IncomeAmount { get; set; }
        [Column("LOAN_APPLICATION_EMPLOYER_KEY")]
        public int? LoanApplicationEmployerKey { get; set; }
        [Column("INCOME_VERIFY_METHOD_KEY")]
        public int? IncomeVerifyMethodKey { get; set; }
        [Column("DATE_VERIFIED", TypeName = "date")]
        public DateTime? DateVerified { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int? LoanAppPrimKey { get; set; }

        [ForeignKey("LoanAppPrimKey")]
        [InverseProperty("LoanApplicationIncome")]
        public virtual LoanApplication LoanAppPrimKeyNavigation { get; set; }
    }
}
