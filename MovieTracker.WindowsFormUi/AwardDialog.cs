using System.Drawing.Drawing2D;
using MovieTracker.Logic.Data.Repositories;

namespace MovieTracker.WindowsFormUi
{
    public partial class AwardDialog : Form
    {
        private readonly Color _buttonBlueColor = Color.FromArgb(0, 120, 212);
        private readonly Color _buttonHoverColor = Color.FromArgb(0, 90, 158);
        private readonly Color _buttonRedColor = Color.FromArgb(232, 17, 35);
        private readonly Color _buttonRedHoverColor = Color.FromArgb(194, 14, 29);

        private readonly AwardRepository? _awardRepository;

        public string AwardName { get; private set; } = string.Empty;
        public string AwardCategory { get; private set; } = string.Empty;
        public int AwardYear { get; private set; }
        public bool Won { get; private set; }

        public AwardDialog(int? defaultYear = null, AwardRepository? awardRepository = null)
        {
            InitializeComponent();
            _awardRepository = awardRepository;

            // Enable double buffering for smooth rendering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Configure button styles
            ConfigureButtonStyles();

            // Set default year if provided
            if (defaultYear.HasValue)
            {
                numYear.Value = defaultYear.Value;
            }

            Load += AwardDialog_Load;
        }

        private void AwardDialog_Load(object? sender, EventArgs e)
        {
            LoadAwardNames();
        }

        private void LoadAwardNames()
        {
            if (_awardRepository == null) return;

            cboAwardName.Items.Clear();
            var names = _awardRepository.GetDistinctAwardNames();
            foreach (var name in names)
            {
                cboAwardName.Items.Add(name);
            }
            if (cboAwardName.Items.Count > 0)
            {
                cboAwardName.SelectedIndex = 0;
            }
        }

        private void cboAwardName_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadCategoriesForSelectedAward();
        }

        private void LoadCategoriesForSelectedAward()
        {
            cboCategory.Items.Clear();
            if (_awardRepository == null) return;

            var selectedName = cboAwardName.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedName)) return;

            var categories = _awardRepository.GetCategoriesByAwardName(selectedName);
            foreach (var category in categories)
            {
                cboCategory.Items.Add(category);
            }
            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        private void ConfigureButtonStyles()
        {
            // OK button
            btnOK.BackColor = _buttonBlueColor;
            btnOK.ForeColor = Color.White;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Cursor = Cursors.Hand;
            btnOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOK.MouseEnter += OKButton_MouseEnter;
            btnOK.MouseLeave += OKButton_MouseLeave;

            // Cancel button
            btnCancel.BackColor = _buttonRedColor;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btnCancel.MouseEnter += CancelButton_MouseEnter;
            btnCancel.MouseLeave += CancelButton_MouseLeave;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Resolve award name: use "add new" text if provided, otherwise selected dropdown value
            var awardName = txtNewAwardName.Text.Trim();
            if (string.IsNullOrWhiteSpace(awardName))
            {
                awardName = cboAwardName.SelectedItem?.ToString()?.Trim() ?? string.Empty;
            }

            // Resolve category: use "add new" text if provided, otherwise selected dropdown value
            var category = txtNewCategory.Text.Trim();
            if (string.IsNullOrWhiteSpace(category))
            {
                category = cboCategory.SelectedItem?.ToString()?.Trim() ?? string.Empty;
            }

            if (string.IsNullOrWhiteSpace(awardName))
            {
                MessageBox.Show("Please select or enter an award name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboAwardName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please select or enter a category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategory.Focus();
                return;
            }

            // Set properties (these will be added to the movie when the form is saved)
            AwardName = awardName;
            AwardCategory = category;
            AwardYear = (int)numYear.Value;
            Won = chkWon.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Button hover effects
        private void OKButton_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = _buttonHoverColor;
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = _buttonBlueColor;
        }

        private void CancelButton_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = _buttonRedHoverColor;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = _buttonRedColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Apply smooth rendering
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        }
    }
}