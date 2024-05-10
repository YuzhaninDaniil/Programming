namespace Programming.View.Panels
{
    partial class RectanglesInfo
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
            RectanglesGroupBox = new GroupBox();
            RectangleFindButton = new Button();
            RectangleIdTextBox = new TextBox();
            RectangleCenterYTextBox = new TextBox();
            RectangleCenterXTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            RectangleColorTextBox = new TextBox();
            label3 = new Label();
            RectangleWidthTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RectangleHeightTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(RectangleFindButton);
            RectanglesGroupBox.Controls.Add(RectangleIdTextBox);
            RectanglesGroupBox.Controls.Add(RectangleCenterYTextBox);
            RectanglesGroupBox.Controls.Add(RectangleCenterXTextBox);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(label5);
            RectanglesGroupBox.Controls.Add(label4);
            RectanglesGroupBox.Controls.Add(RectangleColorTextBox);
            RectanglesGroupBox.Controls.Add(label3);
            RectanglesGroupBox.Controls.Add(RectangleWidthTextBox);
            RectanglesGroupBox.Controls.Add(label2);
            RectanglesGroupBox.Controls.Add(label1);
            RectanglesGroupBox.Controls.Add(RectangleHeightTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(0, 0);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(289, 271);
            RectanglesGroupBox.TabIndex = 4;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleFindButton
            // 
            RectangleFindButton.Location = new Point(184, 243);
            RectangleFindButton.Name = "RectangleFindButton";
            RectangleFindButton.Size = new Size(100, 23);
            RectangleFindButton.TabIndex = 13;
            RectangleFindButton.Text = "Find";
            RectangleFindButton.UseVisualStyleBackColor = true;
            RectangleFindButton.Click += RectangleFindButton_Click;
            // 
            // RectangleIdTextBox
            // 
            RectangleIdTextBox.Location = new Point(229, 215);
            RectangleIdTextBox.Name = "RectangleIdTextBox";
            RectangleIdTextBox.ReadOnly = true;
            RectangleIdTextBox.Size = new Size(55, 23);
            RectangleIdTextBox.TabIndex = 12;
            // 
            // RectangleCenterYTextBox
            // 
            RectangleCenterYTextBox.Location = new Point(229, 186);
            RectangleCenterYTextBox.Name = "RectangleCenterYTextBox";
            RectangleCenterYTextBox.ReadOnly = true;
            RectangleCenterYTextBox.Size = new Size(55, 23);
            RectangleCenterYTextBox.TabIndex = 11;
            // 
            // RectangleCenterXTextBox
            // 
            RectangleCenterXTextBox.Location = new Point(229, 157);
            RectangleCenterXTextBox.Name = "RectangleCenterXTextBox";
            RectangleCenterXTextBox.ReadOnly = true;
            RectangleCenterXTextBox.Size = new Size(55, 23);
            RectangleCenterXTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 194);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 9;
            label6.Text = "Y:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 223);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 8;
            label5.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 165);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 7;
            label4.Text = "X:";
            // 
            // RectangleColorTextBox
            // 
            RectangleColorTextBox.Location = new Point(184, 128);
            RectangleColorTextBox.Name = "RectangleColorTextBox";
            RectangleColorTextBox.Size = new Size(100, 23);
            RectangleColorTextBox.TabIndex = 6;
            RectangleColorTextBox.TextChanged += RectangleColorTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 110);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Color:";
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(184, 84);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(100, 23);
            RectangleWidthTextBox.TabIndex = 4;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 66);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Width:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Height:";
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(184, 40);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(100, 23);
            RectangleHeightTextBox.TabIndex = 1;
            RectangleHeightTextBox.TextChanged += RectangleHeightTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Items.AddRange(new object[] { "Rectagle1", "Rectagle2", "Rectagle3", "Rectagle4", "Rectagle5" });
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(172, 244);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesInfo";
            Size = new Size(293, 274);
            Load += RectanglesInfo_Load;
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Button RectangleFindButton;
        private TextBox RectangleIdTextBox;
        private TextBox RectangleCenterYTextBox;
        private TextBox RectangleCenterXTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox RectangleColorTextBox;
        private Label label3;
        private TextBox RectangleWidthTextBox;
        private Label label2;
        private Label label1;
        private TextBox RectangleHeightTextBox;
        private ListBox RectanglesListBox;
    }
}
