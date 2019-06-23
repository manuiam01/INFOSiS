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
            this.lblRequired0 = new System.Windows.Forms.Label();
            this.lblRequiredInfo = new System.Windows.Forms.Label();
            this.lblRequired4 = new System.Windows.Forms.Label();
            this.lblRequired3 = new System.Windows.Forms.Label();
            this.lblRequired2 = new System.Windows.Forms.Label();
            this.lblRequired1 = new System.Windows.Forms.Label();
            this.gbxSex = new System.Windows.Forms.GroupBox();
            this.gbxDocumentType = new System.Windows.Forms.GroupBox();
            this.gbxContactData = new System.Windows.Forms.GroupBox();
            this.lblRequired7 = new System.Windows.Forms.Label();
            this.lblRequired8 = new System.Windows.Forms.Label();
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
            this.lblBirthday.Location = new System.Drawing.Point(5, 356);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(122, 18);
            this.lblBirthday.TabIndex = 157;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthday.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(133, 356);
            this.dtpBirthday.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(223, 23);
            this.dtpBirthday.TabIndex = 156;
            this.dtpBirthday.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.DtpBirthday_ValueChanged);
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPCode.Location = new System.Drawing.Point(34, 60);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(86, 18);
            this.lblPUCPCode.TabIndex = 155;
            this.lblPUCPCode.Text = "Código PUCP:";
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPUCPCode.Location = new System.Drawing.Point(126, 54);
            this.txtPUCPCode.MaxLength = 8;
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(204, 26);
            this.txtPUCPCode.TabIndex = 154;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(111, 18);
            this.lblEmail.TabIndex = 153;
            this.lblEmail.Text = "Correo alternativo:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(126, 151);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 26);
            this.txtEmail.TabIndex = 152;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPUCP.Location = new System.Drawing.Point(34, 125);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(86, 18);
            this.lblEmailPUCP.TabIndex = 151;
            this.lblEmailPUCP.Text = "Correo PUCP:";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailPUCP.Location = new System.Drawing.Point(126, 118);
            this.txtEmailPUCP.MaxLength = 45;
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(206, 26);
            this.txtEmailPUCP.TabIndex = 150;
            // 
            // lblCellphone
            // 
            this.lblCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(70, 92);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(50, 18);
            this.lblCellphone.TabIndex = 147;
            this.lblCellphone.Text = "Celular:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCellphone.Location = new System.Drawing.Point(126, 85);
            this.txtCellphone.MaxLength = 15;
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(206, 26);
            this.txtCellphone.TabIndex = 146;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMan.Location = new System.Drawing.Point(191, 10);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(70, 22);
            this.rbMan.TabIndex = 145;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Hombre";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWoman.Location = new System.Drawing.Point(88, 10);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(57, 22);
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
            this.lblSecondLastName.Location = new System.Drawing.Point(46, 251);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(105, 18);
            this.lblSecondLastName.TabIndex = 142;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(49, 220);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(102, 18);
            this.lblPrimaryLastName.TabIndex = 141;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(48, 189);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(103, 18);
            this.lblSecondName.TabIndex = 140;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondLastName.Location = new System.Drawing.Point(178, 251);
            this.txtSecondLastName.MaxLength = 45;
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(178, 26);
            this.txtSecondLastName.TabIndex = 139;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimaryLastName.Location = new System.Drawing.Point(178, 219);
            this.txtPrimaryLastName.MaxLength = 45;
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(178, 26);
            this.txtPrimaryLastName.TabIndex = 138;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondName.Location = new System.Drawing.Point(178, 187);
            this.txtSecondName.MaxLength = 45;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(178, 26);
            this.txtSecondName.TabIndex = 137;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(178, 156);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 26);
            this.txtFirstName.TabIndex = 136;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(58, 158);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 18);
            this.lblFirstName.TabIndex = 135;
            this.lblFirstName.Text = "Primer nombre:";
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(10, 127);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(145, 18);
            this.lblDocumentNumber.TabIndex = 134;
            this.lblDocumentNumber.Text = "Número de Documento: ";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentNumber.Location = new System.Drawing.Point(178, 122);
            this.txtDocumentNumber.MaxLength = 12;
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(178, 26);
            this.txtDocumentNumber.TabIndex = 133;
            this.txtDocumentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumentNumber_KeyPress);
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassport.Location = new System.Drawing.Point(234, 22);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(79, 22);
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
            this.rbForeignCard.Location = new System.Drawing.Point(80, 22);
            this.rbForeignCard.Name = "rbForeignCard";
            this.rbForeignCard.Size = new System.Drawing.Size(138, 22);
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
            this.rbDNI.Location = new System.Drawing.Point(9, 22);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(49, 22);
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
            this.lblProfessorRegister.Location = new System.Drawing.Point(4, 21);
            this.lblProfessorRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfessorRegister.Name = "lblProfessorRegister";
            this.lblProfessorRegister.Size = new System.Drawing.Size(358, 48);
            this.lblProfessorRegister.TabIndex = 170;
            this.lblProfessorRegister.Text = "Registrar un profesor";
            // 
            // gbxPersonalData
            // 
            this.gbxPersonalData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxPersonalData.Controls.Add(this.lblRequired0);
            this.gbxPersonalData.Controls.Add(this.lblRequiredInfo);
            this.gbxPersonalData.Controls.Add(this.lblRequired4);
            this.gbxPersonalData.Controls.Add(this.lblRequired3);
            this.gbxPersonalData.Controls.Add(this.lblRequired2);
            this.gbxPersonalData.Controls.Add(this.lblRequired1);
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
            this.gbxPersonalData.Location = new System.Drawing.Point(8, 71);
            this.gbxPersonalData.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPersonalData.Name = "gbxPersonalData";
            this.gbxPersonalData.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPersonalData.Size = new System.Drawing.Size(391, 394);
            this.gbxPersonalData.TabIndex = 171;
            this.gbxPersonalData.TabStop = false;
            this.gbxPersonalData.Text = "Datos Personales";
            // 
            // lblRequired0
            // 
            this.lblRequired0.AutoSize = true;
            this.lblRequired0.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequired0.Location = new System.Drawing.Point(362, 81);
            this.lblRequired0.Name = "lblRequired0";
            this.lblRequired0.Size = new System.Drawing.Size(17, 21);
            this.lblRequired0.TabIndex = 168;
            this.lblRequired0.Text = "*";
            // 
            // lblRequiredInfo
            // 
            this.lblRequiredInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequiredInfo.AutoSize = true;
            this.lblRequiredInfo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequiredInfo.Location = new System.Drawing.Point(13, 28);
            this.lblRequiredInfo.Name = "lblRequiredInfo";
            this.lblRequiredInfo.Size = new System.Drawing.Size(136, 18);
            this.lblRequiredInfo.TabIndex = 167;
            this.lblRequiredInfo.Text = "* Campo obligatorio";
            // 
            // lblRequired4
            // 
            this.lblRequired4.AutoSize = true;
            this.lblRequired4.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequired4.Location = new System.Drawing.Point(362, 256);
            this.lblRequired4.Name = "lblRequired4";
            this.lblRequired4.Size = new System.Drawing.Size(17, 21);
            this.lblRequired4.TabIndex = 163;
            this.lblRequired4.Text = "*";
            // 
            // lblRequired3
            // 
            this.lblRequired3.AutoSize = true;
            this.lblRequired3.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequired3.Location = new System.Drawing.Point(362, 222);
            this.lblRequired3.Name = "lblRequired3";
            this.lblRequired3.Size = new System.Drawing.Size(17, 21);
            this.lblRequired3.TabIndex = 162;
            this.lblRequired3.Text = "*";
            // 
            // lblRequired2
            // 
            this.lblRequired2.AutoSize = true;
            this.lblRequired2.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequired2.Location = new System.Drawing.Point(362, 159);
            this.lblRequired2.Name = "lblRequired2";
            this.lblRequired2.Size = new System.Drawing.Size(17, 21);
            this.lblRequired2.TabIndex = 161;
            this.lblRequired2.Text = "*";
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequired1.Location = new System.Drawing.Point(362, 122);
            this.lblRequired1.Name = "lblRequired1";
            this.lblRequired1.Size = new System.Drawing.Size(17, 21);
            this.lblRequired1.TabIndex = 160;
            this.lblRequired1.Text = "*";
            // 
            // gbxSex
            // 
            this.gbxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxSex.Controls.Add(this.rbWoman);
            this.gbxSex.Controls.Add(this.rbMan);
            this.gbxSex.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSex.Location = new System.Drawing.Point(93, 297);
            this.gbxSex.Name = "gbxSex";
            this.gbxSex.Size = new System.Drawing.Size(263, 34);
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
            this.gbxDocumentType.Location = new System.Drawing.Point(13, 59);
            this.gbxDocumentType.Name = "gbxDocumentType";
            this.gbxDocumentType.Size = new System.Drawing.Size(343, 47);
            this.gbxDocumentType.TabIndex = 158;
            this.gbxDocumentType.TabStop = false;
            this.gbxDocumentType.Text = "Tipo de Documento:";
            // 
            // gbxContactData
            // 
            this.gbxContactData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxContactData.Controls.Add(this.lblRequired7);
            this.gbxContactData.Controls.Add(this.lblRequired8);
            this.gbxContactData.Controls.Add(this.lblEmail);
            this.gbxContactData.Controls.Add(this.txtCellphone);
            this.gbxContactData.Controls.Add(this.lblCellphone);
            this.gbxContactData.Controls.Add(this.txtEmailPUCP);
            this.gbxContactData.Controls.Add(this.lblEmailPUCP);
            this.gbxContactData.Controls.Add(this.txtEmail);
            this.gbxContactData.Controls.Add(this.txtPUCPCode);
            this.gbxContactData.Controls.Add(this.lblPUCPCode);
            this.gbxContactData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContactData.Location = new System.Drawing.Point(419, 119);
            this.gbxContactData.Margin = new System.Windows.Forms.Padding(2);
            this.gbxContactData.Name = "gbxContactData";
            this.gbxContactData.Padding = new System.Windows.Forms.Padding(2);
            this.gbxContactData.Size = new System.Drawing.Size(370, 232);
            this.gbxContactData.TabIndex = 172;
            this.gbxContactData.TabStop = false;
            this.gbxContactData.Text = "Datos de contacto";
            // 
            // lblRequired7
            // 
            this.lblRequired7.AutoSize = true;
            this.lblRequired7.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequired7.Location = new System.Drawing.Point(338, 56);
            this.lblRequired7.Name = "lblRequired7";
            this.lblRequired7.Size = new System.Drawing.Size(17, 21);
            this.lblRequired7.TabIndex = 166;
            this.lblRequired7.Text = "*";
            // 
            // lblRequired8
            // 
            this.lblRequired8.AutoSize = true;
            this.lblRequired8.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequired8.Location = new System.Drawing.Point(338, 121);
            this.lblRequired8.Name = "lblRequired8";
            this.lblRequired8.Size = new System.Drawing.Size(17, 21);
            this.lblRequired8.TabIndex = 165;
            this.lblRequired8.Text = "*";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(216, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 39);
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
            this.btnCancel.Location = new System.Drawing.Point(451, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 39);
            this.btnCancel.TabIndex = 179;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProfessorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxContactData);
            this.Controls.Add(this.lblProfessorRegister);
            this.Controls.Add(this.gbxPersonalData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfessorRegister";
            this.Size = new System.Drawing.Size(811, 566);
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
        private System.Windows.Forms.Label lblRequired4;
        private System.Windows.Forms.Label lblRequired3;
        private System.Windows.Forms.Label lblRequired2;
        private System.Windows.Forms.Label lblRequired1;
        private System.Windows.Forms.Label lblRequired7;
        private System.Windows.Forms.Label lblRequired8;
        private System.Windows.Forms.Label lblRequiredInfo;
        private System.Windows.Forms.Label lblRequired0;
    }
}
