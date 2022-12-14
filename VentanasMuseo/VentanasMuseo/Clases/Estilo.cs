using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager {
    class Estilo {
        private int idEstilo;
        private string descripcion;

        public Estilo (int idEstilo, string descripcion) {
            this.idEstilo = idEstilo;
            this.descripcion = descripcion;
        }

        public Estilo () { }

        public int IdEstilo { get => idEstilo; set => idEstilo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string toString () {
            return descripcion;
        }

    }
}