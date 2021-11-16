using System;
using System.Collections.Generic;

#nullable disable

namespace Prueba1.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Telefono { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
