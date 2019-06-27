namespace INFOSiS_2._0
{
    partial class CalendarCourse
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(86, 14);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(221, 42);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "NombreCurso";
            // 
            // lblProfessor
            // 
            this.lblProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.BackColor = System.Drawing.Color.Transparent;
            this.lblProfessor.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.ForeColor = System.Drawing.Color.White;
            this.lblProfessor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProfessor.Location = new System.Drawing.Point(164, 149);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(128, 34);
            this.lblProfessor.TabIndex = 5;
            this.lblProfessor.Text = "<Profesor>";
            // 
            // lblLugar
            // 
            this.lblLugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblLugar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.ForeColor = System.Drawing.Color.White;
            this.lblLugar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLugar.Location = new System.Drawing.Point(474, 83);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(83, 29);
            this.lblLugar.TabIndex = 6;
            this.lblLugar.Text = "<Lugar>";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHora.Location = new System.Drawing.Point(165, 88);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(80, 29);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "<Hora>";
            // 
            // label3
            // 
            this.label3.Image = global::INFOSiS_2._0.Properties.Resources.infosislocation;
            this.label3.Location = new System.Drawing.Point(395, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 65);
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Image = global::INFOSiS_2._0.Properties.Resources.infosisProfesor;
            this.label2.Location = new System.Drawing.Point(86, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 51);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Image = global::INFOSiS_2._0.Properties.Resources.infosisclock;
            this.label1.Location = new System.Drawing.Point(75, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 58);
            this.label1.TabIndex = 9;
            // 
            // lblBook
            // 
            this.lblBook.Image = global::INFOSiS_2._0.Properties.Resources.Libro_infosis2;
            this.lblBook.Location = new System.Drawing.Point(16, 12);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(64, 56);
            this.lblBook.TabIndex = 8;
            // 
            // CalendarCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblCurso);
            this.Name = "CalendarCourse";
            this.Size = new System.Drawing.Size(788, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
