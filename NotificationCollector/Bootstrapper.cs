﻿using Caliburn.Micro;
using NotificationCollector.Services;
using NotificationCollector.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NotificationCollector
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container;

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            container = new SimpleContainer();

            container.Singleton<IWindowManager, WindowManager>();
            container.RegisterSingleton
                (typeof(IUserNotificationProvider), 
                "UserNotificationService", 
                typeof(UserNotificationProvider));
            container.RegisterSingleton(typeof(CustomMessageBoxViewModel), "CustomMessageBoxViewModel", typeof(CustomMessageBoxViewModel));

            container.PerRequest<ShellViewModel>();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}