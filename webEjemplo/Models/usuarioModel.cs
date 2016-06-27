using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Permite realizar validaciones a nuestra clase a nivel de models
using System.ComponentModel.DataAnnotations;

namespace webEjemplo.Models
{
    public class RegistrarUsuario
    {
        [Required]
        [StringLength(5)]
        [Display(Name ="Codigo del Cliente")]
        public int idCliente { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre Completo")]
        public string nomCliente { get; set; }

        [Required]
        public string cedCliente { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string direCliente { get; set; }
        [Required]
        public string password { get; set; }
    }
    public class LogeoUsuario
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

    }
    public class CambiarContraseña
    {
        [Required]
        public string password { get; set; }
    }
}
