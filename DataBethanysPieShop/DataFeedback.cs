using System;
using System.Collections.Generic;
using System.Text;
using EdgarAparicio.BethanysPieShop.Business.Entity;

namespace EdgarAparicio.BethanysPieShop.Data
{
    public class DataFeedback : IDataFeedback
    {
        private readonly DbContextBethanysPieShop db;

        public DataFeedback(DbContextBethanysPieShop db)
        {
            this.db = db;
        }


        public void AgregarFeedback(Feedback feedback)
        {
            db.Feedbacks.Add(feedback);
            db.SaveChanges();
        }
    }
}
