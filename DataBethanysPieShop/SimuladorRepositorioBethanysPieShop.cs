using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EdgarAparicio.BethanysPieShop.Business.Entity;

namespace EdgarAparicio.BethanysPieShop.Data
{
    public class SimuladorRepositorioBethanysPieShop : IDataBetahysPieShop
    {
        private List<Pie> _pies;

        public SimuladorRepositorioBethanysPieShop()
        {
            if (_pies == null)
            {
                InicializarPies();
            }
        }

        private void InicializarPies()
        {
            _pies = new List<Pie>
            {
                new Pie{ Id = 1, Nombre ="Apple Pie", Precio = 12.95M, DescripcionCorta="Apple Pie", DescripcionLarga="Apple Pie muy Rico", ImagenUrl= "imagen1", ImagenThumbnaiUrl="Imagenthmb1", PastelSemana= true},
                new Pie{ Id = 2, Nombre ="Mango Pie", Precio = 14.00M, DescripcionCorta="Mango Pie", DescripcionLarga="Mango Pie muy Rico", ImagenUrl= "imagen1", ImagenThumbnaiUrl="Imagenthmb1", PastelSemana= true},
                new Pie{ Id = 3, Nombre ="Sandia Pie", Precio = 36.95M, DescripcionCorta="Sandia Pie", DescripcionLarga="Sandia Pie muy Rico", ImagenUrl= "imagen1", ImagenThumbnaiUrl="Imagenthmb1", PastelSemana= true}
            };
        }

        Pie IDataBetahysPieShop.ObtenerPiePorId(int idPie)
        {
            return _pies.FirstOrDefault(p => p.Id == idPie);
        }

        IEnumerable<Pie> IDataBetahysPieShop.ObtenerPies()
        {
            return _pies;
        }
    }
}
