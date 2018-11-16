using Prism.Regions;
using PrismApp.Core.Base;
using PrismApp.Core.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Modules.Common.ViewModels
{
    public class ViewCViewModel : ViewXViewModelBase, IConfirmNavigationRequest
    {
        private IDialogs dialogs;

        public ViewCViewModel(IDialogs dialogs)
        {
            this.dialogs = dialogs;

            Title = "ViewC";
        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            if (navigationContext.Uri.OriginalString == ViewsNames.ViewC)
            {
                continuationCallback(false);
                return;
            }
                
            continuationCallback(dialogs.ShowOkCancelQuestion("Do you really want to exit from ViewC?"));
        }
    }
}
