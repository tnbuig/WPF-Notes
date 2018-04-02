using Caliburn.Micro;
using NotificationCollector.Model;
using NotificationCollector.Services;
using System.Collections.Generic;

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
            if (string.IsNullOrWhiteSpace(MessageText))
            {
                this.MessageText = "Export to Excel Completed successfully";
                this.CaptionText = "Export To Excel";
            }

            this.Severity = Severity.Info;
            this.AddNewNotification();
        }

        public void ShowAsWarning()
        {
            if (string.IsNullOrWhiteSpace(MessageText))
            {
                this.MessageText = "Change your battery or switch to outlet power immediately." +
                    " Your computer has a low battery, so you should act immediately to keep from losing your work";
                this.CaptionText = "Low Battery";
            }

            this.Severity = Severity.Warning;

            this.AddNewNotification();
        }

        public void ShowAsError()
        {
            if (string.IsNullOrWhiteSpace(MessageText))
            {
                this.MessageText = "Change your battery or switch to outlet power immediately." +
                    " Your computer has a low battery, so you should act immediately to keep from losing your work";
                this.CaptionText = "Low Battery";
            }

            this.Severity = Severity.Error;

            this.AddNewNotification();
        }

        private void AddNewNotification()
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
    }
}