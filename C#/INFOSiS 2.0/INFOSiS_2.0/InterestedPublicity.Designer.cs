namespace INFOSiS_2._0
{
    partial class InterestedPublicity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInterestedRegister = new System.Windows.Forms.Label();
            this.dgvInteresadosMailing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicioCurso = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCursoEscogido = new System.Windows.Forms.Label();
            this.lblEditarMail = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApePa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEnviar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresadosMailing)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInterestedRegister
            // 
            this.lblInterestedRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterestedRegister.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestedRegister.Location = new System.Drawing.Point(10, 21);
            this.lblInterestedRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestedRegister.Name = "lblInterestedRegister";
            this.lblInterestedRegister.Size = new System.Drawing.Size(358, 48);
            this.lblInterestedRegister.TabIndex = 172;
            this.lblInterestedRegister.Text = "Publicidad para interesados";
            // 
            // dgvInteresadosMailing
            // 
            this.dgvInteresadosMailing.AllowUserToAddRows = false;
            this.dgvInteresadosMailing.AllowUserToDeleteRows = false;
            this.dgvInteresadosMailing.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInteresadosMailing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInteresadosMailing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteresadosMailing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cApePa,
            this.cCorreo,
            this.cSexo,
            this.cEnviar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInteresadosMailing.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInteresadosMailing.Location = new System.Drawing.Point(16, 207);
            this.dgvInteresadosMailing.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInteresadosMailing.Name = "dgvInteresadosMailing";
            this.dgvInteresadosMailing.ReadOnly = true;
            this.dgvInteresadosMailing.RowTemplate.Height = 24;
            this.dgvInteresadosMailing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInteresadosMailing.Size = new System.Drawing.Size(763, 247);
            this.dgvInteresadosMailing.TabIndex = 173;
            this.dgvInteresadosMailing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInteresadosMailing_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 174;
            this.label1.Text = "Cursos que inicien desde: ";
            // 
            // dtpInicioCurso
            // 
            this.dtpInicioCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInicioCurso.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.dtpInicioCurso.Location = new System.Drawing.Point(167, 84);
            this.dtpInicioCurso.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicioCurso.Name = "dtpInicioCurso";
            this.dtpInicioCurso.Size = new System.Drawing.Size(221, 23);
            this.dtpInicioCurso.TabIndex = 175;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(20, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 32);
            this.btnSearch.TabIndex = 185;
            this.btnSearch.Text = "Buscar curso";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F);
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 186;
            this.label2.Text = "Curso escogido: ";
            // 
            // lblCursoEscogido
            // 
            this.lblCursoEscogido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCursoEscogido.AutoSize = true;
            this.lblCursoEscogido.Location = new System.Drawing.Point(119, 178);
            this.lblCursoEscogido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCursoEscogido.Name = "lblCursoEscogido";
            this.lblCursoEscogido.Size = new System.Drawing.Size(0, 13);
            this.lblCursoEscogido.TabIndex = 187;
            // 
            // lblEditarMail
            // 
            this.lblEditarMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditarMail.AutoSize = true;
            this.lblEditarMail.Font = new System.Drawing.Font("Gill Sans MT", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblEditarMail.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblEditarMail.Location = new System.Drawing.Point(16, 457);
            this.lblEditarMail.Name = "lblEditarMail";
            this.lblEditarMail.Size = new System.Drawing.Size(86, 18);
            this.lblEditarMail.TabIndex = 188;
            this.lblEditarMail.Text = "Editar mailing";
            this.lblEditarMail.Click += new System.EventHandler(this.lblEditarMail_Click);
            this.lblEditarMail.MouseEnter += new System.EventHandler(this.LblEditarMail_MouseEnter);
            this.lblEditarMail.MouseLeave += new System.EventHandler(this.LblEditarMail_MouseLeave);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(424, 476);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(148, 39);
            this.btCancelar.TabIndex = 190;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btModificar
            // 
            this.btModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btModificar.FlatAppearance.BorderSize = 0;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btModificar.ForeColor = System.Drawing.Color.White;
            this.btModificar.Location = new System.Drawing.Point(220, 476);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(148, 39);
            this.btModificar.TabIndex = 189;
            this.btModificar.Text = "Enviar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "firstName";
            this.cNombre.FillWeight = 150F;
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 10;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 180;
            // 
            // cApePa
            // 
            this.cApePa.DataPropertyName = "primaryLastName";
            this.cApePa.HeaderText = "Apellido Paterno";
            this.cApePa.MinimumWidth = 10;
            this.cApePa.Name = "cApePa";
            this.cApePa.ReadOnly = true;
            this.cApePa.Width = 180;
            // 
            // cCorreo
            // 
            this.cCorreo.DataPropertyName = "email";
            this.cCorreo.HeaderText = "Correo";
            this.cCorreo.MinimumWidth = 10;
            this.cCorreo.Name = "cCorreo";
            this.cCorreo.ReadOnly = true;
            this.cCorreo.Width = 200;
            // 
            // cSexo
            // 
            this.cSexo.DataPropertyName = "gender";
            this.cSexo.HeaderText = "Sexo";
            this.cSexo.Name = "cSexo";
            this.cSexo.ReadOnly = true;
            // 
            // cEnviar
            // 
            this.cEnviar.HeaderText = "Enviar";
            this.cEnviar.MinimumWidth = 10;
            this.cEnviar.Name = "cEnviar";
            this.cEnviar.ReadOnly = true;
            this.cEnviar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cEnviar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cEnviar.Width = 60;
            // 
            // InterestedPublicity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.lblEditarMail);
            this.Controls.Add(this.lblCursoEscogido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpInicioCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInteresadosMailing);
            this.Controls.Add(this.lblInterestedRegister);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterestedPublicity";
            this.Size = new System.Drawing.Size(811, 566);
            this.Load += new System.EventHandler(this.InterestedPublicity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresadosMailing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterestedRegister;
        private System.Windows.Forms.DataGridView dgvInteresadosMailing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicioCurso;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCursoEscogido;
        private System.Windows.Forms.Label lblEditarMail;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApePa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSexo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cEnviar;
    }
}
