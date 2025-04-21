using System.Globalization;
using System.Windows.Data;

namespace View.ViewModel
{
    /// <summary>
    /// Инвертирует булево значение (true меняется на false и наоборот).
    /// </summary>
    class BooleanInverseConverter : IValueConverter
    {
        ///<inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        ///<inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
