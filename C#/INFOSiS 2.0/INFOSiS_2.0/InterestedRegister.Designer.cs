﻿namespace INFOSiS_2._0
{
    partial class InterestedRegister
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
            this.gbxInterestedData = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txbApeMa = new System.Windows.Forms.TextBox();
            this.txbApePa = new System.Windows.Forms.TextBox();
            this.txbSegundoNom = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbNDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPasaporte = new System.Windows.Forms.RadioButton();
            this.rbCarnet = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.btBuscarCursos = new System.Windows.Forms.Button();
            this.dgvInterestedCourses = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxInterestedData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterestedCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(13, 26);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(477, 59);
            this.lblInterestedRegister.TabIndex = 171;
            this.lblInterestedRegister.Text = "Registrar un interesado";
            // 
            // gbxInterestedData
            // 
            this.gbxInterestedData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInterestedData.Controls.Add(this.rbFemale);
            this.gbxInterestedData.Controls.Add(this.rbMale);
            this.gbxInterestedData.Controls.Add(this.txbApeMa);
            this.gbxInterestedData.Controls.Add(this.txbApePa);
            this.gbxInterestedData.Controls.Add(this.txbSegundoNom);
            this.gbxInterestedData.Controls.Add(this.txbNombre);
            this.gbxInterestedData.Controls.Add(this.txbNDocumento);
            this.gbxInterestedData.Controls.Add(this.lblDocumentNumber);
            this.gbxInterestedData.Controls.Add(this.lblFirstName);
            this.gbxInterestedData.Controls.Add(this.lblSecondName);
            this.gbxInterestedData.Controls.Add(this.lblPrimaryLastName);
            this.gbxInterestedData.Controls.Add(this.lblSecondLastName);
            this.gbxInterestedData.Controls.Add(this.lblGender);
            this.gbxInterestedData.Controls.Add(this.groupBox1);
            this.gbxInterestedData.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.gbxInterestedData.Location = new System.Drawing.Point(11, 96);
            this.gbxInterestedData.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInterestedData.Name = "gbxInterestedData";
            this.gbxInterestedData.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInterestedData.Size = new System.Drawing.Size(517, 373);
            this.gbxInterestedData.TabIndex = 172;
            this.gbxInterestedData.TabStop = false;
            this.gbxInterestedData.Text = "Datos Personales";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbFemale.Location = new System.Drawing.Point(303, 327);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 29);
            this.rbFemale.TabIndex = 171;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Mujer";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbMale.Location = new System.Drawing.Point(201, 327);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(91, 29);
            this.rbMale.TabIndex = 170;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Hombre";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txbApeMa
            // 
            this.txbApeMa.Location = new System.Drawing.Point(200, 288);
            this.txbApeMa.Margin = new System.Windows.Forms.Padding(4);
            this.txbApeMa.Name = "txbApeMa";
            this.txbApeMa.Size = new System.Drawing.Size(253, 31);
            this.txbApeMa.TabIndex = 169;
            // 
            // txbApePa
            // 
            this.txbApePa.Location = new System.Drawing.Point(200, 249);
            this.txbApePa.Margin = new System.Windows.Forms.Padding(4);
            this.txbApePa.Name = "txbApePa";
            this.txbApePa.Size = new System.Drawing.Size(253, 31);
            this.txbApePa.TabIndex = 168;
            // 
            // txbSegundoNom
            // 
            this.txbSegundoNom.Location = new System.Drawing.Point(201, 208);
            this.txbSegundoNom.Margin = new System.Windows.Forms.Padding(4);
            this.txbSegundoNom.Name = "txbSegundoNom";
            this.txbSegundoNom.Size = new System.Drawing.Size(253, 31);
            this.txbSegundoNom.TabIndex = 167;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(200, 169);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(253, 31);
            this.txbNombre.TabIndex = 166;
            // 
            // txbNDocumento
            // 
            this.txbNDocumento.Location = new System.Drawing.Point(200, 128);
            this.txbNDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txbNDocumento.Name = "txbNDocumento";
            this.txbNDocumento.Size = new System.Drawing.Size(253, 31);
            this.txbNDocumento.TabIndex = 165;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(4, 138);
            this.lblDocumentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(185, 25);
            this.lblDocumentNumber.TabIndex = 158;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(117, 177);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 25);
            this.lblFirstName.TabIndex = 159;
            this.lblFirstName.Text = "Nombre:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(55, 215);
            this.lblSecondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(136, 25);
            this.lblSecondName.TabIndex = 160;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(56, 255);
            this.lblPrimaryLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(134, 25);
            this.lblPrimaryLastName.TabIndex = 161;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLastName.Location = new System.Drawing.Point(52, 292);
            this.lblSecondLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(138, 25);
            this.lblSecondLastName.TabIndex = 162;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(135, 327);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(50, 25);
            this.lblGender.TabIndex = 163;
            this.lblGender.Text = "Sexo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPasaporte);
            this.groupBox1.Controls.Add(this.rbCarnet);
            this.groupBox1.Controls.Add(this.rbDNI);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(449, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Documento";
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbPasaporte.Location = new System.Drawing.Point(331, 32);
            this.rbPasaporte.Margin = new System.Windows.Forms.Padding(4);
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Size = new System.Drawing.Size(102, 29);
            this.rbPasaporte.TabIndex = 2;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            // 
            // rbCarnet
            // 
            this.rbCarnet.AutoSize = true;
            this.rbCarnet.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbCarnet.Location = new System.Drawing.Point(121, 32);
            this.rbCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.rbCarnet.Name = "rbCarnet";
            this.rbCarnet.Size = new System.Drawing.Size(180, 29);
            this.rbCarnet.TabIndex = 1;
            this.rbCarnet.TabStop = true;
            this.rbCarnet.Text = "Carné de Extranjería";
            this.rbCarnet.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbDNI.Location = new System.Drawing.Point(37, 32);
            this.rbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(63, 29);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtCellphone);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblCellphone);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 470);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(517, 112);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(76, 78);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 25);
            this.lblEmail.TabIndex = 180;
            this.lblEmail.Text = "Correo:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(152, 36);
            this.txtCellphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(317, 31);
            this.txtCellphone.TabIndex = 173;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 76);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(317, 31);
            this.txtEmail.TabIndex = 179;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(77, 38);
            this.lblCellphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(67, 25);
            this.lblCellphone.TabIndex = 174;
            this.lblCellphone.Text = "Celular:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(307, 613);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 48);
            this.btnSave.TabIndex = 174;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // gbCursos
            // 
            this.gbCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCursos.Controls.Add(this.btBuscarCursos);
            this.gbCursos.Controls.Add(this.dgvInterestedCourses);
            this.gbCursos.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCursos.Location = new System.Drawing.Point(557, 96);
            this.gbCursos.Margin = new System.Windows.Forms.Padding(4);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Padding = new System.Windows.Forms.Padding(4);
            this.gbCursos.Size = new System.Drawing.Size(477, 486);
            this.gbCursos.TabIndex = 175;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos de interés";
            // 
            // btBuscarCursos
            // 
            this.btBuscarCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBuscarCursos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btBuscarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarCursos.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.btBuscarCursos.ForeColor = System.Drawing.Color.White;
            this.btBuscarCursos.Location = new System.Drawing.Point(7, 24);
            this.btBuscarCursos.Name = "btBuscarCursos";
            this.btBuscarCursos.Size = new System.Drawing.Size(154, 35);
            this.btBuscarCursos.TabIndex = 1;
            this.btBuscarCursos.Text = "Escoger cursos";
            this.btBuscarCursos.UseVisualStyleBackColor = false;
            this.btBuscarCursos.Click += new System.EventHandler(this.BtBuscarCursos_Click);
            // 
            // dgvInterestedCourses
            // 
            this.dgvInterestedCourses.AllowUserToAddRows = false;
            this.dgvInterestedCourses.AllowUserToDeleteRows = false;
            this.dgvInterestedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterestedCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre});
            this.dgvInterestedCourses.Location = new System.Drawing.Point(8, 75);
            this.dgvInterestedCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInterestedCourses.Name = "dgvInterestedCourses";
            this.dgvInterestedCourses.ReadOnly = true;
            this.dgvInterestedCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterestedCourses.Size = new System.Drawing.Size(461, 403);
            this.dgvInterestedCourses.TabIndex = 0;
            this.dgvInterestedCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInterestedCourses_CellContentClick);
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNombre.Width = 415;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(565, 613);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 48);
            this.btnCancel.TabIndex = 176;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // InterestedRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxInterestedData);
            this.Controls.Add(this.lblInterestedRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterestedRegister";
            this.Size = new System.Drawing.Size(1081, 697);
            this.Load += new System.EventHandler(this.InterestedRegister_Load);
            this.Leave += new System.EventHandler(this.InterestedRegister_Leave);
            this.gbxInterestedData.ResumeLayout(false);
            this.gbxInterestedData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterestedCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.GroupBox gbxInterestedData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPasaporte;
        private System.Windows.Forms.RadioButton rbCarnet;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txbNDocumento;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbSegundoNom;
        private System.Windows.Forms.TextBox txbApePa;
        private System.Windows.Forms.TextBox txbApeMa;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.DataGridView dgvInterestedCourses;
        private System.Windows.Forms.Button btBuscarCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancel;
    }
}
