using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReports.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int LoginID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public DateTime LoginDate { get; set; }
        public bool Authentication { get; set; }
    }
}