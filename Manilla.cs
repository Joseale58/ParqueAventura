using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parque_aventura
{
    class Manilla
    {
        public enum tipo_plan {bajo_elagua, tec, jurassic};

        private double saldo;
        private string id;
        private int contador_mecanicas;
        private int contador_virtual;
        private int contador_acuaticas;
        private tipo_plan plan; 

        public double Saldo { get => saldo; set => saldo = value; }
        public string Id { get => id; set => id = value; }
        public int Contador_mecanicas { get => contador_mecanicas; set => contador_mecanicas = value; }
        public int Contador_virtual { get => contador_virtual; set => contador_virtual = value; }
        public int Contador_acuaticas { get => contador_acuaticas; set => contador_acuaticas = value; }
        internal tipo_plan Plan { get => plan; set => plan = value; }
    }
}
