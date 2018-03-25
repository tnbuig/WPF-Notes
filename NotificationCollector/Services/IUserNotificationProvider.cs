using NotificationCollector.Model;
using System;
using System.Collections.Generic;

namespace NotificationCollector.Services
{
    public interface IUserNotificationProvider
    {
         event EventHandler UserNotificationsChanged;

        List<UserNotification> GetUserNotifications();

        int AddUserNotifcation(UserNotification userNotification);
    }
}