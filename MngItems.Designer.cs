namespace University_Library
{
    partial class MngItems
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
            isbn_txt = new TextBox();
            title_txt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            add_update_btn = new Button();
            RemoveBookBtn = new Button();
            BookList = new ListBox();
            add_radio_btn = new RadioButton();
            update_radio_btn = new RadioButton();
            category_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            puc_year = new NumericUpDown();
            label3 = new Label();
            author_combo_box = new ComboBox();
            label6 = new Label();
            isaudio_check = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            duration_txt = new TextBox();
            narrator_txt = new TextBox();
            label9 = new Label();
            cover_url_txt = new TextBox();
            open_file_btn = new Button();
            cover_image = new PictureBox();
            rating_box = new NumericUpDown();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)puc_year).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cover_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rating_box).BeginInit();
            SuspendLayout();
            // 
            // isbn_txt
            // 
            isbn_txt.Anchor = AnchorStyles.None;
            isbn_txt.Location = new Point(406, 56);
            isbn_txt.Name = "isbn_txt";
            isbn_txt.Size = new Size(151, 27);
            isbn_txt.TabIndex = 29;
            // 
            // title_txt
            // 
            title_txt.Anchor = AnchorStyles.None;
            title_txt.Location = new Point(406, 12);
            title_txt.Name = "title_txt";
            title_txt.Size = new Size(151, 27);
            title_txt.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(241, 63);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 27;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(241, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 26;
            label4.Text = "Title";
            // 
            // add_update_btn
            // 
            add_update_btn.Anchor = AnchorStyles.None;
            add_update_btn.Location = new Point(612, 137);
            add_update_btn.Name = "add_update_btn";
            add_update_btn.Size = new Size(124, 29);
            add_update_btn.TabIndex = 25;
            add_update_btn.Text = "Add/Update";
            add_update_btn.UseVisualStyleBackColor = true;
            add_update_btn.Click += add_update_btn_Click;
            // 
            // RemoveBookBtn
            // 
            RemoveBookBtn.Anchor = AnchorStyles.None;
            RemoveBookBtn.Location = new Point(68, 280);
            RemoveBookBtn.Name = "RemoveBookBtn";
            RemoveBookBtn.Size = new Size(94, 29);
            RemoveBookBtn.TabIndex = 24;
            RemoveBookBtn.Text = "Remove";
            RemoveBookBtn.UseVisualStyleBackColor = true;
            RemoveBookBtn.Click += RemoveBookBtn_Click;
            // 
            // BookList
            // 
            BookList.Anchor = AnchorStyles.None;
            BookList.FormattingEnabled = true;
            BookList.Location = new Point(12, 12);
            BookList.Name = "BookList";
            BookList.Size = new Size(210, 244);
            BookList.TabIndex = 19;
            BookList.SelectedIndexChanged += BookList_SelectedIndexChanged_1;
            // 
            // add_radio_btn
            // 
            add_radio_btn.Anchor = AnchorStyles.None;
            add_radio_btn.AutoSize = true;
            add_radio_btn.Location = new Point(612, 65);
            add_radio_btn.Name = "add_radio_btn";
            add_radio_btn.Size = new Size(58, 24);
            add_radio_btn.TabIndex = 18;
            add_radio_btn.TabStop = true;
            add_radio_btn.Text = "Add";
            add_radio_btn.UseVisualStyleBackColor = true;
            // 
            // update_radio_btn
            // 
            update_radio_btn.Anchor = AnchorStyles.None;
            update_radio_btn.AutoSize = true;
            update_radio_btn.Location = new Point(612, 12);
            update_radio_btn.Name = "update_radio_btn";
            update_radio_btn.Size = new Size(79, 24);
            update_radio_btn.TabIndex = 17;
            update_radio_btn.TabStop = true;
            update_radio_btn.Text = "Update";
            update_radio_btn.UseVisualStyleBackColor = true;
            // 
            // category_txt
            // 
            category_txt.Anchor = AnchorStyles.None;
            category_txt.Location = new Point(406, 174);
            category_txt.Name = "category_txt";
            category_txt.Size = new Size(151, 27);
            category_txt.TabIndex = 33;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(241, 181);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 31;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(241, 103);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 30;
            label2.Text = "Publication Year";
            // 
            // puc_year
            // 
            puc_year.Anchor = AnchorStyles.None;
            puc_year.Location = new Point(406, 96);
            puc_year.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            puc_year.Name = "puc_year";
            puc_year.Size = new Size(151, 27);
            puc_year.TabIndex = 34;
            puc_year.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(241, 223);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 35;
            label3.Text = "Author";
            // 
            // author_combo_box
            // 
            author_combo_box.Anchor = AnchorStyles.None;
            author_combo_box.FormattingEnabled = true;
            author_combo_box.Location = new Point(406, 215);
            author_combo_box.Name = "author_combo_box";
            author_combo_box.Size = new Size(151, 28);
            author_combo_box.TabIndex = 36;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(241, 259);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 37;
            label6.Text = "Is Audio";
            // 
            // isaudio_check
            // 
            isaudio_check.Anchor = AnchorStyles.None;
            isaudio_check.AutoSize = true;
            isaudio_check.Location = new Point(406, 259);
            isaudio_check.Name = "isaudio_check";
            isaudio_check.Size = new Size(18, 17);
            isaudio_check.TabIndex = 38;
            isaudio_check.UseVisualStyleBackColor = true;
            isaudio_check.CheckedChanged += this.isaudio_check_CheckedChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(241, 339);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 40;
            label7.Text = "Narrator";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(241, 298);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 39;
            label8.Text = "Duration";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // duration_txt
            // 
            duration_txt.Anchor = AnchorStyles.None;
            duration_txt.Location = new Point(406, 298);
            duration_txt.Name = "duration_txt";
            duration_txt.Size = new Size(151, 27);
            duration_txt.TabIndex = 41;
            // 
            // narrator_txt
            // 
            narrator_txt.Anchor = AnchorStyles.None;
            narrator_txt.Location = new Point(406, 332);
            narrator_txt.Name = "narrator_txt";
            narrator_txt.Size = new Size(151, 27);
            narrator_txt.TabIndex = 42;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(241, 387);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 43;
            label9.Text = "Cover Link/Path";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // cover_url_txt
            // 
            cover_url_txt.Anchor = AnchorStyles.None;
            cover_url_txt.Location = new Point(406, 380);
            cover_url_txt.Name = "cover_url_txt";
            cover_url_txt.Size = new Size(151, 27);
            cover_url_txt.TabIndex = 44;
            // 
            // open_file_btn
            // 
            open_file_btn.Anchor = AnchorStyles.None;
            open_file_btn.Location = new Point(241, 410);
            open_file_btn.Name = "open_file_btn";
            open_file_btn.Size = new Size(94, 29);
            open_file_btn.TabIndex = 45;
            open_file_btn.Text = "Select file";
            open_file_btn.UseVisualStyleBackColor = true;
            open_file_btn.Click += open_file_btn_Click;
            // 
            // cover_image
            // 
            cover_image.Anchor = AnchorStyles.None;
            cover_image.Location = new Point(611, 194);
            cover_image.Name = "cover_image";
            cover_image.Size = new Size(177, 245);
            cover_image.SizeMode = PictureBoxSizeMode.StretchImage;
            cover_image.TabIndex = 46;
            cover_image.TabStop = false;
            // 
            // rating_box
            // 
            rating_box.Anchor = AnchorStyles.None;
            rating_box.DecimalPlaces = 1;
            rating_box.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            rating_box.Location = new Point(406, 136);
            rating_box.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            rating_box.Name = "rating_box";
            rating_box.Size = new Size(151, 27);
            rating_box.TabIndex = 48;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(241, 141);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 47;
            label10.Text = "Rating";
            // 
            // MngItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rating_box);
            Controls.Add(label10);
            Controls.Add(cover_image);
            Controls.Add(open_file_btn);
            Controls.Add(cover_url_txt);
            Controls.Add(label9);
            Controls.Add(narrator_txt);
            Controls.Add(duration_txt);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(isaudio_check);
            Controls.Add(label6);
            Controls.Add(author_combo_box);
            Controls.Add(label3);
            Controls.Add(puc_year);
            Controls.Add(category_txt);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(isbn_txt);
            Controls.Add(title_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(add_update_btn);
            Controls.Add(RemoveBookBtn);
            Controls.Add(BookList);
            Controls.Add(add_radio_btn);
            Controls.Add(update_radio_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MngItems";
            Text = "BrowseLibAdmin";
            Load += MngItems_Load_2;
            ((System.ComponentModel.ISupportInitialize)puc_year).EndInit();
            ((System.ComponentModel.ISupportInitialize)cover_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)rating_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox isbn_txt;
        private TextBox title_txt;
        private Label label5;
        private Label label4;
        private Button add_update_btn;
        private Button RemoveBookBtn;
        private ListBox BookList;
        private RadioButton add_radio_btn;
        private RadioButton update_radio_btn;
        private TextBox category_txt;
        private Label label1;
        private Label label2;
        private NumericUpDown puc_year;
        private Label label3;
        private ComboBox author_combo_box;
        private Label label6;
        private CheckBox isaudio_check;
        private Label label7;
        private Label label8;
        private TextBox duration_txt;
        private TextBox narrator_txt;
        private Label label9;
        private TextBox cover_url_txt;
        private Button open_file_btn;
        private PictureBox cover_image;
        private NumericUpDown rating_box;
        private Label label10;
    }
}