using Prism.Mvvm;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications.ViewModels
{
    public class ItemViewModel : BindableBase
    {
        private string content;
        public string Content
        {
            get => content;
            set => SetProperty(ref content, value);
        }
    }
}
