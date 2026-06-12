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
            pagination.PageChanged += Pagination_PageChanged;
            LoadData();
        }

        private void Pagination_PageChanged(object sender, EventArgs e)
        {
            LoadData();
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
            try
            {
                dgvClassrooms.AutoGenerateColumns = false;

                string keyword = txtSearch.Text.Trim().ToLower();
                int pageSize = 10;
                int currentPage = pagination.CurrentPage;

                var query = db.Classrooms.Where(c => c.IsDelete == false);

                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(c => c.ClassCode.ToLower().Contains(keyword) || 
                                             c.ClassName.ToLower().Contains(keyword));
                }

                int totalRecords = query.Count();
                int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                if (totalPages == 0) totalPages = 1;

                if (currentPage > totalPages)
                {
                    currentPage = totalPages;
                    pagination.CurrentPage = currentPage;
                }

                pagination.TotalRecords = totalRecords;
                pagination.TotalPages = totalPages;

                var classroomList = query.OrderByDescending(c => c.Id)
                                         .Skip((currentPage - 1) * pageSize)
                                         .Take(pageSize)
                                         .ToList();

                dgvClassrooms.DataSource = classroomList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message);
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(21, 101, 192);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(25, 118, 210);
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(27, 94, 32);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(46, 125, 50);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(198, 40, 40);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(211, 47, 47);
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(97, 97, 97);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(117, 117, 117);
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(38, 50, 56);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(55, 71, 79);
        }

        private void btnViewStudents_MouseEnter(object sender, EventArgs e)
        {
            btnViewStudents.BackColor = Color.FromArgb(21, 101, 192);
        }

        private void btnViewStudents_MouseLeave(object sender, EventArgs e)
        {
            btnViewStudents.BackColor = Color.FromArgb(25, 118, 210);
        }

        // --- Business Click Event Handlers ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra ràng buộc dữ liệu đầu vào (Validation)
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

                //Khởi tạo một đối tượng Classroom mới từ thực thể LINQ
                Classroom newClass = new Classroom();

                //Ánh xạ dữ liệu từ giao diện vào đối tượng
                newClass.ClassCode = txtClassCode.Text.Trim();
                newClass.ClassName = txtClassName.Text.Trim();
                newClass.Notes = txtNotes.Text.Trim();

                // Đưa đối tượng vào hàng đợi chuẩn bị thêm của LINQ to SQL
                db.Classrooms.InsertOnSubmit(newClass);

                // Xác nhận cập nhật thay đổi xuống Database thực tế
                db.SubmitChanges();

                // Thông báo thành công, tải lại lưới dữ liệu và xóa trắng ô nhập liệu
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
                // Kiểm tra xem đã chọn lớp học cần sửa chưa
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một lớp học từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int classroomId = int.Parse(txtId.Text);

                // Tìm lớp học trong DB theo Id
                Classroom editClass = db.Classrooms.SingleOrDefault(c => c.Id == classroomId);

                if (editClass != null)
                {
                    // Cập nhật thông tin mới
                    editClass.ClassCode = txtClassCode.Text.Trim();
                    editClass.ClassName = txtClassName.Text.Trim();
                    editClass.Notes = txtNotes.Text.Trim();

                    // Lưu thay đổi xuống DB
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thông tin lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại lưới và xóa trắng ô nhập
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

                int classroomId = int.Parse(txtId.Text);

                //Kiểm tra xem lớp học có sinh viên không
                int activeStudentsCount = db.Students.Count(s => s.ClassId == classroomId && s.IsDelete == false);

                if (activeStudentsCount > 0)
                {
                    // Lớp học có sinh viên -> kiểm tra xem có lớp học nào khác chưa bị xóa không
                    int otherActiveClassesCount = db.Classrooms.Count(c => c.Id != classroomId && c.IsDelete == false);

                    if (otherActiveClassesCount == 0)
                    {
                        MessageBox.Show("Lớp học này đang có sinh viên, và không còn lớp học nào khác trong hệ thống để chuyển sinh viên sang. Không thể xóa lớp học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Mở dialog hỏi xác nhận
                    DialogResult confirmReassign = MessageBox.Show($"Lớp học đang có {activeStudentsCount} sinh viên hoạt động. Bạn có muốn tiếp tục xóa không? Nếu tiếp tục, bạn bắt buộc phải chuyển sinh viên sang lớp học khác.", "Xác nhận chuyển lớp & Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmReassign == DialogResult.Yes)
                    {
                        // Lấy ClassCode của lớp chuẩn bị xóa
                        Classroom deleteClass = db.Classrooms.SingleOrDefault(c => c.Id == classroomId);
                        string classCode = deleteClass != null ? deleteClass.ClassCode : "";

                        // Mở modal ReassignStudentsForm
                        using (ReassignStudentsForm modal = new ReassignStudentsForm(classroomId, classCode))
                        {
                            if (modal.ShowDialog(this) == DialogResult.OK)
                            {
                                // Refresh Data Context để tải lại dữ liệu mới nhất
                                db = new QLSinhVienDataContext();
                                LoadData();
                                ClearInputs();
                            }
                        }
                    }
                }
                else
                {
                    // Lớp học trống -> Tiến hành xóa mềm bình thường
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận xóa lớp trống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Classroom deleteClass = db.Classrooms.SingleOrDefault(c => c.Id == classroomId);

                        if (deleteClass != null)
                        {
                            deleteClass.IsDelete = true;
                            db.SubmitChanges();

                            MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData();
                            ClearInputs();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp học: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pagination.CurrentPage = 1; // Reset về trang 1 khi search
            LoadData();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            pagination.CurrentPage = 1;
            LoadData();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            /* feat<lophoc>: view list sinhvien is out of scope
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn một lớp học để xem danh sách sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int classroomId = int.Parse(txtId.Text);

            using (ClassroomStudentsForm modal = new ClassroomStudentsForm(classroomId))
            {
                modal.ShowDialog(this);
            }
            */
        }

        private void dgvClassrooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra dòng click hợp lệfeat<sinhvien>: DataGridView CellClickEvent
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

        private void dgvClassrooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty content click handler
        }
    }
}
