namespace Programming.View.Panels
{
    public partial class RectanglesInfo : UserControl
    {
        public RectanglesInfo()
        {
            InitializeComponent();
        }

        private Rectangle[] _rectangles1 = new Rectangle[5];
        private Rectangle _currentRectangle1;

        private void RectanglesInfo_Load(object sender, EventArgs e)
        {
            InitializeRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

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

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles1);
        }

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

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double lenght = double.Parse(RectangleHeightTextBox.Text);
                _currentRectangle1.Height = lenght;
                RectangleHeightTextBox.BackColor = AppColors.White;
            }
            catch (ArgumentException ex)
            {
                RectangleHeightTextBox.BackColor = AppColors.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                RectangleHeightTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(RectangleWidthTextBox.Text);
                _currentRectangle1.Width = width;
                RectangleWidthTextBox.BackColor = AppColors.White;
            }
            catch (ArgumentException ex)
            {
                RectangleWidthTextBox.BackColor = AppColors.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                RectangleWidthTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(typeof(ColorEnum), RectangleColorTextBox.Text, out _))
            {
                RectangleColorTextBox.BackColor = AppColors.LightPink;
            }
            else
            {
                RectangleColorTextBox.BackColor = AppColors.White;
                _currentRectangle1.Color = RectangleColorTextBox.Text;
            }
        }
    }
}
