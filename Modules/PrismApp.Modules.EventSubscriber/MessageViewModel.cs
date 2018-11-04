using PrismApp.Core.Base;
using PrismApp.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.EventSubscriber
{
    public class MessageViewModel : ViewModelBase
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { SetProperty(ref date, value); }
        }

        private string content;
        public string Content
        {
            get { return content; }
            set { SetProperty(ref content, value); }
        }
       
        public MessageViewModel() { }

        public MessageViewModel(Message message)
        {
            Id = message.Id;
            Date = message.Date;
            Content = message.Content;
        }
    }
}
