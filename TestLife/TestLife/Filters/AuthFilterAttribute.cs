using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestLife.Filters
{
    public class AuthFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(AuthIgnoreAttribute), true).Any())
            {
                return;
            }

            HttpCookie login = null, sign = null;
            try
            {
                login = filterContext.HttpContext.Request.Cookies.Get("auth");
                sign = filterContext.HttpContext.Request.Cookies.Get("sign");
            }
            catch (Exception ex)
            {
                filterContext.HttpContext.Request.Cookies.Clear();
            }
            var session = filterContext.RequestContext.HttpContext.Session;

            if (null != login && null != login.Value && sign != null && null != sign.Value)
            {
                if (login.Value + "wrdasf" == sign.Value)
                {
                    if (session != null && session["user"] == null)
                    {
                        session["user"] = login.Value;
                       
                    }
                    return;
                }
            }
            else if (session != null && session["user"] != null)
            {
                return;
            }

            throw new Exception("Error");
        }
    }
}