using FinancialReports.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinancialReports.DAL
{
    public class FinancialContext : DbContext
    {

        public FinancialContext() : base("FinancialContext")
        {

        }
        //models for the different forms that we want to create
        public DbSet<Audited> Auditeds { get; set; }
        public DbSet<Gross> Grosss { get; set; }
        public DbSet<Net> Nets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<ReportGenerated> ReportGenerateds { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }

    }
}