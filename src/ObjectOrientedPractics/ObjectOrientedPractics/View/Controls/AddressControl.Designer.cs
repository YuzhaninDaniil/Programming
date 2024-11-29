namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            AddressPanel = new Panel();
            AddressApartmentTextBox = new TextBox();
            AddressBuildingTextBox = new TextBox();
            AddressCityTextBox = new TextBox();
            AddressStreetTextBox = new TextBox();
            AddressCountryTextBox = new TextBox();
            AddressPostIndexTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddressPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddressPanel
            // 
            AddressPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressPanel.Controls.Add(AddressApartmentTextBox);
            AddressPanel.Controls.Add(AddressBuildingTextBox);
            AddressPanel.Controls.Add(AddressCityTextBox);
            AddressPanel.Controls.Add(AddressStreetTextBox);
            AddressPanel.Controls.Add(AddressCountryTextBox);
            AddressPanel.Controls.Add(AddressPostIndexTextBox);
            AddressPanel.Controls.Add(label7);
            AddressPanel.Controls.Add(label6);
            AddressPanel.Controls.Add(label5);
            AddressPanel.Controls.Add(label4);
            AddressPanel.Controls.Add(label3);
            AddressPanel.Controls.Add(label2);
            AddressPanel.Controls.Add(label1);
            AddressPanel.Location = new Point(3, 3);
            AddressPanel.Name = "AddressPanel";
            AddressPanel.Size = new Size(625, 194);
            AddressPanel.TabIndex = 0;
            // 
            // AddressApartmentTextBox
            // 
            AddressApartmentTextBox.Location = new Point(254, 128);
            AddressApartmentTextBox.Name = "AddressApartmentTextBox";
            AddressApartmentTextBox.Size = new Size(101, 23);
            AddressApartmentTextBox.TabIndex = 12;
            AddressApartmentTextBox.TextChanged += AddressApartmentTextBox_TextChanged;
            // 
            // AddressBuildingTextBox
            // 
            AddressBuildingTextBox.Location = new Point(74, 128);
            AddressBuildingTextBox.Name = "AddressBuildingTextBox";
            AddressBuildingTextBox.Size = new Size(101, 23);
            AddressBuildingTextBox.TabIndex = 11;
            AddressBuildingTextBox.TextChanged += AddressBuildingTextBox_TextChanged;
            // 
            // AddressCityTextBox
            // 
            AddressCityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressCityTextBox.Location = new Point(338, 70);
            AddressCityTextBox.Name = "AddressCityTextBox";
            AddressCityTextBox.Size = new Size(284, 23);
            AddressCityTextBox.TabIndex = 10;
            AddressCityTextBox.TextChanged += AddressCityTextBox_TextChanged;
            // 
            // AddressStreetTextBox
            // 
            AddressStreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressStreetTextBox.Location = new Point(74, 99);
            AddressStreetTextBox.Name = "AddressStreetTextBox";
            AddressStreetTextBox.Size = new Size(548, 23);
            AddressStreetTextBox.TabIndex = 9;
            AddressStreetTextBox.TextChanged += AddressStreetTextBox_TextChanged;
            // 
            // AddressCountryTextBox
            // 
            AddressCountryTextBox.Location = new Point(74, 70);
            AddressCountryTextBox.Name = "AddressCountryTextBox";
            AddressCountryTextBox.Size = new Size(221, 23);
            AddressCountryTextBox.TabIndex = 8;
            AddressCountryTextBox.TextChanged += AddressCountryTextBox_TextChanged;
            // 
            // AddressPostIndexTextBox
            // 
            AddressPostIndexTextBox.Location = new Point(74, 41);
            AddressPostIndexTextBox.Name = "AddressPostIndexTextBox";
            AddressPostIndexTextBox.Size = new Size(139, 23);
            AddressPostIndexTextBox.TabIndex = 7;
            AddressPostIndexTextBox.TextChanged += AddressPostIndexTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 73);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 6;
            label7.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 102);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Street:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 134);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Apartment:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 134);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Building:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Country:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(113, 17);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressPanel);
            Name = "AddressControl";
            Size = new Size(631, 200);
            AddressPanel.ResumeLayout(false);
            AddressPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddressPanel;
        private Label label2;
        private Label label1;
        private TextBox AddressApartmentTextBox;
        private TextBox AddressBuildingTextBox;
        private TextBox AddressCityTextBox;
        private TextBox AddressStreetTextBox;
        private TextBox AddressCountryTextBox;
        private TextBox AddressPostIndexTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
