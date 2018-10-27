﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core
{
    public class ModuleBase : IModule
    {
        public virtual void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            RegisterRegion(regionManager);
        }

        public virtual void RegisterTypes(IContainerRegistry containerRegistry) { }
        public virtual void RegisterRegion(IRegionManager regionManager) { }
    }
}
