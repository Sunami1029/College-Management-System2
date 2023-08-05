namespace College_Management_System
{
    partial class Vision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vision));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox3 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 54);
            label1.TabIndex = 0;
            label1.Text = "Vision";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Desktop;
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.DarkOrange;
            richTextBox1.Location = new Point(27, 93);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(851, 731);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(851, 678);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Desktop;
            richTextBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.ForeColor = Color.DarkOrange;
            richTextBox2.Location = new Point(27, 93);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(851, 706);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(27, 36);
            label2.Name = "label2";
            label2.Size = new Size(343, 54);
            label2.TabIndex = 4;
            label2.Text = "Code Of Conduct";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(12, 24);
            label3.Name = "label3";
            label3.Size = new Size(571, 54);
            label3.TabIndex = 5;
            label3.Text = "Best Practices Of The College";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.Desktop;
            richTextBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.ForeColor = Color.DarkOrange;
            richTextBox3.Location = new Point(27, 93);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(851, 719);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // Vision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(975, 872);
            Controls.Add(richTextBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Vision";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vision";
            FormClosed += Vision_FormClosed;
            Load += Vision_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox3;
    }
}