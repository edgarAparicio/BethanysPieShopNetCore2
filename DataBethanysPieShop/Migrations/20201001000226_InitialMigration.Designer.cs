﻿// <auto-generated />
using EdgarAparicio.BethanysPieShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EdgarAparicio.BethanysPieShop.Data.Migrations
{
    [DbContext(typeof(DbContextBethanysPieShop))]
    [Migration("20201001000226_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EdgarAparicio.BethanysPieShop.Business.Entity.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Contacto");

                    b.Property<string>("Email");

                    b.Property<string>("Mensaje");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("EdgarAparicio.BethanysPieShop.Business.Entity.Pie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionCorta");

                    b.Property<string>("DescripcionLarga");

                    b.Property<string>("ImagenThumbnaiUrl");

                    b.Property<string>("ImagenUrl");

                    b.Property<string>("Nombre");

                    b.Property<bool>("PastelSemana");

                    b.Property<decimal>("Precio");

                    b.HasKey("Id");

                    b.ToTable("Pies");
                });
#pragma warning restore 612, 618
        }
    }
}