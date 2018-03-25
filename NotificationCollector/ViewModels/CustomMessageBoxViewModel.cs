using NotificationCollector.Model;
using NotificationCollector.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace NotificationCollector.ViewModels
{
    public class CustomMessageBoxViewModel : INotifyPropertyChanged
    {
        private IUserNotificationProvider userNotificationProvider;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<UserNotification> UserNotifications { get; set; }

        public string MainCaption { get; set; }

        public int InfoCount { get; set; }
        public int WarnCount { get; set; }
        public int ErrorCount { get; set; }

        public CustomMessageBoxViewModel(IUserNotificationProvider userNotificationProvider)
        {
            if (userNotificationProvider == null)
            {
                throw new NullReferenceException("User Notification Provider");
            }

            this.userNotificationProvider = userNotificationProvider;
            UserNotifications = new ObservableCollection<UserNotification>();
            userNotificationProvider.UserNotificationsChanged += OnNotificationsChanged;
        }

        private void OnNotificationsChanged(object sender, EventArgs e)
        {
            UserNotifications.Clear();
            var userNotifications = this.userNotificationProvider?.GetUserNotifications();
            if (userNotifications == null) return;

            foreach (var userNotification in userNotifications)
            {
                UserNotifications.Add(userNotification);
            }

            this.SetCounter();
        }

        private void SetCounter()
        {
            InfoCount = WarnCount = ErrorCount = 0;

            if (UserNotifications == null || !UserNotifications.Any()) return;

            InfoCount = UserNotifications.Where(u => u.Severity == Severity.Info).Count();
            WarnCount = UserNotifications.Where(u => u.Severity == Severity.Warning).Count();
            ErrorCount = UserNotifications.Where(u => u.Severity == Severity.Error).Count();
            MainCaption = UserNotifications.First().Caption;

            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(string.Empty));
            }
            
        }
    }
}