namespace INFOSiS_2._0
{
    partial class InterestedDisable
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
            this.lblInterestedRegister = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPasaporte = new System.Windows.Forms.RadioButton();
            this.rbCarnet = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.txbNDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(13, 26);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(477, 59);
            this.lblInterestedRegister.TabIndex = 173;
            this.lblInterestedRegister.Text = "Desactivar interesado";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbPasaporte);
            this.groupBox1.Controls.Add(this.rbCarnet);
            this.groupBox1.Controls.Add(this.rbDNI);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.groupBox1.Location = new System.Drawing.Point(30, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(449, 76);
            this.groupBox1.TabIndex = 180;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Documento";
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbPasaporte.Location = new System.Drawing.Point(331, 32);
            this.rbPasaporte.Margin = new System.Windows.Forms.Padding(4);
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Size = new System.Drawing.Size(102, 29);
            this.rbPasaporte.TabIndex = 2;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            // 
            // rbCarnet
            // 
            this.rbCarnet.AutoSize = true;
            this.rbCarnet.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbCarnet.Location = new System.Drawing.Point(121, 32);
            this.rbCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.rbCarnet.Name = "rbCarnet";
            this.rbCarnet.Size = new System.Drawing.Size(180, 29);
            this.rbCarnet.TabIndex = 1;
            this.rbCarnet.TabStop = true;
            this.rbCarnet.Text = "Carné de Extranjería";
            this.rbCarnet.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.rbDNI.Location = new System.Drawing.Point(37, 32);
            this.rbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(63, 29);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // txbNDocumento
            // 
            this.txbNDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNDocumento.Location = new System.Drawing.Point(224, 175);
            this.txbNDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txbNDocumento.Name = "txbNDocumento";
            this.txbNDocumento.Size = new System.Drawing.Size(253, 22);
            this.txbNDocumento.TabIndex = 167;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(28, 173);
            this.lblDocumentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(185, 25);
            this.lblDocumentNumber.TabIndex = 166;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // InterestedDisable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txbNDocumento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDocumentNumber);
            this.Controls.Add(this.lblInterestedRegister);
            this.Name = "InterestedDisable";
            this.Size = new System.Drawing.Size(1085, 697);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPasaporte;
        private System.Windows.Forms.RadioButton rbCarnet;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.TextBox txbNDocumento;
        private System.Windows.Forms.Label lblDocumentNumber;
    }
}
