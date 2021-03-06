﻿namespace INFOSiS_2._0
{
    partial class ProfessorAdvancedSearchForReport
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
            this.dgvProfessors = new System.Windows.Forms.DataGridView();
            this.idNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUCPcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSecondLastName = new System.Windows.Forms.TextBox();
            this.txtFirstLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(24, 8);
            this.lblInterestedRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(358, 48);
            this.lblInterestedRegister.TabIndex = 205;
            this.lblInterestedRegister.Text = "Busqueda avanzada";
            // 
            // dgvProfessors
            // 
            this.dgvProfessors.AllowUserToAddRows = false;
            this.dgvProfessors.AllowUserToDeleteRows = false;
            this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNumber,
            this.PUCPcode,
            this.firstName,
            this.primaryLastName,
            this.secondLastName});
            this.dgvProfessors.Location = new System.Drawing.Point(31, 247);
            this.dgvProfessors.Name = "dgvProfessors";
            this.dgvProfessors.ReadOnly = true;
            this.dgvProfessors.Size = new System.Drawing.Size(743, 238);
            this.dgvProfessors.TabIndex = 204;
            // 
            // idNumber
            // 
            this.idNumber.DataPropertyName = "idNumber";
            this.idNumber.HeaderText = "N° Documento";
            this.idNumber.Name = "idNumber";
            this.idNumber.ReadOnly = true;
            this.idNumber.Width = 130;
            // 
            // PUCPcode
            // 
            this.PUCPcode.DataPropertyName = "idPUCP";
            this.PUCPcode.HeaderText = "Código PUCP ";
            this.PUCPcode.Name = "PUCPcode";
            this.PUCPcode.ReadOnly = true;
            this.PUCPcode.Width = 120;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "firstName";
            this.firstName.HeaderText = "Nombre";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 150;
            // 
            // primaryLastName
            // 
            this.primaryLastName.DataPropertyName = "primaryLastName";
            this.primaryLastName.HeaderText = "Apellido Paterno";
            this.primaryLastName.Name = "primaryLastName";
            this.primaryLastName.ReadOnly = true;
            this.primaryLastName.Width = 150;
            // 
            // secondLastName
            // 
            this.secondLastName.DataPropertyName = "secondLastName";
            this.secondLastName.HeaderText = "Apellido Materno";
            this.secondLastName.Name = "secondLastName";
            this.secondLastName.ReadOnly = true;
            this.secondLastName.Width = 150;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(509, 140);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 37);
            this.btnSelect.TabIndex = 203;
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
            this.btnSearch.Location = new System.Drawing.Point(509, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 37);
            this.btnSearch.TabIndex = 202;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondLastName.Location = new System.Drawing.Point(231, 184);
            this.txtSecondLastName.Multiline = true;
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(206, 27);
            this.txtSecondLastName.TabIndex = 201;
            // 
            // txtFirstLastName
            // 
            this.txtFirstLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstLastName.Location = new System.Drawing.Point(231, 147);
            this.txtFirstLastName.Multiline = true;
            this.txtFirstLastName.Name = "txtFirstLastName";
            this.txtFirstLastName.Size = new System.Drawing.Size(206, 27);
            this.txtFirstLastName.TabIndex = 200;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiddleName.Location = new System.Drawing.Point(231, 111);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(206, 27);
            this.txtMiddleName.TabIndex = 199;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(231, 74);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 27);
            this.txtName.TabIndex = 198;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(136, 74);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 23);
            this.lblFirstName.TabIndex = 194;
            this.lblFirstName.Text = "Nombre:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblSecondName.Location = new System.Drawing.Point(84, 111);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(124, 23);
            this.lblSecondName.TabIndex = 195;
            this.lblSecondName.Text = "Segundo nombre:";
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblPrimaryLastName.Location = new System.Drawing.Point(86, 148);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(125, 23);
            this.lblPrimaryLastName.TabIndex = 196;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblSecondLastName.Location = new System.Drawing.Point(82, 185);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(129, 23);
            this.lblSecondLastName.TabIndex = 197;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // ProfessorAdvancedSearchForReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.lblInterestedRegister);
            this.Controls.Add(this.dgvProfessors);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSecondLastName);
            this.Controls.Add(this.txtFirstLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblPrimaryLastName);
            this.Controls.Add(this.lblSecondLastName);
            this.Name = "ProfessorAdvancedSearchForReport";
            this.Text = "ProfessorAdvancedSearchForReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.DataGridView dgvProfessors;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUCPcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondLastName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSecondLastName;
        private System.Windows.Forms.TextBox txtFirstLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.Label lblSecondLastName;
    }
}