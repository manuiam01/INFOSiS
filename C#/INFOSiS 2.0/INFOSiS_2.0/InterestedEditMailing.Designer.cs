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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbYahoo = new System.Windows.Forms.RadioButton();
            this.rbHotmail = new System.Windows.Forms.RadioButton();
            this.rbGmail = new System.Windows.Forms.RadioButton();
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
            this.gbDetailSender.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(10, 21);
            this.lblInterestedRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(358, 48);
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
            this.gbDetailSender.Location = new System.Drawing.Point(17, 73);
            this.gbDetailSender.Name = "gbDetailSender";
            this.gbDetailSender.Size = new System.Drawing.Size(351, 230);
            this.gbDetailSender.TabIndex = 174;
            this.gbDetailSender.TabStop = false;
            this.gbDetailSender.Text = "Detalles de email de envío";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOtro);
            this.groupBox3.Controls.Add(this.rbYahoo);
            this.groupBox3.Controls.Add(this.rbHotmail);
            this.groupBox3.Controls.Add(this.rbGmail);
            this.groupBox3.Location = new System.Drawing.Point(12, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(306, 47);
            this.groupBox3.TabIndex = 185;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servidor de envío";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(216, 20);
            this.rbOtro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(59, 25);
            this.rbOtro.TabIndex = 3;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.RbOtro_CheckedChanged);
            // 
            // rbYahoo
            // 
            this.rbYahoo.AutoSize = true;
            this.rbYahoo.Location = new System.Drawing.Point(151, 20);
            this.rbYahoo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbYahoo.Name = "rbYahoo";
            this.rbYahoo.Size = new System.Drawing.Size(65, 25);
            this.rbYahoo.TabIndex = 2;
            this.rbYahoo.TabStop = true;
            this.rbYahoo.Text = "Yahoo";
            this.rbYahoo.UseVisualStyleBackColor = true;
            this.rbYahoo.CheckedChanged += new System.EventHandler(this.RbYahoo_CheckedChanged);
            // 
            // rbHotmail
            // 
            this.rbHotmail.AutoSize = true;
            this.rbHotmail.Location = new System.Drawing.Point(82, 20);
            this.rbHotmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbHotmail.Name = "rbHotmail";
            this.rbHotmail.Size = new System.Drawing.Size(74, 25);
            this.rbHotmail.TabIndex = 1;
            this.rbHotmail.TabStop = true;
            this.rbHotmail.Text = "Hotmail";
            this.rbHotmail.UseVisualStyleBackColor = true;
            this.rbHotmail.CheckedChanged += new System.EventHandler(this.RbHotmail_CheckedChanged);
            // 
            // rbGmail
            // 
            this.rbGmail.AutoSize = true;
            this.rbGmail.Location = new System.Drawing.Point(26, 20);
            this.rbGmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbGmail.Name = "rbGmail";
            this.rbGmail.Size = new System.Drawing.Size(61, 25);
            this.rbGmail.TabIndex = 0;
            this.rbGmail.TabStop = true;
            this.rbGmail.Text = "Gmail";
            this.rbGmail.UseVisualStyleBackColor = true;
            this.rbGmail.CheckedChanged += new System.EventHandler(this.RbGmail_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(94, 64);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(226, 23);
            this.txtPassword.TabIndex = 184;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Location = new System.Drawing.Point(274, 206);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(50, 25);
            this.cbSSL.TabIndex = 8;
            this.cbSSL.Text = "SSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(93, 124);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(226, 23);
            this.txtPort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto:";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(93, 94);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(226, 23);
            this.txtSmtp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Smtp server:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(17, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 123);
            this.groupBox1.TabIndex = 175;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del email a enviar";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(107, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 25);
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
            this.btnSearch.Location = new System.Drawing.Point(108, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 25);
            this.btnSearch.TabIndex = 186;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Archivo adjunto:";
            // 
            // txbAsunto
            // 
            this.txbAsunto.Location = new System.Drawing.Point(107, 28);
            this.txbAsunto.Name = "txbAsunto";
            this.txbAsunto.Size = new System.Drawing.Size(209, 23);
            this.txbAsunto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Asunto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txbMessage);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox2.Location = new System.Drawing.Point(374, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 349);
            this.groupBox2.TabIndex = 177;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensaje";
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(7, 23);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMessage.Size = new System.Drawing.Size(359, 323);
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
            this.btCancelar.Location = new System.Drawing.Point(417, 440);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(148, 39);
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
            this.btGuardar.Location = new System.Drawing.Point(213, 440);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(148, 39);
            this.btGuardar.TabIndex = 182;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // InterestedEditMailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 508);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDetailSender);
            this.Controls.Add(this.lblInterestedRegister);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InterestedEditMailing";
            this.Text = "InterestedEditMailing";
            this.Load += new System.EventHandler(this.InterestedEditMailing_Load);
            this.gbDetailSender.ResumeLayout(false);
            this.gbDetailSender.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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