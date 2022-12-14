using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da_Vinci_Code_Manager
{
    public partial class frmVisitas : Form
    {
        //Con base de datos física al lado del programa (@"Server=.\SQLExpress;Database=Museo; Trusted_Connection=Yes;");
        private AccesoDatos oDatos = new AccesoDatos(@"Data Source =.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Museo.mdf;Integrated Security = True; Connect Timeout = 30");
        const int tam = 30000;
        Visitas[] vi = new Visitas[tam];
        Visitas visitas = new Visitas();
        bool nuevo = false;
        int c = 0;

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
        }

        private bool validar()
        {
            if (cmbTipoVisita.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Elija un Tipo de Visita", cmbTipoVisita);
                return false;
            }

            if (nudCantidadVisitantes.Value == 0)
            {
                agregarMensajeAlineado(0, "Ingrese una cantidad de visitantes", nudCantidadVisitantes);
                return false;
            }

            if (cmbTipoVisita.SelectedIndex == 0 && nudMonto.Value == 0)
            {
                agregarMensajeAlineado(0, "Ingrese un monto", nudMonto);
                return false;
            }

            if (chkSolicitudGuia.Checked && cmbGuia.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Seleccione un guía", cmbGuia);
                return false;
            }

            return true;
        }

        public frmVisitas()
        {
            InitializeComponent();
            //Initialize Design Components
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            lblFecha.Text = DateTime.Now.ToShortDateString();
            cmbTipoVisita.ContextMenu = new ContextMenu();
            //DON'T TOUCH
        }

        private void FrmVisitas_Load(object sender, EventArgs e)
        {
            btnGuiaVirtual.Enabled = false;
            cmbGuia.Enabled = false;
            //if (cmbTipoVisita.SelectedIndex == 1)
            //{
            //    nudMonto.Enabled = false;
            //}
            CargarLista("Visita");
            lblUsuario.Left = this.Width - lblUsuario.Width;
            picIconUser.Location = new Point(lblUsuario.Location.X - 20, picIconUser.Location.Y);

            for (int i = 0; i < 60; i++)
            {
                cbminutos.Items.Add(i);
                cbsegundos.Items.Add(i);
                if (i < 24)
                {
                    cbhoras.Items.Add(i);
                }
            }
            for (int i = 0; i < 60; i++)
            {
                cbminutos2.Items.Add(i);
                cbsegundos2.Items.Add(i);
                if (i < 24)
                {
                    cbhoras2.Items.Add(i);
                }
            }
            cbminutos.SelectedIndex = 0;
            cbsegundos.SelectedIndex = 1;
            cbhoras.SelectedIndex = 0;
            cbhoras2.SelectedIndex = 0;
            cbminutos2.SelectedIndex = 0;
            cbsegundos2.SelectedIndex = 1;


            btnIniciar.ForeColor = Color.ForestGreen;
            btnIniciar2.ForeColor = Color.ForestGreen;
            btnPausar.Enabled = false;
            btnPausar2.Enabled = false;
            btnPausar.ForeColor = Color.RoyalBlue;
            btnPausar2.ForeColor = Color.RoyalBlue;

            oDatos.CargarCombo(cmbGuia, "vGuia");
            //CargarLista("Obra");
            habilitar(false);
            lstVisitas.SelectedIndex = lstVisitas.Items.Count - 1;
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

        private void cargarCampos(int posicion)
        {
            if (lstVisitas.Items.Count == 0)
            {
                return;
            }
            else
            {
                cmbTipoVisita.Text = vi[posicion].TipoVisita;
                nudCantidadVisitantes.Value = vi[posicion].CantidadVisitantes;
                nudMonto.Value = Convert.ToInt32(vi[posicion].Monto);
                chkSolicitudGuia.Checked = vi[posicion].SolicitudGuia;
                cmbGuia.Text = vi[posicion].Empleado.toStringEmpleado();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Visitas v = new Visitas();
                Empleado em = new Empleado();

                em.IdEmpleado = cmbGuia.SelectedIndex + 1;
                v.Empleado = em;

                v.CantidadVisitantes = Convert.ToInt32(nudCantidadVisitantes.Value);
                v.Monto = Convert.ToDouble(nudMonto.Value);
                v.TipoVisita = cmbTipoVisita.Text;
                v.SolicitudGuia = chkSolicitudGuia.Checked;

                string sql;
                int i = lstVisitas.SelectedIndex;
                if (nuevo)
                {
                    if (v.Empleado.IdEmpleado == 0)
                    {
                        sql = "insert into Visita(cantidadVisitantes, solicitudGuia, tipoVisita, monto) values (" +
                            v.CantidadVisitantes + ",'" +
                            v.SolicitudGuia + "','" +
                            v.TipoVisita + "'," +
                            v.Monto + ")";
                    }
                    else
                    {
                        sql = "insert into Visita(cantidadVisitantes, solicitudGuia, idGuia, tipoVisita, monto) values (" +
                            v.CantidadVisitantes + ",'" +
                            v.SolicitudGuia + "'," +
                            v.Empleado.IdEmpleado + ",'" +
                            v.TipoVisita + "'," +
                            v.Monto + ")";
                    }
                    oDatos.actualizarDB(sql);
                    CargarLista("Visita");
                }
                else
                {
                    if (v.Empleado.IdEmpleado == 0)
                    {
                        sql = "update Visita set cantidadVisitantes =" + v.CantidadVisitantes + "," +
                            "monto =" + v.Monto + "," +
                            "solicitudGuia ='" + v.SolicitudGuia + "'," +
                            "tipoVisita ='" + v.TipoVisita + "' " +
                            "where idVisita =" + vi[i].IdVisita;
                        oDatos.actualizarDB(sql);
                        CargarLista("Visita");
                    }
                    else
                    {
                        sql = "update Visita set cantidadVisitantes =" + v.CantidadVisitantes + "," +
                            "monto =" + v.Monto + "," +
                            "solicitudGuia ='" + v.SolicitudGuia + "'," +
                            "idGuia = " + v.Empleado.IdEmpleado + "," +
                            "tipoVisita ='" + v.TipoVisita + "' " +
                            "where idVisita =" + vi[i].IdVisita;
                        oDatos.actualizarDB(sql);
                        CargarLista("Visita");
                    }
                }
                btnGuardar.FlatStyle = FlatStyle.Popup;
                btnGuardar.BackColor = SystemColors.ActiveBorder;
                habilitar(false);
                nuevo = false;
                agregarMensajeAlineado(2, "Guardado correctamente", null);
            }
        }

        private void limpiar()
        {
            //txtFecha.Text = "";
            cmbTipoVisita.SelectedIndex = -1;
            chkSolicitudGuia.Checked = false;
            nudCantidadVisitantes.Value = 0;
            nudMonto.Value = 0;
        }

        private void habilitar(bool x)
        {
            cmbTipoVisita.Enabled = x;
            chkSolicitudGuia.Enabled = x;
            nudCantidadVisitantes.Enabled = x;
            
            nudMonto.Enabled = x;
            btnModificar.Enabled = !x;
            btnEliminar.Enabled = !x;
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
            lstVisitas.Enabled = !x;
        }

        private void CargarLista(string NombreTabla)
        {
            oDatos.leerVisita(NombreTabla);
            int c = 0;
            while (oDatos.pLector.Read())
            {
                Visitas v = new Visitas();
                Empleado e = new Empleado();

                if (!oDatos.pLector.IsDBNull(0))
                    v.IdVisita = oDatos.pLector.GetInt32(0);
                if (!oDatos.pLector.IsDBNull(5))
                    v.TipoVisita = oDatos.pLector.GetString(5);
                if (!oDatos.pLector.IsDBNull(4))
                    v.SolicitudGuia = oDatos.pLector.GetBoolean(4);
                if (!oDatos.pLector.IsDBNull(3))
                    v.CantidadVisitantes = oDatos.pLector.GetInt32(3);
                if (!oDatos.pLector.IsDBNull(8))
                    v.Monto = oDatos.pLector.GetDouble(8);

                if (!oDatos.pLector.IsDBNull(11))
                    e.IdEmpleado = oDatos.pLector.GetInt32(11);
                if (!oDatos.pLector.IsDBNull(13))
                    e.Nombre = oDatos.pLector.GetString(13);
                if (!oDatos.pLector.IsDBNull(14))
                    e.Apellido = oDatos.pLector.GetString(14);

                v.Empleado = e;

                vi[c] = v;
                c++;
            }
            oDatos.pLector.Close();
            oDatos.desconectar();

            lstVisitas.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                lstVisitas.Items.Add(vi[i].toStringVisitas());
            }
            lstVisitas.SelectedIndex = lstVisitas.Items.Count - 1;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnGuiaVirtual.Enabled = true;
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.BackColor = SystemColors.ActiveBorder;
            ptbBarra.Focus();
            lstVisitas.SelectedIndex = lstVisitas.Items.Count - 1;
            cmbFiltro.SelectedIndex = -1;
            CargarLista("Visita");
            limpiar();
            nuevo = true;
            habilitar(true);
            cmbTipoVisita.Focus();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            cmbFiltro.SelectedIndex = -1;
            CargarLista("Visita");
            ptbBarra.Focus();
            //.SelectedIndex = -1; //Como se llama el combo
            if (lstVisitas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una visita para realizar esta acción", "No ha seleccionado una visita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnModificar.FlatStyle = FlatStyle.Popup;
                btnModificar.BackColor = SystemColors.ActiveBorder;
                ptbBarra.Focus();
                habilitar(true);
                nuevo = false;
                cmbTipoVisita.Focus();
                if (cmbTipoVisita.SelectedIndex == 1)
                {
                    nudMonto.Enabled = false;
                }

            }
        }

        int horas;
        int min;
        int seg;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cbsegundos.SelectedIndex == 0)
            {
                cbsegundos.SelectedIndex = 1;
            }
            if (btnIniciar.Text == "Iniciar")
            {
                timer1.Start();
                btnIniciar.ForeColor = Color.Firebrick;
                btnPausar.Enabled = true;
                horas = cbhoras.SelectedIndex;
                min = cbminutos.SelectedIndex;
                seg = cbsegundos.SelectedIndex;
                btnIniciar.Text = "Restablecer";
            }
            else
            {
                timer1.Stop();
                seg = 0;
                min = 0;
                horas = 0;
                lblTiempo1.Text = "00:00:00";
                btnIniciar.ForeColor = Color.ForestGreen;
                btnPausar.Enabled = false;
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
                btnIniciar.Text = "Iniciar";
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (btnPausar.Text == "Pausar")
            {
                timer1.Stop();
                btnPausar.ForeColor = Color.DarkOrange;
                btnPausar.Text = "Reanudar";
            }
            else
            {
                timer1.Start();
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg -= 1;

            string minutos = min.ToString();
            string hor = horas.ToString();
            string segundos = seg.ToString();

            if (horas < 10)
            {
                hor = "0" + horas.ToString();
            }

            if (min < 10)
            {
                minutos = "0" + min.ToString();
            }

            if (seg < 10)
            {
                segundos = "0" + seg.ToString();
            }

            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }

            if (min == 0 && horas > 0 && seg == 0)
            {
                seg = 60;
                horas -= 1;
                min = 59;
            }

            if (min == 0 && horas == 0 && seg == 0)
            {
                timer1.Stop();
                MessageBox.Show("Se ha acabado el tiempo estimado para el Guía 1.", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblTiempo1.Text = hor + ":" + minutos + ":" + segundos;
        }

        private void SoloEscribirNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void NoEscribirSoloElegir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        private void lstVisitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstVisitas.SelectedIndex);
        }
        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys CutKeys = Keys.Control | Keys.X;
        private const Keys PasteKeys = Keys.Control | Keys.V;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys) || (keyData == CutKeys))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private const int WS_MINIMIZEBOX = 0x20000;
        private const int CS_DBLCLKS = 0x8;
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();

            int i = lstVisitas.SelectedIndex;
            if (lstVisitas.SelectedIndex != -1)
            {
                btnEliminar.FlatStyle = FlatStyle.Popup;
                btnEliminar.BackColor = SystemColors.ActiveBorder;
                if (MessageBox.Show("¿Seguro que quiere eliminar la visita con ID \"" + vi[i].IdVisita + "?", "A punto de borrar...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                    DialogResult.Yes)
                {
                    btnCancelar.FlatStyle = FlatStyle.Flat;
                    btnCancelar.BackColor = Color.Transparent;
                    string sql = "DELETE FROM Visita WHERE idVisita = " + vi[i].IdVisita;
                    oDatos.actualizarDB(sql);
                    CargarLista("Visita");
                    habilitar(false);
                    lstVisitas.SelectedIndex = lstVisitas.Items.Count - 1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una visita para realizar esta acción", "No ha seleccionado una visita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.BackColor = Color.Transparent;
            if (lstVisitas.Items.Count == 0)
            {
                limpiar();
            }
        }
        /// ////////////////////////////////////////////////////

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

        private void FrmVisitas_FormClosing(object sender, FormClosingEventArgs e)
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
            Pen p = new Pen(Color.Gray, 1); //3 original
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 40, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }


        private void BtnModificar_MouseEnterc(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Pencil3Mod1;
        }

        private void BtnModificar_MouseLeavec(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Pencil3;
        }


        private void BtnEliminar_MouseEntert(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.DeleteRedMod1;
        }

        private void BtnEliminar_MouseLeavet(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.DeleteRed;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            //nuevo = false;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.BackColor = SystemColors.ActiveBorder;
            if (MessageBox.Show("¿Seguro que quiere cancelar?", "Cancelando carga/edición de visita...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                nuevo = false;
                btnCancelar.FlatStyle = FlatStyle.Popup;
                btnCancelar.BackColor = SystemColors.ActiveBorder;
                limpiar();

                habilitar(false);
                cargarCampos(lstVisitas.SelectedIndex);
            }
            else
                btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.BackColor = Color.Transparent;
            return;
        }
        private void chkSolicitudGuia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSolicitudGuia.Checked == true)
            {
                cmbGuia.Enabled = true;
                btnGuiaVirtual.Enabled = false;
                

            }
            else
            {
                cmbGuia.Enabled = false;
                btnGuiaVirtual.Enabled = true;
            }
        }

        private void btnGuiaVirtual_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuiaVirtual frmgv = new frmGuiaVirtual();
            frmgv.Show();
        }

        private void lstVisitas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            cargarCampos(lstVisitas.SelectedIndex);
        }

        private void CargarListaCombo(string NombreTabla, string combovalue)
        {
            oDatos.leerVisitaParaFiltroTipoVisita(NombreTabla, combovalue);
            int c = 0;
            while (oDatos.pLector.Read())
            {
                Visitas v = new Visitas();
                Empleado e = new Empleado();

                if (!oDatos.pLector.IsDBNull(0))
                    v.IdVisita = oDatos.pLector.GetInt32(0);
                if (!oDatos.pLector.IsDBNull(5))
                    v.TipoVisita = oDatos.pLector.GetString(5);
                if (!oDatos.pLector.IsDBNull(4))
                    v.SolicitudGuia = oDatos.pLector.GetBoolean(4);
                if (!oDatos.pLector.IsDBNull(3))
                    v.CantidadVisitantes = oDatos.pLector.GetInt32(3);
                if (!oDatos.pLector.IsDBNull(8))
                    v.Monto = oDatos.pLector.GetDouble(8);

                if (!oDatos.pLector.IsDBNull(11))
                    e.IdEmpleado = oDatos.pLector.GetInt32(11);
                if (!oDatos.pLector.IsDBNull(13))
                    e.Nombre = oDatos.pLector.GetString(13);
                if (!oDatos.pLector.IsDBNull(14))
                    e.Apellido = oDatos.pLector.GetString(14);

                v.Empleado = e;

                vi[c] = v;
                c++;
            }
            oDatos.pLector.Close();
            oDatos.desconectar();

            lstVisitas.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                lstVisitas.Items.Add(vi[i].toStringVisitas());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Visita por el cual filtrar", "Falta seleccionar el Tipo de Visita", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return;
            }
            else
            {
                CargarListaCombo("Visita", cmbFiltro.Text);
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoVisita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVisita.SelectedIndex == 1)
            {
                nudMonto.Enabled = false;
                nudMonto.Value = 0;
            }
            else
            { 
            nudMonto.Enabled = true;
            
           }
        }

        private void cmbGuia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbGuia.SelectedIndex == 0 && cmbGuia.Enabled == true)
            //{
            //    lblGuia1.Enabled = true;
            //    lblHoras1.Enabled = true;
            //    lblMinutos1.Enabled = true;
            //    lblSegundos1.Enabled = true;
            //    cbhoras.Enabled = true;
            //    cbminutos.Enabled = true;
            //    cbsegundos.Enabled = true;
            //    lblTiempo1.Enabled = true;
            //    btnIniciar.Enabled = true;
            //    btnPausar.Enabled = true;

            //    lblGuia2.Enabled = false;
            //    lblHoras2.Enabled = false;
            //    lblMinutos2.Enabled = false;
            //    lblSegundos2.Enabled = false;
            //    cbhoras2.Enabled = false;
            //    cbminutos2.Enabled = false;
            //    cbsegundos2.Enabled = false;
            //    lblTiempo2.Enabled = false;
            //    btnIniciar2.Enabled = false;
            //    btnPausar2.Enabled = false;
            //}
            //else if (cmbGuia.SelectedIndex == 1 && cmbGuia.Enabled == true)

            //{
            //    lblGuia1.Enabled = false;
            //    lblHoras1.Enabled = false;
            //    lblMinutos1.Enabled = false;
            //    lblSegundos1.Enabled = false;
            //    cbhoras.Enabled = false;
            //    cbminutos.Enabled = false;
            //    cbsegundos.Enabled = false;
            //    lblTiempo1.Enabled = false;
            //    btnIniciar.Enabled = false;
            //    btnPausar.Enabled = false;

            //    lblGuia2.Enabled = true;
            //    lblHoras2.Enabled = true;
            //    lblMinutos2.Enabled = true;
            //    lblSegundos2.Enabled = true;
            //    cbhoras2.Enabled = true;
            //    cbminutos2.Enabled = true;
            //    cbsegundos2.Enabled = true;
            //    lblTiempo2.Enabled = true;
            //    btnIniciar2.Enabled = true;
            //    btnPausar2.Enabled = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarLista("Visita");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LinkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAux form = new frmAux(3);
            if (form.siNo())
            {
                this.Dispose();
            }
        }
    }
    //End Graphic User Interface Design
}