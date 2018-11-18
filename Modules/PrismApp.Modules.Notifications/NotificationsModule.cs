using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.Base;
using PrismApp.Modules.Notifications.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Notifications
{
    public class NotificationsModule : ModuleBase
    {
        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.Notifications, typeof(NotificationsView));
        }
    }
}
