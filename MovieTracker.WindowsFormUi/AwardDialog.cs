using System.Drawing.Drawing2D;

namespace MovieTracker.WindowsFormUi
{
    public partial class AwardDialog : Form
    {
        private readonly Color _buttonBlueColor = Color.FromArgb(0, 120, 212);
        private readonly Color _buttonHoverColor = Color.FromArgb(0, 90, 158);
        private readonly Color _buttonRedColor = Color.FromArgb(232, 17, 35);
        private readonly Color _buttonRedHoverColor = Color.FromArgb(194, 14, 29);

        public string AwardName { get; private set; } = string.Empty;
        public string AwardCategory { get; private set; } = string.Empty;
        public int AwardYear { get; private set; }
        public bool Won { get; private set; }

        public AwardDialog(int? defaultYear = null)
        {
            InitializeComponent();

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
            // Validate
            if (string.IsNullOrWhiteSpace(txtAwardName.Text))
            {
                MessageBox.Show("Please enter an award name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAwardName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Please enter a category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return;
            }

            // Set properties
            AwardName = txtAwardName.Text.Trim();
            AwardCategory = txtCategory.Text.Trim();
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