//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webEjemplo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbFacturaDet
    {
        public int idFactura { get; set; }
        public int codProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioVenta { get; set; }
        public decimal subtotal { get; set; }
    
        public virtual tbFactura tbFactura { get; set; }
        public virtual tbProducto tbProducto { get; set; }
    }
}
