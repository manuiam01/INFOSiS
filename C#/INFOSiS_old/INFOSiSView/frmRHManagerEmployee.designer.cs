namespace INFOSiSView
{
    partial class frmRHManagerEmployee
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
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailPUCP = new System.Windows.Forms.Label();
            this.txtEmailPUCP = new System.Windows.Forms.TextBox();
            this.lblHomephone = new System.Windows.Forms.Label();
            this.txtHomephone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtSecondLastName = new System.Windows.Forms.TextBox();
            this.txtPrimaryLastName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.rbForeignCard = new System.Windows.Forms.RadioButton();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dgvInterns = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_PUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnInternReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterns)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(143, 359);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(109, 13);
            this.lblBirthday.TabIndex = 57;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(280, 353);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 56;
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Location = new System.Drawing.Point(144, 330);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(75, 13);
            this.lblPUCPCode.TabIndex = 55;
            this.lblPUCPCode.Text = "Código PUCP:";
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Location = new System.Drawing.Point(280, 327);
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(171, 20);
            this.txtPUCPCode.TabIndex = 54;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(143, 304);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "Correo alterno:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(280, 301);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 52;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Location = new System.Drawing.Point(143, 278);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(73, 13);
            this.lblEmailPUCP.TabIndex = 51;
            this.lblEmailPUCP.Text = "Correo PUCP:";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Location = new System.Drawing.Point(280, 275);
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(171, 20);
            this.txtEmailPUCP.TabIndex = 50;
            // 
            // lblHomephone
            // 
            this.lblHomephone.AutoSize = true;
            this.lblHomephone.Location = new System.Drawing.Point(143, 252);
            this.lblHomephone.Name = "lblHomephone";
            this.lblHomephone.Size = new System.Drawing.Size(68, 13);
            this.lblHomephone.TabIndex = 49;
            this.lblHomephone.Text = "Teléfono fijo:";
            // 
            // txtHomephone
            // 
            this.txtHomephone.Location = new System.Drawing.Point(280, 249);
            this.txtHomephone.Name = "txtHomephone";
            this.txtHomephone.Size = new System.Drawing.Size(171, 20);
            this.txtHomephone.TabIndex = 48;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(143, 226);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(81, 13);
            this.lblCellphone.TabIndex = 47;
            this.lblCellphone.Text = "Número celular:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(280, 223);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(171, 20);
            this.txtCellphone.TabIndex = 46;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(337, 200);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(62, 17);
            this.rbMan.TabIndex = 45;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Hombre";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(143, 202);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(31, 13);
            this.lblGender.TabIndex = 44;
            this.lblGender.Text = "Sexo";
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(280, 200);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(51, 17);
            this.rbWoman.TabIndex = 43;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Mujer";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Location = new System.Drawing.Point(143, 177);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(88, 13);
            this.lblSecondLastName.TabIndex = 42;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Location = new System.Drawing.Point(143, 148);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(86, 13);
            this.lblPrimaryLastName.TabIndex = 41;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(143, 122);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(91, 13);
            this.lblSecondName.TabIndex = 40;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Location = new System.Drawing.Point(280, 174);
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(171, 20);
            this.txtSecondLastName.TabIndex = 39;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Location = new System.Drawing.Point(280, 145);
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(171, 20);
            this.txtPrimaryLastName.TabIndex = 38;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(280, 119);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(171, 20);
            this.txtSecondName.TabIndex = 37;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(280, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(171, 20);
            this.txtFirstName.TabIndex = 36;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(144, 96);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(47, 13);
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "Nombre:";
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(143, 70);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(120, 13);
            this.lblDocumentNumber.TabIndex = 34;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(280, 67);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(171, 20);
            this.txtDocumentNumber.TabIndex = 33;
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Location = new System.Drawing.Point(457, 44);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(73, 17);
            this.rbPassport.TabIndex = 32;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Pasaporte";
            this.rbPassport.UseVisualStyleBackColor = true;
            // 
            // rbForeignCard
            // 
            this.rbForeignCard.AutoSize = true;
            this.rbForeignCard.Location = new System.Drawing.Point(330, 44);
            this.rbForeignCard.Name = "rbForeignCard";
            this.rbForeignCard.Size = new System.Drawing.Size(121, 17);
            this.rbForeignCard.TabIndex = 31;
            this.rbForeignCard.TabStop = true;
            this.rbForeignCard.Text = "Carné de extranjería";
            this.rbForeignCard.UseVisualStyleBackColor = true;
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(143, 46);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(104, 13);
            this.lblDocumentType.TabIndex = 30;
            this.lblDocumentType.Text = "Tipo de Documento:";
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(280, 44);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(44, 17);
            this.rbDNI.TabIndex = 29;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(144, 382);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 13);
            this.lblAddress.TabIndex = 59;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(280, 379);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 20);
            this.txtAddress.TabIndex = 58;
            // 
            // dgvInterns
            // 
            this.dgvInterns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Segundo_Nombre,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.Código,
            this.Correo_PUCP,
            this.Celular});
            this.dgvInterns.Location = new System.Drawing.Point(35, 427);
            this.dgvInterns.Name = "dgvInterns";
            this.dgvInterns.Size = new System.Drawing.Size(743, 150);
            this.dgvInterns.TabIndex = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Segundo_Nombre
            // 
            this.Segundo_Nombre.HeaderText = "Segundo Nombre";
            this.Segundo_Nombre.Name = "Segundo_Nombre";
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.HeaderText = "Apellido Paterno";
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.HeaderText = "Apellido Materno";
            this.Apellido_Materno.Name = "Apellido_Materno";
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Correo_PUCP
            // 
            this.Correo_PUCP.HeaderText = "Correo PUCP";
            this.Correo_PUCP.Name = "Correo_PUCP";
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(616, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 23);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(616, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 23);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(616, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 23);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(616, 94);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(137, 23);
            this.btModify.TabIndex = 63;
            this.btModify.Text = "Modificar";
            this.btModify.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(616, 65);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(137, 23);
            this.btnNew.TabIndex = 62;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(616, 210);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(137, 23);
            this.btnSchedule.TabIndex = 67;
            this.btnSchedule.Text = "Horario";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnInternReport
            // 
            this.btnInternReport.Location = new System.Drawing.Point(616, 242);
            this.btnInternReport.Name = "btnInternReport";
            this.btnInternReport.Size = new System.Drawing.Size(137, 23);
            this.btnInternReport.TabIndex = 68;
            this.btnInternReport.Text = "Reporte";
            this.btnInternReport.UseVisualStyleBackColor = true;
            this.btnInternReport.Click += new System.EventHandler(this.BtnInternReport_Click);
            // 
            // frmRHManagerEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 608);
            this.Controls.Add(this.btnInternReport);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvInterns);
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
            this.Name = "frmRHManagerEmployee";
            this.Text = "Gestión de personal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblPUCPCode;
        private System.Windows.Forms.TextBox txtPUCPCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailPUCP;
        private System.Windows.Forms.TextBox txtEmailPUCP;
        private System.Windows.Forms.Label lblHomephone;
        private System.Windows.Forms.TextBox txtHomephone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondLastName;
        private System.Windows.Forms.TextBox txtPrimaryLastName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.RadioButton rbForeignCard;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dgvInterns;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_PUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnInternReport;
    }
}