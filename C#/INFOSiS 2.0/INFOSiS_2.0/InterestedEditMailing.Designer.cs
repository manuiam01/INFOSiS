namespace INFOSiS_2._0
{
    partial class InterestedEditMailing
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
            this.lblInterestedRegister = new System.Windows.Forms.Label();
            this.gbDetailSender = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAsunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbGmail = new System.Windows.Forms.RadioButton();
            this.rbHotmail = new System.Windows.Forms.RadioButton();
            this.rbYahoo = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.gbDetailSender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(13, 26);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(477, 59);
            this.lblInterestedRegister.TabIndex = 173;
            this.lblInterestedRegister.Text = "Editar mailing";
            this.lblInterestedRegister.Click += new System.EventHandler(this.LblInterestedRegister_Click);
            // 
            // gbDetailSender
            // 
            this.gbDetailSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDetailSender.Controls.Add(this.groupBox3);
            this.gbDetailSender.Controls.Add(this.txtPassword);
            this.gbDetailSender.Controls.Add(this.cbSSL);
            this.gbDetailSender.Controls.Add(this.txtPort);
            this.gbDetailSender.Controls.Add(this.label4);
            this.gbDetailSender.Controls.Add(this.txtSmtp);
            this.gbDetailSender.Controls.Add(this.label3);
            this.gbDetailSender.Controls.Add(this.txtEmail);
            this.gbDetailSender.Controls.Add(this.label2);
            this.gbDetailSender.Controls.Add(this.label1);
            this.gbDetailSender.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.gbDetailSender.Location = new System.Drawing.Point(23, 90);
            this.gbDetailSender.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetailSender.Name = "gbDetailSender";
            this.gbDetailSender.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetailSender.Size = new System.Drawing.Size(468, 283);
            this.gbDetailSender.TabIndex = 174;
            this.gbDetailSender.TabStop = false;
            this.gbDetailSender.Text = "Detalles de email de envío";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(125, 79);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 27);
            this.txtPassword.TabIndex = 184;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Location = new System.Drawing.Point(366, 254);
            this.cbSSL.Margin = new System.Windows.Forms.Padding(4);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(58, 29);
            this.cbSSL.TabIndex = 8;
            this.cbSSL.Text = "SSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(124, 153);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(300, 27);
            this.txtPort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto:";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(124, 116);
            this.txtSmtp.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(300, 27);
            this.txtSmtp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Smtp server:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 42);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbAsunto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox1.Location = new System.Drawing.Point(23, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 151);
            this.groupBox1.TabIndex = 175;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del email a enviar";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(133, 117);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 29);
            this.checkBox2.TabIndex = 187;
            this.checkBox2.Text = "HTML ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(135, 79);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 31);
            this.btnSearch.TabIndex = 186;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Archivo adjunto:";
            // 
            // txbAsunto
            // 
            this.txbAsunto.Location = new System.Drawing.Point(133, 34);
            this.txbAsunto.Margin = new System.Windows.Forms.Padding(4);
            this.txbAsunto.Name = "txbAsunto";
            this.txbAsunto.Size = new System.Drawing.Size(277, 27);
            this.txbAsunto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Asunto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txbMessage);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox2.Location = new System.Drawing.Point(499, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(496, 430);
            this.groupBox2.TabIndex = 177;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensaje";
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(9, 28);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMessage.Size = new System.Drawing.Size(477, 397);
            this.txbMessage.TabIndex = 0;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(556, 542);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(197, 48);
            this.btCancelar.TabIndex = 183;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGuardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btGuardar.FlatAppearance.BorderSize = 0;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(284, 542);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(197, 48);
            this.btGuardar.TabIndex = 182;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOtro);
            this.groupBox3.Controls.Add(this.rbYahoo);
            this.groupBox3.Controls.Add(this.rbHotmail);
            this.groupBox3.Controls.Add(this.rbGmail);
            this.groupBox3.Location = new System.Drawing.Point(16, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 58);
            this.groupBox3.TabIndex = 185;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servidor de envío";
            // 
            // rbGmail
            // 
            this.rbGmail.AutoSize = true;
            this.rbGmail.Location = new System.Drawing.Point(34, 25);
            this.rbGmail.Name = "rbGmail";
            this.rbGmail.Size = new System.Drawing.Size(74, 29);
            this.rbGmail.TabIndex = 0;
            this.rbGmail.TabStop = true;
            this.rbGmail.Text = "Gmail";
            this.rbGmail.UseVisualStyleBackColor = true;
            this.rbGmail.CheckedChanged += new System.EventHandler(this.RbGmail_CheckedChanged);
            // 
            // rbHotmail
            // 
            this.rbHotmail.AutoSize = true;
            this.rbHotmail.Location = new System.Drawing.Point(110, 25);
            this.rbHotmail.Name = "rbHotmail";
            this.rbHotmail.Size = new System.Drawing.Size(88, 29);
            this.rbHotmail.TabIndex = 1;
            this.rbHotmail.TabStop = true;
            this.rbHotmail.Text = "Hotmail";
            this.rbHotmail.UseVisualStyleBackColor = true;
            this.rbHotmail.CheckedChanged += new System.EventHandler(this.RbHotmail_CheckedChanged);
            // 
            // rbYahoo
            // 
            this.rbYahoo.AutoSize = true;
            this.rbYahoo.Location = new System.Drawing.Point(201, 24);
            this.rbYahoo.Name = "rbYahoo";
            this.rbYahoo.Size = new System.Drawing.Size(77, 29);
            this.rbYahoo.TabIndex = 2;
            this.rbYahoo.TabStop = true;
            this.rbYahoo.Text = "Yahoo";
            this.rbYahoo.UseVisualStyleBackColor = true;
            this.rbYahoo.CheckedChanged += new System.EventHandler(this.RbYahoo_CheckedChanged);
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(288, 24);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(69, 29);
            this.rbOtro.TabIndex = 3;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.RbOtro_CheckedChanged);
            // 
            // InterestedEditMailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 625);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDetailSender);
            this.Controls.Add(this.lblInterestedRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterestedEditMailing";
            this.Text = "InterestedEditMailing";
            this.Load += new System.EventHandler(this.InterestedEditMailing_Load);
            this.gbDetailSender.ResumeLayout(false);
            this.gbDetailSender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.GroupBox gbDetailSender;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbAsunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbYahoo;
        private System.Windows.Forms.RadioButton rbHotmail;
        private System.Windows.Forms.RadioButton rbGmail;
    }
}