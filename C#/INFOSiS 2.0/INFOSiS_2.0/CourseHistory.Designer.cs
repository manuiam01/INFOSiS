namespace INFOSiS_2._0
{
    partial class CourseHistory
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAdvancedSearch = new System.Windows.Forms.Label();
            this.dgvCoursesHistory = new System.Windows.Forms.DataGridView();
            this.idCourseHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPUCPcode = new System.Windows.Forms.Label();
            this.txtIdCourse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblCourseHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(427, 581);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 48);
            this.btnCancelar.TabIndex = 201;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblAdvancedSearch
            // 
            this.lblAdvancedSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvancedSearch.AutoSize = true;
            this.lblAdvancedSearch.Font = new System.Drawing.Font("Gill Sans MT", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAdvancedSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAdvancedSearch.Location = new System.Drawing.Point(516, 145);
            this.lblAdvancedSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdvancedSearch.Name = "lblAdvancedSearch";
            this.lblAdvancedSearch.Size = new System.Drawing.Size(148, 21);
            this.lblAdvancedSearch.TabIndex = 199;
            this.lblAdvancedSearch.Text = "Busqueda avanzada";
            // 
            // dgvCoursesHistory
            // 
            this.dgvCoursesHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCoursesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCourseHistory,
            this.courseName,
            this.startDate,
            this.endDate,
            this.Hours});
            this.dgvCoursesHistory.Location = new System.Drawing.Point(82, 273);
            this.dgvCoursesHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCoursesHistory.Name = "dgvCoursesHistory";
            this.dgvCoursesHistory.Size = new System.Drawing.Size(942, 283);
            this.dgvCoursesHistory.TabIndex = 198;
            // 
            // idCourseHistory
            // 
            this.idCourseHistory.DataPropertyName = "id";
            this.idCourseHistory.HeaderText = "ID Curso Dictado";
            this.idCourseHistory.Name = "idCourseHistory";
            this.idCourseHistory.Width = 80;
            // 
            // courseName
            // 
            this.courseName.HeaderText = "Nombre Profesor";
            this.courseName.Name = "courseName";
            this.courseName.Width = 300;
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "startDate";
            this.startDate.HeaderText = "Fecha Inicio";
            this.startDate.Name = "startDate";
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "Fecha Fin";
            this.endDate.Name = "endDate";
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "hours";
            this.Hours.HeaderText = "Duración en Horas";
            this.Hours.Name = "Hours";
            this.Hours.Width = 80;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(245, 134);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 46);
            this.btnSearch.TabIndex = 197;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPUCPcode
            // 
            this.lblPUCPcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPUCPcode.AutoSize = true;
            this.lblPUCPcode.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUCPcode.Location = new System.Drawing.Point(301, 98);
            this.lblPUCPcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPUCPcode.Name = "lblPUCPcode";
            this.lblPUCPcode.Size = new System.Drawing.Size(137, 25);
            this.lblPUCPcode.TabIndex = 195;
            this.lblPUCPcode.Text = "Código del curso:";
            this.lblPUCPcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdCourse
            // 
            this.txtIdCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCourse.Location = new System.Drawing.Point(456, 98);
            this.txtIdCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCourse.MaxLength = 7;
            this.txtIdCourse.Multiline = true;
            this.txtIdCourse.Name = "txtIdCourse";
            this.txtIdCourse.Size = new System.Drawing.Size(265, 25);
            this.txtIdCourse.TabIndex = 194;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 193;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 192;
            this.label1.Text = "Desde:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.Location = new System.Drawing.Point(673, 219);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(265, 22);
            this.dtpEndDate.TabIndex = 191;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.Location = new System.Drawing.Point(233, 219);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(265, 22);
            this.dtpStartDate.TabIndex = 190;
            // 
            // lblCourseHistory
            // 
            this.lblCourseHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourseHistory.AutoSize = true;
            this.lblCourseHistory.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseHistory.Location = new System.Drawing.Point(48, 33);
            this.lblCourseHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseHistory.Name = "lblCourseHistory";
            this.lblCourseHistory.Size = new System.Drawing.Size(317, 47);
            this.lblCourseHistory.TabIndex = 189;
            this.lblCourseHistory.Text = "Historial de un Curso";
            // 
            // CourseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAdvancedSearch);
            this.Controls.Add(this.dgvCoursesHistory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPUCPcode);
            this.Controls.Add(this.txtIdCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblCourseHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CourseHistory";
            this.Size = new System.Drawing.Size(1085, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAdvancedSearch;
        private System.Windows.Forms.DataGridView dgvCoursesHistory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPUCPcode;
        private System.Windows.Forms.TextBox txtIdCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblCourseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
    }
}
