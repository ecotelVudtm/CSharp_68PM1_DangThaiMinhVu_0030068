namespace QL_SinhVIen.Views
{
    partial class UCQLSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pagination = new QL_SinhVIen.Common.PaginationControl();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblStudentCode = new System.Windows.Forms.Label();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.tlpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlGrid);
            this.pnlMain.Controls.Add(this.pnlInput);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(15, 15);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlMain.Size = new System.Drawing.Size(1200, 770);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrid.Controls.Add(this.pnlGridContainer);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(370, 10);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlGrid.Size = new System.Drawing.Size(830, 760);
            this.pnlGrid.TabIndex = 1;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackColor = System.Drawing.Color.White;
            this.pnlGridContainer.Controls.Add(this.dgvStudents);
            this.pnlGridContainer.Controls.Add(this.pnlSearch);
            this.pnlGridContainer.Controls.Add(this.pagination);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(20, 0);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridContainer.Size = new System.Drawing.Size(810, 760);
            this.pnlGridContainer.TabIndex = 0;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = QL_SinhVIen.Common.StyleHelper.ZebraColor;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = QL_SinhVIen.Common.StyleHelper.PrimaryBlue;
            dataGridViewCellStyle1.Font = QL_SinhVIen.Common.StyleHelper.ButtonFont;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = QL_SinhVIen.Common.StyleHelper.PrimaryBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeight = 45;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colStudentCode,
            this.colFullName,
            this.colBirthDate,
            this.colGender,
            this.colClassId,
            this.colNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = QL_SinhVIen.Common.StyleHelper.DefaultFont;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = QL_SinhVIen.Common.StyleHelper.SelectionColor;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = QL_SinhVIen.Common.StyleHelper.BorderColor;
            this.dgvStudents.Location = new System.Drawing.Point(1, 81);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 40;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(808, 628);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colStudentCode
            // 
            this.colStudentCode.DataPropertyName = "StudentCode";
            this.colStudentCode.HeaderText = "MÃ SV";
            this.colStudentCode.Name = "colStudentCode";
            this.colStudentCode.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "HỌ VÀ TÊN";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colBirthDate
            // 
            this.colBirthDate.DataPropertyName = "BirthDate";
            this.colBirthDate.HeaderText = "NGÀY SINH";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "GIỚI TÍNH";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colClassId
            // 
            this.colClassId.DataPropertyName = "ClassId";
            this.colClassId.HeaderText = "MÃ LỚP";
            this.colClassId.Name = "colClassId";
            this.colClassId.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.DataPropertyName = "Notes";
            this.colNotes.HeaderText = "GHI CHÚ";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(1, 1);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(808, 80);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblSearch.Location = new System.Drawing.Point(0, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(158, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm sinh viên:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = QL_SinhVIen.Common.StyleHelper.SearchDark;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = QL_SinhVIen.Common.StyleHelper.ButtonFont;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(410, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // pagination
            // 
            this.pagination.CurrentPage = 1;
            this.pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagination.Location = new System.Drawing.Point(1, 709);
            this.pagination.Name = "pagination";
            this.pagination.Size = new System.Drawing.Size(808, 50);
            this.pagination.TabIndex = 2;
            this.pagination.TotalPages = 1;
            this.pagination.TotalRecords = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = QL_SinhVIen.Common.StyleHelper.PanelColor;
            this.pnlInput.Controls.Add(this.pnlButtons);
            this.pnlInput.Controls.Add(this.tlpInputs);
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 10);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInput.Size = new System.Drawing.Size(370, 760);
            this.pnlInput.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(20, 580);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlButtons.Size = new System.Drawing.Size(330, 150);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = QL_SinhVIen.Common.StyleHelper.PrimaryBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = QL_SinhVIen.Common.StyleHelper.ButtonFont;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = QL_SinhVIen.Common.StyleHelper.SuccessGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = QL_SinhVIen.Common.StyleHelper.ButtonFont;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(164, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = QL_SinhVIen.Common.StyleHelper.DangerRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = QL_SinhVIen.Common.StyleHelper.ButtonFont;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(3, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa bỏ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = QL_SinhVIen.Common.StyleHelper.SecondaryGrey;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = QL_SinhVIen.Common.StyleHelper.ButtonFont;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(164, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnRefresh_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            // 
            // tlpInputs
            // 
            this.tlpInputs.AutoSize = true;
            this.tlpInputs.ColumnCount = 1;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblId, 0, 0);
            this.tlpInputs.Controls.Add(this.txtId, 0, 1);
            this.tlpInputs.Controls.Add(this.lblStudentCode, 0, 2);
            this.tlpInputs.Controls.Add(this.txtStudentCode, 0, 3);
            this.tlpInputs.Controls.Add(this.lblFullName, 0, 4);
            this.tlpInputs.Controls.Add(this.txtFullName, 0, 5);
            this.tlpInputs.Controls.Add(this.lblBirthDate, 0, 6);
            this.tlpInputs.Controls.Add(this.dtpBirthDate, 0, 7);
            this.tlpInputs.Controls.Add(this.lblGender, 0, 8);
            this.tlpInputs.Controls.Add(this.cmbGender, 0, 9);
            this.tlpInputs.Controls.Add(this.lblClass, 0, 10);
            this.tlpInputs.Controls.Add(this.cmbClass, 0, 11);
            this.tlpInputs.Controls.Add(this.lblNotes, 0, 12);
            this.tlpInputs.Controls.Add(this.txtNotes, 0, 13);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInputs.Location = new System.Drawing.Point(20, 60);
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlpInputs.RowCount = 14;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.Size = new System.Drawing.Size(330, 520);
            this.tlpInputs.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblId.Location = new System.Drawing.Point(3, 10);
            this.lblId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(155, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã ID (Hệ thống):";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(3, 38);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(324, 30);
            this.txtId.TabIndex = 1;
            // 
            // lblStudentCode
            // 
            this.lblStudentCode.AutoSize = true;
            this.lblStudentCode.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblStudentCode.Location = new System.Drawing.Point(3, 81);
            this.lblStudentCode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblStudentCode.Name = "lblStudentCode";
            this.lblStudentCode.Size = new System.Drawing.Size(113, 23);
            this.lblStudentCode.TabIndex = 2;
            this.lblStudentCode.Text = "Mã sinh viên:";
            this.lblStudentCode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.BackColor = System.Drawing.Color.White;
            this.txtStudentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentCode.Location = new System.Drawing.Point(3, 109);
            this.txtStudentCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(324, 30);
            this.txtStudentCode.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblFullName.Location = new System.Drawing.Point(3, 152);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 23);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Họ và tên:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Location = new System.Drawing.Point(3, 180);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(324, 30);
            this.txtFullName.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblBirthDate.Location = new System.Drawing.Point(3, 223);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(91, 23);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Ngày sinh:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(3, 251);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(324, 30);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblGender.Location = new System.Drawing.Point(3, 294);
            this.lblGender.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(82, 23);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Giới tính:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cmbGender.Location = new System.Drawing.Point(3, 322);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(324, 31);
            this.cmbGender.TabIndex = 9;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblClass.Location = new System.Drawing.Point(3, 366);
            this.lblClass.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(76, 23);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "Lớp học:";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(3, 394);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(324, 31);
            this.cmbClass.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = QL_SinhVIen.Common.StyleHelper.LabelFont;
            this.lblNotes.Location = new System.Drawing.Point(3, 438);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(74, 23);
            this.lblNotes.TabIndex = 12;
            this.lblNotes.Text = "Ghi chú:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 466);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(324, 80);
            this.txtNotes.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = QL_SinhVIen.Common.StyleHelper.HeaderFont;
            this.lblTitle.ForeColor = QL_SinhVIen.Common.StyleHelper.PrimaryBlue;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN SINH VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCQLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UCQLSinhVien";
            this.Size = new System.Drawing.Size(1230, 800);
            this.pnlMain.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.tlpInputs.ResumeLayout(false);
            this.tlpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStudentCode;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private QL_SinhVIen.Common.PaginationControl pagination;
    }
}
