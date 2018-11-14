using Prism.Commands;
using Prism.Regions;
using PrismApp.Core.Base;
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

        private Type selectedView = null;
        public Type SelectedView
        {
            get { return selectedView; }
            set
            {
                if (value != selectedView)
                    Navigate(value);
                SetProperty(ref selectedView, value);
            }
        }

        private IRegionManager regionManager;

        public RegionNavigationViewModel(IRegionManager regionManager)
        {
            Title = GetModuleTitle(Assembly.GetExecutingAssembly());

            this.regionManager = regionManager;

            NavigateCommand = new DelegateCommand<Type>(t => SelectedView = t);

            Views = new ObservableCollection<Type>
            {
                typeof(ViewA),
                typeof(ViewB),
                typeof(ViewC)
            };
        }

        private void Navigate(Type viewType)
        {
            if (viewType != null)
                regionManager.RequestNavigate(RegionNavigationModule.ContentRegion, viewType.Name, NavigationComplete);
        }

        private void NavigationComplete(NavigationResult result)
        {
            Debug.WriteLine($"Navigation to {result.Context.Uri} completed");
        }
    }
}
