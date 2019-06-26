namespace INFOSiS_2._0
{
    partial class CourseHistoryRegister
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.DateTimeSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchProfessor = new System.Windows.Forms.Button();
            this.btnSearchAssistant = new System.Windows.Forms.Button();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.txtAssistant = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgvSessions);
            this.groupBox2.Controls.Add(this.btnAddSession);
            this.groupBox2.Location = new System.Drawing.Point(46, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox2.Size = new System.Drawing.Size(509, 351);
            this.groupBox2.TabIndex = 178;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sesiones:";
            // 
            // dgvSessions
            // 
            this.dgvSessions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeSession,
            this.Hours,
            this.Location});
            this.dgvSessions.Location = new System.Drawing.Point(17, 85);
            this.dgvSessions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.Size = new System.Drawing.Size(479, 230);
            this.dgvSessions.TabIndex = 178;
            // 
            // DateTimeSession
            // 
            this.DateTimeSession.HeaderText = "Fecha de la sesión";
            this.DateTimeSession.Name = "DateTimeSession";
            this.DateTimeSession.Width = 150;
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "Hours";
            this.Hours.HeaderText = "Horas";
            this.Hours.Name = "Hours";
            this.Hours.Width = 50;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Aula";
            this.Location.Name = "Location";
            // 
            // btnAddSession
            // 
            this.btnAddSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSession.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddSession.FlatAppearance.BorderSize = 0;
            this.btnAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSession.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSession.ForeColor = System.Drawing.Color.White;
            this.btnAddSession.Location = new System.Drawing.Point(17, 34);
            this.btnAddSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(284, 32);
            this.btnAddSession.TabIndex = 177;
            this.btnAddSession.Text = "Agregar Sesiones";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(431, 624);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 53);
            this.btnSave.TabIndex = 179;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSearchProfessor);
            this.groupBox1.Controls.Add(this.btnSearchAssistant);
            this.groupBox1.Controls.Add(this.btnSearchCourse);
            this.groupBox1.Controls.Add(this.txtAssistant);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.lblAssistant);
            this.groupBox1.Controls.Add(this.lblProfessor);
            this.groupBox1.Controls.Add(this.txtCourse);
            this.groupBox1.Controls.Add(this.lblCourse);
            this.groupBox1.Location = new System.Drawing.Point(46, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox1.Size = new System.Drawing.Size(1043, 178);
            this.groupBox1.TabIndex = 177;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Curso";
            // 
            // btnSearchProfessor
            // 
            this.btnSearchProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchProfessor.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchProfessor.FlatAppearance.BorderSize = 0;
            this.btnSearchProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProfessor.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProfessor.ForeColor = System.Drawing.Color.White;
            this.btnSearchProfessor.Location = new System.Drawing.Point(573, 81);
            this.btnSearchProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchProfessor.Name = "btnSearchProfessor";
            this.btnSearchProfessor.Size = new System.Drawing.Size(207, 32);
            this.btnSearchProfessor.TabIndex = 194;
            this.btnSearchProfessor.Text = "Buscar Profesor";
            this.btnSearchProfessor.UseVisualStyleBackColor = false;
            this.btnSearchProfessor.Click += new System.EventHandler(this.btnSearchProfessor_Click);
            // 
            // btnSearchAssistant
            // 
            this.btnSearchAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchAssistant.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchAssistant.FlatAppearance.BorderSize = 0;
            this.btnSearchAssistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAssistant.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAssistant.ForeColor = System.Drawing.Color.White;
            this.btnSearchAssistant.Location = new System.Drawing.Point(573, 124);
            this.btnSearchAssistant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchAssistant.Name = "btnSearchAssistant";
            this.btnSearchAssistant.Size = new System.Drawing.Size(207, 32);
            this.btnSearchAssistant.TabIndex = 193;
            this.btnSearchAssistant.Text = "Buscar Asistente";
            this.btnSearchAssistant.UseVisualStyleBackColor = false;
            this.btnSearchAssistant.Click += new System.EventHandler(this.btnSearchAssistant_Click);
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchCourse.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchCourse.FlatAppearance.BorderSize = 0;
            this.btnSearchCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCourse.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCourse.ForeColor = System.Drawing.Color.White;
            this.btnSearchCourse.Location = new System.Drawing.Point(573, 37);
            this.btnSearchCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(207, 32);
            this.btnSearchCourse.TabIndex = 179;
            this.btnSearchCourse.Text = "Buscar Curso";
            this.btnSearchCourse.UseVisualStyleBackColor = false;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // txtAssistant
            // 
            this.txtAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssistant.Location = new System.Drawing.Point(177, 129);
            this.txtAssistant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAssistant.Name = "txtAssistant";
            this.txtAssistant.Size = new System.Drawing.Size(375, 22);
            this.txtAssistant.TabIndex = 192;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProfessor.Location = new System.Drawing.Point(177, 86);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(375, 22);
            this.txtProfessor.TabIndex = 191;
            // 
            // lblAssistant
            // 
            this.lblAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistant.Location = new System.Drawing.Point(87, 130);
            this.lblAssistant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(94, 25);
            this.lblAssistant.TabIndex = 190;
            this.lblAssistant.Text = "Asistente: *";
            // 
            // lblProfessor
            // 
            this.lblProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(93, 86);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(88, 25);
            this.lblProfessor.TabIndex = 189;
            this.lblProfessor.Text = "Profesor: *";
            // 
            // txtCourse
            // 
            this.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourse.Location = new System.Drawing.Point(177, 42);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(375, 22);
            this.txtCourse.TabIndex = 5;
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(107, 42);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(72, 25);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Curso: *";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 47);
            this.label1.TabIndex = 176;
            this.label1.Text = "Registrar un curso dictado";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dgvStudents);
            this.groupBox3.Controls.Add(this.btnAddStudent);
            this.groupBox3.Location = new System.Drawing.Point(566, 262);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox3.Size = new System.Drawing.Size(523, 351);
            this.groupBox3.TabIndex = 179;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alumnos:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(24, 85);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(479, 230);
            this.dgvStudents.TabIndex = 178;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(24, 34);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(284, 32);
            this.btnAddStudent.TabIndex = 177;
            this.btnAddStudent.Text = "Agregar Alumnos";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // CourseHistoryRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CourseHistoryRegister";
            this.Size = new System.Drawing.Size(1131, 706);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchProfessor;
        private System.Windows.Forms.Button btnSearchAssistant;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.TextBox txtAssistant;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}
