using System;
using System.Drawing;
using System.Windows.Forms;
using QL_SinhVIen.Common;

namespace QL_SinhVIen.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            this.Text = "Hệ thống quản lý sinh viên - SPA Modern UI";
            this.Size = new Size(1250, 850);
            this.Font = StyleHelper.DefaultFont;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = StyleHelper.BackgroundColor;
            
            this.menuLogout.ForeColor = StyleHelper.DangerRed;
            
            // Mặc định load màn hình Lớp học khi khởi động
            ShowUserControl(new UCQLLH());

            this.FormClosed += (s, e) => Application.Exit();
        }

        public void ShowUserControl(UserControl uc)
        {
            // Giải phóng triệt để các control cũ trước khi dọn dẹp để tránh rò rỉ bộ nhớ
            while (pnlContainer.Controls.Count > 0)
            {
                var oldControl = pnlContainer.Controls[0];
                pnlContainer.Controls.RemoveAt(0);
                oldControl.Dispose();
            }

            if (uc != null)
            {
                uc.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(uc);
            }
        }

        private void menuStudent_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCQLSinhVien());
        }

        private void menuClass_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCQLLH());
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
