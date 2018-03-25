using NotificationCollector.Model;
using System;
using System.Collections.Generic;

namespace NotificationCollector.Services
{
    internal class UserNotificationProvider : IUserNotificationProvider
    {
        private List<UserNotification> userNotifications;

        public UserNotificationProvider()
        {
            userNotifications = new List<UserNotification>();
        }

        public event EventHandler UserNotificationsChanged;

        public int AddUserNotifcation(UserNotification userNotification)
        {
            userNotifications.Add(userNotification);

            EventHandler handler = UserNotificationsChanged;
            if (handler != null)
            {
                handler.Invoke(this, EventArgs.Empty);
            }

            return userNotifications.Count;
        }

        public List<UserNotification> GetUserNotifications()
        {
            return userNotifications;
        }
    }
}