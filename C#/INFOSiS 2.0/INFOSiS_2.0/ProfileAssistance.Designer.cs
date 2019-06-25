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
            this.lblRegAsistencia = new System.Windows.Forms.Label();
            this.lblPUCPCode = new System.Windows.Forms.Label();
            this.txtPUCPCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegAsistencia
            // 
            this.lblRegAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegAsistencia.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegAsistencia.Location = new System.Drawing.Point(3, 22);
            this.lblRegAsistencia.Name = "lblRegAsistencia";
            this.lblRegAsistencia.Size = new System.Drawing.Size(309, 52);
            this.lblRegAsistencia.TabIndex = 177;
            this.lblRegAsistencia.Text = "Registrar Asistencia";
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
            this.groupBox1.Location = new System.Drawing.Point(11, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 124);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // ProfileAssistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRegAsistencia);
            this.Name = "ProfileAssistance";
            this.Size = new System.Drawing.Size(721, 559);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegAsistencia;
        private System.Windows.Forms.Label lblPUCPCode;
        private System.Windows.Forms.TextBox txtPUCPCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
