namespace ControlEscolar.View
{
    partial class frmEstudiantes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            lblControlEstudiantes = new Label();
            scEstudiantes = new SplitContainer();
            grupBoxDatosEstudiantes = new GroupBox();
            pnlNoControl = new Panel();
            txtBoxControl = new TextBox();
            lblControl = new Label();
            pbQuestion = new PictureBox();
            lblInfo = new Label();
            ibtnGuardar = new FontAwesome.Sharp.IconButton();
            cbEstatus = new ComboBox();
            lblEstatus = new Label();
            nudSemestre = new NumericUpDown();
            dataBaja = new DateTimePicker();
            lblFechaBaja = new Label();
            dataAlta = new DateTimePicker();
            lblFechaAlta = new Label();
            dttFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            lblSemestre = new Label();
            txtCurp = new TextBox();
            lblCurp = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panel2 = new Panel();
            dgvEstudiantes = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblTotalRegister = new Label();
            btnActiualizar = new FontAwesome.Sharp.IconButton();
            txtBusquedaTexto = new TextBox();
            lblBusquedaTexto = new Label();
            dateInicio = new DateTimePicker();
            cmbxTipoFecha = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dateFin = new DateTimePicker();
            lblFiltros = new Label();
            pnlHerramientas = new Panel();
            lblRutaArchivo = new Label();
            btnCarga = new FontAwesome.Sharp.IconButton();
            btnMostrar = new FontAwesome.Sharp.IconButton();
            lblHerramientas = new Label();
            ttInfo = new ToolTip(components);
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            ofdArchivo = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)scEstudiantes).BeginInit();
            scEstudiantes.Panel1.SuspendLayout();
            scEstudiantes.Panel2.SuspendLayout();
            scEstudiantes.SuspendLayout();
            grupBoxDatosEstudiantes.SuspendLayout();
            pnlNoControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            panel1.SuspendLayout();
            pnlHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // lblControlEstudiantes
            // 
            lblControlEstudiantes.BackColor = SystemColors.ControlDarkDark;
            lblControlEstudiantes.Dock = DockStyle.Top;
            lblControlEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblControlEstudiantes.Location = new Point(0, 0);
            lblControlEstudiantes.Name = "lblControlEstudiantes";
            lblControlEstudiantes.Size = new Size(1012, 71);
            lblControlEstudiantes.TabIndex = 2;
            lblControlEstudiantes.Text = "Control de estudiantes";
            lblControlEstudiantes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scEstudiantes
            // 
            scEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scEstudiantes.Location = new Point(0, 74);
            scEstudiantes.Name = "scEstudiantes";
            // 
            // scEstudiantes.Panel1
            // 
            scEstudiantes.Panel1.Controls.Add(grupBoxDatosEstudiantes);
            // 
            // scEstudiantes.Panel2
            // 
            scEstudiantes.Panel2.Controls.Add(panel2);
            scEstudiantes.Size = new Size(1012, 656);
            scEstudiantes.SplitterDistance = 299;
            scEstudiantes.TabIndex = 3;
            // 
            // grupBoxDatosEstudiantes
            // 
            grupBoxDatosEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grupBoxDatosEstudiantes.Controls.Add(pnlNoControl);
            grupBoxDatosEstudiantes.Controls.Add(lblInfo);
            grupBoxDatosEstudiantes.Controls.Add(ibtnGuardar);
            grupBoxDatosEstudiantes.Controls.Add(cbEstatus);
            grupBoxDatosEstudiantes.Controls.Add(lblEstatus);
            grupBoxDatosEstudiantes.Controls.Add(nudSemestre);
            grupBoxDatosEstudiantes.Controls.Add(dataBaja);
            grupBoxDatosEstudiantes.Controls.Add(lblFechaBaja);
            grupBoxDatosEstudiantes.Controls.Add(dataAlta);
            grupBoxDatosEstudiantes.Controls.Add(lblFechaAlta);
            grupBoxDatosEstudiantes.Controls.Add(dttFechaNacimiento);
            grupBoxDatosEstudiantes.Controls.Add(lblFechaNacimiento);
            grupBoxDatosEstudiantes.Controls.Add(lblSemestre);
            grupBoxDatosEstudiantes.Controls.Add(txtCurp);
            grupBoxDatosEstudiantes.Controls.Add(lblCurp);
            grupBoxDatosEstudiantes.Controls.Add(txtCorreo);
            grupBoxDatosEstudiantes.Controls.Add(lblCorreo);
            grupBoxDatosEstudiantes.Controls.Add(txtTelefono);
            grupBoxDatosEstudiantes.Controls.Add(lblTelefono);
            grupBoxDatosEstudiantes.Controls.Add(txtNombre);
            grupBoxDatosEstudiantes.Controls.Add(lblNombre);
            grupBoxDatosEstudiantes.Location = new Point(0, 0);
            grupBoxDatosEstudiantes.Name = "grupBoxDatosEstudiantes";
            grupBoxDatosEstudiantes.Size = new Size(299, 656);
            grupBoxDatosEstudiantes.TabIndex = 0;
            grupBoxDatosEstudiantes.TabStop = false;
            // 
            // pnlNoControl
            // 
            pnlNoControl.Controls.Add(txtBoxControl);
            pnlNoControl.Controls.Add(lblControl);
            pnlNoControl.Controls.Add(pbQuestion);
            pnlNoControl.Location = new Point(6, 334);
            pnlNoControl.Name = "pnlNoControl";
            pnlNoControl.Size = new Size(293, 55);
            pnlNoControl.TabIndex = 3;
            // 
            // txtBoxControl
            // 
            txtBoxControl.Location = new Point(11, 29);
            txtBoxControl.MaxLength = 20;
            txtBoxControl.Name = "txtBoxControl";
            txtBoxControl.Size = new Size(213, 23);
            txtBoxControl.TabIndex = 10;
            // 
            // lblControl
            // 
            lblControl.AutoSize = true;
            lblControl.Location = new Point(11, 11);
            lblControl.Name = "lblControl";
            lblControl.Size = new Size(93, 15);
            lblControl.TabIndex = 9;
            lblControl.Text = "No. de Control *";
            // 
            // pbQuestion
            // 
            pbQuestion.AccessibleRole = AccessibleRole.None;
            pbQuestion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbQuestion.Image = (Image)resources.GetObject("pbQuestion.Image");
            pbQuestion.Location = new Point(237, 6);
            pbQuestion.Name = "pbQuestion";
            pbQuestion.Size = new Size(41, 46);
            pbQuestion.SizeMode = PictureBoxSizeMode.Zoom;
            pbQuestion.TabIndex = 19;
            pbQuestion.TabStop = false;
            ttInfo.SetToolTip(pbQuestion, "T/M-Año de ingreso-Número de alumno");
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(23, 591);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(111, 15);
            lblInfo.TabIndex = 21;
            lblInfo.Text = "* Datos obligatorios";
            // 
            // ibtnGuardar
            // 
            ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnGuardar.IconColor = Color.Black;
            ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGuardar.IconSize = 24;
            ibtnGuardar.Location = new Point(176, 591);
            ibtnGuardar.Name = "ibtnGuardar";
            ibtnGuardar.Size = new Size(106, 32);
            ibtnGuardar.TabIndex = 16;
            ibtnGuardar.Text = "Guardar";
            ibtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            ibtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardar.UseVisualStyleBackColor = true;
            ibtnGuardar.Click += ibtnGuardar_Click;
            // 
            // cbEstatus
            // 
            cbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Location = new Point(10, 487);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(272, 23);
            cbEstatus.TabIndex = 20;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(10, 469);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(52, 15);
            lblEstatus.TabIndex = 18;
            lblEstatus.Text = "Estatus *";
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(164, 295);
            nudSemestre.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(120, 23);
            nudSemestre.TabIndex = 17;
            // 
            // dataBaja
            // 
            dataBaja.Format = DateTimePickerFormat.Short;
            dataBaja.Location = new Point(164, 420);
            dataBaja.Name = "dataBaja";
            dataBaja.Size = new Size(118, 23);
            dataBaja.TabIndex = 16;
            // 
            // lblFechaBaja
            // 
            lblFechaBaja.AutoSize = true;
            lblFechaBaja.Location = new Point(164, 402);
            lblFechaBaja.Name = "lblFechaBaja";
            lblFechaBaja.Size = new Size(63, 15);
            lblFechaBaja.TabIndex = 15;
            lblFechaBaja.Text = "Fecha baja";
            // 
            // dataAlta
            // 
            dataAlta.Format = DateTimePickerFormat.Short;
            dataAlta.Location = new Point(7, 420);
            dataAlta.Name = "dataAlta";
            dataAlta.Size = new Size(113, 23);
            dataAlta.TabIndex = 14;
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Location = new Point(7, 402);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(68, 15);
            lblFechaAlta.TabIndex = 13;
            lblFechaAlta.Text = "Fecha alta *";
            // 
            // dttFechaNacimiento
            // 
            dttFechaNacimiento.Format = DateTimePickerFormat.Short;
            dttFechaNacimiento.Location = new Point(7, 295);
            dttFechaNacimiento.Name = "dttFechaNacimiento";
            dttFechaNacimiento.Size = new Size(113, 23);
            dttFechaNacimiento.TabIndex = 12;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(7, 277);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(125, 15);
            lblFechaNacimiento.TabIndex = 11;
            lblFechaNacimiento.Text = "Fecha de nacimiento *";
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Location = new Point(164, 277);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(63, 15);
            lblSemestre.TabIndex = 8;
            lblSemestre.Text = "Semestre *";
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(9, 205);
            txtCurp.MaxLength = 20;
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(275, 23);
            txtCurp.TabIndex = 7;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Location = new Point(9, 187);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(45, 15);
            lblCurp.TabIndex = 6;
            lblCurp.Text = "CURP *";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(9, 91);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(275, 23);
            txtCorreo.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(9, 73);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(51, 15);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo *";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(9, 147);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(275, 23);
            txtTelefono.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(9, 129);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(61, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Telefono *";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(9, 38);
            txtNombre.MaxLength = 255;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo *";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgvEstudiantes);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pnlHerramientas);
            panel2.Location = new Point(8, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 656);
            panel2.TabIndex = 2;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(4, 234);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(685, 419);
            dgvEstudiantes.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(348, 439);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 9);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalRegister);
            panel1.Controls.Add(btnActiualizar);
            panel1.Controls.Add(txtBusquedaTexto);
            panel1.Controls.Add(lblBusquedaTexto);
            panel1.Controls.Add(dateInicio);
            panel1.Controls.Add(cmbxTipoFecha);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateFin);
            panel1.Controls.Add(lblFiltros);
            panel1.Location = new Point(3, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 149);
            panel1.TabIndex = 1;
            // 
            // lblTotalRegister
            // 
            lblTotalRegister.AutoSize = true;
            lblTotalRegister.Location = new Point(17, 126);
            lblTotalRegister.Name = "lblTotalRegister";
            lblTotalRegister.Size = new Size(93, 15);
            lblTotalRegister.TabIndex = 33;
            lblTotalRegister.Text = "Registros totales";
            // 
            // btnActiualizar
            // 
            btnActiualizar.Anchor = AnchorStyles.Left;
            btnActiualizar.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnActiualizar.IconColor = Color.Black;
            btnActiualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActiualizar.IconSize = 24;
            btnActiualizar.Location = new Point(479, 73);
            btnActiualizar.Name = "btnActiualizar";
            btnActiualizar.Size = new Size(96, 29);
            btnActiualizar.TabIndex = 32;
            btnActiualizar.Text = "Actualizar";
            btnActiualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActiualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActiualizar.UseVisualStyleBackColor = true;
            btnActiualizar.Click += btnActiualizar_Click;
            // 
            // txtBusquedaTexto
            // 
            txtBusquedaTexto.Anchor = AnchorStyles.Left;
            txtBusquedaTexto.Location = new Point(132, 79);
            txtBusquedaTexto.MaxLength = 255;
            txtBusquedaTexto.Name = "txtBusquedaTexto";
            txtBusquedaTexto.Size = new Size(275, 23);
            txtBusquedaTexto.TabIndex = 22;
            // 
            // lblBusquedaTexto
            // 
            lblBusquedaTexto.Anchor = AnchorStyles.Left;
            lblBusquedaTexto.AutoSize = true;
            lblBusquedaTexto.Location = new Point(17, 82);
            lblBusquedaTexto.Name = "lblBusquedaTexto";
            lblBusquedaTexto.Size = new Size(109, 15);
            lblBusquedaTexto.TabIndex = 31;
            lblBusquedaTexto.Text = "Busqueda por texto";
            // 
            // dateInicio
            // 
            dateInicio.Anchor = AnchorStyles.Left;
            dateInicio.Format = DateTimePickerFormat.Short;
            dateInicio.Location = new Point(318, 42);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(113, 23);
            dateInicio.TabIndex = 30;
            // 
            // cmbxTipoFecha
            // 
            cmbxTipoFecha.Anchor = AnchorStyles.Left;
            cmbxTipoFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxTipoFecha.FormattingEnabled = true;
            cmbxTipoFecha.Location = new Point(88, 42);
            cmbxTipoFecha.Name = "cmbxTipoFecha";
            cmbxTipoFecha.Size = new Size(96, 23);
            cmbxTipoFecha.TabIndex = 22;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(17, 45);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 29;
            label7.Text = "TIpo Fecha";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(242, 45);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 28;
            label6.Text = "Fecha inicio";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(479, 47);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 27;
            label5.Text = "Fecha Fin";
            // 
            // dateFin
            // 
            dateFin.Anchor = AnchorStyles.Left;
            dateFin.Format = DateTimePickerFormat.Short;
            dateFin.Location = new Point(542, 42);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(113, 23);
            dateFin.TabIndex = 22;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Location = new Point(8, 12);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(39, 15);
            lblFiltros.TabIndex = 26;
            lblFiltros.Text = "Filtros";
            // 
            // pnlHerramientas
            // 
            pnlHerramientas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHerramientas.BackColor = Color.White;
            pnlHerramientas.Controls.Add(lblRutaArchivo);
            pnlHerramientas.Controls.Add(btnCarga);
            pnlHerramientas.Controls.Add(btnMostrar);
            pnlHerramientas.Controls.Add(lblHerramientas);
            pnlHerramientas.Location = new Point(4, 6);
            pnlHerramientas.Name = "pnlHerramientas";
            pnlHerramientas.Size = new Size(698, 67);
            pnlHerramientas.TabIndex = 0;
            // 
            // lblRutaArchivo
            // 
            lblRutaArchivo.Anchor = AnchorStyles.Left;
            lblRutaArchivo.AutoSize = true;
            lblRutaArchivo.BackColor = SystemColors.Control;
            lblRutaArchivo.ForeColor = Color.Teal;
            lblRutaArchivo.Location = new Point(311, 41);
            lblRutaArchivo.Name = "lblRutaArchivo";
            lblRutaArchivo.Size = new Size(150, 15);
            lblRutaArchivo.TabIndex = 25;
            lblRutaArchivo.Text = "Ruta del archivo a importar";
            // 
            // btnCarga
            // 
            btnCarga.Anchor = AnchorStyles.Left;
            btnCarga.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCarga.IconColor = Color.Black;
            btnCarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCarga.Location = new Point(196, 37);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(97, 23);
            btnCarga.TabIndex = 24;
            btnCarga.Text = "Carga Masiva";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Anchor = AnchorStyles.Left;
            btnMostrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMostrar.IconColor = Color.Black;
            btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrar.Location = new Point(57, 37);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(97, 23);
            btnMostrar.TabIndex = 23;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblHerramientas
            // 
            lblHerramientas.AutoSize = true;
            lblHerramientas.Location = new Point(10, 8);
            lblHerramientas.Name = "lblHerramientas";
            lblHerramientas.Size = new Size(78, 15);
            lblHerramientas.TabIndex = 22;
            lblHerramientas.Text = "Herramientas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 11);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 22;
            label4.Text = "Herramientas";
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // ofdArchivo
            // 
            ofdArchivo.FileName = "Carga Masiva Estudiantes";
            // 
            // frmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 729);
            Controls.Add(scEstudiantes);
            Controls.Add(lblControlEstudiantes);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1028, 768);
            Name = "frmEstudiantes";
            Text = "frmEstudiantes";
            scEstudiantes.Panel1.ResumeLayout(false);
            scEstudiantes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scEstudiantes).EndInit();
            scEstudiantes.ResumeLayout(false);
            grupBoxDatosEstudiantes.ResumeLayout(false);
            grupBoxDatosEstudiantes.PerformLayout();
            pnlNoControl.ResumeLayout(false);
            pnlNoControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHerramientas.ResumeLayout(false);
            pnlHerramientas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblControlEstudiantes;
        private SplitContainer scEstudiantes;
        private GroupBox grupBoxDatosEstudiantes;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCurp;
        private Label lblCurp;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblSemestre;
        private TextBox txtBoxControl;
        private Label lblControl;
        private DateTimePicker dttFechaNacimiento;
        private Label lblFechaNacimiento;
        private DateTimePicker dataBaja;
        private Label lblFechaBaja;
        private DateTimePicker dataAlta;
        private Label lblFechaAlta;
        private Label lblEstatus;
        private NumericUpDown nudSemestre;
        private PictureBox pbQuestion;
        private ToolTip ttInfo;
        private ComboBox cbEstatus;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private Label lblInfo;
        private Panel pnlHerramientas;
        private Panel panel1;
        private Label lblHerramientas;
        private Label lblRutaArchivo;
        private FontAwesome.Sharp.IconButton btnCarga;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private Label lblFiltros;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dateFin;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private FontAwesome.Sharp.IconButton btnActiualizar;
        private TextBox txtBusquedaTexto;
        private Label lblBusquedaTexto;
        private DateTimePicker dateInicio;
        private ComboBox cmbxTipoFecha;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlNoControl;
        private OpenFileDialog ofdArchivo;
        private DataGridView dgvEstudiantes;
        private Label lblTotalRegister;
    }
}