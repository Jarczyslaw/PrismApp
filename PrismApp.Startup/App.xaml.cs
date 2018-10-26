using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using PrismApp.Core;
using PrismApp.Modules.Sample;
using PrismApp.Startup.Services;
using PrismApp.Startup.Utilities;
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
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            DebugInfo();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            DebugInfo();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DebugInfo();
        }

        protected override Window CreateShell()
        {
            DebugInfo();
            LoadApplicationResources();
            return new Shell();
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
            return modules;
        }

        protected override void RegisterRequiredTypes(IContainerRegistry containerRegistry)
        {
            DebugInfo();
            base.RegisterRequiredTypes(containerRegistry);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            DebugInfo();
            containerRegistry.Register<IWindowManager, WindowManager>();
        }

        private void DebugInfo([CallerMemberName]string callerName = "")
        {
            if (!string.IsNullOrEmpty(callerName))
                Debug.WriteLine(callerName);
        }

        private void LoadApplicationResources()
        {
            AppResourcesLoader.LoadColors();
            AppResourcesLoader.LoadStyles();
        }
    }
}
