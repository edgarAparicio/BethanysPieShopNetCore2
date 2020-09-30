using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopNetCore2.ViewModels;
using EdgarAparicio.BethanysPieShop.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShopNetCore2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataBetahysPieShop _pieRepository;

        public HomeController(IDataBetahysPieShop pieRepository)
        {
            _pieRepository = pieRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //ViewBag.Title = "Pie Vision General";
            //var pies = _pieRepository.ObtenerPies().OrderBy(p => p.Nombre);
            //return View(pies);


            var homeViewModels = new HomeViewModels()
            {
                Titulo = "Bienvenido a Bethanys Pie Shop",
                ListaPies = _pieRepository.ObtenerPies().OrderBy(p => p.Nombre).ToList()
            };
            return View(homeViewModels);

        }

        public ActionResult Detalle(int id)
        {
            var pie = _pieRepository.ObtenerPiePorId(id);
            if(pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }
    }
}
