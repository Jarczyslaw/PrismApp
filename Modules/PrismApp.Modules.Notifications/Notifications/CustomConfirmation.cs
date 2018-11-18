using Prism.Interactivity.InteractionRequest;
using PrismApp.Modules.Notifications.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications.Notifications
{
    public class CustomConfirmation : Confirmation, ICustomConfirmation
    {
        public ItemViewModel SelectedItem { get; set; }
        public ObservableCollection<ItemViewModel> Items { get; set; }

        public CustomConfirmation()
        {
            Items = new ObservableCollection<ItemViewModel>
            {
                new ItemViewModel { Content = "Item1" },
                new ItemViewModel { Content = "Item2" },
                new ItemViewModel { Content = "Item3" },
            };
        }
    }
}
