namespace Programming.View.Panels
{
    partial class Enumerations
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
            EnumerationsInfoGroupBox = new GroupBox();
            IntValue = new TextBox();
            label3 = new Label();
            ValuesListBox = new ListBox();
            label2 = new Label();
            label1 = new Label();
            EnumsListBox = new ListBox();
            EnumerationsInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumerationsInfoGroupBox
            // 
            EnumerationsInfoGroupBox.Controls.Add(IntValue);
            EnumerationsInfoGroupBox.Controls.Add(label3);
            EnumerationsInfoGroupBox.Controls.Add(ValuesListBox);
            EnumerationsInfoGroupBox.Controls.Add(label2);
            EnumerationsInfoGroupBox.Controls.Add(label1);
            EnumerationsInfoGroupBox.Controls.Add(EnumsListBox);
            EnumerationsInfoGroupBox.Dock = DockStyle.Top;
            EnumerationsInfoGroupBox.Location = new Point(0, 0);
            EnumerationsInfoGroupBox.Name = "EnumerationsInfoGroupBox";
            EnumerationsInfoGroupBox.Size = new Size(539, 209);
            EnumerationsInfoGroupBox.TabIndex = 9;
            EnumerationsInfoGroupBox.TabStop = false;
            EnumerationsInfoGroupBox.Text = "Enumerations Info";
            // 
            // IntValue
            // 
            IntValue.Location = new Point(376, 34);
            IntValue.Name = "IntValue";
            IntValue.ReadOnly = true;
            IntValue.Size = new Size(137, 23);
            IntValue.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 16);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(190, 34);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(179, 169);
            ValuesListBox.TabIndex = 8;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 16);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 11;
            label2.Text = "Choose value:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 10;
            label1.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "ColorEnum", "Season", "Weekday", "EducationForm", "Genre", "Manufacture" });
            EnumsListBox.Location = new Point(6, 34);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 169);
            EnumsListBox.TabIndex = 7;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // Enumerations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumerationsInfoGroupBox);
            Name = "Enumerations";
            Size = new Size(539, 228);
            Load += Enumerations_Load;
            EnumerationsInfoGroupBox.ResumeLayout(false);
            EnumerationsInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumerationsInfoGroupBox;
        private TextBox IntValue;
        private Label label3;
        private ListBox ValuesListBox;
        private Label label2;
        private Label label1;
        private ListBox EnumsListBox;
    }
}
