﻿namespace INFOSiS_2._0
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
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.lblEmailPUCP = new System.Windows.Forms.Label();
            this.txtHomephone = new System.Windows.Forms.TextBox();
            this.txtEmailPUCP = new System.Windows.Forms.TextBox();
            this.lblHomephone = new System.Windows.Forms.Label();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
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
            this.lblInterestedRegister.Location = new System.Drawing.Point(13, 26);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(477, 59);
            this.lblInterestedRegister.TabIndex = 172;
            this.lblInterestedRegister.Text = "Modificar interesado";
            // 
            // gbCursos
            // 
            this.gbCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCursos.Controls.Add(this.btBuscarCursos);
            this.gbCursos.Controls.Add(this.dgvInterestedCourses);
            this.gbCursos.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCursos.Location = new System.Drawing.Point(573, 309);
            this.gbCursos.Margin = new System.Windows.Forms.Padding(4);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Padding = new System.Windows.Forms.Padding(4);
            this.gbCursos.Size = new System.Drawing.Size(477, 263);
            this.gbCursos.TabIndex = 178;
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
            this.btBuscarCursos.Location = new System.Drawing.Point(8, 28);
            this.btBuscarCursos.Name = "btBuscarCursos";
            this.btBuscarCursos.Size = new System.Drawing.Size(154, 38);
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
            this.dgvInterestedCourses.Size = new System.Drawing.Size(461, 180);
            this.dgvInterestedCourses.TabIndex = 0;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNombre.Width = 415;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtCellphone);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblCellphone);
            this.groupBox2.Controls.Add(this.lblEmailPUCP);
            this.groupBox2.Controls.Add(this.txtHomephone);
            this.groupBox2.Controls.Add(this.txtEmailPUCP);
            this.groupBox2.Controls.Add(this.lblHomephone);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(573, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(477, 212);
            this.groupBox2.TabIndex = 177;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 175);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(123, 25);
            this.lblEmail.TabIndex = 180;
            this.lblEmail.Text = "Correo alterno:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(152, 50);
            this.txtCellphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(227, 31);
            this.txtCellphone.TabIndex = 173;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 169);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 31);
            this.txtEmail.TabIndex = 179;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(77, 52);
            this.lblCellphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(67, 25);
            this.lblCellphone.TabIndex = 174;
            this.lblCellphone.Text = "Celular:";
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPUCP.Location = new System.Drawing.Point(29, 134);
            this.lblEmailPUCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(115, 25);
            this.lblEmailPUCP.TabIndex = 178;
            this.lblEmailPUCP.Text = "Correo PUCP:";
            // 
            // txtHomephone
            // 
            this.txtHomephone.Location = new System.Drawing.Point(152, 90);
            this.txtHomephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtHomephone.Name = "txtHomephone";
            this.txtHomephone.Size = new System.Drawing.Size(227, 31);
            this.txtHomephone.TabIndex = 175;
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Location = new System.Drawing.Point(152, 129);
            this.txtEmailPUCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(227, 31);
            this.txtEmailPUCP.TabIndex = 177;
            // 
            // lblHomephone
            // 
            this.lblHomephone.AutoSize = true;
            this.lblHomephone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomephone.Location = new System.Drawing.Point(40, 94);
            this.lblHomephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomephone.Name = "lblHomephone";
            this.lblHomephone.Size = new System.Drawing.Size(103, 25);
            this.lblHomephone.TabIndex = 176;
            this.lblHomephone.Text = "Teléfono fijo:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLastName.Location = new System.Drawing.Point(52, 161);
            this.lblSecondLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(138, 25);
            this.lblSecondLastName.TabIndex = 162;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(56, 124);
            this.lblPrimaryLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(134, 25);
            this.lblPrimaryLastName.TabIndex = 161;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(55, 84);
            this.lblSecondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(136, 25);
            this.lblSecondName.TabIndex = 160;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(117, 46);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 25);
            this.lblFirstName.TabIndex = 159;
            this.lblFirstName.Text = "Nombre:";
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(28, 173);
            this.lblDocumentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(185, 25);
            this.lblDocumentNumber.TabIndex = 158;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // txbNDocumento
            // 
            this.txbNDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNDocumento.Location = new System.Drawing.Point(224, 175);
            this.txbNDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txbNDocumento.Name = "txbNDocumento";
            this.txbNDocumento.Size = new System.Drawing.Size(253, 22);
            this.txbNDocumento.TabIndex = 165;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(200, 38);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(253, 31);
            this.txbNombre.TabIndex = 166;
            // 
            // txbSegundoNom
            // 
            this.txbSegundoNom.Location = new System.Drawing.Point(201, 77);
            this.txbSegundoNom.Margin = new System.Windows.Forms.Padding(4);
            this.txbSegundoNom.Name = "txbSegundoNom";
            this.txbSegundoNom.Size = new System.Drawing.Size(253, 31);
            this.txbSegundoNom.TabIndex = 167;
            // 
            // txbApePa
            // 
            this.txbApePa.Location = new System.Drawing.Point(200, 118);
            this.txbApePa.Margin = new System.Windows.Forms.Padding(4);
            this.txbApePa.Name = "txbApePa";
            this.txbApePa.Size = new System.Drawing.Size(253, 31);
            this.txbApePa.TabIndex = 168;
            // 
            // txbApeMa
            // 
            this.txbApeMa.Location = new System.Drawing.Point(200, 157);
            this.txbApeMa.Margin = new System.Windows.Forms.Padding(4);
            this.txbApeMa.Name = "txbApeMa";
            this.txbApeMa.Size = new System.Drawing.Size(253, 31);
            this.txbApeMa.TabIndex = 169;
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
            this.gbxInterestedData.Location = new System.Drawing.Point(21, 253);
            this.gbxInterestedData.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInterestedData.Name = "gbxInterestedData";
            this.gbxInterestedData.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInterestedData.Size = new System.Drawing.Size(517, 212);
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
            this.groupBox1.Location = new System.Drawing.Point(30, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(449, 76);
            this.groupBox1.TabIndex = 179;
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
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(33, 205);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 40);
            this.btnSave.TabIndex = 175;
            this.btnSave.Text = "Buscar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btModificar
            // 
            this.btModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btModificar.FlatAppearance.BorderSize = 0;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btModificar.ForeColor = System.Drawing.Color.White;
            this.btModificar.Location = new System.Drawing.Point(30, 524);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(198, 48);
            this.btModificar.TabIndex = 180;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(316, 524);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(198, 48);
            this.btCancelar.TabIndex = 181;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // InterestedModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxInterestedData);
            this.Controls.Add(this.txbNDocumento);
            this.Controls.Add(this.lblInterestedRegister);
            this.Controls.Add(this.lblDocumentNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterestedModified";
            this.Size = new System.Drawing.Size(1085, 697);
            this.Load += new System.EventHandler(this.InterestedSearch_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Label lblEmailPUCP;
        private System.Windows.Forms.TextBox txtHomephone;
        private System.Windows.Forms.TextBox txtEmailPUCP;
        private System.Windows.Forms.Label lblHomephone;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btCancelar;
    }
}