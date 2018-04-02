using NotificationCollector.Model;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NotificationCollector.Utilities
{
    public class SeverityToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ImageSource imageSource = null;

            if (value is Severity severity)
            {
                if (severity == Severity.Info)
                {
                    imageSource = Imaging.CreateBitmapSourceFromHIcon(
                    SystemIcons.Information.Handle,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
                }

                if (severity == Severity.Warning)
                {
                    imageSource = Imaging.CreateBitmapSourceFromHIcon(
                    SystemIcons.Warning.Handle,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
                }

                if (severity == Severity.Error)
                {
                    imageSource = Imaging.CreateBitmapSourceFromHIcon(
                    SystemIcons.Error.Handle,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
                }
            }

            return imageSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}