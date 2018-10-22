using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core
{
    public class ViewModelBase : BindableBase
    {
        public string Title { get; set; }
    }
}
