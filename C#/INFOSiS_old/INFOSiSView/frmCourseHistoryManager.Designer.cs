namespace INFOSiSView
{
    partial class frmCourseHistoryManager
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblRequisite = new System.Windows.Forms.Label();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.lblProffesor = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbAssistant = new System.Windows.Forms.ComboBox();
            this.cmbProffesor = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSelectSurvey = new System.Windows.Forms.Button();
            this.lblSessions = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSurvey = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(58, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Código:";
            // 
            // lblRequisite
            // 
            this.lblRequisite.AutoSize = true;
            this.lblRequisite.Location = new System.Drawing.Point(64, 80);
            this.lblRequisite.Name = "lblRequisite";
            this.lblRequisite.Size = new System.Drawing.Size(37, 13);
            this.lblRequisite.TabIndex = 4;
            this.lblRequisite.Text = "Curso:";
            // 
            // lblAssistant
            // 
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.Location = new System.Drawing.Point(48, 132);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(53, 13);
            this.lblAssistant.TabIndex = 9;
            this.lblAssistant.Text = "Asistente:";
            // 
            // lblProffesor
            // 
            this.lblProffesor.AutoSize = true;
            this.lblProffesor.Location = new System.Drawing.Point(52, 106);
            this.lblProffesor.Name = "lblProffesor";
            this.lblProffesor.Size = new System.Drawing.Size(49, 13);
            this.lblProffesor.TabIndex = 10;
            this.lblProffesor.Text = "Profesor:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(51, 184);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(45, 13);
            this.lblStudent.TabIndex = 11;
            this.lblStudent.Text = "Alumno:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(107, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(208, 20);
            this.txtId.TabIndex = 12;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(107, 77);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(208, 21);
            this.cmbCourse.TabIndex = 15;
            // 
            // cmbAssistant
            // 
            this.cmbAssistant.FormattingEnabled = true;
            this.cmbAssistant.Location = new System.Drawing.Point(107, 129);
            this.cmbAssistant.Name = "cmbAssistant";
            this.cmbAssistant.Size = new System.Drawing.Size(208, 21);
            this.cmbAssistant.TabIndex = 16;
            // 
            // cmbProffesor
            // 
            this.cmbProffesor.FormattingEnabled = true;
            this.cmbProffesor.Location = new System.Drawing.Point(107, 103);
            this.cmbProffesor.Name = "cmbProffesor";
            this.cmbProffesor.Size = new System.Drawing.Size(208, 21);
            this.cmbProffesor.TabIndex = 17;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StudentName});
            this.dgvStudents.Location = new System.Drawing.Point(51, 235);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(591, 254);
            this.dgvStudents.TabIndex = 19;
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(107, 49);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(136, 23);
            this.btnAddSession.TabIndex = 20;
            this.btnAddSession.Text = "Añadir sesiones";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(506, 75);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(136, 23);
            this.btnModify.TabIndex = 21;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(506, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(136, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSelectSurvey
            // 
            this.btnSelectSurvey.Location = new System.Drawing.Point(107, 153);
            this.btnSelectSurvey.Name = "btnSelectSurvey";
            this.btnSelectSurvey.Size = new System.Drawing.Size(136, 23);
            this.btnSelectSurvey.TabIndex = 23;
            this.btnSelectSurvey.Text = "Seleccionar encuesta";
            this.btnSelectSurvey.UseVisualStyleBackColor = true;
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Location = new System.Drawing.Point(48, 54);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(53, 13);
            this.lblSessions.TabIndex = 25;
            this.lblSessions.Text = "Sesiones:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(506, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSurvey
            // 
            this.lblSurvey.AutoSize = true;
            this.lblSurvey.Location = new System.Drawing.Point(48, 158);
            this.lblSurvey.Name = "lblSurvey";
            this.lblSurvey.Size = new System.Drawing.Size(55, 13);
            this.lblSurvey.TabIndex = 28;
            this.lblSurvey.Text = "Encuesta:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(506, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(506, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(107, 181);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(208, 21);
            this.cmbStudent.TabIndex = 31;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(364, 179);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(136, 23);
            this.btnAddStudent.TabIndex = 32;
            this.btnAddStudent.Text = "Añadir alumno";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(506, 179);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteStudent.TabIndex = 33;
            this.btnDeleteStudent.Text = "Eliminar alumno";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(48, 219);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(89, 13);
            this.lblStudents.TabIndex = 34;
            this.lblStudents.Text = "Lista de alumnos:";
            // 
            // ID
            // 
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Nombre del alumno";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 450;
            // 
            // frmCourseHistoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 501);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSurvey);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSessions);
            this.Controls.Add(this.btnSelectSurvey);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.cmbProffesor);
            this.Controls.Add(this.cmbAssistant);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblProffesor);
            this.Controls.Add(this.lblAssistant);
            this.Controls.Add(this.lblRequisite);
            this.Controls.Add(this.lblId);
            this.Name = "frmCourseHistoryManager";
            this.Text = "Gestión de Cursos Dictados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRequisite;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.Label lblProffesor;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbAssistant;
        private System.Windows.Forms.ComboBox cmbProffesor;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSelectSurvey;
        private System.Windows.Forms.Label lblSessions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSurvey;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblStudents;
    }
}