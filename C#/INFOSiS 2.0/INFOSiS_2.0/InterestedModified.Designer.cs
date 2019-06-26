namespace INFOSiS_2._0
{
    partial class InterestedModified
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInterestedRegister = new System.Windows.Forms.Label();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.btBuscarCursos = new System.Windows.Forms.Button();
            this.dgvInterestedCourses = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.txbNDocumento = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbSegundoNom = new System.Windows.Forms.TextBox();
            this.txbApePa = new System.Windows.Forms.TextBox();
            this.txbApeMa = new System.Windows.Forms.TextBox();
            this.gbxInterestedData = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPasaporte = new System.Windows.Forms.RadioButton();
            this.rbCarnet = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbDesactivado = new System.Windows.Forms.CheckBox();
            this.lbBusquedaAvanzada = new System.Windows.Forms.Label();
            this.lblRequiredInfo = new System.Windows.Forms.Label();
            this.gbCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterestedCourses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxInterestedData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(10, 21);
            this.lblInterestedRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(358, 48);
            this.lblInterestedRegister.TabIndex = 172;
            this.lblInterestedRegister.Text = "Modificar interesado";
            // 
            // gbCursos
            // 
            this.gbCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCursos.Controls.Add(this.btBuscarCursos);
            this.gbCursos.Controls.Add(this.dgvInterestedCourses);
            this.gbCursos.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCursos.Location = new System.Drawing.Point(410, 81);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(378, 366);
            this.gbCursos.TabIndex = 178;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos de interés *";
            // 
            // btBuscarCursos
            // 
            this.btBuscarCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBuscarCursos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btBuscarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarCursos.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.btBuscarCursos.ForeColor = System.Drawing.Color.White;
            this.btBuscarCursos.Location = new System.Drawing.Point(6, 25);
            this.btBuscarCursos.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarCursos.Name = "btBuscarCursos";
            this.btBuscarCursos.Size = new System.Drawing.Size(116, 31);
            this.btBuscarCursos.TabIndex = 1;
            this.btBuscarCursos.Text = "Escoger cursos";
            this.btBuscarCursos.UseVisualStyleBackColor = false;
            this.btBuscarCursos.Click += new System.EventHandler(this.BtBuscarCursos_Click);
            // 
            // dgvInterestedCourses
            // 
            this.dgvInterestedCourses.AllowUserToAddRows = false;
            this.dgvInterestedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterestedCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNombre});
            this.dgvInterestedCourses.Location = new System.Drawing.Point(6, 61);
            this.dgvInterestedCourses.Name = "dgvInterestedCourses";
            this.dgvInterestedCourses.ReadOnly = true;
            this.dgvInterestedCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterestedCourses.Size = new System.Drawing.Size(366, 299);
            this.dgvInterestedCourses.TabIndex = 0;
            this.dgvInterestedCourses.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvInterestedCourses_RowsRemoved);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "ID";
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Width = 70;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "Nombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 273;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtCellphone);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblCellphone);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 88);
            this.groupBox2.TabIndex = 177;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(51, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 18);
            this.lblEmail.TabIndex = 180;
            this.lblEmail.Text = "Correo: *";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(114, 25);
            this.txtCellphone.MaxLength = 15;
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(239, 26);
            this.txtCellphone.TabIndex = 173;
            this.txtCellphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellphone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 56);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 26);
            this.txtEmail.TabIndex = 179;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(53, 26);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(59, 18);
            this.lblCellphone.TabIndex = 174;
            this.lblCellphone.Text = "Celular: *";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLastName.Location = new System.Drawing.Point(34, 131);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(114, 18);
            this.lblSecondLastName.TabIndex = 162;
            this.lblSecondLastName.Text = "Apellido materno: *";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(37, 101);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(111, 18);
            this.lblPrimaryLastName.TabIndex = 161;
            this.lblPrimaryLastName.Text = "Apellido paterno: *";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(36, 68);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(103, 18);
            this.lblSecondName.TabIndex = 160;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(83, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 18);
            this.lblFirstName.TabIndex = 159;
            this.lblFirstName.Text = "Nombre: *";
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(17, 163);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(150, 18);
            this.lblDocumentNumber.TabIndex = 158;
            this.lblDocumentNumber.Text = "Número de Documento: *";
            // 
            // txbNDocumento
            // 
            this.txbNDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNDocumento.Location = new System.Drawing.Point(168, 164);
            this.txbNDocumento.MaxLength = 8;
            this.txbNDocumento.Name = "txbNDocumento";
            this.txbNDocumento.Size = new System.Drawing.Size(191, 20);
            this.txbNDocumento.TabIndex = 165;
            this.txbNDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNDocumento_KeyPress);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(150, 31);
            this.txbNombre.MaxLength = 100;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(191, 26);
            this.txbNombre.TabIndex = 166;
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombre_KeyPress);
            // 
            // txbSegundoNom
            // 
            this.txbSegundoNom.Location = new System.Drawing.Point(151, 63);
            this.txbSegundoNom.MaxLength = 100;
            this.txbSegundoNom.Name = "txbSegundoNom";
            this.txbSegundoNom.Size = new System.Drawing.Size(191, 26);
            this.txbSegundoNom.TabIndex = 167;
            this.txbSegundoNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSegundoNom_KeyPress);
            // 
            // txbApePa
            // 
            this.txbApePa.Location = new System.Drawing.Point(150, 96);
            this.txbApePa.MaxLength = 100;
            this.txbApePa.Name = "txbApePa";
            this.txbApePa.Size = new System.Drawing.Size(191, 26);
            this.txbApePa.TabIndex = 168;
            this.txbApePa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApePa_KeyPress);
            // 
            // txbApeMa
            // 
            this.txbApeMa.Location = new System.Drawing.Point(150, 128);
            this.txbApeMa.MaxLength = 100;
            this.txbApeMa.Name = "txbApeMa";
            this.txbApeMa.Size = new System.Drawing.Size(191, 26);
            this.txbApeMa.TabIndex = 169;
            this.txbApeMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApeMa_KeyPress);
            // 
            // gbxInterestedData
            // 
            this.gbxInterestedData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInterestedData.Controls.Add(this.txbApeMa);
            this.gbxInterestedData.Controls.Add(this.txbApePa);
            this.gbxInterestedData.Controls.Add(this.txbSegundoNom);
            this.gbxInterestedData.Controls.Add(this.txbNombre);
            this.gbxInterestedData.Controls.Add(this.lblFirstName);
            this.gbxInterestedData.Controls.Add(this.lblSecondName);
            this.gbxInterestedData.Controls.Add(this.lblPrimaryLastName);
            this.gbxInterestedData.Controls.Add(this.lblSecondLastName);
            this.gbxInterestedData.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.gbxInterestedData.Location = new System.Drawing.Point(16, 227);
            this.gbxInterestedData.Name = "gbxInterestedData";
            this.gbxInterestedData.Size = new System.Drawing.Size(388, 172);
            this.gbxInterestedData.TabIndex = 176;
            this.gbxInterestedData.TabStop = false;
            this.gbxInterestedData.Text = "Datos Personales";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbPasaporte);
            this.groupBox1.Controls.Add(this.rbCarnet);
            this.groupBox1.Controls.Add(this.rbDNI);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox1.Location = new System.Drawing.Point(22, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 62);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Documento";
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbPasaporte.Location = new System.Drawing.Point(248, 26);
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Size = new System.Drawing.Size(79, 22);
            this.rbPasaporte.TabIndex = 2;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            // 
            // rbCarnet
            // 
            this.rbCarnet.AutoSize = true;
            this.rbCarnet.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbCarnet.Location = new System.Drawing.Point(91, 26);
            this.rbCarnet.Name = "rbCarnet";
            this.rbCarnet.Size = new System.Drawing.Size(139, 22);
            this.rbCarnet.TabIndex = 1;
            this.rbCarnet.TabStop = true;
            this.rbCarnet.Text = "Carné de Extranjería";
            this.rbCarnet.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbDNI.Location = new System.Drawing.Point(28, 26);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(49, 22);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(25, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 32);
            this.btnSearch.TabIndex = 175;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.btnSearch.Leave += new System.EventHandler(this.BtnSave_Leave);
            // 
            // btModificar
            // 
            this.btModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btModificar.FlatAppearance.BorderSize = 0;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btModificar.ForeColor = System.Drawing.Color.White;
            this.btModificar.Location = new System.Drawing.Point(226, 505);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(148, 39);
            this.btModificar.TabIndex = 180;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.EnabledChanged += new System.EventHandler(this.BtModificar_EnabledChanged);
            this.btModificar.Click += new System.EventHandler(this.BtModificar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(430, 505);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(148, 39);
            this.btCancelar.TabIndex = 181;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // cbDesactivado
            // 
            this.cbDesactivado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDesactivado.AutoSize = true;
            this.cbDesactivado.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.cbDesactivado.Location = new System.Drawing.Point(430, 461);
            this.cbDesactivado.Name = "cbDesactivado";
            this.cbDesactivado.Size = new System.Drawing.Size(207, 25);
            this.cbDesactivado.TabIndex = 182;
            this.cbDesactivado.Text = "No quiere recibir más correos";
            this.cbDesactivado.UseVisualStyleBackColor = true;
            // 
            // lbBusquedaAvanzada
            // 
            this.lbBusquedaAvanzada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBusquedaAvanzada.AutoSize = true;
            this.lbBusquedaAvanzada.Font = new System.Drawing.Font("Gill Sans MT", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbBusquedaAvanzada.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbBusquedaAvanzada.Location = new System.Drawing.Point(136, 207);
            this.lbBusquedaAvanzada.Name = "lbBusquedaAvanzada";
            this.lbBusquedaAvanzada.Size = new System.Drawing.Size(115, 18);
            this.lbBusquedaAvanzada.TabIndex = 183;
            this.lbBusquedaAvanzada.Text = "Busqueda avanzada";
            this.lbBusquedaAvanzada.Click += new System.EventHandler(this.LbBusquedaAvanzada_Click);
            this.lbBusquedaAvanzada.MouseEnter += new System.EventHandler(this.LbBusquedaAvanzada_MouseEnter);
            this.lbBusquedaAvanzada.MouseLeave += new System.EventHandler(this.LbBusquedaAvanzada_MouseLeave);
            // 
            // lblRequiredInfo
            // 
            this.lblRequiredInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequiredInfo.AutoSize = true;
            this.lblRequiredInfo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequiredInfo.Location = new System.Drawing.Point(19, 140);
            this.lblRequiredInfo.Name = "lblRequiredInfo";
            this.lblRequiredInfo.Size = new System.Drawing.Size(136, 18);
            this.lblRequiredInfo.TabIndex = 184;
            this.lblRequiredInfo.Text = "* Campo obligatorio";
            // 
            // InterestedModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblRequiredInfo);
            this.Controls.Add(this.lbBusquedaAvanzada);
            this.Controls.Add(this.cbDesactivado);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxInterestedData);
            this.Controls.Add(this.txbNDocumento);
            this.Controls.Add(this.lblInterestedRegister);
            this.Controls.Add(this.lblDocumentNumber);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterestedModified";
            this.Size = new System.Drawing.Size(814, 566);
            this.Load += new System.EventHandler(this.InterestedSearch_Load);
            this.Leave += new System.EventHandler(this.InterestedModified_Leave);
            this.gbCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterestedCourses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxInterestedData.ResumeLayout(false);
            this.gbxInterestedData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.Button btBuscarCursos;
        private System.Windows.Forms.DataGridView dgvInterestedCourses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.TextBox txbNDocumento;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbSegundoNom;
        private System.Windows.Forms.TextBox txbApePa;
        private System.Windows.Forms.TextBox txbApeMa;
        private System.Windows.Forms.GroupBox gbxInterestedData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPasaporte;
        private System.Windows.Forms.RadioButton rbCarnet;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.CheckBox cbDesactivado;
        private System.Windows.Forms.Label lbBusquedaAvanzada;
        private System.Windows.Forms.Label lblRequiredInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
    }
}
