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

            UserNotification notification = new UserNotification()
            {
                Caption = "Low Battery.",
                Message = "Please connect your laptop to your charger - the battery is about to run out.",
                Severity = Severity.Warning
            };

            provider.AddUserNotifcation(notification);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserNotification notification = new UserNotification()
            {
                Caption = "Time zone updated.",
                Message = "Ladies and gentlemen, the Captain has turned on the Fasten Seat Belt sign. If you haven’t already done so, please stow your carry-on luggage underneath the seat in front of you or in an overhead bin. Please take your seat and fasten your seat belt.",
                Severity = Severity.Info
            };

            provider.AddUserNotifcation(notification);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UserNotification notification = new UserNotification()
            {
                Caption = "Your plain successfully crashed.",
                Message = "Flight attendants / Cabin Crew please prepare for gate departure. Flight attendants / Cabin Crew, doors on automatic, cross - check and report.Thank you.",
                Severity = Severity.Error
            };

            provider.AddUserNotifcation(notification);
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Flight attendants / Cabin Crew please prepare for gate departure. Flight attendants / Cabin Crew, doors on automatic, cross - check and report.Thank you.", "Your plain successfully crashed.", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}