using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Sample
{
    public class SampleViewModel : ViewModelBase
    {
        public string Message { get; } = "Prism Sample App";

        public SampleViewModel()
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());
        }
    }
}
