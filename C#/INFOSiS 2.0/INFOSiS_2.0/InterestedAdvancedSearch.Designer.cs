namespace INFOSiS_2._0
{
    partial class InterestedAdvancedSearch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbSNombre = new System.Windows.Forms.TextBox();
            this.tbApePa = new System.Windows.Forms.TextBox();
            this.tbApeMa = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvInteresados = new System.Windows.Forms.DataGridView();
            this.lblInterestedRegister = new System.Windows.Forms.Label();
            this.cNDocu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApePa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApeMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(91, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 23);
            this.lblFirstName.TabIndex = 170;
            this.lblFirstName.Text = "Nombre:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblSecondName.Location = new System.Drawing.Point(37, 103);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(124, 23);
            this.lblSecondName.TabIndex = 171;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblPrimaryLastName.Location = new System.Drawing.Point(38, 138);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(125, 23);
            this.lblPrimaryLastName.TabIndex = 172;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblSecondLastName.Location = new System.Drawing.Point(35, 174);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(129, 23);
            this.lblSecondLastName.TabIndex = 173;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Location = new System.Drawing.Point(172, 68);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(206, 27);
            this.tbNombre.TabIndex = 174;
            // 
            // tbSNombre
            // 
            this.tbSNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSNombre.Location = new System.Drawing.Point(172, 103);
            this.tbSNombre.Multiline = true;
            this.tbSNombre.Name = "tbSNombre";
            this.tbSNombre.Size = new System.Drawing.Size(206, 27);
            this.tbSNombre.TabIndex = 175;
            // 
            // tbApePa
            // 
            this.tbApePa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApePa.Location = new System.Drawing.Point(172, 140);
            this.tbApePa.Multiline = true;
            this.tbApePa.Name = "tbApePa";
            this.tbApePa.Size = new System.Drawing.Size(206, 27);
            this.tbApePa.TabIndex = 176;
            // 
            // tbApeMa
            // 
            this.tbApeMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApeMa.Location = new System.Drawing.Point(172, 173);
            this.tbApeMa.Multiline = true;
            this.tbApeMa.Name = "tbApeMa";
            this.tbApeMa.Size = new System.Drawing.Size(206, 27);
            this.tbApeMa.TabIndex = 177;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(426, 136);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 37);
            this.btnSelect.TabIndex = 179;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(426, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 37);
            this.btnSearch.TabIndex = 178;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvInteresados
            // 
            this.dgvInteresados.AllowUserToAddRows = false;
            this.dgvInteresados.AllowUserToDeleteRows = false;
            this.dgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteresados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNDocu,
            this.cNombre,
            this.cApePa,
            this.cApeMa});
            this.dgvInteresados.Location = new System.Drawing.Point(39, 227);
            this.dgvInteresados.Name = "dgvInteresados";
            this.dgvInteresados.ReadOnly = true;
            this.dgvInteresados.Size = new System.Drawing.Size(543, 199);
            this.dgvInteresados.TabIndex = 180;
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(42, 16);
            this.lblInterestedRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(358, 48);
            this.lblInterestedRegister.TabIndex = 181;
            this.lblInterestedRegister.Text = "Busqueda avanzada";
            // 
            // cNDocu
            // 
            this.cNDocu.DataPropertyName = "idNumber";
            this.cNDocu.HeaderText = "N° Documento";
            this.cNDocu.Name = "cNDocu";
            this.cNDocu.ReadOnly = true;
            this.cNDocu.Width = 70;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "firstName";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 120;
            // 
            // cApePa
            // 
            this.cApePa.DataPropertyName = "primaryLastName";
            this.cApePa.HeaderText = "Apellido Paterno";
            this.cApePa.Name = "cApePa";
            this.cApePa.ReadOnly = true;
            this.cApePa.Width = 150;
            // 
            // cApeMa
            // 
            this.cApeMa.DataPropertyName = "secondLastName";
            this.cApeMa.HeaderText = "Apellido Materno";
            this.cApeMa.Name = "cApeMa";
            this.cApeMa.ReadOnly = true;
            this.cApeMa.Width = 150;
            // 
            // InterestedAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 438);
            this.Controls.Add(this.lblInterestedRegister);
            this.Controls.Add(this.dgvInteresados);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbApeMa);
            this.Controls.Add(this.tbApePa);
            this.Controls.Add(this.tbSNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblPrimaryLastName);
            this.Controls.Add(this.lblSecondLastName);
            this.Name = "InterestedAdvancedSearch";
            this.Text = "InterestedAdvancedSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbSNombre;
        private System.Windows.Forms.TextBox tbApePa;
        private System.Windows.Forms.TextBox tbApeMa;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvInteresados;
        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNDocu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApePa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApeMa;
    }
}