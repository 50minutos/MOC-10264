using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Helpers
{
    public static class HtmlHelperExtension
    {
        public static MvcHtmlString MyActionLink(this HtmlHelper htmlHelper, String text, String action, String controller)
        {
            var a = new TagBuilder("a");

            var c = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            a.SetInnerText(text);

            a.Attributes.Add("href", String.Format("/{0}/{1}", controller, action));

            if (c.Equals(controller, StringComparison.CurrentCultureIgnoreCase))
            {
                a.Attributes.Add("class", "selected");
            }

            return MvcHtmlString.Create(a.ToString());
        }
    }
}