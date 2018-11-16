using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core.UI.Services
{
    public interface IDialogs
    {
        bool ShowOkCancelQuestion(string question);
    }
}
