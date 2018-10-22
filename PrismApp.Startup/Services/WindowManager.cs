using PrismApp.Startup.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Startup.Services
{
    public class WindowManager : IWindowManager
    {
        public void Show()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
