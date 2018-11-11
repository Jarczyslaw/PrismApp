using Prism.Commands;
using Prism.Mvvm;
using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Startup
{
    public class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            Title = "Prism Sample App";
        }
    }
}
