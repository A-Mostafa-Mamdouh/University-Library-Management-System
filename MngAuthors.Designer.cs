namespace University_Library
{
    partial class MngAuthors
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
            update_radio_btn = new RadioButton();
            add_radio_btn = new RadioButton();
            AuthorList = new ListBox();
            label2 = new Label();
            label3 = new Label();
            publisher_lbl = new Label();
            noOfItemsLbl = new Label();
            RemoveAuthorBtn = new Button();
            add_update_btn = new Button();
            label4 = new Label();
            label5 = new Label();
            author_name_txt = new TextBox();
            publisher_name_txt = new TextBox();
            SuspendLayout();
            // 
            // update_radio_btn
            // 
            update_radio_btn.Anchor = AnchorStyles.None;
            update_radio_btn.AutoSize = true;
            update_radio_btn.Location = new Point(355, 195);
            update_radio_btn.Name = "update_radio_btn";
            update_radio_btn.Size = new Size(79, 24);
            update_radio_btn.TabIndex = 3;
            update_radio_btn.TabStop = true;
            update_radio_btn.Text = "Update";
            update_radio_btn.UseVisualStyleBackColor = true;
            // 
            // add_radio_btn
            // 
            add_radio_btn.Anchor = AnchorStyles.None;
            add_radio_btn.AutoSize = true;
            add_radio_btn.Location = new Point(355, 244);
            add_radio_btn.Name = "add_radio_btn";
            add_radio_btn.Size = new Size(58, 24);
            add_radio_btn.TabIndex = 4;
            add_radio_btn.TabStop = true;
            add_radio_btn.Text = "Add";
            add_radio_btn.UseVisualStyleBackColor = true;
            // 
            // AuthorList
            // 
            AuthorList.Anchor = AnchorStyles.None;
            AuthorList.FormattingEnabled = true;
            AuthorList.Location = new Point(302, 12);
            AuthorList.Name = "AuthorList";
            AuthorList.Size = new Size(160, 144);
            AuthorList.TabIndex = 6;
            AuthorList.SelectedIndexChanged += AuthorList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(24, 352);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 7;
            label2.Text = "Publisher Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(24, 398);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "No Of items";
            // 
            // publisher_lbl
            // 
            publisher_lbl.Anchor = AnchorStyles.None;
            publisher_lbl.AutoSize = true;
            publisher_lbl.Location = new Point(192, 352);
            publisher_lbl.Name = "publisher_lbl";
            publisher_lbl.Size = new Size(0, 20);
            publisher_lbl.TabIndex = 9;
            // 
            // noOfItemsLbl
            // 
            noOfItemsLbl.Anchor = AnchorStyles.None;
            noOfItemsLbl.AutoSize = true;
            noOfItemsLbl.Location = new Point(192, 398);
            noOfItemsLbl.Name = "noOfItemsLbl";
            noOfItemsLbl.Size = new Size(0, 20);
            noOfItemsLbl.TabIndex = 10;
            // 
            // RemoveAuthorBtn
            // 
            RemoveAuthorBtn.Anchor = AnchorStyles.None;
            RemoveAuthorBtn.Location = new Point(24, 301);
            RemoveAuthorBtn.Name = "RemoveAuthorBtn";
            RemoveAuthorBtn.Size = new Size(94, 29);
            RemoveAuthorBtn.TabIndex = 11;
            RemoveAuthorBtn.Text = "Remove";
            RemoveAuthorBtn.UseVisualStyleBackColor = true;
            RemoveAuthorBtn.Click += RemoveAuthorBtn_Click;
            // 
            // add_update_btn
            // 
            add_update_btn.Anchor = AnchorStyles.None;
            add_update_btn.Location = new Point(355, 301);
            add_update_btn.Name = "add_update_btn";
            add_update_btn.Size = new Size(124, 29);
            add_update_btn.TabIndex = 12;
            add_update_btn.Text = "Add/Update";
            add_update_btn.UseVisualStyleBackColor = true;
            add_update_btn.Click += add_update_btn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(24, 195);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 13;
            label4.Text = "New Author Name";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(24, 250);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 14;
            label5.Text = "New Publisher Name";
            // 
            // author_name_txt
            // 
            author_name_txt.Anchor = AnchorStyles.None;
            author_name_txt.Location = new Point(192, 192);
            author_name_txt.Name = "author_name_txt";
            author_name_txt.Size = new Size(125, 27);
            author_name_txt.TabIndex = 15;
            author_name_txt.TextChanged += author_name_txt_TextChanged;
            // 
            // publisher_name_txt
            // 
            publisher_name_txt.Anchor = AnchorStyles.None;
            publisher_name_txt.Location = new Point(192, 243);
            publisher_name_txt.Name = "publisher_name_txt";
            publisher_name_txt.Size = new Size(125, 27);
            publisher_name_txt.TabIndex = 16;
            // 
            // Mngitems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(publisher_name_txt);
            Controls.Add(author_name_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(add_update_btn);
            Controls.Add(RemoveAuthorBtn);
            Controls.Add(noOfItemsLbl);
            Controls.Add(publisher_lbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AuthorList);
            Controls.Add(add_radio_btn);
            Controls.Add(update_radio_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mngitems";
            Text = "Mngitems";
            Load += Mngitems_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton update_radio_btn;
        private RadioButton add_radio_btn;
        private ListBox AuthorList;
        private Label label2;
        private Label label3;
        private Label publisher_lbl;
        private Label noOfItemsLbl;
        private Button RemoveAuthorBtn;
        private Button add_update_btn;
        private Label label4;
        private Label label5;
        private TextBox author_name_txt;
        private TextBox publisher_name_txt;
    }
}