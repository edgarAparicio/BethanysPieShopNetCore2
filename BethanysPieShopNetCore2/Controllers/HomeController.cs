using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            ViewBag.Tittle = "Pie Vision General";
            var pies = _pieRepository.ObtenerPies().OrderBy(p => p.Nombre);
            return View();
        }
    }
}
