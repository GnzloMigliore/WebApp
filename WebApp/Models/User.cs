using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public int role { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public string first_name { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public string last_name { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public string gender { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        [EmailAddress(ErrorMessage = "El correo electronico no es una direccion valida")]   
        public string email { get; set; }
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        public int phone { get; set; }
       
        [Required(ErrorMessage = "El campo debe ser obligatorio")]
        [StringLength(100,ErrorMessage ="El numero de caracteres de {0} debe ser al menos {2}",MinimumLength =8)]

        public string password { get; set; }
    }
}
