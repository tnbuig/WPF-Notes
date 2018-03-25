using NotificationCollector.Model;
using NotificationCollector.Services;
using NotificationCollector.ViewModels;
using System.Collections.ObjectModel;

namespace NotificationCollector.DesignTimeData
{
    public class MockCustomMessageBoxViewModel : CustomMessageBoxViewModel
    {
        public MockCustomMessageBoxViewModel() : base(new UserNotificationProvider())
        {
            this.UserNotifications = new ObservableCollection<UserNotification>()
            {
                new UserNotification()
                {
                    Caption = "Low Battery.",
                    Message = "Please connect your laptop to your charger - the battery is about to run out.",
                    Severity = Severity.Warning
                }
            };
        }

        public MockCustomMessageBoxViewModel(IUserNotificationProvider userNotificationProvider) : base(userNotificationProvider)
        {
          
        }
    }
}