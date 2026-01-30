namespace MovieTracker.WindowsFormUi
{
    partial class HomeForm
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

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            panelStats = new Panel();
            lblStatsTitle = new Label();
            lblTotalMovies = new Label();
            lblTotalMoviesCount = new Label();
            panelActions = new Panel();
            lblQuickActions = new Label();
            panelBtnAddMovie = new Panel();
            lblAddMovieDesc = new Label();
            btnAddMovie = new Button();
            panelBtnViewMovies = new Panel();
            lblViewMoviesDesc = new Label();
            btnViewMovies = new Button();
            panelBtnUpdateMovie = new Panel();
            lblUpdateMovieDesc = new Label();
            btnUpdateMovie = new Button();
            panelBtnManageAwards = new Panel();
            lblManageAwardsDesc = new Label();
            btnManageAwards = new Button();
            panelBtnManageSummaries = new Panel();
            lblManageSummariesDesc = new Label();
            btnManageSummaries = new Button();
            panelBtnStatistics = new Panel();
            lblStatisticsDesc = new Label();
            btnStatistics = new Button();
            panelFooter = new Panel();
            lblCopyright = new Label();
            lblVersion = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelStats.SuspendLayout();
            panelActions.SuspendLayout();
            panelBtnAddMovie.SuspendLayout();
            panelBtnViewMovies.SuspendLayout();
            panelBtnUpdateMovie.SuspendLayout();
            panelBtnManageAwards.SuspendLayout();
            panelBtnManageSummaries.SuspendLayout();
            panelBtnStatistics.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 120, 212);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 120);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(361, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎬 Movie Tracker";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(220, 240, 255);
            lblSubtitle.Location = new Point(35, 82);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(398, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Your complete film collection management system";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(245, 245, 245);
            panelMain.Controls.Add(panelStats);
            panelMain.Controls.Add(panelActions);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(900, 530);
            panelMain.TabIndex = 1;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.White;
            panelStats.Controls.Add(lblTotalMoviesCount);
            panelStats.Controls.Add(lblTotalMovies);
            panelStats.Controls.Add(lblStatsTitle);
            panelStats.Location = new Point(33, 33);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(834, 80);
            panelStats.TabIndex = 0;
            panelStats.Paint += panelCard_Paint;
            // 
            // lblStatsTitle
            // 
            lblStatsTitle.AutoSize = true;
            lblStatsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatsTitle.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatsTitle.Location = new Point(15, 15);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.Size = new Size(130, 21);
            lblStatsTitle.TabIndex = 0;
            lblStatsTitle.Text = "📊 Quick Stats";
            // 
            // lblTotalMovies
            // 
            lblTotalMovies.AutoSize = true;
            lblTotalMovies.Font = new Font("Segoe UI", 10F);
            lblTotalMovies.ForeColor = Color.Gray;
            lblTotalMovies.Location = new Point(20, 45);
            lblTotalMovies.Name = "lblTotalMovies";
            lblTotalMovies.Size = new Size(94, 19);
            lblTotalMovies.TabIndex = 1;
            lblTotalMovies.Text = "Total Movies:";
            // 
            // lblTotalMoviesCount
            // 
            lblTotalMoviesCount.AutoSize = true;
            lblTotalMoviesCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMoviesCount.ForeColor = Color.FromArgb(0, 120, 212);
            lblTotalMoviesCount.Location = new Point(115, 42);
            lblTotalMoviesCount.Name = "lblTotalMoviesCount";
            lblTotalMoviesCount.Size = new Size(23, 25);
            lblTotalMoviesCount.TabIndex = 2;
            lblTotalMoviesCount.Text = "0";
            // 
            // panelActions
            // 
            panelActions.Controls.Add(panelBtnStatistics);
            panelActions.Controls.Add(panelBtnManageSummaries);
            panelActions.Controls.Add(panelBtnManageAwards);
            panelActions.Controls.Add(panelBtnUpdateMovie);
            panelActions.Controls.Add(panelBtnViewMovies);
            panelActions.Controls.Add(panelBtnAddMovie);
            panelActions.Controls.Add(lblQuickActions);
            panelActions.Location = new Point(33, 130);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(834, 370);
            panelActions.TabIndex = 1;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblQuickActions.ForeColor = Color.FromArgb(60, 60, 60);
            lblQuickActions.Location = new Point(5, 10);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(134, 25);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "⚡ Quick Actions";
            // 
            // panelBtnAddMovie
            // 
            panelBtnAddMovie.BackColor = Color.White;
            panelBtnAddMovie.Controls.Add(lblAddMovieDesc);
            panelBtnAddMovie.Controls.Add(btnAddMovie);
            panelBtnAddMovie.Cursor = Cursors.Hand;
            panelBtnAddMovie.Location = new Point(10, 50);
            panelBtnAddMovie.Name = "panelBtnAddMovie";
            panelBtnAddMovie.Size = new Size(260, 140);
            panelBtnAddMovie.TabIndex = 1;
            panelBtnAddMovie.Paint += panelCard_Paint;
            panelBtnAddMovie.MouseEnter += panelBtn_MouseEnter;
            panelBtnAddMovie.MouseLeave += panelBtn_MouseLeave;
            panelBtnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.BackColor = Color.Transparent;
            btnAddMovie.Cursor = Cursors.Hand;
            btnAddMovie.FlatAppearance.BorderSize = 0;
            btnAddMovie.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddMovie.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddMovie.FlatStyle = FlatStyle.Flat;
            btnAddMovie.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnAddMovie.ForeColor = Color.FromArgb(0, 120, 212);
            btnAddMovie.Location = new Point(0, 20);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(260, 60);
            btnAddMovie.TabIndex = 0;
            btnAddMovie.Text = "➕ Add Movie";
            btnAddMovie.UseVisualStyleBackColor = false;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // lblAddMovieDesc
            // 
            lblAddMovieDesc.Font = new Font("Segoe UI", 9F);
            lblAddMovieDesc.ForeColor = Color.Gray;
            lblAddMovieDesc.Location = new Point(10, 85);
            lblAddMovieDesc.Name = "lblAddMovieDesc";
            lblAddMovieDesc.Size = new Size(240, 45);
            lblAddMovieDesc.TabIndex = 1;
            lblAddMovieDesc.Text = "Add a new movie to your collection with details and awards";
            lblAddMovieDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelBtnViewMovies
            // 
            panelBtnViewMovies.BackColor = Color.White;
            panelBtnViewMovies.Controls.Add(lblViewMoviesDesc);
            panelBtnViewMovies.Controls.Add(btnViewMovies);
            panelBtnViewMovies.Cursor = Cursors.Hand;
            panelBtnViewMovies.Location = new Point(287, 50);
            panelBtnViewMovies.Name = "panelBtnViewMovies";
            panelBtnViewMovies.Size = new Size(260, 140);
            panelBtnViewMovies.TabIndex = 2;
            panelBtnViewMovies.Paint += panelCard_Paint;
            panelBtnViewMovies.MouseEnter += panelBtn_MouseEnter;
            panelBtnViewMovies.MouseLeave += panelBtn_MouseLeave;
            panelBtnViewMovies.Click += btnViewMovies_Click;
            // 
            // btnViewMovies
            // 
            btnViewMovies.BackColor = Color.Transparent;
            btnViewMovies.Cursor = Cursors.Hand;
            btnViewMovies.FlatAppearance.BorderSize = 0;
            btnViewMovies.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnViewMovies.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnViewMovies.FlatStyle = FlatStyle.Flat;
            btnViewMovies.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnViewMovies.ForeColor = Color.FromArgb(0, 120, 212);
            btnViewMovies.Location = new Point(0, 20);
            btnViewMovies.Name = "btnViewMovies";
            btnViewMovies.Size = new Size(260, 60);
            btnViewMovies.TabIndex = 0;
            btnViewMovies.Text = "🎞️ View Movies";
            btnViewMovies.UseVisualStyleBackColor = false;
            btnViewMovies.Click += btnViewMovies_Click;
            // 
            // lblViewMoviesDesc
            // 
            lblViewMoviesDesc.Font = new Font("Segoe UI", 9F);
            lblViewMoviesDesc.ForeColor = Color.Gray;
            lblViewMoviesDesc.Location = new Point(10, 85);
            lblViewMoviesDesc.Name = "lblViewMoviesDesc";
            lblViewMoviesDesc.Size = new Size(240, 45);
            lblViewMoviesDesc.TabIndex = 1;
            lblViewMoviesDesc.Text = "Browse and search your entire movie collection";
            lblViewMoviesDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelBtnUpdateMovie
            // 
            panelBtnUpdateMovie.BackColor = Color.White;
            panelBtnUpdateMovie.Controls.Add(lblUpdateMovieDesc);
            panelBtnUpdateMovie.Controls.Add(btnUpdateMovie);
            panelBtnUpdateMovie.Cursor = Cursors.Hand;
            panelBtnUpdateMovie.Location = new Point(564, 50);
            panelBtnUpdateMovie.Name = "panelBtnUpdateMovie";
            panelBtnUpdateMovie.Size = new Size(260, 140);
            panelBtnUpdateMovie.TabIndex = 3;
            panelBtnUpdateMovie.Paint += panelCard_Paint;
            panelBtnUpdateMovie.MouseEnter += panelBtn_MouseEnter;
            panelBtnUpdateMovie.MouseLeave += panelBtn_MouseLeave;
            panelBtnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.BackColor = Color.Transparent;
            btnUpdateMovie.Cursor = Cursors.Hand;
            btnUpdateMovie.FlatAppearance.BorderSize = 0;
            btnUpdateMovie.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdateMovie.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUpdateMovie.FlatStyle = FlatStyle.Flat;
            btnUpdateMovie.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnUpdateMovie.ForeColor = Color.FromArgb(0, 120, 212);
            btnUpdateMovie.Location = new Point(0, 20);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(260, 60);
            btnUpdateMovie.TabIndex = 0;
            btnUpdateMovie.Text = "✏️ Update Movie";
            btnUpdateMovie.UseVisualStyleBackColor = false;
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // lblUpdateMovieDesc
            // 
            lblUpdateMovieDesc.Font = new Font("Segoe UI", 9F);
            lblUpdateMovieDesc.ForeColor = Color.Gray;
            lblUpdateMovieDesc.Location = new Point(10, 85);
            lblUpdateMovieDesc.Name = "lblUpdateMovieDesc";
            lblUpdateMovieDesc.Size = new Size(240, 45);
            lblUpdateMovieDesc.TabIndex = 1;
            lblUpdateMovieDesc.Text = "Edit and update existing movie information";
            lblUpdateMovieDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelBtnManageAwards
            // 
            panelBtnManageAwards.BackColor = Color.White;
            panelBtnManageAwards.Controls.Add(lblManageAwardsDesc);
            panelBtnManageAwards.Controls.Add(btnManageAwards);
            panelBtnManageAwards.Cursor = Cursors.Hand;
            panelBtnManageAwards.Location = new Point(10, 210);
            panelBtnManageAwards.Name = "panelBtnManageAwards";
            panelBtnManageAwards.Size = new Size(260, 140);
            panelBtnManageAwards.TabIndex = 4;
            panelBtnManageAwards.Paint += panelCard_Paint;
            panelBtnManageAwards.MouseEnter += panelBtn_MouseEnter;
            panelBtnManageAwards.MouseLeave += panelBtn_MouseLeave;
            panelBtnManageAwards.Click += btnManageAwards_Click;
            // 
            // btnManageAwards
            // 
            btnManageAwards.BackColor = Color.Transparent;
            btnManageAwards.Cursor = Cursors.Hand;
            btnManageAwards.FlatAppearance.BorderSize = 0;
            btnManageAwards.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnManageAwards.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnManageAwards.FlatStyle = FlatStyle.Flat;
            btnManageAwards.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnManageAwards.ForeColor = Color.FromArgb(16, 137, 62);
            btnManageAwards.Location = new Point(0, 20);
            btnManageAwards.Name = "btnManageAwards";
            btnManageAwards.Size = new Size(260, 60);
            btnManageAwards.TabIndex = 0;
            btnManageAwards.Text = "🏆 Awards";
            btnManageAwards.UseVisualStyleBackColor = false;
            btnManageAwards.Click += btnManageAwards_Click;
            // 
            // lblManageAwardsDesc
            // 
            lblManageAwardsDesc.Font = new Font("Segoe UI", 9F);
            lblManageAwardsDesc.ForeColor = Color.Gray;
            lblManageAwardsDesc.Location = new Point(10, 85);
            lblManageAwardsDesc.Name = "lblManageAwardsDesc";
            lblManageAwardsDesc.Size = new Size(240, 45);
            lblManageAwardsDesc.TabIndex = 1;
            lblManageAwardsDesc.Text = "View and manage awards across all movies";
            lblManageAwardsDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelBtnManageSummaries
            // 
            panelBtnManageSummaries.BackColor = Color.White;
            panelBtnManageSummaries.Controls.Add(lblManageSummariesDesc);
            panelBtnManageSummaries.Controls.Add(btnManageSummaries);
            panelBtnManageSummaries.Cursor = Cursors.Hand;
            panelBtnManageSummaries.Location = new Point(287, 210);
            panelBtnManageSummaries.Name = "panelBtnManageSummaries";
            panelBtnManageSummaries.Size = new Size(260, 140);
            panelBtnManageSummaries.TabIndex = 5;
            panelBtnManageSummaries.Paint += panelCard_Paint;
            panelBtnManageSummaries.MouseEnter += panelBtn_MouseEnter;
            panelBtnManageSummaries.MouseLeave += panelBtn_MouseLeave;
            panelBtnManageSummaries.Click += btnManageSummaries_Click;
            // 
            // btnManageSummaries
            // 
            btnManageSummaries.BackColor = Color.Transparent;
            btnManageSummaries.Cursor = Cursors.Hand;
            btnManageSummaries.FlatAppearance.BorderSize = 0;
            btnManageSummaries.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnManageSummaries.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnManageSummaries.FlatStyle = FlatStyle.Flat;
            btnManageSummaries.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnManageSummaries.ForeColor = Color.FromArgb(16, 137, 62);
            btnManageSummaries.Location = new Point(0, 20);
            btnManageSummaries.Name = "btnManageSummaries";
            btnManageSummaries.Size = new Size(260, 60);
            btnManageSummaries.TabIndex = 0;
            btnManageSummaries.Text = "📝 Summaries";
            btnManageSummaries.UseVisualStyleBackColor = false;
            btnManageSummaries.Click += btnManageSummaries_Click;
            // 
            // lblManageSummariesDesc
            // 
            lblManageSummariesDesc.Font = new Font("Segoe UI", 9F);
            lblManageSummariesDesc.ForeColor = Color.Gray;
            lblManageSummariesDesc.Location = new Point(10, 85);
            lblManageSummariesDesc.Name = "lblManageSummariesDesc";
            lblManageSummariesDesc.Size = new Size(240, 45);
            lblManageSummariesDesc.TabIndex = 1;
            lblManageSummariesDesc.Text = "Create yearly summaries and collections";
            lblManageSummariesDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelBtnStatistics
            // 
            panelBtnStatistics.BackColor = Color.White;
            panelBtnStatistics.Controls.Add(lblStatisticsDesc);
            panelBtnStatistics.Controls.Add(btnStatistics);
            panelBtnStatistics.Cursor = Cursors.Hand;
            panelBtnStatistics.Location = new Point(564, 210);
            panelBtnStatistics.Name = "panelBtnStatistics";
            panelBtnStatistics.Size = new Size(260, 140);
            panelBtnStatistics.TabIndex = 6;
            panelBtnStatistics.Paint += panelCard_Paint;
            panelBtnStatistics.MouseEnter += panelBtn_MouseEnter;
            panelBtnStatistics.MouseLeave += panelBtn_MouseLeave;
            panelBtnStatistics.Click += btnStatistics_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.Transparent;
            btnStatistics.Cursor = Cursors.Hand;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStatistics.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnStatistics.ForeColor = Color.FromArgb(16, 137, 62);
            btnStatistics.Location = new Point(0, 20);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(260, 60);
            btnStatistics.TabIndex = 0;
            btnStatistics.Text = "📈 Statistics";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // lblStatisticsDesc
            // 
            lblStatisticsDesc.Font = new Font("Segoe UI", 9F);
            lblStatisticsDesc.ForeColor = Color.Gray;
            lblStatisticsDesc.Location = new Point(10, 85);
            lblStatisticsDesc.Name = "lblStatisticsDesc";
            lblStatisticsDesc.Size = new Size(240, 45);
            lblStatisticsDesc.TabIndex = 1;
            lblStatisticsDesc.Text = "View insights and analytics about your collection";
            lblStatisticsDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(50, 50, 50);
            panelFooter.Controls.Add(lblCopyright);
            panelFooter.Controls.Add(lblVersion);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 650);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(900, 50);
            panelFooter.TabIndex = 2;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 9F);
            lblVersion.ForeColor = Color.LightGray;
            lblVersion.Location = new Point(30, 15);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(72, 15);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version 1.0.0";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 9F);
            lblCopyright.ForeColor = Color.LightGray;
            lblCopyright.Location = new Point(760, 15);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(119, 15);
            lblCopyright.TabIndex = 1;
            lblCopyright.Text = "© 2026 Movie Tracker";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Tracker - Home";
            Load += HomeForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelBtnAddMovie.ResumeLayout(false);
            panelBtnViewMovies.ResumeLayout(false);
            panelBtnUpdateMovie.ResumeLayout(false);
            panelBtnManageAwards.ResumeLayout(false);
            panelBtnManageSummaries.ResumeLayout(false);
            panelBtnStatistics.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Panel panelStats;
        private Label lblStatsTitle;
        private Label lblTotalMovies;
        private Label lblTotalMoviesCount;
        private Panel panelActions;
        private Label lblQuickActions;
        private Panel panelBtnAddMovie;
        private Button btnAddMovie;
        private Label lblAddMovieDesc;
        private Panel panelBtnViewMovies;
        private Label lblViewMoviesDesc;
        private Button btnViewMovies;
        private Panel panelBtnUpdateMovie;
        private Label lblUpdateMovieDesc;
        private Button btnUpdateMovie;
        private Panel panelBtnManageAwards;
        private Label lblManageAwardsDesc;
        private Button btnManageAwards;
        private Panel panelBtnManageSummaries;
        private Label lblManageSummariesDesc;
        private Button btnManageSummaries;
        private Panel panelBtnStatistics;
        private Label lblStatisticsDesc;
        private Button btnStatistics;
        private Panel panelFooter;
        private Label lblVersion;
        private Label lblCopyright;
    }
}