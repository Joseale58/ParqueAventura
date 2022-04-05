using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parque_aventura
{
    class Taquilla
    {
        private double dinero_acumulado;
        private List<Usuario> usuarios = new List<Usuario>();

        public double Dinero_acumulado { get => dinero_acumulado; set => dinero_acumulado = value; }
        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        public Taquilla()
        {
        }

    }
}
