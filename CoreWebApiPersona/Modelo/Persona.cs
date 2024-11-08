using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiPersona.Modelo
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string fecha { get; set; }
    }
}
