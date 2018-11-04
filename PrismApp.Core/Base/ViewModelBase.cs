using Prism.Commands;
using Prism.Mvvm;
using PrismApp.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core.Base
{
    public class ViewModelBase : BindableBase
    {
        public string Title { get; set; }

        public DelegateCommand MainCommand { get; private set; }

        public ViewModelBase()
        {
            Title = GetType().Name;
            MainCommand = new DelegateCommand(MainCommandAction);
        }

        protected string GetModuleTitle(Assembly assembly)
        {
            var modules = assembly.FindDerivedTypes(typeof(ModuleBase));
            return modules.SingleOrDefault().Name;
        }

        private void MainCommandAction()
        {
            Debug.WriteLine("Main action invoked in: " + GetType().Name);
        }
    }
}
