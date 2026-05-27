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
        public UCQLSinhVien()
        {
            InitializeComponent();
            
            this.Font = StyleHelper.DefaultFont;
            this.BackColor = StyleHelper.BackgroundColor;
            this.Padding = new Padding(15);

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
                // 1. NGHIÊM CẤM lưới tự chế thêm cột mới, chỉ dùng những cột em đã tạo lúc Design
                dgvStudents.AutoGenerateColumns = false;

                // 2. Lấy dữ liệu từ DB ra
                var studentList = from s in db.Students
                                  select new
                                  {
                                      s.Id,
                                      s.StudentCode,
                                      s.FullName,
                                      s.BirthDate,
                                      s.Gender,
                                      s.Notes,
                                      ClassCode = s.Classroom != null ? s.Classroom.ClassCode : "Chưa xếp lớp"
                                  };

                // 3. Gán dữ liệu vào lưới
                dgvStudents.DataSource = studentList.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message);
            }
        }

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
            txtStudentCode.Focus();
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

                // 2. Khởi tạo một đối tượng Student mới từ thực thể LINQ
                Student newStudent = new Student();

                // 3. Ánh xạ dữ liệu từ giao diện vào đối tượng
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

                // 4. Đưa đối tượng vào hàng đợi chuẩn bị thêm của LINQ to SQL
                db.Students.InsertOnSubmit(newStudent);

                // 5. Xác nhận cập nhật thay đổi xuống Database thực tế
                db.SubmitChanges();

                // 6. Thông báo thành công và tải lại lưới dữ liệu để cập nhật danh sách mới
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
                // 1. Kiểm tra xem người dùng đã chọn sinh viên nào dưới lưới chưa (ô txtId phải có giá trị)
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Ép kiểu Id từ chuỗi sang số nguyên
                int studentId = int.Parse(txtId.Text);

                // 3. Tìm sinh viên trong database theo Id bằng LINQ
                Student editStudent = db.Students.SingleOrDefault(s => s.Id == studentId);

                if (editStudent != null)
                {
                    // 4. Cập nhật các thông tin mới từ giao diện vào đối tượng
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

                    // 5. Xác nhận lưu thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 6. Làm mới lại danh sách hiển thị và xóa trắng ô nhập liệu
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
                // 1. Kiểm tra xem đã chọn sinh viên chưa
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Hỏi xác nhận người dùng trước khi xóa cho chắc chắn
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int studentId = int.Parse(txtId.Text);

                    // 3. Tìm đối tượng cần xóa trong DB
                    Student deleteStudent = db.Students.SingleOrDefault(s => s.Id == studentId);

                    if (deleteStudent != null)
                    {
                        // 4. Xóa đối tượng khỏi hàng đợi của LINQ
                        db.Students.DeleteOnSubmit(deleteStudent);

                        // 5. Đồng bộ xuống Database thực tế
                        db.SubmitChanges();

                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 6. Tải lại lưới dữ liệu và dọn dẹp form
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
            // Gọi lại hàm xóa trắng dữ liệu đã viết
            ClearInputs();

            // Tải lại lưới dữ liệu phòng trường hợp DB có thay đổi
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Empty click handler
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty click handler
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                // Lấy dữ liệu theo số thứ tự cột từ trái sang phải (bắt đầu từ số 0)
                txtId.Text = row.Cells[0].Value?.ToString();          // Cột ID đầu tiên
                txtStudentCode.Text = row.Cells[1].Value?.ToString(); // Cột MÃ SV
                txtFullName.Text = row.Cells[2].Value?.ToString();    // Cột HỌ VÀ TÊN

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
    }
}
