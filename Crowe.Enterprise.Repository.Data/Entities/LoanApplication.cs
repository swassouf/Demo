using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LoanApplication
    {
        public LoanApplication()
        {
            LoanApplicationAddress = new HashSet<LoanApplicationAddress>();
            LoanApplicationAffordSurvey = new HashSet<LoanApplicationAffordSurvey>();
            LoanApplicationEmployer = new HashSet<LoanApplicationEmployer>();
            LoanApplicationIdentification = new HashSet<LoanApplicationIdentification>();
            LoanApplicationIncome = new HashSet<LoanApplicationIncome>();
            LoanApplicationProduct = new HashSet<LoanApplicationProduct>();
            ScoreSummary = new HashSet<ScoreSummary>();
        }

        [Column("LOAN_APPLICATION_KEY")]
        public int LoanApplicationKey { get; set; }
        [Column("LENDER_KEY")]
        public byte LenderKey { get; set; }
        [Column("LOCATION")]
        public short Location { get; set; }
        [Column("CUSTOMER_KEY")]
        public int? CustomerKey { get; set; }
        [Column("VISITOR_KEY")]
        public int? VisitorKey { get; set; }
        [Column("LOAN_KEY")]
        public int? LoanKey { get; set; }
        [Required]
        [Column("FIRST_NAME")]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [Column("MID_NAME")]
        [StringLength(25)]
        public string MidName { get; set; }
        [Required]
        [Column("LAST_NAME")]
        [StringLength(25)]
        public string LastName { get; set; }
        [Column("HOME_PHONE")]
        [StringLength(12)]
        public string HomePhone { get; set; }
        [Column("WORK_PHONE")]
        [StringLength(12)]
        public string WorkPhone { get; set; }
        [Column("WORK_PHONE_EXT")]
        [StringLength(10)]
        public string WorkPhoneExt { get; set; }
        [Column("CELL_PHONE")]
        [StringLength(12)]
        public string CellPhone { get; set; }
        [Required]
        [Column("SSN")]
        [StringLength(9)]
        public string Ssn { get; set; }
        [Column("DIRECT_DEPOSIT")]
        public bool? DirectDeposit { get; set; }
        [Column("NET_INCOME", TypeName = "smallmoney")]
        public decimal? NetIncome { get; set; }
        [Column("PAY_CYCLE")]
        [StringLength(1)]
        public string PayCycle { get; set; }
        [Column("PAY_CYCLE_DAY")]
        public byte? PayCycleDay { get; set; }
        [Column("PAY_CYCLE_1ST")]
        public byte? PayCycle1st { get; set; }
        [Column("PAY_CYCLE_2ND")]
        public byte? PayCycle2nd { get; set; }
        [Column("BIWEEK_BASE", TypeName = "smalldatetime")]
        public DateTime? BiweekBase { get; set; }
        [Required]
        [Column("BANK_ROUTING_NUMBER")]
        [StringLength(9)]
        public string BankRoutingNumber { get; set; }
        [Required]
        [Column("BANK_ACCOUNT_NUMBER")]
        [StringLength(20)]
        public string BankAccountNumber { get; set; }
        [Column("REQ_CASH_AMT", TypeName = "smallmoney")]
        public decimal ReqCashAmt { get; set; }
        [Column("CCARD_EXP_MONTH")]
        public byte CcardExpMonth { get; set; }
        [Column("CCARD_EXP_YEAR")]
        public short CcardExpYear { get; set; }
        [Column("CCARD_IS_DEBIT")]
        public bool CcardIsDebit { get; set; }
        [Required]
        [Column("CCARD_NAME_ON_CARD")]
        [StringLength(50)]
        public string CcardNameOnCard { get; set; }
        [Required]
        [Column("LANGUAGE")]
        [StringLength(1)]
        public string Language { get; set; }
        [Column("STATUS")]
        public int? Status { get; set; }
        [Required]
        [Column("REASON_DENIED")]
        [StringLength(1000)]
        public string ReasonDenied { get; set; }
        [Column("NEXT_PAY_DATE", TypeName = "smalldatetime")]
        public DateTime? NextPayDate { get; set; }
        [Column("TELLER")]
        [StringLength(3)]
        public string Teller { get; set; }
        [Column("ID_NO")]
        [StringLength(25)]
        public string IdNo { get; set; }
        [Column("EMP_FULL_PART")]
        public byte? EmpFullPart { get; set; }
        [Column("EMP_SINCE", TypeName = "smalldatetime")]
        public DateTime? EmpSince { get; set; }
        [Column("WORK_NAME")]
        [StringLength(50)]
        public string WorkName { get; set; }
        [Column("WORK_POSITION")]
        [StringLength(60)]
        public string WorkPosition { get; set; }
        [Column("SPOUSE_FIRST_NAME")]
        [StringLength(50)]
        public string SpouseFirstName { get; set; }
        [Column("SPOUSE_MID_NAME")]
        [StringLength(50)]
        public string SpouseMidName { get; set; }
        [Column("SPOUSE_LAST_NAME")]
        [StringLength(50)]
        public string SpouseLastName { get; set; }
        [Column("SPOUSE_SSN")]
        [StringLength(9)]
        public string SpouseSsn { get; set; }
        [Column("SPOUSE_HOME_PHONE")]
        [StringLength(12)]
        public string SpouseHomePhone { get; set; }
        [Column("SPOUSE_CELL_PHONE")]
        [StringLength(12)]
        public string SpouseCellPhone { get; set; }
        [Column("SPOUSE_WORK_NAME")]
        [StringLength(50)]
        public string SpouseWorkName { get; set; }
        [Column("SPOUSE_WORK_PHONE")]
        [StringLength(12)]
        public string SpouseWorkPhone { get; set; }
        [Column("SPOUSE_WORK_PHONE_EXT")]
        [StringLength(10)]
        public string SpouseWorkPhoneExt { get; set; }
        [Column("GENDER")]
        [StringLength(1)]
        public string Gender { get; set; }
        [Column("BOUNCED")]
        public bool? Bounced { get; set; }
        [Column("HOW_REF_OBSOLETE")]
        [StringLength(1)]
        public string HowRefObsolete { get; set; }
        [Column("EMAIL")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("REF1_FIRST_NAME")]
        [StringLength(50)]
        public string Ref1FirstName { get; set; }
        [Column("REF1_LAST_NAME")]
        [StringLength(50)]
        public string Ref1LastName { get; set; }
        [Column("REF1_PHONE")]
        [StringLength(12)]
        public string Ref1Phone { get; set; }
        [Column("REF1_RELATIONSHIP")]
        [StringLength(1)]
        public string Ref1Relationship { get; set; }
        [Column("REF2_FIRST_NAME")]
        [StringLength(50)]
        public string Ref2FirstName { get; set; }
        [Column("REF2_LAST_NAME")]
        [StringLength(50)]
        public string Ref2LastName { get; set; }
        [Column("REF2_PHONE")]
        [StringLength(12)]
        public string Ref2Phone { get; set; }
        [Column("REF2_RELATIONSHIP")]
        [StringLength(1)]
        public string Ref2Relationship { get; set; }
        [Column("RI_BALANCE", TypeName = "smallmoney")]
        public decimal? RiBalance { get; set; }
        [Column("RI_FOLLOWUP", TypeName = "smalldatetime")]
        public DateTime? RiFollowup { get; set; }
        [Column("OWN_RENT_OTHER")]
        public byte? OwnRentOther { get; set; }
        [Column("RESIDENCE_SINCE", TypeName = "smalldatetime")]
        public DateTime? ResidenceSince { get; set; }
        [Column("LEGAL_NUMBER")]
        [StringLength(10)]
        public string LegalNumber { get; set; }
        [Column("COURTESY_CALL_NUM")]
        [StringLength(1)]
        public string CourtesyCallNum { get; set; }
        [Column("GROSS_INCOME", TypeName = "smallmoney")]
        public decimal? GrossIncome { get; set; }
        [Column("TYPE_OF_INCOME")]
        [StringLength(1)]
        public string TypeOfIncome { get; set; }
        [Column("ACTIVE_MILITARY")]
        public bool? ActiveMilitary { get; set; }
        [Column("MILITARY_MEMBER")]
        public bool? MilitaryMember { get; set; }
        [Column("MILITARY_ACTIVE_DUTY")]
        public bool? MilitaryActiveDuty { get; set; }
        [Column("MILITARY_COMBAT_DUTY")]
        public bool? MilitaryCombatDuty { get; set; }
        [Column("MILITARY_RESERVE_NOT_ACTIVE")]
        public bool? MilitaryReserveNotActive { get; set; }
        [Column("MILITARY_RESERVE_ACTIVE")]
        public bool? MilitaryReserveActive { get; set; }
        [Column("MONTHLY_HOUSING", TypeName = "smallmoney")]
        public decimal? MonthlyHousing { get; set; }
        [Column("INET_APPROVED")]
        public bool? InetApproved { get; set; }
        [Column("CC_BLOCK")]
        public bool? CcBlock { get; set; }
        [Column("SCORE_SUMMARY_KEY")]
        public int? ScoreSummaryKey { get; set; }
        [Column("DOB", TypeName = "smalldatetime")]
        public DateTime? Dob { get; set; }
        [Required]
        [Column("SOURCE_APP")]
        [StringLength(1)]
        public string SourceApp { get; set; }
        [Column("DATE_ENTERED", TypeName = "datetime")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Column("SOURCE_DB")]
        [StringLength(1)]
        public string SourceDb { get; set; }
        [Column("APPROVED_AMT", TypeName = "smallmoney")]
        public decimal? ApprovedAmt { get; set; }
        [Column("CC_COUNT")]
        public byte CcCount { get; set; }
        [Column("WEB_REFERRAL_METHOD_KEY_OBSOLETE")]
        public int WebReferralMethodKeyObsolete { get; set; }
        [Required]
        [Column("IP_ADDRESS")]
        [StringLength(15)]
        public string IpAddress { get; set; }
        [Column("FINAL_SCORE", TypeName = "decimal(18, 9)")]
        public decimal? FinalScore { get; set; }
        [Column("MODEL_USED")]
        public short? ModelUsed { get; set; }
        [Column("MARITAL_STATUS")]
        public byte MaritalStatus { get; set; }
        [Column("JOINT_LOAN")]
        public bool JointLoan { get; set; }
        [Column("BANK_DEPOSITS", TypeName = "smallmoney")]
        public decimal? BankDeposits { get; set; }
        [Column("REFERRAL_METHOD_KEY")]
        public short? ReferralMethodKey { get; set; }
        [Column("LOAN_TYPE")]
        [StringLength(1)]
        public string LoanType { get; set; }
        [Column("PRODUCT_TYPE")]
        [StringLength(1)]
        public string ProductType { get; set; }
        [Column("VEH_MAKE")]
        [StringLength(40)]
        public string VehMake { get; set; }
        [Column("VEH_MODEL")]
        [StringLength(100)]
        public string VehModel { get; set; }
        [Column("VEH_YEAR")]
        public short? VehYear { get; set; }
        [Column("VEH_VIN")]
        [StringLength(40)]
        public string VehVin { get; set; }
        [Column("VEH_LIEN_HOLDER_NAME")]
        [StringLength(30)]
        public string VehLienHolderName { get; set; }
        [Column("VEH_LIEN_BALANCE", TypeName = "smallmoney")]
        public decimal? VehLienBalance { get; set; }
        [Column("VEH_LEASED")]
        public bool? VehLeased { get; set; }
        [Column("ARBITRATION_OPT_IN")]
        public bool? ArbitrationOptIn { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int LoanAppPrimKey { get; set; }
        [Column("SELECTED_AMT", TypeName = "smallmoney")]
        public decimal? SelectedAmt { get; set; }
        [Column("FUNDING_TYPE")]
        [StringLength(1)]
        public string FundingType { get; set; }
        [Column("PAY_CYCLE_MONTH_INTERVAL")]
        [StringLength(1)]
        public string PayCycleMonthInterval { get; set; }
        [Column("CCARD_BRAND")]
        public byte? CcardBrand { get; set; }
        [Column("CCARD_TYPE")]
        public byte? CcardType { get; set; }
        [Column("PRIMARY_SCORE_DATE", TypeName = "datetime")]
        public DateTime? PrimaryScoreDate { get; set; }
        [Column("PAY_CYCLE_COUNT_DAYS_FROM_END_OF_MONTH")]
        public bool? PayCycleCountDaysFromEndOfMonth { get; set; }
        [Column("IS_EPDQ_ONLY")]
        public bool? IsEpdqOnly { get; set; }
        [Column("TITLE")]
        public int? Title { get; set; }
        [Column("DEPENDENTS")]
        public short? Dependents { get; set; }
        [Column("CANCEL_INSURANCE_REQUEST_DATE", TypeName = "date")]
        public DateTime? CancelInsuranceRequestDate { get; set; }
        [Column("CANCEL_INSURANCE_REQUEST_BY")]
        [StringLength(3)]
        public string CancelInsuranceRequestBy { get; set; }
        [Column("INITIAL_WEB_VISIT_CHANNEL")]
        public int InitialWebVisitChannel { get; set; }
        [Column("INITIAL_WEB_VISIT_SUB_CHANNEL")]
        public int InitialWebVisitSubChannel { get; set; }
        [Column("CAN_SELECT_NON_PRIME_PRODUCT")]
        public bool? CanSelectNonPrimeProduct { get; set; }
        [Column("EMAIL_STATEMENTS")]
        public bool? EmailStatements { get; set; }
        [Column("CARD_TOKEN")]
        public int? CardToken { get; set; }
        [Column("CARD_NUMBER_TOKEN")]
        public int? CardNumberToken { get; set; }
        [Column("BIN")]
        public int? Bin { get; set; }
        [Column("CARD_NUMBER_LAST_FOUR")]
        public short? CardNumberLastFour { get; set; }
        [Column("SUCCESSFUL_VISITOR_AUTHENTICATION_CODE_ATTEMPT_KEY")]
        public int? SuccessfulVisitorAuthenticationCodeAttemptKey { get; set; }

        [InverseProperty("LoanAppPrimKeyNavigation")]
        public virtual ICollection<LoanApplicationAddress> LoanApplicationAddress { get; set; }
        [InverseProperty("LoanAppPrimKeyNavigation")]
        public virtual ICollection<LoanApplicationAffordSurvey> LoanApplicationAffordSurvey { get; set; }
        [InverseProperty("LoanAppPrimKeyNavigation")]
        public virtual ICollection<LoanApplicationEmployer> LoanApplicationEmployer { get; set; }
        [InverseProperty("LoanAppPrimKeyNavigation")]
        public virtual ICollection<LoanApplicationIdentification> LoanApplicationIdentification { get; set; }
        [InverseProperty("LoanAppPrimKeyNavigation")]
        public virtual ICollection<LoanApplicationIncome> LoanApplicationIncome { get; set; }
        [InverseProperty("LoanAppPrimKeyNavigation")]
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProduct { get; set; }
        [InverseProperty("LoanAppPrimKeyNavigation")]
        public virtual ICollection<ScoreSummary> ScoreSummary { get; set; }
    }
}
