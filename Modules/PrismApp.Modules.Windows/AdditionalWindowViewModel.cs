using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Windows
{
    public class AdditionalWindowViewModel : ViewModelBase
    {
        public string Message { get; private set; }

        public AdditionalWindowViewModel()
        {
            Title = "Additional Window";
            Message = "Message from AdditionalWindowViewModel";
        }
    }
}
