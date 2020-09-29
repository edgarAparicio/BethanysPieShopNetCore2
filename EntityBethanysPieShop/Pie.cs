using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.BethanysPieShop.Business.Entity
{
     public class Pie
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string DescripcionCorta { get; set; }

        public string DescripcionLarga { get; set; }

        public decimal Precio { get; set; }

        public string ImagenUrl { get; set; }

        public string ImagenThumbnaiUrl { get; set; }

        public bool PastelSemana { get; set; }
    }
}
