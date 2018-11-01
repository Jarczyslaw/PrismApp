using Prism.Regions;
using PrismApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Commands
{
    public class CommandsModule : ModuleBase
    {
        public override void RegisterRegion(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion(ModuleNames.Commands, typeof(CommandsView));
        }
    }
}
