using System.Drawing;
using System.Security.Policy;
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

        private Rectangle[] _rectangles1 = new Rectangle[5];
        private Rectangle _currentRectangle1;

        /// <summary>
        /// инициализирует массив _rectangles объектами 
        /// </summary>
        private void InitializeRectangles()
        {
            Random random = new Random();
            for (int i = 0; i < _rectangles1.Length; i++)
            {
                _rectangles1[i] = new Rectangle();
                double height = random.Next(0, 10000) / 100d;
                double width = random.Next(0, 10000) / 100d;
                double CenterX = random.Next(0, 100000) / 100d;
                double CenterY = random.Next(0, 100000) / 100d;
                int RandomColorId = random.Next(0, Enum.GetValues(typeof(ColorEnum)).Length);
                string color = Enum.GetValues(typeof(ColorEnum)).GetValue(RandomColorId).ToString();

                _rectangles1[i] = new Rectangle(height, width, color, CenterX, CenterY);
            }
        }

        /// <summary>
        /// при измененинии выбранного прямоугольника отображает его характеристики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle1 = _rectangles1[RectanglesListBox.SelectedIndex];
            RectangleHeightTextBox.Text = _currentRectangle1.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle1.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle1.Color;
            RectangleCenterXTextBox.Text = _currentRectangle1.Center.X.ToString();
            RectangleCenterYTextBox.Text = _currentRectangle1.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle1.Id.ToString();
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
                _currentRectangle1.Height = lenght;
                RectangleHeightTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                RectangleHeightTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                RectangleHeightTextBox.BackColor = Color.LightPink;
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
                _currentRectangle1.Width = width;
                RectangleWidthTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                RectangleWidthTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                RectangleWidthTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// при изменении текста в RectangleColorTextBox меняет значение Color в выбранном прямоугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(typeof(ColorEnum), RectangleColorTextBox.Text, out _))
            {
                RectangleColorTextBox.BackColor = Color.LightPink;
            }
            else
            {
                RectangleColorTextBox.BackColor = Color.White;
                _currentRectangle1.Color = RectangleColorTextBox.Text;
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
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles1);
        }


        

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
                case "ColorEnum":
                    return typeof(ColorEnum);
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

        #region Rectangles
        private static List<Rectangle> _rectangles = new List<Rectangle>();
        private static Rectangle _currentRectangle = null;
        private static List<Panel> _rectanglePanels = new List<Panel>();

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(RectanglesPanel.Width, RectanglesPanel.Height);
            _rectangles.Add(newRectangle);

            RectanglesListBox2.Items.Add($"{newRectangle.Id}. (X = {newRectangle.Center.X}, Y = {newRectangle.Center.Y}, W = {newRectangle.Width}; H = {newRectangle.Height})");

            Panel newPanel = new Panel();
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            // Находим координаты точки верхнего левого края прямоугольника
            newPanel.Location = new Point((int)(newRectangle.Center.X - newRectangle.Width / 2), (int)(newRectangle.Center.Y - newRectangle.Height / 2));
            newPanel.Width = (int)newRectangle.Width;
            newPanel.Height = (int)newRectangle.Height;

            _rectanglePanels.Add(newPanel);
            RectanglesPanel.Controls.Add(newPanel);
            FindCollisions();
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            ClearRectangleInfo();
        }

        private void RectanglesListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex < 0)
            {
                RectangleIdTextBox2.Text = string.Empty;
                RectangleCenterXTextBox2.Text = string.Empty;
                RectangleCenterYTextBox2.Text = string.Empty;
                RectangleWidthTextBox2.Text = string.Empty;
                RectangleHeightTextBox2.Text = string.Empty;
            }
            else
            {
                _currentRectangle = _rectangles[RectanglesListBox2.SelectedIndex];

                RectangleWidthTextBox2.Text = _currentRectangle.Width.ToString();
                RectangleHeightTextBox2.Text = _currentRectangle.Height.ToString();
                RectangleCenterXTextBox2.Text = _currentRectangle.Center.X.ToString();
                RectangleCenterYTextBox2.Text = _currentRectangle.Center.Y.ToString();
                RectangleIdTextBox2.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RectangleCenterXTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleCenterXTextBox2.Text)) return;
            try
            {
                int text = int.Parse(RectangleCenterXTextBox2.Text);
                _currentRectangle.Center = new Point2D(text, _currentRectangle.Center.Y);
                RectangleCenterXTextBox2.BackColor = Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[RectanglesListBox2.SelectedIndex].Width / 2,
                    _rectanglePanels[RectanglesListBox2.SelectedIndex].Location.Y);

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleCenterXTextBox2.BackColor = Color.LightPink;
            }
        }

        private void RectanglesCenterYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleCenterYTextBox2.Text)) return;
            try
            {
                int text = int.Parse(RectangleCenterYTextBox2.Text);
                _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, int.Parse(RectangleCenterYTextBox2.Text));
                RectangleCenterYTextBox2.BackColor = Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Location = new Point(
                    _rectanglePanels[RectanglesListBox2.SelectedIndex].Location.X,
                    text - _rectanglePanels[RectanglesListBox2.SelectedIndex].Height / 2);

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleCenterYTextBox2.BackColor = Color.LightPink;
            }
        }

        private void RectangleWidthTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleWidthTextBox2.Text)) return;
            try
            {
                int text = int.Parse(RectangleWidthTextBox2.Text);
                _currentRectangle.Width = text;
                RectangleWidthTextBox2.BackColor = Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Width = text;

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleWidthTextBox2.BackColor = Color.LightPink;
            }
        }

        private void RectangleHeightTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleHeightTextBox2.Text)) return;
            try
            {
                int text = int.Parse(RectangleHeightTextBox2.Text);
                _currentRectangle.Height = text;
                RectangleHeightTextBox2.BackColor = Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Height = text;

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleHeightTextBox2.BackColor = Color.LightPink;
            }
        }

        private void UpdateRectangleInfo()
        {
            Rectangle selectedRectangle = _rectangles[RectanglesListBox2.SelectedIndex];
            RectanglesListBox2.Items[RectanglesListBox2.SelectedIndex] = $"{selectedRectangle.Id}. (X = {selectedRectangle.Center.X}, Y = {selectedRectangle.Center.Y}; W = {selectedRectangle.Width}; H = {selectedRectangle.Height})";
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
        private void ClearRectangleInfo()
        {
            if (RectanglesListBox2.SelectedIndex < 0) return;
            _rectangles.RemoveAt(RectanglesListBox2.SelectedIndex);
            _rectanglePanels.RemoveAt(RectanglesListBox2.SelectedIndex);
            RectanglesPanel.Controls.RemoveAt(RectanglesListBox2.SelectedIndex);
            RectanglesListBox2.Items.RemoveAt(RectanglesListBox2.SelectedIndex);
            FindCollisions();
        }
        #endregion
    }
}