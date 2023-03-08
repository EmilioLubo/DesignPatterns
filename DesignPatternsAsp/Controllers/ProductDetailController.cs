using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            LocalEarnFactory localEarnFactory = new(0.20m);

            ForeignEarnFactory foreignEarnFactory = new(0.30m, 20);

            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
