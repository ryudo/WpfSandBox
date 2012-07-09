namespace WpfSandBox
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    class CornarRadiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var doubleValue = (double)value;
            return doubleValue / 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
