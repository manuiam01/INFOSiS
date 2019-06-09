namespace INFOSiSView
{
    partial class frmAddSession
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
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(100, 15);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(208, 20);
            this.dtpDay.TabIndex = 24;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(100, 41);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(208, 20);
            this.txtPlace.TabIndex = 23;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(100, 67);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(208, 20);
            this.txtHours.TabIndex = 22;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(66, 18);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(28, 13);
            this.lblDay.TabIndex = 21;
            this.lblDay.Text = "Día:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(57, 44);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(37, 13);
            this.lblPlace.TabIndex = 20;
            this.lblPlace.Text = "Lugar:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(56, 70);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 19;
            this.lblHours.Text = "Horas:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(58, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Place,
            this.Hours});
            this.dgvSessions.Location = new System.Drawing.Point(12, 147);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.Size = new System.Drawing.Size(347, 213);
            this.dgvSessions.TabIndex = 28;
            // 
            // Day
            // 
            this.Day.HeaderText = "Día";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.HeaderText = "Lugar";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Duración";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            // 
            // frmAddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 375);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblHours);
            this.Name = "frmAddSession";
            this.Text = "Sesiones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
    }
}