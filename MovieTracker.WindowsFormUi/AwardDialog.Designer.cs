namespace MovieTracker.WindowsFormUi
{
    partial class AwardDialog
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
            lblAwardName = new Label();
            cboAwardName = new ComboBox();
            lblNewAwardName = new Label();
            txtNewAwardName = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblNewCategory = new Label();
            txtNewCategory = new TextBox();
            lblYear = new Label();
            numYear = new NumericUpDown();
            chkWon = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // lblAwardName
            // 
            lblAwardName.AutoSize = true;
            lblAwardName.Location = new Point(20, 20);
            lblAwardName.Name = "lblAwardName";
            lblAwardName.Size = new Size(96, 20);
            lblAwardName.TabIndex = 0;
            lblAwardName.Text = "Award Name:";
            // 
            // cboAwardName
            // 
            cboAwardName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAwardName.Location = new Point(130, 17);
            cboAwardName.Name = "cboAwardName";
            cboAwardName.Size = new Size(250, 28);
            cboAwardName.TabIndex = 1;
            cboAwardName.SelectedIndexChanged += cboAwardName_SelectedIndexChanged;
            // 
            // lblNewAwardName
            // 
            lblNewAwardName.AutoSize = true;
            lblNewAwardName.Location = new Point(20, 52);
            lblNewAwardName.Name = "lblNewAwardName";
            lblNewAwardName.Size = new Size(92, 20);
            lblNewAwardName.TabIndex = 2;
            lblNewAwardName.Text = "Or add new:";
            // 
            // txtNewAwardName
            // 
            txtNewAwardName.Location = new Point(130, 49);
            txtNewAwardName.Name = "txtNewAwardName";
            txtNewAwardName.PlaceholderText = "New award name";
            txtNewAwardName.Size = new Size(250, 27);
            txtNewAwardName.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 88);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(130, 85);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(250, 28);
            cboCategory.TabIndex = 5;
            // 
            // lblNewCategory
            // 
            lblNewCategory.AutoSize = true;
            lblNewCategory.Location = new Point(20, 120);
            lblNewCategory.Name = "lblNewCategory";
            lblNewCategory.Size = new Size(92, 20);
            lblNewCategory.TabIndex = 6;
            lblNewCategory.Text = "Or add new:";
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(130, 117);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.PlaceholderText = "New category";
            txtNewCategory.Size = new Size(250, 27);
            txtNewCategory.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(20, 156);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 20);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year:";
            // 
            // numYear
            // 
            numYear.Location = new Point(130, 153);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(100, 27);
            numYear.TabIndex = 9;
            numYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // chkWon
            // 
            chkWon.AutoSize = true;
            chkWon.Location = new Point(130, 193);
            chkWon.Name = "chkWon";
            chkWon.Size = new Size(62, 24);
            chkWon.TabIndex = 10;
            chkWon.Text = "Won";
            chkWon.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(205, 238);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(85, 35);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(295, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AwardDialog
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(404, 294);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkWon);
            Controls.Add(numYear);
            Controls.Add(lblYear);
            Controls.Add(txtNewCategory);
            Controls.Add(lblNewCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtNewAwardName);
            Controls.Add(lblNewAwardName);
            Controls.Add(cboAwardName);
            Controls.Add(lblAwardName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AwardDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Award";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAwardName;
        private ComboBox cboAwardName;
        private Label lblNewAwardName;
        private TextBox txtNewAwardName;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblNewCategory;
        private TextBox txtNewCategory;
        private Label lblYear;
        private NumericUpDown numYear;
        private CheckBox chkWon;
        private Button btnOK;
        private Button btnCancel;
    }
}