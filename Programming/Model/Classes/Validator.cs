
namespace Programming
{
    static class Validator
    {
        static public void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Поле {propertyName} должно быть больше 0");
            }
        }

        static public void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Поле {propertyName} должно быть больше 0");
            }
        }

        static public void AssertValueInRange(int value1, int min, int max, string propertyName)
        {
            if ((value1 < min) || (value1 > max))
            {
                throw new ArgumentException($"Поле {propertyName} должно находиться в диапазоне от {min} до {max}");
            }
        }

        static public void AssertValueInRange(double value1, double min, double max, string propertyName)
        {
            if ((value1 < min) || (value1 > max))
            {
                throw new ArgumentException($"Поле {propertyName} должно находиться в диапазоне от {min} до {max}");
            }
        }
    }
}
