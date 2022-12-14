namespace Da_Vinci_Code_Manager
{
    partial class frmImprimirObras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirObras));
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvConsulta2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altocmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anchocmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistraciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargadoDelRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDeIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vImprimirObraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.museoDataSet = new Da_Vinci_Code_Manager.MuseoDataSet();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAtras = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vImprimirObraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vImprimirObraTableAdapter = new Da_Vinci_Code_Manager.MuseoDataSetTableAdapters.vImprimirObraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImprimirObraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.museoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImprimirObraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 50;
            this.toolTip2.AutoPopDelay = 10000;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.ReshowDelay = 10;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip2.ToolTipTitle = "Advertencia:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Location = new System.Drawing.Point(1011, 698);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 58);
            this.btnImprimir.TabIndex = 110;
            this.toolTip1.SetToolTip(this.btnImprimir, "Haga click para Imprimir la nomina");
            this.toolTip2.SetToolTip(this.btnImprimir, "Asegurese de tener conectada la impresora, por defecto se guarda como pdf");
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.Document = this.printDocument2;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument2;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument2;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Consejo:";
            // 
            // dgvConsulta2
            // 
            this.dgvConsulta2.AllowUserToAddRows = false;
            this.dgvConsulta2.AllowUserToDeleteRows = false;
            this.dgvConsulta2.AllowUserToOrderColumns = true;
            this.dgvConsulta2.AllowUserToResizeRows = false;
            this.dgvConsulta2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta2.AutoGenerateColumns = false;
            this.dgvConsulta2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConsulta2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.obraDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.artistaDataGridViewTextBoxColumn,
            this.estiloDataGridViewTextBoxColumn,
            this.tipoDeObraDataGridViewTextBoxColumn,
            this.fechaCreaciónDataGridViewTextBoxColumn,
            this.altocmDataGridViewTextBoxColumn,
            this.anchocmDataGridViewTextBoxColumn,
            this.fechaRegistraciónDataGridViewTextBoxColumn,
            this.encargadoDelRegistroDataGridViewTextBoxColumn,
            this.valuaciónDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.motivoDeIngresoDataGridViewTextBoxColumn});
            this.dgvConsulta2.DataSource = this.vImprimirObraBindingSource1;
            this.dgvConsulta2.Location = new System.Drawing.Point(39, 56);
            this.dgvConsulta2.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsulta2.Name = "dgvConsulta2";
            this.dgvConsulta2.ReadOnly = true;
            this.dgvConsulta2.RowHeadersVisible = false;
            this.dgvConsulta2.RowHeadersWidth = 51;
            this.dgvConsulta2.ShowEditingIcon = false;
            this.dgvConsulta2.Size = new System.Drawing.Size(1424, 617);
            this.dgvConsulta2.TabIndex = 108;
            this.dgvConsulta2.TabStop = false;
            this.toolTip1.SetToolTip(this.dgvConsulta2, "Recuerde que puede interactuar con la Tabla");
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obraDataGridViewTextBoxColumn
            // 
            this.obraDataGridViewTextBoxColumn.DataPropertyName = "Obra";
            this.obraDataGridViewTextBoxColumn.HeaderText = "Obra";
            this.obraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.obraDataGridViewTextBoxColumn.Name = "obraDataGridViewTextBoxColumn";
            this.obraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistaDataGridViewTextBoxColumn
            // 
            this.artistaDataGridViewTextBoxColumn.DataPropertyName = "Artista";
            this.artistaDataGridViewTextBoxColumn.HeaderText = "Artista";
            this.artistaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artistaDataGridViewTextBoxColumn.Name = "artistaDataGridViewTextBoxColumn";
            this.artistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estiloDataGridViewTextBoxColumn
            // 
            this.estiloDataGridViewTextBoxColumn.DataPropertyName = "Estilo";
            this.estiloDataGridViewTextBoxColumn.HeaderText = "Estilo";
            this.estiloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estiloDataGridViewTextBoxColumn.Name = "estiloDataGridViewTextBoxColumn";
            this.estiloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDeObraDataGridViewTextBoxColumn
            // 
            this.tipoDeObraDataGridViewTextBoxColumn.DataPropertyName = "Tipo de Obra";
            this.tipoDeObraDataGridViewTextBoxColumn.HeaderText = "Tipo de Obra";
            this.tipoDeObraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDeObraDataGridViewTextBoxColumn.Name = "tipoDeObraDataGridViewTextBoxColumn";
            this.tipoDeObraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreaciónDataGridViewTextBoxColumn
            // 
            this.fechaCreaciónDataGridViewTextBoxColumn.DataPropertyName = "Fecha creación";
            this.fechaCreaciónDataGridViewTextBoxColumn.HeaderText = "Fecha creación";
            this.fechaCreaciónDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCreaciónDataGridViewTextBoxColumn.Name = "fechaCreaciónDataGridViewTextBoxColumn";
            this.fechaCreaciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altocmDataGridViewTextBoxColumn
            // 
            this.altocmDataGridViewTextBoxColumn.DataPropertyName = "Alto (cm)";
            this.altocmDataGridViewTextBoxColumn.HeaderText = "Alto (cm)";
            this.altocmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.altocmDataGridViewTextBoxColumn.Name = "altocmDataGridViewTextBoxColumn";
            this.altocmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anchocmDataGridViewTextBoxColumn
            // 
            this.anchocmDataGridViewTextBoxColumn.DataPropertyName = "Ancho (cm)";
            this.anchocmDataGridViewTextBoxColumn.HeaderText = "Ancho (cm)";
            this.anchocmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anchocmDataGridViewTextBoxColumn.Name = "anchocmDataGridViewTextBoxColumn";
            this.anchocmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegistraciónDataGridViewTextBoxColumn
            // 
            this.fechaRegistraciónDataGridViewTextBoxColumn.DataPropertyName = "Fecha registración";
            this.fechaRegistraciónDataGridViewTextBoxColumn.HeaderText = "Fecha registración";
            this.fechaRegistraciónDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaRegistraciónDataGridViewTextBoxColumn.Name = "fechaRegistraciónDataGridViewTextBoxColumn";
            this.fechaRegistraciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encargadoDelRegistroDataGridViewTextBoxColumn
            // 
            this.encargadoDelRegistroDataGridViewTextBoxColumn.DataPropertyName = "Encargado del registro";
            this.encargadoDelRegistroDataGridViewTextBoxColumn.HeaderText = "Encargado del registro";
            this.encargadoDelRegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.encargadoDelRegistroDataGridViewTextBoxColumn.Name = "encargadoDelRegistroDataGridViewTextBoxColumn";
            this.encargadoDelRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valuaciónDataGridViewTextBoxColumn
            // 
            this.valuaciónDataGridViewTextBoxColumn.DataPropertyName = "Valuación";
            this.valuaciónDataGridViewTextBoxColumn.HeaderText = "Valuación";
            this.valuaciónDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valuaciónDataGridViewTextBoxColumn.Name = "valuaciónDataGridViewTextBoxColumn";
            this.valuaciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            this.destinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motivoDeIngresoDataGridViewTextBoxColumn
            // 
            this.motivoDeIngresoDataGridViewTextBoxColumn.DataPropertyName = "Motivo de Ingreso";
            this.motivoDeIngresoDataGridViewTextBoxColumn.HeaderText = "Motivo de Ingreso";
            this.motivoDeIngresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motivoDeIngresoDataGridViewTextBoxColumn.Name = "motivoDeIngresoDataGridViewTextBoxColumn";
            this.motivoDeIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vImprimirObraBindingSource1
            // 
            this.vImprimirObraBindingSource1.DataMember = "vImprimirObra";
            this.vImprimirObraBindingSource1.DataSource = this.museoDataSet;
            // 
            // museoDataSet
            // 
            this.museoDataSet.DataSetName = "MuseoDataSet";
            this.museoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 50;
            this.toolTip3.AutoPopDelay = 10000;
            this.toolTip3.InitialDelay = 50;
            this.toolTip3.ReshowDelay = 10;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Location = new System.Drawing.Point(1202, 699);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(71, 58);
            this.btnAtras.TabIndex = 111;
            this.toolTip3.SetToolTip(this.btnAtras, "Click para volver a Obras");
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(1211, 679);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 17);
            this.label23.TabIndex = 112;
            this.label23.Text = "ATRÁS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(673, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "NOMINA DE OBRAS";
            // 
            // vImprimirObraBindingSource
            // 
            this.vImprimirObraBindingSource.DataMember = "vImprimirObra";
            this.vImprimirObraBindingSource.DataSource = this.museoDataSet;
            // 
            // vImprimirObraTableAdapter
            // 
            this.vImprimirObraTableAdapter.ClearBeforeFill = true;
            // 
            // frmImprimirObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1502, 768);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsulta2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmImprimirObras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImprimirObras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImprimirObras_FormClosing);
            this.Load += new System.EventHandler(this.frmImprimirObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImprimirObraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.museoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImprimirObraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsulta2;
        private MuseoDataSet museoDataSet;
        private System.Windows.Forms.BindingSource vImprimirObraBindingSource;
        private MuseoDataSetTableAdapters.vImprimirObraTableAdapter vImprimirObraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altocmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anchocmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistraciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargadoDelRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDeIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vImprimirObraBindingSource1;
    }
}