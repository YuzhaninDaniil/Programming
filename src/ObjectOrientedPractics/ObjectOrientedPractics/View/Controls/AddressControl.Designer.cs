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
            AddressGroupBox = new GroupBox();
            ApartmentTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            StreetTextBox = new TextBox();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressGroupBox
            // 
            AddressGroupBox.Controls.Add(ApartmentTextBox);
            AddressGroupBox.Controls.Add(BuildingTextBox);
            AddressGroupBox.Controls.Add(CityTextBox);
            AddressGroupBox.Controls.Add(StreetTextBox);
            AddressGroupBox.Controls.Add(PostIndexTextBox);
            AddressGroupBox.Controls.Add(CountryTextBox);
            AddressGroupBox.Controls.Add(label6);
            AddressGroupBox.Controls.Add(label5);
            AddressGroupBox.Controls.Add(label4);
            AddressGroupBox.Controls.Add(label3);
            AddressGroupBox.Controls.Add(label2);
            AddressGroupBox.Controls.Add(label1);
            AddressGroupBox.Location = new Point(0, 0);
            AddressGroupBox.Name = "AddressGroupBox";
            AddressGroupBox.Size = new Size(547, 181);
            AddressGroupBox.TabIndex = 0;
            AddressGroupBox.TabStop = false;
            AddressGroupBox.Text = "Delivery Address";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(298, 122);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(116, 23);
            ApartmentTextBox.TabIndex = 11;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(77, 122);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(116, 23);
            BuildingTextBox.TabIndex = 10;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(337, 59);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(203, 23);
            CityTextBox.TabIndex = 9;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(77, 91);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(463, 23);
            StreetTextBox.TabIndex = 8;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(77, 25);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(116, 23);
            PostIndexTextBox.TabIndex = 7;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(77, 59);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(204, 23);
            CountryTextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 62);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 125);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Building:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 125);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Apartment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Street:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Country:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressGroupBox);
            Name = "AddressControl";
            Size = new Size(550, 184);
            AddressGroupBox.ResumeLayout(false);
            AddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddressGroupBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ApartmentTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
    }
}
