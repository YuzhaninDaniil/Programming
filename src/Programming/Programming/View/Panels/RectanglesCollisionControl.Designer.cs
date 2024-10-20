namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            RectangleColissionsGropBox = new GroupBox();
            RectanglesPanel = new Panel();
            DeleteRectangleButton = new Button();
            AddRectangleButton = new Button();
            label17 = new Label();
            RectangleHeightTextBox2 = new TextBox();
            RectanglesListBox2 = new ListBox();
            RectangleWidthTextBox2 = new TextBox();
            label18 = new Label();
            RectangleCenterYTextBox2 = new TextBox();
            label19 = new Label();
            RectangleCenterXTextBox2 = new TextBox();
            RectangleIdTextBox2 = new TextBox();
            label23 = new Label();
            label20 = new Label();
            label22 = new Label();
            label21 = new Label();
            RectangleColissionsGropBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectangleColissionsGropBox
            // 
            RectangleColissionsGropBox.Controls.Add(RectanglesPanel);
            RectangleColissionsGropBox.Controls.Add(DeleteRectangleButton);
            RectangleColissionsGropBox.Controls.Add(AddRectangleButton);
            RectangleColissionsGropBox.Controls.Add(label17);
            RectangleColissionsGropBox.Controls.Add(RectangleHeightTextBox2);
            RectangleColissionsGropBox.Controls.Add(RectanglesListBox2);
            RectangleColissionsGropBox.Controls.Add(RectangleWidthTextBox2);
            RectangleColissionsGropBox.Controls.Add(label18);
            RectangleColissionsGropBox.Controls.Add(RectangleCenterYTextBox2);
            RectangleColissionsGropBox.Controls.Add(label19);
            RectangleColissionsGropBox.Controls.Add(RectangleCenterXTextBox2);
            RectangleColissionsGropBox.Controls.Add(RectangleIdTextBox2);
            RectangleColissionsGropBox.Controls.Add(label23);
            RectangleColissionsGropBox.Controls.Add(label20);
            RectangleColissionsGropBox.Controls.Add(label22);
            RectangleColissionsGropBox.Controls.Add(label21);
            RectangleColissionsGropBox.Dock = DockStyle.Fill;
            RectangleColissionsGropBox.Location = new Point(0, 0);
            RectangleColissionsGropBox.Name = "RectangleColissionsGropBox";
            RectangleColissionsGropBox.Size = new Size(641, 422);
            RectangleColissionsGropBox.TabIndex = 17;
            RectangleColissionsGropBox.TabStop = false;
            RectangleColissionsGropBox.Text = "Rectangle Collision";
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(233, 39);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(396, 365);
            RectanglesPanel.TabIndex = 5;
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.Location = new Point(152, 214);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(75, 23);
            DeleteRectangleButton.TabIndex = 15;
            DeleteRectangleButton.Text = "Delete";
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.Location = new Point(11, 215);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(75, 23);
            AddRectangleButton.TabIndex = 14;
            AddRectangleButton.Text = "Add";
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 21);
            label17.Name = "label17";
            label17.Size = new Size(67, 15);
            label17.TabIndex = 0;
            label17.Text = "Rectangles:";
            // 
            // RectangleHeightTextBox2
            // 
            RectangleHeightTextBox2.Location = new Point(59, 381);
            RectangleHeightTextBox2.Name = "RectangleHeightTextBox2";
            RectangleHeightTextBox2.Size = new Size(100, 23);
            RectangleHeightTextBox2.TabIndex = 13;
            RectangleHeightTextBox2.TextChanged += RectangleHeightTextBox2_TextChanged;
            // 
            // RectanglesListBox2
            // 
            RectanglesListBox2.FormattingEnabled = true;
            RectanglesListBox2.ItemHeight = 15;
            RectanglesListBox2.Location = new Point(11, 39);
            RectanglesListBox2.Name = "RectanglesListBox2";
            RectanglesListBox2.Size = new Size(216, 169);
            RectanglesListBox2.TabIndex = 1;
            RectanglesListBox2.SelectedIndexChanged += RectanglesListBox2_SelectedIndexChanged;
            // 
            // RectangleWidthTextBox2
            // 
            RectangleWidthTextBox2.Location = new Point(59, 352);
            RectangleWidthTextBox2.Name = "RectangleWidthTextBox2";
            RectangleWidthTextBox2.Size = new Size(100, 23);
            RectangleWidthTextBox2.TabIndex = 12;
            RectangleWidthTextBox2.TextChanged += RectangleWidthTextBox2_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 241);
            label18.Name = "label18";
            label18.Size = new Size(109, 15);
            label18.TabIndex = 2;
            label18.Text = "Selected Rectangle:";
            // 
            // RectangleCenterYTextBox2
            // 
            RectangleCenterYTextBox2.Location = new Point(59, 323);
            RectangleCenterYTextBox2.Name = "RectangleCenterYTextBox2";
            RectangleCenterYTextBox2.Size = new Size(100, 23);
            RectangleCenterYTextBox2.TabIndex = 11;
            RectangleCenterYTextBox2.TextChanged += RectangleCenterYTextBox2_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(33, 265);
            label19.Name = "label19";
            label19.Size = new Size(20, 15);
            label19.TabIndex = 3;
            label19.Text = "Id:";
            // 
            // RectangleCenterXTextBox2
            // 
            RectangleCenterXTextBox2.Location = new Point(59, 291);
            RectangleCenterXTextBox2.Name = "RectangleCenterXTextBox2";
            RectangleCenterXTextBox2.Size = new Size(100, 23);
            RectangleCenterXTextBox2.TabIndex = 10;
            RectangleCenterXTextBox2.TextChanged += RectangleCenterXTextBox2_TextChanged;
            // 
            // RectangleIdTextBox2
            // 
            RectangleIdTextBox2.Location = new Point(59, 262);
            RectangleIdTextBox2.Name = "RectangleIdTextBox2";
            RectangleIdTextBox2.ReadOnly = true;
            RectangleIdTextBox2.Size = new Size(100, 23);
            RectangleIdTextBox2.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(11, 384);
            label23.Name = "label23";
            label23.Size = new Size(46, 15);
            label23.TabIndex = 9;
            label23.Text = "Heigth:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(36, 294);
            label20.Name = "label20";
            label20.Size = new Size(17, 15);
            label20.TabIndex = 6;
            label20.Text = "X:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(15, 355);
            label22.Name = "label22";
            label22.Size = new Size(42, 15);
            label22.TabIndex = 8;
            label22.Text = "Width:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(36, 326);
            label21.Name = "label21";
            label21.Size = new Size(17, 15);
            label21.TabIndex = 7;
            label21.Text = "Y:";
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleColissionsGropBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(641, 422);
            RectangleColissionsGropBox.ResumeLayout(false);
            RectangleColissionsGropBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectangleColissionsGropBox;
        private Panel RectanglesPanel;
        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private Label label17;
        private TextBox RectangleHeightTextBox2;
        private ListBox RectanglesListBox2;
        private TextBox RectangleWidthTextBox2;
        private Label label18;
        private TextBox RectangleCenterYTextBox2;
        private Label label19;
        private TextBox RectangleCenterXTextBox2;
        private TextBox RectangleIdTextBox2;
        private Label label23;
        private Label label20;
        private Label label22;
        private Label label21;
    }
}
