﻿namespace Programming
{
    partial class MainForm
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
            MainTabControl = new TabControl();
            EnumsPage = new TabPage();
            EnumerationsGroup = new GroupBox();
            SeasonGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonsComboBox = new ComboBox();
            label5 = new Label();
            WeekdayGroupBox = new GroupBox();
            ParsedWeekdayLabel = new Label();
            WeekdayParsingButton = new Button();
            WeekdayTextBox = new TextBox();
            label4 = new Label();
            IntValue = new TextBox();
            label3 = new Label();
            ValuesListBox = new ListBox();
            label2 = new Label();
            label1 = new Label();
            EnumsListBox = new ListBox();
            ClassesPage = new TabPage();
            ClassesGroup = new GroupBox();
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
            RectanglesGroupBox = new GroupBox();
            RectangleFindButton = new Button();
            RectangleColorTextBox = new TextBox();
            label8 = new Label();
            RectangleWidthTextBox = new TextBox();
            label7 = new Label();
            RectangleLengthTextBox = new TextBox();
            label6 = new Label();
            RectanglesListBox = new ListBox();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            EnumerationsGroup.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
            ClassesPage.SuspendLayout();
            ClassesGroup.SuspendLayout();
            MoviesGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EnumsPage);
            MainTabControl.Controls.Add(ClassesPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(758, 397);
            MainTabControl.TabIndex = 0;
            // 
            // EnumsPage
            // 
            EnumsPage.Controls.Add(EnumerationsGroup);
            EnumsPage.Location = new Point(4, 24);
            EnumsPage.Name = "EnumsPage";
            EnumsPage.Padding = new Padding(3);
            EnumsPage.Size = new Size(750, 369);
            EnumsPage.TabIndex = 0;
            EnumsPage.Text = "Enums";
            EnumsPage.UseVisualStyleBackColor = true;
            // 
            // EnumerationsGroup
            // 
            EnumerationsGroup.Controls.Add(SeasonGroupBox);
            EnumerationsGroup.Controls.Add(WeekdayGroupBox);
            EnumerationsGroup.Controls.Add(IntValue);
            EnumerationsGroup.Controls.Add(label3);
            EnumerationsGroup.Controls.Add(ValuesListBox);
            EnumerationsGroup.Controls.Add(label2);
            EnumerationsGroup.Controls.Add(label1);
            EnumerationsGroup.Controls.Add(EnumsListBox);
            EnumerationsGroup.Dock = DockStyle.Fill;
            EnumerationsGroup.Location = new Point(3, 3);
            EnumerationsGroup.Name = "EnumerationsGroup";
            EnumerationsGroup.Size = new Size(744, 363);
            EnumerationsGroup.TabIndex = 7;
            EnumerationsGroup.TabStop = false;
            EnumerationsGroup.Text = "Enumerations";
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonsComboBox);
            SeasonGroupBox.Controls.Add(label5);
            SeasonGroupBox.Location = new Point(375, 227);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(369, 133);
            SeasonGroupBox.TabIndex = 1;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "SeasonHandle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(136, 38);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(50, 23);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Location = new Point(1, 38);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(129, 23);
            SeasonsComboBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 19);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 0;
            label5.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(ParsedWeekdayLabel);
            WeekdayGroupBox.Controls.Add(WeekdayParsingButton);
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Controls.Add(label4);
            WeekdayGroupBox.Location = new Point(5, 227);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(364, 130);
            WeekdayGroupBox.TabIndex = 7;
            WeekdayGroupBox.TabStop = false;
            WeekdayGroupBox.Text = "WeekdayParsing";
            // 
            // ParsedWeekdayLabel
            // 
            ParsedWeekdayLabel.AutoSize = true;
            ParsedWeekdayLabel.Location = new Point(10, 63);
            ParsedWeekdayLabel.Name = "ParsedWeekdayLabel";
            ParsedWeekdayLabel.Size = new Size(47, 15);
            ParsedWeekdayLabel.TabIndex = 1;
            ParsedWeekdayLabel.Text = "Ответ...";
            // 
            // WeekdayParsingButton
            // 
            WeekdayParsingButton.Location = new Point(171, 37);
            WeekdayParsingButton.Name = "WeekdayParsingButton";
            WeekdayParsingButton.Size = new Size(69, 23);
            WeekdayParsingButton.TabIndex = 8;
            WeekdayParsingButton.Text = "Parse";
            WeekdayParsingButton.UseVisualStyleBackColor = true;
            WeekdayParsingButton.Click += WeekdayParsingButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(10, 37);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(155, 23);
            WeekdayTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 0;
            label4.Text = "Type value for parsing:";
            // 
            // IntValue
            // 
            IntValue.Location = new Point(376, 37);
            IntValue.Name = "IntValue";
            IntValue.ReadOnly = true;
            IntValue.Size = new Size(137, 23);
            IntValue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(190, 37);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(179, 169);
            ValuesListBox.TabIndex = 2;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 19);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 5;
            label2.Text = "Choose value:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 4;
            label1.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Season", "Weekday", "EducationForm", "Genre", "Manufacture" });
            EnumsListBox.Location = new Point(6, 37);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 169);
            EnumsListBox.TabIndex = 1;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ClassesPage
            // 
            ClassesPage.Controls.Add(ClassesGroup);
            ClassesPage.Location = new Point(4, 24);
            ClassesPage.Name = "ClassesPage";
            ClassesPage.Padding = new Padding(3);
            ClassesPage.Size = new Size(750, 369);
            ClassesPage.TabIndex = 1;
            ClassesPage.Text = "Classes";
            ClassesPage.UseVisualStyleBackColor = true;
            // 
            // ClassesGroup
            // 
            ClassesGroup.Controls.Add(MoviesGroupBox);
            ClassesGroup.Controls.Add(RectanglesGroupBox);
            ClassesGroup.Location = new Point(0, 0);
            ClassesGroup.Name = "ClassesGroup";
            ClassesGroup.Size = new Size(747, 366);
            ClassesGroup.TabIndex = 0;
            ClassesGroup.TabStop = false;
            ClassesGroup.Text = "Classes";
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
            MoviesGroupBox.Location = new Point(329, 23);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(320, 285);
            MoviesGroupBox.TabIndex = 1;
            MoviesGroupBox.TabStop = false;
            MoviesGroupBox.Text = "Movies";
            // 
            // MovieFindButton
            // 
            MovieFindButton.Location = new Point(204, 244);
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
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(RectangleFindButton);
            RectanglesGroupBox.Controls.Add(RectangleColorTextBox);
            RectanglesGroupBox.Controls.Add(label8);
            RectanglesGroupBox.Controls.Add(RectangleWidthTextBox);
            RectanglesGroupBox.Controls.Add(label7);
            RectanglesGroupBox.Controls.Add(RectangleLengthTextBox);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(3, 23);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(320, 285);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleFindButton
            // 
            RectangleFindButton.Location = new Point(204, 243);
            RectangleFindButton.Name = "RectangleFindButton";
            RectangleFindButton.Size = new Size(110, 23);
            RectangleFindButton.TabIndex = 7;
            RectangleFindButton.Text = "Find";
            RectangleFindButton.UseVisualStyleBackColor = true;
            RectangleFindButton.Click += FindRectangleButton_Click;
            // 
            // RectangleColorTextBox
            // 
            RectangleColorTextBox.Location = new Point(204, 128);
            RectangleColorTextBox.Name = "RectangleColorTextBox";
            RectangleColorTextBox.Size = new Size(110, 23);
            RectangleColorTextBox.TabIndex = 6;
            RectangleColorTextBox.TextChanged += RectangleColorTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(204, 110);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 5;
            label8.Text = "Color:";
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(204, 84);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(110, 23);
            RectangleWidthTextBox.TabIndex = 4;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 66);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 3;
            label7.Text = "Width:";
            // 
            // RectangleLengthTextBox
            // 
            RectangleLengthTextBox.Location = new Point(204, 40);
            RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            RectangleLengthTextBox.Size = new Size(110, 23);
            RectangleLengthTextBox.TabIndex = 2;
            RectangleLengthTextBox.TextChanged += RectangleLenghtTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 22);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 1;
            label6.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Items.AddRange(new object[] { "Rectagle1", "Rectagle2", "Rectagle3", "Rectagle4", "Rectagle5" });
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(192, 244);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(758, 397);
            Controls.Add(MainTabControl);
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            Text = "Programming Demo";
            Load += MainForm_Load;
            MainTabControl.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            EnumerationsGroup.ResumeLayout(false);
            EnumerationsGroup.PerformLayout();
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            ClassesPage.ResumeLayout(false);
            ClassesGroup.ResumeLayout(false);
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage EnumsPage;
        private TabPage ClassesPage;
        private GroupBox EnumerationsGroup;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox WeekdayGroupBox;
        private TextBox IntValue;
        private GroupBox SeasonGroupBox;
        private Label ParsedWeekdayLabel;
        private Button WeekdayParsingButton;
        private TextBox WeekdayTextBox;
        private Label label4;
        private Button GoButton;
        private ComboBox SeasonsComboBox;
        private Label label5;
        private GroupBox ClassesGroup;
        private GroupBox MoviesGroupBox;
        private GroupBox RectanglesGroupBox;
        private ListBox MovieListBox;
        private Label label8;
        private TextBox RectangleWidthTextBox;
        private Label label7;
        private TextBox RectangleLengthTextBox;
        private Label label6;
        private ListBox RectanglesListBox;
        private TextBox MovieReleaseYearTextBox;
        private Label label10;
        private TextBox MovieDurationTextBox;
        private Label label9;
        private Button RectangleFindButton;
        private TextBox RectangleColorTextBox;
        private Button MovieFindButton;
        private TextBox MovieGenreTextBox;
        private Label label13;
        private TextBox MovieTitleTextBox;
        private Label label12;
        private TextBox MovieRatingTextBox;
        private Label label11;
    }
}