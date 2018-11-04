using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.EventPublisher
{
    public class EventPublisherModule : ModuleBase
    {
        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.EventPublisher, typeof(EventPublisherView));
        }
    }
}
