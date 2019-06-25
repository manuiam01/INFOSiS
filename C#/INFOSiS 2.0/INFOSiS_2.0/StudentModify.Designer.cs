namespace INFOSiS_2._0
{
    partial class StudentModify
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarDocumento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnPasaporte = new System.Windows.Forms.RadioButton();
            this.rbnCarneExtranjeria = new System.Windows.Forms.RadioButton();
            this.rbnDNI = new System.Windows.Forms.RadioButton();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCodigos = new System.Windows.Forms.Button();
            this.dgvCodigos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20F);
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar un Alumno";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtApellidoMaterno);
            this.groupBox1.Controls.Add(this.txtApellidoPaterno);
            this.groupBox1.Controls.Add(this.txtSegundoNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscarDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(439, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Alumno";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Enabled = false;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(203, 352);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(221, 31);
            this.txtApellidoMaterno.TabIndex = 11;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Enabled = false;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(203, 309);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(221, 31);
            this.txtApellidoPaterno.TabIndex = 10;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(203, 266);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(221, 31);
            this.txtSegundoNombre.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(203, 223);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 31);
            this.txtNombre.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label6.Location = new System.Drawing.Point(37, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellido Materno: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label5.Location = new System.Drawing.Point(43, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido Paterno: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label4.Location = new System.Drawing.Point(36, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Segundo Nombre: ";
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDocumento.Location = new System.Drawing.Point(203, 162);
            this.btnBuscarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Size = new System.Drawing.Size(221, 39);
            this.btnBuscarDocumento.TabIndex = 4;
            this.btnBuscarDocumento.Text = "Buscar Documento";
            this.btnBuscarDocumento.UseVisualStyleBackColor = false;
            this.btnBuscarDocumento.Click += new System.EventHandler(this.btnVerificarDocumento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label3.Location = new System.Drawing.Point(107, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnPasaporte);
            this.groupBox2.Controls.Add(this.rbnCarneExtranjeria);
            this.groupBox2.Controls.Add(this.rbnDNI);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox2.Location = new System.Drawing.Point(11, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(412, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Documento";
            // 
            // rbnPasaporte
            // 
            this.rbnPasaporte.AutoSize = true;
            this.rbnPasaporte.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbnPasaporte.Location = new System.Drawing.Point(285, 26);
            this.rbnPasaporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnPasaporte.Name = "rbnPasaporte";
            this.rbnPasaporte.Size = new System.Drawing.Size(102, 29);
            this.rbnPasaporte.TabIndex = 2;
            this.rbnPasaporte.TabStop = true;
            this.rbnPasaporte.Text = "Pasaporte";
            this.rbnPasaporte.UseVisualStyleBackColor = true;
            // 
            // rbnCarneExtranjeria
            // 
            this.rbnCarneExtranjeria.AutoSize = true;
            this.rbnCarneExtranjeria.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbnCarneExtranjeria.Location = new System.Drawing.Point(100, 26);
            this.rbnCarneExtranjeria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnCarneExtranjeria.Name = "rbnCarneExtranjeria";
            this.rbnCarneExtranjeria.Size = new System.Drawing.Size(180, 29);
            this.rbnCarneExtranjeria.TabIndex = 1;
            this.rbnCarneExtranjeria.TabStop = true;
            this.rbnCarneExtranjeria.Text = "Carné de Extranjería";
            this.rbnCarneExtranjeria.UseVisualStyleBackColor = true;
            // 
            // rbnDNI
            // 
            this.rbnDNI.AutoSize = true;
            this.rbnDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbnDNI.Location = new System.Drawing.Point(31, 26);
            this.rbnDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnDNI.Name = "rbnDNI";
            this.rbnDNI.Size = new System.Drawing.Size(63, 29);
            this.rbnDNI.TabIndex = 0;
            this.rbnDNI.TabStop = true;
            this.rbnDNI.Text = "DNI";
            this.rbnDNI.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.txtDocumento.Location = new System.Drawing.Point(203, 110);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(221, 27);
            this.txtDocumento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label2.Location = new System.Drawing.Point(5, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de Documento: ";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.CalendarFont = new System.Drawing.Font("Gill Sans MT", 12F);
            this.dateNacimiento.Enabled = false;
            this.dateNacimiento.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.dateNacimiento.Location = new System.Drawing.Point(173, 31);
            this.dateNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dateNacimiento.MaxDate = new System.DateTime(2101, 3, 3, 0, 0, 0, 0);
            this.dateNacimiento.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(296, 27);
            this.dateNacimiento.TabIndex = 173;
            this.dateNacimiento.Value = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(7, 32);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(158, 25);
            this.lblBirthday.TabIndex = 174;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblBirthday);
            this.groupBox3.Controls.Add(this.dateNacimiento);
            this.groupBox3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(543, 116);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(489, 165);
            this.groupBox3.TabIndex = 175;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Personales";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(173, 111);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(296, 27);
            this.txtTelefono.TabIndex = 178;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label8.Location = new System.Drawing.Point(59, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 177;
            this.label8.Text = "Teléfono Fijo:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.txtDireccion.Location = new System.Drawing.Point(173, 71);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(296, 27);
            this.txtDireccion.TabIndex = 176;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label7.Location = new System.Drawing.Point(81, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 175;
            this.label7.Text = "Dirección:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.btnAgregarCodigos);
            this.groupBox4.Controls.Add(this.dgvCodigos);
            this.groupBox4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(543, 299);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(489, 217);
            this.groupBox4.TabIndex = 176;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Códigos PUCP";
            // 
            // btnAgregarCodigos
            // 
            this.btnAgregarCodigos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregarCodigos.Enabled = false;
            this.btnAgregarCodigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCodigos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCodigos.Location = new System.Drawing.Point(248, 30);
            this.btnAgregarCodigos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCodigos.Name = "btnAgregarCodigos";
            this.btnAgregarCodigos.Size = new System.Drawing.Size(221, 39);
            this.btnAgregarCodigos.TabIndex = 5;
            this.btnAgregarCodigos.Text = "Modificar Códigos";
            this.btnAgregarCodigos.UseVisualStyleBackColor = false;
            this.btnAgregarCodigos.Click += new System.EventHandler(this.btnAgregarCodigos_Click);
            // 
            // dgvCodigos
            // 
            this.dgvCodigos.AllowUserToAddRows = false;
            this.dgvCodigos.AllowUserToDeleteRows = false;
            this.dgvCodigos.AllowUserToResizeColumns = false;
            this.dgvCodigos.AllowUserToResizeRows = false;
            this.dgvCodigos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvCodigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo});
            this.dgvCodigos.Enabled = false;
            this.dgvCodigos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCodigos.Location = new System.Drawing.Point(12, 82);
            this.dgvCodigos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCodigos.Name = "dgvCodigos";
            this.dgvCodigos.ReadOnly = true;
            this.dgvCodigos.RowTemplate.Height = 24;
            this.dgvCodigos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCodigos.Size = new System.Drawing.Size(457, 123);
            this.dgvCodigos.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "cadena";
            this.Codigo.HeaderText = "Código PUCP";
            this.Codigo.MaxInputLength = 20;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(543, 537);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(221, 39);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(293, 537);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(221, 39);
            this.BtnCancelar.TabIndex = 177;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // StudentModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentModify";
            this.Size = new System.Drawing.Size(1053, 633);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.RadioButton rbnDNI;
        private System.Windows.Forms.RadioButton rbnCarneExtranjeria;
        private System.Windows.Forms.RadioButton rbnPasaporte;
        private System.Windows.Forms.Button btnBuscarDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCodigos;
        private System.Windows.Forms.Button btnAgregarCodigos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
    }
}
