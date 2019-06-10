namespace INFOSiS_2._0
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbCarnet = new System.Windows.Forms.RadioButton();
            this.rbPasaporte = new System.Windows.Forms.RadioButton();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txbNDocumento = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbSegundoNom = new System.Windows.Forms.TextBox();
            this.txbApePa = new System.Windows.Forms.TextBox();
            this.txbApeMa = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtHomephone = new System.Windows.Forms.TextBox();
            this.lblHomephone = new System.Windows.Forms.Label();
            this.txtEmailPUCP = new System.Windows.Forms.TextBox();
            this.lblEmailPUCP = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbEsInactivo = new System.Windows.Forms.CheckBox();
            this.gbxInterestedData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(10, 21);
            this.lblInterestedRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(361, 48);
            this.lblInterestedRegister.TabIndex = 171;
            this.lblInterestedRegister.Text = "Registrar un interesado";
            // 
            // gbxInterestedData
            // 
            this.gbxInterestedData.Controls.Add(this.dateNacimiento);
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
            this.gbxInterestedData.Controls.Add(this.lblBirthday);
            this.gbxInterestedData.Controls.Add(this.lblGender);
            this.gbxInterestedData.Controls.Add(this.groupBox1);
            this.gbxInterestedData.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.gbxInterestedData.Location = new System.Drawing.Point(8, 85);
            this.gbxInterestedData.Name = "gbxInterestedData";
            this.gbxInterestedData.Size = new System.Drawing.Size(388, 380);
            this.gbxInterestedData.TabIndex = 172;
            this.gbxInterestedData.TabStop = false;
            this.gbxInterestedData.Text = "Datos Personales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPasaporte);
            this.groupBox1.Controls.Add(this.rbCarnet);
            this.groupBox1.Controls.Add(this.rbDNI);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Documento";
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbDNI.Location = new System.Drawing.Point(28, 26);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(49, 22);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // rbCarnet
            // 
            this.rbCarnet.AutoSize = true;
            this.rbCarnet.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbCarnet.Location = new System.Drawing.Point(91, 26);
            this.rbCarnet.Name = "rbCarnet";
            this.rbCarnet.Size = new System.Drawing.Size(139, 22);
            this.rbCarnet.TabIndex = 1;
            this.rbCarnet.TabStop = true;
            this.rbCarnet.Text = "Carné de Extranjería";
            this.rbCarnet.UseVisualStyleBackColor = true;
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbPasaporte.Location = new System.Drawing.Point(248, 26);
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Size = new System.Drawing.Size(79, 22);
            this.rbPasaporte.TabIndex = 2;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(3, 112);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(141, 18);
            this.lblDocumentNumber.TabIndex = 158;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(88, 144);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(56, 18);
            this.lblFirstName.TabIndex = 159;
            this.lblFirstName.Text = "Nombre:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(41, 175);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(103, 18);
            this.lblSecondName.TabIndex = 160;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryLastName.Location = new System.Drawing.Point(42, 207);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(102, 18);
            this.lblPrimaryLastName.TabIndex = 161;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondLastName.Location = new System.Drawing.Point(39, 237);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(105, 18);
            this.lblSecondLastName.TabIndex = 162;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(22, 292);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(122, 18);
            this.lblBirthday.TabIndex = 164;
            this.lblBirthday.Text = "Fecha de nacimiento:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(101, 266);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(37, 18);
            this.lblGender.TabIndex = 163;
            this.lblGender.Text = "Sexo:";
            // 
            // txbNDocumento
            // 
            this.txbNDocumento.Location = new System.Drawing.Point(150, 104);
            this.txbNDocumento.Name = "txbNDocumento";
            this.txbNDocumento.Size = new System.Drawing.Size(191, 26);
            this.txbNDocumento.TabIndex = 165;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(150, 137);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(191, 26);
            this.txbNombre.TabIndex = 166;
            // 
            // txbSegundoNom
            // 
            this.txbSegundoNom.Location = new System.Drawing.Point(151, 169);
            this.txbSegundoNom.Name = "txbSegundoNom";
            this.txbSegundoNom.Size = new System.Drawing.Size(191, 26);
            this.txbSegundoNom.TabIndex = 167;
            // 
            // txbApePa
            // 
            this.txbApePa.Location = new System.Drawing.Point(150, 202);
            this.txbApePa.Name = "txbApePa";
            this.txbApePa.Size = new System.Drawing.Size(191, 26);
            this.txbApePa.TabIndex = 168;
            // 
            // txbApeMa
            // 
            this.txbApeMa.Location = new System.Drawing.Point(150, 234);
            this.txbApeMa.Name = "txbApeMa";
            this.txbApeMa.Size = new System.Drawing.Size(191, 26);
            this.txbApeMa.TabIndex = 169;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbMale.Location = new System.Drawing.Point(151, 266);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 22);
            this.rbMale.TabIndex = 170;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Hombre";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbFemale.Location = new System.Drawing.Point(227, 266);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(57, 22);
            this.rbFemale.TabIndex = 171;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Mujer";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.CalendarFont = new System.Drawing.Font("Gill Sans MT", 10F);
            this.dateNacimiento.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.dateNacimiento.Location = new System.Drawing.Point(151, 295);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(223, 23);
            this.dateNacimiento.TabIndex = 172;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEsInactivo);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtCellphone);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblCellphone);
            this.groupBox2.Controls.Add(this.lblEmailPUCP);
            this.groupBox2.Controls.Add(this.txtHomephone);
            this.groupBox2.Controls.Add(this.txtEmailPUCP);
            this.groupBox2.Controls.Add(this.lblHomephone);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(412, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 284);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(16, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 18);
            this.lblEmail.TabIndex = 180;
            this.lblEmail.Text = "Correo alterno:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(114, 41);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(171, 26);
            this.txtCellphone.TabIndex = 173;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.Location = new System.Drawing.Point(58, 42);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(50, 18);
            this.lblCellphone.TabIndex = 174;
            this.lblCellphone.Text = "Celular:";
            // 
            // txtHomephone
            // 
            this.txtHomephone.Location = new System.Drawing.Point(114, 73);
            this.txtHomephone.Name = "txtHomephone";
            this.txtHomephone.Size = new System.Drawing.Size(171, 26);
            this.txtHomephone.TabIndex = 175;
            // 
            // lblHomephone
            // 
            this.lblHomephone.AutoSize = true;
            this.lblHomephone.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomephone.Location = new System.Drawing.Point(30, 76);
            this.lblHomephone.Name = "lblHomephone";
            this.lblHomephone.Size = new System.Drawing.Size(78, 18);
            this.lblHomephone.TabIndex = 176;
            this.lblHomephone.Text = "Teléfono fijo:";
            // 
            // txtEmailPUCP
            // 
            this.txtEmailPUCP.Location = new System.Drawing.Point(114, 105);
            this.txtEmailPUCP.Name = "txtEmailPUCP";
            this.txtEmailPUCP.Size = new System.Drawing.Size(171, 26);
            this.txtEmailPUCP.TabIndex = 177;
            // 
            // lblEmailPUCP
            // 
            this.lblEmailPUCP.AutoSize = true;
            this.lblEmailPUCP.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPUCP.Location = new System.Drawing.Point(22, 109);
            this.lblEmailPUCP.Name = "lblEmailPUCP";
            this.lblEmailPUCP.Size = new System.Drawing.Size(86, 18);
            this.lblEmailPUCP.TabIndex = 178;
            this.lblEmailPUCP.Text = "Correo PUCP:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 26);
            this.txtEmail.TabIndex = 179;
            // 
            // cbEsInactivo
            // 
            this.cbEsInactivo.AutoSize = true;
            this.cbEsInactivo.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.cbEsInactivo.Location = new System.Drawing.Point(114, 189);
            this.cbEsInactivo.Name = "cbEsInactivo";
            this.cbEsInactivo.Size = new System.Drawing.Size(192, 22);
            this.cbEsInactivo.TabIndex = 181;
            this.cbEsInactivo.Text = "No quiero recibir más correos";
            this.cbEsInactivo.UseVisualStyleBackColor = true;
            // 
            // InterestedRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxInterestedData);
            this.Controls.Add(this.lblInterestedRegister);
            this.Name = "InterestedRegister";
            this.Size = new System.Drawing.Size(814, 566);
            this.Load += new System.EventHandler(this.InterestedRegister_Load);
            this.gbxInterestedData.ResumeLayout(false);
            this.gbxInterestedData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txbNDocumento;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbSegundoNom;
        private System.Windows.Forms.TextBox txbApePa;
        private System.Windows.Forms.TextBox txbApeMa;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Label lblEmailPUCP;
        private System.Windows.Forms.TextBox txtHomephone;
        private System.Windows.Forms.TextBox txtEmailPUCP;
        private System.Windows.Forms.Label lblHomephone;
        private System.Windows.Forms.CheckBox cbEsInactivo;
    }
}
