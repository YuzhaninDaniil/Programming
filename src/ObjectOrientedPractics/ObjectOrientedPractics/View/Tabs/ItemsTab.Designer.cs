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
            ItemsPanel = new Panel();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            SelectedItemPanel = new Panel();
            ItemInfoTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemCostTextBox = new TextBox();
            ItemIdTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ItemsPanel.SuspendLayout();
            SelectedItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsPanel
            // 
            ItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsPanel.Controls.Add(RemoveItemButton);
            ItemsPanel.Controls.Add(AddItemButton);
            ItemsPanel.Controls.Add(ItemsListBox);
            ItemsPanel.Controls.Add(label1);
            ItemsPanel.Location = new Point(3, 3);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(287, 464);
            ItemsPanel.TabIndex = 0;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(102, 429);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(93, 32);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(3, 429);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(93, 32);
            AddItemButton.TabIndex = 2;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 29);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(279, 394);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemPanel.Controls.Add(ItemInfoTextBox);
            SelectedItemPanel.Controls.Add(ItemNameTextBox);
            SelectedItemPanel.Controls.Add(ItemCostTextBox);
            SelectedItemPanel.Controls.Add(ItemIdTextBox);
            SelectedItemPanel.Controls.Add(label6);
            SelectedItemPanel.Controls.Add(label5);
            SelectedItemPanel.Controls.Add(label4);
            SelectedItemPanel.Controls.Add(label3);
            SelectedItemPanel.Controls.Add(label2);
            SelectedItemPanel.Location = new Point(296, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            SelectedItemPanel.Size = new Size(501, 464);
            SelectedItemPanel.TabIndex = 1;
            // 
            // ItemInfoTextBox
            // 
            ItemInfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemInfoTextBox.Location = new Point(15, 233);
            ItemInfoTextBox.Multiline = true;
            ItemInfoTextBox.Name = "ItemInfoTextBox";
            ItemInfoTextBox.Size = new Size(480, 163);
            ItemInfoTextBox.TabIndex = 9;
            ItemInfoTextBox.TextChanged += ItemInfoTextBox_TextChanged;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemNameTextBox.Location = new Point(15, 117);
            ItemNameTextBox.Multiline = true;
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(480, 95);
            ItemNameTextBox.TabIndex = 8;
            ItemNameTextBox.TextChanged += ItemNameTextBox_TextChanged;
            // 
            // ItemCostTextBox
            // 
            ItemCostTextBox.Location = new Point(63, 62);
            ItemCostTextBox.Name = "ItemCostTextBox";
            ItemCostTextBox.Size = new Size(163, 23);
            ItemCostTextBox.TabIndex = 7;
            ItemCostTextBox.TextChanged += ItemCostTextBox_TextChanged;
            // 
            // ItemIdTextBox
            // 
            ItemIdTextBox.Location = new Point(63, 29);
            ItemIdTextBox.Name = "ItemIdTextBox";
            ItemIdTextBox.ReadOnly = true;
            ItemIdTextBox.Size = new Size(163, 23);
            ItemIdTextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 99);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 215);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 65);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 29);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 1;
            label2.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemPanel);
            Controls.Add(ItemsPanel);
            MinimumSize = new Size(800, 470);
            Name = "ItemsTab";
            Size = new Size(800, 470);
            Load += ItemsTab_Load;
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemsPanel;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private ListBox ItemsListBox;
        private Label label1;
        private Panel SelectedItemPanel;
        private TextBox ItemInfoTextBox;
        private TextBox ItemNameTextBox;
        private TextBox ItemCostTextBox;
        private TextBox ItemIdTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
