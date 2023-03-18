using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;
using DesignPatternsAsp.Strategy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatternsAsp.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<BeerVM> beers = from d in _unitOfWork.Beers.Get()
                                        select new BeerVM
                                        {
                                            Id = d.BeerId,
                                            Name = d.Name,
                                            Style = d.Style,
                                        };

            return View("Index", beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();

            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerVM beerVM)
        {
            if (!ModelState.IsValid)
            {
                GetBrandsData();

                return View("Add", beerVM);
            }

            var context = beerVM.BrandId == null ?
                            new Context(new BeerWBrandStrategy()) :
                            new Context(new BeerStrategy());

            context.Add(beerVM, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region HELPERS

        private void GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }

        #endregion
    }
}
