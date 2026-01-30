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
            txtAwardName = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
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
            // txtAwardName
            // 
            txtAwardName.Location = new Point(130, 17);
            txtAwardName.Name = "txtAwardName";
            txtAwardName.Size = new Size(250, 27);
            txtAwardName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(130, 57);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(250, 27);
            txtCategory.TabIndex = 3;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(20, 100);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 20);
            lblYear.TabIndex = 4;
            lblYear.Text = "Year:";
            // 
            // numYear
            // 
            numYear.Location = new Point(130, 98);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(100, 27);
            numYear.TabIndex = 5;
            numYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // chkWon
            // 
            chkWon.AutoSize = true;
            chkWon.Location = new Point(130, 140);
            chkWon.Name = "chkWon";
            chkWon.Size = new Size(62, 24);
            chkWon.TabIndex = 6;
            chkWon.Text = "Won";
            chkWon.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(205, 185);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(85, 35);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(295, 185);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 35);
            btnCancel.TabIndex = 8;
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
            ClientSize = new Size(404, 241);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkWon);
            Controls.Add(numYear);
            Controls.Add(lblYear);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtAwardName);
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
        private TextBox txtAwardName;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblYear;
        private NumericUpDown numYear;
        private CheckBox chkWon;
        private Button btnOK;
        private Button btnCancel;
    }
}