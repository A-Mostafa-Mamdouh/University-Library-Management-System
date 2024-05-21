namespace University_Library
{
    partial class RegisterStudent
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
            Fname_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lName_txt = new TextBox();
            label3 = new Label();
            password_txt = new TextBox();
            label4 = new Label();
            Username_txt = new TextBox();
            label5 = new Label();
            phoneNo_txt = new TextBox();
            label6 = new Label();
            email_txt = new TextBox();
            label7 = new Label();
            faculty_txt = new TextBox();
            label8 = new Label();
            level_txt = new TextBox();
            RegisterButton = new Button();
            GoBackToLog = new Button();
            panel2 = new Panel();
            button1 = new Button();
            clostebtn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Fname_txt
            // 
            Fname_txt.Location = new Point(304, 63);
            Fname_txt.Name = "Fname_txt";
            Fname_txt.Size = new Size(160, 27);
            Fname_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 70);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "FirstName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 103);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "LastName";
            label2.Click += label2_Click;
            // 
            // lName_txt
            // 
            lName_txt.Location = new Point(304, 96);
            lName_txt.Name = "lName_txt";
            lName_txt.Size = new Size(160, 27);
            lName_txt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 169);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // password_txt
            // 
            password_txt.Location = new Point(304, 162);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(160, 27);
            password_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 136);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "UserName";
            // 
            // Username_txt
            // 
            Username_txt.Location = new Point(304, 129);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(160, 27);
            Username_txt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 235);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 11;
            label5.Text = "Phone no";
            // 
            // phoneNo_txt
            // 
            phoneNo_txt.Location = new Point(304, 228);
            phoneNo_txt.Name = "phoneNo_txt";
            phoneNo_txt.Size = new Size(160, 27);
            phoneNo_txt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(220, 202);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // email_txt
            // 
            email_txt.Location = new Point(304, 195);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(160, 27);
            email_txt.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 301);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 15;
            label7.Text = "Faculty";
            // 
            // faculty_txt
            // 
            faculty_txt.Location = new Point(304, 294);
            faculty_txt.Name = "faculty_txt";
            faculty_txt.Size = new Size(160, 27);
            faculty_txt.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(223, 268);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 13;
            label8.Text = "Level";
            // 
            // level_txt
            // 
            level_txt.Location = new Point(304, 261);
            level_txt.Name = "level_txt";
            level_txt.Size = new Size(160, 27);
            level_txt.TabIndex = 12;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(223, 353);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(94, 29);
            RegisterButton.TabIndex = 16;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // GoBackToLog
            // 
            GoBackToLog.Location = new Point(432, 353);
            GoBackToLog.Name = "GoBackToLog";
            GoBackToLog.Size = new Size(94, 29);
            GoBackToLog.TabIndex = 17;
            GoBackToLog.Text = "Login";
            GoBackToLog.UseVisualStyleBackColor = true;
            GoBackToLog.Click += GoBackToLog_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 28, 28);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(clostebtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 31);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(744, 3);
            button1.Name = "button1";
            button1.Size = new Size(53, 22);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // clostebtn
            // 
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
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(GoBackToLog);
            Controls.Add(RegisterButton);
            Controls.Add(label7);
            Controls.Add(faculty_txt);
            Controls.Add(label8);
            Controls.Add(level_txt);
            Controls.Add(label5);
            Controls.Add(phoneNo_txt);
            Controls.Add(label6);
            Controls.Add(email_txt);
            Controls.Add(label3);
            Controls.Add(password_txt);
            Controls.Add(label4);
            Controls.Add(Username_txt);
            Controls.Add(label2);
            Controls.Add(lName_txt);
            Controls.Add(label1);
            Controls.Add(Fname_txt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Fname_txt;
        private Label label1;
        private Label label2;
        private TextBox lName_txt;
        private Label label3;
        private TextBox password_txt;
        private Label label4;
        private TextBox Username_txt;
        private Label label5;
        private TextBox phoneNo_txt;
        private Label label6;
        private TextBox email_txt;
        private Label label7;
        private TextBox faculty_txt;
        private Label label8;
        private TextBox level_txt;
        private Button RegisterButton;
        private Button GoBackToLog;
        private Panel panel2;
        private Button button1;
        private Button clostebtn;
    }
}