namespace Programming
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
            MainTabControl = new TabControl();
            EnumsPage = new TabPage();
            EnumerationsGroup = new GroupBox();
            weekdayParsing = new View.Panels.WeekdayParsing();
            seasonsHandler = new View.Panels.SeasonsHandler();
            enumerations = new View.Panels.Enumerations();
            ClassesPage = new TabPage();
            ClassesGroup = new GroupBox();
            rectanglesInfo = new View.Panels.RectanglesInfo();
            moviesInfo = new View.Panels.MoviesInfo();
            RectanglesPage = new TabPage();
            rectanglesCollisionControl = new View.Panels.RectanglesCollisionControl();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            EnumerationsGroup.SuspendLayout();
            ClassesPage.SuspendLayout();
            ClassesGroup.SuspendLayout();
            RectanglesPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EnumsPage);
            MainTabControl.Controls.Add(ClassesPage);
            MainTabControl.Controls.Add(RectanglesPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(684, 461);
            MainTabControl.TabIndex = 0;
            // 
            // EnumsPage
            // 
            EnumsPage.Controls.Add(EnumerationsGroup);
            EnumsPage.Location = new Point(4, 24);
            EnumsPage.Name = "EnumsPage";
            EnumsPage.Padding = new Padding(3);
            EnumsPage.Size = new Size(676, 433);
            EnumsPage.TabIndex = 0;
            EnumsPage.Text = "Enums";
            EnumsPage.UseVisualStyleBackColor = true;
            // 
            // EnumerationsGroup
            // 
            EnumerationsGroup.Controls.Add(weekdayParsing);
            EnumerationsGroup.Controls.Add(seasonsHandler);
            EnumerationsGroup.Controls.Add(enumerations);
            EnumerationsGroup.Dock = DockStyle.Fill;
            EnumerationsGroup.Location = new Point(3, 3);
            EnumerationsGroup.Name = "EnumerationsGroup";
            EnumerationsGroup.Size = new Size(670, 427);
            EnumerationsGroup.TabIndex = 7;
            EnumerationsGroup.TabStop = false;
            EnumerationsGroup.Text = "Enumerations";
            // 
            // weekdayParsing
            // 
            weekdayParsing.Location = new Point(6, 256);
            weekdayParsing.Name = "weekdayParsing";
            weekdayParsing.Size = new Size(373, 88);
            weekdayParsing.TabIndex = 10;
            // 
            // seasonsHandler
            // 
            seasonsHandler.Location = new Point(385, 256);
            seasonsHandler.Name = "seasonsHandler";
            seasonsHandler.Size = new Size(267, 88);
            seasonsHandler.TabIndex = 9;
            // 
            // enumerations
            // 
            enumerations.Location = new Point(6, 22);
            enumerations.Name = "enumerations";
            enumerations.Size = new Size(539, 228);
            enumerations.TabIndex = 8;
            // 
            // ClassesPage
            // 
            ClassesPage.Controls.Add(ClassesGroup);
            ClassesPage.Location = new Point(4, 24);
            ClassesPage.Name = "ClassesPage";
            ClassesPage.Padding = new Padding(3);
            ClassesPage.Size = new Size(676, 433);
            ClassesPage.TabIndex = 1;
            ClassesPage.Text = "Classes";
            ClassesPage.UseVisualStyleBackColor = true;
            // 
            // ClassesGroup
            // 
            ClassesGroup.Controls.Add(rectanglesInfo);
            ClassesGroup.Controls.Add(moviesInfo);
            ClassesGroup.Dock = DockStyle.Fill;
            ClassesGroup.Location = new Point(3, 3);
            ClassesGroup.Name = "ClassesGroup";
            ClassesGroup.Size = new Size(670, 427);
            ClassesGroup.TabIndex = 0;
            ClassesGroup.TabStop = false;
            ClassesGroup.Text = "Classes";
            // 
            // rectanglesInfo
            // 
            rectanglesInfo.Location = new Point(6, 24);
            rectanglesInfo.Name = "rectanglesInfo";
            rectanglesInfo.Size = new Size(293, 274);
            rectanglesInfo.TabIndex = 4;
            // 
            // moviesInfo
            // 
            moviesInfo.Location = new Point(305, 24);
            moviesInfo.Name = "moviesInfo";
            moviesInfo.Size = new Size(338, 276);
            moviesInfo.TabIndex = 1;
            // 
            // RectanglesPage
            // 
            RectanglesPage.Controls.Add(rectanglesCollisionControl);
            RectanglesPage.Location = new Point(4, 24);
            RectanglesPage.Name = "RectanglesPage";
            RectanglesPage.Size = new Size(676, 433);
            RectanglesPage.TabIndex = 2;
            RectanglesPage.Text = "Rectangles";
            RectanglesPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl
            // 
            rectanglesCollisionControl.Dock = DockStyle.Fill;
            rectanglesCollisionControl.Location = new Point(0, 0);
            rectanglesCollisionControl.Name = "rectanglesCollisionControl";
            rectanglesCollisionControl.Size = new Size(676, 433);
            rectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(684, 461);
            Controls.Add(MainTabControl);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programming Demo";
            Load += MainForm_Load;
            MainTabControl.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            EnumerationsGroup.ResumeLayout(false);
            ClassesPage.ResumeLayout(false);
            ClassesGroup.ResumeLayout(false);
            RectanglesPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage EnumsPage;
        private TabPage ClassesPage;
        private GroupBox EnumerationsGroup;
        private GroupBox ClassesGroup;
        private TabPage RectanglesPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl;
        private View.Panels.Enumerations enumerations;
        private View.Panels.MoviesInfo moviesInfo;
        private View.Panels.SeasonsHandler seasonsHandler;
        private View.Panels.WeekdayParsing weekdayParsing;
        private View.Panels.RectanglesInfo rectanglesInfo;
    }
}