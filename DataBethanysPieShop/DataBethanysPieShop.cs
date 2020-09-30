using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EdgarAparicio.BethanysPieShop.Business.Entity;

namespace EdgarAparicio.BethanysPieShop.Data
{
    public class DataBethanysPieShop : IDataBetahysPieShop
    {
        private readonly DbContextBethanysPieShop db;

        public DataBethanysPieShop(DbContextBethanysPieShop db)
        {
            this.db = db;
        }

        public Pie ObtenerPiePorId(int idPie)
        {
            return db.Pies.FirstOrDefault(p => p.Id == idPie);
            
        }

        public IEnumerable<Pie> ObtenerPies()
        {
            return db.Pies;
        }
    }
}
