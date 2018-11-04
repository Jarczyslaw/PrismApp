using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Sample
{
    public class SampleModule : ModuleBase
    {
        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.Sample, typeof(SampleView));
        }
    }
}
