using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using PrismApp.Core;
using PrismApp.Core.Services;
using PrismApp.Modules.Commands;
using PrismApp.Modules.EventPublisher;
using PrismApp.Modules.EventSubscriber;
using PrismApp.Modules.InvokeCommand;
using PrismApp.Modules.Notifications;
using PrismApp.Modules.RegionNavigation;
using PrismApp.Modules.Sample;
using PrismApp.Modules.ViewsActivation;
using PrismApp.Modules.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Startup
{
    public partial class App : PrismApplication
    {
        public override void Initialize()
        {
            DebugInfo();
            base.Initialize();
        }

        protected override void OnInitialized()
        {
            DebugInfo();
            base.OnInitialized();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DebugInfo();
            base.OnStartup(e);
        }

        protected override Window CreateShell()
        {
            DebugInfo();
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell(Window shell)
        {
            DebugInfo();
            Current.MainWindow = shell;
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            DebugInfo();
            return GetModules();
        }

        protected override void RegisterRequiredTypes(IContainerRegistry containerRegistry)
        {
            DebugInfo();
            base.RegisterRequiredTypes(containerRegistry);
            containerRegistry.RegisterSingleton<IPrismWindowsManager, PrismWindowsManager>();
            containerRegistry.RegisterSingleton<IAppResourcesLoader, AppResourcesLoader>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            DebugInfo();
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        private IModuleCatalog GetModules()
        {
            var modules = base.CreateModuleCatalog();
            modules.AddModule<SampleModule>();
            modules.AddModule<WindowsModule>();
            modules.AddModule<CommandsModule>();
            modules.AddModule<EventPublisherModule>();
            modules.AddModule<EventSubscriberModule>();
            modules.AddModule<ViewsActivationModule>();
            modules.AddModule<RegionNavigationModule>();
            modules.AddModule<NotificationsModule>();
            modules.AddModule<InvokeCommandModule>();
            return modules;
        }

        private void DebugInfo([CallerMemberName]string callerName = "")
        {
            if (!string.IsNullOrEmpty(callerName))
                Debug.WriteLine(callerName);
        }
    }
}
