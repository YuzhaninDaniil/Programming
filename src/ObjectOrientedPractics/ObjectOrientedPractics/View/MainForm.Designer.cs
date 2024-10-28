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
            ItemsTab = new View.Tabs.ItemsTab();
            CustomersTabPage1 = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
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
            ItemsTabPage1.Controls.Add(ItemsTab);
            ItemsTabPage1.Location = new Point(4, 24);
            ItemsTabPage1.Name = "ItemsTabPage1";
            ItemsTabPage1.Padding = new Padding(3);
            ItemsTabPage1.Size = new Size(940, 474);
            ItemsTabPage1.TabIndex = 0;
            ItemsTabPage1.Text = "Items";
            ItemsTabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.MinimumSize = new Size(800, 470);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(934, 470);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage1
            // 
            CustomersTabPage1.Controls.Add(CustomersTab);
            CustomersTabPage1.Location = new Point(4, 24);
            CustomersTabPage1.Name = "CustomersTabPage1";
            CustomersTabPage1.Padding = new Padding(3);
            CustomersTabPage1.Size = new Size(940, 474);
            CustomersTabPage1.TabIndex = 1;
            CustomersTabPage1.Text = "Customers";
            CustomersTabPage1.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(934, 468);
            CustomersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 502);
            Controls.Add(MainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;
    }
}
