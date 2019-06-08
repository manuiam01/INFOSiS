namespace INFOSiSView
{
    partial class frmProfessorManager
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
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.rbForeignCard = new System.Windows.Forms.RadioButton();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPrimaryLastName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtSecondLastName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblHomephone = new System.Windows.Forms.Label();
            this.txtHomephone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailPUCP = new System.Windows.Forms.Label();
            this.txtEmailPUCP = new System.Windows.Forms.TextBox();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rbJP = new System.Windows.Forms.RadioButton();
            this.lblProfessorCathegory = new System.Windows.Forms.Label();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.lblCondition = new System.Windows.Forms.Label();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.dgvProfessors = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.SuspendLayout();
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(173, 32);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(44, 17);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(36, 34);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(104, 13);
            this.lblDocumentType.TabIndex = 1;
            this.lblDocumentType.Text = "Tipo de Documento:";
            // 
            // rbForeignCard
            // 
            this.rbForeignCard.AutoSize = true;
            this.rbForeignCard.Location = new System.Drawing.Point(223, 32);
            this.rbForeignCard.Name = "rbForeignCard";
            this.rbForeignCard.Size = new System.Drawing.Size(121, 17);
            this.rbForeignCard.TabIndex = 2;
            this.rbForeignCard.TabStop = true;
            this.rbForeignCard.Text = "Carné de extranjería";
            this.rbForeignCard.UseVisualStyleBackColor = true;
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Location = new System.Drawing.Point(350, 32);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(73, 17);
            this.rbPassport.TabIndex = 3;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Pasaporte";
            this.rbPassport.UseVisualStyleBackColor = true;
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(173, 55);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(171, 20);
            this.txtDocumentNumber.TabIndex = 4;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(36, 58);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(120, 13);
            this.lblDocumentNumber.TabIndex = 5;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(37, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(47, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "Nombre:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(173, 81);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(171, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Location = new System.Drawing.Point(173, 133);
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(171, 20);
            this.txtPrimaryLastName.TabIndex = 9;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(173, 107);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(171, 20);
            this.txtSecondName.TabIndex = 8;
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Location = new System.Drawing.Point(173, 162);
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(171, 20);
            this.txtSecondLastName.TabIndex = 10;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(36, 110);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(91, 13);
            this.lblSecondName.TabIndex = 11;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Location = new System.Drawing.Point(36, 165);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(88, 13);
            this.lblSecondLastName.TabIndex = 13;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Location = new System.Drawing.Point(36, 136);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(86, 13);
            this.lblPrimaryLastName.TabIndex = 12;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(230, 188);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(62, 17);
            this.rbMan.TabIndex = 16;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Hombre";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(36, 190);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(31, 13);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Sexo";
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(173, 188);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(51, 17);
            this.rbWoman.TabIndex = 14;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Mujer";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(36, 214);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(42, 13);
            this.lblCellphone.TabIndex = 18;
            this.lblCellphone.Text = "Celular:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(173, 211);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(171, 20);
            this.txtCellphone.TabIndex = 17;
            // 
            // lblHomephone
            // 
            this.lblHomephone.AutoSize = true;
            this.lblHomephone.Location = new System.Drawing.Point(36, 240);
            this.lblHomephone.Name = "lblHomephone";
            this.lblHomephone.Size = new System.Drawing.Size(68, 13);
            this.lblHomephone.TabIndex = 20;
            this.lblHomephone.Text = "Teléfono fijo:";
            // 
            // txtHomephone
            // 
            this.txtHomephone.Location = new System.Drawing.Point(173, 237);
            this.txtHomephone.Name = "txtHomephone";
            this.txtHomephone.Size = new System.Drawing.Size(171, 20);
            this.txtHomephone.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 292);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Correo alterno:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Location = new System.Drawing.Point(36, 266);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(73, 13);
            this.lblEmailPUCP.TabIndex = 22;
            this.lblEmailPUCP.Text = "Correo PUCP:";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Location = new System.Drawing.Point(173, 263);
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(171, 20);
            this.txtEmailPUCP.TabIndex = 21;
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Location = new System.Drawing.Point(37, 318);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(75, 13);
            this.lblPUCPCode.TabIndex = 26;
            this.lblPUCPCode.Text = "Código PUCP:";
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Location = new System.Drawing.Point(173, 315);
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(171, 20);
            this.txtPUCPCode.TabIndex = 25;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(173, 341);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 27;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(36, 347);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(109, 13);
            this.lblBirthday.TabIndex = 28;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(37, 370);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 13);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(173, 367);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 20);
            this.txtAddress.TabIndex = 29;
            // 
            // rbJP
            // 
            this.rbJP.AutoSize = true;
            this.rbJP.Location = new System.Drawing.Point(243, 393);
            this.rbJP.Name = "rbJP";
            this.rbJP.Size = new System.Drawing.Size(101, 17);
            this.rbJP.TabIndex = 33;
            this.rbJP.TabStop = true;
            this.rbJP.Text = "Jefe de práctica";
            this.rbJP.UseVisualStyleBackColor = true;
            // 
            // lblProfessorCathegory
            // 
            this.lblProfessorCathegory.AutoSize = true;
            this.lblProfessorCathegory.Location = new System.Drawing.Point(37, 395);
            this.lblProfessorCathegory.Name = "lblProfessorCathegory";
            this.lblProfessorCathegory.Size = new System.Drawing.Size(99, 13);
            this.lblProfessorCathegory.TabIndex = 32;
            this.lblProfessorCathegory.Text = "Categoría docente:";
            // 
            // rbProfessor
            // 
            this.rbProfessor.AutoSize = true;
            this.rbProfessor.Location = new System.Drawing.Point(173, 393);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Size = new System.Drawing.Size(64, 17);
            this.rbProfessor.TabIndex = 31;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Profesor";
            this.rbProfessor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Dirección:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 34;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(243, 442);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(63, 17);
            this.rbInactive.TabIndex = 38;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactivo";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(37, 444);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(57, 13);
            this.lblCondition.TabIndex = 37;
            this.lblCondition.Text = "Condición:";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(173, 442);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(55, 17);
            this.rbActive.TabIndex = 36;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Activo";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // dgvProfessors
            // 
            this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.Correo,
            this.Celular});
            this.dgvProfessors.Location = new System.Drawing.Point(39, 465);
            this.dgvProfessors.Name = "dgvProfessors";
            this.dgvProfessors.Size = new System.Drawing.Size(738, 150);
            this.dgvProfessors.TabIndex = 39;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 120;
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.HeaderText = "Apellido_Paterno";
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            this.Apellido_Paterno.ReadOnly = true;
            this.Apellido_Paterno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido_Paterno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Apellido_Paterno.Width = 120;
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.HeaderText = "Apellido_Materno";
            this.Apellido_Materno.Name = "Apellido_Materno";
            this.Apellido_Materno.ReadOnly = true;
            this.Apellido_Materno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido_Materno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Apellido_Materno.Width = 120;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Correo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Correo.Width = 220;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Celular.Width = 120;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(451, 79);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 23);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(451, 108);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(96, 23);
            this.btModify.TabIndex = 41;
            this.btModify.Text = "Modificar";
            this.btModify.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(451, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(451, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 23);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(451, 224);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(96, 23);
            this.btnReporte.TabIndex = 45;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // frmProfessorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 638);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvProfessors);
            this.Controls.Add(this.rbInactive);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbJP);
            this.Controls.Add(this.lblProfessorCathegory);
            this.Controls.Add(this.rbProfessor);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblPUCPCode);
            this.Controls.Add(this.txtPUCPCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmailPUCP);
            this.Controls.Add(this.txtEmailPUCP);
            this.Controls.Add(this.lblHomephone);
            this.Controls.Add(this.txtHomephone);
            this.Controls.Add(this.lblCellphone);
            this.Controls.Add(this.txtCellphone);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.lblSecondLastName);
            this.Controls.Add(this.lblPrimaryLastName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.txtSecondLastName);
            this.Controls.Add(this.txtPrimaryLastName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDocumentNumber);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.rbPassport);
            this.Controls.Add(this.rbForeignCard);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.rbDNI);
            this.Name = "frmProfessorManager";
            this.Text = "Gestión de profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.RadioButton rbForeignCard;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPrimaryLastName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtSecondLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblHomephone;
        private System.Windows.Forms.TextBox txtHomephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailPUCP;
        private System.Windows.Forms.TextBox txtEmailPUCP;
        private System.Windows.Forms.Label lblPUCPCode;
        private System.Windows.Forms.TextBox txtPUCPCode;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbJP;
        private System.Windows.Forms.Label lblProfessorCathegory;
        private System.Windows.Forms.RadioButton rbProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.DataGridView dgvProfessors;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.Button btnReporte;
    }
}