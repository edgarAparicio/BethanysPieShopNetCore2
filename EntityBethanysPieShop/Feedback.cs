using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EdgarAparicio.BethanysPieShop.Business.Entity
{
    public class Feedback
    {
        [BindNever]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Tu Nombre es requerido")]
        public string Nombre { get; set; } 

        [Required]
        [StringLength(100, ErrorMessage ="Tu Email es requerido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage ="Tu mesnaje es requerido")]
        public string Mensaje { get; set; }

        public bool Contacto { get; set; }
    }
}
