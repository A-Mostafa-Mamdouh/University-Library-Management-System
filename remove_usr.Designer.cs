namespace University_Library
{
    partial class remove_usr
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
            user_list = new ListBox();
            delete_usr = new Button();
            label7 = new Label();
            faculty_txt = new TextBox();
            label8 = new Label();
            level_txt = new TextBox();
            label5 = new Label();
            phoneNo_txt = new TextBox();
            label6 = new Label();
            email_txt = new TextBox();
            label3 = new Label();
            password_txt = new TextBox();
            label4 = new Label();
            Username_txt = new TextBox();
            label2 = new Label();
            lName_txt = new TextBox();
            label1 = new Label();
            Fname_txt = new TextBox();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // user_list
            // 
            user_list.Anchor = AnchorStyles.None;
            user_list.FormattingEnabled = true;
            user_list.Location = new Point(53, 48);
            user_list.Name = "user_list";
            user_list.Size = new Size(179, 204);
            user_list.TabIndex = 0;
            user_list.SelectedIndexChanged += user_list_SelectedIndexChanged;
            // 
            // delete_usr
            // 
            delete_usr.Anchor = AnchorStyles.None;
            delete_usr.Location = new Point(69, 300);
            delete_usr.Name = "delete_usr";
            delete_usr.Size = new Size(94, 29);
            delete_usr.TabIndex = 1;
            delete_usr.Text = "Delete";
            delete_usr.UseVisualStyleBackColor = true;
            delete_usr.Click += delete_usr_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(268, 255);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 49;
            label7.Text = "Faculty";
            // 
            // faculty_txt
            // 
            faculty_txt.Anchor = AnchorStyles.None;
            faculty_txt.Location = new Point(355, 252);
            faculty_txt.Name = "faculty_txt";
            faculty_txt.Size = new Size(160, 27);
            faculty_txt.TabIndex = 48;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(268, 226);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 47;
            label8.Text = "Level";
            // 
            // level_txt
            // 
            level_txt.Anchor = AnchorStyles.None;
            level_txt.Location = new Point(355, 219);
            level_txt.Name = "level_txt";
            level_txt.Size = new Size(160, 27);
            level_txt.TabIndex = 46;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(268, 193);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 45;
            label5.Text = "Phone no";
            // 
            // phoneNo_txt
            // 
            phoneNo_txt.Anchor = AnchorStyles.None;
            phoneNo_txt.Location = new Point(355, 186);
            phoneNo_txt.Name = "phoneNo_txt";
            phoneNo_txt.Size = new Size(160, 27);
            phoneNo_txt.TabIndex = 44;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(268, 160);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 43;
            label6.Text = "Email";
            // 
            // email_txt
            // 
            email_txt.Anchor = AnchorStyles.None;
            email_txt.Location = new Point(355, 153);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(160, 27);
            email_txt.TabIndex = 42;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(268, 127);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 41;
            label3.Text = "Password";
            // 
            // password_txt
            // 
            password_txt.Anchor = AnchorStyles.None;
            password_txt.Location = new Point(355, 120);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(160, 27);
            password_txt.TabIndex = 40;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(268, 94);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 39;
            label4.Text = "UserName";
            // 
            // Username_txt
            // 
            Username_txt.Anchor = AnchorStyles.None;
            Username_txt.Location = new Point(355, 87);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(160, 27);
            Username_txt.TabIndex = 38;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(268, 61);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 37;
            label2.Text = "LastName";
            // 
            // lName_txt
            // 
            lName_txt.Anchor = AnchorStyles.None;
            lName_txt.Location = new Point(355, 54);
            lName_txt.Name = "lName_txt";
            lName_txt.Size = new Size(160, 27);
            lName_txt.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(268, 28);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 35;
            label1.Text = "FirstName";
            // 
            // Fname_txt
            // 
            Fname_txt.Anchor = AnchorStyles.None;
            Fname_txt.Location = new Point(355, 21);
            Fname_txt.Name = "Fname_txt";
            Fname_txt.Size = new Size(160, 27);
            Fname_txt.TabIndex = 34;
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.None;
            UpdateButton.Location = new Point(383, 300);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 50;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // remove_usr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(UpdateButton);
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
            Controls.Add(delete_usr);
            Controls.Add(user_list);
            FormBorderStyle = FormBorderStyle.None;
            Name = "remove_usr";
            Text = "remove_usr";
            Load += remove_usr_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox user_list;
        private Button delete_usr;
        private Label label7;
        private TextBox faculty_txt;
        private Label label8;
        private TextBox level_txt;
        private Label label5;
        private TextBox phoneNo_txt;
        private Label label6;
        private TextBox email_txt;
        private Label label3;
        private TextBox password_txt;
        private Label label4;
        private TextBox Username_txt;
        private Label label2;
        private TextBox lName_txt;
        private Label label1;
        private TextBox Fname_txt;
        private Button UpdateButton;
    }
}