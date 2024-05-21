namespace University_Library
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            username_lbl = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            update_btn = new Button();
            browse_btn = new Button();
            Librarybtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            clostebtn = new Button();
            MainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 28);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(username_lbl);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(update_btn);
            panel1.Controls.Add(browse_btn);
            panel1.Controls.Add(Librarybtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 700);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 532);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_lbl.ForeColor = SystemColors.Window;
            username_lbl.Location = new Point(101, 175);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(0, 23);
            username_lbl.TabIndex = 6;
            username_lbl.TextAlign = ContentAlignment.MiddleCenter;
            username_lbl.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(62, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(28, 28, 28);
            panel3.Location = new Point(227, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 100);
            panel3.TabIndex = 2;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.FromArgb(28, 28, 28);
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = SystemColors.Window;
            update_btn.Location = new Point(-3, 375);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(224, 32);
            update_btn.TabIndex = 4;
            update_btn.Text = "Update Profile";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // browse_btn
            // 
            browse_btn.BackColor = Color.FromArgb(28, 28, 28);
            browse_btn.FlatAppearance.BorderSize = 0;
            browse_btn.FlatStyle = FlatStyle.Flat;
            browse_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browse_btn.ForeColor = SystemColors.Window;
            browse_btn.Location = new Point(-3, 310);
            browse_btn.Name = "browse_btn";
            browse_btn.Size = new Size(224, 32);
            browse_btn.TabIndex = 3;
            browse_btn.Text = "Browse";
            browse_btn.UseVisualStyleBackColor = false;
            browse_btn.Click += browse_btn_Click;
            // 
            // Librarybtn
            // 
            Librarybtn.BackColor = Color.FromArgb(28, 28, 28);
            Librarybtn.FlatAppearance.BorderSize = 0;
            Librarybtn.FlatStyle = FlatStyle.Flat;
            Librarybtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Librarybtn.ForeColor = SystemColors.Window;
            Librarybtn.Location = new Point(-3, 252);
            Librarybtn.Name = "Librarybtn";
            Librarybtn.Size = new Size(224, 32);
            Librarybtn.TabIndex = 2;
            Librarybtn.Text = "Your library";
            Librarybtn.UseVisualStyleBackColor = false;
            Librarybtn.Click += Librarybtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(101, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 38);
            label1.TabIndex = 1;
            label1.Text = "ULMS";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 28, 28);
            panel2.Controls.Add(clostebtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(227, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 31);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            panel2.MouseDoubleClick += panel2_MouseDoubleClick;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // clostebtn
            // 
            clostebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clostebtn.BackColor = Color.FromArgb(28, 28, 28);
            clostebtn.FlatAppearance.BorderSize = 0;
            clostebtn.FlatStyle = FlatStyle.Flat;
            clostebtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clostebtn.ForeColor = SystemColors.Window;
            clostebtn.Location = new Point(920, 3);
            clostebtn.Name = "clostebtn";
            clostebtn.Size = new Size(53, 22);
            clostebtn.TabIndex = 3;
            clostebtn.Text = "X";
            clostebtn.UseVisualStyleBackColor = false;
            clostebtn.Click += button4_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(227, 31);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(973, 669);
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(MainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashboard";
            Load += StudentDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button update_btn;
        private Button browse_btn;
        private Button Librarybtn;
        private Panel panel3;
        private Panel panel2;
        private Button clostebtn;
        private Panel MainPanel;
        private PictureBox pictureBox2;
        private Label username_lbl;
        private PictureBox pictureBox3;
    }
}