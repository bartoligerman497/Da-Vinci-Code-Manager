using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager.Clases {
    class Guia {
        private int idGuia;
        private Empleado empleado;

        public Guia (int idGuia, Empleado empleado) {
            this.idGuia = idGuia;
            this.empleado = empleado;
        }

        public int IdGuia { get => idGuia; set => idGuia = value; }
        internal Empleado Empleado { get => empleado; set => empleado = value; }
    }
}