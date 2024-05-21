namespace University_Library
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            remove_usr_btn = new Button();
            username_lbl = new Label();
            pictureBox2 = new PictureBox();
            report_btn = new Button();
            browse_btn = new Button();
            MngBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            MainPanel = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            clostebtn = new Button();
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
            panel1.Controls.Add(remove_usr_btn);
            panel1.Controls.Add(username_lbl);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(report_btn);
            panel1.Controls.Add(browse_btn);
            panel1.Controls.Add(MngBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 653);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 532);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // remove_usr_btn
            // 
            remove_usr_btn.BackColor = Color.FromArgb(28, 28, 28);
            remove_usr_btn.FlatAppearance.BorderSize = 0;
            remove_usr_btn.FlatStyle = FlatStyle.Flat;
            remove_usr_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove_usr_btn.ForeColor = SystemColors.Window;
            remove_usr_btn.Location = new Point(-3, 365);
            remove_usr_btn.Name = "remove_usr_btn";
            remove_usr_btn.Size = new Size(224, 32);
            remove_usr_btn.TabIndex = 7;
            remove_usr_btn.Text = "Manage Users";
            remove_usr_btn.UseVisualStyleBackColor = false;
            remove_usr_btn.Click += remove_usr_btn_Click;
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
            // report_btn
            // 
            report_btn.BackColor = Color.FromArgb(28, 28, 28);
            report_btn.FlatAppearance.BorderSize = 0;
            report_btn.FlatStyle = FlatStyle.Flat;
            report_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            report_btn.ForeColor = SystemColors.Window;
            report_btn.Location = new Point(-3, 414);
            report_btn.Name = "report_btn";
            report_btn.Size = new Size(224, 32);
            report_btn.TabIndex = 4;
            report_btn.Text = "Reports";
            report_btn.UseVisualStyleBackColor = false;
            report_btn.Click += report_btn_Click;
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
            browse_btn.Text = "Manage Books";
            browse_btn.UseVisualStyleBackColor = false;
            browse_btn.Click += browse_btn_Click;
            // 
            // MngBtn
            // 
            MngBtn.BackColor = Color.FromArgb(28, 28, 28);
            MngBtn.FlatAppearance.BorderSize = 0;
            MngBtn.FlatStyle = FlatStyle.Flat;
            MngBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MngBtn.ForeColor = SystemColors.Window;
            MngBtn.Location = new Point(-3, 256);
            MngBtn.Name = "MngBtn";
            MngBtn.Size = new Size(224, 32);
            MngBtn.TabIndex = 2;
            MngBtn.Text = "Manage Authors";
            MngBtn.UseVisualStyleBackColor = false;
            MngBtn.Click += MngBtn_Click;
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
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(227, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(955, 653);
            MainPanel.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 28, 28);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(clostebtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(227, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 31);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            panel2.Move += panel2_Move;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(1502, 6);
            button1.Name = "button1";
            button1.Size = new Size(53, 22);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // clostebtn
            // 
            clostebtn.BackColor = Color.FromArgb(28, 28, 28);
            clostebtn.FlatAppearance.BorderSize = 0;
            clostebtn.FlatStyle = FlatStyle.Flat;
            clostebtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clostebtn.ForeColor = SystemColors.Window;
            clostebtn.Location = new Point(902, 3);
            clostebtn.Name = "clostebtn";
            clostebtn.Size = new Size(53, 22);
            clostebtn.TabIndex = 3;
            clostebtn.Text = "X";
            clostebtn.UseVisualStyleBackColor = false;
            clostebtn.Click += clostebtn_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(panel2);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
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
        private Label username_lbl;
        private PictureBox pictureBox2;
        private Button report_btn;
        private Button browse_btn;
        private Button MngBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel MainPanel;
        private Panel panel2;
        private Button button1;
        private Button clostebtn;
        private Button remove_usr_btn;
        private PictureBox pictureBox3;
    }
}