using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager {
    class MotivoIngreso {
        private int idMotivoIngreso;

        public int IdMotivoingreso {
            get { return idMotivoIngreso; }
            set { idMotivoIngreso = value; }
        }
        private string motivo;

        public string Motivo {
            get { return motivo; }
            set { motivo = value; }
        }

        public MotivoIngreso (int idMotivoIngreso, string motivo) {
            this.idMotivoIngreso = idMotivoIngreso;
            this.motivo = motivo;
        }

        public MotivoIngreso () { }

        public string toString () {
            return motivo;
        }
    }
}