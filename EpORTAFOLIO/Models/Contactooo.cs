using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpORTAFOLIO.Models
{
    public class Contactooo
    {
        public string FullName { get; set; }
        [Required(ErrorMessage = "The Email field is mandatory.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid email address.")]

        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Mensaje { get; set; }

    }
}

