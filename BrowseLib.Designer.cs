namespace University_Library
{
    partial class BrowseLib
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
            label1 = new Label();
            comboBoxTitles = new ComboBox();
            radioButtonAudio = new RadioButton();
            radioButtonNormal = new RadioButton();
            radioButtonBoth = new RadioButton();
            comboBoxCategories = new ComboBox();
            textBoxTitle = new TextBox();
            textBoxISBN = new TextBox();
            textBoxAuthor = new TextBox();
            SearchBtn = new Button();
            ratingNumBox = new NumericUpDown();
            ResetFilterBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CoverIMG = new PictureBox();
            Add_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)ratingNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoverIMG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(50, -5);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Books";
            // 
            // comboBoxTitles
            // 
            comboBoxTitles.Anchor = AnchorStyles.None;
            comboBoxTitles.FormattingEnabled = true;
            comboBoxTitles.Location = new Point(50, 33);
            comboBoxTitles.Name = "comboBoxTitles";
            comboBoxTitles.Size = new Size(209, 28);
            comboBoxTitles.TabIndex = 1;
            comboBoxTitles.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButtonAudio
            // 
            radioButtonAudio.Anchor = AnchorStyles.None;
            radioButtonAudio.AutoSize = true;
            radioButtonAudio.Location = new Point(50, 96);
            radioButtonAudio.Name = "radioButtonAudio";
            radioButtonAudio.Size = new Size(70, 24);
            radioButtonAudio.TabIndex = 2;
            radioButtonAudio.TabStop = true;
            radioButtonAudio.Text = "Audio";
            radioButtonAudio.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            radioButtonNormal.Anchor = AnchorStyles.None;
            radioButtonNormal.AutoSize = true;
            radioButtonNormal.Location = new Point(50, 153);
            radioButtonNormal.Name = "radioButtonNormal";
            radioButtonNormal.Size = new Size(80, 24);
            radioButtonNormal.TabIndex = 3;
            radioButtonNormal.TabStop = true;
            radioButtonNormal.Text = "Normal";
            radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonBoth
            // 
            radioButtonBoth.Anchor = AnchorStyles.None;
            radioButtonBoth.AutoSize = true;
            radioButtonBoth.Location = new Point(50, 204);
            radioButtonBoth.Name = "radioButtonBoth";
            radioButtonBoth.Size = new Size(61, 24);
            radioButtonBoth.TabIndex = 4;
            radioButtonBoth.TabStop = true;
            radioButtonBoth.Text = "Both";
            radioButtonBoth.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.Anchor = AnchorStyles.None;
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(295, 33);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(209, 28);
            comboBoxCategories.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.None;
            textBoxTitle.Location = new Point(295, 95);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 6;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Anchor = AnchorStyles.None;
            textBoxISBN.Location = new Point(295, 150);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(125, 27);
            textBoxISBN.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Anchor = AnchorStyles.None;
            textBoxAuthor.Location = new Point(295, 203);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(125, 27);
            textBoxAuthor.TabIndex = 8;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.None;
            SearchBtn.Location = new Point(50, 281);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(94, 29);
            SearchBtn.TabIndex = 9;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ratingNumBox
            // 
            ratingNumBox.Anchor = AnchorStyles.None;
            ratingNumBox.DecimalPlaces = 1;
            ratingNumBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ratingNumBox.Location = new Point(540, 34);
            ratingNumBox.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ratingNumBox.Name = "ratingNumBox";
            ratingNumBox.Size = new Size(150, 27);
            ratingNumBox.TabIndex = 10;
            ratingNumBox.ValueChanged += ratingNumBox_ValueChanged;
            // 
            // ResetFilterBtn
            // 
            ResetFilterBtn.Anchor = AnchorStyles.None;
            ResetFilterBtn.Location = new Point(50, 335);
            ResetFilterBtn.Name = "ResetFilterBtn";
            ResetFilterBtn.Size = new Size(94, 29);
            ResetFilterBtn.TabIndex = 11;
            ResetFilterBtn.Text = "Reset";
            ResetFilterBtn.UseVisualStyleBackColor = true;
            ResetFilterBtn.Click += ResetFilterBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(234, 102);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 12;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(234, 157);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 13;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(234, 210);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 14;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(295, -5);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(540, -5);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 16;
            label6.Text = "Min. Rating";
            // 
            // CoverIMG
            // 
            CoverIMG.Anchor = AnchorStyles.None;
            CoverIMG.Location = new Point(467, 67);
            CoverIMG.Name = "CoverIMG";
            CoverIMG.Size = new Size(288, 349);
            CoverIMG.SizeMode = PictureBoxSizeMode.StretchImage;
            CoverIMG.TabIndex = 17;
            CoverIMG.TabStop = false;
            CoverIMG.Click += CoverIMG_Click;
            // 
            // Add_btn
            // 
            Add_btn.Anchor = AnchorStyles.None;
            Add_btn.Location = new Point(295, 281);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(94, 29);
            Add_btn.TabIndex = 18;
            Add_btn.Text = "Add Item";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // BrowseLib
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_btn);
            Controls.Add(CoverIMG);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ResetFilterBtn);
            Controls.Add(ratingNumBox);
            Controls.Add(SearchBtn);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxISBN);
            Controls.Add(textBoxTitle);
            Controls.Add(comboBoxCategories);
            Controls.Add(radioButtonBoth);
            Controls.Add(radioButtonNormal);
            Controls.Add(radioButtonAudio);
            Controls.Add(comboBoxTitles);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BrowseLib";
            Text = "BrowseLib";
            Load += BrowseLib_Load;
            ((System.ComponentModel.ISupportInitialize)ratingNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoverIMG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxTitles;
        private RadioButton radioButtonAudio;
        private RadioButton radioButtonNormal;
        private RadioButton radioButtonBoth;
        private ComboBox comboBoxCategories;
        private TextBox textBoxTitle;
        private TextBox textBoxISBN;
        private TextBox textBoxAuthor;
        private Button SearchBtn;
        private NumericUpDown ratingNumBox;
        private Button ResetFilterBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox CoverIMG;
        private Button Add_btn;
    }
}