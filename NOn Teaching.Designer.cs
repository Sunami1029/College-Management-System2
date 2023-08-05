namespace College_Management_System
{
    partial class NOn_Teaching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOn_Teaching));
            label1 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            ititi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Purple;
            guna2HtmlLabel1.Location = new Point(60, 32);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(412, 51);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "NON TEACHING STAFF\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 590);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(760, 580);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(214, 33);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back To Main Menu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkBlue;
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(60, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(914, 451);
            textBox1.TabIndex = 50000;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MidnightBlue;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(35, 111);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(939, 451);
            richTextBox1.TabIndex = 50001;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ititi
            // 
            ititi.BackColor = Color.Transparent;
            ititi.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ititi.ForeColor = Color.Purple;
            ititi.Location = new Point(51, 32);
            ititi.Name = "ititi";
            ititi.Size = new Size(259, 51);
            ititi.TabIndex = 50002;
            ititi.Text = "Guest Faculty\r\n\r\n\r\n";
            // 
            // NOn_Teaching
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(984, 646);
            Controls.Add(ititi);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(label1);
            Name = "NOn_Teaching";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "NOn_Teaching";
            FormClosed += NOn_Teaching_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ititi;
    }
}