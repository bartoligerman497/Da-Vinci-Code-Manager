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
using System.Windows.Forms.VisualStyles;


namespace Da_Vinci_Code_Manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //Initialize Design Components
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            cmbTipoUsuario.ContextMenu = new ContextMenu(); //disable mouse right-click
            txtPassword.ContextMenu = new ContextMenu();
            txtUsuario.ContextMenu = new ContextMenu();
            //DON'T TOUCH
        }
        private AccesoDatos oDatos = new AccesoDatos(@"Data Source =.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Museo.mdf;Integrated Security = True; Connect Timeout = 30");

        private void Login_Load(object sender, EventArgs e)
        {
            oDatos.CargarCombo(cmbTipoUsuario, "TipoUsuario");
        }

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
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();

            if (validar())
            {
                oDatos.leerUsuario(txtPassword.Text, txtUsuario.Text, Convert.ToInt32(cmbTipoUsuario.SelectedValue));

                if (oDatos.validarRegistro())
                {
                    this.Hide();
                    agregarMensajeAlineado(2, "Acceso Concedido.", null);
                    {
                        if (cmbTipoUsuario.SelectedIndex == 0)
                        {
                            frmVisitas form = new frmVisitas();
                            form.lblUsuario.Text = "¡Bienvenido, " + txtUsuario.Text + "!";
                            form.Show();
                            this.Hide();
                        }
                        if (cmbTipoUsuario.SelectedIndex == 1)
                        {
                            frmObras form = new frmObras();
                            form.lblUsuario.Text = "¡Bienvenido, " + txtUsuario.Text + "!";
                            form.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Usuario no encontrado o contraseña incorrecta, asegurese también de haber seleccionado el tipo de usuario correcto", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    oDatos.desconectar();
                    this.Show();
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    cmbTipoUsuario.Focus();
                    return;
                }
            }

        }

        private bool validar()
        {
            if (cmbTipoUsuario.SelectedIndex == -1)
            {
                agregarMensajeAlineado(0, "Debe seleccionar un tipo de usuario.", cmbTipoUsuario);
                return false;
            }
            else if (txtUsuario.Text == "")
            {
                agregarMensajeAlineado(0, "Ingrese un nombre de usuario.", txtUsuario);
                return false;
            }
            else if (txtPassword.Text == "")
            {
                agregarMensajeAlineado(0, "Ingrese una contraseña.", txtPassword);
                return false;
            }
            else
            {

                return true;
            }

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

        //Disable keypress in combobox and Ctrl + V, Ctrl + X
        private void CmbTipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public int xClick = 0, yClick = 0;

        private void moverBarraConMouse(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { xClick = e.X; yClick = e.Y; } else { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
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

        private void ptbBarra_MouseMove(object sender, MouseEventArgs e)
        {
            moverBarraConMouse(e);
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            moverBarraConMouse(e);
        }

        private const int WS_MINIMIZEBOX = 0x20000;
        private const int CS_DBLCLKS = 0x8;

        private void BtnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.IngresarMod;
        }

        private void BtnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Boton_Ingresar;
        }

        private void BtnIngresar_Enter(object sender, EventArgs e)
        {
            btnIngresar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.IngresarMod;
        }

        private void BtnIngresar_Leave(object sender, EventArgs e)
        {
            btnIngresar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Boton_Ingresar;
        }

        private void CmbTipoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

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

        //End Graphic User Interface Design
    }
}