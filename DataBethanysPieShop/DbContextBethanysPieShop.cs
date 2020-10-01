using EdgarAparicio.BethanysPieShop.Business.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.BethanysPieShop.Data
{
    //public class DbContextBethanysPieShop : DbContext  Se utiliza para una aplicacion normal 
    public class DbContextBethanysPieShop : IdentityDbContext<IdentityUser>   //Para hacer la autenticacion de usuario se debe heredar de IdentityDbContext<IdentityUser>
    {
        public DbContextBethanysPieShop(DbContextOptions<DbContextBethanysPieShop> opciones) : base(opciones)
        {

        }

        public DbSet<Pie> Pies { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
