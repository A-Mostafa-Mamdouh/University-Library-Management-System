namespace University_Library
{
    partial class Login
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
            LoginButton = new Button();
            Username_txt = new TextBox();
            password_txt = new TextBox();
            label1 = new Label();
            LinktoReg = new LinkLabel();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            clostebtn = new Button();
            checkBox1 = new CheckBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(339, 221);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Username_txt
            // 
            Username_txt.Location = new Point(317, 114);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(159, 27);
            Username_txt.TabIndex = 1;
            Username_txt.TextChanged += Username_txt_TextChanged;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(317, 159);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(159, 27);
            password_txt.TabIndex = 2;
            password_txt.UseSystemPasswordChar = true;
            password_txt.KeyPress += password_txt_KeyPress_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 121);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // LinktoReg
            // 
            LinktoReg.AutoSize = true;
            LinktoReg.Location = new Point(261, 253);
            LinktoReg.Name = "LinktoReg";
            LinktoReg.Size = new Size(249, 20);
            LinktoReg.TabIndex = 4;
            LinktoReg.TabStop = true;
            LinktoReg.Text = "Not a registered user? Register here.";
            LinktoReg.LinkClicked += LinktoReg_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 166);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
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
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(747, 6);
            button1.Name = "button1";
            button1.Size = new Size(53, 22);
            button1.TabIndex = 4;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(317, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(LinktoReg);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(Username_txt);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox Username_txt;
        private TextBox password_txt;
        private Label label1;
        private LinkLabel LinktoReg;
        private Label label2;
        private Panel panel2;
        private Button clostebtn;
        private Button button1;
        private CheckBox checkBox1;
    }
}
