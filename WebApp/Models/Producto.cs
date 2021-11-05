using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public string name { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public string description { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public string gender { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public int price { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public int stock { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public string image { get; set; }

    }
}

