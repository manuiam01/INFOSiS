namespace INFOSiS_2._0
{
    partial class CourseHSelectAssistant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(215, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 33);
            this.btnCancelar.TabIndex = 186;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(71, 210);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 33);
            this.btnSeleccionar.TabIndex = 185;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 184;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 183;
            this.label1.Text = "Asistente:";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNombre});
            this.dgvCursos.Location = new System.Drawing.Point(14, 50);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(378, 141);
            this.dgvCursos.TabIndex = 182;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 70;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "Nombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 248;
            // 
            // CourseHSelectAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 258);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCursos);
            this.Name = "CourseHSelectAssistant";
            this.Text = "CourseHSelectAssistant";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
    }
}