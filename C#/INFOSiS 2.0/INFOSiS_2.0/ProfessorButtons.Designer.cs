namespace INFOSiS_2._0
{
    partial class ProfessorButtons
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCourseHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNew.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNew.Location = new System.Drawing.Point(0, 156);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(345, 81);
            this.btnNew.TabIndex = 91;
            this.btnNew.Text = "Registrar un Profesor";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModify.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModify.Location = new System.Drawing.Point(-3, 261);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(349, 73);
            this.btnModify.TabIndex = 92;
            this.btnModify.Text = "Modificar un Profesor";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnCourseHistory
            // 
            this.btnCourseHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCourseHistory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCourseHistory.FlatAppearance.BorderSize = 0;
            this.btnCourseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseHistory.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseHistory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCourseHistory.Location = new System.Drawing.Point(0, 357);
            this.btnCourseHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseHistory.Name = "btnCourseHistory";
            this.btnCourseHistory.Size = new System.Drawing.Size(345, 82);
            this.btnCourseHistory.TabIndex = 93;
            this.btnCourseHistory.Text = "Historial de Cursos Dictados";
            this.btnCourseHistory.UseVisualStyleBackColor = false;
            this.btnCourseHistory.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // ProfessorButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCourseHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfessorButtons";
            this.Size = new System.Drawing.Size(351, 602);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCourseHistory;
    }
}
