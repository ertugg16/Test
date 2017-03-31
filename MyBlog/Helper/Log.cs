using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Controllers;

namespace MyBlog.Helper
{
    public class Log:ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string a = filterContext.ActionDescriptor.ActionName;
            //Database e log atmak ıcın kullanılır.

        }
    }
}