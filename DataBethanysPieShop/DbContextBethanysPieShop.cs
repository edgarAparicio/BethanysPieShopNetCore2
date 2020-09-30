using EdgarAparicio.BethanysPieShop.Business.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.BethanysPieShop.Data
{
    public class DbContextBethanysPieShop : DbContext 
    {
        public DbContextBethanysPieShop(DbContextOptions<DbContextBethanysPieShop> opciones) : base(opciones)
        {

        }

        public DbSet<Pie> Pies { get; set; }
    }
}
