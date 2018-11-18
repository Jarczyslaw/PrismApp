using Prism.Interactivity.InteractionRequest;
using PrismApp.Modules.Notifications.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications.Notifications
{
    public interface ICustomConfirmation : IConfirmation
    {
        ItemViewModel SelectedItem { get; set; }
    }
}
