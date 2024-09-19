using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Productos
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public double Precio_unitario { get; set; }
        public Categorias? Categoria { get; set; }
        public Estados? Estado { get; set; }
        public Proveedores? Proveedor { get; set; }
    }
}
