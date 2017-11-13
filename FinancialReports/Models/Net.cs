﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReports.Models
{
    [Table("Net")]
    public class Net
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int transactionID { get; set; }

        [ForeignKey("PaymentMethod")]
        public string PaymentType { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        public decimal TransactionTotal { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AssociatedOperatingCost { get; set; }
    }
}