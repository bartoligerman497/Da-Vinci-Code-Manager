using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager {
    class TipoObra {
        private int idTipoDeObra;

        public int IdTipoObra {
            get { return idTipoDeObra; }
            set { idTipoDeObra = value; }
        }

        private string tipoDeObra;

        public string TipoDeObra {
            get { return tipoDeObra; }
            set { tipoDeObra = value; }
        }

        public string toString () {
            return tipoDeObra;

        }
    }
}