using System;
using System.Drawing;
using System.Windows.Forms;
using QL_SinhVIen.Common;

namespace QL_SinhVIen.Views
{
    public partial class UCQLSinhVien : UserControl
    {
        public UCQLSinhVien()
        {
            InitializeComponent();
            
            this.Font = StyleHelper.DefaultFont;
            this.BackColor = StyleHelper.BackgroundColor;
            this.Padding = new Padding(15);
        }

        // --- Event Handlers for hover effects ---
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = StyleHelper.PrimaryBlueHover;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = StyleHelper.PrimaryBlue;
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = StyleHelper.SuccessGreenHover;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = StyleHelper.SuccessGreen;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = StyleHelper.DangerRedHover;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = StyleHelper.DangerRed;
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = StyleHelper.SecondaryGreyHover;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = StyleHelper.SecondaryGrey;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = StyleHelper.SearchDarkHover;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = StyleHelper.SearchDark;
        }

        // --- Business Click Event Handlers (Empty as requested) ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Empty click handler
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Empty click handler
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Empty click handler
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Empty click handler
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Empty click handler
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty click handler
        }
    }
}
