namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        private static List<Rectangle> _rectangles = new List<Rectangle>();
        private static Rectangle _currentRectangle = null;
        private static List<Panel> _rectanglePanels = new List<Panel>();

        private void UpdateRectangleInfo()
        {
            Rectangle selectedRectangle = _rectangles[RectanglesListBox2.SelectedIndex];
            RectanglesListBox2.Items[RectanglesListBox2.SelectedIndex] = $"{selectedRectangle.Id}. (X = {selectedRectangle.Center.X}, Y = {selectedRectangle.Center.Y}; W = {selectedRectangle.Width}; H = {selectedRectangle.Height})";
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.Green;
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = AppColors.Red;
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(RectanglesPanel.Width, RectanglesPanel.Height);
            _rectangles.Add(newRectangle);

            RectanglesListBox2.Items.Add($"{newRectangle.Id}. (X = {newRectangle.Center.X}, Y = {newRectangle.Center.Y}, W = {newRectangle.Width}; H = {newRectangle.Height})");

            Panel newPanel = new Panel();
            newPanel.BackColor = AppColors.Green;
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
                RectangleCenterXTextBox2.BackColor = AppColors.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[RectanglesListBox2.SelectedIndex].Width / 2,
                    _rectanglePanels[RectanglesListBox2.SelectedIndex].Location.Y);

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleCenterXTextBox2.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleCenterYTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleCenterYTextBox2.Text)) return;
            try
            {
                int text = int.Parse(RectangleCenterYTextBox2.Text);
                _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, int.Parse(RectangleCenterYTextBox2.Text));
                RectangleCenterYTextBox2.BackColor = AppColors.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Location = new Point(
                    _rectanglePanels[RectanglesListBox2.SelectedIndex].Location.X,
                    text - _rectanglePanels[RectanglesListBox2.SelectedIndex].Height / 2);

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleCenterYTextBox2.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleWidthTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleWidthTextBox2.Text)) return;
            try
            {
                int text = int.Parse(RectangleWidthTextBox2.Text);
                _currentRectangle.Width = text;
                RectangleWidthTextBox2.BackColor = AppColors.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Width = text;

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleWidthTextBox2.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleHeightTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleHeightTextBox2.Text)) return;
            try
            {
                int text = int.Parse(RectangleHeightTextBox2.Text);
                _currentRectangle.Height = text;
                RectangleHeightTextBox2.BackColor = AppColors.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox2.SelectedIndex].Height = text;

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleHeightTextBox2.BackColor = AppColors.LightPink;
            }
        }
    }
}
