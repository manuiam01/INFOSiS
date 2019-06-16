namespace INFOSiS_2._0
{
    partial class InterestedPublicity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInterestedRegister = new System.Windows.Forms.Label();
            this.dgvInteresadosMailing = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApePa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApeMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEnviar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresadosMailing)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(13, 26);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(477, 59);
            this.lblInterestedRegister.TabIndex = 172;
            this.lblInterestedRegister.Text = "Publicidad para interesados";
            // 
            // dgvInteresadosMailing
            // 
            this.dgvInteresadosMailing.AllowUserToAddRows = false;
            this.dgvInteresadosMailing.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInteresadosMailing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInteresadosMailing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteresadosMailing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cSNombre,
            this.cApePa,
            this.cApeMa,
            this.cCorreo,
            this.cEnviar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInteresadosMailing.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInteresadosMailing.Location = new System.Drawing.Point(21, 255);
            this.dgvInteresadosMailing.Name = "dgvInteresadosMailing";
            this.dgvInteresadosMailing.ReadOnly = true;
            this.dgvInteresadosMailing.RowTemplate.Height = 24;
            this.dgvInteresadosMailing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInteresadosMailing.Size = new System.Drawing.Size(1033, 304);
            this.dgvInteresadosMailing.TabIndex = 173;
            // 
            // cNombre
            // 
            this.cNombre.FillWeight = 150F;
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 10;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 150;
            // 
            // cSNombre
            // 
            this.cSNombre.HeaderText = "Segundo Nombre";
            this.cSNombre.MinimumWidth = 10;
            this.cSNombre.Name = "cSNombre";
            this.cSNombre.ReadOnly = true;
            this.cSNombre.Width = 150;
            // 
            // cApePa
            // 
            this.cApePa.HeaderText = "Apellido Paterno";
            this.cApePa.MinimumWidth = 10;
            this.cApePa.Name = "cApePa";
            this.cApePa.ReadOnly = true;
            this.cApePa.Width = 150;
            // 
            // cApeMa
            // 
            this.cApeMa.HeaderText = "Apellido Materno";
            this.cApeMa.MinimumWidth = 10;
            this.cApeMa.Name = "cApeMa";
            this.cApeMa.ReadOnly = true;
            this.cApeMa.Width = 150;
            // 
            // cCorreo
            // 
            this.cCorreo.HeaderText = "Correo";
            this.cCorreo.MinimumWidth = 10;
            this.cCorreo.Name = "cCorreo";
            this.cCorreo.ReadOnly = true;
            this.cCorreo.Width = 200;
            // 
            // cEnviar
            // 
            this.cEnviar.HeaderText = "Enviar";
            this.cEnviar.MinimumWidth = 10;
            this.cEnviar.Name = "cEnviar";
            this.cEnviar.ReadOnly = true;
            this.cEnviar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cEnviar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cEnviar.Width = 60;
            // 
            // InterestedPublicity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInteresadosMailing);
            this.Controls.Add(this.lblInterestedRegister);
            this.Name = "InterestedPublicity";
            this.Size = new System.Drawing.Size(1081, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresadosMailing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.DataGridView dgvInteresadosMailing;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApePa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApeMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCorreo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cEnviar;
    }
}
