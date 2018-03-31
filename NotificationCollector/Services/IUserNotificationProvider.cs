using NotificationCollector.Model;

namespace NotificationCollector.Services
{
    public interface IUserNotificationProvider
    {
        bool IsNotificationVisible
        {
            get;
        }

        int AddUserNotifcation(UserNotification userNotification);
    }
}