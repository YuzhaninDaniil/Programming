namespace Programming
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ����� ������������� ����� �������� ���������� ����� ������� + SeasonsComboBox �������� � enum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;

            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;

            InitializeRectangles();
            RectanglesListBox.SelectedIndex = 0;

            InitialiseMovies();
            MovieListBox.SelectedIndex = 0;

        }

        #region Classes

        #region Rectangles

        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        /// <summary>
        /// �������������� ������ _rectangles ��������� 
        /// </summary>
        private void InitializeRectangles()
        {
            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                double lenght = random.Next(0, 10000) / 100d;
                double width = random.Next(0, 10000) / 100d;
                int RandomColorId = random.Next(0, Enum.GetValues(typeof(Color)).Length);
                string color = Enum.GetValues(typeof(Color)).GetValue(RandomColorId).ToString();

                _rectangles[i] = new Rectangle(lenght, width, color);
            }
        }

        /// <summary>
        /// ��� ����������� ���������� �������������� ���������� ��� ��������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
        }

        /// <summary>
        /// ��� ��������� ������ � RectangleLenghtTextBox ������ �������� Lenght � ��������� ��������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double lenght = double.Parse(RectangleLengthTextBox.Text);
                _currentRectangle.Length = lenght;
                RectangleLengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                RectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// ��� ��������� ������ � RectangleWidthTextBox ������ �������� Width � ��������� ��������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(RectangleWidthTextBox.Text);
                _currentRectangle.Width = width;
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// ��� ��������� ������ � RectangleColorTextBox ������ �������� Color � ��������� ��������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(typeof(Color), RectangleColorTextBox.Text, out _))
            {
                RectangleColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                RectangleColorTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Color = RectangleColorTextBox.Text;
            }
        }
        /// <summary>
        /// ������� ������������� � ������������ ���������� Width 
        /// </summary>
        /// <param name="rectangles">������ ���������������</param>
        /// <returns>int</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int rectangleWithMaxWidthIndex = 0;
            for (int rect = 0; rect < rectangles.Length; rect++)
            {
                if (rectangles[rect].Width > rectangles[rectangleWithMaxWidthIndex].Width)
                {
                    rectangleWithMaxWidthIndex = rect;
                }
            }
            return rectangleWithMaxWidthIndex;
        }

        /// <summary>
        /// �������� � �������� ���������� �������� � RectanglesListBox ������� � ������������ Width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }


        #endregion

        #region Movies
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        private void InitialiseMovies()
        {
            Random random = new Random();
            for (int i = 0; i < _movies.Length; i++)
            {
                int duration = random.Next(1, 300 + 1);
                int releaseYear = random.Next(1900, DateTime.Now.Year);
                int rating = random.Next(0, 11);
                string title = $"�������� {i}";
                int RandomGenreId = random.Next(0, Enum.GetValues(typeof(Genre)).Length);
                string genre = Enum.GetValues(typeof(Genre)).GetValue(RandomGenreId).ToString();

                _movies[i] = new Movie(title, duration, releaseYear, genre, rating);
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MovieListBox.SelectedIndex];

            MovieDurationTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            MovieGenreTextBox.Text = _currentMovie.Genre.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieTitleTextBox.Text = _currentMovie.Title.ToString();
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ParsedDuration = int.Parse(MovieDurationTextBox.Text);
                _currentMovie.DurationInMinutes = ParsedDuration;
                MovieDurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int releaseYear = int.Parse(MovieReleaseYearTextBox.Text);
                _currentMovie.ReleaseYear = releaseYear;
                MovieReleaseYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rating = int.Parse(MovieRatingTextBox.Text);
                _currentMovie.Rating = rating;
                MovieRatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Title = MovieTitleTextBox.Text;
                MovieTitleTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieTitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(typeof(Genre), MovieGenreTextBox.Text, out _))
            {
                MovieGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                MovieGenreTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Genre = MovieGenreTextBox.Text;
            }
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int movieWithMaxRatingIndex = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[movieWithMaxRatingIndex].Rating < movies[i].Rating)
                {
                    movieWithMaxRatingIndex = i;
                }
            }
            return movieWithMaxRatingIndex;
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
        #endregion

        #endregion

        #region Enumerations
        /// <summary>
        /// ���������� ��������� Enum/null �� EnumsListBox
        /// </summary>
        /// <returns></returns>
        private Type GetSelectedEnum()
        {
            string CurrentEnumName = EnumsListBox.SelectedItem.ToString();

            switch (CurrentEnumName)
            {
                case "Color":
                    return typeof(Color);
                case "Weekday":
                    return typeof(Weekday);
                case "EducationForm":
                    return typeof(EducationForm);
                case "Genre":
                    return typeof(Genre);
                case "Manufacture":
                    return typeof(Manufactures);
                case "Season":
                    return typeof(Season);
            }
            return null;
        }

        /// <summary>
        /// ����� ��������� �������� �� SeasonsComboBox � �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("����! �������!");
                    EnumerationsGroup.BackColor = System.Drawing.Color.LightSkyBlue;
                    break;
                case Season.Spring:
                    MessageBox.Show("������ �����");
                    EnumerationsGroup.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case Season.Summer:
                    MessageBox.Show("���! ������!");
                    EnumerationsGroup.BackColor = System.Drawing.Color.YellowGreen;
                    break;
                case Season.Autumn:
                    MessageBox.Show("������ �����");
                    EnumerationsGroup.BackColor = System.Drawing.Color.DarkGoldenrod;
                    break;
            }
        }

        /// <summary>
        /// ����� �������� ���������� �������� ������ � ��� ������������ Weekday, ����� ��������� � parsedWeekday
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string weekday = WeekdayTextBox.Text;
            object parsedWeekday;
            bool isWeek = Enum.TryParse(typeof(Weekday), weekday, out parsedWeekday);

            if (isWeek && int.Parse(weekday) <= 6)
            {
                ParsedWeekdayLabel.Text = $"��� ���� ������ ({parsedWeekday} = {(int)parsedWeekday})";
            }
            else if (weekday == "Monday" || weekday.ToLower() == "�������" || weekday.ToLower() == "�����" ||
             weekday.ToLower() == "�������" || weekday.ToLower() == "�������" || weekday.ToLower() == "�������" ||
             weekday.ToLower() == "�����������")
            {
                ParsedWeekdayLabel.Text = $"��� ���� ������ {weekday} = {(int)parsedWeekday}";
            }
            else
            {
                ParsedWeekdayLabel.Text = "��� ������ ��� ������";
            }

        }

        /// <summary>
        /// ����� ���������� ��� ������ �������� EnumsListBox � �������� ValuesListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("�������� �� �������");
                return;
            }

            ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
            ValuesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// ����� ���������� int �������� ������� ������������ �� ValuesListBox � ��������� IntValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = ValuesListBox.SelectedItem.ToString();
            Type selectedEnum = GetSelectedEnum();

            // ���� �������� � ���� int, ����� �� ������������ ������� � �����
            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }
        #endregion
    }
}