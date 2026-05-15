using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QL_SinhVIen.Common;
using QL_SinhVIen.Models;

namespace QL_SinhVIen.Views
{
    public class StudentForm : Form
    {
        private MenuStrip menuStrip;
        private Panel pnlMain;
        private Panel pnlInput;
        private Panel pnlGrid;
        private Panel pnlSearch;
        private TableLayoutPanel tlpInputs;
        
        private Label lblTitle;
        private TextBox txtId;
        private TextBox txtStudentCode;
        private TextBox txtFullName;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbGender;
        private ComboBox cmbClass;
        private TextBox txtNotes;
        
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        
        private TextBox txtSearch;
        private Button btnSearch;
        
        private DataGridView dgvStudents;
        private PaginationControl pagination;

        public StudentForm()
        {
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Size = new Size(1250, 850);
            this.Font = StyleHelper.DefaultFont;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = StyleHelper.BackgroundColor;
            this.Padding = new Padding(15);
            
            InitializeComponents();
            
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void InitializeComponents()
        {
            menuStrip = new MenuStrip { BackColor = Color.White };
            var menuStudent = new ToolStripMenuItem("Quản lý Sinh Viên", null, (s, e) => { });
            var menuClass = new ToolStripMenuItem("Quản lý Lớp Học", null, (s, e) => {
                this.Hide();
                new ClassroomForm().Show();
            });
            var menuLogout = new ToolStripMenuItem("Đăng xuất", null, (s, e) => {
                this.Hide();
                new LoginForm().Show();
            });
            menuLogout.ForeColor = StyleHelper.DangerRed;
            menuStrip.Items.AddRange(new ToolStripItem[] { menuStudent, menuClass, menuLogout });
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            pnlMain = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 10, 0, 0) };
            this.Controls.Add(pnlMain);

            pnlInput = new Panel
            {
                Dock = DockStyle.Left,
                Width = StyleHelper.InputPanelWidth + 20,
                Padding = new Padding(20),
                BackColor = StyleHelper.PanelColor
            };

            lblTitle = new Label
            {
                Text = "THÔNG TIN SINH VIÊN",
                Font = StyleHelper.HeaderFont,
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = StyleHelper.PrimaryBlue
            };

            tlpInputs = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 1,
                AutoSize = true,
                Padding = new Padding(0, 10, 0, 0)
            };
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            txtId = CreateInputGroup(tlpInputs, "Mã ID (Hệ thống):", out _, true);
            txtStudentCode = CreateInputGroup(tlpInputs, "Mã sinh viên:", out _);
            txtFullName = CreateInputGroup(tlpInputs, "Họ và tên:", out _);
            
            Label lblBD = new Label { Text = "Ngày sinh:", Font = StyleHelper.LabelFont, AutoSize = true, Margin = new Padding(0, 5, 0, 2) };
            dtpBirthDate = new DateTimePicker { Dock = DockStyle.Fill, Format = DateTimePickerFormat.Short, Margin = new Padding(0, 0, 0, 15) };
            tlpInputs.Controls.Add(lblBD);
            tlpInputs.Controls.Add(dtpBirthDate);

            Label lblGender = new Label { Text = "Giới tính:", Font = StyleHelper.LabelFont, AutoSize = true, Margin = new Padding(0, 5, 0, 2) };
            cmbGender = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, Margin = new Padding(0, 0, 0, 15) };
            cmbGender.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            tlpInputs.Controls.Add(lblGender);
            tlpInputs.Controls.Add(cmbGender);

            Label lblClass = new Label { Text = "Lớp học:", Font = StyleHelper.LabelFont, AutoSize = true, Margin = new Padding(0, 5, 0, 2) };
            cmbClass = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, Margin = new Padding(0, 0, 0, 15) };
            tlpInputs.Controls.Add(lblClass);
            tlpInputs.Controls.Add(cmbClass);

            txtNotes = CreateInputGroup(tlpInputs, "Ghi chú:", out _);
            txtNotes.Multiline = true;
            txtNotes.Height = 80;

            FlowLayoutPanel pnlButtons = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 150,
                Padding = new Padding(0, 20, 0, 0),
                BackColor = Color.Transparent
            };

            btnAdd = CreateActionButton("Thêm mới", StyleHelper.PrimaryBlue, StyleHelper.PrimaryBlueHover);
            btnEdit = CreateActionButton("Cập nhật", StyleHelper.SuccessGreen, StyleHelper.SuccessGreenHover);
            btnDelete = CreateActionButton("Xóa bỏ", StyleHelper.DangerRed, StyleHelper.DangerRedHover);
            btnRefresh = CreateActionButton("Làm mới", StyleHelper.SecondaryGrey, StyleHelper.SecondaryGreyHover);

            pnlButtons.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete, btnRefresh });

            pnlInput.Controls.Add(pnlButtons);
            pnlInput.Controls.Add(tlpInputs);
            pnlInput.Controls.Add(lblTitle);

            pnlGrid = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20, 0, 0, 0), BackColor = Color.Transparent };
            
            Panel pnlGridContainer = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Padding = new Padding(1) };
            pnlGrid.Controls.Add(pnlGridContainer);

            pnlSearch = new Panel { Dock = DockStyle.Top, Height = 80, BackColor = Color.Transparent };
            Label lblSearch = new Label { Text = "Tìm kiếm sinh viên:", Font = StyleHelper.LabelFont, AutoSize = true, Location = new Point(0, 10) };
            txtSearch = new TextBox { Location = new Point(0, 35), Width = 400, Height = 30 };
            btnSearch = CreateActionButton("Tìm kiếm", StyleHelper.SearchDark, StyleHelper.SearchDarkHover);
            btnSearch.Location = new Point(410, 33);
            btnSearch.Size = new Size(100, 32);
            pnlSearch.Controls.AddRange(new Control[] { lblSearch, txtSearch, btnSearch });

            dgvStudents = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                ColumnHeadersHeight = 45,
                EnableHeadersVisualStyles = false,
                RowTemplate = { Height = 40 },
                CellBorderStyle = DataGridViewCellBorderStyle.None,
                GridColor = StyleHelper.BorderColor
            };
            
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = StyleHelper.PrimaryBlue;
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = StyleHelper.ButtonFont;
            dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvStudents.DefaultCellStyle.SelectionBackColor = StyleHelper.SelectionColor;
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = StyleHelper.ZebraColor;
            
            SetupGridColumns();

            pagination = new PaginationControl();

            pnlGridContainer.Controls.Add(dgvStudents);
            pnlGridContainer.Controls.Add(pnlSearch);
            pnlGridContainer.Controls.Add(pagination);

            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(pnlInput);
        }

        private TextBox CreateInputGroup(TableLayoutPanel panel, string labelText, out Label label, bool isReadOnly = false)
        {
            label = new Label
            {
                Text = labelText,
                Font = StyleHelper.LabelFont,
                AutoSize = true,
                Margin = new Padding(0, 5, 0, 2),
                TextAlign = ContentAlignment.BottomLeft
            };
            TextBox textBox = new TextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = isReadOnly,
                BackColor = isReadOnly ? Color.FromArgb(245, 245, 245) : Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 15)
            };
            panel.Controls.Add(label);
            panel.Controls.Add(textBox);
            return textBox;
        }

        private Button CreateActionButton(string text, Color backColor, Color hoverColor)
        {
            Button btn = new Button
            {
                Text = text,
                Width = (StyleHelper.InputPanelWidth - 25) / 2,
                Height = 40,
                BackColor = backColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = StyleHelper.ButtonFont,
                Margin = new Padding(3),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = backColor;
            
            btn.Click += (s, e) => { /* Chưa đủ sức làm */ };
            
            return btn;
        }

        private void SetupGridColumns()
        {
            dgvStudents.Columns.Clear();
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentCode", HeaderText = "MÃ SV" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "HỌ VÀ TÊN" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BirthDate", HeaderText = "NGÀY SINH" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "GIỚI TÍNH" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClassId", HeaderText = "MÃ LỚP" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Notes", HeaderText = "GHI CHÚ" });
        }
    }
}
