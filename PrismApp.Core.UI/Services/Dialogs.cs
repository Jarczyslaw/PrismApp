using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Core.UI.Services
{
    public class Dialogs : IDialogs
    {
        public bool ShowOkCancelQuestion(string question)
        {
            return MessageBox.Show(question, "Question", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK;
        }
    }
}
