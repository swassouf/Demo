using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LoanApplicationAddress
    {
        [Column("LOAN_APPLICATION_ADDRESS_KEY")]
        public int? LoanApplicationAddressKey { get; set; }
        [Column("PK_LOAN_APPLICATION_ADDRESS_KEY")]
        public int PkLoanApplicationAddressKey { get; set; }
        [Column("DATE_ENTERED", TypeName = "smalldatetime")]
        public DateTime? DateEntered { get; set; }
        [Column("TELLER")]
        [StringLength(3)]
        public string Teller { get; set; }
        [Column("LOAN_APPLICATION_KEY")]
        public int LoanApplicationKey { get; set; }
        [Column("ADDRESS_TYPE_CODE")]
        public byte? AddressTypeCode { get; set; }
        [Column("ADDRESS1")]
        [StringLength(100)]
        public string Address1 { get; set; }
        [Column("COUNTY")]
        [StringLength(25)]
        public string County { get; set; }
        [Column("COUNTRY")]
        [StringLength(3)]
        public string Country { get; set; }
        [Column("CITY")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("STATE")]
        [StringLength(2)]
        public string State { get; set; }
        [Column("ZIPCODE")]
        [StringLength(10)]
        public string Zipcode { get; set; }
        [Column("FROM_DATE", TypeName = "date")]
        public DateTime? FromDate { get; set; }
        [Column("TO_DATE", TypeName = "date")]
        public DateTime? ToDate { get; set; }
        [Column("ADDRESS_FORMAT")]
        [StringLength(3)]
        public string AddressFormat { get; set; }
        [Column("ADDR_STREET")]
        [StringLength(40)]
        public string AddrStreet { get; set; }
        [Column("FLAT_NUM")]
        [StringLength(50)]
        public string FlatNum { get; set; }
        [Column("BUILDING_NUM")]
        [StringLength(10)]
        public string BuildingNum { get; set; }
        [Column("BUILDING_NAME")]
        [StringLength(40)]
        public string BuildingName { get; set; }
        [Column("ADDRESS_CSZ")]
        [StringLength(500)]
        public string AddressCsz { get; set; }
        [Column("ADDRESS_LINE_3")]
        [StringLength(500)]
        public string AddressLine3 { get; set; }
        [Column("ADDR_NUM")]
        [StringLength(10)]
        public string AddrNum { get; set; }
        [Column("ADDR_PRE_DIR")]
        [StringLength(2)]
        public string AddrPreDir { get; set; }
        [Column("ADDR_SUFFIX")]
        [StringLength(10)]
        public string AddrSuffix { get; set; }
        [Column("ADDR_POST_DIR")]
        [StringLength(2)]
        public string AddrPostDir { get; set; }
        [Column("ADDR_SUITE")]
        [StringLength(10)]
        public string AddrSuite { get; set; }
        [Column("ADDR_SUITE_NUM")]
        [StringLength(15)]
        public string AddrSuiteNum { get; set; }
        [Column("ADDRESS_LINE")]
        [StringLength(500)]
        public string AddressLine { get; set; }
        [Column("ADDRESS_LINE_1")]
        [StringLength(500)]
        public string AddressLine1 { get; set; }
        [Column("ADDRESS_LINE_2")]
        [StringLength(500)]
        public string AddressLine2 { get; set; }
        [Column("LOAN_APP_PRIM_KEY")]
        public int? LoanAppPrimKey { get; set; }

        [ForeignKey("LoanAppPrimKey")]
        [InverseProperty("LoanApplicationAddress")]
        public virtual LoanApplication LoanAppPrimKeyNavigation { get; set; }
    }
}
