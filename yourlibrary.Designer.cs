namespace University_Library
{
    partial class yourlibrary
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
            listBoxTitles = new ListBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            categorylabel = new Label();
            authorlabel = new Label();
            publicationlabel = new Label();
            isbnlabel = new Label();
            ratinglabel = new Label();
            typelabel = new Label();
            narratorlabel = new Label();
            durationlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Your Items";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // listBoxTitles
            // 
            listBoxTitles.Anchor = AnchorStyles.None;
            listBoxTitles.FormattingEnabled = true;
            listBoxTitles.Location = new Point(26, 53);
            listBoxTitles.Name = "listBoxTitles";
            listBoxTitles.Size = new Size(276, 264);
            listBoxTitles.TabIndex = 1;
            listBoxTitles.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(333, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(634, 18);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Properties";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(104, 356);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(537, 53);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Category";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(537, 96);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Author";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(537, 140);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 7;
            label5.Text = "Publication Year";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(537, 181);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 8;
            label6.Text = "ISBN";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(537, 224);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 9;
            label7.Text = "Rating";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(537, 257);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 10;
            label8.Text = "Type";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(537, 297);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 11;
            label9.Text = "Narrator";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(537, 335);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 12;
            label10.Text = "Duration";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // categorylabel
            // 
            categorylabel.Anchor = AnchorStyles.None;
            categorylabel.AutoSize = true;
            categorylabel.Location = new Point(670, 53);
            categorylabel.Name = "categorylabel";
            categorylabel.Size = new Size(58, 20);
            categorylabel.TabIndex = 13;
            categorylabel.Text = "label11";
            // 
            // authorlabel
            // 
            authorlabel.Anchor = AnchorStyles.None;
            authorlabel.AutoSize = true;
            authorlabel.Location = new Point(670, 96);
            authorlabel.Name = "authorlabel";
            authorlabel.Size = new Size(58, 20);
            authorlabel.TabIndex = 14;
            authorlabel.Text = "label12";
            // 
            // publicationlabel
            // 
            publicationlabel.Anchor = AnchorStyles.None;
            publicationlabel.AutoSize = true;
            publicationlabel.Location = new Point(670, 140);
            publicationlabel.Name = "publicationlabel";
            publicationlabel.Size = new Size(58, 20);
            publicationlabel.TabIndex = 15;
            publicationlabel.Text = "label13";
            // 
            // isbnlabel
            // 
            isbnlabel.Anchor = AnchorStyles.None;
            isbnlabel.AutoSize = true;
            isbnlabel.Location = new Point(670, 181);
            isbnlabel.Name = "isbnlabel";
            isbnlabel.Size = new Size(58, 20);
            isbnlabel.TabIndex = 16;
            isbnlabel.Text = "label14";
            // 
            // ratinglabel
            // 
            ratinglabel.Anchor = AnchorStyles.None;
            ratinglabel.AutoSize = true;
            ratinglabel.Location = new Point(670, 224);
            ratinglabel.Name = "ratinglabel";
            ratinglabel.Size = new Size(58, 20);
            ratinglabel.TabIndex = 17;
            ratinglabel.Text = "label15";
            // 
            // typelabel
            // 
            typelabel.Anchor = AnchorStyles.None;
            typelabel.AutoSize = true;
            typelabel.Location = new Point(670, 257);
            typelabel.Name = "typelabel";
            typelabel.Size = new Size(58, 20);
            typelabel.TabIndex = 18;
            typelabel.Text = "label16";
            // 
            // narratorlabel
            // 
            narratorlabel.Anchor = AnchorStyles.None;
            narratorlabel.AutoSize = true;
            narratorlabel.Location = new Point(670, 297);
            narratorlabel.Name = "narratorlabel";
            narratorlabel.Size = new Size(58, 20);
            narratorlabel.TabIndex = 19;
            narratorlabel.Text = "label17";
            // 
            // durationlabel
            // 
            durationlabel.Anchor = AnchorStyles.None;
            durationlabel.AutoSize = true;
            durationlabel.Location = new Point(670, 335);
            durationlabel.Name = "durationlabel";
            durationlabel.Size = new Size(58, 20);
            durationlabel.TabIndex = 20;
            durationlabel.Text = "label18";
            // 
            // yourlibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(durationlabel);
            Controls.Add(narratorlabel);
            Controls.Add(typelabel);
            Controls.Add(ratinglabel);
            Controls.Add(isbnlabel);
            Controls.Add(publicationlabel);
            Controls.Add(authorlabel);
            Controls.Add(categorylabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxTitles);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "yourlibrary";
            Text = "library";
            Load += yourlibrary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxTitles;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label categorylabel;
        private Label authorlabel;
        private Label publicationlabel;
        private Label isbnlabel;
        private Label ratinglabel;
        private Label typelabel;
        private Label narratorlabel;
        private Label durationlabel;
    }
}