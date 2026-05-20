namespace QL_SinhVIen.Views
{
    partial class UCQLLH
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.dgvClassrooms = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblClassCode = new System.Windows.Forms.Label();
            this.txtClassCode = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassrooms)).BeginInit();
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
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1230, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrid.Controls.Add(this.pnlGridContainer);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(370, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(860, 800);
            this.pnlGrid.TabIndex = 1;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackColor = System.Drawing.Color.White;
            this.pnlGridContainer.Controls.Add(this.dgvClassrooms);
            this.pnlGridContainer.Controls.Add(this.pnlSearch);
            this.pnlGridContainer.Controls.Add(this.pagination);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(860, 800);
            this.pnlGridContainer.TabIndex = 0;
            // 
            // dgvClassrooms
            // 
            this.dgvClassrooms.AllowUserToAddRows = false;
            this.dgvClassrooms.AllowUserToDeleteRows = false;
            this.dgvClassrooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassrooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvClassrooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClassrooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClassrooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassrooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClassrooms.ColumnHeadersHeight = 45;
            this.dgvClassrooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colClassCode,
            this.colClassName,
            this.colNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassrooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClassrooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassrooms.EnableHeadersVisualStyles = false;
            this.dgvClassrooms.Location = new System.Drawing.Point(0, 80);
            this.dgvClassrooms.Name = "dgvClassrooms";
            this.dgvClassrooms.ReadOnly = true;
            this.dgvClassrooms.RowHeadersVisible = false;
            this.dgvClassrooms.RowHeadersWidth = 51;
            this.dgvClassrooms.RowTemplate.Height = 40;
            this.dgvClassrooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassrooms.Size = new System.Drawing.Size(860, 670);
            this.dgvClassrooms.TabIndex = 1;
            this.dgvClassrooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassrooms_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Mã ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colClassCode
            // 
            this.colClassCode.DataPropertyName = "ClassCode";
            this.colClassCode.HeaderText = "Mã lớp";
            this.colClassCode.MinimumWidth = 6;
            this.colClassCode.Name = "colClassCode";
            this.colClassCode.ReadOnly = true;
            // 
            // colClassName
            // 
            this.colClassName.DataPropertyName = "ClassName";
            this.colClassName.HeaderText = "Tên lớp";
            this.colClassName.MinimumWidth = 6;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.DataPropertyName = "Notes";
            this.colNotes.HeaderText = "Ghi chú";
            this.colNotes.MinimumWidth = 6;
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
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(860, 80);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(0, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(193, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(410, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // pagination
            // 
            this.pagination.CurrentPage = 1;
            this.pagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagination.Location = new System.Drawing.Point(0, 750);
            this.pagination.Name = "pagination";
            this.pagination.Size = new System.Drawing.Size(860, 50);
            this.pagination.TabIndex = 2;
            this.pagination.TotalPages = 1;
            this.pagination.TotalRecords = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.pnlButtons);
            this.pnlInput.Controls.Add(this.tlpInputs);
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(370, 800);
            this.pnlInput.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnViewStudents);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 300);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(370, 200);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(164, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(3, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(164, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnRefresh_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStudents.FlatAppearance.BorderSize = 0;
            this.btnViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudents.ForeColor = System.Drawing.Color.White;
            this.btnViewStudents.Location = new System.Drawing.Point(3, 95);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(316, 40);
            this.btnViewStudents.TabIndex = 4;
            this.btnViewStudents.Text = "Xem danh sách sinh viên";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            this.btnViewStudents.MouseEnter += new System.EventHandler(this.btnViewStudents_MouseEnter);
            this.btnViewStudents.MouseLeave += new System.EventHandler(this.btnViewStudents_MouseLeave);
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 1;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblId, 0, 0);
            this.tlpInputs.Controls.Add(this.txtId, 0, 1);
            this.tlpInputs.Controls.Add(this.lblClassCode, 0, 2);
            this.tlpInputs.Controls.Add(this.txtClassCode, 0, 3);
            this.tlpInputs.Controls.Add(this.lblClassName, 0, 4);
            this.tlpInputs.Controls.Add(this.txtClassName, 0, 5);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInputs.Location = new System.Drawing.Point(0, 40);
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 6;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInputs.Size = new System.Drawing.Size(370, 260);
            this.tlpInputs.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(48, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(3, 21);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(364, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblClassCode
            // 
            this.lblClassCode.AutoSize = true;
            this.lblClassCode.Location = new System.Drawing.Point(3, 58);
            this.lblClassCode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblClassCode.Name = "lblClassCode";
            this.lblClassCode.Size = new System.Drawing.Size(51, 16);
            this.lblClassCode.TabIndex = 2;
            this.lblClassCode.Text = "Mã lớp:";
            this.lblClassCode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtClassCode
            // 
            this.txtClassCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClassCode.Location = new System.Drawing.Point(3, 79);
            this.txtClassCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtClassCode.Name = "txtClassCode";
            this.txtClassCode.Size = new System.Drawing.Size(364, 22);
            this.txtClassCode.TabIndex = 3;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(3, 116);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(56, 16);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Tên lớp:";
            this.lblClassName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtClassName
            // 
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClassName.Location = new System.Drawing.Point(3, 137);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(364, 22);
            this.txtClassName.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin lớp học";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UCQLLH";
            this.Size = new System.Drawing.Size(1230, 800);
            this.pnlMain.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassrooms)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlInput.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblClassCode;
        private System.Windows.Forms.TextBox txtClassCode;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvClassrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private QL_SinhVIen.Common.PaginationControl pagination;
    }
}
