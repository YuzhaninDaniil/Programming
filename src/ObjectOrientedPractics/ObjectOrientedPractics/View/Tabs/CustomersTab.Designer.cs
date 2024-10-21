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
            Address address1 = new Address();
            CustomersGroupBox = new GroupBox();
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            CustomersListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            CustomerIDTextBox = new TextBox();
            CustomerFullNameTextBox = new TextBox();
            CustomerAddressControl = new Controls.AddressControl();
            SelectedCustomersGroupBox = new GroupBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
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
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(33, 27);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(116, 23);
            CustomerIDTextBox.TabIndex = 3;
            // 
            // CustomerFullNameTextBox
            // 
            CustomerFullNameTextBox.Location = new Point(6, 81);
            CustomerFullNameTextBox.Multiline = true;
            CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            CustomerFullNameTextBox.Size = new Size(278, 42);
            CustomerFullNameTextBox.TabIndex = 4;
            // 
            // CustomerAddressControl
            // 
            address1.Apartment = "Apartment";
            address1.Building = "Building";
            address1.City = "City";
            address1.Country = "Country";
            address1.Index = 100000;
            address1.Street = "Street";
            CustomerAddressControl.Address = address1;
            CustomerAddressControl.Location = new Point(6, 150);
            CustomerAddressControl.Name = "CustomerAddressControl";
            CustomerAddressControl.Size = new Size(550, 184);
            CustomerAddressControl.TabIndex = 5;
            // 
            // SelectedCustomersGroupBox
            // 
            SelectedCustomersGroupBox.Controls.Add(CustomerAddressControl);
            SelectedCustomersGroupBox.Controls.Add(CustomerFullNameTextBox);
            SelectedCustomersGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedCustomersGroupBox.Controls.Add(label2);
            SelectedCustomersGroupBox.Controls.Add(label1);
            SelectedCustomersGroupBox.Location = new Point(286, 3);
            SelectedCustomersGroupBox.Name = "SelectedCustomersGroupBox";
            SelectedCustomersGroupBox.Size = new Size(627, 410);
            SelectedCustomersGroupBox.TabIndex = 1;
            SelectedCustomersGroupBox.TabStop = false;
            SelectedCustomersGroupBox.Text = "Selected Customers";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomersGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(916, 416);
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
        private Label label1;
        private Label label2;
        private TextBox CustomerIDTextBox;
        private TextBox CustomerFullNameTextBox;
        private Controls.AddressControl CustomerAddressControl;
        private GroupBox SelectedCustomersGroupBox;
    }
}
