using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Talle
    {
        [Key]
        public int id { get; set; }
        public string talle { get; set; }
        public string ProductId { get; set; }

    }
}
