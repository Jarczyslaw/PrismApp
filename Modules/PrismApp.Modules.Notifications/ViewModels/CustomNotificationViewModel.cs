using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using PrismApp.Core.Base;
using PrismApp.Modules.Notifications.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications.ViewModels
{
    public class CustomNotificationViewModel : BindableBase, IInteractionRequestAware
    {
        private ICustomNotification notification;
        public INotification Notification
        {
            get => notification;
            set => SetProperty(ref notification, (ICustomNotification)value);
        }

        public Action FinishInteraction { get; set; }

        public DelegateCommand OkCommand { get; private set; }

        public CustomNotificationViewModel()
        {
            OkCommand = new DelegateCommand(() => FinishInteraction?.Invoke());
        }
    }
}
