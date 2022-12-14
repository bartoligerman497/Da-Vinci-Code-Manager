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
    public partial class frmGuiaVirtual : Form
    {
        public frmGuiaVirtual()
        {
            InitializeComponent();
        }

        private void frmGuiaVirtual_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmVisitas nom = new frmVisitas();
            nom.Show();
            Dispose();
        }

        private void btnCerrarGuiaVirtual_Click(object sender, EventArgs e)
        {
            frmVisitas nom = new frmVisitas();
            nom.Show();
            Dispose();
        }
    }
}
