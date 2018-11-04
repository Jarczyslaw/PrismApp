using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core.Events
{
    public class Message
    {
        public bool IsMulticast { get; set; }
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
