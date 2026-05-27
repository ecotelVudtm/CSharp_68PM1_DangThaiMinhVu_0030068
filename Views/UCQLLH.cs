using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QL_SinhVIen.Common;

namespace QL_SinhVIen.Views
{
    public partial class UCQLLH : UserControl
    {
        QLSinhVienDataContext db = new QLSinhVienDataContext();
        public UCQLLH()
        {
            InitializeComponent();
            LoadData();
            ApplyStyles();
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtClassCode.Clear();
            txtClassName.Clear();
            txtNotes.Clear();

            // Đẩy con trỏ chuột về lại ô Mã lớp để người dùng sẵn sàng nhập tiếp
            txtClassCode.Focus();
        }

        private void LoadData()
        {
            // Lấy danh sách lớp học từ CSDL và đổ vào DataGridView
            dgvClassrooms.DataSource = db.Classrooms.ToList();
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

        // --- Business Click Event Handlers ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra ràng buộc dữ liệu đầu vào (Validation)
                if (string.IsNullOrEmpty(txtClassCode.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập Mã lớp học!");
                    txtClassCode.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtClassName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập Tên lớp học!");
                    txtClassName.Focus();
                    return;
                }

                // 2. Khởi tạo một đối tượng Classroom mới từ thực thể LINQ
                Classroom newClass = new Classroom();

                // 3. Ánh xạ dữ liệu từ giao diện vào đối tượng
                newClass.ClassCode = txtClassCode.Text.Trim();
                newClass.ClassName = txtClassName.Text.Trim();
                newClass.Notes = txtNotes.Text.Trim();

                // 4. Đưa đối tượng vào hàng đợi chuẩn bị thêm của LINQ to SQL
                db.Classrooms.InsertOnSubmit(newClass);

                // 5. Xác nhận cập nhật thay đổi xuống Database thực tế
                db.SubmitChanges();

                // 6. Thông báo thành công, tải lại lưới dữ liệu và xóa trắng ô nhập liệu
                MessageBox.Show("Thêm mới lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();     // Làm mới GridView lớp học
                ClearInputs();  // Xóa trắng các ô nhập liệu để sẵn sàng nhập lớp tiếp theo
            }
            catch (Exception ex)
            {
                // Bắt các lỗi như trùng Mã lớp hoặc lỗi kết nối
                MessageBox.Show("Lỗi khi thêm lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem đã chọn lớp học cần sửa chưa
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một lớp học từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int classroomId = int.Parse(txtId.Text);

                // 2. Tìm lớp học trong DB theo Id
                Classroom editClass = db.Classrooms.SingleOrDefault(c => c.Id == classroomId);

                if (editClass != null)
                {
                    // 3. Cập nhật thông tin mới
                    editClass.ClassCode = txtClassCode.Text.Trim();
                    editClass.ClassName = txtClassName.Text.Trim();
                    editClass.Notes = txtNotes.Text.Trim();

                    // 4. Lưu thay đổi xuống DB
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thông tin lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Tải lại lưới và xóa trắng ô nhập
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một lớp học từ danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int classroomId = int.Parse(txtId.Text);

                    // Tìm lớp cần xóa
                    Classroom deleteClass = db.Classrooms.SingleOrDefault(c => c.Id == classroomId);

                    if (deleteClass != null)
                    {
                        // Xóa lớp khỏi hàng đợi
                        db.Classrooms.DeleteOnSubmit(deleteClass);

                        // Đồng bộ xuống DB
                        db.SubmitChanges();

                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                // Bắt các lỗi ràng buộc dữ liệu (Ví dụ: Lớp đang có sinh viên thì không cho xóa)
                MessageBox.Show("Không thể xóa lớp học này! Có thể lớp đang chứa sinh viên. Chi tiết lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
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

        private void dgvClassrooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra dòng click hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClassrooms.Rows[e.RowIndex];

                // Đổ dữ liệu từ các cột lên Control tương ứng (Vị trí 0: Id, Vị trí 1: ClassCode, Vị trí 2: ClassName)
                txtId.Text = row.Cells[0].Value?.ToString();
                txtClassCode.Text = row.Cells[1].Value?.ToString();
                txtClassName.Text = row.Cells[2].Value?.ToString();
                txtNotes.Text = row.Cells[3].Value?.ToString();
            }
        }
    }
}
