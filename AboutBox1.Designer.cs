namespace College_Management_System
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            tableLayoutPanel = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            labelProductName = new Label();
            labelVersion = new Label();
            labelCopyright = new Label();
            labelCompanyName = new Label();
            textBoxDescription = new TextBox();
            okButton = new Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.92618F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.07382F));
            tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
            tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
            tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel.Controls.Add(okButton, 1, 5);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(12, 14);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7850933F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.912768F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.912768F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.912768F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.56384F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.912768F));
            tableLayoutPanel.Size = new Size(964, 468);
            tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(4, 5);
            logoPictureBox.Margin = new Padding(4, 5, 4, 5);
            logoPictureBox.Name = "logoPictureBox";
            tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
            logoPictureBox.Size = new Size(328, 458);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 12;
            logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            labelProductName.Dock = DockStyle.Fill;
            labelProductName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.ForeColor = Color.DarkBlue;
            labelProductName.Location = new Point(344, 0);
            labelProductName.Margin = new Padding(8, 0, 4, 0);
            labelProductName.MaximumSize = new Size(0, 26);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(616, 26);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "College Management System";
            labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            labelVersion.Dock = DockStyle.Fill;
            labelVersion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelVersion.ForeColor = Color.DarkMagenta;
            labelVersion.Location = new Point(344, 50);
            labelVersion.Margin = new Padding(8, 0, 4, 0);
            labelVersion.MaximumSize = new Size(0, 26);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(616, 26);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "Version";
            labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            labelCopyright.Dock = DockStyle.Fill;
            labelCopyright.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelCopyright.ForeColor = Color.Red;
            labelCopyright.Location = new Point(344, 96);
            labelCopyright.Margin = new Padding(8, 0, 4, 0);
            labelCopyright.MaximumSize = new Size(0, 26);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(616, 26);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "Copyright";
            labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Dock = DockStyle.Fill;
            labelCompanyName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCompanyName.ForeColor = Color.DarkSlateBlue;
            labelCompanyName.Location = new Point(344, 142);
            labelCompanyName.Margin = new Padding(8, 0, 4, 0);
            labelCompanyName.MaximumSize = new Size(0, 26);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(616, 26);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "Company Name";
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDescription.ForeColor = Color.Black;
            textBoxDescription.Location = new Point(344, 193);
            textBoxDescription.Margin = new Padding(8, 5, 4, 5);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = ScrollBars.Both;
            textBoxDescription.Size = new Size(616, 221);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "Description";
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(860, 429);
            okButton.Margin = new Padding(4, 5, 4, 5);
            okButton.Name = "okButton";
            okButton.Size = new Size(100, 34);
            okButton.TabIndex = 24;
            okButton.Text = "&OK";
            okButton.Click += okButton_Click;
            // 
            // AboutBox1
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 496);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox1";
            Padding = new Padding(12, 14, 12, 14);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutBox1";
            Load += AboutBox1_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox logoPictureBox;
        private Label labelProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private TextBox textBoxDescription;
        private Button okButton;
    }
}
