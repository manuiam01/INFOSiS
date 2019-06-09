namespace INFOSiS_2._0
{
    partial class ProfessorControl
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelProfessorOptions = new System.Windows.Forms.Panel();
            this.panelProfessor = new System.Windows.Forms.Panel();
            this.panelProfessorOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(0, 306);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(236, 73);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "Buscar Profesor";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReporte.Location = new System.Drawing.Point(0, 396);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(236, 82);
            this.btnReporte.TabIndex = 90;
            this.btnReporte.Text = "Reporte\r\n de cursos dictados";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNew.Location = new System.Drawing.Point(10, 215);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(236, 73);
            this.btnNew.TabIndex = 85;
            this.btnNew.Text = "Registrar un Profesor";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelProfessorOptions
            // 
            this.panelProfessorOptions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelProfessorOptions.Controls.Add(this.btnNew);
            this.panelProfessorOptions.Controls.Add(this.btnReporte);
            this.panelProfessorOptions.Controls.Add(this.btnSearch);
            this.panelProfessorOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfessorOptions.Location = new System.Drawing.Point(0, 0);
            this.panelProfessorOptions.Name = "panelProfessorOptions";
            this.panelProfessorOptions.Size = new System.Drawing.Size(246, 889);
            this.panelProfessorOptions.TabIndex = 91;
            // 
            // panelProfessor
            // 
            this.panelProfessor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelProfessor.Location = new System.Drawing.Point(246, 0);
            this.panelProfessor.Name = "panelProfessor";
            this.panelProfessor.Size = new System.Drawing.Size(1181, 889);
            this.panelProfessor.TabIndex = 0;
            this.panelProfessor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProfessor_Paint);
            // 
            // ProfessorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProfessorOptions);
            this.Controls.Add(this.panelProfessor);
            this.Name = "ProfessorControl";
            this.Size = new System.Drawing.Size(1427, 889);
            this.panelProfessorOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelProfessorOptions;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelProfessor;
    }
}
