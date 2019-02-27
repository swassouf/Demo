using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LoanApplicationAffordSurvey
    {
        [Column("LOAN_APPLICATION_KEY")]
        public int? LoanApplicationKey { get; set; }
        [Column("MONTHLY_MORTGAGE")]
        public int? MonthlyMortgage { get; set; }
        [Column("MONTHLY_UTILITIES")]
        public int? MonthlyUtilities { get; set; }
        [Column("MONTHLY_OTHER_DEBT")]
        public int? MonthlyOtherDebt { get; set; }
        [Column("ROLLOVER_REQUEST_KEY")]
        public int? RolloverRequestKey { get; set; }
        [Column("PK_LOAN_APPLICATION_AFFORD_SURVEY_KEY")]
        public int PkLoanApplicationAffordSurveyKey { get; set; }
        [Column("LOAN_APPLICATION_AFFORD_SURVEY_KEY")]
        public int? LoanApplicationAffordSurveyKey { get; set; }
        [Column("VISITOR_KEY")]
        public int? VisitorKey { get; set; }
        [Column("NET_INCOME", TypeName = "money")]
        public decimal? NetIncome { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime? DateEntered { get; set; }
        [Column("IS_CUSTOMER_REVIEWED")]
        public bool? IsCustomerReviewed { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int? LoanAppPrimKey { get; set; }

        [ForeignKey("LoanAppPrimKey")]
        [InverseProperty("LoanApplicationAffordSurvey")]
        public virtual LoanApplication LoanAppPrimKeyNavigation { get; set; }
    }
}
