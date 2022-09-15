using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using StimulSoft.Sample.Models;

namespace StimulSoft.Sample.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly MyAppDbContext _context;
		public HomeController(ILogger<HomeController> logger, MyAppDbContext context)
		{
			//StiLicense.Key="6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHkcgIvwL0jnpsDqRpWg5FI5kt2G7A0tYIcUygBh1sPs7uPvgjp0GgDowCB/F6myz180QOXN+hAWpeqWhPokj7sFSjITHge+0Hvjw4vKQPmlfDn/OWCMfhCPY4cZMTeUW6cW2VSK+480C7TeIrX/O/tLgGrgklP1P/7MdEkP/gQjQIwyRizsmj17wLkWfRzMal1duePiYgMsYr8GE9AdT2Mz6RPH+SCwPKHdjCq5PI/k4SrswBNYyd60U3YHOve2dNPfteBnaTnzwpyfuKQSyJrPuccoqDVxIUWSF8GCXtQa2nf7qqvv7A9L4L2LSU3JS31y3NU4ykT1r2gg8lkLmXQlauRyq3SR3zhTCvr1gsuM8a/85YPA2KCT4T2X14/Sj6Z3uo9x8lFQPOsW3fk1us4HDqN54uz7DOynURHiLJ5Twy7m2SzZhgg7QKO07CZgff70N6ID1D/h2G8pjVhsUO5qkWEkdr2kj8ygbUq5OZcMYTuQXkt1+sVOet7/cmQGdjsxperXlhn/96fbzPPn/q4Q";
			//StiLicense.LoadFromFile("license.key");
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			var model = _context.Vendors.ToList();
			return View(model);
		}

		public IActionResult ShowVendor()
		{
			
			return View();
		}
		
		public IActionResult VendorReport(int id)
		{
			var vendorId = new SqlParameter("@Id", id);
			StiReport report = new StiReport();
			report.Load("wwwroot/Report/Report2.mrt");

			//This model will initialize by EF Core
			//var model = _context.Vendors.FirstOrDefault(f => f.Id == id);

			//This model will initialize by a stored procedure that get a parameter as ID
			var model = _context.Vendors.FromSqlRaw("exec VendorSP @Id", vendorId).ToList();
			report.RegData("vr", model);
			return StiNetCoreViewer.GetReportResult(this, report);
		}

		public IActionResult ViewEvent()
		{
			return StiNetCoreViewer.ViewerEventResult(this);
		}
	}
}