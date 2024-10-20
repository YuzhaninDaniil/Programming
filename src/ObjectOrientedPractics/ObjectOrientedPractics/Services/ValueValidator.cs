namespace ObjectOrientedPractics
{
    /// <summary>
    /// Проверяет корректность данных
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки и указанного для нее максимума.
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="maxLength">Максимальная длина для строки</param>
        /// <param name="propertyName">Имя свойства</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string str, int maxLength, string propertyName)
        {
            if(str.Length > maxLength)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно быть меньше {maxLength} символов.");
            }
        }

        /// <summary>
        /// Проверяет строку на null или на пустоту.
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="propertyName">Имя свойства</param>
        /// <exception cref="ArgumentException"></exception>
        public static void IsStringNullOrEmpty(string str, string propertyName)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException($"Значение свойства {propertyName} не должно быть null или пустым.");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в указанном диапазоне.
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="minValue">Нижняя граница диапазоне</param>
        /// <param name="maxValue">Верхняя граница диапазона</param>
        /// <param name="propertyName">Имя свойства</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void CheckNumberInRange(double number, double minValue, double maxValue, string propertyName)
        {
            if(number < minValue)
            {
                throw new ArgumentOutOfRangeException($"Значение свойства {propertyName} должно быть >= {minValue}");
            }
            if (number > maxValue)
            {
                throw new ArgumentOutOfRangeException($"Значение свойства {propertyName} должно быть <= {maxValue}");
            }
        }
    }
}
