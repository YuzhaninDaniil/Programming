namespace ListOfEmployees
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
            EmployeesListBox = new ListBox();
            EmployeeInfoGroupBox = new GroupBox();
            SalaryTextBox = new TextBox();
            label4 = new Label();
            HireDateTimePicker = new DateTimePicker();
            label3 = new Label();
            PositionTextBox = new TextBox();
            label2 = new Label();
            FullNameTextBox = new TextBox();
            label1 = new Label();
            SaveButton = new Button();
            AddButton = new Button();
            RemoveButton = new Button();
            EmployeeInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EmployeesListBox
            // 
            EmployeesListBox.FormattingEnabled = true;
            EmployeesListBox.ItemHeight = 15;
            EmployeesListBox.Location = new Point(12, 12);
            EmployeesListBox.Name = "EmployeesListBox";
            EmployeesListBox.Size = new Size(252, 424);
            EmployeesListBox.TabIndex = 0;
            EmployeesListBox.SelectedIndexChanged += EmployeesListBox_SelectedIndexChanged;
            // 
            // EmployeeInfoGroupBox
            // 
            EmployeeInfoGroupBox.Controls.Add(SalaryTextBox);
            EmployeeInfoGroupBox.Controls.Add(label4);
            EmployeeInfoGroupBox.Controls.Add(HireDateTimePicker);
            EmployeeInfoGroupBox.Controls.Add(label3);
            EmployeeInfoGroupBox.Controls.Add(PositionTextBox);
            EmployeeInfoGroupBox.Controls.Add(label2);
            EmployeeInfoGroupBox.Controls.Add(FullNameTextBox);
            EmployeeInfoGroupBox.Controls.Add(label1);
            EmployeeInfoGroupBox.Location = new Point(270, 12);
            EmployeeInfoGroupBox.Name = "EmployeeInfoGroupBox";
            EmployeeInfoGroupBox.Size = new Size(518, 142);
            EmployeeInfoGroupBox.TabIndex = 1;
            EmployeeInfoGroupBox.TabStop = false;
            EmployeeInfoGroupBox.Text = "Employee Info";
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new Point(87, 109);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(154, 23);
            SalaryTextBox.TabIndex = 7;
            SalaryTextBox.TextChanged += SalaryTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Salary:";
            // 
            // HireDateTimePicker
            // 
            HireDateTimePicker.Location = new Point(87, 80);
            HireDateTimePicker.Name = "HireDateTimePicker";
            HireDateTimePicker.Size = new Size(154, 23);
            HireDateTimePicker.TabIndex = 5;
            HireDateTimePicker.ValueChanged += HireDateTimePicker_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Hire date:";
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(87, 51);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(154, 23);
            PositionTextBox.TabIndex = 3;
            PositionTextBox.TextChanged += PositionTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Position:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(87, 22);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.ReadOnly = true;
            FullNameTextBox.Size = new Size(425, 23);
            FullNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(270, 160);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(351, 160);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(432, 160);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(SaveButton);
            Controls.Add(EmployeeInfoGroupBox);
            Controls.Add(EmployeesListBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            EmployeeInfoGroupBox.ResumeLayout(false);
            EmployeeInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox EmployeesListBox;
        private GroupBox EmployeeInfoGroupBox;
        private Label label1;
        private TextBox FullNameTextBox;
        private TextBox PositionTextBox;
        private Label label2;
        private DateTimePicker HireDateTimePicker;
        private Label label3;
        private TextBox SalaryTextBox;
        private Label label4;
        private Button SaveButton;
        private Button AddButton;
        private Button RemoveButton;
    }
}