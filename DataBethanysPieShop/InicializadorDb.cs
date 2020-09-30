using EdgarAparicio.BethanysPieShop.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdgarAparicio.BethanysPieShop.Data
{
    public static class InicializadorDb
    {
        public static void Seed(DbContextBethanysPieShop context)
        {
            if (!context.Pies.Any())
            {
                
                context.AddRange
                    (
                    new Pie { Nombre = "Manzana Pie", Precio = 12.95M, DescripcionCorta = "Apple Pie", DescripcionLarga = "Apple Pie muy Rico", ImagenUrl = "imagen1", ImagenThumbnaiUrl = "Imagenthmb1", PastelSemana = true },
                    new Pie { Nombre = "Pera Pie", Precio = 14.00M, DescripcionCorta = "Mango Pie", DescripcionLarga = "Mango Pie muy Rico", ImagenUrl = "imagen1", ImagenThumbnaiUrl = "Imagenthmb1", PastelSemana = true },
                    new Pie { Nombre = "Uva Pie", Precio = 36.95M, DescripcionCorta = "Sandia Pie", DescripcionLarga = "Sandia Pie muy Rico", ImagenUrl = "imagen1", ImagenThumbnaiUrl = "Imagenthmb1", PastelSemana = true }

                    );
                context.SaveChanges();

            }
        }
    }
}
