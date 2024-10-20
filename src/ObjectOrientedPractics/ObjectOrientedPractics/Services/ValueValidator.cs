namespace ObjectOrientedPractics
{
    internal static class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if(value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
            }
        }

        public static void IsStringNullOrEmpty(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{propertyName} не должно быть null или пустым.");
            }
        }
        public static void CheckNumberInRange(double value, double minValue, double maxValue, string propertyName)
        {
            if(value < minValue)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} должно быть >= {minValue}");
            }
            if (value > maxValue)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} должно быть <= {maxValue}");
            }
        }
    }
}
