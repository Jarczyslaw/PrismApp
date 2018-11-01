using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using PrismApp.Core;
using PrismApp.Modules.Commands;
using PrismApp.Modules.Sample;
using PrismApp.Startup.Services;
using PrismApp.Startup.Views;
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
            var modules = base.CreateModuleCatalog();
            modules.AddModule<SampleModule>();
            modules.AddModule<CommandsModule>();
            return modules;
        }

        protected override void RegisterRequiredTypes(IContainerRegistry containerRegistry)
        {
            DebugInfo();
            base.RegisterRequiredTypes(containerRegistry);
            containerRegistry.Register<IPrismWindowManager, PrismWindowsManager>();
            containerRegistry.Register<IAppResourcesLoader, AppResourcesLoader>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            DebugInfo();
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        private void DebugInfo([CallerMemberName]string callerName = "")
        {
            if (!string.IsNullOrEmpty(callerName))
                Debug.WriteLine(callerName);
        }
    }
}
