using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using PrismApp.Core.Base;
using PrismApp.Modules.Notifications.Notifications;
using System;

namespace PrismApp.Modules.Notifications.ViewModels
{
    public class CustomConfirmationViewModel : ViewModelBase, IInteractionRequestAware
    {
        private ItemViewModel selectedItem;
        public ItemViewModel SelectedItem
        {
            get => selectedItem;
            set
            {
                SetProperty(ref selectedItem, value);
                SelectCommand.RaiseCanExecuteChanged();
            }
        }

        private ICustomConfirmation confirmation;
        public INotification Notification
        {
            get => confirmation;
            set => SetProperty(ref confirmation, (ICustomConfirmation)value);
        }

        public Action FinishInteraction { get; set; }

        public DelegateCommand SelectCommand { get; private set; }
        public DelegateCommand CancelCommand { get; private set; }

        public CustomConfirmationViewModel()
        {
            SelectCommand = new DelegateCommand(Select, () => SelectedItem != null);
            CancelCommand = new DelegateCommand(Cancel);
        }

        private void Select()
        {
            confirmation.SelectedItem = SelectedItem;
            confirmation.Confirmed = true;
            FinishInteraction?.Invoke();
        }

        private void Cancel()
        {
            confirmation.SelectedItem = null;
            confirmation.Confirmed = false;
            FinishInteraction?.Invoke();
        }
    }
}
