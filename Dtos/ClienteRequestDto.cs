using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba1.Dtos
{
    public class ClienteRequestDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Telefono { get; set; }
    }
}
