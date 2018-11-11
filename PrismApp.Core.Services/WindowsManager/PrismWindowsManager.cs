using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Core.Services
{
    public class PrismWindowsManager : WindowsManager, IPrismWindowsManager
    {
        private IContainerExtension container;

        public PrismWindowsManager(IContainerExtension container)
        {
            this.container = container;
        }

        public void CreateWindow<T>()
            where T : Window
        {
            var window = container.Resolve<T>();
            Show(window, null);
        }

        public void CreateModalWindow<T>()
            where T : Window
        {
            var window = container.Resolve<T>();
            ShowModal(window, null);
        }

        public void CreateOrRestoreWindow<T>()
            where T : Window
        {
            if (!IsWindowOpen<T>())
                CreateWindow<T>();
            else
                RestoreWindows<T>();
        }
    }
}
