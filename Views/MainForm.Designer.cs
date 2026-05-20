namespace QL_SinhVIen.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            this.menuStrip.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStudent,
            this.menuClass,
            this.menuLogout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1232, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuStudent
            // 
            this.menuStudent.Name = "menuStudent";
            this.menuStudent.Size = new System.Drawing.Size(140, 24);
            this.menuStudent.Text = "Quản lý Sinh Viên";
            this.menuStudent.Click += new System.EventHandler(this.menuStudent_Click);
            // 
            // menuClass
            // 
            this.menuClass.Name = "menuClass";
            this.menuClass.Size = new System.Drawing.Size(123, 24);
            this.menuClass.Text = "Quản lý Lớp Học";
            this.menuClass.Click += new System.EventHandler(this.menuClass_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(91, 24);
            this.menuLogout.Text = "Đăng xuất";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 28);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1232, 775);
            this.pnlContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 803);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStudent;
        private System.Windows.Forms.ToolStripMenuItem menuClass;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.Panel pnlContainer;
    }
}
