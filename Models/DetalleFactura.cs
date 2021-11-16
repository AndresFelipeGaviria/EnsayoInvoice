using System;
using System.Collections.Generic;

#nullable disable

namespace Prueba1.Models
{
    public partial class DetalleFactura
    {
        public int Id { get; set; }
        public int? IdProducto { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
