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
            customMessageBoxViewModel.AddUserNotification(userNotification);
            
            if (!customMessageBoxViewModel.IsActive)
            {
                if (!userNotification.Blocking)
                {
                    windowsManager.ShowWindow(customMessageBoxViewModel);
                }
                else
                {
                    windowsManager.ShowDialog(customMessageBoxViewModel);
                }
            }

            return customMessageBoxViewModel.UserNotifications.Count;
        }
    }
}