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
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if(value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
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
            if (number < minValue || number > maxValue)
            {
                throw new ArgumentException($"{propertyName} должен быть в диапазоне от {minValue} до {maxValue}.");
            }
        }
    }
}
