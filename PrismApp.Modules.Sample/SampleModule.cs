using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Sample
{
    public class SampleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(ModuleNames.Sample, typeof(SampleView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
