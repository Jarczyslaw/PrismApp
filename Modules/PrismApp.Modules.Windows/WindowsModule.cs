using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Windows
{
    public class WindowsModule : ModuleBase
    {
        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.Windows, typeof(WindowsView));
        }
    }
}
