using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Excepcion : Exception
    {
        private const string _mensaje_predeterminado = "Ha ocurrido algo, por favor contacte con el soporte técnico.";
        
        public Excepcion() : base(_mensaje_predeterminado)
        {
        }

        public Excepcion(string message) : base(message)
        {
        }

        public Excepcion(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
