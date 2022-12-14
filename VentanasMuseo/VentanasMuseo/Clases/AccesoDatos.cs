using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da_Vinci_Code_Manager {
    internal class AccesoDatos {
        public SqlCommand comando;
        private SqlConnection conexion;
        public DataTable tabla;
        public String cadenaConexion;
        public SqlDataReader lector;
        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public SqlDataReader pLector { get => lector; set => lector = value; }
        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public AccesoDatos (string cadenaConexion) {
            this.comando = new SqlCommand ();
            this.Conexion = new SqlConnection (cadenaConexion);
            this.Conexion.ConnectionString = cadenaConexion;
            this.tabla = new DataTable ();
            this.cadenaConexion = cadenaConexion;
            this.lector = null;
        }

        public AccesoDatos () {
            this.comando = new SqlCommand ();
            this.Conexion = new SqlConnection ();
            this.tabla = new DataTable ();
            this.cadenaConexion = "";
            this.lector = null;
        }

        public void conectar () {
            Conexion.ConnectionString = cadenaConexion;
            Conexion.Open ();
            comando.Connection = Conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar () {
            Conexion.Close ();
            Conexion.Dispose ();
        }

        public DataTable consultarTabla (string nombreTabla) {
            tabla = new DataTable ();
            conectar ();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load (comando.ExecuteReader ());
            desconectar ();
            return tabla;
        }

        public DataTable consultarTablaSQL (string nombreTabla) {
            tabla = new DataTable ();
            conectar ();
            comando.CommandText = nombreTabla;
            tabla.Load (comando.ExecuteReader ());
            desconectar ();
            return tabla;
        }

        public void leerTabla (string nombreTabla) {
            conectar ();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            lector = comando.ExecuteReader ();
        }

        public void leerObra (string nombreTabla) {
            conectar ();
            comando.CommandText = "select * from Obra o " +
                "inner join Estilo e on o.idEstilo=e.idEstilo " +
                "inner join Destino d on o.idDestino=d.idDestino " +
                "inner join MotivoDeIngreso m on o.idMotivoIngreso=m.idMotivoIngreso " +
                "inner join TipoDeObra t on o.idTipoObra=t.idTipoObra " +
                "inner join Artista a on o.idArtista=a.idArtista";
            lector = comando.ExecuteReader ();
        }
        public void leerObraParaFiltroDestino (string nombreTabla, int i) {
            conectar ();
            comando.CommandText = "select * from Obra o " +
                "inner join Estilo e on o.idEstilo=e.idEstilo " +
                "inner join Destino d on o.idDestino=d.idDestino " +
                "inner join MotivoDeIngreso m on o.idMotivoIngreso=m.idMotivoIngreso " +
                "inner join TipoDeObra t on o.idTipoObra=t.idTipoObra " +
                "inner join Artista a on o.idArtista=a.idArtista" +
                " where o.idDestino =" + i;
            lector = comando.ExecuteReader ();
        }

        public void leerVisitaParaFiltroTipoVisita(string nombreTabla, string tipoVisita)
        {
            conectar();
            comando.CommandText = "select * from Visita v " +
                "LEFT OUTER join Guia g on v.idGuia = g.idGuia " +
                "LEFT join Empleado e on  e.idEmpleado= g.idEmpleado"
                + " where v.tipoVisita='"+ tipoVisita + "' ";

            lector = comando.ExecuteReader();
        }

        public void leerVisita (string nombreTabla) {
            conectar ();
            comando.CommandText = "select * from Visita v " +
                "LEFT OUTER join Guia g on v.idGuia = g.idGuia " +
                "LEFT join Empleado e on  e.idEmpleado= g.idEmpleado";

            lector = comando.ExecuteReader ();
        }

        public void leerUsuario (string txt1, string txt2, int i) {
            conectar ();
            comando.CommandText = "select  Contraseña, Usuario, u.idTipoUsuario from Usuario u join TipoUsuario t on  u.idTipoUsuario=t.idTipoUsuario " +
                "where Contraseña ='" + txt1 + "' and Usuario ='" + txt2 + "'" + " and u.idTipoUsuario=" + i;
            lector = comando.ExecuteReader ();
            validarRegistro ();
        }

        public bool validarRegistro () {
            bool existenciaregistro = lector.HasRows;
            if (existenciaregistro) {
                return true;
            } else
                return false;
        }

        public void actualizarDB (string consultaSQL) {
            conectar ();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery ();
            desconectar ();
        }

        public void CargarCombo (ComboBox combo, string NombreTabla) {
            DataTable dt = new DataTable ();
            dt = this.consultarTabla (NombreTabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
    }
}