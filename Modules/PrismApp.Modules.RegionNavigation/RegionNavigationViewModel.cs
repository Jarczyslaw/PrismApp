using Prism.Commands;
using Prism.Regions;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.RegionNavigation
{
    public class RegionNavigationViewModel : ViewModelBase
    {
        public DelegateCommand<Type> NavigateCommand { get; private set; } 

        private IRegionManager regionManager;

        public RegionNavigationViewModel(IRegionManager regionManager)
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            this.regionManager = regionManager;

            NavigateCommand = new DelegateCommand<Type>(Navigate);
        }

        private void Navigate(Type viewType)
        {
            regionManager.RequestNavigate(RegionNavigationModule.ContentRegion, viewType.Name);
        }
    }
}
