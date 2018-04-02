using Caliburn.Micro;
using NotificationCollector.Model;
using NotificationCollector.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace NotificationCollector.ViewModels
{
    public class CustomMessageBoxViewModel : Screen
    {
        public ObservableCollection<UserNotification> UserNotifications { get; set; }

        public void AddUserNotification(UserNotification userNotification)
        {
            UserNotifications.Add(userNotification);
            this.SetCounter();
        }

        public string MainCaption { get; set; }

        private int _infoCount;
        private int _warnCount;
        private int _errorCount;

        public int InfoCount
        {
            get { return _infoCount; }
            set
            {
                _infoCount = value;
                NotifyOfPropertyChange(() => InfoCount);
            }
        }

        public int WarnCount
        {
            get { return _warnCount; }
            set
            {
                _warnCount = value;
                NotifyOfPropertyChange(() => WarnCount);
            }
        }

        public int ErrorCount
        {
            get { return _errorCount; }
            set
            {
                _errorCount = value;
                NotifyOfPropertyChange(() => ErrorCount);
            }
        }

        public void Close()
        {
            this.UserNotifications.Clear();
            this.TryClose();
        }

        public CustomMessageBoxViewModel()
        {
            UserNotifications = new ObservableCollection<UserNotification>();
        }

        protected override void OnDeactivate(bool close)
        {
            UserNotifications.Clear();
            base.OnDeactivate(close);
        }

        private void SetCounter()
        {
            InfoCount = WarnCount = ErrorCount = 0;

            if (UserNotifications == null || !UserNotifications.Any()) return;

            InfoCount = UserNotifications.Where(u => u.Severity == Severity.Info).Count();
            WarnCount = UserNotifications.Where(u => u.Severity == Severity.Warning).Count();
            ErrorCount = UserNotifications.Where(u => u.Severity == Severity.Error).Count();
            MainCaption = UserNotifications.First().Caption;
        }
    }
}