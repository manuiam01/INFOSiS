namespace INFOSiS_2._0
{
    partial class WorkforceButtons
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
            this.btnAvailability = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAvailability
            // 
            this.btnAvailability.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAvailability.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAvailability.FlatAppearance.BorderSize = 0;
            this.btnAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailability.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailability.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAvailability.Location = new System.Drawing.Point(4, 160);
            this.btnAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(345, 81);
            this.btnAvailability.TabIndex = 94;
            this.btnAvailability.Text = "Registrar disponibilidad";
            this.btnAvailability.UseVisualStyleBackColor = false;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSchedule.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSchedule.Location = new System.Drawing.Point(1, 265);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(349, 73);
            this.btnSchedule.TabIndex = 95;
            this.btnSchedule.Text = "Visualizar horario";
            this.btnSchedule.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReport.Location = new System.Drawing.Point(4, 361);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(345, 82);
            this.btnReport.TabIndex = 96;
            this.btnReport.Text = "Reporte de asistencia";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // WorkforceButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnReport);
            this.Name = "WorkforceButtons";
            this.Size = new System.Drawing.Size(351, 602);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnReport;
    }
}
