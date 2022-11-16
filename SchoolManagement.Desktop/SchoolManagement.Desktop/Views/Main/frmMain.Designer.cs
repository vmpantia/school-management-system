namespace SchoolManagement.Desktop
{
    partial class frmMain
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.pnlSystemVersion = new System.Windows.Forms.Panel();
            this.lblSystemVersion = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenuBar.SuspendLayout();
            this.pnlSystemVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1409, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenuBar.Controls.Add(this.pnlSystemVersion);
            this.pnlMenuBar.Controls.Add(this.btnStudent);
            this.pnlMenuBar.Controls.Add(this.label1);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 65);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(250, 613);
            this.pnlMenuBar.TabIndex = 1;
            // 
            // pnlSystemVersion
            // 
            this.pnlSystemVersion.Controls.Add(this.lblSystemVersion);
            this.pnlSystemVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSystemVersion.Location = new System.Drawing.Point(0, 582);
            this.pnlSystemVersion.Name = "pnlSystemVersion";
            this.pnlSystemVersion.Size = new System.Drawing.Size(250, 31);
            this.pnlSystemVersion.TabIndex = 4;
            // 
            // lblSystemVersion
            // 
            this.lblSystemVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSystemVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemVersion.Location = new System.Drawing.Point(0, 0);
            this.lblSystemVersion.Name = "lblSystemVersion";
            this.lblSystemVersion.Size = new System.Drawing.Size(250, 31);
            this.lblSystemVersion.TabIndex = 1;
            this.lblSystemVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(0, 46);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(250, 39);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.MouseEnter += new System.EventHandler(this.LabelMouseEnter);
            this.btnStudent.MouseLeave += new System.EventHandler(this.LabelMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1159, 613);
            this.pnlContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 678);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenuBar);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.pnlSystemVersion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnStudent;
        private System.Windows.Forms.Panel pnlSystemVersion;
        private System.Windows.Forms.Label lblSystemVersion;
    }
}

