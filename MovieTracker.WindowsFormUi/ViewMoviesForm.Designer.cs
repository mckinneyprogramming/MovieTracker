namespace MovieTracker.WindowsFormUi
{
    partial class ViewMoviesForm
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
            lblTitle = new Label();
            panelFilters = new Panel();
            lblFilter = new Label();
            cboFilter = new ComboBox();
            lblWatched = new Label();
            cboWatched = new ComboBox();
            lblYearFrom = new Label();
            cboYearFrom = new ComboBox();
            lblYearTo = new Label();
            cboYearTo = new ComboBox();
            lblAward = new Label();
            cboAward = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            splitMain = new SplitContainer();
            panelMovies = new Panel();
            lblMoviesTable = new Label();
            dgvMovies = new DataGridView();
            panelAwards = new Panel();
            lblAwardsTable = new Label();
            dgvAwards = new DataGridView();
            panelFooter = new Panel();
            btnClose = new Button();
            panelHeader.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            panelMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            panelAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAwards).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(0, 120, 212);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 80);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "View Movies";
            //
            // panelFilters
            //
            panelFilters.BackColor = Color.White;
            panelFilters.Controls.Add(lblCount);
            panelFilters.Controls.Add(txtSearch);
            panelFilters.Controls.Add(lblSearch);
            panelFilters.Controls.Add(cboAward);
            panelFilters.Controls.Add(lblAward);
            panelFilters.Controls.Add(cboYearTo);
            panelFilters.Controls.Add(lblYearTo);
            panelFilters.Controls.Add(cboYearFrom);
            panelFilters.Controls.Add(lblYearFrom);
            panelFilters.Controls.Add(cboWatched);
            panelFilters.Controls.Add(lblWatched);
            panelFilters.Controls.Add(cboFilter);
            panelFilters.Controls.Add(lblFilter);
            panelFilters.Dock = DockStyle.Top;
            panelFilters.Location = new Point(0, 80);
            panelFilters.Name = "panelFilters";
            panelFilters.Padding = new Padding(20, 12, 20, 12);
            panelFilters.Size = new Size(900, 88);
            panelFilters.TabIndex = 1;
            //
            // lblFilter
            //
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 9.5F);
            lblFilter.ForeColor = Color.FromArgb(60, 60, 60);
            lblFilter.Location = new Point(23, 18);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(35, 17);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Type:";
            //
            // cboFilter
            //
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.Font = new Font("Segoe UI", 9.5F);
            cboFilter.FormattingEnabled = true;
            cboFilter.Items.AddRange(new object[] { "All Movies", "Disney Only", "National Film Register Only" });
            cboFilter.Location = new Point(63, 15);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(165, 25);
            cboFilter.TabIndex = 1;
            cboFilter.SelectedIndexChanged += Filter_Changed;
            //
            // lblWatched
            //
            lblWatched.AutoSize = true;
            lblWatched.Font = new Font("Segoe UI", 9.5F);
            lblWatched.ForeColor = Color.FromArgb(60, 60, 60);
            lblWatched.Location = new Point(242, 18);
            lblWatched.Name = "lblWatched";
            lblWatched.Size = new Size(54, 17);
            lblWatched.TabIndex = 2;
            lblWatched.Text = "Watched:";
            //
            // cboWatched
            //
            cboWatched.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWatched.Font = new Font("Segoe UI", 9.5F);
            cboWatched.FormattingEnabled = true;
            cboWatched.Items.AddRange(new object[] { "All", "Watched only", "Unwatched only" });
            cboWatched.Location = new Point(301, 15);
            cboWatched.Name = "cboWatched";
            cboWatched.Size = new Size(120, 25);
            cboWatched.TabIndex = 3;
            cboWatched.SelectedIndexChanged += Filter_Changed;
            //
            // lblYearFrom
            //
            lblYearFrom.AutoSize = true;
            lblYearFrom.Font = new Font("Segoe UI", 9.5F);
            lblYearFrom.ForeColor = Color.FromArgb(60, 60, 60);
            lblYearFrom.Location = new Point(433, 18);
            lblYearFrom.Name = "lblYearFrom";
            lblYearFrom.Size = new Size(58, 17);
            lblYearFrom.TabIndex = 4;
            lblYearFrom.Text = "Year from:";
            //
            // cboYearFrom
            //
            cboYearFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearFrom.Font = new Font("Segoe UI", 9.5F);
            cboYearFrom.FormattingEnabled = true;
            cboYearFrom.Location = new Point(496, 15);
            cboYearFrom.Name = "cboYearFrom";
            cboYearFrom.Size = new Size(72, 25);
            cboYearFrom.TabIndex = 5;
            cboYearFrom.SelectedIndexChanged += Filter_Changed;
            //
            // lblYearTo
            //
            lblYearTo.AutoSize = true;
            lblYearTo.Font = new Font("Segoe UI", 9.5F);
            lblYearTo.ForeColor = Color.FromArgb(60, 60, 60);
            lblYearTo.Location = new Point(578, 18);
            lblYearTo.Name = "lblYearTo";
            lblYearTo.Size = new Size(20, 17);
            lblYearTo.TabIndex = 6;
            lblYearTo.Text = "to:";
            //
            // cboYearTo
            //
            cboYearTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearTo.Font = new Font("Segoe UI", 9.5F);
            cboYearTo.FormattingEnabled = true;
            cboYearTo.Location = new Point(604, 15);
            cboYearTo.Name = "cboYearTo";
            cboYearTo.Size = new Size(72, 25);
            cboYearTo.TabIndex = 7;
            cboYearTo.SelectedIndexChanged += Filter_Changed;
            //
            // lblAward
            //
            lblAward.AutoSize = true;
            lblAward.Font = new Font("Segoe UI", 9.5F);
            lblAward.ForeColor = Color.FromArgb(60, 60, 60);
            lblAward.Location = new Point(23, 52);
            lblAward.Name = "lblAward";
            lblAward.Size = new Size(46, 17);
            lblAward.TabIndex = 8;
            lblAward.Text = "Award:";
            //
            // cboAward
            //
            cboAward.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAward.Font = new Font("Segoe UI", 9.5F);
            cboAward.FormattingEnabled = true;
            cboAward.Location = new Point(75, 49);
            cboAward.Name = "cboAward";
            cboAward.Size = new Size(220, 25);
            cboAward.TabIndex = 9;
            cboAward.SelectedIndexChanged += Filter_Changed;
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F);
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(308, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(44, 17);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search:";
            //
            // txtSearch
            //
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(358, 49);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Title, director, genre...";
            txtSearch.Size = new Size(220, 25);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // lblCount
            //
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCount.Font = new Font("Segoe UI", 10F);
            lblCount.ForeColor = Color.Gray;
            lblCount.Location = new Point(700, 52);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(177, 19);
            lblCount.TabIndex = 12;
            lblCount.Text = "0 movie(s)";
            lblCount.TextAlign = ContentAlignment.TopRight;
            //
            // splitMain
            //
            splitMain.Dock = DockStyle.Fill;
            splitMain.FixedPanel = FixedPanel.None;
            splitMain.Location = new Point(0, 168);
            splitMain.Name = "splitMain";
            splitMain.Orientation = Orientation.Horizontal;
            //
            // splitMain.Panel1
            //
            splitMain.Panel1.Controls.Add(panelMovies);
            splitMain.Panel1.Padding = new Padding(16, 8, 16, 4);
            //
            // splitMain.Panel2
            //
            splitMain.Panel2.Controls.Add(panelAwards);
            splitMain.Panel2.Padding = new Padding(16, 4, 16, 8);
            splitMain.Size = new Size(900, 432);
            splitMain.SplitterDistance = 240;
            splitMain.TabIndex = 2;
            splitMain.BackColor = Color.FromArgb(245, 245, 245);
            //
            // panelMovies
            //
            panelMovies.BackColor = Color.White;
            panelMovies.Controls.Add(lblMoviesTable);
            panelMovies.Controls.Add(dgvMovies);
            panelMovies.Dock = DockStyle.Fill;
            panelMovies.Location = new Point(16, 8);
            panelMovies.Name = "panelMovies";
            panelMovies.Padding = new Padding(12);
            panelMovies.Size = new Size(868, 228);
            panelMovies.TabIndex = 0;
            //
            // lblMoviesTable
            //
            lblMoviesTable.AutoSize = true;
            lblMoviesTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMoviesTable.ForeColor = Color.FromArgb(60, 60, 60);
            lblMoviesTable.Location = new Point(15, 12);
            lblMoviesTable.Name = "lblMoviesTable";
            lblMoviesTable.Size = new Size(60, 20);
            lblMoviesTable.TabIndex = 0;
            lblMoviesTable.Text = "Movies";
            //
            // dgvMovies
            //
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.AllowUserToResizeRows = false;
            dgvMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovies.BackgroundColor = Color.White;
            dgvMovies.BorderStyle = BorderStyle.None;
            dgvMovies.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMovies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMovies.ColumnHeadersHeight = 36;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMovies.EnableHeadersVisualStyles = false;
            dgvMovies.Location = new Point(12, 38);
            dgvMovies.MultiSelect = false;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersVisible = false;
            dgvMovies.RowTemplate.Height = 32;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(844, 178);
            dgvMovies.TabIndex = 1;
            dgvMovies.SelectionChanged += dgvMovies_SelectionChanged;
            //
            // panelAwards
            //
            panelAwards.BackColor = Color.White;
            panelAwards.Controls.Add(lblAwardsTable);
            panelAwards.Controls.Add(dgvAwards);
            panelAwards.Dock = DockStyle.Fill;
            panelAwards.Location = new Point(16, 4);
            panelAwards.Name = "panelAwards";
            panelAwards.Padding = new Padding(12);
            panelAwards.Size = new Size(868, 216);
            panelAwards.TabIndex = 0;
            //
            // lblAwardsTable
            //
            lblAwardsTable.AutoSize = true;
            lblAwardsTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAwardsTable.ForeColor = Color.FromArgb(60, 60, 60);
            lblAwardsTable.Location = new Point(15, 12);
            lblAwardsTable.Name = "lblAwardsTable";
            lblAwardsTable.Size = new Size(195, 20);
            lblAwardsTable.TabIndex = 0;
            lblAwardsTable.Text = "Awards for selected movie";
            //
            // dgvAwards
            //
            dgvAwards.AllowUserToAddRows = false;
            dgvAwards.AllowUserToDeleteRows = false;
            dgvAwards.AllowUserToResizeRows = false;
            dgvAwards.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAwards.BackgroundColor = Color.White;
            dgvAwards.BorderStyle = BorderStyle.None;
            dgvAwards.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAwards.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAwards.ColumnHeadersHeight = 36;
            dgvAwards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAwards.EnableHeadersVisualStyles = false;
            dgvAwards.Location = new Point(12, 38);
            dgvAwards.MultiSelect = false;
            dgvAwards.Name = "dgvAwards";
            dgvAwards.ReadOnly = true;
            dgvAwards.RowHeadersVisible = false;
            dgvAwards.RowTemplate.Height = 32;
            dgvAwards.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAwards.Size = new Size(844, 166);
            dgvAwards.TabIndex = 1;
            //
            // panelFooter
            //
            panelFooter.BackColor = Color.FromArgb(245, 245, 245);
            panelFooter.Controls.Add(btnClose);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(20, 10, 20, 10);
            panelFooter.Size = new Size(900, 50);
            panelFooter.TabIndex = 3;
            //
            // btnClose
            //
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(0, 120, 212);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(785, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Click += btnClose_Click;
            //
            // ViewMoviesForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 650);
            Controls.Add(splitMain);
            Controls.Add(panelFooter);
            Controls.Add(panelFilters);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "ViewMoviesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Movies - Movie Tracker";
            Load += ViewMoviesForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            panelMovies.ResumeLayout(false);
            panelMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            panelAwards.ResumeLayout(false);
            panelAwards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAwards).EndInit();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelFilters;
        private Label lblFilter;
        private ComboBox cboFilter;
        private Label lblWatched;
        private ComboBox cboWatched;
        private Label lblYearFrom;
        private ComboBox cboYearFrom;
        private Label lblYearTo;
        private ComboBox cboYearTo;
        private Label lblAward;
        private ComboBox cboAward;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private SplitContainer splitMain;
        private Panel panelMovies;
        private Label lblMoviesTable;
        private DataGridView dgvMovies;
        private Panel panelAwards;
        private Label lblAwardsTable;
        private DataGridView dgvAwards;
        private Panel panelFooter;
        private Button btnClose;
    }
}
