using System.ComponentModel.DataAnnotations;

namespace FrontTestImaginamos.Models
{
    public class Registro
    {
        [Required(ErrorMessage = "Ingrese su nombre")]
        [StringLength(50, ErrorMessage = "El nombre no debe superar los 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese su documento")]
        [StringLength(50, ErrorMessage = "El documento no debe superar los 12 caracteres")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "Ingrese su email")]
        [StringLength(50, ErrorMessage = "El email no debe superar los 12 caracteres")]
        [EmailAddress(ErrorMessage = "El email no es válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese su contraseña")]
        [DataType(DataType.Password)]
        [StringLength(12, ErrorMessage = "La contraseña no debe superar los 12 caracteres")]
        public string Contrasena { get; set; }

        [Display(Name = "Confirme contraseña")]
        [Required(ErrorMessage = "Confirme su contraseña")]
        [DataType(DataType.Password)]
        public string ContrasenaConfirmada { get; set; }

        [Display(Name = "Nombre de usuario")]
        [Required(ErrorMessage = "Ingrese su nombre de usuario")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no debe superar los 50 caracteres")]
        public string NombreUsuario { get; set; }
    }
}