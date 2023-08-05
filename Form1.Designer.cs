namespace College_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxun = new TextBox();
            textBoxpas = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(67, 34);
            label1.Name = "label1";
            label1.Size = new Size(954, 35);
            label1.TabIndex = 0;
            label1.Text = "Smt Saraladevi Satheshchandra Agarwal Government First Grade College ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(370, 78);
            label2.Name = "label2";
            label2.Size = new Size(428, 35);
            label2.TabIndex = 1;
            label2.Text = "Autonomous, Bellary, Karnataka";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(463, 142);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 3;
            label3.Text = "Login Page";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(385, 193);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 4;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(400, 256);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // textBoxun
            // 
            textBoxun.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxun.Location = new Point(581, 186);
            textBoxun.Name = "textBoxun";
            textBoxun.PlaceholderText = "Suma01";
            textBoxun.Size = new Size(193, 32);
            textBoxun.TabIndex = 6;
            // 
            // textBoxpas
            // 
            textBoxpas.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxpas.Location = new Point(581, 249);
            textBoxpas.Name = "textBoxpas";
            textBoxpas.PasswordChar = '*';
            textBoxpas.PlaceholderText = "1234";
            textBoxpas.Size = new Size(193, 32);
            textBoxpas.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(370, 316);
            button1.Name = "button1";
            button1.Size = new Size(128, 43);
            button1.TabIndex = 8;
            button1.Text = "Login ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(520, 316);
            button2.Name = "button2";
            button2.Size = new Size(128, 43);
            button2.TabIndex = 9;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(664, 316);
            button3.Name = "button3";
            button3.Size = new Size(134, 43);
            button3.TabIndex = 10;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1086, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxpas);
            Controls.Add(textBoxun);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page [SSA GFGC BELLARY]";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxun;
        private TextBox textBoxpas;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}