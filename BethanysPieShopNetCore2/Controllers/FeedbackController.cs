using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.BethanysPieShop.Business.Entity;
using EdgarAparicio.BethanysPieShop.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShopNetCore2.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        
        private readonly IDataFeedback db;

        public FeedbackController(IDataFeedback db)
        {
            this.db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                db.AgregarFeedback(feedback);
                return RedirectToAction("FeedbackCompleto");
            }
            return View(feedback);
        }

        public IActionResult FeedbackCompleto()
        {
            return View();
        }
    }
}
