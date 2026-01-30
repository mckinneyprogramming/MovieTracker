namespace MovieTracker.WindowsFormUi
{
    partial class AddMovieForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupAwards = new GroupBox();
            btnRemoveAward = new Button();
            btnAddAward = new Button();
            dgvAwards = new DataGridView();
            AwardName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Won = new DataGridViewCheckBoxColumn();
            groupTracking = new GroupBox();
            dtpWatchedDate = new DateTimePicker();
            lblWatchedDate = new Label();
            numUserRating = new NumericUpDown();
            lblUserRating = new Label();
            txtNotes = new TextBox();
            lblNotes = new Label();
            chkFirstWatch = new CheckBox();
            chkIsWatched = new CheckBox();
            groupRegistry = new GroupBox();
            numRegistryYear = new NumericUpDown();
            lblRegistryYear = new Label();
            chkIsDisney = new CheckBox();
            chkIsNationalFilmRegistry = new CheckBox();
            groupMovieDetails = new GroupBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            numRuntime = new NumericUpDown();
            lblRuntime = new Label();
            txtSeries = new TextBox();
            lblSeries = new Label();
            txtGenre = new TextBox();
            lblGenre = new Label();
            txtTopActor = new TextBox();
            lblTopActor = new Label();
            txtDirector = new TextBox();
            lblDirector = new Label();
            numReleaseYear = new NumericUpDown();
            lblReleaseYear = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            groupAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAwards).BeginInit();
            groupTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUserRating).BeginInit();
            groupRegistry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRegistryYear).BeginInit();
            groupMovieDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRuntime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReleaseYear).BeginInit();
            SuspendLayout();
            // 
            // groupAwards
            // 
            groupAwards.Controls.Add(btnRemoveAward);
            groupAwards.Controls.Add(btnAddAward);
            groupAwards.Controls.Add(dgvAwards);
            groupAwards.Location = new Point(506, 16);
            groupAwards.Name = "groupAwards";
            groupAwards.Size = new Size(370, 300);
            groupAwards.TabIndex = 3;
            groupAwards.TabStop = false;
            groupAwards.Text = "Awards";
            // 
            // btnRemoveAward
            // 
            btnRemoveAward.Location = new Point(275, 260);
            btnRemoveAward.Name = "btnRemoveAward";
            btnRemoveAward.Size = new Size(90, 30);
            btnRemoveAward.TabIndex = 2;
            btnRemoveAward.Text = "Remove";
            btnRemoveAward.UseVisualStyleBackColor = true;
            btnRemoveAward.Click += btnRemoveAward_Click;
            // 
            // btnAddAward
            // 
            btnAddAward.Location = new Point(185, 260);
            btnAddAward.Name = "btnAddAward";
            btnAddAward.Size = new Size(90, 30);
            btnAddAward.TabIndex = 1;
            btnAddAward.Text = "Add Award";
            btnAddAward.UseVisualStyleBackColor = true;
            btnAddAward.Click += btnAddAward_Click;
            // 
            // dgvAwards
            // 
            dgvAwards.AllowUserToAddRows = false;
            dgvAwards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAwards.Columns.AddRange(new DataGridViewColumn[] { AwardName, Category, Year, Won });
            dgvAwards.Location = new Point(15, 30);
            dgvAwards.Name = "dgvAwards";
            dgvAwards.RowHeadersWidth = 51;
            dgvAwards.Size = new Size(340, 220);
            dgvAwards.TabIndex = 0;
            // 
            // AwardName
            // 
            AwardName.HeaderText = "Award Name";
            AwardName.MinimumWidth = 6;
            AwardName.Name = "AwardName";
            AwardName.Width = 120;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 120;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.Width = 60;
            // 
            // Won
            // 
            Won.HeaderText = "Won";
            Won.MinimumWidth = 6;
            Won.Name = "Won";
            Won.Width = 50;
            // 
            // groupTracking
            // 
            groupTracking.Controls.Add(dtpWatchedDate);
            groupTracking.Controls.Add(lblWatchedDate);
            groupTracking.Controls.Add(numUserRating);
            groupTracking.Controls.Add(lblUserRating);
            groupTracking.Controls.Add(txtNotes);
            groupTracking.Controls.Add(lblNotes);
            groupTracking.Controls.Add(chkFirstWatch);
            groupTracking.Controls.Add(chkIsWatched);
            groupTracking.Location = new Point(506, 322);
            groupTracking.Name = "groupTracking";
            groupTracking.Size = new Size(370, 280);
            groupTracking.TabIndex = 4;
            groupTracking.TabStop = false;
            groupTracking.Text = "Tracking Information";
            // 
            // dtpWatchedDate
            // 
            dtpWatchedDate.CustomFormat = "MM/dd/yyyy";
            dtpWatchedDate.Enabled = false;
            dtpWatchedDate.Format = DateTimePickerFormat.Custom;
            dtpWatchedDate.Location = new Point(150, 90);
            dtpWatchedDate.Name = "dtpWatchedDate";
            dtpWatchedDate.Size = new Size(150, 27);
            dtpWatchedDate.TabIndex = 3;
            // 
            // lblWatchedDate
            // 
            lblWatchedDate.AutoSize = true;
            lblWatchedDate.Location = new Point(15, 95);
            lblWatchedDate.Name = "lblWatchedDate";
            lblWatchedDate.Size = new Size(107, 20);
            lblWatchedDate.TabIndex = 2;
            lblWatchedDate.Text = "Watched Date:";
            // 
            // numUserRating
            // 
            numUserRating.Location = new Point(150, 130);
            numUserRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUserRating.Name = "numUserRating";
            numUserRating.Size = new Size(80, 27);
            numUserRating.TabIndex = 5;
            // 
            // lblUserRating
            // 
            lblUserRating.AutoSize = true;
            lblUserRating.Location = new Point(15, 132);
            lblUserRating.Name = "lblUserRating";
            lblUserRating.Size = new Size(124, 20);
            lblUserRating.TabIndex = 4;
            lblUserRating.Text = "User Rating (1-10):";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(15, 190);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(340, 75);
            txtNotes.TabIndex = 7;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(15, 167);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(51, 20);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes:";
            // 
            // chkFirstWatch
            // 
            chkFirstWatch.AutoSize = true;
            chkFirstWatch.Enabled = false;
            chkFirstWatch.Location = new Point(15, 58);
            chkFirstWatch.Name = "chkFirstWatch";
            chkFirstWatch.Size = new Size(105, 24);
            chkFirstWatch.TabIndex = 1;
            chkFirstWatch.Text = "First Watch";
            chkFirstWatch.UseVisualStyleBackColor = true;
            // 
            // chkIsWatched
            // 
            chkIsWatched.AutoSize = true;
            chkIsWatched.Location = new Point(15, 30);
            chkIsWatched.Name = "chkIsWatched";
            chkIsWatched.Size = new Size(92, 24);
            chkIsWatched.TabIndex = 0;
            chkIsWatched.Text = "Watched";
            chkIsWatched.UseVisualStyleBackColor = true;
            chkIsWatched.CheckedChanged += chkIsWatched_CheckedChanged;
            // 
            // groupRegistry
            // 
            groupRegistry.Controls.Add(numRegistryYear);
            groupRegistry.Controls.Add(lblRegistryYear);
            groupRegistry.Controls.Add(chkIsDisney);
            groupRegistry.Controls.Add(chkIsNationalFilmRegistry);
            groupRegistry.Location = new Point(16, 462);
            groupRegistry.Name = "groupRegistry";
            groupRegistry.Size = new Size(370, 140);
            groupRegistry.TabIndex = 2;
            groupRegistry.TabStop = false;
            groupRegistry.Text = "Film Registry";
            // 
            // numRegistryYear
            // 
            numRegistryYear.Enabled = false;
            numRegistryYear.Location = new Point(205, 92);
            numRegistryYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numRegistryYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numRegistryYear.Name = "numRegistryYear";
            numRegistryYear.Size = new Size(100, 27);
            numRegistryYear.TabIndex = 3;
            numRegistryYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblRegistryYear
            // 
            lblRegistryYear.AutoSize = true;
            lblRegistryYear.Location = new Point(15, 94);
            lblRegistryYear.Name = "lblRegistryYear";
            lblRegistryYear.Size = new Size(184, 20);
            lblRegistryYear.TabIndex = 2;
            lblRegistryYear.Text = "National Registry Year:";
            // 
            // chkIsDisney
            // 
            chkIsDisney.AutoSize = true;
            chkIsDisney.Location = new Point(15, 60);
            chkIsDisney.Name = "chkIsDisney";
            chkIsDisney.Size = new Size(75, 24);
            chkIsDisney.TabIndex = 1;
            chkIsDisney.Text = "Disney";
            chkIsDisney.UseVisualStyleBackColor = true;
            // 
            // chkIsNationalFilmRegistry
            // 
            chkIsNationalFilmRegistry.AutoSize = true;
            chkIsNationalFilmRegistry.Location = new Point(15, 30);
            chkIsNationalFilmRegistry.Name = "chkIsNationalFilmRegistry";
            chkIsNationalFilmRegistry.Size = new Size(181, 24);
            chkIsNationalFilmRegistry.TabIndex = 0;
            chkIsNationalFilmRegistry.Text = "National Film Registry";
            chkIsNationalFilmRegistry.UseVisualStyleBackColor = true;
            chkIsNationalFilmRegistry.CheckedChanged += chkIsNationalFilmRegistry_CheckedChanged;
            // 
            // groupMovieDetails
            // 
            groupMovieDetails.Controls.Add(txtDescription);
            groupMovieDetails.Controls.Add(lblDescription);
            groupMovieDetails.Controls.Add(numRuntime);
            groupMovieDetails.Controls.Add(lblRuntime);
            groupMovieDetails.Controls.Add(txtSeries);
            groupMovieDetails.Controls.Add(lblSeries);
            groupMovieDetails.Controls.Add(txtGenre);
            groupMovieDetails.Controls.Add(lblGenre);
            groupMovieDetails.Controls.Add(txtTopActor);
            groupMovieDetails.Controls.Add(lblTopActor);
            groupMovieDetails.Controls.Add(txtDirector);
            groupMovieDetails.Controls.Add(lblDirector);
            groupMovieDetails.Controls.Add(numReleaseYear);
            groupMovieDetails.Controls.Add(lblReleaseYear);
            groupMovieDetails.Controls.Add(txtTitle);
            groupMovieDetails.Controls.Add(lblTitle);
            groupMovieDetails.Location = new Point(16, 16);
            groupMovieDetails.Name = "groupMovieDetails";
            groupMovieDetails.Size = new Size(370, 300);
            groupMovieDetails.TabIndex = 1;
            groupMovieDetails.TabStop = false;
            groupMovieDetails.Text = "Movie Details";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(15, 325);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(370, 100);
            txtDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(15, 302);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // numRuntime
            // 
            numRuntime.Location = new Point(130, 265);
            numRuntime.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numRuntime.Name = "numRuntime";
            numRuntime.Size = new Size(100, 27);
            numRuntime.TabIndex = 13;
            // 
            // lblRuntime
            // 
            lblRuntime.AutoSize = true;
            lblRuntime.Location = new Point(15, 267);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(109, 20);
            lblRuntime.TabIndex = 12;
            lblRuntime.Text = "Runtime (mins):";
            // 
            // txtSeries
            // 
            txtSeries.Location = new Point(130, 225);
            txtSeries.Name = "txtSeries";
            txtSeries.Size = new Size(225, 27);
            txtSeries.TabIndex = 11;
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Location = new Point(15, 228);
            lblSeries.Name = "lblSeries";
            lblSeries.Size = new Size(51, 20);
            lblSeries.TabIndex = 10;
            lblSeries.Text = "Series:";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(130, 185);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(225, 27);
            txtGenre.TabIndex = 9;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(15, 188);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(51, 20);
            lblGenre.TabIndex = 8;
            lblGenre.Text = "Genre:";
            // 
            // txtTopActor
            // 
            txtTopActor.Location = new Point(130, 145);
            txtTopActor.Name = "txtTopActor";
            txtTopActor.Size = new Size(225, 27);
            txtTopActor.TabIndex = 7;
            // 
            // lblTopActor
            // 
            lblTopActor.AutoSize = true;
            lblTopActor.Location = new Point(15, 148);
            lblTopActor.Name = "lblTopActor";
            lblTopActor.Size = new Size(78, 20);
            lblTopActor.TabIndex = 6;
            lblTopActor.Text = "Top Actor:";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(130, 105);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(225, 27);
            txtDirector.TabIndex = 5;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(15, 108);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(67, 20);
            lblDirector.TabIndex = 4;
            lblDirector.Text = "Director:";
            // 
            // numReleaseYear
            // 
            numReleaseYear.Location = new Point(130, 65);
            numReleaseYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numReleaseYear.Minimum = new decimal(new int[] { 1888, 0, 0, 0 });
            numReleaseYear.Name = "numReleaseYear";
            numReleaseYear.Size = new Size(100, 27);
            numReleaseYear.TabIndex = 3;
            numReleaseYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(15, 67);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(95, 20);
            lblReleaseYear.TabIndex = 2;
            lblReleaseYear.Text = "Release Year:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(130, 25);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(225, 27);
            txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(786, 620);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Movie";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(656, 620);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Clear Form";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 680);
            Controls.Add(groupAwards);
            Controls.Add(groupTracking);
            Controls.Add(groupRegistry);
            Controls.Add(groupMovieDetails);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Movie";
            Load += Form1_Load;
            groupAwards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAwards).EndInit();
            groupTracking.ResumeLayout(false);
            groupTracking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUserRating).EndInit();
            groupRegistry.ResumeLayout(false);
            groupRegistry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRegistryYear).EndInit();
            groupMovieDetails.ResumeLayout(false);
            groupMovieDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRuntime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReleaseYear).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupMovieDetails;
        private TextBox txtTitle;
        private Label lblTitle;
        private NumericUpDown numReleaseYear;
        private Label lblReleaseYear;
        private TextBox txtDirector;
        private Label lblDirector;
        private TextBox txtTopActor;
        private Label lblTopActor;
        private TextBox txtGenre;
        private Label lblGenre;
        private TextBox txtSeries;
        private Label lblSeries;
        private NumericUpDown numRuntime;
        private Label lblRuntime;
        private TextBox txtDescription;
        private Label lblDescription;
        private GroupBox groupRegistry;
        private CheckBox chkIsNationalFilmRegistry;
        private CheckBox chkIsDisney;
        private NumericUpDown numRegistryYear;
        private Label lblRegistryYear;
        private GroupBox groupTracking;
        private CheckBox chkIsWatched;
        private CheckBox chkFirstWatch;
        private Label lblNotes;
        private TextBox txtNotes;
        private Label lblUserRating;
        private NumericUpDown numUserRating;
        private Label lblWatchedDate;
        private DateTimePicker dtpWatchedDate;
        private GroupBox groupAwards;
        private DataGridView dgvAwards;
        private Button btnAddAward;
        private Button btnRemoveAward;
        private Button btnSave;
        private Button btnCancel;
        private DataGridViewTextBoxColumn AwardName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewCheckBoxColumn Won;
    }
}
