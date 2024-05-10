namespace Programming.View.Panels
{
    partial class WeekdayParsing
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
            WeekdayGroupBox = new GroupBox();
            ParsedWeekdayLabel = new Label();
            WeekdayParsingButton = new Button();
            WeekdayTextBox = new TextBox();
            label4 = new Label();
            WeekdayGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(ParsedWeekdayLabel);
            WeekdayGroupBox.Controls.Add(WeekdayParsingButton);
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Controls.Add(label4);
            WeekdayGroupBox.Dock = DockStyle.Fill;
            WeekdayGroupBox.Location = new Point(0, 0);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(373, 94);
            WeekdayGroupBox.TabIndex = 8;
            WeekdayGroupBox.TabStop = false;
            WeekdayGroupBox.Text = "Weekday Parsing";
            WeekdayGroupBox.SizeChanged += WeekdayGroupBox_SizeChanged;
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
            // WeekdayParsing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayGroupBox);
            Name = "WeekdayParsing";
            Size = new Size(373, 94);
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayGroupBox;
        private Label ParsedWeekdayLabel;
        private Button WeekdayParsingButton;
        private TextBox WeekdayTextBox;
        private Label label4;
    }
}
