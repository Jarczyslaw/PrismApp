using Prism.Regions;
using PrismApp.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Common.ViewModels
{
    public class ViewXViewModelBase : ViewModelBase, INavigationAware
    {
        public int pageViews = 0;
        public int PageViews
        {
            get { return pageViews; }
            set { SetProperty(ref pageViews, value); }
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext) { }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            PageViews++;
        }
    }
}
