namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabControl = new TabControl();
            ItemsTabPage1 = new TabPage();
            itemsTab = new View.Tabs.ItemsTab();
            CustomersTabPage1 = new TabPage();
            customersTab = new View.Tabs.CustomersTab();
            MainTabControl.SuspendLayout();
            ItemsTabPage1.SuspendLayout();
            CustomersTabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsTabPage1);
            MainTabControl.Controls.Add(CustomersTabPage1);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(948, 502);
            MainTabControl.TabIndex = 0;
            // 
            // ItemsTabPage1
            // 
            ItemsTabPage1.Controls.Add(itemsTab);
            ItemsTabPage1.Location = new Point(4, 24);
            ItemsTabPage1.Name = "ItemsTabPage1";
            ItemsTabPage1.Padding = new Padding(3);
            ItemsTabPage1.Size = new Size(940, 474);
            ItemsTabPage1.TabIndex = 0;
            ItemsTabPage1.Text = "Items";
            ItemsTabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(934, 468);
            itemsTab.TabIndex = 0;
            // 
            // CustomersTabPage1
            // 
            CustomersTabPage1.Controls.Add(customersTab);
            CustomersTabPage1.Location = new Point(4, 24);
            CustomersTabPage1.Name = "CustomersTabPage1";
            CustomersTabPage1.Padding = new Padding(3);
            CustomersTabPage1.Size = new Size(940, 474);
            CustomersTabPage1.TabIndex = 1;
            CustomersTabPage1.Text = "Customers";
            CustomersTabPage1.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(934, 468);
            customersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 502);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObjectOrientedPractics";
            MainTabControl.ResumeLayout(false);
            ItemsTabPage1.ResumeLayout(false);
            CustomersTabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsTabPage1;
        private TabPage CustomersTabPage1;
        private View.Tabs.CustomersTab customersTab;
        private View.Tabs.ItemsTab itemsTab;
    }
}
