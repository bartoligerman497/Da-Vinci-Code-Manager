namespace Da_Vinci_Code_Manager
{
    partial class frmVisitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitas));
            this.cmbTipoVisita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGuia = new System.Windows.Forms.ComboBox();
            this.lblGuia2 = new System.Windows.Forms.Label();
            this.lblGuia1 = new System.Windows.Forms.Label();
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.lblSegundos2 = new System.Windows.Forms.Label();
            this.btnPausar2 = new System.Windows.Forms.Button();
            this.lblMinutos2 = new System.Windows.Forms.Label();
            this.lblHoras2 = new System.Windows.Forms.Label();
            this.btnIniciar2 = new System.Windows.Forms.Button();
            this.cbsegundos2 = new System.Windows.Forms.ComboBox();
            this.cbminutos2 = new System.Windows.Forms.ComboBox();
            this.cbhoras2 = new System.Windows.Forms.ComboBox();
            this.lblTiempo1 = new System.Windows.Forms.Label();
            this.lblSegundos1 = new System.Windows.Forms.Label();
            this.btnPausar = new System.Windows.Forms.Button();
            this.lblMinutos1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHoras1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cbsegundos = new System.Windows.Forms.ComboBox();
            this.nudCantidadVisitantes = new System.Windows.Forms.NumericUpDown();
            this.cbminutos = new System.Windows.Forms.ComboBox();
            this.cbhoras = new System.Windows.Forms.ComboBox();
            this.chkSolicitudGuia = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptbBarra = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picIconUser = new System.Windows.Forms.PictureBox();
            this.lblUsuarioEnMenu = new System.Windows.Forms.Label();
            this.lstVisitas = new System.Windows.Forms.ListBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnGuardar = new Da_Vinci_Code_Manager.ButtonZ();
            this.btnCancelar = new Da_Vinci_Code_Manager.ButtonZ();
            this.btnEliminar = new Da_Vinci_Code_Manager.ButtonZ();
            this.btnModificar = new Da_Vinci_Code_Manager.ButtonZ();
            this.btnNuevo = new Da_Vinci_Code_Manager.ButtonZ();
            this.btnGuiaVirtual = new Da_Vinci_Code_Manager.ButtonZ();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVisitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoVisita
            // 
            this.cmbTipoVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVisita.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVisita.FormattingEnabled = true;
            this.cmbTipoVisita.Items.AddRange(new object[] {
            "Común",
            "Especial"});
            this.cmbTipoVisita.Location = new System.Drawing.Point(207, 59);
            this.cmbTipoVisita.Name = "cmbTipoVisita";
            this.cmbTipoVisita.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoVisita.TabIndex = 0;
            this.cmbTipoVisita.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVisita_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Visita:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbGuia);
            this.groupBox1.Controls.Add(this.btnGuiaVirtual);
            this.groupBox1.Controls.Add(this.lblGuia2);
            this.groupBox1.Controls.Add(this.lblGuia1);
            this.groupBox1.Controls.Add(this.lblTiempo2);
            this.groupBox1.Controls.Add(this.lblSegundos2);
            this.groupBox1.Controls.Add(this.btnPausar2);
            this.groupBox1.Controls.Add(this.lblMinutos2);
            this.groupBox1.Controls.Add(this.lblHoras2);
            this.groupBox1.Controls.Add(this.btnIniciar2);
            this.groupBox1.Controls.Add(this.cbsegundos2);
            this.groupBox1.Controls.Add(this.cbminutos2);
            this.groupBox1.Controls.Add(this.cbhoras2);
            this.groupBox1.Controls.Add(this.lblTiempo1);
            this.groupBox1.Controls.Add(this.lblSegundos1);
            this.groupBox1.Controls.Add(this.btnPausar);
            this.groupBox1.Controls.Add(this.lblMinutos1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblHoras1);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.cbsegundos);
            this.groupBox1.Controls.Add(this.nudCantidadVisitantes);
            this.groupBox1.Controls.Add(this.cbminutos);
            this.groupBox1.Controls.Add(this.cbhoras);
            this.groupBox1.Controls.Add(this.chkSolicitudGuia);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudMonto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipoVisita);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 562);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visita";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBox1_Paint);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbGuia
            // 
            this.cmbGuia.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuia.FormattingEnabled = true;
            this.cmbGuia.Items.AddRange(new object[] {
            "Seleccionar"});
            this.cmbGuia.Location = new System.Drawing.Point(53, 245);
            this.cmbGuia.Name = "cmbGuia";
            this.cmbGuia.Size = new System.Drawing.Size(224, 23);
            this.cmbGuia.TabIndex = 137;
            this.cmbGuia.Text = "Seleccionar";
            this.cmbGuia.SelectedIndexChanged += new System.EventHandler(this.cmbGuia_SelectedIndexChanged);
            // 
            // lblGuia2
            // 
            this.lblGuia2.AutoSize = true;
            this.lblGuia2.Location = new System.Drawing.Point(31, 436);
            this.lblGuia2.Name = "lblGuia2";
            this.lblGuia2.Size = new System.Drawing.Size(57, 16);
            this.lblGuia2.TabIndex = 136;
            this.lblGuia2.Text = "Guia 2:";
            // 
            // lblGuia1
            // 
            this.lblGuia1.AutoSize = true;
            this.lblGuia1.Location = new System.Drawing.Point(35, 293);
            this.lblGuia1.Name = "lblGuia1";
            this.lblGuia1.Size = new System.Drawing.Size(57, 16);
            this.lblGuia1.TabIndex = 135;
            this.lblGuia1.Text = "Guia 1:";
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Italic);
            this.lblTiempo2.Location = new System.Drawing.Point(102, 424);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(146, 46);
            this.lblTiempo2.TabIndex = 134;
            this.lblTiempo2.Text = "00:00:00";
            // 
            // lblSegundos2
            // 
            this.lblSegundos2.AutoSize = true;
            this.lblSegundos2.Location = new System.Drawing.Point(248, 475);
            this.lblSegundos2.Name = "lblSegundos2";
            this.lblSegundos2.Size = new System.Drawing.Size(74, 16);
            this.lblSegundos2.TabIndex = 131;
            this.lblSegundos2.Text = "Segundos";
            // 
            // btnPausar2
            // 
            this.btnPausar2.Location = new System.Drawing.Point(232, 528);
            this.btnPausar2.Name = "btnPausar2";
            this.btnPausar2.Size = new System.Drawing.Size(97, 23);
            this.btnPausar2.TabIndex = 133;
            this.btnPausar2.Text = "Pausar";
            this.btnPausar2.UseVisualStyleBackColor = true;
            // 
            // lblMinutos2
            // 
            this.lblMinutos2.AutoSize = true;
            this.lblMinutos2.Location = new System.Drawing.Point(146, 475);
            this.lblMinutos2.Name = "lblMinutos2";
            this.lblMinutos2.Size = new System.Drawing.Size(61, 16);
            this.lblMinutos2.TabIndex = 130;
            this.lblMinutos2.Text = "Minutos";
            // 
            // lblHoras2
            // 
            this.lblHoras2.AutoSize = true;
            this.lblHoras2.Location = new System.Drawing.Point(56, 475);
            this.lblHoras2.Name = "lblHoras2";
            this.lblHoras2.Size = new System.Drawing.Size(46, 16);
            this.lblHoras2.TabIndex = 129;
            this.lblHoras2.Text = "Horas";
            // 
            // btnIniciar2
            // 
            this.btnIniciar2.Location = new System.Drawing.Point(20, 528);
            this.btnIniciar2.Name = "btnIniciar2";
            this.btnIniciar2.Size = new System.Drawing.Size(111, 23);
            this.btnIniciar2.TabIndex = 132;
            this.btnIniciar2.Text = "Iniciar";
            this.btnIniciar2.UseVisualStyleBackColor = true;
            // 
            // cbsegundos2
            // 
            this.cbsegundos2.FormattingEnabled = true;
            this.cbsegundos2.Location = new System.Drawing.Point(232, 492);
            this.cbsegundos2.Name = "cbsegundos2";
            this.cbsegundos2.Size = new System.Drawing.Size(97, 24);
            this.cbsegundos2.TabIndex = 128;
            this.cbsegundos2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoEscribirSoloElegir_KeyPress);
            // 
            // cbminutos2
            // 
            this.cbminutos2.FormattingEnabled = true;
            this.cbminutos2.Location = new System.Drawing.Point(129, 492);
            this.cbminutos2.Name = "cbminutos2";
            this.cbminutos2.Size = new System.Drawing.Size(97, 24);
            this.cbminutos2.TabIndex = 127;
            this.cbminutos2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoEscribirSoloElegir_KeyPress);
            // 
            // cbhoras2
            // 
            this.cbhoras2.FormattingEnabled = true;
            this.cbhoras2.Location = new System.Drawing.Point(20, 492);
            this.cbhoras2.Name = "cbhoras2";
            this.cbhoras2.Size = new System.Drawing.Size(103, 24);
            this.cbhoras2.TabIndex = 126;
            this.cbhoras2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoEscribirSoloElegir_KeyPress);
            // 
            // lblTiempo1
            // 
            this.lblTiempo1.AutoSize = true;
            this.lblTiempo1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo1.Location = new System.Drawing.Point(104, 280);
            this.lblTiempo1.Name = "lblTiempo1";
            this.lblTiempo1.Size = new System.Drawing.Size(146, 46);
            this.lblTiempo1.TabIndex = 125;
            this.lblTiempo1.Text = "00:00:00";
            // 
            // lblSegundos1
            // 
            this.lblSegundos1.AutoSize = true;
            this.lblSegundos1.Location = new System.Drawing.Point(247, 335);
            this.lblSegundos1.Name = "lblSegundos1";
            this.lblSegundos1.Size = new System.Drawing.Size(74, 16);
            this.lblSegundos1.TabIndex = 122;
            this.lblSegundos1.Text = "Segundos";
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(231, 388);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(97, 23);
            this.btnPausar.TabIndex = 124;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // lblMinutos1
            // 
            this.lblMinutos1.AutoSize = true;
            this.lblMinutos1.Location = new System.Drawing.Point(145, 335);
            this.lblMinutos1.Name = "lblMinutos1";
            this.lblMinutos1.Size = new System.Drawing.Size(61, 16);
            this.lblMinutos1.TabIndex = 121;
            this.lblMinutos1.Text = "Minutos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(28, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "Cantidad visitantes:";
            // 
            // lblHoras1
            // 
            this.lblHoras1.AutoSize = true;
            this.lblHoras1.Location = new System.Drawing.Point(55, 335);
            this.lblHoras1.Name = "lblHoras1";
            this.lblHoras1.Size = new System.Drawing.Size(46, 16);
            this.lblHoras1.TabIndex = 120;
            this.lblHoras1.Text = "Horas";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(19, 388);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(112, 23);
            this.btnIniciar.TabIndex = 123;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cbsegundos
            // 
            this.cbsegundos.FormattingEnabled = true;
            this.cbsegundos.Location = new System.Drawing.Point(231, 352);
            this.cbsegundos.Name = "cbsegundos";
            this.cbsegundos.Size = new System.Drawing.Size(97, 24);
            this.cbsegundos.TabIndex = 119;
            this.cbsegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoEscribirSoloElegir_KeyPress);
            // 
            // nudCantidadVisitantes
            // 
            this.nudCantidadVisitantes.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadVisitantes.Location = new System.Drawing.Point(207, 99);
            this.nudCantidadVisitantes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCantidadVisitantes.Name = "nudCantidadVisitantes";
            this.nudCantidadVisitantes.Size = new System.Drawing.Size(82, 23);
            this.nudCantidadVisitantes.TabIndex = 2;
            // 
            // cbminutos
            // 
            this.cbminutos.FormattingEnabled = true;
            this.cbminutos.Location = new System.Drawing.Point(128, 352);
            this.cbminutos.Name = "cbminutos";
            this.cbminutos.Size = new System.Drawing.Size(97, 24);
            this.cbminutos.TabIndex = 118;
            this.cbminutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoEscribirSoloElegir_KeyPress);
            // 
            // cbhoras
            // 
            this.cbhoras.FormattingEnabled = true;
            this.cbhoras.Location = new System.Drawing.Point(19, 352);
            this.cbhoras.Name = "cbhoras";
            this.cbhoras.Size = new System.Drawing.Size(103, 24);
            this.cbhoras.TabIndex = 117;
            this.cbhoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoEscribirSoloElegir_KeyPress);
            // 
            // chkSolicitudGuia
            // 
            this.chkSolicitudGuia.AutoSize = true;
            this.chkSolicitudGuia.Location = new System.Drawing.Point(195, 190);
            this.chkSolicitudGuia.Name = "chkSolicitudGuia";
            this.chkSolicitudGuia.Size = new System.Drawing.Size(18, 17);
            this.chkSolicitudGuia.TabIndex = 1;
            this.chkSolicitudGuia.UseVisualStyleBackColor = true;
            this.chkSolicitudGuia.CheckedChanged += new System.EventHandler(this.chkSolicitudGuia_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(59, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 16);
            this.label18.TabIndex = 108;
            this.label18.Text = "¿Solicitar Guía?:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFecha.Location = new System.Drawing.Point(207, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(30, 19);
            this.lblFecha.TabIndex = 105;
            this.lblFecha.Text = "???";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(128, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 104;
            this.label13.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(50, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Seleccionar Guía:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(120, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto:";
            // 
            // nudMonto
            // 
            this.nudMonto.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonto.Location = new System.Drawing.Point(207, 134);
            this.nudMonto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(82, 23);
            this.nudMonto.TabIndex = 3;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.Salmon;
            this.picCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCerrar.BackgroundImage")));
            this.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(934, -5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(68, 44);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 43;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.PicCerrar_Click);
            this.picCerrar.MouseEnter += new System.EventHandler(this.PicCerrar_MouseEnter);
            this.picCerrar.MouseLeave += new System.EventHandler(this.PicCerrar_MouseLeave);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Salmon;
            this.picMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.BackgroundImage")));
            this.picMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(882, -5);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(53, 44);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 45;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.PicMinimizar_Click);
            this.picMinimizar.MouseEnter += new System.EventHandler(this.PicMinimizar_MouseEnter);
            this.picMinimizar.MouseLeave += new System.EventHandler(this.PicMinimizar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseMove);
            // 
            // ptbBarra
            // 
            this.ptbBarra.BackColor = System.Drawing.Color.Silver;
            this.ptbBarra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbBarra.BackgroundImage")));
            this.ptbBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbBarra.Location = new System.Drawing.Point(-17, -4);
            this.ptbBarra.Name = "ptbBarra";
            this.ptbBarra.Size = new System.Drawing.Size(1015, 54);
            this.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbBarra.TabIndex = 41;
            this.ptbBarra.TabStop = false;
            this.ptbBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbBarra_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(458, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_MouseMove);
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar.Font = new System.Drawing.Font("Clarendon BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(374, 765);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(92, 20);
            this.lblModificar.TabIndex = 93;
            this.lblModificar.Text = "Modificar";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Font = new System.Drawing.Font("Clarendon BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(792, 763);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(85, 20);
            this.lblEliminar.TabIndex = 92;
            this.lblEliminar.Text = "Eliminar";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevo.Font = new System.Drawing.Font("Clarendon BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.Location = new System.Drawing.Point(64, 765);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(62, 20);
            this.lblNuevo.TabIndex = 90;
            this.lblNuevo.Text = "Nuevo";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.Gold;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Nuevo";
            // 
            // linkCerrarSesion
            // 
            this.linkCerrarSesion.AutoSize = true;
            this.linkCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.linkCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkCerrarSesion.Location = new System.Drawing.Point(902, 75);
            this.linkCerrarSesion.Name = "linkCerrarSesion";
            this.linkCerrarSesion.Size = new System.Drawing.Size(95, 17);
            this.linkCerrarSesion.TabIndex = 4;
            this.linkCerrarSesion.TabStop = true;
            this.linkCerrarSesion.Text = "Cerrar Sesión";
            this.linkCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCerrarSesion_LinkClicked);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(765, 54);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 20);
            this.lblUsuario.TabIndex = 96;
            this.lblUsuario.Text = "label5";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIconUser
            // 
            this.picIconUser.BackColor = System.Drawing.Color.Transparent;
            this.picIconUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIconUser.BackgroundImage")));
            this.picIconUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconUser.Location = new System.Drawing.Point(738, 50);
            this.picIconUser.Name = "picIconUser";
            this.picIconUser.Size = new System.Drawing.Size(27, 26);
            this.picIconUser.TabIndex = 97;
            this.picIconUser.TabStop = false;
            // 
            // lblUsuarioEnMenu
            // 
            this.lblUsuarioEnMenu.AutoSize = true;
            this.lblUsuarioEnMenu.Location = new System.Drawing.Point(671, 59);
            this.lblUsuarioEnMenu.Name = "lblUsuarioEnMenu";
            this.lblUsuarioEnMenu.Size = new System.Drawing.Size(46, 17);
            this.lblUsuarioEnMenu.TabIndex = 104;
            this.lblUsuarioEnMenu.Text = "label8";
            this.lblUsuarioEnMenu.Visible = false;
            // 
            // lstVisitas
            // 
            this.lstVisitas.FormattingEnabled = true;
            this.lstVisitas.HorizontalScrollbar = true;
            this.lstVisitas.ItemHeight = 16;
            this.lstVisitas.Location = new System.Drawing.Point(393, 153);
            this.lstVisitas.Name = "lstVisitas";
            this.lstVisitas.Size = new System.Drawing.Size(575, 500);
            this.lstVisitas.TabIndex = 111;
            this.lstVisitas.SelectedIndexChanged += new System.EventHandler(this.lstVisitas_SelectedIndexChanged_1);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardar.Font = new System.Drawing.Font("Clarendon BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.Black;
            this.lblGuardar.Location = new System.Drawing.Point(557, 765);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(80, 20);
            this.lblGuardar.TabIndex = 116;
            this.lblGuardar.Text = "Guardar";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Font = new System.Drawing.Font("Clarendon BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.Black;
            this.lblCancelar.Location = new System.Drawing.Point(271, 766);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(84, 20);
            this.lblCancelar.TabIndex = 115;
            this.lblCancelar.Text = "Cancelar";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Común",
            "Especial"});
            this.cmbFiltro.Location = new System.Drawing.Point(592, 111);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(128, 24);
            this.cmbFiltro.TabIndex = 117;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(393, 109);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(193, 29);
            this.btnFiltro.TabIndex = 118;
            this.btnFiltro.Text = "flitrar por Tipo de Visita:";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderWidth = 2;
            this.btnGuardar.ButtonShape = Da_Vinci_Code_Manager.ButtonZ.ButtonsShapes.Rect;
            this.btnGuardar.ButtonText = "";
            this.btnGuardar.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.GradientAngle = 90;
            this.btnGuardar.Location = new System.Drawing.Point(556, 700);
            this.btnGuardar.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnGuardar.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShowButtontext = true;
            this.btnGuardar.Size = new System.Drawing.Size(82, 62);
            this.btnGuardar.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.TabIndex = 114;
            this.btnGuardar.TextLocation_X = 26;
            this.btnGuardar.TextLocation_Y = 25;
            this.btnGuardar.Transparent1 = 250;
            this.btnGuardar.Transparent2 = 250;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuardar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderWidth = 2;
            this.btnCancelar.ButtonShape = Da_Vinci_Code_Manager.ButtonZ.ButtonsShapes.Rect;
            this.btnCancelar.ButtonText = "";
            this.btnCancelar.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.GradientAngle = 90;
            this.btnCancelar.Location = new System.Drawing.Point(271, 701);
            this.btnCancelar.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnCancelar.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShowButtontext = true;
            this.btnCancelar.Size = new System.Drawing.Size(82, 62);
            this.btnCancelar.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.TabIndex = 113;
            this.btnCancelar.TextLocation_X = 26;
            this.btnCancelar.TextLocation_Y = 25;
            this.btnCancelar.Transparent1 = 250;
            this.btnCancelar.Transparent2 = 250;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderWidth = 2;
            this.btnEliminar.ButtonShape = Da_Vinci_Code_Manager.ButtonZ.ButtonsShapes.Rect;
            this.btnEliminar.ButtonText = "";
            this.btnEliminar.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.GradientAngle = 90;
            this.btnEliminar.Location = new System.Drawing.Point(792, 700);
            this.btnEliminar.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnEliminar.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShowButtontext = true;
            this.btnEliminar.Size = new System.Drawing.Size(82, 62);
            this.btnEliminar.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.TextLocation_X = 26;
            this.btnEliminar.TextLocation_Y = 25;
            this.btnEliminar.Transparent1 = 250;
            this.btnEliminar.Transparent2 = 250;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.btnEliminar.Enter += new System.EventHandler(this.BtnEliminar_Enter);
            this.btnEliminar.Leave += new System.EventHandler(this.BtnEliminar_Leave);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderWidth = 2;
            this.btnModificar.ButtonShape = Da_Vinci_Code_Manager.ButtonZ.ButtonsShapes.Rect;
            this.btnModificar.ButtonText = "";
            this.btnModificar.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.GradientAngle = 90;
            this.btnModificar.Location = new System.Drawing.Point(378, 700);
            this.btnModificar.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnModificar.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShowButtontext = true;
            this.btnModificar.Size = new System.Drawing.Size(82, 62);
            this.btnModificar.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.TabIndex = 1;
            this.btnModificar.TextLocation_X = 26;
            this.btnModificar.TextLocation_Y = 25;
            this.btnModificar.Transparent1 = 250;
            this.btnModificar.Transparent2 = 250;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            this.btnModificar.Enter += new System.EventHandler(this.BtnModificar_Enter);
            this.btnModificar.Leave += new System.EventHandler(this.BtnModificar_Leave);
            this.btnModificar.MouseEnter += new System.EventHandler(this.BtnModificar_MouseEnter);
            this.btnModificar.MouseLeave += new System.EventHandler(this.BtnModificar_MouseLeave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BorderWidth = 2;
            this.btnNuevo.ButtonShape = Da_Vinci_Code_Manager.ButtonZ.ButtonsShapes.Rect;
            this.btnNuevo.ButtonText = "";
            this.btnNuevo.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.GradientAngle = 90;
            this.btnNuevo.Location = new System.Drawing.Point(55, 700);
            this.btnNuevo.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnNuevo.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ShowButtontext = true;
            this.btnNuevo.Size = new System.Drawing.Size(82, 62);
            this.btnNuevo.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.TextLocation_X = 26;
            this.btnNuevo.TextLocation_Y = 25;
            this.btnNuevo.Transparent1 = 250;
            this.btnNuevo.Transparent2 = 250;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.btnNuevo.Enter += new System.EventHandler(this.BtnNuevo_Enter);
            this.btnNuevo.Leave += new System.EventHandler(this.BtnNuevo_Leave);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.BtnNuevo_MouseEnter);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.BtnNuevo_MouseLeave);
            // 
            // btnGuiaVirtual
            // 
            this.btnGuiaVirtual.BackColor = System.Drawing.Color.Transparent;
            this.btnGuiaVirtual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuiaVirtual.BackgroundImage")));
            this.btnGuiaVirtual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuiaVirtual.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuiaVirtual.BorderWidth = 2;
            this.btnGuiaVirtual.ButtonShape = Da_Vinci_Code_Manager.ButtonZ.ButtonsShapes.Rect;
            this.btnGuiaVirtual.ButtonText = "";
            this.btnGuiaVirtual.EndColor = System.Drawing.Color.MidnightBlue;
            this.btnGuiaVirtual.FlatAppearance.BorderSize = 0;
            this.btnGuiaVirtual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuiaVirtual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuiaVirtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiaVirtual.GradientAngle = 90;
            this.btnGuiaVirtual.Location = new System.Drawing.Point(231, 171);
            this.btnGuiaVirtual.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnGuiaVirtual.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnGuiaVirtual.Name = "btnGuiaVirtual";
            this.btnGuiaVirtual.ShowButtontext = true;
            this.btnGuiaVirtual.Size = new System.Drawing.Size(58, 52);
            this.btnGuiaVirtual.StartColor = System.Drawing.Color.DodgerBlue;
            this.btnGuiaVirtual.TabIndex = 117;
            this.btnGuiaVirtual.TextLocation_X = 18;
            this.btnGuiaVirtual.TextLocation_Y = 22;
            this.toolTip1.SetToolTip(this.btnGuiaVirtual, "Guía Virtual");
            this.btnGuiaVirtual.Transparent1 = 250;
            this.btnGuiaVirtual.Transparent2 = 250;
            this.btnGuiaVirtual.UseVisualStyleBackColor = false;
            this.btnGuiaVirtual.Click += new System.EventHandler(this.btnGuiaVirtual_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 29);
            this.button1.TabIndex = 119;
            this.button1.Text = "Ver Listado Completo:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 803);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstVisitas);
            this.Controls.Add(this.lblUsuarioEnMenu);
            this.Controls.Add(this.picIconUser);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.linkCerrarSesion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ptbBarra);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVisitas_FormClosing);
            this.Load += new System.EventHandler(this.FrmVisitas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVisitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVisita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ptbBarra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkSolicitudGuia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCantidadVisitantes;
        private Da_Vinci_Code_Manager.ButtonZ btnNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private Da_Vinci_Code_Manager.ButtonZ btnModificar;
        private Da_Vinci_Code_Manager.ButtonZ btnEliminar;
        public System.Windows.Forms.LinkLabel linkCerrarSesion;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.PictureBox picIconUser;
        public System.Windows.Forms.Label lblUsuarioEnMenu;
        private System.Windows.Forms.ListBox lstVisitas;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label lblCancelar;
        private ButtonZ btnGuardar;
        private ButtonZ btnCancelar;
        private System.Windows.Forms.ComboBox cbhoras;
        private System.Windows.Forms.ComboBox cbminutos;
        private System.Windows.Forms.ComboBox cbsegundos;
        private System.Windows.Forms.Label lblHoras1;
        private System.Windows.Forms.Label lblMinutos1;
        private System.Windows.Forms.Label lblSegundos1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Label lblTiempo1;
        private System.Windows.Forms.Label lblGuia2;
        private System.Windows.Forms.Label lblGuia1;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.Label lblSegundos2;
        private System.Windows.Forms.Button btnPausar2;
        private System.Windows.Forms.Label lblMinutos2;
        private System.Windows.Forms.Label lblHoras2;
        private System.Windows.Forms.Button btnIniciar2;
        private System.Windows.Forms.ComboBox cbsegundos2;
        private System.Windows.Forms.ComboBox cbminutos2;
        private System.Windows.Forms.ComboBox cbhoras2;
        private ButtonZ btnGuiaVirtual;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cmbGuia;
        private System.Windows.Forms.Button button1;
    }
}