using EdgarAparicio.BethanysPieShop.Business.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.BethanysPieShop.Data
{
    public interface IDataFeedback
    {
        void AgregarFeedback(Feedback feedback);
    }
}
