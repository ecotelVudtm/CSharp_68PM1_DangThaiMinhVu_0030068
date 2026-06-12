using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QL_SinhVIen.Common;

namespace QL_SinhVIen.Views
{
    public partial class UCQLSinhVien : UserControl
    {
        QLSinhVienDataContext db = new QLSinhVienDataContext();
        // feat<sinhvien>: SearchPaging
        // private int? filterClassId = null;

        public UCQLSinhVien() : this(null)
        {
        }

        public UCQLSinhVien(int? classId)
        {
            InitializeComponent();
            this.Padding = new Padding(15);
            // feat<sinhvien>: SearchPaging
            // this.filterClassId = classId;

            // pagination.PageChanged += Pagination_PageChanged;

            /*
            if (classId != null)
            {
                var cls = db.Classrooms.SingleOrDefault(c => c.Id == classId);
                if (cls != null)
                {
                    txtSearch.Text = cls.ClassCode;
                }
            }
            */

            LoadData();
            LoadClassroomsToComboBox();
            FormatGridView();
        }

        // Hàm định dạng lại hiển thị ngày sinh cho lưới
        private void FormatGridView()
        {
            try
            {
                if (dgvStudents.Columns["BirthDate"] != null)
                {
                    dgvStudents.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch { }
        }

        // Hàm lấy dữ liệu sinh viên đổ vào DataGridView
        private void LoadData()
        {
            try
            {
                dgvStudents.AutoGenerateColumns = false;

                // feat<sinhvien>: SearchPaging
                /*
                // Lấy thông tin tìm kiếm và phân trang
                string keyword = txtSearch.Text.Trim().ToLower();
                int pageSize = 10;
                int currentPage = pagination.CurrentPage;

                // Base query: chỉ lấy sinh viên chưa bị xóa mềm
                var query = db.Students.Where(s => s.IsDelete == false).OrderByDescending(s => s.Id);

                // Áp dụng bộ lọc lớp học hoặc tìm kiếm
                if (filterClassId != null)
                {
                    query = query.Where(s => s.ClassId == filterClassId.Value);
                }
                else if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(s => s.StudentCode.ToLower().Contains(keyword) || 
                                             s.FullName.ToLower().Contains(keyword) || 
                                             (s.Classroom != null && s.Classroom.ClassCode.ToLower().Contains(keyword)));
                }

                // Cập nhật thông tin phân trang
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

                // Lấy dữ liệu phân trang và định dạng cho GridView
                var studentList = query.OrderByDescending(s => s.Id)
                                       .Skip((currentPage - 1) * pageSize).Take(pageSize)
                                       .Select(s => new
                                       {
                                           s.Id,
                                           s.StudentCode,
                                           s.FullName,
                                           s.BirthDate,
                                           s.Gender,
                                           s.Notes,
                                           ClassCode = s.Classroom != null ? s.Classroom.ClassCode : "Chưa xếp lớp"
                                       });
                */

                // Chỉ hiển thị danh sách sinh viên ban đầu
                var studentList = db.Students
                                     .Select(s => new
                                     {
                                         s.Id,
                                         s.StudentCode,
                                         s.FullName,
                                         s.BirthDate,
                                         s.Gender,
                                         s.Notes,
                                         ClassCode = s.Classroom != null ? s.Classroom.ClassCode : "Chưa xếp lớp"
                                     }).ToList();

                // Gán dữ liệu vào lưới
                dgvStudents.DataSource = studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message);
            }
        }

        // feat<sinhvien>: SearchPaging
        /*
        private void Pagination_PageChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        */

        // Hàm lấy danh sách lớp học đổ vào ComboBox cmbClass
        private void LoadClassroomsToComboBox()
        {
            try
            {
                // Lấy danh sách lớp học từ database
                var listClassrooms = db.Classrooms.ToList();

                // Gán nguồn dữ liệu cho ComboBox
                cmbClass.DataSource = listClassrooms;

                // Tên thuộc tính sẽ hiển thị cho người dùng nhìn thấy trên ComboBox
                cmbClass.DisplayMember = "ClassCode";

                // Giá trị thực tế (Mã ID của lớp) ẩn phía sau để ta lập trình lấy ra lưu vào DB
                cmbClass.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message);
            }
        }

        // Hàm xóa dữ liệu các ô input
        private void ClearInputs()
        {
            // Bổ sung xóa trắng ô mã ID hệ thống
            txtId.Clear();

            txtStudentCode.Clear();
            txtFullName.Clear();
            txtNotes.Clear();

            // Đưa DateTimePicker về ngày hiện tại
            dtpBirthDate.Value = DateTime.Now;

            // Reset ComboBox về lựa chọn đầu tiên
            if (cmbGender.Items.Count > 0) cmbGender.SelectedIndex = 0;
            if (cmbClass.Items.Count > 0) cmbClass.SelectedIndex = 0;

            // Đẩy con trỏ chuột về lại ô Mã sinh viên để người dùng nhập tiếp
            txtStudentCode.Enabled = true;
            txtStudentCode.Focus();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra ràng buộc dữ liệu đầu vào cơ bản (Validation)
                if (string.IsNullOrEmpty(txtStudentCode.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên!");
                    txtStudentCode.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập Họ tên sinh viên!");
                    txtFullName.Focus();
                    return;
                }

                // Khởi tạo một đối tượng Student mới từ thực thể LINQ
                Student newStudent = new Student();

                // Ánh xạ dữ liệu từ giao diện vào đối tượng
                newStudent.StudentCode = txtStudentCode.Text.Trim();
                newStudent.FullName = txtFullName.Text.Trim();
                newStudent.BirthDate = dtpBirthDate.Value; // Lấy giá trị ngày tháng
                newStudent.Gender = cmbGender.Text;        // Lấy chữ Nam/Nữ từ combobox giới tính
                newStudent.Notes = txtNotes.Text.Trim();

                // Lấy Id của lớp học đang chọn ngầm ở ValueMember
                if (cmbClass.SelectedValue != null)
                {
                    newStudent.ClassId = (int)cmbClass.SelectedValue;
                }

                // Đưa đối tượng vào hàng đợi chuẩn bị thêm của LINQ to SQL
                db.Students.InsertOnSubmit(newStudent);

                // Xác nhận cập nhật thay đổi xuống Database thực tế
                db.SubmitChanges();

                // Thông báo thành công và tải lại lưới dữ liệu để cập nhật danh sách mới
                MessageBox.Show("Thêm mới sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(); // Lấy lại dữ liệu mới cho dgv luôn

                ClearInputs(); // Xóa dữ liệu đang có ở mấy cái cục input
            }
            catch (Exception ex)
            {
                // Nếu có lỗi (Ví dụ: Trùng khóa chính Id/StudentCode, lỗi kết nối...)
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn sinh viên nào dưới lưới chưa (ô txtId phải có giá trị)
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ép kiểu Id từ chuỗi sang số nguyên
                int studentId = int.Parse(txtId.Text);

                // Tìm sinh viên trong database theo Id bằng LINQ
                Student editStudent = db.Students.SingleOrDefault(s => s.Id == studentId);

                if (editStudent != null)
                {
                    // Cập nhật các thông tin mới từ giao diện vào đối tượng
                    editStudent.StudentCode = txtStudentCode.Text.Trim();
                    editStudent.FullName = txtFullName.Text.Trim();
                    editStudent.BirthDate = dtpBirthDate.Value;
                    editStudent.Gender = cmbGender.Text;
                    editStudent.Notes = txtNotes.Text.Trim();

                    // Lấy Id của lớp học mới chọn trên ComboBox
                    if (cmbClass.SelectedValue != null)
                    {
                        editStudent.ClassId = (int)cmbClass.SelectedValue;
                    }

                    // Xác nhận lưu thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới lại danh sách hiển thị và xóa trắng ô nhập liệu
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn sinh viên chưa
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hỏi xác nhận người dùng trước khi xóa cho chắc chắn
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int studentId = int.Parse(txtId.Text);

                    // Tìm đối tượng cần xóa trong DB
                    Student deleteStudent = db.Students.SingleOrDefault(s => s.Id == studentId);

                    if (deleteStudent != null)
                    {
                        // Thay vì xóa cứng, đánh dấu IsDelete = true (Soft Delete)
                        deleteStudent.IsDelete = true;

                        // Đồng bộ xuống Database thực tế
                        db.SubmitChanges();

                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tải lại lưới dữ liệu và dọn dẹp form
                        LoadData();
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            /* feat<sinhvien>: SearchPaging is out of scope
            filterClassId = null;
            // Gọi lại hàm xóa trắng dữ liệu đã viết
            ClearInputs();

            // Tải lại lưới dữ liệu phòng trường hợp DB có thay đổi
            LoadData();
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /* feat<sinhvien>: SearchPaging is out of scope
            filterClassId = null;
            pagination.CurrentPage = 1; // Reset về trang 1 khi search
            LoadData();
            */
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            /* feat<sinhvien>: SearchPaging is out of scope
            txtSearch.Clear();
            filterClassId = null;
            pagination.CurrentPage = 1;
            LoadData();
            */
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                // Lấy dữ liệu theo số thứ tự cột từ trái sang phải (bắt đầu từ số 0)
                txtId.Text = row.Cells[0].Value?.ToString();
                txtStudentCode.Text = row.Cells[1].Value?.ToString();
                txtStudentCode.Enabled = false;
                txtFullName.Text = row.Cells[2].Value?.ToString();

                // Đổ dữ liệu cho Ngày sinh (Cột thứ 4 -> Vị trí số 3)
                if (row.Cells[3].Value != null)
                {
                    dtpBirthDate.Value = Convert.ToDateTime(row.Cells[3].Value);
                }

                // Đổ dữ liệu cho Giới tính (Cột thứ 5 -> Vị trí số 4)
                if (row.Cells[4].Value != null)
                {
                    cmbGender.Text = row.Cells[4].Value.ToString();
                }

                // Đổ dữ liệu cho Lớp học (Cột thứ 6 -> Vị trí số 5)
                if (row.Cells[5].Value != null)
                {
                    cmbClass.Text = row.Cells[5].Value.ToString();
                }

                // Đổ dữ liệu cho Ghi chú (Cột thứ 7 -> Vị trí số 6)
                txtNotes.Text = row.Cells[6].Value?.ToString();
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty content click handler
        }
    }
}
