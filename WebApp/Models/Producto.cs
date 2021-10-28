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
        public string name { get; set; }
        public string description { get; set; }
        public string gender { get; set; }
        public int price { get; set; }
        public int stock { get; set; }  
    }
}

