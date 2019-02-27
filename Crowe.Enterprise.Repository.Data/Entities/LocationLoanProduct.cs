using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.Enterprise.Repository.Data.Entities
{
    public partial class LocationLoanProduct
    {
        [Column("LOCATION_LOAN_PRODUCT_KEY")]
        public int LocationLoanProductKey { get; set; }
        [Column("LOCATION_KEY")]
        public short LocationKey { get; set; }
        [Column("LOAN_PRODUCT_KEY")]
        public int LoanProductKey { get; set; }
        [Required]
        [Column("APPROVAL_INCOME_TYPE")]
        [StringLength(1)]
        public string ApprovalIncomeType { get; set; }

        [ForeignKey("LocationKey")]
        [InverseProperty("LocationLoanProduct")]
        public virtual Location LocationKeyNavigation { get; set; }
    }
}
