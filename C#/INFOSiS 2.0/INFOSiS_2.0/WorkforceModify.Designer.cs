namespace INFOSiS_2._0
{
    partial class WorkforceModify
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
            this.gbxContactData = new System.Windows.Forms.GroupBox();
            this.gbxCondition = new System.Windows.Forms.GroupBox();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtHomephone = new System.Windows.Forms.TextBox();
            this.lblHomephone = new System.Windows.Forms.Label();
            this.txtEmailPUCP = new System.Windows.Forms.TextBox();
            this.lblEmailPUCP = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.lblInternModify = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.gbxPersonalData = new System.Windows.Forms.GroupBox();
            this.lblRequiredInfo = new System.Windows.Forms.Label();
            this.lbAdvancedSearch = new System.Windows.Forms.Label();
            this.gbxSex = new System.Windows.Forms.GroupBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.gbxDocumentType = new System.Windows.Forms.GroupBox();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbForeignCard = new System.Windows.Forms.RadioButton();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtPrimaryLastName = new System.Windows.Forms.TextBox();
            this.txtSecondLastName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxContactData.SuspendLayout();
            this.gbxCondition.SuspendLayout();
            this.gbxPersonalData.SuspendLayout();
            this.gbxSex.SuspendLayout();
            this.gbxDocumentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxContactData
            // 
            this.gbxContactData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxContactData.Controls.Add(this.gbxCondition);
            this.gbxContactData.Controls.Add(this.lblEmail);
            this.gbxContactData.Controls.Add(this.txtCellphone);
            this.gbxContactData.Controls.Add(this.lblCellphone);
            this.gbxContactData.Controls.Add(this.txtHomephone);
            this.gbxContactData.Controls.Add(this.lblHomephone);
            this.gbxContactData.Controls.Add(this.txtEmailPUCP);
            this.gbxContactData.Controls.Add(this.lblEmailPUCP);
            this.gbxContactData.Controls.Add(this.txtEmail);
            this.gbxContactData.Controls.Add(this.lblAddress);
            this.gbxContactData.Controls.Add(this.txtAddress);
            this.gbxContactData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContactData.Location = new System.Drawing.Point(430, 92);
            this.gbxContactData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxContactData.Name = "gbxContactData";
            this.gbxContactData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxContactData.Size = new System.Drawing.Size(355, 297);
            this.gbxContactData.TabIndex = 182;
            this.gbxContactData.TabStop = false;
            this.gbxContactData.Text = "Datos de contacto";
            // 
            // gbxCondition
            // 
            this.gbxCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxCondition.Controls.Add(this.rbActive);
            this.gbxCondition.Controls.Add(this.rbInactive);
            this.gbxCondition.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCondition.Location = new System.Drawing.Point(29, 206);
            this.gbxCondition.Name = "gbxCondition";
            this.gbxCondition.Size = new System.Drawing.Size(271, 39);
            this.gbxCondition.TabIndex = 169;
            this.gbxCondition.TabStop = false;
            this.gbxCondition.Text = "Condición:";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.Location = new System.Drawing.Point(100, 12);
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
            this.rbInactive.Location = new System.Drawing.Point(187, 13);
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
            this.lblEmail.Location = new System.Drawing.Point(32, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 18);
            this.lblEmail.TabIndex = 153;
            this.lblEmail.Text = "Correo alterno:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCellphone.Location = new System.Drawing.Point(130, 29);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(171, 26);
            this.txtCellphone.TabIndex = 146;
            this.txtCellphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellphone_KeyPress);
            // 
            // lblCellphone
            // 
            this.lblCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(65, 32);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(59, 18);
            this.lblCellphone.TabIndex = 147;
            this.lblCellphone.Text = "Celular: *";
            // 
            // txtHomephone
            // 
            this.txtHomephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHomephone.Location = new System.Drawing.Point(130, 62);
            this.txtHomephone.Name = "txtHomephone";
            this.txtHomephone.Size = new System.Drawing.Size(171, 26);
            this.txtHomephone.TabIndex = 148;
            // 
            // lblHomephone
            // 
            this.lblHomephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHomephone.AutoSize = true;
            this.lblHomephone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomephone.Location = new System.Drawing.Point(37, 66);
            this.lblHomephone.Name = "lblHomephone";
            this.lblHomephone.Size = new System.Drawing.Size(78, 18);
            this.lblHomephone.TabIndex = 149;
            this.lblHomephone.Text = "Teléfono fijo:";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailPUCP.Location = new System.Drawing.Point(130, 93);
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(171, 26);
            this.txtEmailPUCP.TabIndex = 150;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPUCP.Location = new System.Drawing.Point(38, 98);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(86, 18);
            this.lblEmailPUCP.Location = new System.Drawing.Point(29, 99);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(95, 18);
            this.lblEmailPUCP.TabIndex = 151;
            this.lblEmailPUCP.Text = "Correo PUCP: *";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(130, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 26);
            this.txtEmail.TabIndex = 152;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(51, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 18);
            this.lblAddress.TabIndex = 159;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(130, 158);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 26);
            this.txtAddress.TabIndex = 158;
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPUCPCode.Location = new System.Drawing.Point(159, 43);
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(198, 26);
            this.txtPUCPCode.TabIndex = 154;
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPCode.Location = new System.Drawing.Point(52, 45);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(95, 18);
            this.lblPUCPCode.TabIndex = 155;
            this.lblPUCPCode.Text = "Código PUCP: *";
            // 
            // lblInternModify
            // 
            this.lblInternModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInternModify.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternModify.Location = new System.Drawing.Point(28, 27);
            this.lblInternModify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInternModify.Name = "lblInternModify";
            this.lblInternModify.Size = new System.Drawing.Size(313, 48);
            this.lblInternModify.TabIndex = 180;
            this.lblInternModify.Text = "Modificar un practicante";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(315, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 43);
            this.btnSave.TabIndex = 179;
            this.btnSave.Text = "Guardar cambios";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModify.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(76, 496);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(201, 43);
            this.btnModify.TabIndex = 178;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // gbxPersonalData
            // 
            this.gbxPersonalData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxPersonalData.Controls.Add(this.lblRequiredInfo);
            this.gbxPersonalData.Controls.Add(this.lbAdvancedSearch);
            this.gbxPersonalData.Controls.Add(this.gbxSex);
            this.gbxPersonalData.Controls.Add(this.gbxDocumentType);
            this.gbxPersonalData.Controls.Add(this.txtDocumentNumber);
            this.gbxPersonalData.Controls.Add(this.txtPUCPCode);
            this.gbxPersonalData.Controls.Add(this.lblPUCPCode);
            this.gbxPersonalData.Controls.Add(this.btnSearch);
            this.gbxPersonalData.Controls.Add(this.lblDocumentNumber);
            this.gbxPersonalData.Controls.Add(this.lblFirstName);
            this.gbxPersonalData.Controls.Add(this.txtFirstName);
            this.gbxPersonalData.Controls.Add(this.txtSecondName);
            this.gbxPersonalData.Controls.Add(this.txtPrimaryLastName);
            this.gbxPersonalData.Controls.Add(this.txtSecondLastName);
            this.gbxPersonalData.Controls.Add(this.lblSecondName);
            this.gbxPersonalData.Controls.Add(this.lblPrimaryLastName);
            this.gbxPersonalData.Controls.Add(this.lblSecondLastName);
            this.gbxPersonalData.Controls.Add(this.dtpBirthday);
            this.gbxPersonalData.Controls.Add(this.lblBirthday);
            this.gbxPersonalData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPersonalData.Location = new System.Drawing.Point(26, 69);
            this.gbxPersonalData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPersonalData.Name = "gbxPersonalData";
            this.gbxPersonalData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPersonalData.Size = new System.Drawing.Size(391, 404);            this.gbxPersonalData.TabIndex = 181;
            this.gbxPersonalData.TabStop = false;
            this.gbxPersonalData.Text = "Datos Personales";
           
            // lblRequiredInfo
            // 
            this.lblRequiredInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequiredInfo.AutoSize = true;
            this.lblRequiredInfo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredInfo.Location = new System.Drawing.Point(18, 31);
            this.lblRequiredInfo.Location = new System.Drawing.Point(18, 22);
            this.lblRequiredInfo.Name = "lblRequiredInfo";
            this.lblRequiredInfo.Size = new System.Drawing.Size(136, 18);
            this.lblRequiredInfo.TabIndex = 187;
            this.lblRequiredInfo.Text = "* Campo obligatorio";
            // 
            // lbAdvancedSearch
            // 
            this.lbAdvancedSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAdvancedSearch.AutoSize = true;
            this.lbAdvancedSearch.Font = new System.Drawing.Font("Gill Sans MT", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbAdvancedSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbAdvancedSearch.Location = new System.Drawing.Point(133, 97);
            this.lbAdvancedSearch.Name = "lbAdvancedSearch";
            this.lbAdvancedSearch.Size = new System.Drawing.Size(115, 18);
            this.lbAdvancedSearch.TabIndex = 185;
            this.lbAdvancedSearch.Text = "Busqueda avanzada";
            this.lbAdvancedSearch.Click += new System.EventHandler(this.lbAdvancedSearch_Click);
            // 
            // gbxSex
            // 
            this.gbxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxSex.Controls.Add(this.rbWoman);
            this.gbxSex.Controls.Add(this.rbMan);
            this.gbxSex.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSex.Location = new System.Drawing.Point(52, 323);
            this.gbxSex.Name = "gbxSex";
            this.gbxSex.Size = new System.Drawing.Size(304, 36);
            this.gbxSex.TabIndex = 159;
            this.gbxSex.TabStop = false;
            this.gbxSex.Text = "Sexo:";
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
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMan.Location = new System.Drawing.Point(194, 10);
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
            this.gbxDocumentType.Location = new System.Drawing.Point(26, 118);
            this.gbxDocumentType.Name = "gbxDocumentType";
            this.gbxDocumentType.Size = new System.Drawing.Size(330, 47);
            this.gbxDocumentType.TabIndex = 158;
            this.gbxDocumentType.TabStop = false;
            this.gbxDocumentType.Text = "Tipo de Documento: *";
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Checked = true;
            this.rbDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDNI.Location = new System.Drawing.Point(9, 22);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(49, 22);
            this.rbDNI.TabIndex = 129;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
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
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentNumber.Location = new System.Drawing.Point(159, 169);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(198, 26);
            this.txtDocumentNumber.TabIndex = 133;
            this.txtDocumentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentNumber_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(22, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 32);
            this.btnSearch.TabIndex = 184;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(4, 178);
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
            this.lblFirstName.Location = new System.Drawing.Point(52, 209);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 18);
            this.lblFirstName.TabIndex = 135;
            this.lblFirstName.Text = "Primer nombre: *";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(159, 202);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(198, 26);
            this.txtFirstName.TabIndex = 136;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondName.Location = new System.Drawing.Point(159, 234);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(198, 26);
            this.txtSecondName.TabIndex = 137;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimaryLastName.Location = new System.Drawing.Point(159, 266);
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(198, 26);
            this.txtPrimaryLastName.TabIndex = 138;
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondLastName.Location = new System.Drawing.Point(159, 297);
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(198, 26);
            this.txtSecondLastName.TabIndex = 139;
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(42, 240);
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
            this.lblPrimaryLastName.Location = new System.Drawing.Point(43, 270);
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
            this.lblSecondLastName.Location = new System.Drawing.Point(40, 301);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(105, 18);
            this.lblSecondLastName.TabIndex = 142;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthday.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.dtpBirthday.Location = new System.Drawing.Point(146, 374);
            this.dtpBirthday.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(221, 23);

            this.dtpBirthday.TabIndex = 156;
            this.dtpBirthday.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblBirthday.Location = new System.Drawing.Point(19, 369);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(122, 18);
            this.lblBirthday.TabIndex = 157;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(550, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 43);
            this.btnCancel.TabIndex = 183;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WorkforceModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxContactData);
            this.Controls.Add(this.lblInternModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.gbxPersonalData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkforceModify";
            this.Size = new System.Drawing.Size(811, 566);
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

        private System.Windows.Forms.GroupBox gbxContactData;
        private System.Windows.Forms.GroupBox gbxCondition;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtHomephone;
        private System.Windows.Forms.Label lblHomephone;
        private System.Windows.Forms.TextBox txtEmailPUCP;
        private System.Windows.Forms.Label lblEmailPUCP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPUCPCode;
        private System.Windows.Forms.Label lblPUCPCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblInternModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
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
        private System.Windows.Forms.Label lbAdvancedSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblRequiredInfo;
        private System.Windows.Forms.Button btnCancel;
    }
}
