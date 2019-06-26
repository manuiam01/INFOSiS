namespace INFOSiS_2._0
{
    partial class ProfessorReport
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
            this.lblProfessorReport = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPUCPcode = new System.Windows.Forms.Label();
            this.txtPUCPcode = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCoursesHistory = new System.Windows.Forms.DataGridView();
            this.idCourseHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdvancedSearch = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfessorReport
            // 
            this.lblProfessorReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfessorReport.AutoSize = true;
            this.lblProfessorReport.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorReport.Location = new System.Drawing.Point(23, 31);
            this.lblProfessorReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfessorReport.Name = "lblProfessorReport";
            this.lblProfessorReport.Size = new System.Drawing.Size(346, 47);
            this.lblProfessorReport.TabIndex = 0;
            this.lblProfessorReport.Text = "Reporte de un Profesor";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.Location = new System.Drawing.Point(208, 217);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(265, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.Location = new System.Drawing.Point(648, 217);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(265, 22);
            this.dtpEndDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // lblPUCPcode
            // 
            this.lblPUCPcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPcode.AutoSize = true;
            this.lblPUCPcode.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPcode.Location = new System.Drawing.Point(276, 96);
            this.lblPUCPcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPUCPcode.Name = "lblPUCPcode";
            this.lblPUCPcode.Size = new System.Drawing.Size(114, 25);
            this.lblPUCPcode.TabIndex = 138;
            this.lblPUCPcode.Text = "Código PUCP:";
            this.lblPUCPcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPUCPcode
            // 
            this.txtPUCPcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPUCPcode.Location = new System.Drawing.Point(431, 96);
            this.txtPUCPcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPUCPcode.Multiline = true;
            this.txtPUCPcode.Name = "txtPUCPcode";
            this.txtPUCPcode.Size = new System.Drawing.Size(265, 25);
            this.txtPUCPcode.TabIndex = 137;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(281, 615);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(208, 46);
            this.btnReport.TabIndex = 176;
            this.btnReport.Text = "Reporte";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(220, 132);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 46);
            this.btnSearch.TabIndex = 177;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvCoursesHistory
            // 
            this.dgvCoursesHistory.AllowUserToAddRows = false;
            this.dgvCoursesHistory.AllowUserToDeleteRows = false;
            this.dgvCoursesHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCoursesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCourseHistory,
            this.courseName,
            this.startDate,
            this.endDate,
            this.Hours});
            this.dgvCoursesHistory.Location = new System.Drawing.Point(76, 272);
            this.dgvCoursesHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCoursesHistory.Name = "dgvCoursesHistory";
            this.dgvCoursesHistory.ReadOnly = true;
            this.dgvCoursesHistory.Size = new System.Drawing.Size(937, 268);
            this.dgvCoursesHistory.TabIndex = 178;
            // 
            // idCourseHistory
            // 
            this.idCourseHistory.DataPropertyName = "id";
            this.idCourseHistory.HeaderText = "ID Curso Dictado";
            this.idCourseHistory.Name = "idCourseHistory";
            this.idCourseHistory.ReadOnly = true;
            this.idCourseHistory.Width = 80;
            // 
            // courseName
            // 
            this.courseName.DataPropertyName = "courseName";
            this.courseName.HeaderText = "Nombre Curso";
            this.courseName.Name = "courseName";
            this.courseName.ReadOnly = true;
            this.courseName.Width = 300;
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "startDate";
            this.startDate.HeaderText = "Fecha Inicio";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "Fecha Fin";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "hours";
            this.Hours.HeaderText = "Duración en Horas";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            this.Hours.Width = 80;
            // 
            // lblAdvancedSearch
            // 
            this.lblAdvancedSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvancedSearch.AutoSize = true;
            this.lblAdvancedSearch.Font = new System.Drawing.Font("Gill Sans MT", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAdvancedSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAdvancedSearch.Location = new System.Drawing.Point(491, 143);
            this.lblAdvancedSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdvancedSearch.Name = "lblAdvancedSearch";
            this.lblAdvancedSearch.Size = new System.Drawing.Size(148, 21);
            this.lblAdvancedSearch.TabIndex = 186;
            this.lblAdvancedSearch.Text = "Busqueda avanzada";
            this.lblAdvancedSearch.Click += new System.EventHandler(this.lblAdvancedSearch_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(89, 544);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(723, 17);
            this.lblInfo.TabIndex = 187;
            this.lblInfo.Text = "*Si no selecciona un curso el reporte será generado en base a todos los cursos di" +
    "ctados por el profesor buscado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(597, 613);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 48);
            this.btnCancelar.TabIndex = 188;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ProfessorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAdvancedSearch);
            this.Controls.Add(this.dgvCoursesHistory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblPUCPcode);
            this.Controls.Add(this.txtPUCPcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblProfessorReport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfessorReport";
            this.Size = new System.Drawing.Size(1085, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfessorReport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPUCPcode;
        private System.Windows.Forms.TextBox txtPUCPcode;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCoursesHistory;
        private System.Windows.Forms.Label lblAdvancedSearch;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
    }
}
