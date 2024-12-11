//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inventario_productos_crub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Inventarios = new HashSet<Inventario>();
        }

        [Display(Name = "#")]
        public int ProductoID { get; set; }

        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion del Producto")]
        public string Descripcion { get; set; }

        [Display(Name = "Precio del Producto")]
        public decimal Precio { get; set; }
        public int CategoriaID { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
