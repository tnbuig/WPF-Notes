using Caliburn.Micro;
using NotificationCollector.Model;
using NotificationCollector.ViewModels;
using System.Collections.Generic;

namespace NotificationCollector.Services
{
    internal class UserNotificationProvider : IUserNotificationProvider
    {
        private IWindowManager _windowManager;

        public UserNotificationProvider(IWindowManager windowManager)
        {
            this._windowManager = windowManager;
        }

        public bool IsNotificationVisible => false;

        public int AddUserNotifcation(UserNotification userNotification)
        {
            var windowsManager = IoC.Get<IWindowManager>();
            var customMessageBoxViewModel = IoC.Get<CustomMessageBoxViewModel>();
            
            if (!customMessageBoxViewModel.IsActive)
            {
                customMessageBoxViewModel.UserNotifications.Clear();
                if (!userNotification.Blocking)
                {
                    windowsManager.ShowWindow(customMessageBoxViewModel);
                }
                else
                {
                    windowsManager.ShowDialog(customMessageBoxViewModel);
                }
            }

            customMessageBoxViewModel.AddUserNotification(userNotification);
            
            return customMessageBoxViewModel.UserNotifications.Count;
        }
    }
}