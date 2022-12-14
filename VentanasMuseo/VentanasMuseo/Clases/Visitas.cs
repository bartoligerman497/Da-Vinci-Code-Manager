using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager {
    internal class Visitas {
        private int idVisita;
        private string tipoVisita;
        private Boolean solicitudGuia;
        private int cantidadVisitantes;
        private double monto;
        private Empleado empleado;

        public int IdVisita {
            set { idVisita = value; }
            get { return idVisita; }
        }

        public int CantidadVisitantes {
            set { cantidadVisitantes = value; }
            get { return cantidadVisitantes; }
        }

        public double Monto {
            set { monto = value; }
            get { return monto; }
        }

        public Boolean SolicitudGuia {
            set { solicitudGuia = value; }
            get { return solicitudGuia; }
        }

        public string TipoVisita {
            set { tipoVisita = value; }
            get { return tipoVisita; }
        }

        internal Empleado Empleado { get => empleado; set => empleado = value; }

        public Visitas () { }

        public string SolicitudGuiaString () {
            string solicitudGuiaString = "Si";

            if (solicitudGuia == true) {
                return solicitudGuiaString;
            } else {
                solicitudGuiaString = "No";
                return solicitudGuiaString;
            }
        }

        public string toStringVisitas () {
            string string1 = "ID:" + idVisita + ", Cantidad Visitantes: " + cantidadVisitantes + ", Tipo Visita: " + tipoVisita +
                ", Monto: " + monto + ", Solicitud Guía:" + SolicitudGuiaString ();

            if (SolicitudGuia == true) {
                string1 += ", Guia:" + Empleado.Nombre + " " + Empleado.Apellido;
            }
            return string1;
        }

        /*private int idVisita;
         private int idExposiciones;
         private int idGuia;
         private int fecha;
         private int cantidadVisitantes;
         private double monto;
         private bool solicitudGuia;
         private string tipoVisita;
         private int ubicacion;
         private int idCobrador;
         private int horario;

         public int IdVisita {
             set { idVisita = value; }
             get { return idVisita; }
         }

         public int IdExposiciones {
             set { idExposiciones = value; }
             get { return idExposiciones; }
         }

         public int IdGuia {
             set { idGuia = value; }
             get { return idGuia; }
         }

         public int Fecha {
             set { fecha = value; }
             get { return fecha; }
         }

         public int CantidadVisitantes {
             set { cantidadVisitantes = value; }
             get { return cantidadVisitantes; }
         }

         public double Monto {
             set { monto = value; }
             get { return monto; }
         }

         public bool SolicitudGuia {
             set { solicitudGuia = value; }
             get { return solicitudGuia; }
         }

         public string TipoVisita {
             set { tipoVisita = value; }
             get { return tipoVisita; }
         }

         public int Ubicacion {
             set { ubicacion = value; }
             get { return ubicacion; }
         }

         public int IdCobrador {
             set { idCobrador = value; }
             get { return idCobrador; }
         }

         public int Horario {
             set { horario = value; }
             get { return horario; }
         }

         public Visitas () { }

         public Visitas (int idVisita, int idExposiciones, int idGuia, int fecha, int cantidadVisitantes, double monto, bool solicitudGuia, string tipoVisita, int ubicacion, int idCobrador, int horario) {
             IdVisita = idVisita;
             IdExposiciones = idExposiciones;
             IdGuia = idGuia;
             Fecha = fecha;
             CantidadVisitantes = cantidadVisitantes;
             Monto = monto;
             SolicitudGuia = solicitudGuia;
             TipoVisita = tipoVisita;
             Ubicacion = ubicacion;
             IdCobrador = idCobrador;
             Horario = horario;
         }

         public string toStringVisitas () {
             return idVisita + ", " + cantidadVisitantes + ", " + tipoVisita + ", " + horario;
         }*/
    }
}