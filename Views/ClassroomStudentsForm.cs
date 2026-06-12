using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_SinhVIen.Views
{
    public partial class ClassroomStudentsForm : Form
    {
        private int classroomId;
        private QLSinhVienDataContext db = new QLSinhVienDataContext();

        public ClassroomStudentsForm(int classroomId)
        {
            this.classroomId = classroomId;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var cls = db.Classrooms.SingleOrDefault(c => c.Id == classroomId);
                if (cls != null)
                {
                    lblTitle.Text = $"DANH SÁCH SINH VIÊN - LỚP {cls.ClassCode.ToUpper()} ({cls.ClassName})";
                }

                dgvStudents.AutoGenerateColumns = false;

                if (dgvStudents.Columns["colBirthDate"] != null)
                {
                    dgvStudents.Columns["colBirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                var studentList = db.Students
                                    .Where(s => s.ClassId == classroomId && s.IsDelete == false)
                                    .OrderByDescending(s => s.Id)
                                    .Select(s => new
                                    {
                                        s.Id,
                                        s.StudentCode,
                                        s.FullName,
                                        s.BirthDate,
                                        s.Gender,
                                        s.Notes
                                    })
                                    .ToList();

                dgvStudents.DataSource = studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
