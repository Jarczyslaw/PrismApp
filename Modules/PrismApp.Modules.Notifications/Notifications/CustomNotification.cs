using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications.Notifications
{
    public class CustomNotification : Notification, ICustomNotification
    {
        public DateTime TimeStamp { get; set; }
    }
}
