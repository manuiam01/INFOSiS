namespace INFOSiS_2._0
{
    partial class StudentButtons
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
            this.btnRegStudent = new System.Windows.Forms.Button();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegStudent
            // 
            this.btnRegStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegStudent.FlatAppearance.BorderSize = 0;
            this.btnRegStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegStudent.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegStudent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegStudent.Location = new System.Drawing.Point(0, 90);
            this.btnRegStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegStudent.Name = "btnRegStudent";
            this.btnRegStudent.Size = new System.Drawing.Size(351, 84);
            this.btnRegStudent.TabIndex = 0;
            this.btnRegStudent.Text = "Registrar un Alumno";
            this.btnRegStudent.UseVisualStyleBackColor = false;
            this.btnRegStudent.Click += new System.EventHandler(this.btnRegStudent_Click);
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyStudent.FlatAppearance.BorderSize = 0;
            this.btnModifyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyStudent.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyStudent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModifyStudent.Location = new System.Drawing.Point(0, 182);
            this.btnModifyStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(351, 84);
            this.btnModifyStudent.TabIndex = 1;
            this.btnModifyStudent.Text = "Modificar un Alumno";
            this.btnModifyStudent.UseVisualStyleBackColor = false;
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(0, 274);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(351, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "Certificado de Curso";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(0, 366);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(351, 84);
            this.button4.TabIndex = 3;
            this.button4.Text = "Constancia de Cursos";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // StudentButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnModifyStudent);
            this.Controls.Add(this.btnRegStudent);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentButtons";
            this.Size = new System.Drawing.Size(351, 521);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegStudent;
        private System.Windows.Forms.Button btnModifyStudent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
