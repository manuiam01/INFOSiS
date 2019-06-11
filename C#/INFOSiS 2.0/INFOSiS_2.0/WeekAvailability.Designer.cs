namespace INFOSiS_2._0
{
    partial class WeekAvailability
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
            this.lblWeekAvailability = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWeekAvailability
            // 
            this.lblWeekAvailability.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWeekAvailability.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekAvailability.Location = new System.Drawing.Point(13, 22);
            this.lblWeekAvailability.Name = "lblWeekAvailability";
            this.lblWeekAvailability.Size = new System.Drawing.Size(477, 59);
            this.lblWeekAvailability.TabIndex = 171;
            this.lblWeekAvailability.Text = "Disponibilidad Semanal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 172;
            this.label1.Text = "label1";
            // 
            // WeekAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeekAvailability);
            this.Name = "WeekAvailability";
            this.Size = new System.Drawing.Size(1081, 697);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeekAvailability;
        private System.Windows.Forms.Label label1;
    }
}
