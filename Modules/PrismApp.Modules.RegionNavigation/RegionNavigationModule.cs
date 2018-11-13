using Prism.Ioc;
using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.Base;
using PrismApp.Modules.Common.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.RegionNavigation
{
    public class RegionNavigationModule : ModuleBase
    {
        public static string ContentRegion => nameof(ContentRegion);

        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.RegionNavigation, typeof(RegionNavigationView));
        }

        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
        }
    }
}
