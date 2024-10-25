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
            CustomersTabPage = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            MainTabControl.SuspendLayout();
            ItemsTabPage1.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsTabPage1);
            MainTabControl.Controls.Add(CustomersTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(853, 526);
            MainTabControl.TabIndex = 0;
            // 
            // ItemsTabPage1
            // 
            ItemsTabPage1.Controls.Add(ItemsTab);
            ItemsTabPage1.Location = new Point(4, 24);
            ItemsTabPage1.Name = "ItemsTabPage1";
            ItemsTabPage1.Padding = new Padding(3);
            ItemsTabPage1.Size = new Size(845, 498);
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
            ItemsTab.Size = new Size(839, 492);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(customersTab1);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(845, 498);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.MinimumSize = new Size(800, 470);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(839, 492);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 526);
            Controls.Add(MainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObjectOrientedPractics";
            MainTabControl.ResumeLayout(false);
            ItemsTabPage1.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsTabPage1;
        private TabPage CustomersTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab customersTab1;
    }
}
