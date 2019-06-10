namespace INFOSiS_2._0
{
    partial class InterestedButtons
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
            this.btnNewInte = new System.Windows.Forms.Button();
            this.btnModificarInte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewInte
            // 
            this.btnNewInte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewInte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewInte.FlatAppearance.BorderSize = 0;
            this.btnNewInte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInte.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewInte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewInte.Location = new System.Drawing.Point(0, 127);
            this.btnNewInte.Name = "btnNewInte";
            this.btnNewInte.Size = new System.Drawing.Size(259, 66);
            this.btnNewInte.TabIndex = 92;
            this.btnNewInte.Text = "Registrar un Interesado";
            this.btnNewInte.UseVisualStyleBackColor = false;
            this.btnNewInte.Click += new System.EventHandler(this.BtnNewInte_Click);
            // 
            // btnModificarInte
            // 
            this.btnModificarInte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarInte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarInte.FlatAppearance.BorderSize = 0;
            this.btnModificarInte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarInte.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificarInte.Location = new System.Drawing.Point(2, 211);
            this.btnModificarInte.Name = "btnModificarInte";
            this.btnModificarInte.Size = new System.Drawing.Size(259, 66);
            this.btnModificarInte.TabIndex = 93;
            this.btnModificarInte.Text = "Modificar un Interesado";
            this.btnModificarInte.UseVisualStyleBackColor = false;
            // 
            // InterestedButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnModificarInte);
            this.Controls.Add(this.btnNewInte);
            this.Name = "InterestedButtons";
            this.Size = new System.Drawing.Size(263, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewInte;
        private System.Windows.Forms.Button btnModificarInte;
    }
}
