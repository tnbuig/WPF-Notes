using Caliburn.Micro;
using NotificationCollector.Model;
using NotificationCollector.Services;

namespace NotificationCollector.ViewModels
{
    public class ShellViewModel : Screen
    {
        private UserNotification _userNotification;
        public ShellViewModel()
        {
            _userNotification = new UserNotification()
            {
                Message = "Message",
                Severity = Severity.Error,
                Caption = "Error"
            };
        }

        public string CaptionText { get; set; }
        public string MessageText { get; set; }
        public bool IsBlocking { get; set; }

        public void AddNotification()
        {
            var notificationProvider = IoC.Get<IUserNotificationProvider>();
            notificationProvider.AddUserNotifcation(_userNotification);
           
        }
    }
}