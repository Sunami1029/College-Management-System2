namespace College_Management_System
{
    partial class e_learn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(e_learn));
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(44, 45, 0);
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Yellow;
            linkLabel1.Location = new Point(625, 482);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(269, 23);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://karnatakalms.com/login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(904, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(229, 481);
            label1.Name = "label1";
            label1.Size = new Size(340, 25);
            label1.TabIndex = 2;
            label1.Text = "Login Via Nearby Link And Learn Online";
            // 
            // e_learn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 45, 0);
            ClientSize = new Size(906, 527);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Name = "e_learn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e_learn";
            FormClosed += e_learn_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}