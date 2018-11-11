using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.ViewsActivation
{
    public class ViewsActivationModule : ModuleBase
    {
        public static string ViewsActivationRegion => nameof(ViewsActivationRegion);

        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.ViewsActivation, typeof(ViewsActivationView));
        }
    }
}
