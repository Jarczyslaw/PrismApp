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
        public void ShowMainWindow()
        {
            CreateOrRestoreWindow<MainWindow>();
        }

        public void CreateOrRestoreWindow<T>()
            where T : Window, new()
        {
            if (!IsWindowOpen<T>())
                Show<T>(null);
            else
                RestoreWindows<T>();
        }
    }
}
