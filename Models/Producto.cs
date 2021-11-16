  using System;
using System.Collections.Generic;

#nullable disable

namespace Prueba1.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double? Precio { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
