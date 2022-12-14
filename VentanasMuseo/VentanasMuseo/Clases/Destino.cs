using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager {
    class Destino {
        private int idDestino;

        public int IdDestino {
            get { return idDestino; }
            set { idDestino = value; }
        }
        private string nombreDestino;

        public string NombreDestino {
            get { return nombreDestino; }
            set { nombreDestino = value; }
        }

        public string toStringDestino () {
            return nombreDestino;
        }
    }
}