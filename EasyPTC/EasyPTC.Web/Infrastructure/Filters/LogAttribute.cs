using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPTC.Web.Infrastructure.Filters
{
	public class LogAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			//var db = this.Data.Logs.Add(new Log { Message = filterContext.HttpContext.Request.RawUrl });
			//db.SaveChanges();

			base.OnActionExecuted(filterContext);
		}

	}
}