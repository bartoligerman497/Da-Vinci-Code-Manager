using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager {
    internal class Artista {
        private int idArtista;
        private int idDomicilio;
        private string nombre;
        private string apellido;
        private string seudonimo;
        private DateTime fechaNacimiento;
        private DateTime fechaDefuncion;

        public int IdArtista {
            set { idArtista = value; }
            get { return idArtista; }
        }

        public int IdDomicilio {
            set { idDomicilio = value; }
            get { return idDomicilio; }
        }

        public string Nombre {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido {
            set { apellido = value; }
            get { return apellido; }
        }

        public string Seudonimo {
            set { seudonimo = value; }
            get { return seudonimo; }
        }

        public DateTime FechaNacimiento {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public DateTime FechaDefuncion {
            set { fechaDefuncion = value; }
            get { return fechaDefuncion; }
        }

        public Artista () { }

        public Artista (int idArtista, int idDomicilio, string nombre, string apellido, string seudonimo, DateTime fechaNacimiento, DateTime fechaDefuncion) {
            IdArtista = idArtista;
            this.idDomicilio = idDomicilio;
            Nombre = nombre;
            Apellido = apellido;
            Seudonimo = seudonimo;
            FechaNacimiento = fechaNacimiento;
            FechaDefuncion = fechaDefuncion;
        }

        public string toStringArtista () {
            return nombre + " " + apellido;
        }
    }
}