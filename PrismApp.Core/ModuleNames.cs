using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core
{
    public static class ModuleNames
    {
        public static string Sample => nameof(Sample);
        public static string Commands => nameof(Commands);
        public static string EventPublisher => nameof(EventPublisher);
        public static string EventSubscriber1 => nameof(EventSubscriber1);
        public static string EventSubscriber2 => nameof(EventSubscriber2);
        public static string Windows => nameof(Windows);
        public static string ViewsActivation => nameof(ViewsActivation);
    }
}
