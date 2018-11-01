using PrismApp.Core;
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
        public string Message { get; } = "Message from Sample Module";

        public SampleViewModel()
        {
            Title = GetCorrespondingModuleName(Assembly.GetExecutingAssembly());
        }
    }
}
