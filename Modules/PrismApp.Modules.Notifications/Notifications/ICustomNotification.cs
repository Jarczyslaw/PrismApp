using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications.Notifications
{
    public interface ICustomNotification : INotification
    {
        DateTime TimeStamp { get; set; }
    }
}
