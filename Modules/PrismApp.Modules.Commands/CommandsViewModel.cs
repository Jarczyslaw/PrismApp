using Prism.Commands;
using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Commands
{
    public class CommandsViewModel : ViewModelBase
    {
        private bool isEnabled = true;
        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                SetProperty(ref isEnabled, value);
                AsyncCommand.RaiseCanExecuteChanged();
            }
        }

        private int counterValue = 0;
        public int CounterValue
        {
            get { return counterValue; }
            set { SetProperty(ref counterValue, value); }
        }

        private bool? stateValue = null;
        public bool? StateValue
        {
            get { return stateValue; }
            set
            {
                SetProperty(ref stateValue, value);
                AsyncCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ReadyToRun
        {
            get
            {
                var readyToRun = !StateValue.HasValue || StateValue.Value;
                return IsEnabled && readyToRun;
            }
        }

        public DelegateCommand IncrementCommand { get; private set; }
        public DelegateCommand AsyncCommand { get; private set; }

        public IApplicationCommands ApplicationCommands { get; private set; }

        public CommandsViewModel(IApplicationCommands applicationCommands)
        {
            ApplicationCommands = applicationCommands;

            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            IncrementCommand = new DelegateCommand(Increment)
                .ObservesCanExecute(() => IsEnabled);
            AsyncCommand = new DelegateCommand(async () => await HeavyTask())
                .ObservesCanExecute(() => ReadyToRun);
            MainCommand.ObservesCanExecute(() => IsEnabled);
            ApplicationCommands.MainCommand.RegisterCommand(MainCommand);
        }

        private void Increment()
        {
            CounterValue++;
        }

        private async Task HeavyTask()
        {
            StateValue = false;
            await Task.Delay(3000);
            StateValue = true;
        }
    }
}
