namespace College_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Turquoise;
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Maroon;
            richTextBox1.Location = new Point(24, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1106, 447);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(238, 50);
            label1.TabIndex = 11;
            label1.Text = "Courses Info";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1165, 600);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
    }
}