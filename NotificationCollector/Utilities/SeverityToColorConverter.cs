using NotificationCollector.Model;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace NotificationCollector.Utilities
{
    public class SeverityToColorConverter  : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        SolidColorBrush color = null;

        if (value is Severity severity)
        {
            if (severity == Severity.Info)
            {
                    color = new BrushConverter().ConvertFromString("#3E66CD") as SolidColorBrush;
            }

            if (severity == Severity.Warning)
            {
                    color = new BrushConverter().ConvertFromString("#EFC500") as SolidColorBrush;
                }

            if (severity == Severity.Error)
            {
                color = new BrushConverter().ConvertFromString("#B20808") as SolidColorBrush;
            }
        }

        return color;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
}