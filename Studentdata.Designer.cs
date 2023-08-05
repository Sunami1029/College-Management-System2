namespace College_Management_System
{
    partial class Studentdata
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
            labR3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labR3
            // 
            labR3.AutoSize = true;
            labR3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labR3.ForeColor = Color.Crimson;
            labR3.Location = new Point(460, 121);
            labR3.Name = "labR3";
            labR3.Size = new Size(320, 32);
            labR3.TabIndex = 6;
            labR3.Text = "All Students  Information\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(256, 61);
            label2.Name = "label2";
            label2.Size = new Size(659, 46);
            label2.TabIndex = 5;
            label2.Text = "Autonomous, SN Pet, Bellary, Karnataka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(1200, 42);
            label1.TabIndex = 4;
            label1.Text = "Smt Saraladevi Satheshchandra Agarwal Government First Grade College ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(731, 187);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Here....";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(768, 584);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(239, 36);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click To Print";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(256, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(738, 312);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Address";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Phone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Sem";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Branch";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Studentdata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 644);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(textBox1);
            Controls.Add(labR3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Studentdata";
            Text = "Studentdata";
            FormClosed += Studentdata_FormClosed;
            Load += Studentdata_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labR3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}