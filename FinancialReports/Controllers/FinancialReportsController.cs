using FinancialReports.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinancialReports.Models;

namespace FinancialReports.Controllers
{
    public class FinancialReportsController : Controller
    {
        //set up global variables
        private FinancialContext db = new FinancialContext();
        int iCount = 0;
        int iCount2 = 0;

        //GET: FinancialReports
        public ActionResult Index()
        {
            //Create SelectedList items (for our drop down list) for types of reports
            List<SelectListItem> reports = new List<SelectListItem>();
            reports.Add(new SelectListItem { Text = "Select", Value = "Value " + iCount });
            iCount++;

            foreach (var item in db.ReportTypes)
            {
                reports.Add(new SelectListItem { Text = item.Description, Value = "Value " + iCount });
                iCount++;
            }

            //Create SelectedList items (for our drop down list) for types of payment methods
            List<SelectListItem> paymentType = new List<SelectListItem>();

            paymentType.Add(new SelectListItem { Text = "Select", Value = "Value " + iCount2 });
            iCount2++;

            paymentType.Add(new SelectListItem { Text = "All", Value = "Value " + iCount2 });
            iCount2++;

            foreach (var item in db.PaymentMethods)
            {
                paymentType.Add(new SelectListItem { Text = item.PaymentType, Value = "Value " + iCount2 });
                iCount2++;
            }

            ViewBag.Reports = reports;
            ViewBag.PaymentMethods = paymentType;
            return View();
        }
    }
}