namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemsGroupBox = new GroupBox();
            ItemDescriptionTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemCostTextBox = new TextBox();
            ItemIDTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ItemsGroupBox.SuspendLayout();
            SelectedItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(RemoveItemButton);
            ItemsGroupBox.Controls.Add(AddItemButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(251, 451);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(87, 392);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(75, 34);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(6, 392);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(75, 34);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(239, 364);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.Click += ItemsListBox_Click;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemsGroupBox
            // 
            SelectedItemsGroupBox.Controls.Add(ItemDescriptionTextBox);
            SelectedItemsGroupBox.Controls.Add(ItemNameTextBox);
            SelectedItemsGroupBox.Controls.Add(ItemCostTextBox);
            SelectedItemsGroupBox.Controls.Add(ItemIDTextBox);
            SelectedItemsGroupBox.Controls.Add(label4);
            SelectedItemsGroupBox.Controls.Add(label3);
            SelectedItemsGroupBox.Controls.Add(label2);
            SelectedItemsGroupBox.Controls.Add(label1);
            SelectedItemsGroupBox.Location = new Point(260, 3);
            SelectedItemsGroupBox.Name = "SelectedItemsGroupBox";
            SelectedItemsGroupBox.Size = new Size(339, 451);
            SelectedItemsGroupBox.TabIndex = 1;
            SelectedItemsGroupBox.TabStop = false;
            SelectedItemsGroupBox.Text = "Selected Item";
            // 
            // ItemDescriptionTextBox
            // 
            ItemDescriptionTextBox.Location = new Point(7, 237);
            ItemDescriptionTextBox.Multiline = true;
            ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            ItemDescriptionTextBox.Size = new Size(326, 149);
            ItemDescriptionTextBox.TabIndex = 7;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(7, 108);
            ItemNameTextBox.Multiline = true;
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(327, 90);
            ItemNameTextBox.TabIndex = 6;
            // 
            // ItemCostTextBox
            // 
            ItemCostTextBox.Location = new Point(54, 48);
            ItemCostTextBox.Name = "ItemCostTextBox";
            ItemCostTextBox.Size = new Size(129, 23);
            ItemCostTextBox.TabIndex = 5;
            // 
            // ItemIDTextBox
            // 
            ItemIDTextBox.Location = new Point(54, 19);
            ItemIDTextBox.Name = "ItemIDTextBox";
            ItemIDTextBox.ReadOnly = true;
            ItemIDTextBox.Size = new Size(129, 23);
            ItemIDTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 219);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Cost:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemsGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(602, 457);
            Load += ItemsTab_Load;
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemsGroupBox.ResumeLayout(false);
            SelectedItemsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemsGroupBox;
        private TextBox ItemDescriptionTextBox;
        private TextBox ItemNameTextBox;
        private TextBox ItemCostTextBox;
        private TextBox ItemIDTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button RemoveItemButton;
        private Button AddItemButton;
    }
}
