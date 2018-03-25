using NotificationCollector.Model;
using NotificationCollector.Services;
using System.Windows;

namespace NotificationCollector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserNotificationProvider provider;
        private CustomMessageBox customMessageBox;

        public MainWindow()
        {
            InitializeComponent();
            provider = new UserNotificationProvider();
            customMessageBox = new CustomMessageBox(provider);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("alerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a condition", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            customMessageBox.Show();

            UserNotification warningNotification = new UserNotification()
            {
                Caption = "Low Battery.",
                Message = "Please connect your laptop to your charger - the battery is about to run out.",
                Severity = Severity.Warning
            };

            provider.AddUserNotifcation(warningNotification);
        }
    }
}