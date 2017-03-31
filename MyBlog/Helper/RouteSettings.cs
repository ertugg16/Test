using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Helper
{
    public static class RouteSettings
    {
        public static string ClearnUrl(this HtmlHelper htmlHelper, string title)
        {
            string cleanTitle = title.ToLower().Replace(" ", "-");
            cleanTitle = Regex.Replace(cleanTitle, @"[^a-zA-Z0-9\/_|+ -]", "");
            return cleanTitle;
        }

    }
}