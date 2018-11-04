using Prism.Events;
using PrismApp.Core.Base;
using PrismApp.Core.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.EventSubscriber
{
    public class EventSubscriberViewModel : ViewModelBase
    {
        private bool receiveMessages = true;
        public bool ReceiveMessages
        {
            get { return receiveMessages; }
            set { SetProperty(ref receiveMessages, value); }
        }

        public ObservableCollection<MessageViewModel> Messages { get; private set; }

        private IEventAggregator eventAggregator;

        public EventSubscriberViewModel(IEventAggregator eventAggregator)
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            Messages = new ObservableCollection<MessageViewModel>();
            this.eventAggregator = eventAggregator;
            eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageReceived, ThreadOption.UIThread, false, m => ReceiveMessages);
        }

        private void MessageReceived(Message message)
        {
            Messages.Insert(0, new MessageViewModel(message));
        }
    }
}
