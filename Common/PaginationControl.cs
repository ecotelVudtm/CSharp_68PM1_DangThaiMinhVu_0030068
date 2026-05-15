using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_SinhVIen.Common
{
    public class PaginationControl : UserControl
    {
        private Button btnFirst;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private Label lblPageInfo;

        public event EventHandler PageChanged;

        private int _currentPage = 1;
        private int _totalPages = 1;
        private int _totalRecords = 0;

        public int CurrentPage
        {
            get => _currentPage;
            set { _currentPage = value; UpdateInfo(); }
        }

        public int TotalPages
        {
            get => _totalPages;
            set { _totalPages = value; UpdateInfo(); }
        }

        public int TotalRecords
        {
            get => _totalRecords;
            set { _totalRecords = value; UpdateInfo(); }
        }

        public PaginationControl()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Height = 50;
            this.Dock = DockStyle.Bottom;

            btnFirst = CreateButton("<<");
            btnPrev = CreateButton("<");
            btnNext = CreateButton(">");
            btnLast = CreateButton(">>");

            lblPageInfo = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 200,
                Dock = DockStyle.Fill,
                Font = StyleHelper.DefaultFont,
                Text = "Trang 1/1 | 0 bản ghi"
            };

            Panel leftPanel = new Panel { Dock = DockStyle.Left, Width = 100 };
            leftPanel.Controls.Add(btnPrev);
            leftPanel.Controls.Add(btnFirst);
            btnFirst.Dock = DockStyle.Left;
            btnPrev.Dock = DockStyle.Right;

            Panel rightPanel = new Panel { Dock = DockStyle.Right, Width = 100 };
            rightPanel.Controls.Add(btnNext);
            rightPanel.Controls.Add(btnLast);
            btnLast.Dock = DockStyle.Right;
            btnNext.Dock = DockStyle.Left;

            this.Controls.Add(lblPageInfo);
            this.Controls.Add(leftPanel);
            this.Controls.Add(rightPanel);

            btnFirst.Click += (s, e) => { CurrentPage = 1; PageChanged?.Invoke(this, EventArgs.Empty); };
            btnPrev.Click += (s, e) => { if (CurrentPage > 1) { CurrentPage--; PageChanged?.Invoke(this, EventArgs.Empty); } };
            btnNext.Click += (s, e) => { if (CurrentPage < TotalPages) { CurrentPage++; PageChanged?.Invoke(this, EventArgs.Empty); } };
            btnLast.Click += (s, e) => { CurrentPage = TotalPages; PageChanged?.Invoke(this, EventArgs.Empty); };
        }

        private Button CreateButton(string text)
        {
            return new Button
            {
                Text = text,
                Width = 45,
                FlatStyle = FlatStyle.Flat,
                Font = StyleHelper.ButtonFont,
                BackColor = Color.White
            };
        }

        private void UpdateInfo()
        {
            lblPageInfo.Text = $"Trang {CurrentPage}/{TotalPages} | {TotalRecords} bản ghi";
        }
    }
}
