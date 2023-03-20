using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using Tools.Generator;

namespace DesignPatternsAsp.Controllers
{
    public class GeneratorController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private Generator _generator;

        public GeneratorController(IUnitOfWork unitOfWork, Generator generator)
        {
            _unitOfWork = unitOfWork;
            _generator = generator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int opFile)
        {
            try
            {
                var beer = _unitOfWork.Beers.Get();
                List<string> content = beer.Select(x => x.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var docGen = new DocGenerator(_generator);

                if (opFile == 1)
                    docGen.CreateSimpleJsonGenerator(content, path);
                else
                    docGen.CreateSimplePipeGenerator(content, path);

                var doc = _generator.GetDocument();
                doc.Save();

                return Json("Archivo Generado");

            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
