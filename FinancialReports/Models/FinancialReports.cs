using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinancialReports.Models
{
    public class FinancialReports
    {
        public int TransactionID { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TransactionTotal { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AdjustedAmount { get; set; }
        public decimal AssociatedOperatingCost { get; set; }
        public decimal Calculation { get; set; }
    }
}