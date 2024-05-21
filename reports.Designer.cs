namespace University_Library
{
    partial class reports
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            usr_txt = new TextBox();
            button3 = new Button();
            button4 = new Button();
            book_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 255);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(12, 45);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 2;
            button1.Text = "Show Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(222, 45);
            button2.Name = "button2";
            button2.Size = new Size(160, 29);
            button2.TabIndex = 3;
            button2.Text = "Show Users";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // usr_txt
            // 
            usr_txt.Anchor = AnchorStyles.None;
            usr_txt.Location = new Point(440, 12);
            usr_txt.Name = "usr_txt";
            usr_txt.Size = new Size(125, 27);
            usr_txt.TabIndex = 4;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(425, 45);
            button3.Name = "button3";
            button3.Size = new Size(160, 29);
            button3.TabIndex = 5;
            button3.Text = "Show user";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(614, 45);
            button4.Name = "button4";
            button4.Size = new Size(160, 29);
            button4.TabIndex = 7;
            button4.Text = "Show book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // book_txt
            // 
            book_txt.Anchor = AnchorStyles.None;
            book_txt.Location = new Point(629, 12);
            book_txt.Name = "book_txt";
            book_txt.Size = new Size(125, 27);
            book_txt.TabIndex = 6;
            book_txt.TextChanged += book_txt_TextChanged;
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(book_txt);
            Controls.Add(button3);
            Controls.Add(usr_txt);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "reports";
            Text = "reports";
            Load += reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox usr_txt;
        private Button button3;
        private Button button4;
        private TextBox book_txt;
    }
}