using System.ComponentModel.DataAnnotations;
namespace MVCparcial.Models
{
    public enum TipoUnidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public enum TipoEstado
    {
        Activo, 
        Inactivo
    }
    public class Product
    {
        [Key]
        public int ProdctoId { get; set; }  //prop+tab tab
        [Required]
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        [Required]
        public TipoUnidad Unidad { get; set; }
        public TipoEstado Estado { get; set; }

    }
}