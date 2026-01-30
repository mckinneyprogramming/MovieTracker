using MovieTracker.Logic.Data;
using System.Drawing.Drawing2D;

namespace MovieTracker.WindowsFormUi
{
    public partial class HomeForm : Form
    {
        private readonly Color _buttonHoverColor = Color.FromArgb(0, 90, 158);
        private readonly Color _buttonBlueColor = Color.FromArgb(0, 120, 212);
        private readonly Color _buttonGreenColor = Color.FromArgb(16, 137, 62);
        private readonly Color _buttonGreenHoverColor = Color.FromArgb(12, 107, 48);

        private MovieTrackerUnitOfWork? _unitOfWork;
        private static string DatabasePath => DatabasePathHelper.GetDatabasePath();

        public HomeForm()
        {
            InitializeComponent();
            
            // Enable double buffering for smooth rendering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void HomeForm_Load(object sender, EventArgs e)
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

            // Load statistics
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                if (_unitOfWork != null)
                {
                    var movies = _unitOfWork.Movies.GetAll(_unitOfWork.Awards);
                    lblTotalMoviesCount.Text = movies.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                lblTotalMoviesCount.Text = "Error";
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Create gradient background for header
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panelHeader.ClientRectangle,
                Color.FromArgb(0, 120, 212),
                Color.FromArgb(0, 90, 180),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, panelHeader.ClientRectangle);
            }
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel panel)
            {
                // Draw shadow effect
                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
                    int radius = 8;

                    // Create rounded rectangle
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    panel.Region = new Region(path);

                    // Draw border
                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    {
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private void panelBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = Color.FromArgb(248, 248, 248);
                
                // Add subtle scale effect
                panel.Padding = new Padding(2);
            }
        }

        private void panelBtn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = Color.White;
                panel.Padding = new Padding(0);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            var addMovieForm = new AddMovieForm();
            addMovieForm.ShowDialog();
            
            // Refresh statistics after adding movie
            LoadStatistics();
        }

        private void btnViewMovies_Click(object sender, EventArgs e)
        {
            // TODO: Create ViewMoviesForm
            MessageBox.Show("View Movies feature coming soon!", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            // TODO: Create UpdateMovieForm
            MessageBox.Show("Update Movie feature coming soon!", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageAwards_Click(object sender, EventArgs e)
        {
            // TODO: Create ManageAwardsForm
            MessageBox.Show("Manage Awards feature coming soon!", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageSummaries_Click(object sender, EventArgs e)
        {
            // TODO: Create ManageSummariesForm
            MessageBox.Show("Manage Summaries feature coming soon!", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            // TODO: Create StatisticsForm
            MessageBox.Show("Statistics feature coming soon!", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _unitOfWork?.Dispose();
            base.OnFormClosing(e);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Apply hover effect based on original color
                if (btn.BackColor == _buttonBlueColor)
                {
                    btn.BackColor = _buttonHoverColor;
                }
                else if (btn.BackColor == _buttonGreenColor)
                {
                    btn.BackColor = _buttonGreenHoverColor;
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Restore original color based on which row
                if (btn == btnAddMovie || btn == btnViewMovies || btn == btnUpdateMovie)
                {
                    btn.BackColor = _buttonBlueColor;
                }
                else
                {
                    btn.BackColor = _buttonGreenColor;
                }
            }
        }
    }
}