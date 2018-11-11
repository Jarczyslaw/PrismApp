using Prism.Commands;
using PrismApp.Core.Base;
using PrismApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Windows
{
    public class WindowsViewModel : ViewModelBase
    {
        private IPrismWindowsManager prismWindowsManager;

        public DelegateCommand ShowWindowCommand { get; private set; }
        public DelegateCommand ShowOneInstanceWindowCommand { get; private set; }
        public DelegateCommand ShowModalWindowCommand { get; private set; }

        public WindowsViewModel(IPrismWindowsManager prismWindowsManager)
        {
            this.prismWindowsManager = prismWindowsManager;

            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            ShowWindowCommand = new DelegateCommand(() => prismWindowsManager.CreateWindow<AdditionalWindow>());
            ShowOneInstanceWindowCommand = new DelegateCommand(() => prismWindowsManager.CreateOrRestoreWindow<AdditionalWindow>());
            ShowModalWindowCommand = new DelegateCommand(() => prismWindowsManager.CreateModalWindow<AdditionalWindow>());
        }
    }
}
