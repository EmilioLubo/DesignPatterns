using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
