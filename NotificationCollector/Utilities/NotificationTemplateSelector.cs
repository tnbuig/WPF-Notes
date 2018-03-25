using NotificationCollector.Model;
using System.Windows;
using System.Windows.Controls;

namespace NotificationCollector.Utilities
{
    public class NotificationTemplateSelector : DataTemplateSelector
    {
        public DataTemplate InformationNotificationTemplate { get; set; }
        public DataTemplate WarningNotificationTemplate { get; set; }
        public DataTemplate ErrorNotificationTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var userNotification = item as UserNotification;
            if (userNotification == null)
                return null;
            switch (userNotification.Severity)
            {
                case Severity.Info:
                    return InformationNotificationTemplate;

                case Severity.Warning:
                    return WarningNotificationTemplate;

                case Severity.Error:
                    return ErrorNotificationTemplate;
            }
            return null;
        }
    }
}