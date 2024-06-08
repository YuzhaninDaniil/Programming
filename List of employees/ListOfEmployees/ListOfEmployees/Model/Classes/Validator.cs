namespace ListOfEmployees
{
    /// <summary>
    /// Класс проверяет целостность данных.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверяет, находится ли дробное число в указанном диапазоне.
        /// </summary>
        /// <param name="value1">Проверяемое число.</param>
        /// <param name="min">Минимум, представляющей из себя число с плавающей точкой.</param>
        /// <param name="max">Максимум, представляющей из себя число с плавающей точкой.</param>
        /// <param name="propertyName">Название поля.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertValueInRange(double value1, double min, double max, string propertyName)
        {
            if ((value1 < min) || (value1 > max))
            {
                throw new ArgumentException($"Поле {propertyName} должно находиться в диапазоне от {min} до {max}");
            }
        }

        /// <summary>
        /// Константа, хранящая буквы русского алфавита.
        /// </summary>
        private const string _symbols = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        
        /// <summary>
        /// Проверяет на ввод символов.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="propertyName">Название поля.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            value = value.ToLower();
            foreach (char c in value)
            {
                if (!_symbols.Contains(c))
                {
                    throw new ArgumentException($"Поле {propertyName} должно содержать толко латиницу");
                }
            }
        }

        /// <summary>
        /// Проверяет, находиться ли дата в указанном промежутке.
        /// </summary>
        /// <param name="selectedDate"></param>
        /// <param name="minDate">Указанная минимальная дата, год, месяц, число.</param>
        /// <param name="maxDate">Указанная максимальная дата, год, месяц, число.</param>
        /// <param name="propertyName">Название поля.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertDateTimeInRange(DateTime selectedDate, DateTime minDate, DateTime maxDate, string propertyName)
        {
            if (selectedDate < minDate || selectedDate > maxDate)
            {
                throw new ArgumentException($"Поле {propertyName} должно находиться в диапазоне от {minDate.ToShortDateString()} до {maxDate.ToShortDateString()}");
            }
        }
    }
}
