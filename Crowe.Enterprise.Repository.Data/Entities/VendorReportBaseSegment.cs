using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class VendorReportBaseSegment
    {
        [Key]
        [Column("VENDOR_REPORT_BASE_SEGMENT_KEY")]
        public int VendorReportBaseSegmentKey { get; set; }
        [Column("DATE_ENTERED", TypeName = "date")]
        public DateTime DateEntered { get; set; }
        [Column("LOCATION_KEY")]
        public short LocationKey { get; set; }
        [Column("CUSTOMER_KEY")]
        public int CustomerKey { get; set; }
        [Column("LOAN_KEY")]
        public int LoanKey { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int LoanProductKey { get; set; }
        [Required]
        [Column("PRODUCT_TYPE")]
        [StringLength(1)]
        public string ProductType { get; set; }
        [Column("LOAN_CLOSED")]
        public bool LoanClosed { get; set; }
        [Column("LOAN_TRANSFERRED")]
        public bool LoanTransferred { get; set; }
        [Column("LOAN_SOLD")]
        public bool LoanSold { get; set; }
        [Required]
        [Column("LAST_STATUS")]
        [StringLength(4)]
        public string LastStatus { get; set; }
        [Required]
        [Column("LAST_SPECIAL_COMMENT")]
        [StringLength(4)]
        public string LastSpecialComment { get; set; }
        [Required]
        [Column("REPORTING_INDICATOR")]
        [StringLength(1)]
        public string ReportingIndicator { get; set; }
        [Column("LAST_DATE_UPDATED", TypeName = "date")]
        public DateTime LastDateUpdated { get; set; }
        [Required]
        [Column("IDENTIFICATION_NUMBER")]
        [StringLength(20)]
        public string IdentificationNumber { get; set; }
        [Column("CYCLE_IDENTIFIER")]
        [StringLength(2)]
        public string CycleIdentifier { get; set; }
        [Column("CONSUMER_ACCOUNT_NUMBER")]
        public int ConsumerAccountNumber { get; set; }
        [Required]
        [Column("PORTFOLIO_TYPE")]
        [StringLength(1)]
        public string PortfolioType { get; set; }
        [Required]
        [Column("ACCOUNT_TYPE")]
        [StringLength(2)]
        public string AccountType { get; set; }
        [Column("DATE_OPENED", TypeName = "date")]
        public DateTime DateOpened { get; set; }
        [Column("CREDIT_LIMIT")]
        public int CreditLimit { get; set; }
        [Column("ORIGINAL_LOAN_AMOUNT")]
        public int OriginalLoanAmount { get; set; }
        [Column("TERMS_DURATION")]
        public short TermsDuration { get; set; }
        [Required]
        [Column("TERMS_FREQUENCY")]
        [StringLength(1)]
        public string TermsFrequency { get; set; }
        [Column("SCHEDULED_PAYMENT_AMOUNT")]
        public int ScheduledPaymentAmount { get; set; }
        [Column("ACTUAL_PAYMENT_AMOUNT")]
        public int ActualPaymentAmount { get; set; }
        [Required]
        [Column("ACCOUNT_STATUS")]
        [StringLength(2)]
        public string AccountStatus { get; set; }
        [Required]
        [Column("PAYMENT_RATING")]
        [StringLength(1)]
        public string PaymentRating { get; set; }
        [Required]
        [Column("PAYMENT_HISTORY_PROFILE")]
        [StringLength(24)]
        public string PaymentHistoryProfile { get; set; }
        [Required]
        [Column("SPECIAL_COMMENT")]
        [StringLength(2)]
        public string SpecialComment { get; set; }
        [Required]
        [Column("COMPLIANCE_CONDITION_CODE")]
        [StringLength(2)]
        public string ComplianceConditionCode { get; set; }
        [Column("CURRENT_BALANCE")]
        public int CurrentBalance { get; set; }
        [Column("AMOUNT_PAST_DUE")]
        public int AmountPastDue { get; set; }
        [Column("ORIGINAL_CHARGE_OFF_AMOUNT")]
        public int OriginalChargeOffAmount { get; set; }
        [Column("DATE_OF_ACCOUNT_INFORMATION", TypeName = "date")]
        public DateTime DateOfAccountInformation { get; set; }
        [Column("DATE_FIRST_DELINQUENCY", TypeName = "date")]
        public DateTime? DateFirstDelinquency { get; set; }
        [Column("DATE_CLOSED", TypeName = "date")]
        public DateTime? DateClosed { get; set; }
        [Column("DATE_LAST_PAYMENT", TypeName = "date")]
        public DateTime? DateLastPayment { get; set; }
        [Required]
        [Column("INTEREST_TYPE_INDICATOR")]
        [StringLength(2)]
        public string InterestTypeIndicator { get; set; }
        [Required]
        [Column("SURNAME")]
        [StringLength(25)]
        public string Surname { get; set; }
        [Required]
        [Column("FIRST_NAME")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [Column("MIDDLE_NAME")]
        [StringLength(25)]
        public string MiddleName { get; set; }
        [Column("GENERATION_CODE")]
        [StringLength(1)]
        public string GenerationCode { get; set; }
        [Required]
        [Column("SOCIAL_SECURITY_NUMBER")]
        [StringLength(9)]
        public string SocialSecurityNumber { get; set; }
        [Column("DATE_OF_BIRTH", TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column("TELEPHONE_NUMBER")]
        [StringLength(10)]
        public string TelephoneNumber { get; set; }
        [Required]
        [Column("ECOA_CODE")]
        [StringLength(1)]
        public string EcoaCode { get; set; }
        [Column("CONSUMER_INFORMATION_INDICATOR")]
        [StringLength(2)]
        public string ConsumerInformationIndicator { get; set; }
        [Column("COUNTRY_CODE")]
        [StringLength(2)]
        public string CountryCode { get; set; }
        [Required]
        [Column("ADDRESS_LINE_1")]
        [StringLength(32)]
        public string AddressLine1 { get; set; }
        [Required]
        [Column("ADDRESS_LINE_2")]
        [StringLength(32)]
        public string AddressLine2 { get; set; }
        [Required]
        [Column("CITY")]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [Column("STATE")]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [Column("POSTAL_CODE")]
        [StringLength(9)]
        public string PostalCode { get; set; }
        [Required]
        [Column("ADDRESS_INDICATOR")]
        [StringLength(1)]
        public string AddressIndicator { get; set; }
        [Required]
        [Column("RESIDENCE_CODE")]
        [StringLength(1)]
        public string ResidenceCode { get; set; }
    }
}
