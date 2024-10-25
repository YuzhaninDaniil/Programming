namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomersPanel = new Panel();
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            CustomersListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            CustomerAddressTextBox = new TextBox();
            CustomerFullNameTextBox = new TextBox();
            CustomerIdTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            CustomersPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersPanel
            // 
            CustomersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersPanel.Controls.Add(RemoveCustomerButton);
            CustomersPanel.Controls.Add(AddCustomerButton);
            CustomersPanel.Controls.Add(CustomersListBox);
            CustomersPanel.Controls.Add(label1);
            CustomersPanel.Location = new Point(3, 3);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.Size = new Size(287, 464);
            CustomersPanel.TabIndex = 0;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustomerButton.Location = new Point(103, 424);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(94, 37);
            RemoveCustomerButton.TabIndex = 3;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustomerButton.Location = new Point(3, 424);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(94, 37);
            AddCustomerButton.TabIndex = 2;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 24);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(279, 394);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 1;
            label2.Text = "Selected Customer";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(CustomerAddressTextBox);
            panel1.Controls.Add(CustomerFullNameTextBox);
            panel1.Controls.Add(CustomerIdTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(291, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 205);
            panel1.TabIndex = 1;
            // 
            // CustomerAddressTextBox
            // 
            CustomerAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAddressTextBox.Location = new Point(69, 81);
            CustomerAddressTextBox.Multiline = true;
            CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            CustomerAddressTextBox.Size = new Size(435, 106);
            CustomerAddressTextBox.TabIndex = 7;
            CustomerAddressTextBox.TextChanged += CustomerAddressTextBox_TextChanged;
            // 
            // CustomerFullNameTextBox
            // 
            CustomerFullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerFullNameTextBox.Location = new Point(68, 51);
            CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            CustomerFullNameTextBox.Size = new Size(435, 23);
            CustomerFullNameTextBox.TabIndex = 6;
            CustomerFullNameTextBox.TextChanged += CustomerFullNameTextBox_TextChanged;
            // 
            // CustomerIdTextBox
            // 
            CustomerIdTextBox.Location = new Point(68, 23);
            CustomerIdTextBox.Name = "CustomerIdTextBox";
            CustomerIdTextBox.ReadOnly = true;
            CustomerIdTextBox.Size = new Size(155, 23);
            CustomerIdTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 83);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "FullName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(CustomersPanel);
            MinimumSize = new Size(800, 470);
            Name = "CustomersTab";
            Size = new Size(800, 470);
            Load += CustomersTab_Load;
            CustomersPanel.ResumeLayout(false);
            CustomersPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CustomersPanel;
        private Button RemoveCustomerButton;
        private Button AddCustomerButton;
        private ListBox CustomersListBox;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox CustomerAddressTextBox;
        private TextBox CustomerFullNameTextBox;
        private TextBox CustomerIdTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
