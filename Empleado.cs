using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parque_aventura
{
    class Empleado
    {
        private string nombre;
        private string cedula;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public Empleado(string nombre, string cedula)
        {
            this.nombre = nombre;
            this.cedula = cedula;
        }
    }
}
