using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_pilas_colas
{
    class Persona
    {
        public string nombre { set; get; }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}", nombre);
        }
    }
}
