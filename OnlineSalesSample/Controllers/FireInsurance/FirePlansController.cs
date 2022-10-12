using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineSalesSample.Controllers.FireInsurance
{
    public class FirePlansController : BaseController
    {
        // GET: Fire
        public ActionResult Index()
        {
            var currentSeller = CurrentSeller;
            return View();
        }
    }
}