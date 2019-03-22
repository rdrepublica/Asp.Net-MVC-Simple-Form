using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Form
    {
        [Required(ErrorMessage ="El campo es obligatorio")]
        public String Name { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public String Cedula { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [Range(15, 100, ErrorMessage = "La edad debe ser mayor a 15 y menor a 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public String Tel { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public String Gender { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public String Last { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public String CivilStatus { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public bool Hobbys { get; set; }
        public String HobbieDefinitivo { get; set; }

    }
}