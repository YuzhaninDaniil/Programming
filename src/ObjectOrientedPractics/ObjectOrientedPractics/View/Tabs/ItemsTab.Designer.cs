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
            panel1 = new Panel();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            label2 = new Label();
            SelectedItemPanel = new Panel();
            ItemCategoryComboBox = new ComboBox();
            ItemNameTextBox = new TextBox();
            ItemInfoTextBox = new TextBox();
            ItemCostTextBox = new TextBox();
            ItemIdTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SelectedItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(RemoveItemButton);
            panel1.Controls.Add(AddItemButton);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 464);
            panel1.TabIndex = 0;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(103, 424);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(94, 37);
            RemoveItemButton.TabIndex = 4;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(3, 424);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(94, 37);
            AddItemButton.TabIndex = 3;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(5, 24);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(279, 394);
            ItemsListBox.TabIndex = 2;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 1;
            label2.Text = "Items";
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemPanel.Controls.Add(ItemCategoryComboBox);
            SelectedItemPanel.Controls.Add(ItemNameTextBox);
            SelectedItemPanel.Controls.Add(ItemInfoTextBox);
            SelectedItemPanel.Controls.Add(ItemCostTextBox);
            SelectedItemPanel.Controls.Add(ItemIdTextBox);
            SelectedItemPanel.Controls.Add(label7);
            SelectedItemPanel.Controls.Add(label6);
            SelectedItemPanel.Controls.Add(label5);
            SelectedItemPanel.Controls.Add(label4);
            SelectedItemPanel.Controls.Add(label3);
            SelectedItemPanel.Controls.Add(label1);
            SelectedItemPanel.Location = new Point(296, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            SelectedItemPanel.Size = new Size(501, 464);
            SelectedItemPanel.TabIndex = 1;
            // 
            // ItemCategoryComboBox
            // 
            ItemCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemCategoryComboBox.FormattingEnabled = true;
            ItemCategoryComboBox.Location = new Point(72, 89);
            ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            ItemCategoryComboBox.Size = new Size(140, 23);
            ItemCategoryComboBox.TabIndex = 10;
            ItemCategoryComboBox.SelectedIndexChanged += ItemCategoryComboBox_SelectedIndexChanged;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemNameTextBox.Location = new Point(3, 147);
            ItemNameTextBox.Multiline = true;
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(495, 95);
            ItemNameTextBox.TabIndex = 9;
            ItemNameTextBox.TextChanged += ItemNameTextBox_TextChanged;
            // 
            // ItemInfoTextBox
            // 
            ItemInfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemInfoTextBox.Location = new Point(4, 274);
            ItemInfoTextBox.Multiline = true;
            ItemInfoTextBox.Name = "ItemInfoTextBox";
            ItemInfoTextBox.Size = new Size(495, 145);
            ItemInfoTextBox.TabIndex = 8;
            ItemInfoTextBox.TextChanged += ItemInfoTextBox_TextChanged;
            // 
            // ItemCostTextBox
            // 
            ItemCostTextBox.Location = new Point(72, 57);
            ItemCostTextBox.Name = "ItemCostTextBox";
            ItemCostTextBox.Size = new Size(140, 23);
            ItemCostTextBox.TabIndex = 7;
            ItemCostTextBox.TextChanged += ItemCostTextBox_TextChanged;
            // 
            // ItemIdTextBox
            // 
            ItemIdTextBox.Location = new Point(72, 24);
            ItemIdTextBox.Name = "ItemIdTextBox";
            ItemIdTextBox.ReadOnly = true;
            ItemIdTextBox.Size = new Size(140, 23);
            ItemIdTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 255);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 5;
            label7.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 129);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 4;
            label6.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 92);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 0;
            label1.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemPanel);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 470);
            Name = "ItemsTab";
            Size = new Size(800, 470);
            Load += ItemsTab_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private ListBox ItemsListBox;
        private Label label2;
        private Panel SelectedItemPanel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox ItemCategoryComboBox;
        private TextBox ItemNameTextBox;
        private TextBox ItemInfoTextBox;
        private TextBox ItemCostTextBox;
        private TextBox ItemIdTextBox;
    }
}
