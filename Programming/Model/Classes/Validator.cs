
namespace Programming
{
    /// <summary>
    /// Класс проверяет целостность данных.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверяет ввод целого числа на отрицательное значение.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="propertyName">Название поля.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Поле {propertyName} должно быть больше 0");
            }
        }

        /// <summary>
        /// Проверяет ввод числа с плавающей точкой на отрицательное значение.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="propertyName">Название поля.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Поле {propertyName} должно быть больше 0");
            }
        }

        /// <summary>
        /// Проверяет, находится ли целочисленное число в указанном диапазоне.
        /// </summary>
        /// <param name="value1">Проверяемое число.</param>
        /// <param name="min">Целочисленный минимум.</param>
        /// <param name="max">Целочисленный максимум.</param>
        /// <param name="propertyName">Название поля.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertValueInRange(int value1, int min, int max, string propertyName)
        {
            if ((value1 < min) || (value1 > max))
            {
                throw new ArgumentException($"Поле {propertyName} должно находиться в диапазоне от {min} до {max}");
            }
        }

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
    }
}
