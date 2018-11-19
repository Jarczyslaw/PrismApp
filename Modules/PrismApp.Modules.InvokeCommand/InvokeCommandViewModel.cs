using Prism.Commands;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.InvokeCommand
{
    public class InvokeCommandViewModel : ViewModelBase
    {
        public DelegateCommand ClickCommand { get; private set; }
        public DelegateCommand MouseEnterCommand { get; private set; }
        public DelegateCommand MouseLeaveCommand { get; private set; }

        public ObservableCollection<string> Events { get; private set; }

        public InvokeCommandViewModel()
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            Events = new ObservableCollection<string>();

            ClickCommand = new DelegateCommand(() => AddEvent("Click"));
            MouseEnterCommand = new DelegateCommand(() => AddEvent("MouseEnter"));
            MouseLeaveCommand = new DelegateCommand(() => AddEvent("MouseLeave"));
        }

        private void AddEvent(string eventName)
        {
            Events.Insert(0, $"{Events.Count + 1}. {eventName}");
        }
    }
}
