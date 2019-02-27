using Crowe.Enterprise.Repository.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Enterprise.Repository.Data
{
    public class ScoringViewerDataContext : DbContext, IScoringViewerDataContext
    {
        public ScoringViewerDataContext()
        {
        }

        public virtual DbSet<AgencyCertificate> AgencyCertificate { get; set; }
        public virtual DbSet<AgencyData> AgencyData { get; set; }
        public virtual DbSet<AgencyDataDeviceId> AgencyDataDeviceId { get; set; }
        public virtual DbSet<AgencyDetail> AgencyDetail { get; set; }
        public virtual DbSet<AgencyDetailAttribute> AgencyDetailAttribute { get; set; }
        public virtual DbSet<AgencyDetailXmlTemplateTransform> AgencyDetailXmlTemplateTransform { get; set; }
        public virtual DbSet<AgencyMaster> AgencyMaster { get; set; }
        public virtual DbSet<AgencyReport> AgencyReport { get; set; }
        public virtual DbSet<Claim> Claim { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<ConversionMatrixIndicator> ConversionMatrixIndicator { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DenialReason> DenialReason { get; set; }
        public virtual DbSet<DenialReasonType> DenialReasonType { get; set; }
        public virtual DbSet<ExcludedModelType> ExcludedModelType { get; set; }
        public virtual DbSet<ExpirableAccount> ExpirableAccount { get; set; }
        public virtual DbSet<ExpirableAccountProviderType> ExpirableAccountProviderType { get; set; }
        public virtual DbSet<LoanApplication> LoanApplication { get; set; }
        public virtual DbSet<LoanApplicationAddress> LoanApplicationAddress { get; set; }
        public virtual DbSet<LoanApplicationAffordSurvey> LoanApplicationAffordSurvey { get; set; }
        public virtual DbSet<LoanApplicationEmployer> LoanApplicationEmployer { get; set; }
        public virtual DbSet<LoanApplicationIdentification> LoanApplicationIdentification { get; set; }
        public virtual DbSet<LoanApplicationIncome> LoanApplicationIncome { get; set; }
        public virtual DbSet<LoanApplicationProduct> LoanApplicationProduct { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationLoanProduct> LocationLoanProduct { get; set; }
        public virtual DbSet<Metro2Format> Metro2Format { get; set; }
        public virtual DbSet<ModelGroup> ModelGroup { get; set; }
        public virtual DbSet<ModelGroupApplyToAllModel> ModelGroupApplyToAllModel { get; set; }
        public virtual DbSet<ModelGroupDetail> ModelGroupDetail { get; set; }
        public virtual DbSet<ModelGroupPrimaryModel> ModelGroupPrimaryModel { get; set; }
        public virtual DbSet<ModelType> ModelType { get; set; }
        public virtual DbSet<MultiScoreMatrix> MultiScoreMatrix { get; set; }
        public virtual DbSet<PasswordType> PasswordType { get; set; }
        public virtual DbSet<PendingReason> PendingReason { get; set; }
        public virtual DbSet<PointValue> PointValue { get; set; }
        public virtual DbSet<RuleConfig> RuleConfig { get; set; }
        public virtual DbSet<RuleExpression> RuleExpression { get; set; }
        public virtual DbSet<RuleExpressionEdit> RuleExpressionEdit { get; set; }
        public virtual DbSet<RuleGroup> RuleGroup { get; set; }
        public virtual DbSet<RuleHeader> RuleHeader { get; set; }
        public virtual DbSet<RuleHeaderDetail> RuleHeaderDetail { get; set; }
        public virtual DbSet<RuleHeaderEdit> RuleHeaderEdit { get; set; }
        public virtual DbSet<RuleHeaderType> RuleHeaderType { get; set; }
        public virtual DbSet<RuleParameter> RuleParameter { get; set; }
        public virtual DbSet<RuleParameterDetail> RuleParameterDetail { get; set; }
        public virtual DbSet<RuleParameterType> RuleParameterType { get; set; }
        public virtual DbSet<RuleResult> RuleResult { get; set; }
        public virtual DbSet<RuleResultEdit> RuleResultEdit { get; set; }
        public virtual DbSet<ScoreDenialReason> ScoreDenialReason { get; set; }
        public virtual DbSet<ScoreDetail> ScoreDetail { get; set; }
        public virtual DbSet<ScoreLoanMatrix> ScoreLoanMatrix { get; set; }
        public virtual DbSet<ScorePendingReason> ScorePendingReason { get; set; }
        public virtual DbSet<ScoreProductSummary> ScoreProductSummary { get; set; }
        public virtual DbSet<ScoreSummary> ScoreSummary { get; set; }
        public virtual DbSet<ScoreSummaryAgencyDataXref> ScoreSummaryAgencyDataXref { get; set; }
        public virtual DbSet<ScoringHealthCheck> ScoringHealthCheck { get; set; }
        public virtual DbSet<ScoringHealthCheckLog> ScoringHealthCheckLog { get; set; }
        public virtual DbSet<ScoringItemMaster> ScoringItemMaster { get; set; }
        public virtual DbSet<ScoringTestName> ScoringTestName { get; set; }
        public virtual DbSet<SecurityGroup> SecurityGroup { get; set; }
        public virtual DbSet<SecurityGroupClaim> SecurityGroupClaim { get; set; }
        public virtual DbSet<UserClaim> UserClaim { get; set; }
        public virtual DbSet<UserSecurityGroup> UserSecurityGroup { get; set; }
        public virtual DbSet<VendorLocationCredential> VendorLocationCredential { get; set; }
        public virtual DbSet<VendorMatrixToSpeedyMatrix> VendorMatrixToSpeedyMatrix { get; set; }
        public virtual DbSet<VendorReportBaseSegment> VendorReportBaseSegment { get; set; }
        public virtual DbSet<VendorReportConfig> VendorReportConfig { get; set; }
        public virtual DbSet<VendorReportConfigEdit> VendorReportConfigEdit { get; set; }
        public virtual DbSet<VendorReportLoan> VendorReportLoan { get; set; }
        public virtual DbSet<VendorReportLocation> VendorReportLocation { get; set; }
        public virtual DbSet<VendorReportLocationEdit> VendorReportLocationEdit { get; set; }
        public virtual DbSet<VendorReportProduct> VendorReportProduct { get; set; }
        public virtual DbSet<VendorReportProductEdit> VendorReportProductEdit { get; set; }
        public virtual DbSet<VendorReportRun> VendorReportRun { get; set; }

        // Unable to generate entity type for table 'dbo.UserPermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LoanApplicationExpense'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LoanApplicationExpenseDetail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Global'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ICTACDEV23;Database=CustomerScoring;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScoreSummary>().HasKey(k => k.ScoreSummaryKey);
            modelBuilder.Entity<AgencyData>().HasKey(k => k.AgencyDataKey);
            modelBuilder.Entity<Config>().HasKey(k => k.ConfigKey);
            modelBuilder.Entity<Country>().HasKey(k => k.CountryKey);
            modelBuilder.Entity<LoanApplication>().HasKey(k => k.LoanApplicationKey);
            modelBuilder.Entity<LoanApplicationAddress>().HasKey(k => k.LoanApplicationAddressKey);
            modelBuilder.Entity<LoanApplicationAffordSurvey>().HasKey(k => k.LoanApplicationAffordSurveyKey);
            modelBuilder.Entity<LocationLoanProduct>().HasKey(k => k.LoanProductKey);
            modelBuilder.Entity<ScorePendingReason>().HasKey(k => new { k.ScoreSummaryKey, k.PendingReasonKey });
            modelBuilder.Entity<ScoreSummaryAgencyDataXref>().HasKey(k => new { k.ScoreSummaryKey, k.AgencyDataKey });

        }

    }
}
