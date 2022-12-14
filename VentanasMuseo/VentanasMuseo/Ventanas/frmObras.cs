using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da_Vinci_Code_Manager
{
    public partial class frmObras : Form
    {
        //private AccesoDatos oDatos = new AccesoDatos(@"Server=.\SQLExpress;Database=Museo; Trusted_Connection=Yes;");
        private AccesoDatos oDatos = new AccesoDatos(@"Data Source =.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Museo.mdf;Integrated Security = True; Connect Timeout = 30");
        private const int tam = 30000;
        private Obras[] ob = new Obras[tam];
        private Obras obras = new Obras();
        private bool nuevo = false;
        private int c = 0;

        //btnGuardar.Enter += btnGuardar_Enter; para agregar evento   //no lo usamos solamente es para recordarlo
        //btnGuardar.Enter -= btnGuardar_Enter; para quitar evento

        private void agregarMensajeAlineado(int i, string mensaje, Control con)
        {
            frmAux form = new frmAux(i);
            form.lblContenido.Text = mensaje;
            form.lblContenido.Left = (form.Width - form.lblContenido.Width + form.picIconoMensaje.Width) / 2;
            form.lblContenido.Top = (form.Height - form.lblContenido.Height) / 2;
            form.picIconoMensaje.Location = new Point(form.lblContenido.Location.X - 40, form.picIconoMensaje.Location.Y - 5);
            form.ShowDialog();
            form.siNo();
            if (i != 2)
                con.Focus();
            else
                form.Dispose();
        }

        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombreObra.Text))
            {
                agregarMensajeAlineado(0, "Ingrese un nombre de obra.", txtNombreObra);
                return false;
            }
            if (cmbArtista.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Seleccione un artista", cmbArtista);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                agregarMensajeAlineado(0, "Ingrese una descripción", txtDescripcion);
                return false;
            }
            if (cmbEstilo.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Seleccione un estilo", cmbEstilo);
                return false;
            }
            if (cmbTipoObra.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Seleccione un tipo de obra", cmbTipoObra);
                return false;
            }
            if (dtpFechaCreacion.Value.Date > DateTime.Today)
            {
                agregarMensajeAlineado(0, "La fecha de creación no puede ser \n superior a la fecha actual", dtpFechaCreacion);
                return false;
            }
            if (dtpFechaRegistracion.Value.Date > DateTime.Today)
            {
                agregarMensajeAlineado(0, "La fecha de registración no puede ser \n superior a la fecha actual", dtpFechaRegistracion);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEncargadoDeRegistro.Text))
            {
                agregarMensajeAlineado(0, "Ingrese el encargado del registro", txtEncargadoDeRegistro);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAlto.Text))
            {
                agregarMensajeAlineado(0, "Ingrese una altura de obra", txtAlto);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAncho.Text))
            {
                agregarMensajeAlineado(0, "Ingrese ancho de obra", txtAncho);
                return false;
            }
            if (cmbDestino.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Seleccione un destino", cmbDestino);
                return false;
            }
            if (cmbMotivoIngreso.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Seleccione un motivo de ingreso", cmbMotivoIngreso);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtValuacion.Text))
            {
                agregarMensajeAlineado(0, "Ingrese la valuación de la obra", txtValuacion);
                return false;
            }
            else
                return true;
        }

        public frmObras()
        {
            InitializeComponent();
            //Initialize Design Components
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            //DON'T TOUCH
        }

        private void Obras_Load(object sender, EventArgs e)
        {
    
            ContextMenu _blankContextMenu = new ContextMenu();
            txtNombreObra.ContextMenu = _blankContextMenu;
            txtEncargadoDeRegistro.ContextMenu = _blankContextMenu;
            txtDescripcion.ContextMenu = _blankContextMenu;
            txtAlto.ContextMenu = _blankContextMenu;
            txtAncho.ContextMenu = _blankContextMenu;
            txtValuacion.ContextMenu = _blankContextMenu;

            lblUsuario.Left = this.Width - lblUsuario.Width;
            picIconUser.Location = new Point(lblUsuario.Location.X - 20, picIconUser.Location.Y);
            oDatos.CargarCombo(cmbFiltro, "Destino");
            oDatos.CargarCombo(cmbArtista, "vArtista");
            oDatos.CargarCombo(cmbEstilo, "Estilo");
            oDatos.CargarCombo(cmbDestino, "Destino");
            oDatos.CargarCombo(cmbTipoObra, "TipoDeObra");
            oDatos.CargarCombo(cmbMotivoIngreso, "MotivoDeIngreso");
            CargarLista("Obra");
            habilitar(false);
            lstObras.SelectedIndex = lstObras.Items.Count - 1;
        }

        private void cargarCampos(int posicion)
        {
            if (lstObras.Items.Count == 0)
            {
                return;
            }
            else
            {
                txtNombreObra.Text = ob[posicion].NombreObra;
                cmbArtista.Text = ob[posicion].Artista.toStringArtista();
                txtDescripcion.Text = ob[posicion].Descripcion;
                cmbEstilo.Text = ob[posicion].Estilo.Descripcion;
                cmbTipoObra.Text = ob[posicion].TipoObra.TipoDeObra;
                cmbMotivoIngreso.Text = ob[posicion].MotivoIngreso.Motivo;
                cmbDestino.Text = ob[posicion].Destino.NombreDestino;
                dtpFechaCreacion.Value = Convert.ToDateTime(ob[posicion].FechaCreacion);
                dtpFechaRegistracion.Value = Convert.ToDateTime(ob[posicion].FechaRegistracion);
                txtEncargadoDeRegistro.Text = ob[posicion].EncargadoRegistro;
                txtAncho.Text = ob[posicion].DimensionAncho.ToString();
                txtAlto.Text = ob[posicion].DimensionAlto.ToString();
                txtValuacion.Text = ob[posicion].Valuacion.ToString();
            }
        }

        private void lstObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstObras.SelectedIndex);
        }

        private void CargarLista(string NombreTabla)
        {
            oDatos.leerObra(NombreTabla);
            int c = 0;

            while (oDatos.pLector.Read())
            {
                Obras o = new Obras();

                Estilo e = new Estilo();
                TipoObra t = new TipoObra();
                Destino d = new Destino();
                Artista a = new Artista();
                MotivoIngreso m = new MotivoIngreso();

                if (!oDatos.pLector.IsDBNull(7))
                {
                    e.IdEstilo = oDatos.pLector.GetInt32(7);
                }
                if (!oDatos.pLector.IsDBNull(20))
                {
                    e.Descripcion = oDatos.pLector.GetString(20);
                }
                o.Estilo = e;

                if (!oDatos.pLector.IsDBNull(16))
                {
                    t.IdTipoObra = oDatos.pLector.GetInt32(16);
                }
                if (!oDatos.pLector.IsDBNull(26))
                {
                    t.TipoDeObra = oDatos.pLector.GetString(26);
                }
                o.TipoObra = t;

                if (!oDatos.pLector.IsDBNull(21))
                {
                    d.IdDestino = oDatos.pLector.GetInt32(21);
                }
                if (!oDatos.pLector.IsDBNull(22))
                {
                    d.NombreDestino = oDatos.pLector.GetString(22);
                }
                o.Destino = d;

                if (!oDatos.pLector.IsDBNull(27))
                {
                    a.IdArtista = oDatos.pLector.GetInt32(27);
                }
                if (!oDatos.pLector.IsDBNull(28))
                {
                    a.Nombre = oDatos.pLector.GetString(28);
                }
                if (!oDatos.pLector.IsDBNull(29))
                {
                    a.Apellido = oDatos.pLector.GetString(29);
                }
                o.Artista = a;

                if (!oDatos.pLector.IsDBNull(23))
                {
                    m.IdMotivoingreso = oDatos.pLector.GetInt32(23);
                }
                if (!oDatos.pLector.IsDBNull(24))
                {
                    m.Motivo = oDatos.pLector.GetString(24);
                }
                o.MotivoIngreso = m;

                if (!oDatos.pLector.IsDBNull(0))
                {
                    o.IdObra = oDatos.pLector.GetInt32(0);
                }

                if (!oDatos.pLector.IsDBNull(6))
                {
                    o.NombreObra = oDatos.pLector.GetString(6);
                }

                if (!oDatos.pLector.IsDBNull(15))
                {
                    o.Descripcion = oDatos.pLector.GetString(15);
                }

                if (!oDatos.pLector.IsDBNull(10))
                {
                    o.DimensionAncho = oDatos.pLector.GetInt32(10);
                }

                if (!oDatos.pLector.IsDBNull(8))
                {
                    o.FechaCreacion = oDatos.pLector.GetDateTime(8);
                }

                if (!oDatos.pLector.IsDBNull(12))
                {
                    o.FechaRegistracion = oDatos.pLector.GetDateTime(12);
                }

                if (!oDatos.pLector.IsDBNull(11))
                {
                    o.DimensionAlto = oDatos.pLector.GetInt32(11);
                }

                if (!oDatos.pLector.IsDBNull(13))
                {
                    o.EncargadoRegistro = oDatos.pLector.GetString(13);
                }

                if (!oDatos.pLector.IsDBNull(14))
                {
                    o.Valuacion = oDatos.pLector.GetDouble(14);
                }

                ob[c] = o;
                c++;
            }
            oDatos.pLector.Close();
            oDatos.desconectar();

            lstObras.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                lstObras.Items.Add(ob[i].toStringObras());
            }


        }

        private void CargarListaCombo(string NombreTabla, int indexDelComboDestino)
        {
            oDatos.leerObraParaFiltroDestino(NombreTabla, indexDelComboDestino);
            int c = 0;

            while (oDatos.pLector.Read())
            {
                Obras o = new Obras();

                Estilo e = new Estilo();
                TipoObra t = new TipoObra();
                Destino d = new Destino();
                Artista a = new Artista();
                MotivoIngreso m = new MotivoIngreso();

                if (!oDatos.pLector.IsDBNull(7))
                {
                    e.IdEstilo = oDatos.pLector.GetInt32(7);
                }
                if (!oDatos.pLector.IsDBNull(20))
                {
                    e.Descripcion = oDatos.pLector.GetString(20);
                }
                o.Estilo = e;

                if (!oDatos.pLector.IsDBNull(16))
                {
                    t.IdTipoObra = oDatos.pLector.GetInt32(16);
                }
                if (!oDatos.pLector.IsDBNull(26))
                {
                    t.TipoDeObra = oDatos.pLector.GetString(26);
                }
                o.TipoObra = t;

                if (!oDatos.pLector.IsDBNull(21))
                {
                    d.IdDestino = oDatos.pLector.GetInt32(21);
                }
                if (!oDatos.pLector.IsDBNull(22))
                {
                    d.NombreDestino = oDatos.pLector.GetString(22);
                }
                o.Destino = d;

                if (!oDatos.pLector.IsDBNull(27))
                {
                    a.IdArtista = oDatos.pLector.GetInt32(27);
                }
                if (!oDatos.pLector.IsDBNull(28))
                {
                    a.Nombre = oDatos.pLector.GetString(28);
                }
                if (!oDatos.pLector.IsDBNull(29))
                {
                    a.Apellido = oDatos.pLector.GetString(29);
                }
                o.Artista = a;

                if (!oDatos.pLector.IsDBNull(23))
                {
                    m.IdMotivoingreso = oDatos.pLector.GetInt32(23);
                }
                if (!oDatos.pLector.IsDBNull(24))
                {
                    m.Motivo = oDatos.pLector.GetString(24);
                }
                o.MotivoIngreso = m;

                if (!oDatos.pLector.IsDBNull(0))
                {
                    o.IdObra = oDatos.pLector.GetInt32(0);
                }

                if (!oDatos.pLector.IsDBNull(6))
                {
                    o.NombreObra = oDatos.pLector.GetString(6);
                }

                if (!oDatos.pLector.IsDBNull(15))
                {
                    o.Descripcion = oDatos.pLector.GetString(15);
                }

                if (!oDatos.pLector.IsDBNull(10))
                {
                    o.DimensionAncho = oDatos.pLector.GetInt32(10);
                }

                if (!oDatos.pLector.IsDBNull(8))
                {
                    o.FechaCreacion = oDatos.pLector.GetDateTime(8);
                }

                if (!oDatos.pLector.IsDBNull(12))
                {
                    o.FechaRegistracion = oDatos.pLector.GetDateTime(12);
                }

                if (!oDatos.pLector.IsDBNull(11))
                {
                    o.DimensionAlto = oDatos.pLector.GetInt32(11);
                }

                if (!oDatos.pLector.IsDBNull(13))
                {
                    o.EncargadoRegistro = oDatos.pLector.GetString(13);
                }

                if (!oDatos.pLector.IsDBNull(14))
                {
                    o.Valuacion = oDatos.pLector.GetDouble(14);
                }

                ob[c] = o;
                c++;
            }
            oDatos.pLector.Close();
            oDatos.desconectar();

            lstObras.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                lstObras.Items.Add(ob[i].toStringObras());
            }


        }

        private void limpiar()
        {
            txtNombreObra.Clear();
            cmbArtista.SelectedIndex = -1;
            txtDescripcion.Clear();
            txtAlto.Clear();
            txtAncho.Clear();
            txtEncargadoDeRegistro.Clear();
            txtValuacion.Clear();
            dtpFechaCreacion.Value = DateTime.Now;
            dtpFechaRegistracion.Value = DateTime.Now;
            cmbDestino.SelectedIndex = -1;
            cmbEstilo.SelectedIndex = -1;
            cmbTipoObra.SelectedIndex = -1;
            cmbMotivoIngreso.SelectedIndex = -1;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            
            cmbFiltro.SelectedIndex = -1;
            CargarLista("Visita");
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.BackColor = SystemColors.ActiveBorder;
            lstObras.SelectedIndex = lstObras.Items.Count - 1;
            habilitar(true);
            nuevo = true;
            txtNombreObra.Focus();
            limpiar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            ptbBarra.Focus();
            cmbFiltro.SelectedIndex = -1;
            if (lstObras.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una obra para realizar esta acción", "No ha seleccionado una obra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            
                btnModificar.FlatStyle = FlatStyle.Popup;
                btnModificar.BackColor = SystemColors.ActiveBorder;
                ptbBarra.Focus();
                habilitar(true);
                nuevo = false;
                txtNombreObra.Focus();
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();

            int i = lstObras.SelectedIndex;
            if (lstObras.SelectedIndex != -1)
            {
                btnEliminar.FlatStyle = FlatStyle.Popup;
                btnEliminar.BackColor = SystemColors.ActiveBorder;
                if (MessageBox.Show("¿Seguro que quiere eliminar la obra \"" + ob[i].NombreObra + "\" de " + ob[i].Artista.Nombre + "?", "A punto de borrar...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                    DialogResult.Yes)
                {
                    btnCancelar.FlatStyle = FlatStyle.Flat;
                    btnCancelar.BackColor = Color.Transparent;
                    string sql = "DELETE FROM Obra WHERE idObra = " + ob[i].IdObra;
                    oDatos.actualizarDB(sql);
                    CargarLista("Obra");
                    habilitar(false);
                    lstObras.SelectedIndex = lstObras.Items.Count - 1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una obra para realizar esta acción", "No ha seleccionado una obra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.BackColor = Color.Transparent;
            if (lstObras.Items.Count == 0)
            {
                limpiar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            if (validar())
            {
                Obras o = new Obras();
                Estilo es = new Estilo();
                TipoObra t = new TipoObra();
                Destino d = new Destino();
                Artista a = new Artista();
                MotivoIngreso m = new MotivoIngreso();

                a.IdArtista = cmbArtista.SelectedIndex + 1;
                o.Artista = a;

                es.IdEstilo = cmbEstilo.SelectedIndex + 1;
                o.Estilo = es;

                t.IdTipoObra = cmbTipoObra.SelectedIndex + 1;
                o.TipoObra = t;

                d.IdDestino = cmbDestino.SelectedIndex + 1;
                o.Destino = d;

                m.IdMotivoingreso = cmbMotivoIngreso.SelectedIndex + 1;
                o.MotivoIngreso = m;

                o.Descripcion = txtDescripcion.Text;
                o.NombreObra = txtNombreObra.Text;

                o.FechaCreacion = dtpFechaCreacion.Value;
                o.FechaRegistracion = dtpFechaRegistracion.Value;
                o.EncargadoRegistro = txtEncargadoDeRegistro.Text;
                o.DimensionAncho = Convert.ToInt32(txtAncho.Text);
                o.DimensionAlto = Convert.ToInt32(txtAlto.Text);
                o.Valuacion = Convert.ToDouble(txtValuacion.Text);

                string sql;
                int i = lstObras.SelectedIndex;
                if (nuevo)
                {
                    sql = "insert into Obra (idArtista,nombreObra,idEstilo,fechaCreacion,dimensionAncho_cm," +
                        "dimensionAlto_cm,fechaRegistracion,encargadoRegistro,valuacion,descripcion,idTipoObra,idDestino,idMotivoIngreso) values (" +
                        o.Artista.IdArtista + ",'" +
                        o.NombreObra + "'," +
                        o.Estilo.IdEstilo + ",'" +
                        o.FechaCreacion.Date.ToString("MM/dd/yyyy HH:mm:ss") + "'," +
                        o.DimensionAncho + "," +
                        o.DimensionAlto + ",'" +
                        o.FechaRegistracion.Date.ToString("MM/dd /yyyy HH: mm:ss") + "','" +
                        o.EncargadoRegistro + "'," +
                        o.Valuacion + ",'" +
                        o.Descripcion + "'," +
                        o.TipoObra.IdTipoObra + "," +
                        o.Destino.IdDestino + "," +
                        o.MotivoIngreso.IdMotivoingreso + ")";

                    oDatos.actualizarDB(sql);

                    CargarLista("Obra");
                    lstObras.SelectedIndex = lstObras.Items.Count - 1;
                }
                else
                {
                    sql = "update Obra set idArtista =" + o.Artista.IdArtista + "," +
                        "nombreObra ='" + o.NombreObra + "'," +
                        "idEstilo = " + o.Estilo.IdEstilo + "," +
                        "fechaCreacion ='" + o.FechaCreacion.Date.ToString("MM/dd/yyyy HH:mm:ss") + "'," +
                        "dimensionAncho_cm =" + o.DimensionAncho + "," +
                        "dimensionAlto_cm = " + o.DimensionAlto + "," +
                        "fechaRegistracion ='" + o.FechaRegistracion.Date.ToString("MM/dd/yyyy HH:mm:ss") + "'," +
                        "encargadoRegistro ='" + o.EncargadoRegistro + "'," +
                        "valuacion =" + o.Valuacion + "," +
                        "descripcion = '" + o.Descripcion + "'," +
                        "idTipoObra =" + o.TipoObra.IdTipoObra + "," +
                        "idDestino =" + o.Destino.IdDestino + "," +
                        "idMotivoIngreso =" + o.MotivoIngreso.IdMotivoingreso +
                        " where idObra =" + ob[i].IdObra;

                    oDatos.actualizarDB(sql);

                    CargarLista("Obra");
                }
                btnGuardar.FlatStyle = FlatStyle.Popup;
                btnGuardar.BackColor = SystemColors.ActiveBorder;
                habilitar(false);
                nuevo = false;
                agregarMensajeAlineado(2, "Guardado correctamente", null);
            }
        }

        private void habilitar(bool x)
        {
            txtNombreObra.Enabled = x;
            cmbArtista.Enabled = x;
            cmbEstilo.Enabled = x;
            txtDescripcion.Enabled = x;
            txtAlto.Enabled = x;
            txtAncho.Enabled = x;
            txtEncargadoDeRegistro.Enabled = x;
            txtValuacion.Enabled = x;
            cmbDestino.Enabled = x;
            cmbTipoObra.Enabled = x;
            cmbMotivoIngreso.Enabled = x;
            dtpFechaCreacion.Enabled = x;
            dtpFechaRegistracion.Enabled = x;

            btnFiltro.Enabled = !x;
            cmbFiltro.Enabled = !x;
            button1.Enabled = !x;

            btnNuevo.Enabled = !x;
            if (btnNuevo.Enabled = !x)
            {
                btnNuevo.BackgroundImage = Resource1.Plus__Orange;
                lblNuevo.Visible = true;
                btnNuevo.FlatStyle = FlatStyle.Flat;
                btnNuevo.BackColor = Color.Transparent;
            }
            else
            {
                btnNuevo.BackgroundImage = Resource1.Plus__Orange_disabled;
                lblNuevo.Visible = false;
            }

            btnModificar.Enabled = !x;
            if (btnModificar.Enabled = !x)
            {
                btnModificar.BackgroundImage = Resource1.Pencil3;
                lblModificar.Visible = true;
                btnModificar.FlatStyle = FlatStyle.Flat;
                btnModificar.BackColor = Color.Transparent;
            }
            else
            {
                btnModificar.BackgroundImage = Resource1.Pencil3_disabled;
                lblModificar.Visible = false;
            }

            btnEliminar.Enabled = !x;
            if (btnEliminar.Enabled = !x)
            {
                btnEliminar.BackgroundImage = Resource1.DeleteRed;
                lblEliminar.Visible = true;
                btnEliminar.FlatStyle = FlatStyle.Flat;
                btnEliminar.BackColor = Color.Transparent;
            }
            else
            {
                btnEliminar.BackgroundImage = Resource1.DeleteRed_disabled;
                lblEliminar.Visible = false;
            }

            btnGuardar.Enabled = x;
            if (btnGuardar.Enabled = x)
            {
                btnGuardar.BackgroundImage = Resource1.save;
                lblGuardar.Visible = true;
                btnGuardar.FlatStyle = FlatStyle.Flat;
                btnGuardar.BackColor = Color.Transparent;
            }
            else
            {
                btnGuardar.BackgroundImage = Resource1.save_disabled;
                lblGuardar.Visible = false;
            }

            btnCancelar.Enabled = x;
            if (btnCancelar.Enabled = x)
            {
                btnCancelar.BackgroundImage = Resource1.Cancel__Red;
                lblCancelar.Visible = true;
                btnCancelar.FlatStyle = FlatStyle.Flat;
                btnCancelar.BackColor = Color.Transparent;
            }
            else
            {
                btnCancelar.BackgroundImage = Resource1.Cancel__Red_disabled;
                lblCancelar.Visible = false;
            }
            lstObras.Enabled = !x;
        }

        //Star Graphic User Interface Design
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );

        private const int WS_MINIMIZEBOX = 0x20000;
        private const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // para minimizar a restaurar ventana desde icno de barra de estado
                cp.Style |= WS_MINIMIZEBOX; //
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void BtnNuevo_MouseEnter(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Resource1.Plus__OrangeMod1;
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Resource1.Plus__Orange;
        }

        private void BtnNuevo_Enter(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Resource1.Plus__OrangeMod1;
        }

        private void BtnNuevo_Leave(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            btnNuevo.BackgroundImage = Resource1.Plus__Orange;
        }

        private void BtnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Resource1.Pencil3Mod1;
        }

        private void BtnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Resource1.Pencil3;
        }

        private void BtnModificar_Enter(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Resource1.Pencil3Mod1;
        }

        private void BtnModificar_Leave(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            btnModificar.BackgroundImage = Resource1.Pencil3;
        }

        private void BtnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Resource1.DeleteRedMod1;
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Resource1.DeleteRed;
        }

        private void BtnEliminar_Enter(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Resource1.DeleteRedMod1;
        }

        private void BtnEliminar_Leave(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            btnEliminar.BackgroundImage = Resource1.DeleteRed;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            frmMenu menu = new frmMenu();
            menu.lblUsuario.Text = lblUsuarioEnMenu.Text;
            menu.Show();
            this.Dispose();
        }

        public int xClick = 0, yClick = 0;

        private void moverBarraConMouse(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { xClick = e.X; yClick = e.Y; } else { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void ptbBarra_MouseMove(object sender, MouseEventArgs e)
        {
            moverBarraConMouse(e);
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            moverBarraConMouse(e);
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            moverBarraConMouse(e);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            moverBarraConMouse(e);
        }

        private void FrmObras_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAux frm = new frmAux(1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.siNo())
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicMinimizar_MouseEnter(object sender, EventArgs e)
        {
            picMinimizar.Image = Da_Vinci_Code_Manager.Resource1.Minimize_Box_Blue_modified2;
        }

        private void PicMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicMinimizar_MouseLeave(object sender, EventArgs e)
        {
            picMinimizar.Image = Da_Vinci_Code_Manager.Resource1.Minimize_Box_Blue;
        }

        private void PicCerrar_MouseEnter(object sender, EventArgs e)
        {
            picCerrar.Image = Da_Vinci_Code_Manager.Resource1.Close_Box_Red_modified;
        }

        private void PicCerrar_MouseLeave(object sender, EventArgs e)
        {
            picCerrar.Image = Da_Vinci_Code_Manager.Resource1.Close_Box_Red_2;
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            frmAux frm = new frmAux(1);
            frm.ShowDialog();
            if (frm.siNo())
            {
                Application.ExitThread();
            }
            else
            {
                btnNuevo.Focus();
            }
        }

        private void GroupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Blue, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 42, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void LinkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAux form = new frmAux(3);
            if (form.siNo())
            {
                this.Dispose();
            }
        }

        private void CmbMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmbDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            ptbBarra.Focus();
            //nuevo = false;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.BackColor = SystemColors.ActiveBorder;
            if (MessageBox.Show("¿Seguro que quiere cancelar?", "Cancelando carga/edición de obra...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                nuevo = false;
                btnCancelar.FlatStyle = FlatStyle.Popup;
                btnCancelar.BackColor = SystemColors.ActiveBorder;
                limpiar();

                habilitar(false);
                cargarCampos(lstObras.SelectedIndex);
            }
            else
                btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.BackColor = Color.Transparent;
            return;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Resource1.Cancel__Redmod;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Resource1.Cancel__Red;
        }

        private void btnCancelar_Enter(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Resource1.Cancel__Redmod;
        }

        private void btnCancelar_Leave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Resource1.Cancel__Red;
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Resource1.savemod;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Resource1.save;
        }

        private void btnGuardar_Enter(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Resource1.savemod;
        }

        private void btnGuardar_Leave(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Resource1.save;
        }

        private void SoloEscribirNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            if (lstObras.Items.Count == 0)
            {
                MessageBox.Show("No se puede ver la nomina", "Perdon.. pero la lista está vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return;
            }
            else
            {
                frmImprimirObras nomimp = new frmImprimirObras();
                nomimp.Show();
                Hide();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Destino por el cual quiere filtrar", "Falta seleccionar destino", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return;
            }
            else

                CargarListaCombo("Obra", Convert.ToInt32(cmbFiltro.SelectedValue));
        }

        /*private DataTable Datos(int id)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source =.\SQLEXPRESS; AttachDbFilename =C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Museo.mdf; Integrated Security = True; Connect Timeout = 30"))
            {
                DataTable dt = new DataTable();
                string query = "select * from Obra where idDestino = @idDestino";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idDestino", id);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }*/

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private DataTable Datos(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(@"Data Source =.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Museo.mdf;Integrated Security = True; Connect Timeout = 30"))
        //    {
        //        DataTable dt = new DataTable();
        //        string query = "select * from Obra where idDestino = @idDestino";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@idDestino", id);
        //        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        //        adap.Fill(dt);
        //        conn.Close();
        //        //string test = dt//ME TRAE System.Data.ROWS. ETC....en vez de las columnas //creo que puede ser con el cargarLista()
        //        return dt;

        //    }
        //}

        private void cmbFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //lstObras.DisplayMember = "destino";
            //lstObras.DataSource = Datos (Convert.ToInt32(cmbFiltro.SelectedValue));
        }

        private void btnVerNomina_MouseEnter(object sender, EventArgs e)
        {
            btnVerNomina.BackgroundImage = Resource1.Book3Mod;
        }

        private void btnVerNomina_MouseLeave(object sender, EventArgs e)
        {
            btnVerNomina.BackgroundImage = Resource1.Book3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarLista("Obra");
        }

        private void SoloEscribirLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
    //o.FechaCreacion = dtpFechaCreacion.Value;
    //Date.ToString("MM/dd/yyyy HH:mm:ss")
    //o.FechaRegistracion = dtpFechaRegistracion.Value;  
}