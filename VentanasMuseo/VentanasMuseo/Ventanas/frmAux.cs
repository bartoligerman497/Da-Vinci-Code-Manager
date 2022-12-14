using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da_Vinci_Code_Manager
{
    public partial class frmAux : Form
    {
        private int f = 0;

        public frmAux()
        {
            InitializeComponent();
        }

        public frmAux(int i)
        {
            InitializeComponent();
            switch (i)
            {
                case 0:

                    this.Size = new Size(310, 155);

                    picIconoMensaje.Visible = true;
                    lblMensaje.Image = Resource1.barramona;
                    lblMensaje.BorderStyle = BorderStyle.FixedSingle;
                    this.BackgroundImage = null;
                    btnCancelar.Visible = false;
                    btnAceptar.Left = (this.ClientSize.Width - btnAceptar.Width) / 2;
                    btnAceptar.Top = (this.ClientSize.Height - btnAceptar.Height) - 20;
                    btnAceptar.Text = "Aceptar";
                    lblMensaje.Text = "Advertencia";
                    break;

                case 1:
                    this.Size = new Size(310, 208);
                    break;

                case 2:
                    this.Size = new Size(310, 155);

                    picIconoMensaje.Visible = true;
                    lblMensaje.Image = Resource1.barramona;
                    lblMensaje.BorderStyle = BorderStyle.FixedSingle;
                    this.BackgroundImage = null;
                    btnCancelar.Visible = false;
                    btnAceptar.Left = (this.ClientSize.Width - btnAceptar.Width) / 2;
                    btnAceptar.Top = (this.ClientSize.Height - btnAceptar.Height) - 20;
                    picIconoMensaje.Image = Resource1.tick;
                    btnAceptar.Text = "Aceptar";
                    lblMensaje.Text = "Éxito";
                    break;

                case 3:
                    //f = 0;
                    this.Size = new Size(310, 155);
                    lblMensaje.Text = "¿Seguro?";
                    lblMensaje.BorderStyle = BorderStyle.FixedSingle;
                    lblMensaje.Image = Resource1.barramona;
                    lblContenido.Left = (ClientSize.Width - lblContenido.Width) / 2;
                    lblContenido.Top = ((ClientSize.Height - lblContenido.Height) / 3) + 15;
                    lblContenido.Text = "¿Desea Cerrar Sesión?";
                    btnAceptar.Text = "Sí";
                    btnCancelar.Text = "No";
                    btnAceptar.Size = new Size(72, 24);
                    btnCancelar.Size = new Size(72, 24);
                    btnAceptar.Location = new Point(30, 100);
                    btnCancelar.Location = new Point(208, 100);
                    BackgroundImage = null;
                    ShowDialog();
                    if (siNo())
                    {
                        frmLogin login = new frmLogin();
                        login.Show();
                        //this.Dispose();
                    }

                    break;

                default:

                    break;
            }
        }

        private void frmAux_Load(object sender, EventArgs e)
        {
        }

        public bool siNo()
        {
            if (f == 1)
                return true;
            else
                return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if (f == 2)
            //{
            //    Login login = new Login();
            //    login.Show();
            //    Dispose();
            //}
            //else
            //{
            f = 1;

            Dispose();
            //}
        }

        private void btnAcaptarDesarrollo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}