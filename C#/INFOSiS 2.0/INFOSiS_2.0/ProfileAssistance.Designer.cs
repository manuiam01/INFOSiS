namespace INFOSiS_2._0
{
    partial class ProfileAssistance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRegAsistencia = new System.Windows.Forms.Label();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegAsistencia
            // 
            this.lblRegAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegAsistencia.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegAsistencia.Location = new System.Drawing.Point(15, 16);
            this.lblRegAsistencia.Name = "lblRegAsistencia";
            this.lblRegAsistencia.Size = new System.Drawing.Size(544, 62);
            this.lblRegAsistencia.TabIndex = 177;
            this.lblRegAsistencia.Text = "Registrar Asistencia";
            this.lblRegAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPUCPCode
            // 
            this.lblPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPCode.AutoSize = true;
            this.lblPUCPCode.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPCode.Location = new System.Drawing.Point(7, 38);
            this.lblPUCPCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPUCPCode.Name = "lblPUCPCode";
            this.lblPUCPCode.Size = new System.Drawing.Size(119, 25);
            this.lblPUCPCode.TabIndex = 180;
            this.lblPUCPCode.Text = "Código PUCP: ";
            // 
            // txtPUCPCode
            // 
            this.txtPUCPCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPUCPCode.Enabled = false;
            this.txtPUCPCode.Location = new System.Drawing.Point(134, 38);
            this.txtPUCPCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPUCPCode.MaxLength = 8;
            this.txtPUCPCode.Name = "txtPUCPCode";
            this.txtPUCPCode.Size = new System.Drawing.Size(217, 31);
            this.txtPUCPCode.TabIndex = 179;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 182;
            this.label1.Text = "Nombre: ";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(134, 77);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 8;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(547, 31);
            this.txtName.TabIndex = 181;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPUCPCode);
            this.groupBox1.Controls.Add(this.lblPUCPCode);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 124);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtSalida);
            this.groupBox2.Controls.Add(this.txtEntrada);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.groupBox2.Location = new System.Drawing.Point(11, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 117);
            this.groupBox2.TabIndex = 179;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de Asistencia";
            // 
            // txtSalida
            // 
            this.txtSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalida.Enabled = false;
            this.txtSalida.Location = new System.Drawing.Point(134, 73);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalida.MaxLength = 8;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(217, 31);
            this.txtSalida.TabIndex = 185;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Location = new System.Drawing.Point(134, 38);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntrada.MaxLength = 8;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(217, 31);
            this.txtEntrada.TabIndex = 183;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 184;
            this.label3.Text = "Salida: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 183;
            this.label2.Text = "Entrada: ";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrada.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEntrada.Enabled = false;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(91, 382);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(221, 39);
            this.btnEntrada.TabIndex = 186;
            this.btnEntrada.Text = "Registrar Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalida.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalida.Enabled = false;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Location = new System.Drawing.Point(389, 382);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(221, 39);
            this.btnSalida.TabIndex = 187;
            this.btnSalida.Text = "Registrar Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(390, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(302, 62);
            this.lblTime.TabIndex = 188;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProfileAssistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRegAsistencia);
            this.Name = "ProfileAssistance";
            this.Size = new System.Drawing.Size(721, 484);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegAsistencia;
        private System.Windows.Forms.Label lblPUCPCode;
        private System.Windows.Forms.TextBox txtPUCPCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}
