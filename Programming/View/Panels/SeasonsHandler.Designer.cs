namespace Programming.View.Panels
{
    partial class SeasonsHandler
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
            SeasonHandleGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonsComboBox = new ComboBox();
            label1 = new Label();
            SeasonHandleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonHandleGroupBox
            // 
            SeasonHandleGroupBox.Controls.Add(GoButton);
            SeasonHandleGroupBox.Controls.Add(SeasonsComboBox);
            SeasonHandleGroupBox.Controls.Add(label1);
            SeasonHandleGroupBox.Dock = DockStyle.Fill;
            SeasonHandleGroupBox.Location = new Point(0, 0);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(267, 88);
            SeasonHandleGroupBox.TabIndex = 10;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handler";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(145, 36);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 25);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Location = new Point(6, 37);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(121, 23);
            SeasonsComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose season:";
            // 
            // SeasonsHandler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandleGroupBox);
            Name = "SeasonsHandler";
            Size = new Size(267, 88);
            Load += SeasonsHandler_Load;
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonHandleGroupBox;
        private Button GoButton;
        private ComboBox SeasonsComboBox;
        private Label label1;
    }
}
