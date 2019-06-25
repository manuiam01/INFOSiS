namespace INFOSiS_2._0
{
    partial class ProfessorModify
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
            this.lblProfessorModify = new System.Windows.Forms.Label();
            this.gbxContactData = new System.Windows.Forms.GroupBox();
            this.gbxCondition = new System.Windows.Forms.GroupBox();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtEmailPUCP = new System.Windows.Forms.TextBox();
            this.lblEmailPUCP = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.gbxPersonalData = new System.Windows.Forms.GroupBox();
            this.lblRequiredInfo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAdvancedSearch = new System.Windows.Forms.Label();
            this.gbxSex = new System.Windows.Forms.GroupBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.gbxDocumentType = new System.Windows.Forms.GroupBox();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbForeignCard = new System.Windows.Forms.RadioButton();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtPrimaryLastName = new System.Windows.Forms.TextBox();
            this.txtSecondLastName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbxContactData.SuspendLayout();
            this.gbxCondition.SuspendLayout();
            this.gbxPersonalData.SuspendLayout();
            this.gbxSex.SuspendLayout();
            this.gbxDocumentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfessorModify
            // 
            this.lblProfessorModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfessorModify.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorModify.Location = new System.Drawing.Point(10, 16);
            this.lblProfessorModify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfessorModify.Name = "lblProfessorModify";
            this.lblProfessorModify.Size = new System.Drawing.Size(308, 42);
            this.lblProfessorModify.TabIndex = 171;
            this.lblProfessorModify.Text = "Modificar un Profesor";
            // 
            // gbxContactData
            // 
            this.gbxContactData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxContactData.Controls.Add(this.gbxCondition);
            this.gbxContactData.Controls.Add(this.lblEmail);
            this.gbxContactData.Controls.Add(this.txtCellphone);
            this.gbxContactData.Controls.Add(this.lblCellphone);
            this.gbxContactData.Controls.Add(this.txtEmailPUCP);
            this.gbxContactData.Controls.Add(this.lblEmailPUCP);
            this.gbxContactData.Controls.Add(this.txtEmail);
            this.gbxContactData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContactData.Location = new System.Drawing.Point(418, 108);
            this.gbxContactData.Margin = new System.Windows.Forms.Padding(2);
            this.gbxContactData.Name = "gbxContactData";
            this.gbxContactData.Padding = new System.Windows.Forms.Padding(2);
            this.gbxContactData.Size = new System.Drawing.Size(386, 256);
            this.gbxContactData.TabIndex = 174;
            this.gbxContactData.TabStop = false;
            this.gbxContactData.Text = "Datos de contacto";
            // 
            // gbxCondition
            // 
            this.gbxCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxCondition.Controls.Add(this.rbActive);
            this.gbxCondition.Controls.Add(this.rbInactive);
            this.gbxCondition.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCondition.Location = new System.Drawing.Point(67, 163);
            this.gbxCondition.Name = "gbxCondition";
            this.gbxCondition.Size = new System.Drawing.Size(284, 39);
            this.gbxCondition.TabIndex = 169;
            this.gbxCondition.TabStop = false;
            this.gbxCondition.Text = "Condición: *";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.Location = new System.Drawing.Point(109, 12);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(61, 22);
            this.rbActive.TabIndex = 165;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Activo";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactive.Location = new System.Drawing.Point(196, 11);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(68, 22);
            this.rbInactive.TabIndex = 167;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactivo";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(47, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 18);
            this.lblEmail.TabIndex = 153;
            this.lblEmail.Text = "Correo alterno:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCellphone.Location = new System.Drawing.Point(145, 48);
            this.txtCellphone.MaxLength = 15;
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(206, 26);
            this.txtCellphone.TabIndex = 146;
            this.txtCellphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCellphone_KeyPress);
            // 
            // lblCellphone
            // 
            this.lblCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(89, 49);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(50, 18);
            this.lblCellphone.TabIndex = 147;
            this.lblCellphone.Text = "Celular:";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailPUCP.Location = new System.Drawing.Point(145, 84);
            this.txtEmailPUCP.MaxLength = 45;
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(206, 26);
            this.txtEmailPUCP.TabIndex = 150;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPUCP.Location = new System.Drawing.Point(53, 87);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(95, 18);
            this.lblEmailPUCP.TabIndex = 151;
            this.lblEmailPUCP.Text = "Correo PUCP: *";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(145, 122);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 26);
            this.txtEmail.TabIndex = 152;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthday.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(128, 404);
            this.dtpBirthday.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(233, 23);
            this.dtpBirthday.TabIndex = 156;
            this.dtpBirthday.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.DtpBirthday_ValueChanged);
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(3, 406);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(122, 18);
            this.lblBirthday.TabIndex = 157;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPUCPCode.Location = new System.Drawing.Point(157, 48);
            this.txtPUCPCode.MaxLength = 8;
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(204, 26);
            this.txtPUCPCode.TabIndex = 154;
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPCode.Location = new System.Drawing.Point(57, 54);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(95, 18);
            this.lblPUCPCode.TabIndex = 155;
            this.lblPUCPCode.Text = "Código PUCP: *";
            // 
            // gbxPersonalData
            // 
            this.gbxPersonalData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxPersonalData.Controls.Add(this.lblRequiredInfo);
            this.gbxPersonalData.Controls.Add(this.btnSearch);
            this.gbxPersonalData.Controls.Add(this.lblAdvancedSearch);
            this.gbxPersonalData.Controls.Add(this.gbxSex);
            this.gbxPersonalData.Controls.Add(this.gbxDocumentType);
            this.gbxPersonalData.Controls.Add(this.txtDocumentNumber);
            this.gbxPersonalData.Controls.Add(this.lblDocumentNumber);
            this.gbxPersonalData.Controls.Add(this.dtpBirthday);
            this.gbxPersonalData.Controls.Add(this.lblFirstName);
            this.gbxPersonalData.Controls.Add(this.lblBirthday);
            this.gbxPersonalData.Controls.Add(this.txtFirstName);
            this.gbxPersonalData.Controls.Add(this.txtSecondName);
            this.gbxPersonalData.Controls.Add(this.txtPrimaryLastName);
            this.gbxPersonalData.Controls.Add(this.txtSecondLastName);
            this.gbxPersonalData.Controls.Add(this.lblSecondName);
            this.gbxPersonalData.Controls.Add(this.txtPUCPCode);
            this.gbxPersonalData.Controls.Add(this.lblPrimaryLastName);
            this.gbxPersonalData.Controls.Add(this.lblPUCPCode);
            this.gbxPersonalData.Controls.Add(this.lblSecondLastName);
            this.gbxPersonalData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPersonalData.Location = new System.Drawing.Point(17, 60);
            this.gbxPersonalData.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPersonalData.Name = "gbxPersonalData";
            this.gbxPersonalData.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPersonalData.Size = new System.Drawing.Size(388, 442);
            this.gbxPersonalData.TabIndex = 173;
            this.gbxPersonalData.TabStop = false;
            this.gbxPersonalData.Text = "Datos Personales";
            // 
            // lblRequiredInfo
            // 
            this.lblRequiredInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequiredInfo.AutoSize = true;
            this.lblRequiredInfo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRequiredInfo.Location = new System.Drawing.Point(19, 24);
            this.lblRequiredInfo.Name = "lblRequiredInfo";
            this.lblRequiredInfo.Size = new System.Drawing.Size(136, 18);
            this.lblRequiredInfo.TabIndex = 186;
            this.lblRequiredInfo.Text = "* Campo obligatorio";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(22, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 34);
            this.btnSearch.TabIndex = 184;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblAdvancedSearch
            // 
            this.lblAdvancedSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvancedSearch.AutoSize = true;
            this.lblAdvancedSearch.Font = new System.Drawing.Font("Gill Sans MT", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAdvancedSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAdvancedSearch.Location = new System.Drawing.Point(191, 95);
            this.lblAdvancedSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdvancedSearch.Name = "lblAdvancedSearch";
            this.lblAdvancedSearch.Size = new System.Drawing.Size(115, 18);
            this.lblAdvancedSearch.TabIndex = 185;
            this.lblAdvancedSearch.Text = "Busqueda avanzada";
            this.lblAdvancedSearch.Click += new System.EventHandler(this.lblAdvancedSearch_Click);
            // 
            // gbxSex
            // 
            this.gbxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxSex.Controls.Add(this.rbWoman);
            this.gbxSex.Controls.Add(this.rbMan);
            this.gbxSex.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSex.Location = new System.Drawing.Point(89, 355);
            this.gbxSex.Name = "gbxSex";
            this.gbxSex.Size = new System.Drawing.Size(272, 36);
            this.gbxSex.TabIndex = 159;
            this.gbxSex.TabStop = false;
            this.gbxSex.Text = "Sexo:";
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWoman.Location = new System.Drawing.Point(105, 10);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(57, 22);
            this.rbWoman.TabIndex = 143;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Mujer";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMan.Location = new System.Drawing.Point(187, 10);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(70, 22);
            this.rbMan.TabIndex = 145;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Hombre";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // gbxDocumentType
            // 
            this.gbxDocumentType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxDocumentType.Controls.Add(this.rbDNI);
            this.gbxDocumentType.Controls.Add(this.rbForeignCard);
            this.gbxDocumentType.Controls.Add(this.rbPassport);
            this.gbxDocumentType.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDocumentType.Location = new System.Drawing.Point(16, 135);
            this.gbxDocumentType.Name = "gbxDocumentType";
            this.gbxDocumentType.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDocumentType.Size = new System.Drawing.Size(345, 54);
            this.gbxDocumentType.TabIndex = 158;
            this.gbxDocumentType.TabStop = false;
            this.gbxDocumentType.Text = "Tipo de Documento: *";
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
            // rbForeignCard
            // 
            this.rbForeignCard.AutoSize = true;
            this.rbForeignCard.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForeignCard.Location = new System.Drawing.Point(88, 22);
            this.rbForeignCard.Name = "rbForeignCard";
            this.rbForeignCard.Size = new System.Drawing.Size(138, 22);
            this.rbForeignCard.TabIndex = 131;
            this.rbForeignCard.TabStop = true;
            this.rbForeignCard.Text = "Carné de extranjería";
            this.rbForeignCard.UseVisualStyleBackColor = true;
            this.rbForeignCard.CheckedChanged += new System.EventHandler(this.RbForeignCard_CheckedChanged);
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassport.Location = new System.Drawing.Point(251, 22);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(79, 22);
            this.rbPassport.TabIndex = 132;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Pasaporte";
            this.rbPassport.UseVisualStyleBackColor = true;
            this.rbPassport.CheckedChanged += new System.EventHandler(this.RbPassport_CheckedChanged);
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentNumber.Location = new System.Drawing.Point(157, 199);
            this.txtDocumentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentNumber.MaxLength = 8;
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(204, 26);
            this.txtDocumentNumber.TabIndex = 133;
            this.txtDocumentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumentNumber_KeyPress);
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(3, 200);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(150, 18);
            this.lblDocumentNumber.TabIndex = 134;
            this.lblDocumentNumber.Text = "Número de Documento: *";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(50, 233);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 18);
            this.lblFirstName.TabIndex = 135;
            this.lblFirstName.Text = "Primer nombre: *";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(157, 230);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(204, 26);
            this.txtFirstName.TabIndex = 136;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondName.Location = new System.Drawing.Point(158, 261);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecondName.MaxLength = 45;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(203, 26);
            this.txtSecondName.TabIndex = 137;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimaryLastName.Location = new System.Drawing.Point(158, 292);
            this.txtPrimaryLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimaryLastName.MaxLength = 45;
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(203, 26);
            this.txtPrimaryLastName.TabIndex = 138;
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondLastName.Location = new System.Drawing.Point(158, 323);
            this.txtSecondLastName.MaxLength = 45;
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(203, 26);
            this.txtSecondLastName.TabIndex = 139;
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(40, 264);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(103, 18);
            this.lblSecondName.TabIndex = 140;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(41, 295);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(111, 18);
            this.lblPrimaryLastName.TabIndex = 141;
            this.lblPrimaryLastName.Text = "Apellido paterno: *";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLastName.Location = new System.Drawing.Point(38, 327);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(114, 18);
            this.lblSecondLastName.TabIndex = 142;
            this.lblSecondLastName.Text = "Apellido materno: *";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(563, 507);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 39);
            this.btnCancelar.TabIndex = 183;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(120, 507);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 39);
            this.btnModificar.TabIndex = 182;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveChanges.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(326, 507);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(181, 39);
            this.btnSaveChanges.TabIndex = 184;
            this.btnSaveChanges.Text = "Guardar cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // ProfessorModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbxContactData);
            this.Controls.Add(this.gbxPersonalData);
            this.Controls.Add(this.lblProfessorModify);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfessorModify";
            this.Size = new System.Drawing.Size(814, 566);
            this.gbxContactData.ResumeLayout(false);
            this.gbxContactData.PerformLayout();
            this.gbxCondition.ResumeLayout(false);
            this.gbxCondition.PerformLayout();
            this.gbxPersonalData.ResumeLayout(false);
            this.gbxPersonalData.PerformLayout();
            this.gbxSex.ResumeLayout(false);
            this.gbxSex.PerformLayout();
            this.gbxDocumentType.ResumeLayout(false);
            this.gbxDocumentType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblProfessorModify;
        private System.Windows.Forms.GroupBox gbxContactData;
        private System.Windows.Forms.GroupBox gbxCondition;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtEmailPUCP;
        private System.Windows.Forms.Label lblEmailPUCP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPUCPCode;
        private System.Windows.Forms.Label lblPUCPCode;
        private System.Windows.Forms.GroupBox gbxPersonalData;
        private System.Windows.Forms.GroupBox gbxSex;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.GroupBox gbxDocumentType;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.RadioButton rbForeignCard;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtPrimaryLastName;
        private System.Windows.Forms.TextBox txtSecondLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAdvancedSearch;
        private System.Windows.Forms.Label lblRequiredInfo;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}
