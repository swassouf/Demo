using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LoanApplicationEmployer
    {
        [Column("LOAN_APPLICATION_EMPLOYER_KEY")]
        public int LoanApplicationEmployerKey { get; set; }
        [Key]
        [Column("PK_LOAN_APPLICATION_EMPLOYER_KEY")]
        public int PkLoanApplicationEmployerKey { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int? LoanApplicationKey { get; set; }
        [Column("EMPLOYER_NAME")]
        [StringLength(50)]
        public string EmployerName { get; set; }
        [Column("DEPARTMENT")]
        [StringLength(60)]
        public string Department { get; set; }
        [Column("COUNTY")]
        [StringLength(25)]
        public string County { get; set; }
        [Column("COUNTRY")]
        [StringLength(3)]
        public string Country { get; set; }
        [Column("LOAN_APPLICATION_ADDRESS_KEY")]
        public int? LoanApplicationAddressKey { get; set; }
        [Column("IS_DIRECT_DEPOSIT")]
        public bool? IsDirectDeposit { get; set; }
        [Column("EMP_SINCE", TypeName = "date")]
        public DateTime? EmpSince { get; set; }
        [Column("FULLPARTTIME")]
        [StringLength(1)]
        public string Fullparttime { get; set; }
        [Column("PHONE_NUMBER")]
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        [Column("PHONE_EXT")]
        [StringLength(10)]
        public string PhoneExt { get; set; }
        [Column("PAY_CYCLE")]
        [StringLength(1)]
        public string PayCycle { get; set; }
        [Column("PAY_CYCLE_DAY")]
        public byte? PayCycleDay { get; set; }
        [Column("PAY_CYCLE_1ST")]
        public byte? PayCycle1st { get; set; }
        [Column("PAY_CYCLE_2ND")]
        public byte? PayCycle2nd { get; set; }
        [Column("BIWEEK_BASE", TypeName = "date")]
        public DateTime? BiweekBase { get; set; }
        [Column("PAY_CYCLE_MONTH_INT")]
        [StringLength(1)]
        public string PayCycleMonthInt { get; set; }
        [Column("PAY_CYCLE_COUNT_DAYS_FROM_END_OF_MONTH")]
        public bool? PayCycleCountDaysFromEndOfMonth { get; set; }
        [Column("INCOME_TYPE_KEY")]
        public int? IncomeTypeKey { get; set; }
        [Column("INCOME_SOURCE_KEY")]
        public int? IncomeSourceKey { get; set; }
        [Column("INCOME_JOB_TYPE_KEY")]
        public int? IncomeJobTypeKey { get; set; }
        [Column("IS_PRIMARY_EMPLOYER")]
        public bool IsPrimaryEmployer { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime DateEntered { get; set; }
        [Column("TELLER")]
        [StringLength(3)]
        public string Teller { get; set; }
        [Column("JOB_TYPE_VERIFIED_DATE", TypeName = "smalldatetime")]
        public DateTime? JobTypeVerifiedDate { get; set; }
        [Column("CUSTOMER_EMPLOYER_KEY")]
        public int? CustomerEmployerKey { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int? LoanAppPrimKey { get; set; }

        [ForeignKey("LoanAppPrimKey")]
        [InverseProperty("LoanApplicationEmployer")]
        public virtual LoanApplication LoanAppPrimKeyNavigation { get; set; }
    }
}
