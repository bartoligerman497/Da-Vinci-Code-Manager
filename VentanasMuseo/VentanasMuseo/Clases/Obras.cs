using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Vinci_Code_Manager
{
    internal class Obras
    {
        private int idObra;
        private int idCompra;
        private int idVenta;
        private Artista artista;
        private int idDonacion;
        private int idDepositoYMantenimiento;
        private string nombreObra;
        private string descripcion;
        private Estilo estilo;
        private TipoObra tipoObra;
        private DateTime fechaCreacion;
        private DateTime fechaRegistracion;
        private MotivoIngreso motivoIngreso;
        private string encargadoRegistro;
        private int dimensionAncho;
        private int dimensionAlto;
        private Destino destino;
        private double valuacion;

        public Obras(int idObra, int idCompra, int idVenta, Artista artista, int idDonacion, int idDepositoYMantenimiento, string nombreObra, string descripcion, Estilo estilo, TipoObra tipoObra, DateTime fechaCreacion, DateTime fechaRegistracion, MotivoIngreso motivoIngreso, string encargadoRegistro, int dimensionAncho, int dimensionAlto, Destino destino, double valuacion)
        {
            this.IdObra = idObra;
            this.IdCompra = idCompra;
            this.IdVenta = idVenta;
            this.Artista = artista;
            this.IdDonacion = idDonacion;
            this.IdDepositoYMantenimiento = idDepositoYMantenimiento;
            this.NombreObra = nombreObra;
            this.Descripcion = descripcion;
            this.Estilo = estilo;
            this.TipoObra = tipoObra;
            this.FechaCreacion = fechaCreacion;
            this.FechaRegistracion = fechaRegistracion;
            this.MotivoIngreso = motivoIngreso;
            this.EncargadoRegistro = encargadoRegistro;
            this.DimensionAncho = dimensionAncho;
            this.DimensionAlto = dimensionAlto;
            this.Destino = destino;
            this.Valuacion = valuacion;
        }

        public Obras()
        {
        }

        public int IdObra { get => idObra; set => idObra = value; }
        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdDonacion { get => idDonacion; set => idDonacion = value; }
        public int IdDepositoYMantenimiento { get => idDepositoYMantenimiento; set => idDepositoYMantenimiento = value; }
        public string NombreObra { get => nombreObra; set => nombreObra = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaRegistracion { get => fechaRegistracion; set => fechaRegistracion = value; }
        public string EncargadoRegistro { get => encargadoRegistro; set => encargadoRegistro = value; }
        public int DimensionAncho { get => dimensionAncho; set => dimensionAncho = value; }
        public int DimensionAlto { get => dimensionAlto; set => dimensionAlto = value; }
        public double Valuacion { get => valuacion; set => valuacion = value; }
        internal Artista Artista { get => artista; set => artista = value; }
        internal Estilo Estilo { get => estilo; set => estilo = value; }
        internal TipoObra TipoObra { get => tipoObra; set => tipoObra = value; }
        internal MotivoIngreso MotivoIngreso { get => motivoIngreso; set => motivoIngreso = value; }
        internal Destino Destino { get => destino; set => destino = value; }

        public string toStringObras()
        {
            return "ID: " + IdObra + ", Fecha Creación: " + fechaCreacion.Date.ToString() + ", Fecha Registración: " + fechaRegistracion.Date.ToString() + ", Nombre: " + NombreObra + ", Estilo: " + Estilo.toString() + ", Artista: " + Artista.toStringArtista() + ", Destino: " + Destino.toStringDestino();
        }
    }
}