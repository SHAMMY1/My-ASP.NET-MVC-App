using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPTC.Web.Infrastructure.Helpers
{
	public static class HtmlExtension
	{
		public static MvcHtmlString Submit(this HtmlHelper helper, object htmlAttributes = null)
		{
			var input = new TagBuilder("input");
			var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;
			input.MergeAttributes(attributes);
			input.Attributes.Add("type", "submit");
			return new MvcHtmlString(input.ToString());
		}
	}
}