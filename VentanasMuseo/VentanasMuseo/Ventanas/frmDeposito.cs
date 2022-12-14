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
    public partial class frmDeposito : Form
    {
        public frmDeposito()
        {
            InitializeComponent();
            //Initialize Design Components
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            //DON'T TOUCH
        }

        private void Deposito_Load(object sender, EventArgs e)
        {
            lblUsuario.Left = this.Width - lblUsuario.Width;
            picIconUser.Location = new Point(lblUsuario.Location.X - 20, picIconUser.Location.Y);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ptbBarra.Focus();
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

        private void BtnNuevo_MouseEnter(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Plus__OrangeMod1;
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Plus__Orange;
        }

        private void BtnNuevo_Enter(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Plus__OrangeMod1;
        }

        private void BtnNuevo_Leave(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            btnNuevo.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Plus__Orange;
        }

        private void BtnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Pencil3Mod1;
        }

        private void BtnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Pencil3;
        }

        private void BtnModificar_Enter(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Pencil3Mod1;
        }

        private void BtnModificar_Leave(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            btnModificar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Pencil3;
        }

        private void BtnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.DeleteRedMod1;
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.DeleteRed;
        }

        private void BtnEliminar_Enter(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.DeleteRedMod1;
        }

        private void BtnEliminar_Leave(object sender, EventArgs e)
        {
            ptbBarra.Focus();
            btnEliminar.BackgroundImage = Da_Vinci_Code_Manager.Resource1.DeleteRed;
        }

        private void BtnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Da_Vinci_Code_Manager.Resource1.HomeMod1;
        }

        private void BtnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Home;
        }

        private void BtnMenu_Enter(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Da_Vinci_Code_Manager.Resource1.HomeMod1;
        }

        private void BtnMenu_Leave(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Da_Vinci_Code_Manager.Resource1.Home;
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

        private void FrmDeposito_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PicMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Dispose();
        }

        private void LinkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAux form = new frmAux(3);
            if (form.siNo())
            {
                this.Dispose();
            }
        }

        private void GroupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkRed, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 116, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        //End Graphic User Interface Design
    }
}