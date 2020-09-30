using EdgarAparicio.BethanysPieShop.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopNetCore2.ViewModels
{
    public class HomeViewModels
    {
        public string Titulo { get; set; }

        public List<Pie> ListaPies { get; set; }

    }
}
