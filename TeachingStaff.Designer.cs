namespace College_Management_System
{
    partial class TeachingStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachingStaff));
            label1 = new Label();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(378, 53);
            label1.TabIndex = 0;
            label1.Text = "Teaching Staff";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkBlue;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(52, 80);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(1330, 430);
            textBox1.TabIndex = 50000;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(986, 533);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 23);
            linkLabel1.TabIndex = 50001;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Yellow;
            textBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(412, 530);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(543, 30);
            textBox2.TabIndex = 50002;
            textBox2.Text = "https://gfgc.kar.nic.in/ssa-bellary/category/Teaching-Staff";
            // 
            // TeachingStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1405, 572);
            Controls.Add(textBox2);
            Controls.Add(linkLabel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TeachingStaff";
            Text = "TeachingStaff";
            FormClosed += TeachingStaff_FormClosed;
            Load += TeachingStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private TextBox textBox2;
    }
}