namespace INFOSiS_2._0
{
    partial class WorkforceAdvancedSearch
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
            this.lblInterestedRegister = new System.Windows.Forms.Label();
            this.dgvInterns = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSecondLastName = new System.Windows.Forms.TextBox();
            this.txtPrimaryLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.cNDocu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApePa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApeMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterns)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(32, 18);
            this.lblInterestedRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(358, 48);
            this.lblInterestedRegister.TabIndex = 193;
            this.lblInterestedRegister.Text = "Busqueda avanzada";
            // 
            // dgvInterns
            // 
            this.dgvInterns.AllowUserToAddRows = false;
            this.dgvInterns.AllowUserToDeleteRows = false;
            this.dgvInterns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNDocu,
            this.cNombre,
            this.cApePa,
            this.cApeMa});
            this.dgvInterns.Location = new System.Drawing.Point(39, 273);
            this.dgvInterns.Name = "dgvInterns";
            this.dgvInterns.ReadOnly = true;
            this.dgvInterns.Size = new System.Drawing.Size(715, 199);
            this.dgvInterns.TabIndex = 192;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(522, 157);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 37);
            this.btnSelect.TabIndex = 191;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(522, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 37);
            this.btnSearch.TabIndex = 190;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondLastName.Location = new System.Drawing.Point(239, 192);
            this.txtSecondLastName.Multiline = true;
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(206, 27);
            this.txtSecondLastName.TabIndex = 189;
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimaryLastName.Location = new System.Drawing.Point(239, 158);
            this.txtPrimaryLastName.Multiline = true;
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(206, 27);
            this.txtPrimaryLastName.TabIndex = 188;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiddleName.Location = new System.Drawing.Point(239, 122);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(206, 27);
            this.txtMiddleName.TabIndex = 187;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(239, 87);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(206, 27);
            this.txtFirstName.TabIndex = 186;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(139, 87);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 23);
            this.lblFirstName.TabIndex = 182;
            this.lblFirstName.Text = "Nombre:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblSecondName.Location = new System.Drawing.Point(85, 122);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(124, 23);
            this.lblSecondName.TabIndex = 183;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblPrimaryLastName.Location = new System.Drawing.Point(86, 157);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(125, 23);
            this.lblPrimaryLastName.TabIndex = 184;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblSecondLastName.Location = new System.Drawing.Point(83, 193);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(129, 23);
            this.lblSecondLastName.TabIndex = 185;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // cNDocu
            // 
            this.cNDocu.DataPropertyName = "idNumber";
            this.cNDocu.HeaderText = "N° Documento";
            this.cNDocu.Name = "cNDocu";
            this.cNDocu.ReadOnly = true;
            this.cNDocu.Width = 120;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "firstName";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 180;
            // 
            // cApePa
            // 
            this.cApePa.DataPropertyName = "primaryLastName";
            this.cApePa.HeaderText = "Apellido Paterno";
            this.cApePa.Name = "cApePa";
            this.cApePa.ReadOnly = true;
            this.cApePa.Width = 200;
            // 
            // cApeMa
            // 
            this.cApeMa.DataPropertyName = "secondLastName";
            this.cApeMa.HeaderText = "Apellido Materno";
            this.cApeMa.Name = "cApeMa";
            this.cApeMa.ReadOnly = true;
            this.cApeMa.Width = 200;
            // 
            // WorkforceAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.lblInterestedRegister);
            this.Controls.Add(this.dgvInterns);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSecondLastName);
            this.Controls.Add(this.txtPrimaryLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblPrimaryLastName);
            this.Controls.Add(this.lblSecondLastName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkforceAdvancedSearch";
            this.Text = "InternAdvanceSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.DataGridView dgvInterns;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSecondLastName;
        private System.Windows.Forms.TextBox txtPrimaryLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNDocu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApePa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApeMa;
    }
}