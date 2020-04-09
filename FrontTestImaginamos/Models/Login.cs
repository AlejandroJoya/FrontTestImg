using System.ComponentModel.DataAnnotations;

namespace FrontTestImaginamos.Models
{
    public class Login
    {
        public const string LOGIN_FALLIDO = "El usuario o la contraseña son incorrectos";

        [Required(ErrorMessage = "Ingrese su nombre de usuario")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no debe superar los 50 caracteres")]
        public string Usuario { get; set; }
        
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Ingrese su contraseña")]
        [DataType(DataType.Password)]
        [StringLength(12, ErrorMessage = "La contraseña no debe superar los 12 caracteres")]
        public string Contrasena { get; set; }
    }
}