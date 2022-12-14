using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager {
    class Empleado {
        private int idEmpleado;
        private string nombre;
        private string apellido;
        public Empleado (int idEmpleado, string nombre, string apellido) {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Empleado () { }

        public string toStringEmpleado () {
            return "Guia: " + nombre + " " + apellido;
        }
    }

}