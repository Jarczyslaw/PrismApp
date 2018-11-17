using Prism.Commands;
using Prism.Regions;
using PrismApp.Core.Base;
using PrismApp.Modules.Common.ViewModels;
using PrismApp.Modules.Common.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.RegionNavigation
{
    public class RegionNavigationViewModel : ViewModelBase
    {
        public DelegateCommand<Type> NavigateCommand { get; private set; } 

        public ObservableCollection<Type> Views { get; private set; }

        private string navigationParameter;
        public string NavigationParameter
        {
            get { return navigationParameter; }
            set { SetProperty(ref navigationParameter, value); }
        }

        private IRegionManager regionManager;

        public RegionNavigationViewModel(IRegionManager regionManager)
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            this.regionManager = regionManager;

            NavigateCommand = new DelegateCommand<Type>(Navigate);

            Views = new ObservableCollection<Type>
            {
                typeof(ViewA),
                typeof(ViewB),
                typeof(ViewC)
            };
        }

        private void Navigate(Type viewType)
        {
            if (viewType == null)
                return;

            var region = regionManager.Regions[RegionNavigationModule.ContentRegion];
            var activeView = region.ActiveViews.FirstOrDefault();
            if (activeView != null && activeView.GetType() == viewType)
                return;

            var parameters = new NavigationParameters
            {
                { ViewXViewModelBase.NavigationParameterName, NavigationParameter }
            };
            regionManager.RequestNavigate(RegionNavigationModule.ContentRegion, viewType.Name, NavigationComplete, parameters);
        }

        private void NavigationComplete(NavigationResult result)
        {
            if (result.Result == true)
            {
                Debug.WriteLine($"Navigation to {result.Context.Uri} completed");
                NavigationParameter = string.Empty;
            }
        }
    }
}
