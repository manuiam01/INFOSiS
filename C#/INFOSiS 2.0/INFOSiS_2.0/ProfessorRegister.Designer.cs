namespace INFOSiS_2._0
{
    partial class ProfessorRegister
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
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailPUCP = new System.Windows.Forms.Label();
            this.txtEmailPUCP = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
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
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.lblProfessorRegister = new System.Windows.Forms.Label();
            this.gbxPersonalData = new System.Windows.Forms.GroupBox();
            this.lblRequiredInfo = new System.Windows.Forms.Label();
            this.gbxSex = new System.Windows.Forms.GroupBox();
            this.gbxDocumentType = new System.Windows.Forms.GroupBox();
            this.gbxContactData = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxPersonalData.SuspendLayout();
            this.gbxSex.SuspendLayout();
            this.gbxDocumentType.SuspendLayout();
            this.gbxContactData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(33, 423);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(158, 25);
            this.lblBirthday.TabIndex = 157;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthday.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(196, 420);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpBirthday.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(300, 27);
            this.dtpBirthday.TabIndex = 156;
            this.dtpBirthday.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.DtpBirthday_ValueChanged);
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPCode.Location = new System.Drawing.Point(60, 60);
            this.lblPUCPCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(126, 25);
            this.lblPUCPCode.TabIndex = 155;
            this.lblPUCPCode.Text = "Código PUCP: *";
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPUCPCode.Location = new System.Drawing.Point(196, 55);
            this.txtPUCPCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPUCPCode.MaxLength = 8;
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(259, 31);
            this.txtPUCPCode.TabIndex = 154;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(25, 206);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(147, 25);
            this.lblEmail.TabIndex = 153;
            this.lblEmail.Text = "Correo alternativo:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(196, 203);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 31);
            this.txtEmail.TabIndex = 152;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPUCP.Location = new System.Drawing.Point(60, 155);
            this.lblEmailPUCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(127, 25);
            this.lblEmailPUCP.TabIndex = 151;
            this.lblEmailPUCP.Text = "Correo PUCP: *";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailPUCP.Location = new System.Drawing.Point(196, 153);
            this.txtEmailPUCP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmailPUCP.MaxLength = 45;
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(261, 31);
            this.txtEmailPUCP.TabIndex = 150;
            // 
            // lblCellphone
            // 
            this.lblCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(107, 107);
            this.lblCellphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(67, 25);
            this.lblCellphone.TabIndex = 147;
            this.lblCellphone.Text = "Celular:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCellphone.Location = new System.Drawing.Point(196, 103);
            this.txtCellphone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCellphone.MaxLength = 15;
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(261, 31);
            this.txtCellphone.TabIndex = 146;
            this.txtCellphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCellphone_KeyPress);
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMan.Location = new System.Drawing.Point(340, 15);
            this.rbMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(91, 29);
            this.rbMan.TabIndex = 145;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Hombre";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWoman.Location = new System.Drawing.Point(156, 15);
            this.rbWoman.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(74, 29);
            this.rbWoman.TabIndex = 143;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Mujer";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLastName.Location = new System.Drawing.Point(58, 375);
            this.lblSecondLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(150, 25);
            this.lblSecondLastName.TabIndex = 142;
            this.lblSecondLastName.Text = "Apellido materno: *";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(62, 329);
            this.lblPrimaryLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(146, 25);
            this.lblPrimaryLastName.TabIndex = 141;
            this.lblPrimaryLastName.Text = "Apellido paterno: *";
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(62, 284);
            this.lblSecondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(136, 25);
            this.lblSecondName.TabIndex = 140;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondLastName.Location = new System.Drawing.Point(220, 375);
            this.txtSecondLastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSecondLastName.MaxLength = 45;
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(276, 31);
            this.txtSecondLastName.TabIndex = 139;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimaryLastName.Location = new System.Drawing.Point(220, 329);
            this.txtPrimaryLastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrimaryLastName.MaxLength = 45;
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(276, 31);
            this.txtPrimaryLastName.TabIndex = 138;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondName.Location = new System.Drawing.Point(220, 284);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSecondName.MaxLength = 45;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(276, 31);
            this.txtSecondName.TabIndex = 137;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(220, 238);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(276, 31);
            this.txtFirstName.TabIndex = 136;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(74, 238);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(136, 25);
            this.lblFirstName.TabIndex = 135;
            this.lblFirstName.Text = "Primer nombre: *";
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(12, 193);
            this.lblDocumentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(202, 25);
            this.lblDocumentNumber.TabIndex = 134;
            this.lblDocumentNumber.Text = "Número de Documento: * ";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentNumber.Location = new System.Drawing.Point(220, 193);
            this.txtDocumentNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDocumentNumber.MaxLength = 8;
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(276, 31);
            this.txtDocumentNumber.TabIndex = 133;
            this.txtDocumentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumentNumber_KeyPress);
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassport.Location = new System.Drawing.Point(361, 33);
            this.rbPassport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(102, 29);
            this.rbPassport.TabIndex = 132;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Pasaporte";
            this.rbPassport.UseVisualStyleBackColor = true;
            this.rbPassport.CheckedChanged += new System.EventHandler(this.RbPassport_CheckedChanged);
            // 
            // rbForeignCard
            // 
            this.rbForeignCard.AutoSize = true;
            this.rbForeignCard.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForeignCard.Location = new System.Drawing.Point(143, 33);
            this.rbForeignCard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbForeignCard.Name = "rbForeignCard";
            this.rbForeignCard.Size = new System.Drawing.Size(179, 29);
            this.rbForeignCard.TabIndex = 131;
            this.rbForeignCard.TabStop = true;
            this.rbForeignCard.Text = "Carné de extranjería";
            this.rbForeignCard.UseVisualStyleBackColor = true;
            this.rbForeignCard.CheckedChanged += new System.EventHandler(this.RbForeignCard_CheckedChanged);
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDNI.Location = new System.Drawing.Point(16, 33);
            this.rbDNI.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(63, 29);
            this.rbDNI.TabIndex = 129;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            this.rbDNI.CheckedChanged += new System.EventHandler(this.RbDNI_CheckedChanged);
            // 
            // lblProfessorRegister
            // 
            this.lblProfessorRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfessorRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorRegister.Location = new System.Drawing.Point(27, 6);
            this.lblProfessorRegister.Name = "lblProfessorRegister";
            this.lblProfessorRegister.Size = new System.Drawing.Size(477, 59);
            this.lblProfessorRegister.TabIndex = 170;
            this.lblProfessorRegister.Text = "Registrar un profesor";
            // 
            // gbxPersonalData
            // 
            this.gbxPersonalData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxPersonalData.Controls.Add(this.lblRequiredInfo);
            this.gbxPersonalData.Controls.Add(this.gbxSex);
            this.gbxPersonalData.Controls.Add(this.gbxDocumentType);
            this.gbxPersonalData.Controls.Add(this.txtDocumentNumber);
            this.gbxPersonalData.Controls.Add(this.lblDocumentNumber);
            this.gbxPersonalData.Controls.Add(this.lblFirstName);
            this.gbxPersonalData.Controls.Add(this.dtpBirthday);
            this.gbxPersonalData.Controls.Add(this.txtFirstName);
            this.gbxPersonalData.Controls.Add(this.lblBirthday);
            this.gbxPersonalData.Controls.Add(this.txtSecondName);
            this.gbxPersonalData.Controls.Add(this.txtPrimaryLastName);
            this.gbxPersonalData.Controls.Add(this.txtSecondLastName);
            this.gbxPersonalData.Controls.Add(this.lblSecondName);
            this.gbxPersonalData.Controls.Add(this.lblPrimaryLastName);
            this.gbxPersonalData.Controls.Add(this.lblSecondLastName);
            this.gbxPersonalData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPersonalData.Location = new System.Drawing.Point(27, 67);
            this.gbxPersonalData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPersonalData.Name = "gbxPersonalData";
            this.gbxPersonalData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPersonalData.Size = new System.Drawing.Size(519, 519);
            this.gbxPersonalData.TabIndex = 171;
            this.gbxPersonalData.TabStop = false;
            this.gbxPersonalData.Text = "Datos Personales";
            // 
            // lblRequiredInfo
            // 
            this.lblRequiredInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequiredInfo.AutoSize = true;
            this.lblRequiredInfo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequiredInfo.Location = new System.Drawing.Point(19, 49);
            this.lblRequiredInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequiredInfo.Name = "lblRequiredInfo";
            this.lblRequiredInfo.Size = new System.Drawing.Size(176, 25);
            this.lblRequiredInfo.TabIndex = 167;
            this.lblRequiredInfo.Text = "* Campo obligatorio";
            // 
            // gbxSex
            // 
            this.gbxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxSex.Controls.Add(this.rbWoman);
            this.gbxSex.Controls.Add(this.rbMan);
            this.gbxSex.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSex.Location = new System.Drawing.Point(28, 457);
            this.gbxSex.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxSex.Name = "gbxSex";
            this.gbxSex.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxSex.Size = new System.Drawing.Size(468, 52);
            this.gbxSex.TabIndex = 159;
            this.gbxSex.TabStop = false;
            this.gbxSex.Text = "Sexo:";
            // 
            // gbxDocumentType
            // 
            this.gbxDocumentType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxDocumentType.Controls.Add(this.rbDNI);
            this.gbxDocumentType.Controls.Add(this.rbForeignCard);
            this.gbxDocumentType.Controls.Add(this.rbPassport);
            this.gbxDocumentType.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDocumentType.Location = new System.Drawing.Point(8, 96);
            this.gbxDocumentType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxDocumentType.Name = "gbxDocumentType";
            this.gbxDocumentType.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxDocumentType.Size = new System.Drawing.Size(488, 71);
            this.gbxDocumentType.TabIndex = 158;
            this.gbxDocumentType.TabStop = false;
            this.gbxDocumentType.Text = "Tipo de Documento: *";
            // 
            // gbxContactData
            // 
            this.gbxContactData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxContactData.Controls.Add(this.lblEmail);
            this.gbxContactData.Controls.Add(this.txtCellphone);
            this.gbxContactData.Controls.Add(this.lblCellphone);
            this.gbxContactData.Controls.Add(this.txtEmailPUCP);
            this.gbxContactData.Controls.Add(this.lblEmailPUCP);
            this.gbxContactData.Controls.Add(this.txtEmail);
            this.gbxContactData.Controls.Add(this.txtPUCPCode);
            this.gbxContactData.Controls.Add(this.lblPUCPCode);
            this.gbxContactData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContactData.Location = new System.Drawing.Point(572, 67);
            this.gbxContactData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxContactData.Name = "gbxContactData";
            this.gbxContactData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxContactData.Size = new System.Drawing.Size(493, 286);
            this.gbxContactData.TabIndex = 172;
            this.gbxContactData.TabStop = false;
            this.gbxContactData.Text = "Datos de contacto";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(289, 596);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 48);
            this.btnSave.TabIndex = 177;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(633, 596);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 48);
            this.btnCancel.TabIndex = 179;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProfessorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxContactData);
            this.Controls.Add(this.lblProfessorRegister);
            this.Controls.Add(this.gbxPersonalData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfessorRegister";
            this.Size = new System.Drawing.Size(1081, 701);
            this.gbxPersonalData.ResumeLayout(false);
            this.gbxPersonalData.PerformLayout();
            this.gbxSex.ResumeLayout(false);
            this.gbxSex.PerformLayout();
            this.gbxDocumentType.ResumeLayout(false);
            this.gbxDocumentType.PerformLayout();
            this.gbxContactData.ResumeLayout(false);
            this.gbxContactData.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.RadioButton rbMan;
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
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Label lblProfessorRegister;
        private System.Windows.Forms.GroupBox gbxPersonalData;
        private System.Windows.Forms.GroupBox gbxContactData;
        private System.Windows.Forms.GroupBox gbxSex;
        private System.Windows.Forms.GroupBox gbxDocumentType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRequiredInfo;
    }
}
