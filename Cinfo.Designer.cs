namespace College_Management_System
{
    partial class Cinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cinfo));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(237, 50);
            label1.TabIndex = 0;
            label1.Text = "Contact Info";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(44, 55, 0);
            richTextBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.FromArgb(192, 192, 0);
            richTextBox1.Location = new Point(72, 104);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 429);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(567, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(72, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(499, 429);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Cinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 55, 0);
            ClientSize = new Size(922, 605);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Cinfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cinfo";
            FormClosed += Cinfo_FormClosed;
            Load += Cinfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}