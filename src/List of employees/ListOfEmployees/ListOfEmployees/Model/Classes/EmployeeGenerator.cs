namespace ListOfEmployees
{
    /// <summary>
    /// Класс генерирует информация про работника.
    /// </summary>
    public static class EmployeeGenerator
    {
        /// <summary>
        /// Переменная счетчик.
        /// </summary>
        private static int _count = 0;

        /// <summary>
        /// Генерирует случайную информацию о работнике.
        /// </summary>
        /// <returns></returns>
        public static Employee Randomize()
        {
            Random random = new Random();
            int MROT = 19242;
            Names name = (Names)random.Next(Enum.GetNames(typeof(Names)).Length);
            Surnames surname = (Surnames)random.Next(Enum.GetNames(typeof(Surnames)).Length);
            Patronymics patronymic = (Patronymics)random.Next(Enum.GetNames(typeof(Patronymics)).Length);
            Positions positions = (Positions)random.Next(Enum.GetNames(typeof(Positions)).Length);
            double salary = random.Next(MROT, 500000);
            DateTime hireDate = new DateTime(random.Next(2000, DateTime.Now.Year), random.Next(1, 13), random.Next(1, 29));


            Employee employee = new Employee(name, surname, patronymic, positions,  hireDate, salary);
            _count++;
            return employee;
        }
    }
}
