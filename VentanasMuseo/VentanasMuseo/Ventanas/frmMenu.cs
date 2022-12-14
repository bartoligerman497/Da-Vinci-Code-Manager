using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Da_Vinci_Code_Manager
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //Initialize Design Components
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            lblFecha.Text = DateTime.Now.ToLongDateString();
            //DON'T TOUCH
        }

        //Star Graphic User Interface Design
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
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
                cp.Style |= WS_MINIMIZEBOX;//
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        public int xClick = 0, yClick = 0;

        private void moverBarraConMouse(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
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

        private void BtnVisitas_Click(object sender, EventArgs e)
        {
            frmVisitas visitas = new frmVisitas();
            visitas.lblUsuario.Visible = false;
            visitas.picIconUser.Visible = false;
            visitas.linkCerrarSesion.Visible = false;
            visitas.lblUsuarioEnMenu.Text = this.lblUsuario.Text;
            visitas.Show();
            this.Hide();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Left = this.Width - lblUsuario.Width;
            picIconUser.Location = new Point(lblUsuario.Location.X - 20, picIconUser.Location.Y);
        }

        private void BtnObras_Click(object sender, EventArgs e)
        {
            frmObras obras = new frmObras();
            obras.lblUsuario.Visible = false;
            obras.picIconUser.Visible = false;
            obras.linkCerrarSesion.Visible = false;
            obras.lblUsuarioEnMenu.Text = this.lblUsuario.Text;
            obras.Show();
            this.Hide();
        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            frmDeposito deposito = new frmDeposito();
            deposito.lblUsuario.Visible = false;
            deposito.picIconUser.Visible = false;
            deposito.linkCerrarSesion.Visible = false;
            deposito.lblUsuarioEnMenu.Text = this.lblUsuario.Text;
            deposito.Show();
            this.Hide();
        }

        private void BtnExposiciones_Click(object sender, EventArgs e)
        {
            frmExposicion exposicion = new frmExposicion();
            exposicion.lblUsuario.Visible = false;
            exposicion.picIconUser.Visible = false;
            exposicion.linkCerrarSesion.Visible = false;
            exposicion.lblUsuarioEnMenu.Text = this.lblUsuario.Text;
            exposicion.Show();
            this.Hide();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicMinimizar_MouseEnter(object sender, EventArgs e)
        {
            picMinimizar.Image = Da_Vinci_Code_Manager.Resource1.Minimize_Box_Blue_modified2;
            //picMinimizar.Location = new Point(885, -4);
        }

        private void PicMinimizar_Click(object sender, EventArgs e)
        {
            //picMinimizar.Image = VentanasMuseo.Resource1.blue_box_click;
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

        private void LinkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAux form = new frmAux(3);
            if (form.siNo())
            {
                this.Dispose();
            }
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            frmAux frm = new frmAux(1);
            frm.ShowDialog();
            if (frm.siNo())
            {
                Application.ExitThread();
            }
        }

        //End Graphic User Interface Design
    }
}