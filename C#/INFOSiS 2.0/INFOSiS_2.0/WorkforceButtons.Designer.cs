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
            this.btnWeekAvailability = new System.Windows.Forms.Button();
            this.btnModificarIntern = new System.Windows.Forms.Button();
            this.btnNewIntern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeekAvailability
            // 
            this.btnWeekAvailability.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnWeekAvailability.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWeekAvailability.FlatAppearance.BorderSize = 0;
            this.btnWeekAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekAvailability.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekAvailability.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWeekAvailability.Location = new System.Drawing.Point(1, 361);
            this.btnWeekAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.btnWeekAvailability.Name = "btnWeekAvailability";
            this.btnWeekAvailability.Size = new System.Drawing.Size(345, 81);
            this.btnWeekAvailability.TabIndex = 97;
            this.btnWeekAvailability.Text = "Disponibilidad Semanal";
            this.btnWeekAvailability.UseVisualStyleBackColor = false;
            this.btnWeekAvailability.Click += new System.EventHandler(this.btnWeekAvailability_Click);
            // 
            // btnModificarIntern
            // 
            this.btnModificarIntern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarIntern.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarIntern.FlatAppearance.BorderSize = 0;
            this.btnModificarIntern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarIntern.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarIntern.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificarIntern.Location = new System.Drawing.Point(4, 264);
            this.btnModificarIntern.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarIntern.Name = "btnModificarIntern";
            this.btnModificarIntern.Size = new System.Drawing.Size(345, 81);
            this.btnModificarIntern.TabIndex = 96;
            this.btnModificarIntern.Text = "Modificar un Practicante";
            this.btnModificarIntern.UseVisualStyleBackColor = false;
            this.btnModificarIntern.Click += new System.EventHandler(this.btnModificarIntern_Click);
            // 
            // btnNewIntern
            // 
            this.btnNewIntern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewIntern.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewIntern.FlatAppearance.BorderSize = 0;
            this.btnNewIntern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIntern.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewIntern.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewIntern.Location = new System.Drawing.Point(1, 160);
            this.btnNewIntern.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewIntern.Name = "btnNewIntern";
            this.btnNewIntern.Size = new System.Drawing.Size(345, 81);
            this.btnNewIntern.TabIndex = 95;
            this.btnNewIntern.Text = "Registrar un Practicante";
            this.btnNewIntern.UseVisualStyleBackColor = false;
            this.btnNewIntern.Click += new System.EventHandler(this.btnNewIntern_Click);
            // 
            // WorkforceButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnWeekAvailability);
            this.Controls.Add(this.btnModificarIntern);
            this.Controls.Add(this.btnNewIntern);
            this.Name = "WorkforceButtons";
            this.Size = new System.Drawing.Size(351, 602);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeekAvailability;
        private System.Windows.Forms.Button btnModificarIntern;
        private System.Windows.Forms.Button btnNewIntern;
    }
}
