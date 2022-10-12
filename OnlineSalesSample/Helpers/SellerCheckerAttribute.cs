using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineSalesSample.Controllers.FireInsurance;

namespace OnlineSalesSample.Helpers
{
    public class SellerCheckerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var id = filterContext.RouteData.GetRequiredString("id");
            ((BaseController)filterContext.Controller).CurrentSeller = int.Parse(id);

            var absolutePath = filterContext.HttpContext.Request.Url.AbsolutePath;
            var absoluteUri = filterContext.HttpContext.Request.Url.AbsoluteUri;
            var host = filterContext.HttpContext.Request.Url.Host;
            var LocalPath = filterContext.HttpContext.Request.Url.LocalPath;
            var PathAndQuery = filterContext.HttpContext.Request.Url.PathAndQuery;


            base.OnActionExecuting(filterContext);
        }
    }
}