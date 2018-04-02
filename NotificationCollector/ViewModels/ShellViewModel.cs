using Caliburn.Micro;
using NotificationCollector.Model;
using NotificationCollector.Services;

namespace NotificationCollector.ViewModels
{
    public class ShellViewModel : Screen
    {
        public ShellViewModel()
        {
        }

        public Severity Severity { get; set; }
        public string CaptionText { get; set; }
        public string MessageText { get; set; }
        public bool IsBlocking { get; set; }

        public void AddNotification()
        {
            var notificationProvider = IoC.Get<IUserNotificationProvider>();

            var userNotification = new UserNotification()
            {
                Message = this.MessageText,
                Severity = this.Severity,
                Caption = this.CaptionText,
                Blocking = this.IsBlocking
            };

            notificationProvider.AddUserNotifcation(userNotification);
        }

        public void ShowAsInfo()
        {
            string messageText = "Export to Excel Completed successfully";
            string captionText = "Export To Excel";

            this.Severity = Severity.Info;
            this.AddNewNotification(captionText, messageText);
        }

        public void ShowAsWarning()
        {
            string messageText = "Change your battery or switch to outlet power immediately." +
                " Your computer has a low battery, so you should act immediately to keep from losing your work";
            string captionText = "Low Battery";

            this.Severity = Severity.Warning;

            this.AddNewNotification(captionText, messageText);
        }

        public void ShowAsError()
        {
            string messageText = "The printer installation failed. Operation could not be completed (error 0x000043)";
            string captionText = "Add Printer";
            
            this.Severity = Severity.Error;

            this.AddNewNotification(captionText, messageText);
        }

        private void AddNewNotification(string caption, string message)
        {
            var notificationProvider = IoC.Get<IUserNotificationProvider>();

            if (string.IsNullOrWhiteSpace(MessageText))
            {
                this.MessageText = message;
                this.CaptionText = caption;
            }

            var userNotification = new UserNotification()
            {
                Message = this.MessageText,
                Severity = this.Severity,
                Caption = this.CaptionText,
                Blocking = this.IsBlocking
            };

            notificationProvider.AddUserNotifcation(userNotification);

            this.MessageText = string.Empty;
            this.CaptionText = string.Empty;
        }
    }
}