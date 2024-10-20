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
            CustomersGroupBox = new GroupBox();
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomersGroupBox = new GroupBox();
            CustomerAddressTextBox = new TextBox();
            CustomerFullNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(RemoveCustomerButton);
            CustomersGroupBox.Controls.Add(AddCustomerButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(274, 410);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Location = new Point(87, 362);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(75, 39);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Location = new Point(6, 362);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(75, 39);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(262, 334);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomersGroupBox
            // 
            SelectedCustomersGroupBox.Controls.Add(CustomerAddressTextBox);
            SelectedCustomersGroupBox.Controls.Add(CustomerFullNameTextBox);
            SelectedCustomersGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedCustomersGroupBox.Controls.Add(label3);
            SelectedCustomersGroupBox.Controls.Add(label2);
            SelectedCustomersGroupBox.Controls.Add(label1);
            SelectedCustomersGroupBox.Location = new Point(283, 3);
            SelectedCustomersGroupBox.Name = "SelectedCustomersGroupBox";
            SelectedCustomersGroupBox.Size = new Size(377, 410);
            SelectedCustomersGroupBox.TabIndex = 1;
            SelectedCustomersGroupBox.TabStop = false;
            SelectedCustomersGroupBox.Text = "Selected Customers";
            // 
            // CustomerAddressTextBox
            // 
            CustomerAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CustomerAddressTextBox.Location = new Point(6, 223);
            CustomerAddressTextBox.Multiline = true;
            CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            CustomerAddressTextBox.Size = new Size(278, 97);
            CustomerAddressTextBox.TabIndex = 5;
            // 
            // CustomerFullNameTextBox
            // 
            CustomerFullNameTextBox.Location = new Point(6, 81);
            CustomerFullNameTextBox.Multiline = true;
            CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            CustomerFullNameTextBox.Size = new Size(278, 42);
            CustomerFullNameTextBox.TabIndex = 4;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(33, 27);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(116, 23);
            CustomerIDTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 205);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomersGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(663, 416);
            Load += CustomersTab_Load;
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomersGroupBox.ResumeLayout(false);
            SelectedCustomersGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private Button RemoveCustomerButton;
        private Button AddCustomerButton;
        private ListBox CustomersListBox;
        private GroupBox SelectedCustomersGroupBox;
        private TextBox CustomerAddressTextBox;
        private TextBox CustomerFullNameTextBox;
        private TextBox CustomerIDTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
