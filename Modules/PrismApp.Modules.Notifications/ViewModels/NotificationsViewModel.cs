using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using PrismApp.Core.Base;
using PrismApp.Modules.Notifications.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications.ViewModels
{
    public class NotificationsViewModel : ViewModelBase
    {
        private string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public InteractionRequest<INotification> DefaultNotificationRequest { get; set; }
        public InteractionRequest<IConfirmation> DefaultConfirmationRequest { get; set; }
        public InteractionRequest<ICustomNotification> CustomNotificationRequest { get; set; }
        public InteractionRequest<ICustomConfirmation> CustomConfirmationRequest { get; set; }

        public DelegateCommand DefaultNotificationCommand { get; private set; }
        public DelegateCommand DefaultConfirmationCommand { get; private set; }
        public DelegateCommand CustomNotificationCommand { get; private set; }
        public DelegateCommand CustomConfirmationCommand { get; private set; }

        public NotificationsViewModel()
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            DefaultNotificationRequest = new InteractionRequest<INotification>();
            DefaultConfirmationRequest = new InteractionRequest<IConfirmation>();
            CustomNotificationRequest = new InteractionRequest<ICustomNotification>();
            CustomConfirmationRequest = new InteractionRequest<ICustomConfirmation>();

            DefaultNotificationCommand = new DelegateCommand(() =>
            {
                var notification = new Notification
                {
                    Title = "Default notification title",
                    Content = "Default notification content"
                };
                DefaultNotificationRequest.Raise(notification, DefaultNotificationCallback);
            });
            DefaultConfirmationCommand = new DelegateCommand(() =>
            {
                var confirmation = new Confirmation
                {
                    Title = "Default confirmation title",
                    Content = "Default confirmation content"
                };
                DefaultConfirmationRequest.Raise(confirmation, DefaultConfirmationCallback);
            });
            CustomNotificationCommand = new DelegateCommand(() =>
            {
                var notification = new CustomNotification
                {
                    Title = "Custom notification title",
                    Content = "Custom notification content",
                    TimeStamp = DateTime.Now
                };
                CustomNotificationRequest.Raise(notification, CustomNotificationCallback);
            });
            CustomConfirmationCommand = new DelegateCommand(() =>
            {
                var confirmation = new CustomConfirmation
                {
                    Title = "Custom confirmation title"
                };
                CustomConfirmationRequest.Raise(confirmation, CustomConfirmationCallback);
            });
        }

        private void DefaultNotificationCallback(INotification notification)
        {
            Message = "Notified";
        }

        private void DefaultConfirmationCallback(IConfirmation confirmation)
        {
            Message = confirmation.Confirmed ? "Confirmed" : "Not confirmed";
        }

        private void CustomNotificationCallback(ICustomNotification notification)
        {
            var duration = DateTime.Now - notification.TimeStamp;
            Message = $"Custom notification duration: {duration.TotalSeconds:0.00} sec";
        }

        private void CustomConfirmationCallback(ICustomConfirmation confirmation)
        {
            if (confirmation.Confirmed)
                Message = $"{confirmation.SelectedItem.Content} confirmed!";
            else
                Message = "Item selection was cancelled";
        }
    }
}
