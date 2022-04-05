using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parque_aventura
{
    class Control
    {
        private List<Usuario> usuarios;
        private int contador;
        private Atraccion atraccion;

        //Accesores

        public int Contador { get => contador; private set => contador = value; }
        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        internal Atraccion Atraccion { get => atraccion; set => atraccion = value; }

        //Constructor
        public Control()
        {

        }
    }
}
