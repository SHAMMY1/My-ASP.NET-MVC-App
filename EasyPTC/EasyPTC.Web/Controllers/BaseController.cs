namespace EasyPTC.Web.Controllers
{
	using EasyPTC.Web.Models;
using System.Web.Mvc;

    public abstract class BaseController : Controller
    {
		protected ApplicationUser CurrentUser { get; set; }

		[NonAction]
		public void SystemSettings()
		{
		}
    }
}