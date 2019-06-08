namespace INFOSiSView
{
    partial class frmStudentConsult
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
            this.lblPucpCode = new System.Windows.Forms.Label();
            this.txtPucpCode = new System.Windows.Forms.TextBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.dgvCoursesHistory = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblPrimaryLastName = new System.Windows.Forms.Label();
            this.txtPrimaryLastName = new System.Windows.Forms.TextBox();
            this.lblSecondLastName = new System.Windows.Forms.Label();
            this.txtSecondLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Nombre_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPucpCode
            // 
            this.lblPucpCode.AutoSize = true;
            this.lblPucpCode.Location = new System.Drawing.Point(96, 42);
            this.lblPucpCode.Name = "lblPucpCode";
            this.lblPucpCode.Size = new System.Drawing.Size(75, 13);
            this.lblPucpCode.TabIndex = 0;
            this.lblPucpCode.Text = "Código PUCP:";
            // 
            // txtPucpCode
            // 
            this.txtPucpCode.Location = new System.Drawing.Point(186, 39);
            this.txtPucpCode.Name = "txtPucpCode";
            this.txtPucpCode.Size = new System.Drawing.Size(195, 20);
            this.txtPucpCode.TabIndex = 1;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(49, 217);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(188, 25);
            this.lblCourses.TabIndex = 2;
            this.lblCourses.Text = "Histórico de Cursos:";
            // 
            // dgvCoursesHistory
            // 
            this.dgvCoursesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Curso,
            this.Nota,
            this.Resultado});
            this.dgvCoursesHistory.Location = new System.Drawing.Point(47, 259);
            this.dgvCoursesHistory.Name = "dgvCoursesHistory";
            this.dgvCoursesHistory.Size = new System.Drawing.Size(561, 208);
            this.dgvCoursesHistory.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(124, 72);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(47, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Nombre:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(186, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(295, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(80, 102);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(91, 13);
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Segundo nombre:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(186, 99);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(336, 20);
            this.txtMiddleName.TabIndex = 7;
            // 
            // lblPrimaryLastName
            // 
            this.lblPrimaryLastName.AutoSize = true;
            this.lblPrimaryLastName.Location = new System.Drawing.Point(85, 132);
            this.lblPrimaryLastName.Name = "lblPrimaryLastName";
            this.lblPrimaryLastName.Size = new System.Drawing.Size(86, 13);
            this.lblPrimaryLastName.TabIndex = 8;
            this.lblPrimaryLastName.Text = "Apellido paterno:";
            // 
            // txtPrimaryLastName
            // 
            this.txtPrimaryLastName.Location = new System.Drawing.Point(186, 129);
            this.txtPrimaryLastName.Name = "txtPrimaryLastName";
            this.txtPrimaryLastName.Size = new System.Drawing.Size(336, 20);
            this.txtPrimaryLastName.TabIndex = 9;
            // 
            // lblSecondLastName
            // 
            this.lblSecondLastName.AutoSize = true;
            this.lblSecondLastName.Location = new System.Drawing.Point(85, 162);
            this.lblSecondLastName.Name = "lblSecondLastName";
            this.lblSecondLastName.Size = new System.Drawing.Size(88, 13);
            this.lblSecondLastName.TabIndex = 10;
            this.lblSecondLastName.Text = "Apellido materno:";
            // 
            // txtSecondLastName
            // 
            this.txtSecondLastName.Location = new System.Drawing.Point(186, 159);
            this.txtSecondLastName.Name = "txtSecondLastName";
            this.txtSecondLastName.Size = new System.Drawing.Size(336, 20);
            this.txtSecondLastName.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(486, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(136, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // Nombre_Curso
            // 
            this.Nombre_Curso.Frozen = true;
            this.Nombre_Curso.HeaderText = "Nombre_Curso";
            this.Nombre_Curso.Name = "Nombre_Curso";
            this.Nombre_Curso.ReadOnly = true;
            this.Nombre_Curso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre_Curso.Width = 300;
            // 
            // Nota
            // 
            this.Nota.Frozen = true;
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Resultado
            // 
            this.Resultado.Frozen = true;
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Resultado.Width = 120;
            // 
            // frmStudentConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 502);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSecondLastName);
            this.Controls.Add(this.lblSecondLastName);
            this.Controls.Add(this.txtPrimaryLastName);
            this.Controls.Add(this.lblPrimaryLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.dgvCoursesHistory);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.txtPucpCode);
            this.Controls.Add(this.lblPucpCode);
            this.Name = "frmStudentConsult";
            this.Text = "Consultar Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPucpCode;
        private System.Windows.Forms.TextBox txtPucpCode;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.DataGridView dgvCoursesHistory;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblPrimaryLastName;
        private System.Windows.Forms.TextBox txtPrimaryLastName;
        private System.Windows.Forms.Label lblSecondLastName;
        private System.Windows.Forms.TextBox txtSecondLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
    }
}