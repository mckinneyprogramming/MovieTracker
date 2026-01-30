using MovieTracker.Logic.Data;
using MovieTracker.Logic.Models;
using System.Drawing.Drawing2D;

namespace MovieTracker.WindowsFormUi
{
    public partial class ViewMoviesForm : Form
    {
        private static readonly Color HeaderBackColor = Color.FromArgb(248, 249, 250);
        private static readonly Color HeaderForeColor = Color.FromArgb(60, 60, 60);
        private static readonly Color AltRowColor = Color.FromArgb(249, 250, 251);
        private static readonly Color GridLineColor = Color.FromArgb(234, 236, 239);
        private static readonly Color SelectionBackColor = Color.FromArgb(0, 120, 212);
        private static readonly Color SelectionForeColor = Color.White;

        private MovieTrackerUnitOfWork? _unitOfWork;
        private static string DatabasePath => DatabasePathHelper.GetDatabasePath();

        private List<Movie> _currentMovies = [];

        public ViewMoviesForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void ViewMoviesForm_Load(object sender, EventArgs e)
        {
            var directory = Path.GetDirectoryName(DatabasePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            _unitOfWork = new MovieTrackerUnitOfWork(DatabasePath);
            _unitOfWork.InitializeDatabase();

            ConfigureMoviesGrid();
            ConfigureAwardsGrid();
            PopulateFilterOptions();

            cboWatched.SelectedIndex = 0;
            cboYearFrom.SelectedIndex = 0;
            cboYearTo.SelectedIndex = 0;
            cboAward.SelectedIndex = 0;
            cboFilter.SelectedIndex = 0;
        }

        private void PopulateFilterOptions()
        {
            if (_unitOfWork == null) return;

            var years = _unitOfWork.Movies.GetDistinctReleaseYears();
            cboYearFrom.Items.Clear();
            cboYearTo.Items.Clear();
            cboYearFrom.Items.Add("Any");
            cboYearTo.Items.Add("Any");
            foreach (var year in years)
            {
                cboYearFrom.Items.Add(year.ToString());
                cboYearTo.Items.Add(year.ToString());
            }

            var awardNames = _unitOfWork.Awards.GetDistinctAwardNames();
            cboAward.Items.Clear();
            cboAward.Items.Add("Any");
            foreach (var name in awardNames)
            {
                cboAward.Items.Add(name);
            }
        }

        private void ConfigureMoviesGrid()
        {
            dgvMovies.Columns.Clear();
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Title",
                Width = 200,
                ReadOnly = true
            });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Year",
                HeaderText = "Year",
                Width = 56,
                ReadOnly = true
            });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Director",
                HeaderText = "Director",
                Width = 140,
                ReadOnly = true
            });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Genre",
                HeaderText = "Genre",
                Width = 100,
                ReadOnly = true
            });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Disney",
                HeaderText = "Disney",
                Width = 64,
                ReadOnly = true
            });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NFR",
                HeaderText = "NFR",
                Width = 48,
                ReadOnly = true
            });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Awards",
                HeaderText = "Awards",
                Width = 64,
                ReadOnly = true
            });
            dgvMovies.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvMovies.ColumnHeadersDefaultCellStyle.BackColor = HeaderBackColor;
            dgvMovies.ColumnHeadersDefaultCellStyle.ForeColor = HeaderForeColor;
            dgvMovies.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvMovies.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 8, 10, 8);
            dgvMovies.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvMovies.DefaultCellStyle.SelectionBackColor = SelectionBackColor;
            dgvMovies.DefaultCellStyle.SelectionForeColor = SelectionForeColor;
            dgvMovies.AlternatingRowsDefaultCellStyle.BackColor = AltRowColor;
            dgvMovies.GridColor = GridLineColor;
            dgvMovies.RowTemplate.Height = 32;
        }

        private void ConfigureAwardsGrid()
        {
            dgvAwards.Columns.Clear();
            dgvAwards.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AwardName",
                HeaderText = "Award",
                Width = 180,
                ReadOnly = true
            });
            dgvAwards.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Category",
                Width = 180,
                ReadOnly = true
            });
            dgvAwards.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Year",
                HeaderText = "Year",
                Width = 56,
                ReadOnly = true
            });
            dgvAwards.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Result",
                HeaderText = "Result",
                Width = 90,
                ReadOnly = true
            });
            dgvAwards.Columns["AwardName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvAwards.ColumnHeadersDefaultCellStyle.BackColor = HeaderBackColor;
            dgvAwards.ColumnHeadersDefaultCellStyle.ForeColor = HeaderForeColor;
            dgvAwards.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvAwards.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 8, 10, 8);
            dgvAwards.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvAwards.DefaultCellStyle.SelectionBackColor = SelectionBackColor;
            dgvAwards.DefaultCellStyle.SelectionForeColor = SelectionForeColor;
            dgvAwards.AlternatingRowsDefaultCellStyle.BackColor = AltRowColor;
            dgvAwards.GridColor = GridLineColor;
            dgvAwards.RowTemplate.Height = 32;
        }

        private void LoadMovies()
        {
            if (_unitOfWork == null) return;

            try
            {
                var baseList = cboFilter.SelectedIndex switch
                {
                    1 => _unitOfWork.Movies.GetDisney(_unitOfWork.Awards),
                    2 => _unitOfWork.Movies.GetNationalFilmRegistry(_unitOfWork.Awards),
                    _ => _unitOfWork.Movies.GetAll(_unitOfWork.Awards)
                };

                var query = baseList.AsEnumerable();

                // Watched filter
                if (cboWatched.SelectedIndex == 1)
                    query = query.Where(m => m.IsWatched);
                else if (cboWatched.SelectedIndex == 2)
                    query = query.Where(m => !m.IsWatched);

                // Year range filter
                if (cboYearFrom.SelectedIndex > 0 && int.TryParse(cboYearFrom.SelectedItem?.ToString(), out var yearFrom))
                    query = query.Where(m => m.ReleaseYear.HasValue && m.ReleaseYear >= yearFrom);
                if (cboYearTo.SelectedIndex > 0 && int.TryParse(cboYearTo.SelectedItem?.ToString(), out var yearTo))
                    query = query.Where(m => m.ReleaseYear.HasValue && m.ReleaseYear <= yearTo);

                // Award filter: movies that have at least one award matching the selected name
                if (cboAward.SelectedIndex > 0 && cboAward.SelectedItem is string awardName)
                    query = query.Where(m => m.Awards.Any(a => a.AwardName == awardName));

                _currentMovies = query.ToList();

                PopulateMoviesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading movies: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateMoviesGrid()
        {
            var searchTerm = txtSearch.Text.Trim();
            var searchLower = searchTerm.Length > 0 ? searchTerm.ToLowerInvariant() : null;

            var toShow = searchLower == null
                ? _currentMovies
                : _currentMovies.Where(m =>
                    (m.Title?.Contains(searchLower, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (m.Director?.Contains(searchLower, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (m.Genre?.Contains(searchLower, StringComparison.OrdinalIgnoreCase) ?? false)).ToList();

            dgvMovies.Rows.Clear();

            foreach (var movie in toShow)
            {
                var idx = dgvMovies.Rows.Add(
                    movie.Title,
                    movie.ReleaseYear?.ToString() ?? "",
                    movie.Director ?? "",
                    movie.Genre ?? "",
                    movie.IsDisney ? "Yes" : "No",
                    movie.IsNationalFilmRegistry ? "Yes" : "No",
                    movie.Awards.Count.ToString()
                );
                dgvMovies.Rows[idx].Tag = movie;
            }

            lblCount.Text = $"{toShow.Count} movie(s)";

            // Clear awards when list changes; select first row if any to show awards
            dgvAwards.Rows.Clear();
            lblAwardsTable.Text = "Awards for selected movie";
            if (dgvMovies.Rows.Count > 0)
            {
                dgvMovies.Rows[0].Selected = true;
                dgvMovies_SelectionChanged(dgvMovies, EventArgs.Empty);
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            PopulateMoviesGrid();
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            dgvAwards.Rows.Clear();

            if (dgvMovies.CurrentRow?.Tag is not Movie movie)
                return;

            foreach (var award in movie.Awards)
            {
                dgvAwards.Rows.Add(
                    award.AwardName,
                    award.Category,
                    award.Year.ToString(),
                    award.Won ? "Won" : "Nominated"
                );
            }

            lblAwardsTable.Text = movie.Awards.Count == 0
                ? "Awards for selected movie (none)"
                : $"Awards for \"{movie.Title}\" ({movie.Awards.Count})";
        }

        private void Filter_Changed(object? sender, EventArgs e)
        {
            LoadMovies();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                panelHeader.ClientRectangle,
                Color.FromArgb(0, 120, 212),
                Color.FromArgb(0, 90, 180),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, panelHeader.ClientRectangle);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _unitOfWork?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
