using Prism.Commands;
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
        public static string NavigationParameterName => nameof(NavigationParameterName);

        protected IRegionNavigationJournal journal;

        public int pageViews = 0;
        public int PageViews
        {
            get { return pageViews; }
            set { SetProperty(ref pageViews, value); }
        }

        public bool NavigationParameterPassed
        {
            get { return !string.IsNullOrEmpty(NavigationParameter); }
        }

        private string navigationParameter;
        public string NavigationParameter
        {
            get { return navigationParameter; }
            set
            {
                SetProperty(ref navigationParameter, value);
                RaisePropertyChanged(nameof(NavigationParameterPassed));
            }
        }

        public DelegateCommand GoBackCommand { get; private set; }

        public ViewXViewModelBase()
        {
            GoBackCommand = new DelegateCommand(GoBack, CanGoBack);
        }

        private bool CanGoBack()
        {
            return journal != null && journal.CanGoBack;
        }

        private void GoBack()
        {
            journal.GoBack();
        }

        #region INavigationAware implementation

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext) { }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            journal = navigationContext.NavigationService.Journal;

            PageViews++;

            if (navigationContext.Parameters[NavigationParameterName] is string parameter)
                NavigationParameter = parameter;
            else
                NavigationParameter = string.Empty;
        }

        #endregion
    }
}
