using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineSalesSample.Controllers.FireInsurance;

namespace OnlineSalesSample.Controllers.MobileInsurance
{
    public class MobilePlansController : BaseController
    {
        // GET: MobileInsurance
        public ActionResult Index()
        {
            var currentSeller = CurrentSeller;

            return View();
        }
    }
}