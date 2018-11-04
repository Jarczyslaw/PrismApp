using Prism.Commands;
using Prism.Events;
using PrismApp.Core;
using PrismApp.Core.Base;
using PrismApp.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.EventPublisher
{
    public class EventPublisherViewModel : ViewModelBase
    {
        private string messageContent = "Test message";
        public string MessageContent
        {
            get { return messageContent; }
            set { SetProperty(ref messageContent, value); }
        }

        private int currentId = 1;
        public int CurrentId
        {
            get { return currentId; }
            set { SetProperty(ref currentId, value); }
        }

        private string sendStatus = string.Empty;
        public string SendStatus
        {
            get { return sendStatus; }
            set { SetProperty(ref sendStatus, value); }
        }

        public DelegateCommand PublishCommand { get; private set; }

        private IEventAggregator eventAggregator;

        public EventPublisherViewModel(IEventAggregator eventAggregator, IApplicationCommands applicationCommands) 
        {
            this.eventAggregator = eventAggregator;

            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            PublishCommand = new DelegateCommand(Publish);
            applicationCommands.MainCommand.RegisterCommand(MainCommand);
        }

        private void Publish()
        {
            if (!Validate())
                return;
                
            var message = new Message
            {
                Id = CurrentId,
                Content = MessageContent,
                Date = DateTime.Now
            };
            eventAggregator.GetEvent<MessageEvent>().Publish(message);

            MessageContent = string.Empty;
            CurrentId++;
        }

        private bool Validate()
        {
            SendStatus = string.Empty;
            if (string.IsNullOrEmpty(MessageContent))
            {
                SendStatus = "Message can not be empty";
                return false;
            }

            return true;
        }
    }
}
