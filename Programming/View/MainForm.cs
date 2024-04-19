using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод устанавливает какие элементы листбоксов будут первыми + SeasonsComboBox работает с enum
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
        /// инициализирует массив _rectangles объектами 
        /// </summary>
        private void InitializeRectangles()
        {
            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                double height = random.Next(0, 10000) / 100d;
                double width = random.Next(0, 10000) / 100d;
                double CenterX = random.Next(0, 100000) / 100d;
                double CenterY = random.Next(0, 100000) / 100d;
                int RandomColorId = random.Next(0, Enum.GetValues(typeof(Color)).Length);
                string color = Enum.GetValues(typeof(Color)).GetValue(RandomColorId).ToString();

                _rectangles[i] = new Rectangle(height, width, color, CenterX, CenterY);
            }
        }

        /// <summary>
        /// при измененинии выбранного прямоугольника отображает его характеристики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// при изменении текста в RectangleLenghtTextBox меняет значение Lenght в выбранном прямоугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double lenght = double.Parse(RectangleHeightTextBox.Text);
                _currentRectangle.Height = lenght;
                RectangleHeightTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                RectangleHeightTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                RectangleHeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// при изменении текста в RectangleWidthTextBox меняет значение Width в выбранном прямоугольнике
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
            catch (ArgumentException ex)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// при изменении текста в RectangleColorTextBox меняет значение Color в выбранном прямоугольнике
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
        /// Находит прямоугольник с максимальным параметром Width 
        /// </summary>
        /// <param name="rectangles">массив прямоугольников</param>
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
        /// Выбирает в качестве выбранного элемента в RectanglesListBox элемент с максимальным Width
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
                string title = $"Название {i}";
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
            catch (ArgumentException ex)
            {
                MovieDurationTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
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
            catch (ArgumentException ex)
            {
                MovieReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
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
            catch (ArgumentException ex)
            {
                MovieRatingTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
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
            catch (Exception ex)
            {
                MovieTitleTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = MovieGenreTextBox.Text;
                MovieGenreTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                MovieGenreTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Возвращает выбранный Enum/null из EnumsListBox
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
        /// Метод считывает значение из SeasonsComboBox и вызывает событие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    EnumerationsGroup.BackColor = System.Drawing.Color.LightSkyBlue;
                    break;
                case Season.Spring:
                    MessageBox.Show("Сейчас весна");
                    EnumerationsGroup.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    EnumerationsGroup.BackColor = System.Drawing.Color.YellowGreen;
                    break;
                case Season.Autumn:
                    MessageBox.Show("Сейчас осень");
                    EnumerationsGroup.BackColor = System.Drawing.Color.DarkGoldenrod;
                    break;
            }
        }

        /// <summary>
        /// Метод пытается распарсить значение строки в тип перечисления Weekday, затем сохраняет в parsedWeekday
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string weekday = WeekdayTextBox.Text;
            object parsedWeekday;
            //bool isWeek = Enum.TryParse(typeof(Weekday), weekday, out parsedWeekday);


            //if (weekday.ToLower() == "monday" || weekday == "Tuesday" || weekday == "Wednesday" || weekday == "Thursday"
            //    || weekday == "Friday" || weekday == "Saturday" || weekday == "Sunday")
            //{
            //    weekday = char.ToUpper(weekday[0]) + weekday.Substring(1);
            //    ParsedWeekdayLabel.Text = $"Это день недели {weekday} = {(int)parsedWeekday}";
            //}
            //else if(isWeek && int.Parse(weekday) <= 7 && int.Parse(weekday)!= 0)
            //{
            //    ParsedWeekdayLabel.Text = $"Это день недели ({parsedWeekday} = {(int)parsedWeekday})";
            //}
            //else
            //{
            //    ParsedWeekdayLabel.Text = "Нет такого дня недели";
            //}
            bool isWeek = Enum.TryParse(typeof(Weekday), weekday, true, out parsedWeekday); // true используется для игнорирования регистра

            // Сравнение с использованием StringComparison.OrdinalIgnoreCase
            if (weekday.Equals("monday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("tuesday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("wednesday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("thursday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("friday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("saturday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("sunday", StringComparison.OrdinalIgnoreCase))
            {
                weekday = char.ToUpper(weekday[0]) + weekday.Substring(1).ToLower();
                ParsedWeekdayLabel.Text = $"Это день недели {weekday} = {(int)parsedWeekday}";
            }
            else if (isWeek && int.Parse(weekday) <= 7 && int.Parse(weekday) != 0)
            {
                ParsedWeekdayLabel.Text = $"Это день недели ({parsedWeekday} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        /// <summary>
        /// Метод вызывается при выборе элемента EnumsListBox и вызывает ValuesListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("Элементы не найдены");
                return;
            }

            ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
            ValuesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод возвращает int значение объекта перечисления из ValuesListBox в текстбокс IntValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = ValuesListBox.SelectedItem.ToString();
            Type selectedEnum = GetSelectedEnum();

            // явно приводим к типу int, чтобы из перечисления перейти к числу
            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            EnumerationsGroup.BackColor = System.Drawing.Color.Transparent;
        }
        #endregion
    }
}