﻿namespace INFOSiS_2._0
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
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblInternModify = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.gbxPersonalData = new System.Windows.Forms.GroupBox();
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
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
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
            this.gbxContactData.Controls.Add(this.txtPUCPCode);
            this.gbxContactData.Controls.Add(this.lblPUCPCode);
            this.gbxContactData.Controls.Add(this.lblAddress);
            this.gbxContactData.Controls.Add(this.txtAddress);
            this.gbxContactData.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContactData.Location = new System.Drawing.Point(573, 113);
            this.gbxContactData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxContactData.Name = "gbxContactData";
            this.gbxContactData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxContactData.Size = new System.Drawing.Size(473, 365);
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
            this.gbxCondition.Location = new System.Drawing.Point(39, 299);
            this.gbxCondition.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCondition.Name = "gbxCondition";
            this.gbxCondition.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCondition.Size = new System.Drawing.Size(361, 48);
            this.gbxCondition.TabIndex = 169;
            this.gbxCondition.TabStop = false;
            this.gbxCondition.Text = "Condición:";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.Location = new System.Drawing.Point(147, 21);
            this.rbActive.Margin = new System.Windows.Forms.Padding(4);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(77, 29);
            this.rbActive.TabIndex = 165;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Activo";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactive.Location = new System.Drawing.Point(249, 21);
            this.rbInactive.Margin = new System.Windows.Forms.Padding(4);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(86, 29);
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
            this.lblEmail.Location = new System.Drawing.Point(42, 161);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(123, 25);
            this.lblEmail.TabIndex = 153;
            this.lblEmail.Text = "Correo alterno:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCellphone.Location = new System.Drawing.Point(173, 36);
            this.txtCellphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(227, 31);
            this.txtCellphone.TabIndex = 146;
            // 
            // lblCellphone
            // 
            this.lblCellphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(98, 38);
            this.lblCellphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(67, 25);
            this.lblCellphone.TabIndex = 147;
            this.lblCellphone.Text = "Celular:";
            // 
            // txtHomephone
            // 
            this.txtHomephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHomephone.Location = new System.Drawing.Point(173, 76);
            this.txtHomephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtHomephone.Name = "txtHomephone";
            this.txtHomephone.Size = new System.Drawing.Size(227, 31);
            this.txtHomephone.TabIndex = 148;
            // 
            // lblHomephone
            // 
            this.lblHomephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHomephone.AutoSize = true;
            this.lblHomephone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomephone.Location = new System.Drawing.Point(61, 80);
            this.lblHomephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomephone.Name = "lblHomephone";
            this.lblHomephone.Size = new System.Drawing.Size(103, 25);
            this.lblHomephone.TabIndex = 149;
            this.lblHomephone.Text = "Teléfono fijo:";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailPUCP.Location = new System.Drawing.Point(173, 115);
            this.txtEmailPUCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(227, 31);
            this.txtEmailPUCP.TabIndex = 150;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPUCP.Location = new System.Drawing.Point(50, 120);
            this.lblEmailPUCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(115, 25);
            this.lblEmailPUCP.TabIndex = 151;
            this.lblEmailPUCP.Text = "Correo PUCP:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(173, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 31);
            this.txtEmail.TabIndex = 152;
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPUCPCode.Location = new System.Drawing.Point(173, 194);
            this.txtPUCPCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(227, 31);
            this.txtPUCPCode.TabIndex = 154;
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPCode.Location = new System.Drawing.Point(50, 201);
            this.lblPUCPCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(114, 25);
            this.lblPUCPCode.TabIndex = 155;
            this.lblPUCPCode.Text = "Código PUCP:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(80, 243);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(84, 25);
            this.lblAddress.TabIndex = 159;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(173, 235);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 31);
            this.txtAddress.TabIndex = 158;
            // 
            // lblInternModify
            // 
            this.lblInternModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInternModify.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternModify.Location = new System.Drawing.Point(37, 33);
            this.lblInternModify.Name = "lblInternModify";
            this.lblInternModify.Size = new System.Drawing.Size(477, 59);
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
            this.btnSave.Location = new System.Drawing.Point(531, 610);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(268, 53);
            this.btnSave.TabIndex = 179;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btModify
            // 
            this.btModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModify.BackColor = System.Drawing.Color.MidnightBlue;
            this.btModify.FlatAppearance.BorderSize = 0;
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModify.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModify.ForeColor = System.Drawing.Color.White;
            this.btModify.Location = new System.Drawing.Point(171, 610);
            this.btModify.Margin = new System.Windows.Forms.Padding(4);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(268, 53);
            this.btModify.TabIndex = 178;
            this.btModify.Text = "Modificar";
            this.btModify.UseVisualStyleBackColor = false;
            // 
            // gbxPersonalData
            // 
            this.gbxPersonalData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxPersonalData.Controls.Add(this.gbxSex);
            this.gbxPersonalData.Controls.Add(this.gbxDocumentType);
            this.gbxPersonalData.Controls.Add(this.txtDocumentNumber);
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
            this.gbxPersonalData.Location = new System.Drawing.Point(35, 98);
            this.gbxPersonalData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPersonalData.Name = "gbxPersonalData";
            this.gbxPersonalData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPersonalData.Size = new System.Drawing.Size(521, 485);
            this.gbxPersonalData.TabIndex = 181;
            this.gbxPersonalData.TabStop = false;
            this.gbxPersonalData.Text = "Datos Personales";
            // 
            // gbxSex
            // 
            this.gbxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxSex.Controls.Add(this.rbWoman);
            this.gbxSex.Controls.Add(this.rbMan);
            this.gbxSex.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSex.Location = new System.Drawing.Point(69, 353);
            this.gbxSex.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSex.Name = "gbxSex";
            this.gbxSex.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSex.Size = new System.Drawing.Size(405, 44);
            this.gbxSex.TabIndex = 159;
            this.gbxSex.TabStop = false;
            this.gbxSex.Text = "Sexo:";
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWoman.Location = new System.Drawing.Point(117, 12);
            this.rbWoman.Margin = new System.Windows.Forms.Padding(4);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(74, 29);
            this.rbWoman.TabIndex = 143;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Mujer";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMan.Location = new System.Drawing.Point(259, 12);
            this.rbMan.Margin = new System.Windows.Forms.Padding(4);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(91, 29);
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
            this.gbxDocumentType.Location = new System.Drawing.Point(17, 59);
            this.gbxDocumentType.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDocumentType.Name = "gbxDocumentType";
            this.gbxDocumentType.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDocumentType.Size = new System.Drawing.Size(440, 58);
            this.gbxDocumentType.TabIndex = 158;
            this.gbxDocumentType.TabStop = false;
            this.gbxDocumentType.Text = "Tipo de Documento:";
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDNI.Location = new System.Drawing.Point(12, 27);
            this.rbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(63, 29);
            this.rbDNI.TabIndex = 129;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // rbForeignCard
            // 
            this.rbForeignCard.AutoSize = true;
            this.rbForeignCard.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForeignCard.Location = new System.Drawing.Point(107, 27);
            this.rbForeignCard.Margin = new System.Windows.Forms.Padding(4);
            this.rbForeignCard.Name = "rbForeignCard";
            this.rbForeignCard.Size = new System.Drawing.Size(179, 29);
            this.rbForeignCard.TabIndex = 131;
            this.rbForeignCard.TabStop = true;
            this.rbForeignCard.Text = "Carné de extranjería";
            this.rbForeignCard.UseVisualStyleBackColor = true;
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassport.Location = new System.Drawing.Point(312, 27);
            this.rbPassport.Margin = new System.Windows.Forms.Padding(4);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(102, 29);
            this.rbPassport.TabIndex = 132;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Pasaporte";
            this.rbPassport.UseVisualStyleBackColor = true;
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentNumber.Location = new System.Drawing.Point(212, 137);
            this.txtDocumentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(219, 31);
            this.txtDocumentNumber.TabIndex = 133;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(13, 143);
            this.lblDocumentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(185, 25);
            this.lblDocumentNumber.TabIndex = 134;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(77, 181);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(124, 25);
            this.lblFirstName.TabIndex = 135;
            this.lblFirstName.Text = "Primer nombre:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(212, 178);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 31);
            this.txtFirstName.TabIndex = 136;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondName.Location = new System.Drawing.Point(212, 217);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(219, 31);
            this.txtSecondName.TabIndex = 137;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimaryLastName.Location = new System.Drawing.Point(212, 256);
            this.txtPrimaryLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(219, 31);
            this.txtPrimaryLastName.TabIndex = 138;
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondLastName.Location = new System.Drawing.Point(212, 295);
            this.txtSecondLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(219, 31);
            this.txtSecondLastName.TabIndex = 139;
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(64, 219);
            this.lblSecondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(136, 25);
            this.lblSecondName.TabIndex = 140;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(65, 257);
            this.lblPrimaryLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(134, 25);
            this.lblPrimaryLastName.TabIndex = 141;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLastName.Location = new System.Drawing.Point(61, 295);
            this.lblSecondLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(138, 25);
            this.lblSecondLastName.TabIndex = 142;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthday.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(195, 405);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(301, 27);
            this.dtpBirthday.TabIndex = 156;
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(25, 410);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(158, 25);
            this.lblBirthday.TabIndex = 157;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // WorkforceModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxContactData);
            this.Controls.Add(this.lblInternModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.gbxPersonalData);
            this.Name = "WorkforceModify";
            this.Size = new System.Drawing.Size(1081, 697);
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
        private System.Windows.Forms.Button btModify;
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
    }
}