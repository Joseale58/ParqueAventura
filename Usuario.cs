using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parque_aventura
{
    class Usuario
    {
        private string nombre;
        private string cedula;
        private Manilla manilla;
        private byte edad;
        private int estatura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public byte Edad { get => edad; set => edad = value; }
        public int Estatura { get => estatura; set => estatura = value; }
        internal Manilla Manilla { get => manilla; set => manilla = value; }

        public Usuario(string nombre, string cedula, byte edad, int estatura)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.edad = edad;
            this.estatura = estatura;
        }
    }
}
