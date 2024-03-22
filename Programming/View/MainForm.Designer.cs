namespace Programming
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
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            EnumerationsGroup.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
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
            IntValue.Location = new Point(383, 37);
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
            ClassesPage.Location = new Point(4, 24);
            ClassesPage.Name = "ClassesPage";
            ClassesPage.Padding = new Padding(3);
            ClassesPage.Size = new Size(750, 369);
            ClassesPage.TabIndex = 1;
            ClassesPage.Text = "ClassesPage";
            ClassesPage.UseVisualStyleBackColor = true;
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
    }
}