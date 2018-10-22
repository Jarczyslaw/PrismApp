using PrismApp.Startup.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Startup.Services
{
    public class WindowManager : IWindowManager
    {
        private MainWindow mainWindowInstance = null;

        public void ShowMainWindow()
        {
            CreateOrRestoreWindow(ref mainWindowInstance);
        }

        public void CreateOrRestoreWindow<T>(ref T windowInstance)
            where T : Window, new()
        {
            if (!IsWindowOpen(windowInstance))
            {
                windowInstance = new T();
                windowInstance.Show();
            }
            else
            {
                if (windowInstance.WindowState == WindowState.Minimized)
                    windowInstance.WindowState = WindowState.Normal;
                windowInstance.Activate();
            }
        }

        public static bool IsWindowOpen<T>(T window)
            where T : Window
        {
            var windows = Application.Current.Windows.OfType<T>();
            return windows.Any(w => w == window);
        }
    }
}
