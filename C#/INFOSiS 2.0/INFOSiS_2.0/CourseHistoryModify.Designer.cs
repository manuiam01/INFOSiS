namespace INFOSiS_2._0
{
    partial class CourseHistoryModify
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmounPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.DateTimeSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSession = new System.Windows.Forms.Button();
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
            this.btnSearchCourseH = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dgvStudents);
            this.groupBox3.Controls.Add(this.btnAddStudent);
            this.groupBox3.Location = new System.Drawing.Point(353, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox3.Size = new System.Drawing.Size(455, 285);
            this.groupBox3.TabIndex = 183;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alumnos:";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(103, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 26);
            this.button2.TabIndex = 180;
            this.button2.Text = "Agregar Alumnos desde CSV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(172, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 26);
            this.button1.TabIndex = 179;
            this.button1.Text = "Eliminar Alumnos Seleccionados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StudentName,
            this.Grade,
            this.AmounPaid});
            this.dgvStudents.Location = new System.Drawing.Point(7, 59);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(441, 187);
            this.dgvStudents.TabIndex = 178;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Nombre";
            this.StudentName.HeaderText = "Nombre";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 200;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Nota";
            this.Grade.HeaderText = "Nota";
            this.Grade.Name = "Grade";
            this.Grade.Width = 30;
            // 
            // AmounPaid
            // 
            this.AmounPaid.DataPropertyName = "Pagado";
            this.AmounPaid.HeaderText = "Monto Pagado";
            this.AmounPaid.Name = "AmounPaid";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(7, 18);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(159, 26);
            this.btnAddStudent.TabIndex = 177;
            this.btnAddStudent.Text = "Agregar Alumnos";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgvSessions);
            this.groupBox2.Controls.Add(this.btnAddSession);
            this.groupBox2.Location = new System.Drawing.Point(26, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Size = new System.Drawing.Size(319, 285);
            this.groupBox2.TabIndex = 182;
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
            this.dgvSessions.Location = new System.Drawing.Point(7, 59);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.Size = new System.Drawing.Size(300, 187);
            this.dgvSessions.TabIndex = 178;
            // 
            // DateTimeSession
            // 
            this.DateTimeSession.DataPropertyName = "DateSession";
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
            this.btnAddSession.Location = new System.Drawing.Point(7, 18);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(138, 26);
            this.btnAddSession.TabIndex = 177;
            this.btnAddSession.Text = "Editar Sesiones";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(26, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(782, 145);
            this.groupBox1.TabIndex = 181;
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
            this.btnSearchProfessor.Location = new System.Drawing.Point(430, 66);
            this.btnSearchProfessor.Name = "btnSearchProfessor";
            this.btnSearchProfessor.Size = new System.Drawing.Size(155, 26);
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
            this.btnSearchAssistant.Location = new System.Drawing.Point(430, 101);
            this.btnSearchAssistant.Name = "btnSearchAssistant";
            this.btnSearchAssistant.Size = new System.Drawing.Size(155, 26);
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
            this.btnSearchCourse.Location = new System.Drawing.Point(430, 30);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(155, 26);
            this.btnSearchCourse.TabIndex = 179;
            this.btnSearchCourse.Text = "Buscar Curso";
            this.btnSearchCourse.UseVisualStyleBackColor = false;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // txtAssistant
            // 
            this.txtAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssistant.Location = new System.Drawing.Point(133, 105);
            this.txtAssistant.Name = "txtAssistant";
            this.txtAssistant.Size = new System.Drawing.Size(282, 20);
            this.txtAssistant.TabIndex = 192;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProfessor.Location = new System.Drawing.Point(133, 70);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(282, 20);
            this.txtProfessor.TabIndex = 191;
            // 
            // lblAssistant
            // 
            this.lblAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistant.Location = new System.Drawing.Point(65, 106);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(69, 18);
            this.lblAssistant.TabIndex = 190;
            this.lblAssistant.Text = "Asistente: *";
            // 
            // lblProfessor
            // 
            this.lblProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(70, 70);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(65, 18);
            this.lblProfessor.TabIndex = 189;
            this.lblProfessor.Text = "Profesor: *";
            // 
            // txtCourse
            // 
            this.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourse.Location = new System.Drawing.Point(133, 34);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(282, 20);
            this.txtCourse.TabIndex = 5;
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(80, 34);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 18);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Curso: *";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 180;
            this.label1.Text = "Modificar un curso dictado";
            // 
            // btnSearchCourseH
            // 
            this.btnSearchCourseH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchCourseH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchCourseH.FlatAppearance.BorderSize = 0;
            this.btnSearchCourseH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCourseH.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCourseH.ForeColor = System.Drawing.Color.White;
            this.btnSearchCourseH.Location = new System.Drawing.Point(456, 66);
            this.btnSearchCourseH.Name = "btnSearchCourseH";
            this.btnSearchCourseH.Size = new System.Drawing.Size(216, 51);
            this.btnSearchCourseH.TabIndex = 179;
            this.btnSearchCourseH.Text = "Buscar Cursos Dictados";
            this.btnSearchCourseH.UseVisualStyleBackColor = false;
            this.btnSearchCourseH.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(159, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 51);
            this.button4.TabIndex = 184;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(429, 596);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 51);
            this.button5.TabIndex = 185;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 195;
            this.label2.Text = "Código del curso:";
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchCourse.Location = new System.Drawing.Point(159, 84);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(282, 20);
            this.txtSearchCourse.TabIndex = 195;
            // 
            // CourseHistoryModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSearchCourseH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CourseHistoryModify";
            this.Size = new System.Drawing.Size(848, 681);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmounPaid;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchProfessor;
        private System.Windows.Forms.Button btnSearchAssistant;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.TextBox txtAssistant;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchCourseH;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchCourse;
    }
}
