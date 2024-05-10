namespace Programming.View.Panels
{
    partial class MoviesInfo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MoviesGroupBox = new GroupBox();
            MovieFindButton = new Button();
            MovieGenreTextBox = new TextBox();
            label13 = new Label();
            MovieTitleTextBox = new TextBox();
            label12 = new Label();
            MovieRatingTextBox = new TextBox();
            label11 = new Label();
            MovieReleaseYearTextBox = new TextBox();
            label10 = new Label();
            MovieDurationTextBox = new TextBox();
            label9 = new Label();
            MovieListBox = new ListBox();
            MoviesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MoviesGroupBox
            // 
            MoviesGroupBox.Controls.Add(MovieFindButton);
            MoviesGroupBox.Controls.Add(MovieGenreTextBox);
            MoviesGroupBox.Controls.Add(label13);
            MoviesGroupBox.Controls.Add(MovieTitleTextBox);
            MoviesGroupBox.Controls.Add(label12);
            MoviesGroupBox.Controls.Add(MovieRatingTextBox);
            MoviesGroupBox.Controls.Add(label11);
            MoviesGroupBox.Controls.Add(MovieReleaseYearTextBox);
            MoviesGroupBox.Controls.Add(label10);
            MoviesGroupBox.Controls.Add(MovieDurationTextBox);
            MoviesGroupBox.Controls.Add(label9);
            MoviesGroupBox.Controls.Add(MovieListBox);
            MoviesGroupBox.Location = new Point(0, 0);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(329, 271);
            MoviesGroupBox.TabIndex = 2;
            MoviesGroupBox.TabStop = false;
            MoviesGroupBox.Text = "Movies";
            // 
            // MovieFindButton
            // 
            MovieFindButton.Location = new Point(204, 242);
            MovieFindButton.Name = "MovieFindButton";
            MovieFindButton.Size = new Size(110, 23);
            MovieFindButton.TabIndex = 12;
            MovieFindButton.Text = "Find";
            MovieFindButton.UseVisualStyleBackColor = true;
            MovieFindButton.Click += MovieFindButton_Click;
            // 
            // MovieGenreTextBox
            // 
            MovieGenreTextBox.Location = new Point(204, 215);
            MovieGenreTextBox.Name = "MovieGenreTextBox";
            MovieGenreTextBox.Size = new Size(110, 23);
            MovieGenreTextBox.TabIndex = 11;
            MovieGenreTextBox.TextChanged += MovieGenreTextBox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(204, 197);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 10;
            label13.Text = "Genre:";
            // 
            // MovieTitleTextBox
            // 
            MovieTitleTextBox.Location = new Point(204, 171);
            MovieTitleTextBox.Name = "MovieTitleTextBox";
            MovieTitleTextBox.Size = new Size(110, 23);
            MovieTitleTextBox.TabIndex = 9;
            MovieTitleTextBox.TextChanged += MovieTitleTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(204, 153);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 8;
            label12.Text = "Title:";
            // 
            // MovieRatingTextBox
            // 
            MovieRatingTextBox.Location = new Point(204, 127);
            MovieRatingTextBox.Name = "MovieRatingTextBox";
            MovieRatingTextBox.Size = new Size(110, 23);
            MovieRatingTextBox.TabIndex = 7;
            MovieRatingTextBox.TextChanged += MovieRatingTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(204, 109);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 6;
            label11.Text = "Rating:";
            // 
            // MovieReleaseYearTextBox
            // 
            MovieReleaseYearTextBox.Location = new Point(204, 83);
            MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            MovieReleaseYearTextBox.Size = new Size(110, 23);
            MovieReleaseYearTextBox.TabIndex = 5;
            MovieReleaseYearTextBox.TextChanged += MovieReleaseYearTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(204, 65);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 4;
            label10.Text = "Release Year:";
            // 
            // MovieDurationTextBox
            // 
            MovieDurationTextBox.Location = new Point(204, 39);
            MovieDurationTextBox.Name = "MovieDurationTextBox";
            MovieDurationTextBox.Size = new Size(110, 23);
            MovieDurationTextBox.TabIndex = 3;
            MovieDurationTextBox.TextChanged += MovieDurationTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(204, 21);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 2;
            label9.Text = "Duration:";
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Items.AddRange(new object[] { "Movie1", "Movie2", "Movie3", "Movie4", "Movie5" });
            MovieListBox.Location = new Point(6, 21);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(192, 244);
            MovieListBox.TabIndex = 0;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // MoviesInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MoviesGroupBox);
            Name = "MoviesInfo";
            Size = new Size(329, 271);
            Load += MoviesInfo_Load;
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MoviesGroupBox;
        private Button MovieFindButton;
        private TextBox MovieGenreTextBox;
        private Label label13;
        private TextBox MovieTitleTextBox;
        private Label label12;
        private TextBox MovieRatingTextBox;
        private Label label11;
        private TextBox MovieReleaseYearTextBox;
        private Label label10;
        private TextBox MovieDurationTextBox;
        private Label label9;
        private ListBox MovieListBox;
    }
}
