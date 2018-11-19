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
        public static string EventSubscriber => nameof(EventSubscriber);
        public static string Windows => nameof(Windows);
        public static string ViewsActivation => nameof(ViewsActivation);
        public static string RegionNavigation => nameof(RegionNavigation);
        public static string Notifications => nameof(Notifications);
        public static string InvokeCommand => nameof(InvokeCommand);
    }
}
