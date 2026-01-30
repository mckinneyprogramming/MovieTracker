using MovieTracker.Logic.Data;
using MovieTracker.Logic.Models;
using System.Drawing.Drawing2D;

namespace MovieTracker.WindowsFormUi
{
    public partial class AddMovieForm : Form
    {
        private readonly Color _buttonHoverColor = Color.FromArgb(0, 90, 158);
        private readonly Color _buttonBlueColor = Color.FromArgb(0, 120, 212);
        private readonly Color _buttonGreenColor = Color.FromArgb(16, 137, 62);
        private readonly Color _buttonGreenHoverColor = Color.FromArgb(12, 107, 48);
        private readonly Color _buttonRedColor = Color.FromArgb(232, 17, 35);
        private readonly Color _buttonRedHoverColor = Color.FromArgb(194, 14, 29);
        private readonly Color _headerGradientStart = Color.FromArgb(0, 120, 212);
        private readonly Color _headerGradientEnd = Color.FromArgb(0, 90, 180);

        private MovieTrackerUnitOfWork? _unitOfWork;
        private static string DatabasePath => DatabasePathHelper.GetDatabasePath();

        public AddMovieForm()
        {
            InitializeComponent();

            // Enable double buffering for smooth rendering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Configure button styles
            ConfigureButtonStyles();

            // Style group boxes
            StyleGroupBoxes();

            // Style DataGridView
            StyleDataGridView();
        }

        private void ConfigureButtonStyles()
        {
            // Save button
            btnSave.BackColor = _buttonGreenColor;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Cursor = Cursors.Hand;
            btnSave.MouseEnter += SaveButton_MouseEnter;
            btnSave.MouseLeave += SaveButton_MouseLeave;

            // Cancel button
            btnCancel.BackColor = _buttonRedColor;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.MouseEnter += CancelButton_MouseEnter;
            btnCancel.MouseLeave += CancelButton_MouseLeave;

            // Add Award button
            btnAddAward.BackColor = _buttonBlueColor;
            btnAddAward.ForeColor = Color.White;
            btnAddAward.FlatStyle = FlatStyle.Flat;
            btnAddAward.FlatAppearance.BorderSize = 0;
            btnAddAward.Cursor = Cursors.Hand;
            btnAddAward.MouseEnter += AddAwardButton_MouseEnter;
            btnAddAward.MouseLeave += AddAwardButton_MouseLeave;

            // Remove Award button
            btnRemoveAward.BackColor = _buttonRedColor;
            btnRemoveAward.ForeColor = Color.White;
            btnRemoveAward.FlatStyle = FlatStyle.Flat;
            btnRemoveAward.FlatAppearance.BorderSize = 0;
            btnRemoveAward.Cursor = Cursors.Hand;
            btnRemoveAward.MouseEnter += RemoveAwardButton_MouseEnter;
            btnRemoveAward.MouseLeave += RemoveAwardButton_MouseLeave;
        }

        private void StyleGroupBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    groupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
                    groupBox.ForeColor = Color.FromArgb(0, 120, 212);
                }
            }
        }

        private void StyleDataGridView()
        {
            dgvAwards.BorderStyle = BorderStyle.None;
            dgvAwards.BackgroundColor = Color.White;
            dgvAwards.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAwards.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 212);
            dgvAwards.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAwards.EnableHeadersVisualStyles = false;
            dgvAwards.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 212);
            dgvAwards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAwards.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvAwards.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvAwards.RowTemplate.Height = 35;
            dgvAwards.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ensure database directory exists
            var directory = Path.GetDirectoryName(DatabasePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Initialize database
            _unitOfWork = new MovieTrackerUnitOfWork(DatabasePath);
            _unitOfWork.InitializeDatabase();
        }

        private void chkIsWatched_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable watched-related controls
            bool isWatched = chkIsWatched.Checked;
            chkFirstWatch.Enabled = isWatched;
            dtpWatchedDate.Enabled = isWatched;

            if (isWatched)
            {
                dtpWatchedDate.Value = DateTime.Now;
            }
        }

        private void chkIsNationalFilmRegistry_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable registry year control
            numRegistryYear.Enabled = chkIsNationalFilmRegistry.Checked;
        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            // Calculate suggested year (release year + 1)
            int suggestedYear = (int)numReleaseYear.Value + 1;

            // Open award dialog with suggested year and repository for dropdowns
            using var awardDialog = new AwardDialog(suggestedYear, _unitOfWork?.Awards);
            if (awardDialog.ShowDialog() == DialogResult.OK)
            {
                dgvAwards.Rows.Add(
                    awardDialog.AwardName,
                    awardDialog.AwardCategory,
                    awardDialog.AwardYear,
                    awardDialog.Won);
            }
        }

        private void btnRemoveAward_Click(object sender, EventArgs e)
        {
            if (dgvAwards.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAwards.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvAwards.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an award to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a movie title.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (_unitOfWork == null)
            {
                MessageBox.Show("Database connection not initialized.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create movie object
                var movie = new Movie
                {
                    Title = txtTitle.Text.Trim(),
                    ReleaseYear = (int)numReleaseYear.Value,
                    Director = string.IsNullOrWhiteSpace(txtDirector.Text) ? null : txtDirector.Text.Trim(),
                    TopActor = string.IsNullOrWhiteSpace(txtTopActor.Text) ? null : txtTopActor.Text.Trim(),
                    Genre = string.IsNullOrWhiteSpace(txtGenre.Text) ? null : txtGenre.Text.Trim(),
                    Series = string.IsNullOrWhiteSpace(txtSeries.Text) ? null : txtSeries.Text.Trim(),
                    Runtime = numRuntime.Value > 0 ? (int)numRuntime.Value : null,
                    Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim(),
                    IsNationalFilmRegistry = chkIsNationalFilmRegistry.Checked,
                    IsDisney = chkIsDisney.Checked,
                    NationalFilmRegistryYear = chkIsNationalFilmRegistry.Checked ? (int)numRegistryYear.Value : null,
                    IsWatched = chkIsWatched.Checked,
                    FirstWatch = chkFirstWatch.Checked,
                    WatchedDate = chkIsWatched.Checked ? dtpWatchedDate.Value : null,
                    UserRating = numUserRating.Value > 0 ? (int)numUserRating.Value : null,
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim(),
                    DateAdded = DateTime.Now
                };

                // Insert movie
                int movieId = _unitOfWork.Movies.Insert(movie);

                // Insert awards
                foreach (DataGridViewRow row in dgvAwards.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null)
                    {
                        var award = new Award
                        {
                            MovieId = movieId,
                            AwardName = row.Cells[0].Value?.ToString() ?? string.Empty,
                            Category = row.Cells[1].Value?.ToString() ?? string.Empty,
                            Year = Convert.ToInt32(row.Cells[2].Value ?? DateTime.Now.Year),
                            Won = Convert.ToBoolean(row.Cells[3].Value ?? false)
                        };

                        _unitOfWork.Awards.Insert(award);
                    }
                }

                MessageBox.Show($"Movie '{movie.Title}' saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving movie: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the form?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            // Clear all input fields
            txtTitle.Clear();
            numReleaseYear.Value = DateTime.Now.Year;
            txtDirector.Clear();
            txtTopActor.Clear();
            txtGenre.Clear();
            txtSeries.Clear();
            numRuntime.Value = 0;
            txtDescription.Clear();

            chkIsNationalFilmRegistry.Checked = false;
            chkIsDisney.Checked = false;
            numRegistryYear.Value = DateTime.Now.Year;

            chkIsWatched.Checked = false;
            chkFirstWatch.Checked = false;
            dtpWatchedDate.Value = DateTime.Now;
            numUserRating.Value = 0;
            txtNotes.Clear();

            dgvAwards.Rows.Clear();

            txtTitle.Focus();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _unitOfWork?.Dispose();
            base.OnFormClosing(e);
        }

        // Button hover effects
        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = _buttonGreenHoverColor;
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = _buttonGreenColor;
        }

        private void CancelButton_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = _buttonRedHoverColor;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = _buttonRedColor;
        }

        private void AddAwardButton_MouseEnter(object sender, EventArgs e)
        {
            btnAddAward.BackColor = _buttonHoverColor;
        }

        private void AddAwardButton_MouseLeave(object sender, EventArgs e)
        {
            btnAddAward.BackColor = _buttonBlueColor;
        }

        private void RemoveAwardButton_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveAward.BackColor = _buttonRedHoverColor;
        }

        private void RemoveAwardButton_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveAward.BackColor = _buttonRedColor;
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
