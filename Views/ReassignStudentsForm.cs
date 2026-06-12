using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_SinhVIen.Views
{
    public partial class ReassignStudentsForm : Form
    {
        private int deletingClassroomId;
        private QLSinhVienDataContext db = new QLSinhVienDataContext();
        private List<ReassignStudentViewModel> viewModels;

        public class ReassignStudentViewModel
        {
            public int StudentId { get; set; }
            public string StudentCode { get; set; }
            public string FullName { get; set; }
            public int ClassId { get; set; }
        }

        public ReassignStudentsForm(int deletingClassroomId, string deletingClassCode)
        {
            this.deletingClassroomId = deletingClassroomId;
            InitializeComponent();
            lblTitle.Text = $"CHUYỂN LỚP CHO SINH VIÊN - LỚP CŨ: {deletingClassCode.ToUpper()}";
            LoadDataAndSetup();
        }

        private void LoadDataAndSetup()
        {
            try
            {
                var availableClasses = db.Classrooms
                                         .Where(c => c.Id != deletingClassroomId && c.IsDelete == false)
                                         .ToList();

                if (availableClasses.Count == 0)
                {
                    MessageBox.Show("Không còn lớp học nào khác trong hệ thống để chuyển sinh viên sang!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }

                var students = db.Students
                                 .Where(s => s.ClassId == deletingClassroomId && s.IsDelete == false)
                                 .ToList();

                int defaultClassId = availableClasses.First().Id;
                viewModels = students.Select(s => new ReassignStudentViewModel
                {
                    StudentId = s.Id,
                    StudentCode = s.StudentCode,
                    FullName = s.FullName,
                    ClassId = defaultClassId
                }).ToList();

                colNewClass.DataSource = availableClasses;
                colNewClass.DisplayMember = "ClassCode";
                colNewClass.ValueMember = "Id";
                colNewClass.DataPropertyName = "ClassId";

                dgvStudents.AutoGenerateColumns = false;
                dgvStudents.DataSource = viewModels;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu chuyển lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStudents.EndEdit();

                foreach (var vm in viewModels)
                {
                    var student = db.Students.SingleOrDefault(s => s.Id == vm.StudentId);
                    if (student != null)
                    {
                        student.ClassId = vm.ClassId;
                    }
                }

                var cls = db.Classrooms.SingleOrDefault(c => c.Id == deletingClassroomId);
                if (cls != null)
                {
                    cls.IsDelete = true;
                }

                db.SubmitChanges();
                MessageBox.Show("Chuyển lớp cho sinh viên và xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thay đổi chuyển lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
