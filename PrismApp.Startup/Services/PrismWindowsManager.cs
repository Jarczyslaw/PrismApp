using Prism.Ioc;
using PrismApp.Startup.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Startup.Services
{
    public class PrismWindowsManager : WindowsManager, IPrismWindowManager
    {
        private IContainerExtension container;

        public PrismWindowsManager(IContainerExtension container)
        {
            this.container = container;
        }

        public void ShowMainWindow()
        {
            CreateOrRestoreWindow<MainWindow>();
        }

        public void CreateOrRestoreWindow<T>()
            where T : Window, new()
        {
            if (!IsWindowOpen<T>())
            {
                var window = container.Resolve<T>();
                Show(window, null);
            }  
            else
                RestoreWindows<T>();
        }
    }
}
