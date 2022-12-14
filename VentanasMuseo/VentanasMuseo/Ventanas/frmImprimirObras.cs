using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da_Vinci_Code_Manager {
    public partial class frmImprimirObras : Form {
        public frmImprimirObras () {
            InitializeComponent ();
        }

        private void frmImprimirObras_Load (object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'museoDataSet.vImprimirObra' Puede moverla o quitarla según sea necesario.
            this.vImprimirObraTableAdapter.Fill (this.museoDataSet.vImprimirObra);

        }

        Bitmap bmp;
        private void btnImprimir_Click (object sender, EventArgs e) {
            try {
                int height = dgvConsulta2.Height;
                dgvConsulta2.Height = dgvConsulta2.RowCount * dgvConsulta2.RowTemplate.Height * 2;
                bmp = new Bitmap (dgvConsulta2.Width, dgvConsulta2.Height);
                dgvConsulta2.DrawToBitmap (bmp, new Rectangle (0, 0, dgvConsulta2.Width, dgvConsulta2.Height));
                dgvConsulta2.Height = height;
                //printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize ("PaperA4", 840, 1180);
                printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 1180, 1100);
                printDocument2.DefaultPageSettings.Landscape = true;
                printPreviewDialog1.ShowDialog ();
            } catch (System.Drawing.Printing.InvalidPrinterException) {
                MessageBox.Show ("POR FAVOR, RECUERDE SIEMPRE CONECTAR LA IMPRESORA ANTES DE EJECUTAR EL PROGRAMA. CERRANDO... ABRA NUEVAMENTE EL PROGRAMA", "ERROR");
                Application.ExitThread ();
            }

        }

        private void printDocument2_PrintPage (object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            e.Graphics.DrawImage (bmp, 0, 0);
        }

        private void btnAtras_Click_1 (object sender, EventArgs e) {
            frmObras nom = new frmObras();
            nom.Show();
            Dispose();
        }

        private void frmImprimirObras_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmObras nom = new frmObras();
            nom.Show();
            Dispose();
        }
    }
}