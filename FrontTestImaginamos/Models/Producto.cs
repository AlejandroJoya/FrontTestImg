using System.ComponentModel.DataAnnotations;

namespace FrontTestImaginamos.Models
{
    public class Producto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Ingrese precio")]        
        [Range(0, int.MaxValue, ErrorMessage = "Se permite un número hasta 10 dígitos")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Ingrese cantidad")]        
        [Range(0, int.MaxValue, ErrorMessage = "Se permite un número hasta 7 dígitos")]
        public int Cantidad { get; set; }

        [Display(Name = "Nombre de producto")]
        [Required(ErrorMessage = "Ingrese nombre de producto")]
        [StringLength(50, ErrorMessage = "El nombre no debe superar los 50 caracteres")]
        public string NombreProducto { get; set; }
    }
}