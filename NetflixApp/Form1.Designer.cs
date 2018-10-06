namespace NetflixApp
{
    partial class Form1
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
            this.movButton = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.textMovieRating = new System.Windows.Forms.TextBox();
            this.revButton = new System.Windows.Forms.Button();
            this.lstReviews = new System.Windows.Forms.ListBox();
            this.eachRating = new System.Windows.Forms.Button();
            this.lstEachRating = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstUserName = new System.Windows.Forms.ListBox();
            this.cmdUserName = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cndUserReview = new System.Windows.Forms.Button();
            this.lstReview1 = new System.Windows.Forms.ListBox();
            this.txtInsertBox = new System.Windows.Forms.TextBox();
            this.addReview = new System.Windows.Forms.Button();
            this.lstTopNAverageRattingMovies = new System.Windows.Forms.ListBox();
            this.NValue = new System.Windows.Forms.TextBox();
            this.TopNButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movButton
            // 
            this.movButton.Location = new System.Drawing.Point(285, 24);
            this.movButton.Name = "movButton";
            this.movButton.Size = new System.Drawing.Size(75, 23);
            this.movButton.TabIndex = 0;
            this.movButton.Text = "Movies";
            this.movButton.UseVisualStyleBackColor = true;
            this.movButton.Click += new System.EventHandler(this.movButton_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(153, 376);
            this.txtDatabase.Multiline = true;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(215, 20);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.Text = "netflix-200k.mdf";
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.Location = new System.Drawing.Point(208, 56);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(160, 303);
            this.lstMovies.TabIndex = 2;
            this.lstMovies.SelectedIndexChanged += new System.EventHandler(this.lstMovies_SelectedIndexChanged);
            // 
            // textMovieID
            // 
            this.textMovieID.Location = new System.Drawing.Point(102, 56);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(100, 20);
            this.textMovieID.TabIndex = 3;
            // 
            // textMovieRating
            // 
            this.textMovieRating.Location = new System.Drawing.Point(102, 82);
            this.textMovieRating.Name = "textMovieRating";
            this.textMovieRating.Size = new System.Drawing.Size(100, 20);
            this.textMovieRating.TabIndex = 4;
            this.textMovieRating.TextChanged += new System.EventHandler(this.textMovieRating_TextChanged);
            // 
            // revButton
            // 
            this.revButton.Location = new System.Drawing.Point(467, 20);
            this.revButton.Name = "revButton";
            this.revButton.Size = new System.Drawing.Size(51, 30);
            this.revButton.TabIndex = 5;
            this.revButton.Text = "Review";
            this.revButton.UseVisualStyleBackColor = true;
            this.revButton.Click += new System.EventHandler(this.revButton_Click);
            // 
            // lstReviews
            // 
            this.lstReviews.FormattingEnabled = true;
            this.lstReviews.Location = new System.Drawing.Point(374, 56);
            this.lstReviews.Name = "lstReviews";
            this.lstReviews.Size = new System.Drawing.Size(144, 303);
            this.lstReviews.TabIndex = 6;
            this.lstReviews.SelectedIndexChanged += new System.EventHandler(this.lstReviews_SelectedIndexChanged);
            // 
            // eachRating
            // 
            this.eachRating.Location = new System.Drawing.Point(613, 194);
            this.eachRating.Name = "eachRating";
            this.eachRating.Size = new System.Drawing.Size(78, 25);
            this.eachRating.TabIndex = 7;
            this.eachRating.Text = "Each Rating";
            this.eachRating.UseVisualStyleBackColor = true;
            this.eachRating.Click += new System.EventHandler(this.eachRating_Click);
            // 
            // lstEachRating
            // 
            this.lstEachRating.FormattingEnabled = true;
            this.lstEachRating.Location = new System.Drawing.Point(524, 225);
            this.lstEachRating.Name = "lstEachRating";
            this.lstEachRating.Size = new System.Drawing.Size(121, 134);
            this.lstEachRating.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movie ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Avg Rating:";
            // 
            // lstUserName
            // 
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(768, 53);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(120, 160);
            this.lstUserName.TabIndex = 11;
            this.lstUserName.SelectedIndexChanged += new System.EventHandler(this.lstUserName_SelectedIndexChanged);
            // 
            // cmdUserName
            // 
            this.cmdUserName.Location = new System.Drawing.Point(856, 19);
            this.cmdUserName.Name = "cmdUserName";
            this.cmdUserName.Size = new System.Drawing.Size(75, 23);
            this.cmdUserName.TabIndex = 12;
            this.cmdUserName.Text = "User Name";
            this.cmdUserName.UseVisualStyleBackColor = true;
            this.cmdUserName.Click += new System.EventHandler(this.cmdUserName_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(662, 56);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 13;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(662, 75);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(100, 20);
            this.txtOccupation.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Occupation:";
            // 
            // cndUserReview
            // 
            this.cndUserReview.Location = new System.Drawing.Point(1065, 19);
            this.cndUserReview.Name = "cndUserReview";
            this.cndUserReview.Size = new System.Drawing.Size(108, 23);
            this.cndUserReview.TabIndex = 17;
            this.cndUserReview.Text = "User Review";
            this.cndUserReview.UseVisualStyleBackColor = true;
            this.cndUserReview.Click += new System.EventHandler(this.cndUserReview_Click);
            // 
            // lstReview1
            // 
            this.lstReview1.FormattingEnabled = true;
            this.lstReview1.Location = new System.Drawing.Point(940, 49);
            this.lstReview1.Name = "lstReview1";
            this.lstReview1.Size = new System.Drawing.Size(299, 160);
            this.lstReview1.TabIndex = 18;
            // 
            // txtInsertBox
            // 
            this.txtInsertBox.Location = new System.Drawing.Point(1026, 218);
            this.txtInsertBox.Name = "txtInsertBox";
            this.txtInsertBox.Size = new System.Drawing.Size(100, 20);
            this.txtInsertBox.TabIndex = 19;
            this.txtInsertBox.TextChanged += new System.EventHandler(this.txtInsertBox_TextChanged);
            // 
            // addReview
            // 
            this.addReview.Location = new System.Drawing.Point(1132, 215);
            this.addReview.Name = "addReview";
            this.addReview.Size = new System.Drawing.Size(75, 23);
            this.addReview.TabIndex = 20;
            this.addReview.Text = "ADD";
            this.addReview.UseVisualStyleBackColor = true;
            this.addReview.Click += new System.EventHandler(this.addReview_Click);
            // 
            // lstTopNAverageRattingMovies
            // 
            this.lstTopNAverageRattingMovies.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lstTopNAverageRattingMovies.FormattingEnabled = true;
            this.lstTopNAverageRattingMovies.Location = new System.Drawing.Point(881, 270);
            this.lstTopNAverageRattingMovies.Name = "lstTopNAverageRattingMovies";
            this.lstTopNAverageRattingMovies.Size = new System.Drawing.Size(358, 160);
            this.lstTopNAverageRattingMovies.TabIndex = 21;
            // 
            // NValue
            // 
            this.NValue.Location = new System.Drawing.Point(803, 270);
            this.NValue.Name = "NValue";
            this.NValue.Size = new System.Drawing.Size(54, 20);
            this.NValue.TabIndex = 22;
            // 
            // TopNButton
            // 
            this.TopNButton.Location = new System.Drawing.Point(745, 296);
            this.TopNButton.Name = "TopNButton";
            this.TopNButton.Size = new System.Drawing.Size(112, 23);
            this.TopNButton.TabIndex = 23;
            this.TopNButton.Text = "Top N Reviews";
            this.TopNButton.UseVisualStyleBackColor = true;
            this.TopNButton.Click += new System.EventHandler(this.TopNButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "List Of Movies:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Review oF Movies:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Each Rating List:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(752, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "List Of UserNames:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(956, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "List of User Reviews:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(909, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Insert Review (1 to 5):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "File Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(721, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Top-nth value:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(909, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(265, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "(Note: Select Movie and User and then insert Review:)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Tejash Contractor GUI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1270, 472);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TopNButton);
            this.Controls.Add(this.NValue);
            this.Controls.Add(this.lstTopNAverageRattingMovies);
            this.Controls.Add(this.addReview);
            this.Controls.Add(this.txtInsertBox);
            this.Controls.Add(this.lstReview1);
            this.Controls.Add(this.cndUserReview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.cmdUserName);
            this.Controls.Add(this.lstUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEachRating);
            this.Controls.Add(this.eachRating);
            this.Controls.Add(this.lstReviews);
            this.Controls.Add(this.revButton);
            this.Controls.Add(this.textMovieRating);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.movButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button movButton;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.TextBox textMovieID;
        private System.Windows.Forms.TextBox textMovieRating;
        private System.Windows.Forms.Button revButton;
        private System.Windows.Forms.ListBox lstReviews;
        private System.Windows.Forms.Button eachRating;
        private System.Windows.Forms.ListBox lstEachRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstUserName;
        private System.Windows.Forms.Button cmdUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cndUserReview;
        private System.Windows.Forms.ListBox lstReview1;
        private System.Windows.Forms.TextBox txtInsertBox;
        private System.Windows.Forms.Button addReview;
        private System.Windows.Forms.ListBox lstTopNAverageRattingMovies;
        private System.Windows.Forms.TextBox NValue;
        private System.Windows.Forms.Button TopNButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

