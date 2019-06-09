namespace INFOSiS_2._0
{
    partial class ProfessorSearch
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
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.txtProfessorID = new System.Windows.Forms.TextBox();
            this.lblProfessorRegister = new System.Windows.Forms.Label();
            this.dgvProfessors = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfessorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(194, 216);
            this.lblDocumentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(158, 17);
            this.lblDocumentNumber.TabIndex = 136;
            this.lblDocumentNumber.Text = "Número de Documento:";
            // 
            // txtProfessorID
            // 
            this.txtProfessorID.Location = new System.Drawing.Point(372, 211);
            this.txtProfessorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfessorID.Multiline = true;
            this.txtProfessorID.Name = "txtProfessorID";
            this.txtProfessorID.Size = new System.Drawing.Size(242, 32);
            this.txtProfessorID.TabIndex = 135;
            // 
            // lblProfessorRegister
            // 
            this.lblProfessorRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorRegister.Location = new System.Drawing.Point(88, 78);
            this.lblProfessorRegister.Name = "lblProfessorRegister";
            this.lblProfessorRegister.Size = new System.Drawing.Size(305, 52);
            this.lblProfessorRegister.TabIndex = 171;
            this.lblProfessorRegister.Text = "Buscar un profesor";
            // 
            // dgvProfessors
            // 
            this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessors.Location = new System.Drawing.Point(93, 425);
            this.dgvProfessors.Name = "dgvProfessors";
            this.dgvProfessors.RowTemplate.Height = 24;
            this.dgvProfessors.Size = new System.Drawing.Size(902, 306);
            this.dgvProfessors.TabIndex = 173;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSelect.Location = new System.Drawing.Point(741, 299);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(208, 46);
            this.btnSelect.TabIndex = 176;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(741, 200);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 46);
            this.btnSearch.TabIndex = 175;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 177;
            this.label1.Text = "Nombre:";
            // 
            // txtProfessorName
            // 
            this.txtProfessorName.Location = new System.Drawing.Point(372, 278);
            this.txtProfessorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfessorName.Multiline = true;
            this.txtProfessorName.Name = "txtProfessorName";
            this.txtProfessorName.Size = new System.Drawing.Size(242, 34);
            this.txtProfessorName.TabIndex = 178;
            // 
            // ProfessorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtProfessorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProfessors);
            this.Controls.Add(this.lblProfessorRegister);
            this.Controls.Add(this.lblDocumentNumber);
            this.Controls.Add(this.txtProfessorID);
            this.Name = "ProfessorSearch";
            this.Size = new System.Drawing.Size(1181, 889);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.TextBox txtProfessorID;
        private System.Windows.Forms.Label lblProfessorRegister;
        private System.Windows.Forms.DataGridView dgvProfessors;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfessorName;
    }
}
