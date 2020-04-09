using System.ComponentModel.DataAnnotations;

namespace FrontTestImaginamos.Models
{
    public class Login
    {
        [Required]
        public string Usuario { get; set; }
        
        [Required]
        public string Contrasena { get; set; }
    }
}