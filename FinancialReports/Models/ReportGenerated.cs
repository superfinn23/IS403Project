using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReports.Models
{
    [Table("ReportGenerated")]
    public class ReportGenerated
    {
        [Key]
        public int GeneratedReportID { get; set; }

        [ForeignKey("ReportType")]
        public int ReportID { get; set; }
        public virtual ReportType ReportType { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public DateTime GeneratedDate { get; set; }
    }
}