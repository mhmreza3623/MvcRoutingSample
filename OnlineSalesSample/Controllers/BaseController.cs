using System.Web.Mvc;
using OnlineSalesSample.Helpers;

namespace OnlineSalesSample.Controllers.FireInsurance
{
    [SellerChecker]
    public class BaseController : Controller
    {
        public int CurrentSeller { get; set; }
    }
}