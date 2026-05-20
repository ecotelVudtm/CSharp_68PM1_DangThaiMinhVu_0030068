using System;
using System.Drawing;
using System.Windows.Forms;
using QL_SinhVIen.Common;

namespace QL_SinhVIen.Views
{
    public partial class UCQLLH : UserControl
    {
        public UCQLLH()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.Font = StyleHelper.DefaultFont;
            this.BackColor = StyleHelper.BackgroundColor;
            this.Padding = new Padding(15);

            pnlMain.Padding = new Padding(0, 10, 0, 0);
            pnlGrid.Padding = new Padding(20, 0, 0, 0);
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Padding = new Padding(1);

            lblSearch.Font = StyleHelper.LabelFont;
            btnSearch.BackColor = StyleHelper.SearchDark;
            btnSearch.Font = StyleHelper.ButtonFont;

            pnlInput.BackColor = StyleHelper.PanelColor;
            pnlInput.Padding = new Padding(20);
            pnlButtons.Padding = new Padding(0, 20, 0, 0);

            btnAdd.BackColor = StyleHelper.PrimaryBlue;
            btnAdd.Font = StyleHelper.ButtonFont;
            btnEdit.BackColor = StyleHelper.SuccessGreen;
            btnEdit.Font = StyleHelper.ButtonFont;
            btnDelete.BackColor = StyleHelper.DangerRed;
            btnDelete.Font = StyleHelper.ButtonFont;
            btnRefresh.BackColor = StyleHelper.SecondaryGrey;
            btnRefresh.Font = StyleHelper.ButtonFont;
            
            btnViewStudents.BackColor = StyleHelper.PrimaryBlue;
            btnViewStudents.Font = StyleHelper.ButtonFont;

            tlpInputs.Padding = new Padding(0, 10, 0, 0);

            lblId.Font = StyleHelper.LabelFont;
            txtId.BackColor = Color.FromArgb(245, 245, 245);

            lblClassCode.Font = StyleHelper.LabelFont;
            txtClassCode.BackColor = Color.White;

            lblClassName.Font = StyleHelper.LabelFont;
            txtClassName.BackColor = Color.White;

            lblTitle.Font = StyleHelper.HeaderFont;
            lblTitle.ForeColor = StyleHelper.PrimaryBlue;

            dgvClassrooms.AlternatingRowsDefaultCellStyle.BackColor = StyleHelper.ZebraColor;
            dgvClassrooms.ColumnHeadersDefaultCellStyle.BackColor = StyleHelper.PrimaryBlue;
            dgvClassrooms.ColumnHeadersDefaultCellStyle.Font = StyleHelper.ButtonFont;
            dgvClassrooms.DefaultCellStyle.SelectionBackColor = StyleHelper.SelectionColor;
            dgvClassrooms.GridColor = StyleHelper.BorderColor;
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

        private void btnViewStudents_MouseEnter(object sender, EventArgs e)
        {
            btnViewStudents.BackColor = StyleHelper.PrimaryBlueHover;
        }

        private void btnViewStudents_MouseLeave(object sender, EventArgs e)
        {
            btnViewStudents.BackColor = StyleHelper.PrimaryBlue;
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

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            // Empty click handler
        }

        private void dgvClassrooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty click handler
        }
    }
}
