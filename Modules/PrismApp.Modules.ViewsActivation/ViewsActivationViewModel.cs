using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.ViewsActivation
{
    public class ViewsActivationViewModel : ViewModelBase
    {
        public ViewsActivationViewModel()
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());
        }
    }
}
