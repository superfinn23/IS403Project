using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReports.Models
{
    [Table("PaymentMethod")]
    public class PaymentMethod
    {
        
        public int PaymentID { get; set; }

        [Key]
        public string PaymentType { get; set; }
    }
}