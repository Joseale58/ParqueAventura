using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parque_aventura
{
    class Atraccion
    {
        private string codigo;
        private string nombre;
        private int lim_edad;
        private int lim_estatura;
        private string descripcion;
        private List<Empleado> empleados;

        public Atraccion(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Lim_edad { get => lim_edad; set => lim_edad = value; }
        public int Lim_estatura { get => lim_estatura; set => lim_estatura = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal List<Empleado> Empleados { get => empleados; set => empleados = value; }
    }
}
