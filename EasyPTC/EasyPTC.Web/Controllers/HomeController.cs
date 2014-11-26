using EasyPTC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPTC.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.TelerikAcademiMSG = new List<string>()
				{
					"Welcome to ASP.NET!", "HI!"
				};

			ViewData["Pesho"] = "Gosho";
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult OurVision()
		{
			return View();
		}

		[HttpGet]

		public ActionResult Test()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Test(Person person)
		{

			return Content(person.Name + " " + person.Age);

		}
	}
}