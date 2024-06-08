using System.Windows.Forms;
using System.Text.Json;
using System.IO;


namespace ListOfEmployees
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������, �������� �������� ������ Employee.
        /// </summary>
        private List<Employee> employeesList = new List<Employee>();
        /// <summary>
        /// ��������� ������ Employee.
        /// </summary>
        private Employee currentEmployee;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ������������� ������ �������� ��������� ��� �������� �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();

            if (employeesList.Count == 0)
            {
                employeesList.Add(EmployeeGenerator.Randomize());
            }
            currentEmployee = employeesList[0];
            RewriteData();
            EmployeesListBox.SelectedIndex = 0;

        }
        /// <summary>
        /// ��������� �� �������� �� ����������� �������� ������ � ��������� ListBox.
        /// </summary>
        private void RewriteData()
        {
            employeesList.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            EmployeesListBox.Items.Clear();



            foreach (Employee book in employeesList)
            {
                EmployeesListBox.Items.Add(book.ToString());
            }
        }

        /// <summary>
        /// ����� ��������� �������� �������� ListBox �������� ��������������� �������� � ������ ���������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedIndex < 0)
            {
                FullNameTextBox.Clear();
                PositionTextBox.Clear();
                SalaryTextBox.Clear();
            }
            else
            {
                currentEmployee = employeesList[EmployeesListBox.SelectedIndex];

                FullNameTextBox.Text = currentEmployee.ToString();
                PositionTextBox.Text = currentEmployee.Position.ToString();
                HireDateTimePicker.Value = currentEmployee.HireDate;
                SalaryTextBox.Text = currentEmployee.Salary.ToString();
            }
        }

        /// <summary>
        /// ��������� ������ ����� �������� �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// ������ ��� ���������� �������� � ������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            employeesList.Add(EmployeeGenerator.Randomize());
            RewriteData();
        }

        /// <summary>
        /// ������ ��� �������� ���������� �������� ListBox �� ������ � ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedIndex == -1) { return; }
            employeesList.RemoveAt(EmployeesListBox.SelectedIndex);
            EmployeesListBox.Items.RemoveAt(EmployeesListBox.SelectedIndex);
            RewriteData();
        }

        /// <summary>
        /// ��������� ������ ���������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedIndex == -1)
            {
                return;
            }
            SaveEmployeesInfo();

            FullNameTextBox.Clear();
            PositionTextBox.Clear();
            SalaryTextBox.Clear();
            EmployeesListBox.SelectedIndex = 0;
        }
        /// <summary>
        /// ��������� ���������� � ����������.
        /// </summary>
        private void SaveEmployeesInfo()
        {
            try
            {
                if (Enum.TryParse(PositionTextBox.Text, out Positions newPosition))
                {
                    currentEmployee.Position = newPosition;
                    PositionTextBox.BackColor = AppColors.White;
                }
                else
                {
                    PositionTextBox.BackColor = AppColors.LightPink;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message);
            }

            try
            {
                currentEmployee.HireDate = HireDateTimePicker.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message);
            }

            try
            {
                double salary = double.Parse(SalaryTextBox.Text);
                currentEmployee.Salary = salary;
                SalaryTextBox.BackColor = AppColors.White;

            }
            catch (ArgumentException ex)
            {
                SalaryTextBox.BackColor = AppColors.LightPink;
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                SalaryTextBox.BackColor = AppColors.LightPink;
            }

            EmployeesListBox.Items[EmployeesListBox.SelectedIndex] = currentEmployee.ToString();

            RewriteData();
        }

        /// <summary>
        /// ������������ �������, ���� �������� �������� ���� ��������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double salary = double.Parse(SalaryTextBox.Text);
                currentEmployee.Salary = salary;
                SalaryTextBox.BackColor = AppColors.White;

            }
            catch (ArgumentException ex)
            {
                SalaryTextBox.BackColor = AppColors.LightPink;
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                SalaryTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// ������������ �������, ���� �������� �������� ���� ��������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PositionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Enum.TryParse(PositionTextBox.Text, out Positions newPosition))
                {
                    currentEmployee.Position = newPosition;
                    PositionTextBox.BackColor = AppColors.White;
                }
                else
                {
                    PositionTextBox.BackColor = AppColors.LightPink;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message);
            }
        }
        /// <summary>
        /// ������������ �������, ���� �������� �������� ���� ��������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HireDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                currentEmployee.HireDate = HireDateTimePicker.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message);
            }
        }
        /// <summary>
        /// ��������� ������ � ����.
        /// </summary>
        public void SaveData()
        {
            string path = Environment.CurrentDirectory + @"\info.txt";
            string data = JsonSerializer.Serialize(employeesList);
            File.WriteAllText(path, data);
        }

        /// <summary>
        /// ��������� ������ � ����.
        /// </summary>
        public void LoadData()
        {
            string path = Environment.CurrentDirectory + @"\info.txt";
            if (!File.Exists(path)) return;
            string data = File.ReadAllText(path);
            employeesList = JsonSerializer.Deserialize<List<Employee>>(data);
            RewriteData();
        }

    }
}