using Prism.Commands;
using Prism.Mvvm;
using PrismApp.Core;
using PrismApp.Core.Base;
using PrismApp.Startup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Startup.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public DelegateCommand ShowMainWindowCommand { get; private set; }

        private IPrismWindowManager windowManager;

        public ShellViewModel(IPrismWindowManager windowManager)
        {
            this.windowManager = windowManager;

            Title = "Prism Sample App";

            ShowMainWindowCommand = new DelegateCommand(() =>
            {
                Debug.WriteLine("Show main window");
                windowManager.ShowMainWindow();
            });
        }
    }
}
