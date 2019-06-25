namespace INFOSiS_2._0
{
    partial class CalendarDate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDia = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(3, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(101, 42);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "label1";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(3, 42);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(433, 17);
            this.lblLine.TabIndex = 1;
            this.lblLine.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // CalendarDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblDia);
            this.Name = "CalendarDate";
            this.Size = new System.Drawing.Size(447, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblLine;
    }
}
