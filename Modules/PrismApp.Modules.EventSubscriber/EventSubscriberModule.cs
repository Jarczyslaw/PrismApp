using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.EventSubscriber
{
    public class EventSubscriberModule : ModuleBase
    {
        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.EventSubscriber1, typeof(EventSubscriberView));
            regionManager.RegisterViewWithRegion(ModuleNames.EventSubscriber2, typeof(EventSubscriberView));
        }
    }
}
